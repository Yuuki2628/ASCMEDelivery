namespace ASCMEDelivery
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreaFlotta = new System.Windows.Forms.Button();
            this.lblCrea = new System.Windows.Forms.Label();
            this.lblCreaVeicolo = new System.Windows.Forms.Label();
            this.btnCreaVeicolo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreaFlotta
            // 
            this.btnCreaFlotta.Location = new System.Drawing.Point(12, 25);
            this.btnCreaFlotta.Name = "btnCreaFlotta";
            this.btnCreaFlotta.Size = new System.Drawing.Size(112, 32);
            this.btnCreaFlotta.TabIndex = 0;
            this.btnCreaFlotta.Text = "Crea";
            this.btnCreaFlotta.UseVisualStyleBackColor = true;
            this.btnCreaFlotta.Click += new System.EventHandler(this.btnCreaFlotta_Click);
            // 
            // lblCrea
            // 
            this.lblCrea.AutoSize = true;
            this.lblCrea.Location = new System.Drawing.Point(12, 9);
            this.lblCrea.Name = "lblCrea";
            this.lblCrea.Size = new System.Drawing.Size(112, 13);
            this.lblCrea.TabIndex = 1;
            this.lblCrea.Text = "Crea una nuova flotta:";
            // 
            // lblCreaVeicolo
            // 
            this.lblCreaVeicolo.AutoSize = true;
            this.lblCreaVeicolo.Location = new System.Drawing.Point(12, 71);
            this.lblCreaVeicolo.Name = "lblCreaVeicolo";
            this.lblCreaVeicolo.Size = new System.Drawing.Size(117, 13);
            this.lblCreaVeicolo.TabIndex = 3;
            this.lblCreaVeicolo.Text = "Crea un nuovo veicolo:";
            // 
            // btnCreaVeicolo
            // 
            this.btnCreaVeicolo.Location = new System.Drawing.Point(12, 87);
            this.btnCreaVeicolo.Name = "btnCreaVeicolo";
            this.btnCreaVeicolo.Size = new System.Drawing.Size(112, 32);
            this.btnCreaVeicolo.TabIndex = 2;
            this.btnCreaVeicolo.Text = "Crea";
            this.btnCreaVeicolo.UseVisualStyleBackColor = true;
            this.btnCreaVeicolo.Click += new System.EventHandler(this.btnCreaVeicolo_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCreaVeicolo);
            this.Controls.Add(this.btnCreaVeicolo);
            this.Controls.Add(this.lblCrea);
            this.Controls.Add(this.btnCreaFlotta);
            this.Name = "FrmMain";
            this.Text = "Lisat di veicoli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreaFlotta;
        private System.Windows.Forms.Label lblCrea;
        private System.Windows.Forms.Label lblCreaVeicolo;
        private System.Windows.Forms.Button btnCreaVeicolo;
    }
}

