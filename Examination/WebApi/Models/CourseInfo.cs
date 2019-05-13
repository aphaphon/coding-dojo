using System.Collections.Generic;

namespace WebApi.Models
{
    public class CourseInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Credit { get; set; }
        public List<ScoringCriteria> Criteria { get; set; }

        public CourseInfo(string id, string name, double credit)
        {
            this.Id = id;
            this.Name = name;
            this.Credit = credit;
        }
    }
}