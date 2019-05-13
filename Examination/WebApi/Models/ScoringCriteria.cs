namespace WebApi.Models
{
    public class ScoringCriteria
    {
        public string Grade { get; set; }
        public int RequiredScore { get; set; }

        public ScoringCriteria(string grade, int requiredScore)
        {
            this.Grade = grade;
            this.RequiredScore = requiredScore;
        }
    }
}