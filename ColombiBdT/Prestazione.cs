using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColombiBdT
{
    public class Prestazione
    {
        private string _zona;
        private string _tipo;
        private float _nOre;
        private Socio _richiedente;
        private Socio _fornitore;
        private DateTime _data;
        private static int nServizi;
        private int idServizio;
        [JsonConstructor]
        public Prestazione(string zona, string tipo, float nore, Socio richiedente, Socio fornitore, DateTime data, int idservizio)
        {
            this.Data = data;
            this._zona = zona;
            this._tipo = tipo;
            this.NOre = nore;
            this.Richiedente = richiedente;
            this.Fornitore = fornitore;
            this.idServizio = idservizio;

        }
        public string Zona
        {
            private set
            {
                _zona = value;
            }
            get
            {
                return _zona;
            }
        }
        public string Tipo
        {
            private set
            {
                _tipo = value;
            }
            get
            {
                return _tipo;
            }
        }
        public float NOre
        {
            private set
            {
                _nOre = value;
            }
            get
            {
                return _nOre;
            }
        }
        public Socio Richiedente
        {
            private set
            {
                _richiedente = value;
            }
            get
            {
                return _richiedente;
            }
        }
        public Socio Fornitore
        {
            private set
            {
                _fornitore = value;
            }
            get
            {
                return _fornitore;
            }
        }
        public DateTime Data
        {
            private set
            {
                _data = value;
            }
            get
            {
                return _data;
            }
        }
        public Prestazione(Socio richiedente, Socio fornitore, DateTime data, float nOre, string zona)
        {
            Richiedente = richiedente;
            Fornitore = fornitore;
            Data = data;
            NOre = nOre;
            Zona = zona;
            idServizio = nServizi;
            nServizi++;
        }
        public Prestazione() : this(null, null, DateTime.Now, 0, null)
        {

        }
        public override bool Equals(object obj)
        {
            return this.idServizio==obj.GetHashCode();
        }
        public override int GetHashCode()
        {
            return this.idServizio;
        }
    }
}
