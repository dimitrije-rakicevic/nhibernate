using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarodnaSkupstina.Entiteti
{
    public class Sednica
    {
        public virtual int Id { get; protected set; }
        public virtual int BrojSednice { get; set; }
        public virtual int BrojSaziva { get; set; }
        public virtual DateTime DatumPocetka { get; set; }
        public virtual DateTime DatumZavrsetka { get; set; }
        public virtual char VanrednaFlag { get; set; }
        public virtual IList<RadniDan> RadniDani { get; set; }
        public Sednica()
        {
            RadniDani = new List<RadniDan>();
        }
    }

    public class VanrednaSednica : Sednica
    {
        public virtual string Inicijator { get; set; }
        public virtual IList<NarodniPoslanik> Poslanici { get; set; }

        public VanrednaSednica()
        {
            Poslanici = new List<NarodniPoslanik>();
        }
    }
}
