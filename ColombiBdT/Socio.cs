using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColombiBdT
{
    public class Socio
    {
        private string _nome;
        private string _cognome;
        private int _telefono;
        private float _debitoOre;
        private static int nSoci;
        private int idSocio;
        private bool _segreteria;
        
        public bool Segreteria
        {
            private set
            {
                _segreteria = value;
            }
            get
            {
                return _segreteria;
            }
        }
        public int IDSocio
        {
            private set
            {
                idSocio = value;
            }
            get
            {
                return idSocio;
            }
        }
        public int Telefono
        {
            private set
            {
                _telefono = value;
            }
            get
            {
                return _telefono;
            }
        }
        public string Nome
        {
            private set 
            {
                _nome = value;
            }
            get { return _nome; }
        }
        public string Cognome
        {
            private set
            {
                _cognome = value;
            }
            get
            {
                return _cognome;   
            }
        }
        public float DebitoOre
        {
            private set
            {
                _debitoOre = value;
            }
            get
            {
                return _debitoOre;
            }
        }
        public Socio()
        {
            Nome = null;
            Cognome = null;
            DebitoOre = 0;
            Telefono = 0;
            Segreteria = false;
            
        }
        public Socio(string nome, string cognome, int debitoore, int telefono, bool segreteria)
        {
            Nome = nome;
            Cognome = cognome;
            DebitoOre = debitoore;
            idSocio = nSoci;
            nSoci++;
            Telefono = telefono;
            Segreteria = segreteria;
            
        }
        public Socio(string nome, string cognome, int telefono, bool segreteria) : this(nome, cognome, 0, telefono, segreteria)
        {
            
        } 
        public Socio(Socio s)
        {
            Nome = s.Nome;
            Cognome = s.Cognome;
            DebitoOre = s.DebitoOre;
            idSocio = s.IDSocio;
            Telefono = s.Telefono;
            Segreteria = s.Segreteria;
        }
        public void modificaDebito(float orePrestazioni)
        {
            if(DebitoOre-orePrestazioni < -25)
            {
                throw new Exception("Non è possibile scendere sotto le 25 ore di debito");
            }
            DebitoOre += orePrestazioni;
        }
        public override int GetHashCode()
        {
            return idSocio;
        }
        public override bool Equals(object obj)
        {
            return idSocio == obj.GetHashCode();
        }
        public Socio Clone()
        {
            return new Socio(this);
        }
    }
}
