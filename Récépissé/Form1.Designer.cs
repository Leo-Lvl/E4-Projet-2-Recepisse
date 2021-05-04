namespace Récépissé
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
            this.BAgentDSI = new System.Windows.Forms.Button();
            this.BAgentUtilisateur = new System.Windows.Forms.Button();
            this.labelChoisirUtilisateur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BAgentDSI
            // 
            this.BAgentDSI.Location = new System.Drawing.Point(187, 199);
            this.BAgentDSI.Name = "BAgentDSI";
            this.BAgentDSI.Size = new System.Drawing.Size(166, 56);
            this.BAgentDSI.TabIndex = 0;
            this.BAgentDSI.Text = "Agent(DSI)";
            this.BAgentDSI.UseVisualStyleBackColor = true;
            this.BAgentDSI.Click += new System.EventHandler(this.BAgentDSI_Click);
            // 
            // BAgentUtilisateur
            // 
            this.BAgentUtilisateur.Location = new System.Drawing.Point(417, 199);
            this.BAgentUtilisateur.Name = "BAgentUtilisateur";
            this.BAgentUtilisateur.Size = new System.Drawing.Size(168, 56);
            this.BAgentUtilisateur.TabIndex = 1;
            this.BAgentUtilisateur.Text = "Agent(utilisateur)";
            this.BAgentUtilisateur.UseVisualStyleBackColor = true;
            this.BAgentUtilisateur.Click += new System.EventHandler(this.BAgentUtilisateur_Click);
            // 
            // labelChoisirUtilisateur
            // 
            this.labelChoisirUtilisateur.AutoSize = true;
            this.labelChoisirUtilisateur.BackColor = System.Drawing.Color.Azure;
            this.labelChoisirUtilisateur.Location = new System.Drawing.Point(337, 141);
            this.labelChoisirUtilisateur.Name = "labelChoisirUtilisateur";
            this.labelChoisirUtilisateur.Size = new System.Drawing.Size(93, 13);
            this.labelChoisirUtilisateur.TabIndex = 2;
            this.labelChoisirUtilisateur.Text = "Choisir l\'utlisateur :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelChoisirUtilisateur);
            this.Controls.Add(this.BAgentUtilisateur);
            this.Controls.Add(this.BAgentDSI);
            this.Name = "Form1";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAgentDSI;
        private System.Windows.Forms.Button BAgentUtilisateur;
        private System.Windows.Forms.Label labelChoisirUtilisateur;
    }
}

