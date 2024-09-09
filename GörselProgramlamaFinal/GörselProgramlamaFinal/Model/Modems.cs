﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GörselProgramlamaFinal.Model
{
    public class Modems
    {
        [Key]

        public int ModemId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Kimlik { get; set; }
        public string Sehir { get; set; }
    }
}
