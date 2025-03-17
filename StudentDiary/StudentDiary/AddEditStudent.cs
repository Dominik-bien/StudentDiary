
using System.Data;


namespace StudentDiary
{

    public partial class AddEditStudent : Form
    {



        private int _studentId;
        private Student _student;


        private FileHelper<List<Student>> _fileHelper =
            new FileHelper<List<Student>>
            (Program.FilePath);

        public AddEditStudent(int Id = 0)
        {

            InitializeComponent();
            _studentId = Id;
            GetStudentData();

            tbName.Select();
        }



        private void GetStudentData()
        {
            if (_studentId != 0)
            {
                Text = "Edit Student";
                var students = _fileHelper.DeserializeFromFile();
                _student = students.FirstOrDefault(x => x.Id == _studentId);

                if (_student == null)
                    throw new Exception("no user with the specified Id");

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
            rtbComments.Text = _student.Comments;
            tbEnglish.Text = _student.English;
            tbTechnology.Text = _student.Technology;
            tbPsysics.Text = _student.Psysics;
        }





        private async void btnApply_Click(object sender, EventArgs e)
        {
            var students = _fileHelper.DeserializeFromFile();

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
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
            });
        }

        private void AddNewUserToList(List<Student> students)
        {
            var student = new Student
            {
                Id = _studentId,
                Name = tbName.Text,
                Surname = tbSurname.Text,
                Math = tbMath.Text,
                Comments = rtbComments.Text,
                Polish = tbPolish.Text,
                English = tbEnglish.Text,
                Psysics = tbPsysics.Text,
                Technology = tbTechnology.Text
            };

            students.Add(student);
        }

        private void AssignToIdStudent(List<Student> students)
        {
            var studentsWithHighestId = students
                   .OrderByDescending(x => x.Id).FirstOrDefault();


            _studentId = studentsWithHighestId == null ?
                1 : studentsWithHighestId.Id + 1;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
