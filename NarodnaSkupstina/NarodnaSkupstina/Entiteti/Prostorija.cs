using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarodnaSkupstina.Entiteti
{
    public class Prostorija
    {
        public virtual int Id { get; set; }
        public virtual int Sprat { get; set; }
        public virtual RadnoTelo RadnoTelo { get; set; }
        public virtual PoslanickaGrupa PoslanickaGrupa { get; set; }
    }
}
