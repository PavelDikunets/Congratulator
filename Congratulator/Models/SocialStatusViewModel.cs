using System.ComponentModel.DataAnnotations;

namespace Congratulator.Models
{
    public enum SocialStatusViewModel
    {
        [Display(Name = "Знакомые")]
        Familiar,

        [Display(Name = "Сотрудники")]
        Employee,

        [Display(Name = "Друзья")]
        Friend,
    }
}
