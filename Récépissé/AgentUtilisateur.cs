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
    public partial class AgentUtilisateur : Form
    {
        public AgentUtilisateur()
        {
            InitializeComponent();
        }

        private void BValiderRecepisse_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecepisseDispo pageMatricule = new RecepisseDispo();
            pageMatricule.ShowDialog();

            string sCnx = "server=localhost;uid=root;database=Attribution_materiel;port=3306;pwd=";
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

            string agentRequete = "INSERT into agent(nom_utilisateur,prenom_utilisateur, matricule) values ('" 
            + TextBoxNomAgentUtilisateur.Text + "','" + textBoxPrenomAgentUtilisateur.Text + "','" + textBoxSaisirMatricule.Text + "')";

                MySqlCommand requeteInsertionAgent = new MySqlCommand(agentRequete, Cnx);



            string recepisseRequete = "INSERT into recepisse(date_retour_reelle,statut) values ('" + textBoxDateRetourReelle.Text + 
                "', '" + ComboBoxStatutAgentUtilisateur.Text + "')";
               MySqlCommand requeteInsertionRecepisse = new MySqlCommand(recepisseRequete, Cnx);
     



        }


        private void textBoxSaisirMatricule_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelAgentUtilisateur_Click(object sender, EventArgs e)
        {

        }
    }
}
