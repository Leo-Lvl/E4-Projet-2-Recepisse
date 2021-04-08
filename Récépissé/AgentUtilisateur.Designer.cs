namespace Récépissé
{
    partial class AgentUtilisateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelAgentUtilisateur = new System.Windows.Forms.Label();
            this.LabelNom = new System.Windows.Forms.Label();
            this.LabelPrenom = new System.Windows.Forms.Label();
            this.TextBoxNomAgentUtilisateur = new System.Windows.Forms.TextBox();
            this.textBoxPrenomAgentUtilisateur = new System.Windows.Forms.TextBox();
            this.LabelDateRetourReelle = new System.Windows.Forms.Label();
            this.LabelRecepisseDisponible = new System.Windows.Forms.Label();
            this.LabelSaisirMatricule = new System.Windows.Forms.Label();
            this.LabelSignatureAgent = new System.Windows.Forms.Label();
            this.LabelNomSignatureAgentDSI = new System.Windows.Forms.Label();
            this.LabelStatut = new System.Windows.Forms.Label();
            this.textBoxSaisirMatricule = new System.Windows.Forms.TextBox();
            this.textBoxRecepisseDisponible = new System.Windows.Forms.TextBox();
            this.textBoxDateRetourReelle = new System.Windows.Forms.TextBox();
            this.textBoxSignatureAgent = new System.Windows.Forms.TextBox();
            this.textBoxNomSignatureAgentDSI = new System.Windows.Forms.TextBox();
            this.ComboBoxStatutAgentUtilisateur = new System.Windows.Forms.ComboBox();
            this.BValiderRecepisse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelAgentUtilisateur
            // 
            this.LabelAgentUtilisateur.AutoSize = true;
            this.LabelAgentUtilisateur.Location = new System.Drawing.Point(35, 84);
            this.LabelAgentUtilisateur.Name = "LabelAgentUtilisateur";
            this.LabelAgentUtilisateur.Size = new System.Drawing.Size(88, 13);
            this.LabelAgentUtilisateur.TabIndex = 10;
            this.LabelAgentUtilisateur.Text = "Agent (utilisateur)";
            this.LabelAgentUtilisateur.Click += new System.EventHandler(this.LabelAgentUtilisateur_Click);
            // 
            // LabelNom
            // 
            this.LabelNom.AutoSize = true;
            this.LabelNom.Location = new System.Drawing.Point(204, 44);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(29, 13);
            this.LabelNom.TabIndex = 11;
            this.LabelNom.Text = "Nom";
            // 
            // LabelPrenom
            // 
            this.LabelPrenom.AutoSize = true;
            this.LabelPrenom.Location = new System.Drawing.Point(370, 44);
            this.LabelPrenom.Name = "LabelPrenom";
            this.LabelPrenom.Size = new System.Drawing.Size(43, 13);
            this.LabelPrenom.TabIndex = 12;
            this.LabelPrenom.Text = "Prénom";
            // 
            // TextBoxNomAgentUtilisateur
            // 
            this.TextBoxNomAgentUtilisateur.Location = new System.Drawing.Point(170, 81);
            this.TextBoxNomAgentUtilisateur.Name = "TextBoxNomAgentUtilisateur";
            this.TextBoxNomAgentUtilisateur.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNomAgentUtilisateur.TabIndex = 13;
            // 
            // textBoxPrenomAgentUtilisateur
            // 
            this.textBoxPrenomAgentUtilisateur.Location = new System.Drawing.Point(338, 81);
            this.textBoxPrenomAgentUtilisateur.Name = "textBoxPrenomAgentUtilisateur";
            this.textBoxPrenomAgentUtilisateur.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenomAgentUtilisateur.TabIndex = 14;
            // 
            // LabelDateRetourReelle
            // 
            this.LabelDateRetourReelle.AutoSize = true;
            this.LabelDateRetourReelle.Location = new System.Drawing.Point(35, 254);
            this.LabelDateRetourReelle.Name = "LabelDateRetourReelle";
            this.LabelDateRetourReelle.Size = new System.Drawing.Size(109, 13);
            this.LabelDateRetourReelle.TabIndex = 15;
            this.LabelDateRetourReelle.Text = "Date de retour réelle :";
            // 
            // LabelRecepisseDisponible
            // 
            this.LabelRecepisseDisponible.AutoSize = true;
            this.LabelRecepisseDisponible.Location = new System.Drawing.Point(35, 200);
            this.LabelRecepisseDisponible.Name = "LabelRecepisseDisponible";
            this.LabelRecepisseDisponible.Size = new System.Drawing.Size(113, 13);
            this.LabelRecepisseDisponible.TabIndex = 16;
            this.LabelRecepisseDisponible.Text = "Récépissé disponible :";
            // 
            // LabelSaisirMatricule
            // 
            this.LabelSaisirMatricule.AutoSize = true;
            this.LabelSaisirMatricule.Location = new System.Drawing.Point(35, 142);
            this.LabelSaisirMatricule.Name = "LabelSaisirMatricule";
            this.LabelSaisirMatricule.Size = new System.Drawing.Size(94, 13);
            this.LabelSaisirMatricule.TabIndex = 17;
            this.LabelSaisirMatricule.Text = "Saisir le matricule :";
            // 
            // LabelSignatureAgent
            // 
            this.LabelSignatureAgent.AutoSize = true;
            this.LabelSignatureAgent.Location = new System.Drawing.Point(358, 139);
            this.LabelSignatureAgent.Name = "LabelSignatureAgent";
            this.LabelSignatureAgent.Size = new System.Drawing.Size(89, 13);
            this.LabelSignatureAgent.TabIndex = 18;
            this.LabelSignatureAgent.Text = "Signature Agent :";
            // 
            // LabelNomSignatureAgentDSI
            // 
            this.LabelNomSignatureAgentDSI.AutoSize = true;
            this.LabelNomSignatureAgentDSI.Location = new System.Drawing.Point(335, 196);
            this.LabelNomSignatureAgentDSI.Name = "LabelNomSignatureAgentDSI";
            this.LabelNomSignatureAgentDSI.Size = new System.Drawing.Size(151, 13);
            this.LabelNomSignatureAgentDSI.TabIndex = 19;
            this.LabelNomSignatureAgentDSI.Text = "Nom et signature Agent (DSI) :";
            // 
            // LabelStatut
            // 
            this.LabelStatut.AutoSize = true;
            this.LabelStatut.Location = new System.Drawing.Point(379, 257);
            this.LabelStatut.Name = "LabelStatut";
            this.LabelStatut.Size = new System.Drawing.Size(41, 13);
            this.LabelStatut.TabIndex = 20;
            this.LabelStatut.Text = "Statut :";
            // 
            // textBoxSaisirMatricule
            // 
            this.textBoxSaisirMatricule.Location = new System.Drawing.Point(170, 139);
            this.textBoxSaisirMatricule.Name = "textBoxSaisirMatricule";
            this.textBoxSaisirMatricule.Size = new System.Drawing.Size(100, 20);
            this.textBoxSaisirMatricule.TabIndex = 21;
            this.textBoxSaisirMatricule.TextChanged += new System.EventHandler(this.textBoxSaisirMatricule_TextChanged);
            // 
            // textBoxRecepisseDisponible
            // 
            this.textBoxRecepisseDisponible.Location = new System.Drawing.Point(170, 197);
            this.textBoxRecepisseDisponible.Name = "textBoxRecepisseDisponible";
            this.textBoxRecepisseDisponible.Size = new System.Drawing.Size(100, 20);
            this.textBoxRecepisseDisponible.TabIndex = 22;
            // 
            // textBoxDateRetourReelle
            // 
            this.textBoxDateRetourReelle.Location = new System.Drawing.Point(170, 251);
            this.textBoxDateRetourReelle.Name = "textBoxDateRetourReelle";
            this.textBoxDateRetourReelle.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateRetourReelle.TabIndex = 23;
            // 
            // textBoxSignatureAgent
            // 
            this.textBoxSignatureAgent.Location = new System.Drawing.Point(521, 136);
            this.textBoxSignatureAgent.Name = "textBoxSignatureAgent";
            this.textBoxSignatureAgent.Size = new System.Drawing.Size(100, 20);
            this.textBoxSignatureAgent.TabIndex = 24;
            // 
            // textBoxNomSignatureAgentDSI
            // 
            this.textBoxNomSignatureAgentDSI.Location = new System.Drawing.Point(521, 193);
            this.textBoxNomSignatureAgentDSI.Name = "textBoxNomSignatureAgentDSI";
            this.textBoxNomSignatureAgentDSI.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomSignatureAgentDSI.TabIndex = 25;
            // 
            // ComboBoxStatutAgentUtilisateur
            // 
            this.ComboBoxStatutAgentUtilisateur.FormattingEnabled = true;
            this.ComboBoxStatutAgentUtilisateur.Items.AddRange(new object[] {
            "EN COURS",
            "RECEPTIONNE"});
            this.ComboBoxStatutAgentUtilisateur.Location = new System.Drawing.Point(521, 249);
            this.ComboBoxStatutAgentUtilisateur.Name = "ComboBoxStatutAgentUtilisateur";
            this.ComboBoxStatutAgentUtilisateur.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxStatutAgentUtilisateur.TabIndex = 30;
            // 
            // BValiderRecepisse
            // 
            this.BValiderRecepisse.Location = new System.Drawing.Point(314, 317);
            this.BValiderRecepisse.Name = "BValiderRecepisse";
            this.BValiderRecepisse.Size = new System.Drawing.Size(124, 63);
            this.BValiderRecepisse.TabIndex = 31;
            this.BValiderRecepisse.Text = "Valider";
            this.BValiderRecepisse.UseVisualStyleBackColor = true;
            this.BValiderRecepisse.Click += new System.EventHandler(this.BValiderRecepisse_Click);
            // 
            // AgentUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(938, 511);
            this.Controls.Add(this.BValiderRecepisse);
            this.Controls.Add(this.ComboBoxStatutAgentUtilisateur);
            this.Controls.Add(this.textBoxNomSignatureAgentDSI);
            this.Controls.Add(this.textBoxSignatureAgent);
            this.Controls.Add(this.textBoxDateRetourReelle);
            this.Controls.Add(this.textBoxRecepisseDisponible);
            this.Controls.Add(this.textBoxSaisirMatricule);
            this.Controls.Add(this.LabelStatut);
            this.Controls.Add(this.LabelNomSignatureAgentDSI);
            this.Controls.Add(this.LabelSignatureAgent);
            this.Controls.Add(this.LabelSaisirMatricule);
            this.Controls.Add(this.LabelRecepisseDisponible);
            this.Controls.Add(this.LabelDateRetourReelle);
            this.Controls.Add(this.textBoxPrenomAgentUtilisateur);
            this.Controls.Add(this.TextBoxNomAgentUtilisateur);
            this.Controls.Add(this.LabelPrenom);
            this.Controls.Add(this.LabelNom);
            this.Controls.Add(this.LabelAgentUtilisateur);
            this.Name = "AgentUtilisateur";
            this.Text = "AgentUtilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAgentUtilisateur;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.Label LabelPrenom;
        private System.Windows.Forms.TextBox TextBoxNomAgentUtilisateur;
        private System.Windows.Forms.TextBox textBoxPrenomAgentUtilisateur;
        private System.Windows.Forms.Label LabelDateRetourReelle;
        private System.Windows.Forms.Label LabelRecepisseDisponible;
        private System.Windows.Forms.Label LabelSaisirMatricule;
        private System.Windows.Forms.Label LabelSignatureAgent;
        private System.Windows.Forms.Label LabelNomSignatureAgentDSI;
        private System.Windows.Forms.Label LabelStatut;
        private System.Windows.Forms.TextBox textBoxSaisirMatricule;
        private System.Windows.Forms.TextBox textBoxRecepisseDisponible;
        private System.Windows.Forms.TextBox textBoxDateRetourReelle;
        private System.Windows.Forms.TextBox textBoxSignatureAgent;
        private System.Windows.Forms.TextBox textBoxNomSignatureAgentDSI;
        private System.Windows.Forms.ComboBox ComboBoxStatutAgentUtilisateur;
        private System.Windows.Forms.Button BValiderRecepisse;
    }
}