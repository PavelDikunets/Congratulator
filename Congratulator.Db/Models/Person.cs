namespace Congratulator.Db.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public SocialStatus SocialStatus { get; set; }

        public Person()
        {
            SocialStatus = SocialStatus.Familiar;
        }
    }
}
