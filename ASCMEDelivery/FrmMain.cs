using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCMEDelivery
{
    public partial class FrmMain : Form
    {
        Flotta flotta;
        FrmCreazioneVeicolo creaVeicolo;

        string marca, modello, targa, codiceAziendale;
        double kmPercorsi, kmPercorsiAlLitro;
        int annoImmatricolazione;


        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCreaFlotta_Click(object sender, EventArgs e)
        {
            flotta = new Flotta();
        }

        private void btnCreaVeicolo_Click(object sender, EventArgs e)
        {
            creaVeicolo = new FrmCreazioneVeicolo(this);

            creaVeicolo.ShowDialog();
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

    }
}
