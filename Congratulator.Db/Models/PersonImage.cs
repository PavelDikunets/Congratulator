using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Congratulator.Db.Models
{
    public class PersonImage
    {

        public int Id { get; set; }
        public string ImagePath { get; set; }

        public int ImageOfPersonId { get; set; }
        public Person Person { get; set; }
    }
}
