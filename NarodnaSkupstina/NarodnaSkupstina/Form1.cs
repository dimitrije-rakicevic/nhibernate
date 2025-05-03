using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NarodnaSkupstina.Entiteti;
using NHibernate.Criterion;

namespace NarodnaSkupstina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUcitavanjePoslanika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NarodniPoslanik np = s.Load<NarodniPoslanik>(2);
                MessageBox.Show(np.LicnoIme + " " + np.Prezime);

                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodavanjePoslanika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StalniRadniOdnos np = new StalniRadniOdnos();
                
                np.Jmbg = 1234567890999;
                np.LicnoIme = "Aleksa";
                np.ImeRoditelja = "Andrija";
                np.Prezime = "Acimovic";
                np.IzbornaLista = "DS";
                np.DatumRodj = new DateTime(1987,1, 4);
                np.MestoRodj = "Nis";
                np.Ulica = "Desanke Maksimovic";
                np.Broj = 3;
                np.Mesto = "Nis";
                np.BrTel = "018383014";
                np.BrMobTel = "0655678111";
                np.StalniRadniOdnosFlag = 'Y';
                np.BrRadneKnjizice = 19129;
                np.Godine = 3;
                np.Meseci = 11;
                np.Dani = 22;
                np.ImePoslFirme = "LEONI";


                s.Save(np);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnIzmenaPoslanika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NarodniPoslanik np = s.Load<NarodniPoslanik>(14);
                np.Broj = 18;

                s.Save(np);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnBrisanjePoslanika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NarodniPoslanik np = s.Load<NarodniPoslanik>(39);

                s.Delete(np);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnManyToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NarodniPoslanik np = s.Load<NarodniPoslanik>(2);

                MessageBox.Show(np.LicnoIme + " " + np.Prezime + " " + np.ClanPG.JedinstvenoIme);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoslanickaGrupa pg = s.Load<PoslanickaGrupa>(1);

                foreach (NarodniPoslanik np in pg.Clanovi)
                {
                    MessageBox.Show(np.LicnoIme + " " + np.Prezime);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodavanjePG_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NarodniPoslanik np1 = s.Load<NarodniPoslanik>(3);
                NarodniPoslanik np2 = s.Load<NarodniPoslanik>(10);
                NarodniPoslanik np3 = s.Load<NarodniPoslanik>(14);

                PoslanickaGrupa pg = new PoslanickaGrupa();
                pg.JedinstvenoIme = "JS";
                
                np1.ClanPG = pg;
                np2.ClanPG = pg;
                np3.ClanPG = pg;
                np1.PredsednikPG = pg;
                np2.ZamenikPG = pg;

                pg.Predsednik = np1;
                pg.Zamenik = np2;
                pg.Clanovi.Add(np1);
                pg.Clanovi.Add(np2);
                pg.Clanovi.Add(np3);

                s.Save(pg);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnManyToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PredlogPoslanika p = s.Load<PredlogPoslanika>(3);

                foreach (NarodniPoslanik np in p.Poslanici)
                {
                    MessageBox.Show(np.LicnoIme + " " + np.Prezime);
                }

                NarodniPoslanik np2 = s.Load<NarodniPoslanik>(5);

                foreach (PredlogPoslanika p2 in np2.PravniAkti)
                {
                    MessageBox.Show(p2.TipPravnogAkta);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodavanjePA_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PredlogPoslanika p1 = s.Load<PredlogPoslanika>(6);
                PredlogPoslanika p2 = s.Load<PredlogPoslanika>(7);
                PredlogPoslanika p3 = s.Load<PredlogPoslanika>(8);

                NarodniPoslanik np1 = s.Load<NarodniPoslanik>(1);
                NarodniPoslanik np2 = s.Load<NarodniPoslanik>(2);
                NarodniPoslanik np3 = s.Load<NarodniPoslanik>(3);
                NarodniPoslanik np4 = s.Load<NarodniPoslanik>(4);
                NarodniPoslanik np5 = s.Load<NarodniPoslanik>(5);
                NarodniPoslanik np6 = s.Load<NarodniPoslanik>(6);
                NarodniPoslanik np7 = s.Load<NarodniPoslanik>(7);
                NarodniPoslanik np8 = s.Load<NarodniPoslanik>(8);
                NarodniPoslanik np9 = s.Load<NarodniPoslanik>(9);
                NarodniPoslanik np10 = s.Load<NarodniPoslanik>(10);
                NarodniPoslanik np11 = s.Load<NarodniPoslanik>(11);
                NarodniPoslanik np12 = s.Load<NarodniPoslanik>(12);

                p1.Poslanici.Add(np1);
                p1.Poslanici.Add(np3);
                p1.Poslanici.Add(np5);
                p1.Poslanici.Add(np7);
                p1.Poslanici.Add(np9);
                np1.PravniAkti.Add(p1);
                np3.PravniAkti.Add(p1);
                np5.PravniAkti.Add(p1);
                np7.PravniAkti.Add(p1);
                np9.PravniAkti.Add(p1);

                p2.Poslanici.Add(np2);
                p2.Poslanici.Add(np4);
                p2.Poslanici.Add(np6);
                p2.Poslanici.Add(np8);
                p2.Poslanici.Add(np10);
                np2.PravniAkti.Add(p2);
                np4.PravniAkti.Add(p2);
                np6.PravniAkti.Add(p2);
                np8.PravniAkti.Add(p2);
                np10.PravniAkti.Add(p2);

                p3.Poslanici.Add(np1);
                p3.Poslanici.Add(np3);
                p3.Poslanici.Add(np11);
                p3.Poslanici.Add(np12);
                p3.Poslanici.Add(np8);
                np1.PravniAkti.Add(p3);
                np3.PravniAkti.Add(p3);
                np11.PravniAkti.Add(p3);
                np12.PravniAkti.Add(p3);
                np8.PravniAkti.Add(p3);

                s.Save(p1);
                s.Save(p2);
                s.Save(p3);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnOneToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prostorija p = new Prostorija()
                {
                    Id = 10,
                    Sprat = 3,
                };

                NarodniPoslanik np1 = s.Load<NarodniPoslanik>(9);
                NarodniPoslanik np2 = s.Load<NarodniPoslanik>(10);

                RadnoTelo rt = new RadnoTelo()
                {
                    TipRadnogTela = "PRIVREMENI ODBOR",
                    Predsednik = np1,
                    Zamenik = np2,
                    Prostorija = p                   
                };

                rt.Clanovi.Add(np1);
                rt.Clanovi.Add(np2);

                np1.ClanRT = rt;
                np2.ClanRT = rt;

                p.RadnoTelo = rt;

                s.Save(rt);
                s.Save(p);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodavanjeRT_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NarodniPoslanik np1 = s.Load<NarodniPoslanik>(1);
                NarodniPoslanik np2 = s.Load<NarodniPoslanik>(8);
                NarodniPoslanik np3 = s.Load<NarodniPoslanik>(6);

                Prostorija p = s.Load<Prostorija>(1);

                RadnoTelo rt = new RadnoTelo();
                rt.TipRadnogTela = "ANKETNI ODBOR";
                rt.Prostorija = p;

                np1.ClanRT = rt;
                np2.ClanRT = rt;
                np3.ClanRT = rt;
                np1.PredsednikRT = rt;
                np2.ZamenikRT = rt;

                rt.Predsednik = np1;
                rt.Zamenik = np2;
                rt.Clanovi.Add(np1);
                rt.Clanovi.Add(np2);
                rt.Clanovi.Add(np3);

                s.Save(rt);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnTPH_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<PravniAkt> pravniAkti = s.QueryOver<PravniAkt>()
                                                    .List<PravniAkt>();

                foreach (PravniAkt pa in pravniAkti)
                {
                    if (pa.GetType() == typeof(PredlogPoslanika))
                    {
                        PredlogPoslanika pp = (PredlogPoslanika)pa;
                    }
                    else if (pa.GetType() == typeof(PredlogBiraca))
                    {
                        PredlogBiraca pb = (PredlogBiraca)pa;
                    }
                    else
                    {
                        PredlogVlade pv = (PredlogVlade)pa;
                    }
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnCreateSubclassPA_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PredlogBiraca pb = new PredlogBiraca()
                {
                    TipPravnogAkta = "DEKLARACIJA",
                    BrojBiraca = 71012
                };

                s.Save(pb);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NarodniPoslanik np = s.Get<NarodniPoslanik>(7);

                if (np != null)
                {
                    MessageBox.Show(np.ClanRT.TipRadnogTela);
                }
                else
                {
                    MessageBox.Show("NE POSTOJI POSLANIK SA ZADATIM ID-JEM");
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PravniAkt p = s.Get<PravniAkt>(2);

                s.Refresh(p);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnFind1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("From Sednica");

                IList<Sednica> sednice = q.List<Sednica>();

                foreach (Sednica se in sednice)
                {
                    MessageBox.Show(se.DatumPocetka + " --- " + se.DatumZavrsetka);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnFind2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Sednica as se where se.Id < 4");

                IList<Sednica> sednice = q.List<Sednica>();

                foreach (Sednica se in sednice)
                {
                    MessageBox.Show(se.DatumPocetka + " --- " + se.DatumZavrsetka);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUpitiSaParametrima_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from PravniAkt as pa where pa.TipPravnogAkta = ? and pa.Id > ?");
                q.SetParameter(0, "ZAKON");
                q.SetParameter(1, 2);


                IList<PravniAkt> akti = q.List<PravniAkt>();

                foreach (PravniAkt pa in akti)
                {
                    MessageBox.Show(pa.TipPravnogAkta);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnImenovaniParametriUpit_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select pa.Poslanici from PravniAkt as pa where pa.TipPravnogAkta = :tip and pa.Id >= :id");
                q.SetString("tip", "ODLUKA");
                q.SetInt32("id", 6);


                IList<NarodniPoslanik> poslanici = q.List<NarodniPoslanik>();

                foreach (NarodniPoslanik np in poslanici)
                {
                    MessageBox.Show(np.LicnoIme + " " + np.Prezime);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnImenovaniParametriUpit2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select pg.Predsednik from PoslanickaGrupa as pg" +
                                         " where pg.Predsednik.MestoRodj = :mesto and pg.JedinstvenoIme = :ime");
                q.SetString("mesto", "Beograd");
                q.SetString("ime", "ZND");


                IList<NarodniPoslanik> nps = q.List<NarodniPoslanik>();

                foreach (NarodniPoslanik np in nps)
                {
                    MessageBox.Show(np.LicnoIme + " " + np.Prezime);
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnEnumerable_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from PravniAkt");

                IEnumerable<PravniAkt> akti = q.Enumerable<PravniAkt>();

                foreach (PravniAkt p in akti)
                {
                    if (p.TipPravnogAkta == "DEKLARACIJA")
                        break;
                    MessageBox.Show(p.Id + " " + p.TipPravnogAkta);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnSkalarniRez_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select sum(rd.BrojPrisutnih) from RadniDan rd ");

                Int64 prisutni = q.UniqueResult<Int64>();

                MessageBox.Show(prisutni.ToString());

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUniqRes_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select se from Sednica se where se.Id = 2");

                //za slucaj da upit vraca samo jednu vrednost
                Sednica se = q.UniqueResult<Sednica>();

                MessageBox.Show(se.BrojSednice.ToString());

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVisestrukiRez_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select rd.VremPeriodRadaOd, rd.VremPeriodRadaDo, rd.BrojPrisutnih" +
                                         " from RadniDan rd order by rd.BrojPrisutnih");

                //za slucaj da upit vraca visestruku vrednost
                IList<object[]> result = q.List<object[]>();

                foreach (object[] r in result)
                {
                    DateTime vremeOd = (DateTime)r[0];
                    DateTime vremeDo = (DateTime)r[1];
                    int prisutni = (int)r[2];
                    MessageBox.Show(vremeOd + " " + " " + vremeDo + " " + prisutni);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnPaging_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from NarodniPoslanik");
                q.SetFirstResult(9);
                q.SetMaxResults(2);

                IList<NarodniPoslanik> nps = q.List<NarodniPoslanik>();

                foreach (NarodniPoslanik np in nps)
                {
                    MessageBox.Show(np.Id.ToString() + " " + np.LicnoIme + " " + np.Prezime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCriteria_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<NarodniPoslanik>();
                DateTime date = new DateTime(1970, 1, 1);
                c.Add(Expression.Eq("MestoRodj", "Beograd"));
                c.Add(Expression.Ge("DatumRodj", date));

                IList<NarodniPoslanik> nps = c.List<NarodniPoslanik>();

                foreach (NarodniPoslanik np in nps)
                {
                    MessageBox.Show(np.LicnoIme + " " + np.Prezime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdQueryOver_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<RadniDan> rds = s.QueryOver<RadniDan>()
                                                .Where(x => x.BrojPrisutnih >= 125)
                                                .Where(x => x.Id >= 5)
                                                .List<RadniDan>();

                foreach (RadniDan rd in rds)
                {
                    MessageBox.Show(rd.VremPeriodRadaOd + "-" + rd.VremPeriodRadaDo);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnNativeSql_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ISQLQuery q = s.CreateSQLQuery("SELECT PG.* FROM POSLANICKA_GRUPA PG");
                q.AddEntity(typeof(PoslanickaGrupa));


                IList<PoslanickaGrupa> pgs = q.List<PoslanickaGrupa>();

                foreach (PoslanickaGrupa pg in pgs)
                {
                    MessageBox.Show(pg.Id.ToString() + " " + pg.JedinstvenoIme);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadnoTelo rt = s.Load<RadnoTelo>(1);

                s.Close();

                rt.TipRadnogTela = "ANKETNI ODBOR";

                ISession s1 = DataLayer.GetSession();

                s1.Update(rt);

                s1.Flush();
                s1.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadniDan rd = s.Load<RadniDan>(2);

                s.Delete(rd);

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadniDan rd = s.Load<RadniDan>(10);

                ITransaction t = s.BeginTransaction();

                s.Delete(rd);

                //t.Commit();
                t.Rollback();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnLinq_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<RadniDan> rds = (from rd in s.Query<RadniDan>()
                                              where (rd.BrojPrisutnih >= 125 && rd.Sednica.Id == 2)
                                              select rd).ToList<RadniDan>();

                foreach (RadniDan rd in rds)
                {
                    MessageBox.Show(rd.Id.ToString() + " " + rd.VremPeriodRadaOd + " " + rd.VremPeriodRadaDo);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnLinq1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PravniAkt> akti = from pa in s.Query<PravniAkt>()
                                                  where (pa.TipPravnogAkta == "ZAKON" || pa.TipPravnogAkta == "ODLUKA")
                                                  orderby pa.TipPravnogAkta
                                                  select pa;

                foreach (PravniAkt pa in akti)
                {
                    MessageBox.Show(pa.Id.ToString() + " " + pa.TipPravnogAkta);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnLinq2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PravniAkt> akti = s.Query<PravniAkt>()
                                                    .Where(pa => (pa.TipPravnogAkta == "ZAKON" || pa.TipPravnogAkta == "ODLUKA"))
                                                    .OrderBy(pa => pa.TipPravnogAkta)
                                                    .Select(pa => pa);

                foreach (PravniAkt pa in akti)
                {
                    MessageBox.Show(pa.Id.ToString() + " " + pa.TipPravnogAkta);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
