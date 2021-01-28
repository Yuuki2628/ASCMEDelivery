using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCMEDelivery
{
    class Veicolo
    {
        string marca, modello, targa, codiceAziendale;
        double kmPercorsi, kmPercorsiAlLitro;
        int annoImmatricolazione;
        static int codiceIdentificativo = 1;

        /// <summary>
        /// Creazione dell'oggetto veicolo con tutti i suoi parametri
        /// </summary>
        /// <param name="marca">La Marca del veicolo</param>
        /// <param name="modello">Il modello del veicolo</param>
        /// <param name="targa">La targa del veicolo</param>
        /// <param name="annoImmatricolazione">Anno in cui è stato Immatricolato il veicolo</param>
        /// <param name="kmPercorsiAlLitro">Cjilometri al litro che il veicolo può percorrere</param>
        public Veicolo(string marca, string modello, string targa, int annoImmatricolazione, double kmPercorsiAlLitro)
        {
            targa = targa.ToUpper();
            if ((ControlloStringa(targa[0]) && ControlloStringa(targa[1]) && ControlloNumero(targa[2]) && ControlloNumero(targa[3]) && ControlloNumero(targa[4]) && ControlloStringa(targa[5]) && ControlloStringa(targa[6])))
            {
                throw new Exception("La targa inserita non è nel formato corretto");
            }

            this.codiceAziendale = generaCodiceAziendale(targa, annoImmatricolazione);

            this.marca = marca;
            this.modello = modello;
            this.targa = targa;
            this.annoImmatricolazione = annoImmatricolazione;
            this.kmPercorsiAlLitro = kmPercorsiAlLitro;
        }

        /// <summary>
        /// Creazione dell'oggetto veicolo con tutti i suoi parametri
        /// </summary>
        /// <param name="marca">La Marca del veicolo</param>
        /// <param name="modello">Il modello del veicolo</param>
        /// <param name="targa">La targa del veicolo</param>
        /// <param name="annoImmatricolazione">Anno in cui è stato Immatricolato il veicolo</param>
        /// <param name="kmPercorsiAlLitro">Cjilometri al litro che il veicolo può percorrere</param>
        /// <param name="kmPercorsi">Chilometi già percorsi dal veicolo</param>
        public Veicolo(string marca, string modello, string targa, int annoImmatricolazione, double kmPercorsiAlLitro, double kmPercorsi) : this(marca, modello, targa, annoImmatricolazione, kmPercorsiAlLitro)
        {
            this.kmPercorsi = kmPercorsi;
        }

        /// <summary>
        /// Genera il codice aziendale di un veicolo partendo dalla targa, anno di immatricolazione ed aggiungendo un codice identificativo univoco
        /// </summary>
        /// <param name="targa">targa del veicolo</param>
        /// <param name="annoImmatricolazione">Anno di immatricolazione del veicolo</param>
        /// <returns></returns>
        private string generaCodiceAziendale(string targa, int annoImmatricolazione)
        {
            return annoImmatricolazione.ToString() + targa.Substring(5) + codiceIdentificativo++.ToString();
        }

        /// <summary>
        /// Controllo se il carattere è una lettera
        /// </summary>
        /// <param name="c">carattere da controllare</param>
        /// <returns></returns>
        private bool ControlloStringa(char c)
        {
            if (c > 'A' && c < 'Z')
                return true;
            else
                return false;
        }

        /// <summary>
        /// Controllo se il carattere è una cifra
        /// </summary>
        /// <param name="c">Carattere da controllare</param>
        /// <returns></returns>
        private bool ControlloNumero(char c)
        {
            if (int.TryParse(Convert.ToString(c), out int n))
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Restituisce il costo di un viaggio
        /// </summary>
        /// <param name="kmPercorsi">Lunghezza del viaggio in chilometri</param>
        /// <param name="prezzoBenzina">Prezzo della benzina per il viaggio</param>
        /// <returns></returns>
        public double CostoViaggio(double kmPercorsi, double prezzoBenzina)
        {
            this.kmPercorsi += kmPercorsi;

            return prezzoBenzina * kmPercorsiAlLitro / kmPercorsi;
        }

        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                this.marca = value;
            }
        }

        public string Modello
        {
            get
            {
                return modello;
            }
            set
            {
                this.modello = value;
            }
        }

        public string Targa
        {
            get
            {
                return targa;
            }
            set
            {
                this.targa = value;
            }
        }

        public int AnnoImmatricolazione
        {
            get
            {
                return annoImmatricolazione;
            }
            set
            {
                this.annoImmatricolazione = value;
            }
        }

        public double KmPercorsi
        {
            get
            {
                return kmPercorsi;
            }
            set
            {
                this.kmPercorsi = value;
            }
        }

        public double KmPercorsiAlLitro
        {
            get
            {
                return kmPercorsiAlLitro;
            }
            set
            {
                this.kmPercorsiAlLitro = value;
            }
        }

        public override string ToString()
        {
            return $"Il veicolo {Marca} - {Modello} di codice {codiceAziendale} ha percorso in totale {kmPercorsi}km.";
        }
    }
}
