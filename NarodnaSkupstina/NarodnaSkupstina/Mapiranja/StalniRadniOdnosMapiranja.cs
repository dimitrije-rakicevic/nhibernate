using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NarodnaSkupstina.Entiteti;
using FluentNHibernate.Mapping;

namespace NarodnaSkupstina.Mapiranja
{
    internal class StalniRadniOdnosMapiranja : SubclassMap<StalniRadniOdnos>
    {
        public StalniRadniOdnosMapiranja()
        {
            Table("STALNI_RADNI_ODNOS");

            KeyColumn("JIBNP");

            //DiscriminatorValue('Y');

            Map(x => x.BrRadneKnjizice, "BR_RADNE_KNJIZICE");
            Map(x => x.Godine, "GODINE");
            Map(x => x.Meseci, "MESECI");
            Map(x => x.Dani, "DANI");
            Map(x => x.ImePoslFirme, "IME_POSL_FIRME");
        }
    }
}
