namespace Récépissé
{
    partial class CleAgentDSI
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LabelNom = new System.Windows.Forms.Label();
            this.LabelPrenom = new System.Windows.Forms.Label();
            this.LabelSite = new System.Windows.Forms.Label();
            this.TextBoxNomAgentDSI = new System.Windows.Forms.TextBox();
            this.TextBoxPrenomAgentDSI = new System.Windows.Forms.TextBox();
            this.TextBoxSite = new System.Windows.Forms.TextBox();
            this.LabelMateriel = new System.Windows.Forms.Label();
            this.LabelEquipement = new System.Windows.Forms.Label();
            this.LabelAgentDSI = new System.Windows.Forms.Label();
            this.LabelEtatMateriel = new System.Windows.Forms.Label();
            this.textBoxTypeEquipement = new System.Windows.Forms.TextBox();
            this.textBoxNumInventaire = new System.Windows.Forms.TextBox();
            this.textBoxNumSerie = new System.Windows.Forms.TextBox();
            this.LabelNumInventaire = new System.Windows.Forms.Label();
            this.LabelNumSerie = new System.Windows.Forms.Label();
            this.LabelCleAgentUtilisateur = new System.Windows.Forms.Label();
            this.LabelNomSite = new System.Windows.Forms.Label();
            this.LabelAttributionMaterielAgent = new System.Windows.Forms.Label();
            this.LabelDateRetourEstimee = new System.Windows.Forms.Label();
            this.LabelStatut = new System.Windows.Forms.Label();
            this.TextBoxCleAgentUtilisateur = new System.Windows.Forms.TextBox();
            this.textBoxNomSite = new System.Windows.Forms.TextBox();
            this.textBoxDateAttributionMaterielAgent = new System.Windows.Forms.TextBox();
            this.textBoxDateRetourEstimee = new System.Windows.Forms.TextBox();
            this.ComboBoxStatutAgentDSI = new System.Windows.Forms.ComboBox();
            this.BValiderRecepisse = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.TextBoxDirection = new System.Windows.Forms.TextBox();
            this.TextBoxService = new System.Windows.Forms.TextBox();
            this.LabelDirection = new System.Windows.Forms.Label();
            this.LabelService = new System.Windows.Forms.Label();
            this.LabelSaisirMatricule = new System.Windows.Forms.Label();
            this.textBoxSaisirMatricule = new System.Windows.Forms.TextBox();
            this.LabelCodeSite = new System.Windows.Forms.Label();
            this.textBoxCodeSite = new System.Windows.Forms.TextBox();
            this.ComboBoxEtatMateriel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelNom
            // 
            this.LabelNom.AutoSize = true;
            this.LabelNom.Location = new System.Drawing.Point(185, 9);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(29, 13);
            this.LabelNom.TabIndex = 0;
            this.LabelNom.Text = "Nom";
            // 
            // LabelPrenom
            // 
            this.LabelPrenom.AutoSize = true;
            this.LabelPrenom.Location = new System.Drawing.Point(350, 9);
            this.LabelPrenom.Name = "LabelPrenom";
            this.LabelPrenom.Size = new System.Drawing.Size(43, 13);
            this.LabelPrenom.TabIndex = 1;
            this.LabelPrenom.Text = "Prénom";
            // 
            // LabelSite
            // 
            this.LabelSite.AutoSize = true;
            this.LabelSite.Location = new System.Drawing.Point(519, 9);
            this.LabelSite.Name = "LabelSite";
            this.LabelSite.Size = new System.Drawing.Size(25, 13);
            this.LabelSite.TabIndex = 3;
            this.LabelSite.Text = "Site";
            this.LabelSite.Click += new System.EventHandler(this.label3_Click);
            // 
            // TextBoxNomAgentDSI
            // 
            this.TextBoxNomAgentDSI.Location = new System.Drawing.Point(151, 48);
            this.TextBoxNomAgentDSI.Name = "TextBoxNomAgentDSI";
            this.TextBoxNomAgentDSI.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNomAgentDSI.TabIndex = 4;
            this.TextBoxNomAgentDSI.TextChanged += new System.EventHandler(this.TextBoxNom_TextChanged);
            // 
            // TextBoxPrenomAgentDSI
            // 
            this.TextBoxPrenomAgentDSI.Location = new System.Drawing.Point(321, 48);
            this.TextBoxPrenomAgentDSI.Name = "TextBoxPrenomAgentDSI";
            this.TextBoxPrenomAgentDSI.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPrenomAgentDSI.TabIndex = 5;
            this.TextBoxPrenomAgentDSI.TextChanged += new System.EventHandler(this.TextBoxPrenom_TextChanged);
            // 
            // TextBoxSite
            // 
            this.TextBoxSite.Location = new System.Drawing.Point(484, 48);
            this.TextBoxSite.Name = "TextBoxSite";
            this.TextBoxSite.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSite.TabIndex = 6;
            // 
            // LabelMateriel
            // 
            this.LabelMateriel.AutoSize = true;
            this.LabelMateriel.Location = new System.Drawing.Point(22, 157);
            this.LabelMateriel.Name = "LabelMateriel";
            this.LabelMateriel.Size = new System.Drawing.Size(50, 13);
            this.LabelMateriel.TabIndex = 7;
            this.LabelMateriel.Text = "Matériel :";
            // 
            // LabelEquipement
            // 
            this.LabelEquipement.AutoSize = true;
            this.LabelEquipement.Location = new System.Drawing.Point(154, 111);
            this.LabelEquipement.Name = "LabelEquipement";
            this.LabelEquipement.Size = new System.Drawing.Size(97, 13);
            this.LabelEquipement.TabIndex = 8;
            this.LabelEquipement.Text = "Type d\'équipement";
            // 
            // LabelAgentDSI
            // 
            this.LabelAgentDSI.AutoSize = true;
            this.LabelAgentDSI.Location = new System.Drawing.Point(22, 51);
            this.LabelAgentDSI.Name = "LabelAgentDSI";
            this.LabelAgentDSI.Size = new System.Drawing.Size(59, 13);
            this.LabelAgentDSI.TabIndex = 9;
            this.LabelAgentDSI.Text = "Agent(DSI)";
            // 
            // LabelEtatMateriel
            // 
            this.LabelEtatMateriel.AutoSize = true;
            this.LabelEtatMateriel.Location = new System.Drawing.Point(329, 111);
            this.LabelEtatMateriel.Name = "LabelEtatMateriel";
            this.LabelEtatMateriel.Size = new System.Drawing.Size(80, 13);
            this.LabelEtatMateriel.TabIndex = 10;
            this.LabelEtatMateriel.Text = "Etat du matériel";
            // 
            // textBoxTypeEquipement
            // 
            this.textBoxTypeEquipement.Location = new System.Drawing.Point(151, 154);
            this.textBoxTypeEquipement.Name = "textBoxTypeEquipement";
            this.textBoxTypeEquipement.Size = new System.Drawing.Size(100, 20);
            this.textBoxTypeEquipement.TabIndex = 14;
            this.textBoxTypeEquipement.TextChanged += new System.EventHandler(this.textBoxTypeEquipement_TextChanged);
            // 
            // textBoxNumInventaire
            // 
            this.textBoxNumInventaire.Location = new System.Drawing.Point(484, 153);
            this.textBoxNumInventaire.Name = "textBoxNumInventaire";
            this.textBoxNumInventaire.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumInventaire.TabIndex = 15;
            // 
            // textBoxNumSerie
            // 
            this.textBoxNumSerie.Location = new System.Drawing.Point(636, 154);
            this.textBoxNumSerie.Name = "textBoxNumSerie";
            this.textBoxNumSerie.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumSerie.TabIndex = 16;
            // 
            // LabelNumInventaire
            // 
            this.LabelNumInventaire.AutoSize = true;
            this.LabelNumInventaire.Location = new System.Drawing.Point(498, 111);
            this.LabelNumInventaire.Name = "LabelNumInventaire";
            this.LabelNumInventaire.Size = new System.Drawing.Size(69, 13);
            this.LabelNumInventaire.TabIndex = 17;
            this.LabelNumInventaire.Text = "N° Inventaire";
            // 
            // LabelNumSerie
            // 
            this.LabelNumSerie.AutoSize = true;
            this.LabelNumSerie.Location = new System.Drawing.Point(658, 111);
            this.LabelNumSerie.Name = "LabelNumSerie";
            this.LabelNumSerie.Size = new System.Drawing.Size(46, 13);
            this.LabelNumSerie.TabIndex = 18;
            this.LabelNumSerie.Text = "N° Série";
            this.LabelNumSerie.Click += new System.EventHandler(this.label4_Click);
            // 
            // LabelCleAgentUtilisateur
            // 
            this.LabelCleAgentUtilisateur.AutoSize = true;
            this.LabelCleAgentUtilisateur.Location = new System.Drawing.Point(22, 214);
            this.LabelCleAgentUtilisateur.Name = "LabelCleAgentUtilisateur";
            this.LabelCleAgentUtilisateur.Size = new System.Drawing.Size(130, 13);
            this.LabelCleAgentUtilisateur.TabIndex = 19;
            this.LabelCleAgentUtilisateur.Text = "Clé de l\'agent (utilisateur) :";
            // 
            // LabelNomSite
            // 
            this.LabelNomSite.AutoSize = true;
            this.LabelNomSite.Location = new System.Drawing.Point(591, 214);
            this.LabelNomSite.Name = "LabelNomSite";
            this.LabelNomSite.Size = new System.Drawing.Size(71, 13);
            this.LabelNomSite.TabIndex = 20;
            this.LabelNomSite.Text = "Nom du Site :";
            // 
            // LabelAttributionMaterielAgent
            // 
            this.LabelAttributionMaterielAgent.AutoSize = true;
            this.LabelAttributionMaterielAgent.Location = new System.Drawing.Point(24, 285);
            this.LabelAttributionMaterielAgent.Name = "LabelAttributionMaterielAgent";
            this.LabelAttributionMaterielAgent.Size = new System.Drawing.Size(190, 13);
            this.LabelAttributionMaterielAgent.TabIndex = 21;
            this.LabelAttributionMaterielAgent.Text = "Date d\'attribution du matériel à l\'agent :";
            // 
            // LabelDateRetourEstimee
            // 
            this.LabelDateRetourEstimee.AutoSize = true;
            this.LabelDateRetourEstimee.Location = new System.Drawing.Point(447, 285);
            this.LabelDateRetourEstimee.Name = "LabelDateRetourEstimee";
            this.LabelDateRetourEstimee.Size = new System.Drawing.Size(120, 13);
            this.LabelDateRetourEstimee.TabIndex = 22;
            this.LabelDateRetourEstimee.Text = "Date de retour estimée :";
            // 
            // LabelStatut
            // 
            this.LabelStatut.AutoSize = true;
            this.LabelStatut.Location = new System.Drawing.Point(312, 353);
            this.LabelStatut.Name = "LabelStatut";
            this.LabelStatut.Size = new System.Drawing.Size(41, 13);
            this.LabelStatut.TabIndex = 23;
            this.LabelStatut.Text = "Statut :";
            // 
            // TextBoxCleAgentUtilisateur
            // 
            this.TextBoxCleAgentUtilisateur.Location = new System.Drawing.Point(151, 211);
            this.TextBoxCleAgentUtilisateur.Name = "TextBoxCleAgentUtilisateur";
            this.TextBoxCleAgentUtilisateur.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCleAgentUtilisateur.TabIndex = 24;
            // 
            // textBoxNomSite
            // 
            this.textBoxNomSite.Location = new System.Drawing.Point(705, 211);
            this.textBoxNomSite.Name = "textBoxNomSite";
            this.textBoxNomSite.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomSite.TabIndex = 25;
            // 
            // textBoxDateAttributionMaterielAgent
            // 
            this.textBoxDateAttributionMaterielAgent.Location = new System.Drawing.Point(255, 282);
            this.textBoxDateAttributionMaterielAgent.Name = "textBoxDateAttributionMaterielAgent";
            this.textBoxDateAttributionMaterielAgent.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateAttributionMaterielAgent.TabIndex = 26;
            // 
            // textBoxDateRetourEstimee
            // 
            this.textBoxDateRetourEstimee.Location = new System.Drawing.Point(594, 282);
            this.textBoxDateRetourEstimee.Name = "textBoxDateRetourEstimee";
            this.textBoxDateRetourEstimee.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateRetourEstimee.TabIndex = 27;
            // 
            // ComboBoxStatutAgentDSI
            // 
            this.ComboBoxStatutAgentDSI.FormattingEnabled = true;
            this.ComboBoxStatutAgentDSI.Items.AddRange(new object[] {
            "EN COURS",
            "RECEPTIONNE"});
            this.ComboBoxStatutAgentDSI.Location = new System.Drawing.Point(382, 350);
            this.ComboBoxStatutAgentDSI.Name = "ComboBoxStatutAgentDSI";
            this.ComboBoxStatutAgentDSI.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxStatutAgentDSI.TabIndex = 29;
            this.ComboBoxStatutAgentDSI.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BValiderRecepisse
            // 
            this.BValiderRecepisse.Location = new System.Drawing.Point(594, 335);
            this.BValiderRecepisse.Name = "BValiderRecepisse";
            this.BValiderRecepisse.Size = new System.Drawing.Size(153, 70);
            this.BValiderRecepisse.TabIndex = 32;
            this.BValiderRecepisse.Text = "Valider";
            this.BValiderRecepisse.UseVisualStyleBackColor = true;
            this.BValiderRecepisse.Click += new System.EventHandler(this.BValiderRecepisse_Click);
            // 
            // TextBoxDirection
            // 
            this.TextBoxDirection.Location = new System.Drawing.Point(636, 48);
            this.TextBoxDirection.Name = "TextBoxDirection";
            this.TextBoxDirection.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDirection.TabIndex = 33;
            // 
            // TextBoxService
            // 
            this.TextBoxService.Location = new System.Drawing.Point(771, 48);
            this.TextBoxService.Name = "TextBoxService";
            this.TextBoxService.Size = new System.Drawing.Size(100, 20);
            this.TextBoxService.TabIndex = 34;
            // 
            // LabelDirection
            // 
            this.LabelDirection.AutoSize = true;
            this.LabelDirection.Location = new System.Drawing.Point(658, 9);
            this.LabelDirection.Name = "LabelDirection";
            this.LabelDirection.Size = new System.Drawing.Size(49, 13);
            this.LabelDirection.TabIndex = 35;
            this.LabelDirection.Text = "Direction";
            // 
            // LabelService
            // 
            this.LabelService.AutoSize = true;
            this.LabelService.Location = new System.Drawing.Point(798, 9);
            this.LabelService.Name = "LabelService";
            this.LabelService.Size = new System.Drawing.Size(43, 13);
            this.LabelService.TabIndex = 36;
            this.LabelService.Text = "Service";
            // 
            // LabelSaisirMatricule
            // 
            this.LabelSaisirMatricule.AutoSize = true;
            this.LabelSaisirMatricule.Location = new System.Drawing.Point(22, 353);
            this.LabelSaisirMatricule.Name = "LabelSaisirMatricule";
            this.LabelSaisirMatricule.Size = new System.Drawing.Size(94, 13);
            this.LabelSaisirMatricule.TabIndex = 37;
            this.LabelSaisirMatricule.Text = "Saisir le matricule :";
            // 
            // textBoxSaisirMatricule
            // 
            this.textBoxSaisirMatricule.Location = new System.Drawing.Point(151, 350);
            this.textBoxSaisirMatricule.Name = "textBoxSaisirMatricule";
            this.textBoxSaisirMatricule.Size = new System.Drawing.Size(100, 20);
            this.textBoxSaisirMatricule.TabIndex = 38;
            this.textBoxSaisirMatricule.TextChanged += new System.EventHandler(this.textBoxSaisirMatricule_TextChanged);
            // 
            // LabelCodeSite
            // 
            this.LabelCodeSite.AutoSize = true;
            this.LabelCodeSite.Location = new System.Drawing.Point(327, 214);
            this.LabelCodeSite.Name = "LabelCodeSite";
            this.LabelCodeSite.Size = new System.Drawing.Size(66, 13);
            this.LabelCodeSite.TabIndex = 39;
            this.LabelCodeSite.Text = "Code du site";
            // 
            // textBoxCodeSite
            // 
            this.textBoxCodeSite.Location = new System.Drawing.Point(444, 211);
            this.textBoxCodeSite.Name = "textBoxCodeSite";
            this.textBoxCodeSite.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodeSite.TabIndex = 40;
            // 
            // ComboBoxEtatMateriel
            // 
            this.ComboBoxEtatMateriel.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxEtatMateriel.FormattingEnabled = true;
            this.ComboBoxEtatMateriel.Items.AddRange(new object[] {
            "NEUF",
            "PARFAIT",
            "EXCELLENT",
            "TRES BON",
            "BON",
            "CORRECT",
            "MAUVAIS"});
            this.ComboBoxEtatMateriel.Location = new System.Drawing.Point(315, 153);
            this.ComboBoxEtatMateriel.Name = "ComboBoxEtatMateriel";
            this.ComboBoxEtatMateriel.Size = new System.Drawing.Size(106, 21);
            this.ComboBoxEtatMateriel.TabIndex = 41;
            // 
            // CleAgentDSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(904, 426);
            this.Controls.Add(this.ComboBoxEtatMateriel);
            this.Controls.Add(this.textBoxCodeSite);
            this.Controls.Add(this.LabelCodeSite);
            this.Controls.Add(this.textBoxSaisirMatricule);
            this.Controls.Add(this.LabelSaisirMatricule);
            this.Controls.Add(this.LabelService);
            this.Controls.Add(this.LabelDirection);
            this.Controls.Add(this.TextBoxService);
            this.Controls.Add(this.TextBoxDirection);
            this.Controls.Add(this.BValiderRecepisse);
            this.Controls.Add(this.ComboBoxStatutAgentDSI);
            this.Controls.Add(this.textBoxDateRetourEstimee);
            this.Controls.Add(this.textBoxDateAttributionMaterielAgent);
            this.Controls.Add(this.textBoxNomSite);
            this.Controls.Add(this.TextBoxCleAgentUtilisateur);
            this.Controls.Add(this.LabelStatut);
            this.Controls.Add(this.LabelDateRetourEstimee);
            this.Controls.Add(this.LabelAttributionMaterielAgent);
            this.Controls.Add(this.LabelNomSite);
            this.Controls.Add(this.LabelCleAgentUtilisateur);
            this.Controls.Add(this.LabelNumSerie);
            this.Controls.Add(this.LabelNumInventaire);
            this.Controls.Add(this.textBoxNumSerie);
            this.Controls.Add(this.textBoxNumInventaire);
            this.Controls.Add(this.textBoxTypeEquipement);
            this.Controls.Add(this.LabelEtatMateriel);
            this.Controls.Add(this.LabelAgentDSI);
            this.Controls.Add(this.LabelEquipement);
            this.Controls.Add(this.LabelMateriel);
            this.Controls.Add(this.TextBoxSite);
            this.Controls.Add(this.TextBoxPrenomAgentDSI);
            this.Controls.Add(this.TextBoxNomAgentDSI);
            this.Controls.Add(this.LabelSite);
            this.Controls.Add(this.LabelPrenom);
            this.Controls.Add(this.LabelNom);
            this.Name = "CleAgentDSI";
            this.Load += new System.EventHandler(this.AgentDSI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.Label LabelPrenom;
        private System.Windows.Forms.Label LabelSite;
        private System.Windows.Forms.TextBox TextBoxNomAgentDSI;
        private System.Windows.Forms.TextBox TextBoxPrenomAgentDSI;
        private System.Windows.Forms.TextBox TextBoxSite;
        private System.Windows.Forms.Label LabelMateriel;
        private System.Windows.Forms.Label LabelEquipement;
        private System.Windows.Forms.Label LabelAgentDSI;
        private System.Windows.Forms.Label LabelEtatMateriel;
        private System.Windows.Forms.TextBox textBoxNumInventaire;
        private System.Windows.Forms.TextBox textBoxNumSerie;
        private System.Windows.Forms.Label LabelNumInventaire;
        private System.Windows.Forms.Label LabelNumSerie;
        private System.Windows.Forms.Label LabelCleAgentUtilisateur;
        private System.Windows.Forms.Label LabelNomSite;
        private System.Windows.Forms.Label LabelAttributionMaterielAgent;
        private System.Windows.Forms.Label LabelDateRetourEstimee;
        private System.Windows.Forms.Label LabelStatut;
        private System.Windows.Forms.TextBox TextBoxCleAgentUtilisateur;
        private System.Windows.Forms.TextBox textBoxNomSite;
        private System.Windows.Forms.TextBox textBoxDateAttributionMaterielAgent;
        private System.Windows.Forms.TextBox textBoxDateRetourEstimee;
        private System.Windows.Forms.ComboBox ComboBoxStatutAgentDSI;
        private System.Windows.Forms.Button BValiderRecepisse;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox TextBoxDirection;
        private System.Windows.Forms.TextBox TextBoxService;
        private System.Windows.Forms.Label LabelDirection;
        private System.Windows.Forms.Label LabelService;
        private System.Windows.Forms.Label LabelSaisirMatricule;
        private System.Windows.Forms.TextBox textBoxSaisirMatricule;
        private System.Windows.Forms.TextBox textBoxTypeEquipement;
        private System.Windows.Forms.Label LabelCodeSite;
        private System.Windows.Forms.TextBox textBoxCodeSite;
        private System.Windows.Forms.ComboBox ComboBoxEtatMateriel;
    }
}