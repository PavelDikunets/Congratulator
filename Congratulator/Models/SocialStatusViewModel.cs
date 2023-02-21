using System.ComponentModel.DataAnnotations;

namespace Congratulator.WebApp.Models
{
    public enum SocialStatusViewModel
    {
        [Display(Name = "Знакомый")]
        Familiar,

        [Display(Name = "Сотрудник")]
        Employee,

        [Display(Name = "Друг")]
        Friend,
    }
}
