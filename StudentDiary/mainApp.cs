using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StudentDiary
{
    public partial class mainApp : Form
    {

        private string _filePath =
            Path.Combine(Environment.CurrentDirectory, "students.txt");


        public mainApp()
        {
            InitializeComponent();
            var students = DeserializeFromFile();
            dgvDiary.DataSource = students;

        }

        public void SerializeToFile2(List<Student> students)
        {
            var serializer = new XmlSerializer(typeof(List<Student>));

            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, students);
                streamWriter.Close();
            }

        }

        public List<Student> DeserializeFromFile()
        {

            if (!File.Exists(_filePath))
                return new List<Student>();

            var serializer = new XmlSerializer(typeof(List<Student>));


            using (var streamReader = new StreamReader(_filePath))
            {
                var students = (List<Student>)serializer.Deserialize(streamReader);
                streamReader.Close();
                return students;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditStudent = new AddEditStudent();
            addEditStudent.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please mark the student, whose you want edit");
                return;
            }

            var addEditStudent = new AddEditStudent(
                Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value));
            addEditStudent.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please mark the student, whose you want delete");
                return;
            }

            var selectedStudent = dgvDiary.SelectedRows[0];

            var confirmDelete = MessageBox.Show($"Do you want to delete student {selectedStudent.Cells[1].Value.ToString() + " " + selectedStudent.Cells[2].Value.ToString().Trim()}", "Remove student", MessageBoxButtons.OKCancel);

            if (confirmDelete == DialogResult.OK)
            {
                var students = DeserializeFromFile();
                students.RemoveAll(x => x.ID == Convert.ToInt32(selectedStudent.Cells[0].Value));
                SerializeToFile2(students);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var students = DeserializeFromFile();
            dgvDiary.DataSource = students;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
