using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFromCSV
{
    internal class Iris
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public double Sepallength { get; set; }
        [Required]
        public double SepalWidth { get; set; }
        [Required]
        public double Petallength { get; set; }
        [Required]
        public double PetalWidth { get; set; }
        [Required]
        public string? Variety { get; set; }
    }
}
