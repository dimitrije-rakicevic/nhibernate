using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarodnaSkupstina.Entiteti
{
    public class RadniDan
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime VremPeriodRadaOd { get; set; }
        public virtual DateTime VremPeriodRadaDo { get; set; }
        public virtual int BrojPrisutnih { get; set; }
        public virtual Sednica Sednica { get; set; }
    }
}
