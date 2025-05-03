using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NarodnaSkupstina.Entiteti;
using FluentNHibernate.Mapping;

namespace NarodnaSkupstina.Mapiranja
{
    internal class SednicaMapiranja : ClassMap<Sednica>
    {
        public SednicaMapiranja()
        {
            Table("SEDNICA");

            DiscriminateSubClassesOnColumn("VANREDNAFLAG", 'N');

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojSednice, "BROJ_SEDNICE");
            Map(x => x.BrojSaziva, "BROJ_SAZIVA");
            Map(x => x.DatumPocetka, "DATUM_POCETKA");
            Map(x => x.DatumZavrsetka, "DATUM_ZAVRSETKA");

            HasMany(x => x.RadniDani).KeyColumn("SEDNICA_ID").LazyLoad().Cascade.All().Inverse();
        }
    }

    internal class VanrednaSednicaMapiranja : SubclassMap<VanrednaSednica>
    {
        public VanrednaSednicaMapiranja()
        {
            Table("SEDNICA");

            DiscriminatorValue('Y');

            Map(x => x.Inicijator, "INICIJATOR");

            HasManyToMany(x => x.Poslanici)
                .Table("POSLANICKI_ZAHTEV_SEDNICE")
                .ParentKeyColumn("SEDNICA_ID")
                .ChildKeyColumn("JIBNP")
                .Cascade.All();
        }
    }
}
