using System.ComponentModel.DataAnnotations;

namespace Congratulator.WebApp.Models
{
    public partial class PersonViewModel
    {
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string? ImagePath { get; set; }

        public IFormFile? UploadedFIle { get; set; }

        public SocialStatusViewModel SocialStatus { get; set; }

        public PersonViewModel()
        {
            SocialStatus = SocialStatusViewModel.Familiar;
        }
    }
}
