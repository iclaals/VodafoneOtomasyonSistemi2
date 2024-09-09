using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GörselProgramlamaFinal.Model
{
    public class Alisveris
    {
        [Key]

        public int UrunId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int Fiyat { get; set; }
    }
}
