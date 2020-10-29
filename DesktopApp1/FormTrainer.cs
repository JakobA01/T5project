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
    public partial class FormTrainer : Form
    {
        Form1 form;
        Controller controller = new Controller();
        ErrorHandling error = new ErrorHandling();
        Pokémon currentPokemon = new Pokémon();
        public FormTrainer(Form1 form1)
        {
            InitializeComponent();
            form = form1;
            
        }
        private void ErrorMessagebox(String errormessage)
        {
            String caption = "Error occured";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(errormessage, caption, buttons);
        }

        private void TextBoxNickname_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                AddPokemonToTrainer form = new AddPokemonToTrainer(this);
                form.currentTID = Int32.Parse(textBoxTrainerIdFT.Text);
                form.dataGridViewAddPokemon.DataSource = controller.FindAllPokemons();
                form.FormClosing += new FormClosingEventHandler(this.AddPokemonToTrainer_FormClosing);
                form.dataGridViewAddPokemon.Columns["pId"].HeaderText = "Pokémon ID";
                form.dataGridViewAddPokemon.Columns["tId"].HeaderText = "Trainer ID";
                form.dataGridViewAddPokemon.Columns["pLevel"].HeaderText = "Level";
                form.dataGridViewAddPokemon.Columns["pType"].HeaderText = "Type";
                form.dataGridViewAddPokemon.Columns["pName"].HeaderText = "Name";
                form.dataGridViewAddPokemon.Columns["nickName"].HeaderText = "Nickname";
                //AddPokemonToTrainer fp = new AddPokemonToTrainer(this);           
                //fp.FormClosing += new FormClosingEventHandler(this.FormPokemon_FormClosing);
                //fp.buttonUpdateFP.Click += new EventHandler(this.FormPokemon_FormClosing);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                String errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
            }
           
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxTrainer_Click(object sender, EventArgs e)
        {

        }

        private void ButtonUpdateTrainerFT_Click(object sender, EventArgs e)
        {
            int tId = Int32.Parse(textBoxTrainerIdFT.Text);
            int nbrOfBadges = (int)Math.Round(numericUpDownNbrBadgesFT.Value);
            string tName = textBoxNameFT.Text;

            try
            {
                controller.UpdateTrainer(tName, nbrOfBadges, tId);
            }
            catch (Exception ex)
            {
                String errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void FormPokemon_FormClosing(object sender, FormClosingEventArgs e)
        {
            populateDataGrid();
        }
        private void AddPokemonToTrainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            populateDataGrid();
        }
        public void populateDataGrid()
        {
            try
            {
                int pk = Int32.Parse(this.textBoxTrainerIdFT.Text);
                dataGridView1.DataSource = controller.FindPokemonsTrainer(pk);
            }
            catch (Exception ex)
            {
                String errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
            }


            /*if (dataGridView1.Columns.Contains("Trainer"))
            {
                dataGridView1.Columns.Remove("Trainer");
            }*/
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Columns.Contains("Trainer"))
            {
                dataGridView1.Columns.Remove("Trainer");
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int pk;
                pk = Int32.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                currentPokemon = controller.FindPokemon(pk);
                FormPokemon fp = new FormPokemon(this);
                fp.textBoxPidFP.Text = currentPokemon.pId.ToString();
                fp.textBoxNameFP.Text = currentPokemon.pName;
                fp.textBoxNicknameFP.Text = currentPokemon.nickname;
                fp.textBoxTypeFP.Text = currentPokemon.pType;
                fp.numericUpDownLevelFP.Value = currentPokemon.pLevel;
                fp.textBoxTrainerId.Text = controller.FindTrainerFromPokemon(pk);
                fp.FormClosing += new FormClosingEventHandler(this.FormPokemon_FormClosing);
                //fp.buttonUpdateFP.Click += new EventHandler(this.FormPokemon_FormClosing);
                fp.ShowDialog();
            }
            catch (Exception ex)
            {
                String errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
            }

        }

        private void ButtonUpdateTrainerFT_Click_1(object sender, EventArgs e)
        {
            try
            {
                int tId = Int32.Parse(textBoxTrainerIdFT.Text.ToString());
                string tName = textBoxNameFT.Text;
                int nbrOfBadges = (int)Math.Round(numericUpDownNbrBadgesFT.Value);
                controller.UpdateTrainer(tName, nbrOfBadges, tId);
                MessageBox.Show("Trainer updated!", $"{tId} sucessfully updated", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                String errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
            }
        }

        private void ButtonRemovePokemonFT_Click(object sender, EventArgs e)
        {
            try
            {
                int pk;
                pk = Int32.Parse(dataGridView1.CurrentRow.Cells["pId"].Value.ToString());
                Pokémon pokemon = new Pokémon();
                pokemon = controller.FindPokemon(pk);
                DialogResult removePokemon = MessageBox.Show($"Are you sure you want to remove {pokemon.pName} with Id: {pokemon.pId} from trainer {textBoxNameFT.Text}?", "Remove pokémon", MessageBoxButtons.YesNo);
                if (removePokemon == DialogResult.Yes)
                {
                    controller.UpdatePokemon(pokemon.pName, pokemon.nickname, pk, pokemon.pLevel, pokemon.pType, null);
                    if (controller.FindTrainerFromPokemon(pk).Equals("Stray pokémon"))
                    {
                        dataGridView1.DataSource = controller.FindPokemonsTrainer(Int32.Parse(textBoxTrainerIdFT.Text));
                        MessageBox.Show("Pokémon successfully removed");
                    }
                }
            }
            catch (Exception ex)
            {
                String errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
            }
            
        }

        private void ButtonRemoveTrainerFT_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult removeTrainer = MessageBox.Show("Are you sure you want to remove this trainer?", "Remove trainer", MessageBoxButtons.YesNo);
                if(removeTrainer == DialogResult.Yes)
                {
                    int tId = Int32.Parse(textBoxTrainerIdFT.Text);
                    controller.DeleteTrainer(tId);
                    if (controller.FindTrainer(tId).tId.Equals(0))
                    {
                        this.Close();
                        MessageBox.Show("Trainer was successfully removed");
                    }
                }
                
            }
            catch (Exception ex)
            {
                String errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
            }
        }
    }
}
