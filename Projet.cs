using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_prets
{
    class Projet
    {
        string numero;
        string debut;
        int budget;
        string descrip;
        string employe;

        public string Numero { get => numero; set => numero = value; }
        public string Debut { get =>debut ; set => debut = value; }
        public int Budget { get => budget; set => budget = value; }
        public string Descrip { get => descrip; set => descrip = value; }
        public string Employe { get => employe; set => employe = value; }



    }
}
