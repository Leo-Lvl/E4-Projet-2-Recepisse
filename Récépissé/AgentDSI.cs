using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Récépissé
{
    public partial class CleAgentDSI : Form
    {
        public CleAgentDSI()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BValiderRecepisse_Click(object sender, EventArgs e)
        {   
            if (MessageBox.Show("Valider le récépissé ?", "Demande de confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) ;

            string sCnx = "server=localhost;uid=root;database=projet_recepisse;port=3306;pwd=";
            MySqlConnection Cnx = new MySqlConnection(sCnx);
            try
            {
                Cnx.Open();
                MessageBox.Show("Valider le récépissé ?", "Demande de confirmation");
            }
            catch (Exception f)
            {
                MessageBox.Show("erreur connexion " + f.Message.ToString());
            }



            string agentRequete = "INSERT into agent(nom_dsi, prenom_dsi, matricule, site, direction, service) values" +
                "('" + TextBoxNomAgentDSI.Text + "'," + " '" + TextBoxPrenomAgentDSI.Text + "','" + textBoxSaisirMatricule.Text + "'," +
                " '" + TextBoxSite.Text + "', '" + TextBoxDirection.Text + "', '" + TextBoxService.Text + "');";
            
                MySqlCommand requeteInsertionAgent = new MySqlCommand(agentRequete, Cnx);
                requeteInsertionAgent.ExecuteNonQuery();
            
                

            //string equipementRequete = "INSERT into materiel (type_equipement, etat_materiel) values(" + textBoxTypeEquipement.Text +
            //    ComboBoxEtatMateriel.Text + ")";
            string equipementRequete = String.Format("INSERT into materiel (type_equipement, etat_materiel) values({0},'{1}')",
                textBoxTypeEquipement.Text, ComboBoxEtatMateriel.Text);

            MySqlCommand requeteInsertionEquipement = new MySqlCommand(equipementRequete, Cnx);            
                requeteInsertionEquipement.ExecuteNonQuery();                 
               

            string recepisseRequete = "INSERT into recepisse(matricule, num_inventaire, date_retour_estime," +
                " date_retour_reel, statut) values ('" + textBoxSaisirMatricule.Text + "'," + " '" + textBoxNumInventaire.Text +
                "'," + " '" + textBoxDateRetourEstimee.Text + "'," + " '" + textBoxDateAttributionMaterielAgent.Text + "', '" +
                ComboBoxStatutAgentDSI.Text + "')";
                MySqlCommand requeteInsertionRecepisse = new MySqlCommand(recepisseRequete, Cnx);
               requeteInsertionRecepisse.ExecuteNonQuery();          

            string inventaireRequete = "INSERT into inventaire(Num_inventaire, Num_serie, Type) values (" +
                textBoxNumInventaire.Text + "," + textBoxNumSerie.Text + "," + textBoxTypeEquipement.Text + ")";
                MySqlCommand requeteInsertionInventaire = new MySqlCommand(inventaireRequete, Cnx);
                requeteInsertionInventaire.ExecuteNonQuery();
           
        

            string siteRequete = "INSERT into site(code_site, nom_site, cle_agent_utilisateur) values ('" + textBoxCodeSite.Text + "','" 
                + textBoxNomSite.Text + "','" + TextBoxCleAgentUtilisateur.Text + "')";
                MySqlCommand requeteInsertionSite = new MySqlCommand(siteRequete, Cnx);
            requeteInsertionSite.ExecuteNonQuery();

            string agentmaterielRequete = "INSERT into agentmateriel(date_attribution) values (" + textBoxDateAttributionMaterielAgent.Text + ")";
            MySqlCommand requeteInsertionagentmateriel = new MySqlCommand(agentmaterielRequete, Cnx);
            requeteInsertionagentmateriel.ExecuteNonQuery();


        }

        private void TextBoxPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgentDSI_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSaisirMatricule_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTypeEquipement_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
   
