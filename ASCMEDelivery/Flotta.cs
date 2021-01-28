using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCMEDelivery
{
    class Flotta
    {
        List<Veicolo> veicoli;

        public Flotta()
        {
            veicoli = new List<Veicolo>();
        }

        public bool AggiungiVeicolo(Veicolo v)
        {
            bool presente = false;
            for(int i = 0; i < veicoli.Count && !presente; i++)
            {
                if (v.Targa == veicoli[i].Targa)
                    presente = true;
            }
            if (!presente)
            {
                veicoli.Add(v);
                return true;
            }
            else
                return false;

        }

        public string ListaOrdinata()
        {
            List<Veicolo> w = new List<Veicolo>();
            for (int i = 0; i < veicoli.Count; i++)
                w[i] = veicoli[i];


        }

        private void OrdinaLista(List<Veicolo> lista)
        {

        }
    }
}
