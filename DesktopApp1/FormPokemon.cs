using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class FormPokemon : Form
    {
        Form1 form;
        FormTrainer ft;
        Controller controller = new Controller();
        ErrorHandling error = new ErrorHandling();
        public FormPokemon(Form1 form1)
        {
            form = form1;
            InitializeComponent();
        }
        public FormPokemon(FormTrainer formTrainer)
        {
            ft = formTrainer;
            InitializeComponent();
        }
        private void ErrorMessagebox(String errormessage)
        {
            String caption = "Error occured";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(errormessage, caption, buttons);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelType_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemoveFP_Click(object sender, EventArgs e)
        {
            try
            {
                int pk;
                pk = Int32.Parse(textBoxPidFP.Text);
                DialogResult removePokemonDR = MessageBox.Show("Are you sure you want to delete this Pokémon?", "Remove Pokémon", MessageBoxButtons.YesNo);
                if (removePokemonDR == DialogResult.Yes)
                {
                    controller.DeletePokemon(pk);
                    if (controller.FindPokemon(pk).pId.Equals(0))
                    {
                        MessageBox.Show($"Pokemon {pk} deleted");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                String errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
            }
        }

        private void ButtonUpdateFP_Click(object sender, EventArgs e)
        {
            int pId = Int32.Parse(textBoxPidFP.Text);
            int pLevel = (int)Math.Round(numericUpDownLevelFP.Value);
            string pName = textBoxNameFP.Text;
            string pType = textBoxTypeFP.Text;
            string nickname = textBoxNicknameFP.Text;
            int? tId;
            try
            {
                tId = Int32.Parse(textBoxTrainerId.Text);
            }
            catch (FormatException exe)
            {
                tId = null;
            }         
            try
            {
                if (controller.FindPokemon(pId).pId.Equals(0))
                {
                    MessageBox.Show("Pokémon does not exist. Perhaps another user has removed it");
                }       
                else
                {
                    controller.UpdatePokemon(pName, nickname, pId, pLevel, pType, tId);
                    MessageBox.Show("Pokémon successfully updated");
                }                              
            }
            catch (Exception ex)
            {
                String errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
            }
        }

        private void FormPokemon_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
