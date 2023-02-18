using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Congratulator.Db.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        public SocialStatus Status { get; set; }
    }
}
