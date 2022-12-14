using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientCRUD.Models.Entities
{
    public class Patient
    {
        [Key]
        [MaxLength(5)]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        public string Name { get => FirstName + " " + LastName; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
       


    }
}
