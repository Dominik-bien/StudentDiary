
using StudentDiary.Properties;

namespace StudentDiary
{
    public partial class Main : Form
    {
        private delegate void DisplayMessage(string message);


        private FileHelper<List<Student>> _fileHelper =
            new FileHelper<List<Student>>
            (Program.FilePath);

        public bool IsMaximize
        {
            get
            {
                return Settings.Default.IsMaximize;
            }
            set
            {
                Settings.Default.IsMaximize = value;
            }
        }

        public Main()
        {

            InitializeComponent();
            RefreshDiary();
            SetColumnsHeader();

            if (IsMaximize)
                WindowState = FormWindowState.Maximized;

        }

        private void SetColumnsHeader()
        {
            dgvDiary.Columns[0].HeaderText = "Number";
            dgvDiary.Columns[1].HeaderText = "Name";
            dgvDiary.Columns[2].HeaderText = "Surname";
            dgvDiary.Columns[3].HeaderText = "Math";
            dgvDiary.Columns[4].HeaderText = "Polish";
            dgvDiary.Columns[5].HeaderText = "English";
            dgvDiary.Columns[6].HeaderText = "Technology";
            dgvDiary.Columns[7].HeaderText = "Psysics";
            dgvDiary.Columns[8].HeaderText = "Comments";

        }

        private void RefreshDiary()
        {
            var students = _fileHelper.DeserializeFromFile();
            dgvDiary.DataSource = students;
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEdtiStudent = new AddEditStudent();
            addEdtiStudent.FormClosing += AddEdtiStudent_FormClosing;
            addEdtiStudent.ShowDialog();
        }

        private void AddEdtiStudent_FormClosing(object? sender, FormClosingEventArgs e)
        {
            RefreshDiary();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select the student you want to edit");
                return;
            }

            var addEditStudent = new AddEditStudent(
                Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value));
            addEditStudent.FormClosing += AddEdtiStudent_FormClosing;

            addEditStudent.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select the student you want to delete");
                return;
            }

            var selectedStudent =
                dgvDiary.SelectedRows[0];
            var confirmDelete = MessageBox.Show($"Do you want remove: {(selectedStudent.Cells[1].Value.ToString() + " " + selectedStudent.Cells[2].Value.ToString()).Trim()}?",
                 "Removing Student", MessageBoxButtons.OKCancel);

            if (confirmDelete == DialogResult.OK)
            {
                DeleteStudent(Convert.ToInt32(selectedStudent.Cells[0].Value));
                RefreshDiary();
            }


        }

        private void DeleteStudent(int Id)
        {
            var students = _fileHelper.DeserializeFromFile();
            students.RemoveAll(x => x.Id == Id);
            _fileHelper.SerializeToFile(students);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            RefreshDiary();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)

                IsMaximize = true;
            else
                IsMaximize = false;

            Settings.Default.Save();

        }
    }
}
