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

        /// <summary>
        /// Inizializza la lista di veicoli
        /// </summary>
        public Flotta()
        {
            veicoli = new List<Veicolo>();
        }

        /// <summary>
        /// Aggiunge un veicolo alla lista
        /// </summary>
        /// <param name="v">Veicolo da aggiungere</param>
        /// <returns></returns>
        public bool AggiungiVeicolo(Veicolo v)
        {
            bool presente = false;
            for (int i = 0; i < veicoli.Count && !presente; i++)
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

        /// <summary>
        /// Rimuove un veicolo dalla lista di veicoli
        /// </summary>
        /// <param name="v">veicolo da rimuovere</param>
        public void RimuoviVeicolo(Veicolo v)
        {
            for(int i = 0; i < veicoli.Count; i++)
            {
                if (veicoli[i].Targa == v.Targa)
                    veicoli.Remove(v);
            }
        }

        /// <summary>
        /// Restituisce una rappresentazione della lista con i veicoli ordinati in base ai chilometi percorsi
        /// </summary>
        /// <param name="lista">lista di veicoli di cui si vuole una rappresentazione</param>
        /// <returns></returns>
        private string OrdinaLista(List<Veicolo> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (lista[j - 1].KmPercorsi > lista[j].KmPercorsi)
                    {
                        Veicolo temp = lista[j - 1];
                        lista[j - 1] = lista[j];
                        lista[j] = temp;
                    }
                }
            }

            string output = "";

            for(int i = 0; i < lista.Count; i++)
            {
                output = output + lista[i].ToString() + "\n";
            }
            return output;
        }
    }
}
