using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColombiBdT
{
    public class Zona
    {
        private static int nZone;
        private int _idZona;
        private string _nomeZona;
        public int IDZona
        {
            private set
            {
                _idZona = value;
            }
            get
            {
                return _idZona;
            }
        }
        public string NomeZona
        {
            private set
            {
                _nomeZona = value;
            }
            get
            {
                return _nomeZona;
            }
        }
        public Zona(string nomeZona)
        {
            NomeZona = nomeZona;
            IDZona = nZone;
            nZone++;
        }
        public override bool Equals(object obj)
        {
            return IDZona==obj.GetHashCode();
        }
        public override int GetHashCode()
        {
            return IDZona;
        }
    }
}
