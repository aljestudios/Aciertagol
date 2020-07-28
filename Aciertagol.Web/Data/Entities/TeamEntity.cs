using System.ComponentModel.DataAnnotations;

namespace Aciertagol.Web.Data.Entities
{
    public class TeamEntity
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
         public string Name { get; set; }

        [Display(Name="logo")]

        public string LogoPath { get; set; }
    }
}
