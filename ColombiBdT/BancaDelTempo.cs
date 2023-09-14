using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace ColombiBdT
{
    public class BancaDelTempo
    {
        public List<Prestazione> RegistroPrestazioni;
        public List<Socio> ElencoSoci;
        public BancaDelTempo()
        {
            RegistroPrestazioni = new List<Prestazione>();
            ElencoSoci = new List<Socio>();
        }
        public void Scrivi()
        {
            try
            {
                string existingData = File.Exists($@"{AppDomain.CurrentDomain.BaseDirectory}\bdt.json") ? File.ReadAllText($@"{AppDomain.CurrentDomain.BaseDirectory}\bdt.json") : "";
                string jsonData = JsonConvert.SerializeObject(this, Formatting.Indented);
                File.WriteAllText($@"{AppDomain.CurrentDomain.BaseDirectory}\bdt.json", jsonData);
            } catch (Exception e)
            {
                MessageBox.Show("Non ci sta");
            }
        }
        public void Carica()
        {
            try
            {
                string jsonData = File.ReadAllText($@"{AppDomain.CurrentDomain.BaseDirectory}\bdt.json");
                BancaDelTempo data = JsonConvert.DeserializeObject<BancaDelTempo>(jsonData);
                if (data.ElencoSoci != null)
                {
                    this.ElencoSoci = data.ElencoSoci;
                    if (ElencoSoci.Count > 0)
                    {
                        Socio.LoadSoci(ElencoSoci[ElencoSoci.Count - 1].IDSocio + 1);
                    }
                }
                else this.ElencoSoci = new List<Socio>();
                
                if (data.RegistroPrestazioni != null)
                {
                    this.RegistroPrestazioni = data.RegistroPrestazioni;
                    if (RegistroPrestazioni.Count > 0)
                    {
                        Prestazione.loadServizi(RegistroPrestazioni[RegistroPrestazioni.Count - 1].IDServizio + 1);
                    }
                }
                else this.RegistroPrestazioni = new List<Prestazione>();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void aggiungiSocio(string nome, string cognome, long numero, bool segreteria)
        {
            Socio nuovo = new Socio(nome, cognome, numero, segreteria);
            ElencoSoci.Add(nuovo);
            
        }
        public void aggiungiPrestazione(Prestazione p)
        {
            try
            {
                ElencoSoci[p.IDRichiedente].modificaDebito(-p.NOre);
                ElencoSoci[p.IDFornitore].modificaDebito(p.NOre);
                RegistroPrestazioni.Add(p);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        [JsonConstructor]
        public BancaDelTempo(List<Socio> ElencoSoci, List<Prestazione> RegistroPrestazioni)
        {
            this.ElencoSoci = ElencoSoci;
            this.RegistroPrestazioni = RegistroPrestazioni;
        }
    }
}
