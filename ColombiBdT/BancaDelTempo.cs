using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ColombiBdT
{
    public class BancaDelTempo
    {
        Dictionary<Socio, List<Prestazione>> RegistroPrestazioni;
        public List<Socio> ElencoSoci;
        public BancaDelTempo()
        {
            RegistroPrestazioni = new Dictionary<Socio, List<Prestazione>>();
            ElencoSoci = new List<Socio>();
        }
        public void Scrivi()
        {
            string existingData = File.Exists($@"{AppDomain.CurrentDomain.BaseDirectory}\bdt.json") ? File.ReadAllText($@"{AppDomain.CurrentDomain.BaseDirectory}\bdt.json") : "";
            string jsonData = JsonConvert.SerializeObject(this, Formatting.Indented);         
            File.WriteAllText($@"{AppDomain.CurrentDomain.BaseDirectory}\bdt.json", jsonData);
        }
        public void Carica()
        {
            try
            {
                string jsonData = File.ReadAllText($@"{AppDomain.CurrentDomain.BaseDirectory}\bdt.json");
                BancaDelTempo data = JsonConvert.DeserializeObject<BancaDelTempo>(jsonData);
                this.ElencoSoci = data.ElencoSoci;
                this.RegistroPrestazioni = data.RegistroPrestazioni;
                Socio.LoadSoci(ElencoSoci[ElencoSoci.Count-1].IDSocio + 1);
            }
            catch
            {
               
            }
        }
        public void aggiungiSocio(string nome, string cognome, int numero, bool segreteria)
        {
            Socio nuovo = new Socio(nome, cognome, numero, segreteria);
            ElencoSoci.Add(nuovo);
            
        }
        [JsonConstructor]
        public BancaDelTempo(List<Socio> ElencoSoci, Dictionary<Socio, List<Prestazione>> RegistroPrestazioni)
        {
            this.ElencoSoci = ElencoSoci;
            this.RegistroPrestazioni = RegistroPrestazioni;
        }
    }
}
