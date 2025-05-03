using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NarodnaSkupstina.Entiteti;
using FluentNHibernate.Mapping;

namespace NarodnaSkupstina.Mapiranja
{
    internal class ProstorijaMapiranja : ClassMap<Prostorija>
    {
        public ProstorijaMapiranja()
        {
            Table("PROSTORIJA");

            Id(x => x.Id, "BROJ_PROSTORIJE").GeneratedBy.Assigned();

            Map(x => x.Sprat, "SPRAT");

            HasOne(x => x.RadnoTelo).PropertyRef(x => x.Prostorija);

            References(x => x.PoslanickaGrupa).Column("ID_PG").LazyLoad();
        }
    }
}
