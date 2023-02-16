namespace Congratulator.Models
{
    public partial class PersonViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public SocialStatusViewModel SocialStatus { get; set; }
    }
}
