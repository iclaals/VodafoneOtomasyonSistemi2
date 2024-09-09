using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GörselProgramlamaFinal.Model
{
    public class VodafoneDbEntities : DbContext
    {
        public VodafoneDbEntities()
            : base("name=VodafoneDbEntities")
        {
        }

        public virtual DbSet<Alisveris> Alisverisler { get; set; }
        public virtual DbSet<Hats> Hatlar { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Modems> Modemler { get; set; }
    }
}
