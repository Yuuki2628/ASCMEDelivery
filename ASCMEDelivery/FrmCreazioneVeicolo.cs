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
    public partial class FrmCreazioneVeicolo : Form
    {
        FrmMain main;

        public FrmCreazioneVeicolo(FrmMain main)
        {
            InitializeComponent();

            this.main = main;
        }

        private void btnCreaAuto_Click(object sender, EventArgs e)
        {
            main.Marca = txbMarca.Text;
            main.Modello = txbModello.Text;
            main.Targa = txbTarga.Text;
            main.KmPercorsiAlLitro = Convert.ToDouble(txb)
            main.AnnoImmatricolazione = Convert.ToInt32(txbAnnoDiImmatricolazione.Text);
        }
    }
}
