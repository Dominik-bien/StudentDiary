using System.Data;

namespace StudentDiary
{
    public partial class AddEditStudent : Form
    {
        private int _studentId;
        private Student _student;
        private FileHelper<List<Student>> _fileHelper = new FileHelper<List<Student>>(Program.FilePath);

        public AddEditStudent(int Id = 0)
        {
            InitializeComponent();
            _studentId = Id;
            InitializeComboBox();
            GetStudentData();
            tbName.Select();
        }

        private void InitializeComboBox()
        {
            cmbClass.DataSource = new List<string> { "1", "2", "3" }; 
        }

        private void GetStudentData()
        {
            if (_studentId != 0)
            {
                Text = "Edit Student";
                var students = _fileHelper.DeserializeFromFile();
                _student = students.FirstOrDefault(x => x.Id == _studentId);

                if (_student == null)
                    throw new Exception("No user with the specified Id");

                FillTextBoxes();
            }
            tbName.Select();
        }

        private void FillTextBoxes()
        {
            tbId.Text = _student.Id.ToString();
            tbName.Text = _student.Name;
            tbSurname.Text = _student.Surname;
            tbPolish.Text = _student.Polish;
            tbEnglish.Text = _student.English;
            tbTechnology.Text = _student.Technology;
            tbPsysics.Text = _student.Psysics;
            rtbComments.Text = _student.Comments;
            cbExtraActivites.Checked = _student.Extra;
            cmbClass.SelectedItem = _student.IdGroup.ToString();
        }

        private async void btnApply_Click(object sender, EventArgs e)
        {
            var students = _fileHelper.DeserializeFromFile() ?? new List<Student>();

            if (_studentId != 0)
                students.RemoveAll(x => x.Id == _studentId);
            else
                AssignToIdStudent(students);

            AddNewUserToList(students);
            _fileHelper.SerializeToFile(students);

            await LongProcessAsync();
            Close();
        }

        private async Task LongProcessAsync()
        {
            await Task.Run(() => Thread.Sleep(3000));
        }

        private void AddNewUserToList(List<Student> students)
        {
            var student = new Student
            {
                Id = _studentId,
                Name = tbName?.Text ?? string.Empty,
                Surname = tbSurname?.Text ?? string.Empty,
                Math = tbMath?.Text ?? "0",
                Polish = tbPolish?.Text ?? "0",
                English = tbEnglish?.Text ?? "0",
                Psysics = tbPsysics?.Text ?? "0",
                Technology = tbTechnology?.Text ?? "0",
                Comments = rtbComments?.Text ?? string.Empty,
                Extra = cbExtraActivites?.Checked ?? false,
                IdGroup = int.TryParse(cmbClass.SelectedItem?.ToString(), out int idGroup) ? idGroup : 0
            };

            students.Add(student);
        }

        private void AssignToIdStudent(List<Student> students)
        {
            var studentsWithHighestId = students.OrderByDescending(x => x.Id).FirstOrDefault();
            _studentId = studentsWithHighestId == null ? 1 : studentsWithHighestId.Id + 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}