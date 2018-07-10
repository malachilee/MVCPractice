using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCpractice2.Models
{
    public class VitrualPet
    {
        [Key]
        public int VituralPetID { get; set; }
        [DisplayName("Name of Pet")]
        public string Name { get; set; }
        [DisplayName("Age of Pet")]
        public int Age { get; set; }
        [DisplayName("Hunger Level")]
        public int Hunger { get; set; }
        [DisplayName("Type Of Pet")]
        public string Type { get; set; }
        [DisplayName("Thirst Level")]
        public int Thrist { get; set; }

    }
}