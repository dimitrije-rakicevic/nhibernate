using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarodnaSkupstina.Entiteti
{
    public abstract class PravniAkt
    {
        public virtual int Id { get; protected set; }
        public virtual string TipPravnogAkta { get; set; }
        public virtual string Predlozio { get; set; }
    }

    public class PredlogPoslanika : PravniAkt
    {
        public virtual IList<NarodniPoslanik> Poslanici { get; set; }
        public PredlogPoslanika()
        {
            Poslanici = new List<NarodniPoslanik>();
        }
    }

    public class PredlogBiraca : PravniAkt
    {
        public virtual int BrojBiraca { get; set; }
    }

    public class PredlogVlade : PravniAkt
    {
    }
}
