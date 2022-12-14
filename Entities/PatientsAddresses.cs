using PatientCRUD.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientCRUD.Entities
{
    public class PatientsAddresses
    {
        [Key]
        [MaxLength(3)]
        public int Id { get; set; }
        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }
        public int PatientId { get; set; }
        [MaxLength(30)]
        public string Street { get; set; }
        [MaxLength(2)]
        public int StreetNumber { get; set; }
        [MaxLength(2)]
        public int? Floor { get; set; }
        [MaxLength(2)]
        public string? Apartment { get; set; }
        public string Address { get => Street + " " + StreetNumber; }


    }
}
