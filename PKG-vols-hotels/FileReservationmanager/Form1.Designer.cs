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
            this.result = new System.Windows.Forms.Label();
            this.ajoutFile = new System.Windows.Forms.Button();
            this.entree = new System.Windows.Forms.TextBox();
            this.lireFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(21, 78);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(30, 13);
            this.result.TabIndex = 0;
            this.result.Text = "NOP";
            // 
            // ajoutFile
            // 
            this.ajoutFile.Location = new System.Drawing.Point(149, 19);
            this.ajoutFile.Name = "ajoutFile";
            this.ajoutFile.Size = new System.Drawing.Size(75, 23);
            this.ajoutFile.TabIndex = 1;
            this.ajoutFile.Text = "Ajouter File";
            this.ajoutFile.UseVisualStyleBackColor = true;
            this.ajoutFile.Click += new System.EventHandler(this.ajoutFile_click);
            // 
            // entree
            // 
            this.entree.Location = new System.Drawing.Point(24, 21);
            this.entree.Name = "entree";
            this.entree.Size = new System.Drawing.Size(100, 20);
            this.entree.TabIndex = 2;
            // 
            // lireFile
            // 
            this.lireFile.Location = new System.Drawing.Point(149, 73);
            this.lireFile.Name = "lireFile";
            this.lireFile.Size = new System.Drawing.Size(75, 23);
            this.lireFile.TabIndex = 3;
            this.lireFile.Text = "Lire File";
            this.lireFile.UseVisualStyleBackColor = true;
            this.lireFile.Click += new System.EventHandler(this.lireFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lireFile);
            this.Controls.Add(this.entree);
            this.Controls.Add(this.ajoutFile);
            this.Controls.Add(this.result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button ajoutFile;
        private System.Windows.Forms.TextBox entree;
        private System.Windows.Forms.Button lireFile;
    }
}

