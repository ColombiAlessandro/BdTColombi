using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColombiBdT
{
    public class Prestazione : IComparable<object>
    {
        private string _zona;
        private string _tipo;
        private float _nOre;
        private int _richiedente;
        private int _fornitore;
        private string _data;
        private static int nServizi;
        private int idServizio;
        [JsonConstructor]
        public Prestazione(string zona, string tipo, float nore, int idrichiedente, int idfornitore, string data, int idservizio)
        {
            this.Data = data;
            this._zona = zona;
            this._tipo = tipo;
            this.NOre = nore;
            this.IDRichiedente = idrichiedente;
            this.IDFornitore = idfornitore;
            this.idServizio = idservizio;


        }
        public static void loadServizi(int nservizi)
        {
            if(nservizi>=0)
            {
                nServizi = nservizi;
            }
        }
        public int IDServizio
        {
            get { return idServizio; }
            set { idServizio = value; }
        }
        public static int NServizi
        {
            get { return nServizi; }
            private set { nServizi = value; }
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
        public int IDRichiedente
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
        public int IDFornitore
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
        public string Data
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
        public Prestazione(int idrichiedente, int idfornitore, string data, float nOre, string zona, string tipo)
        {
            IDRichiedente = idrichiedente;
            IDFornitore = idfornitore;
            Data = data;
            NOre = nOre;
            Zona = zona;
            Tipo = tipo;
            idServizio = nServizi;
            nServizi++;
        }
        public Prestazione() : this(0, 0, DateTime.Now.ToString(), 0, "", "")
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
        public int CompareTo(object obj)
        {
            Prestazione p=obj as Prestazione;
            if (this.NOre > p.NOre) return 1;
            if(this.NOre < p.NOre) return -1;
            return 0;
        }
    }
}
