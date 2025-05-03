using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NarodnaSkupstina.Entiteti;
using FluentNHibernate.Mapping;

namespace NarodnaSkupstina.Mapiranja
{
    internal class PoslanickaGrupaMapiranja : ClassMap<PoslanickaGrupa>
    {
        public PoslanickaGrupaMapiranja()
        {
            Table("POSLANICKA_GRUPA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.JedinstvenoIme, "JEDINSTVENO_IME");
            
            HasMany(x => x.Clanovi).KeyColumn("ID_PG").LazyLoad().Cascade.All().Inverse();

            References(x => x.Predsednik).Column("JIBNPP").LazyLoad();
            References(x => x.Zamenik).Column("JIBNPZ").LazyLoad();

            HasMany(x => x.Prostorije).KeyColumn("ID_PG").LazyLoad().Cascade.All().Inverse();
        }
    }
}
