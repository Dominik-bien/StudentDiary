namespace StudentDiary
{
    static class Program
    {
        public static string FilePath =
            Path.Combine(Environment.CurrentDirectory, "students.txt");
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}