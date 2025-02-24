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
    public partial class AddEditStudent : Form
    {
        private int _studentID;
        private string _filePath =
            Path.Combine(Environment.CurrentDirectory, "students.txt");

        public AddEditStudent(int ID = 0)
        {
            InitializeComponent();
            _studentID = ID; 

            if (ID != 0)
            {
                var students = DeserializeFromFile();
                var student = students.FirstOrDefault(x => x.ID == ID);

                if (student == null)
                    throw new Exception("no student about specific ID");


                tbID.Text = student.ID.ToString();
                tbName.Text = student.FirstName;
                tbSurname.Text = student.LastName;
                tbMath.Text = student.Math;
                tbPsysics.Text = student.Psysichs;
                tbPolish.Text = student.Polish;
                tbEnglish.Text = student.English;
                rtbComments.Text = student.Comments;
            }
            tbName.Select();
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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AddEditStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var students = DeserializeFromFile();

            if (_studentID != 0)
            {
                students.RemoveAll(x => x.ID == _studentID);
            }
            else
            {
                var studentWithHighestId = students
                   .OrderByDescending(x => x.ID).FirstOrDefault();

                _studentID = studentWithHighestId == null ? 1 : studentWithHighestId.ID + 1;
            }
               

            var student = new Student()
            {
                ID = _studentID,
                FirstName = tbName.Text,
                LastName = tbSurname.Text,
                Comments = rtbComments.Text,
                English = tbEnglish.Text,
                Polish = tbPolish.Text,
                Technology = tbTechnology.Text,
                Math = tbMath.Text
            };

            students.Add(student);

            SerializeToFile2(students);

            Close();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
