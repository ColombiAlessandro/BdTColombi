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
            string existingData = File.Exists(@"C:\Users\aless\source\repos\ColombiBdT\bin\Debug\bdt.json") ? File.ReadAllText(@"C:\Users\aless\source\repos\ColombiBdT\bin\Debug\bdt.json") : "";
            string jsonData = JsonConvert.SerializeObject(this, Formatting.Indented);         
            File.WriteAllText(@"C:\Users\aless\source\repos\ColombiBdT\bin\Debug\bdt.json",jsonData);
        }
        public void Carica()
        {
            try
            {
                string jsonData = File.ReadAllText(@"C:\Users\aless\source\repos\ColombiBdT\bin\Debug\bdt.json");
                BancaDelTempo data = JsonConvert.DeserializeObject<BancaDelTempo>(jsonData);
                this.ElencoSoci = data.ElencoSoci;
                this.RegistroPrestazioni = data.RegistroPrestazioni;
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
    }
}
