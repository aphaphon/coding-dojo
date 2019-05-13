namespace WebApi.Models
{
    public class StudentInfo
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string FacultyName { get; set; }
        
        public StudentInfo(string id, string fullName, string facultyName)
        {
            this.Id = id;
            this.FullName = fullName;
            this.FacultyName = facultyName;

        }
    }
}