namespace FileReservationmanager
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lireFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lireFile
            // 
            this.lireFile.Location = new System.Drawing.Point(12, 25);
            this.lireFile.Name = "lireFile";
            this.lireFile.Size = new System.Drawing.Size(260, 224);
            this.lireFile.TabIndex = 3;
            this.lireFile.Text = "Dépiler réservation";
            this.lireFile.UseVisualStyleBackColor = true;
            this.lireFile.Click += new System.EventHandler(this.lireFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lireFile);
            this.Name = "Form1";
            this.Text = "File Reservation Manager";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button lireFile;
    }
}

