namespace JobsBoardWebApp.Models
{
    public class Job
    {
        public int Id { get; set; }

        public string JobTitle { get; set; }

        public string JobDescription { get; set; }

        public string JobLocation { get; set; }

        public string JobCompanyName { get; set; }

        public int JobSalary { get; set; }

        public string JobEmailAddress { get; set; }

        public string JobTelephone { get; set; }

        public Job()
        {

        }
    }
}
