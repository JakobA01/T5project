using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        ErrorHandling error = new ErrorHandling();
        Trainer currentTrainer;
        Pok�mon currentPokemon;
        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
            //ShowSearch();
            PopulateCbxTrainer();

        }
        private void ErrorMessagebox(String errormessage)
        {
            String caption = "Error occured";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(errormessage, caption, buttons);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxTId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonTestTrainer_Click(object sender, EventArgs e)
        {
            FormTrainer formTrainer = new FormTrainer(this);
            formTrainer.ShowDialog();

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateWindowOpen();
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            int pk;
            if (dataGridView.Columns.Contains("pId"))
            {
                pk = Int32.Parse(dataGridView.CurrentRow.Cells["pId"].Value.ToString());
                currentPokemon = controller.FindPokemon(pk);
                DialogResult removePokemonDR = MessageBox.Show($"Are you sure you want to delete {currentPokemon.pName} with Id: {currentPokemon.pId}?", "Remove Pok�mon", MessageBoxButtons.YesNo);
                if (removePokemonDR == DialogResult.Yes)
                {
                    controller.DeletePokemon(pk);
                    if (controller.FindPokemon(pk).pId.Equals(0))
                    {                       
                        MessageBox.Show($"Pokemon {pk} deleted");
                        ShowSearch();
                    }
                }
            }
            else
            {
                pk = Int32.Parse(dataGridView.CurrentRow.Cells["tId"].Value.ToString());
                currentTrainer = controller.FindTrainer(pk);
                DialogResult removeTrainerDR = MessageBox.Show($"Are you sure you want to delete {currentTrainer.tName} with Id: {currentTrainer.tId}?", "Remove Trainer", MessageBoxButtons.YesNo);
                if (removeTrainerDR == DialogResult.Yes)
                {
                    controller.DeleteTrainer(pk);
                    if (controller.FindTrainer(pk).tId.Equals(0))
                    {
                        Console.WriteLine("DEEELEEETE TRAINER");
                        Console.WriteLine(controller.FindTrainer(pk).tId);                        
                        MessageBox.Show($"Trainer {pk} deleted");
                        ShowSearch();
                    }
                }
            }
            PopulateCbxTrainer();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (radioBtnPokemon.Checked == true)
            {
                string name = textBoxName.Text;
                string nickname = textBoxNickname.Text;
                string type = textBoxType.Text;
                int? trainerId = (int?)comboBoxTrainer.SelectedValue;
                int level = (int)Math.Round(numericUpDownLevel.Value, 0);
                try
                {
                    controller.CreatePokemon(name, nickname, level, type, trainerId);
                }
                catch (Exception ex)
                {
                    String errormessage = error.GetMessage(ex);
                    ErrorMessagebox(errormessage);
                }
            }
            else if (radioBtnTrainer.Checked == true)
            {
                string name = textBoxName.Text;
                int nbrOfBadges = (int)Math.Round(numericUpDownLevel.Value, 0);
                try
                {
                    controller.CreateTrainer(name, nbrOfBadges);
                }
                catch (Exception ex)
                {
                    String errormessage = error.GetMessage(ex);
                    ErrorMessagebox(errormessage);
                }
            }
            PopulateCbxTrainer();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ShowSearch();
            }
            catch (Exception ex)
            {
                String errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
            }
            
        }

        private void ShowSearch()
        {
            try
            {
<<<<<<< HEAD
                while (dataGridView.Rows.Count > 0)
                {
                    dataGridView.Rows.RemoveAt(0);
                }
                Console.WriteLine("Showsearch yea");
                dataGridView.DataSource = controller.FindAllPokemons();
                dataGridView.Columns.Remove("Trainer");
                dataGridView.Columns["pId"].HeaderText = "Pok�monId";
                dataGridView.Columns["tId"].HeaderText = "TrainerId";
                Console.WriteLine("Showsearch done");
=======
                if (radioBtnSearchPokemon.Checked == true)
                {
                    dataGridView.DataSource = controller.FindAllPokemons();
                    dataGridView.Columns.Remove("Trainer");
                    dataGridView.Columns["pId"].HeaderText = "Pok�mon ID";
                    dataGridView.Columns["tId"].HeaderText = "Trainer ID";
                    dataGridView.Columns["pLevel"].HeaderText = "Level";
                    dataGridView.Columns["pType"].HeaderText = "Type";
                    dataGridView.Columns["pName"].HeaderText = "Name";
                    dataGridView.Columns["nickName"].HeaderText = "Nickname";
>>>>>>> master

                }
                else if (radioBtnSearchTrainer.Checked == true)
                {
                    dataGridView.DataSource = controller.FindAllTrainers();
                    dataGridView.Columns.Remove("Pok�mon");
                    dataGridView.Columns["tId"].HeaderText = "Trainer ID";
                    dataGridView.Columns["nbrOfBadges"].HeaderText = "Badges";
                    dataGridView.Columns["tName"].HeaderText = "Name";
                }
                dataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                while (dataGridView.Rows.Count > 0)
                {
                    dataGridView.Rows.RemoveAt(0);
                }
                dataGridView.DataSource = controller.FindAllTrainers();
                dataGridView.Columns.Remove("Pok�mon");
                dataGridView.Columns["tId"].HeaderText = "TrainerId";
=======
                throw ex;
>>>>>>> master
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void PopulateCbxTrainer()
        {
            comboBoxTrainer.DataSource = controller.FindAllTrainers();
            comboBoxTrainer.DisplayMember = "tName";
            comboBoxTrainer.ValueMember = "tId";
        }


        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateWindowOpen();
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {

        }
        private void UpdateWindowOpen()
        {
            int pk;
            if (dataGridView.ColumnCount > 3)
            {
                pk = Int32.Parse(dataGridView.CurrentRow.Cells[3].Value.ToString());
                currentPokemon = controller.FindPokemon(pk);
                FormPokemon fp = new FormPokemon(this);
                fp.textBoxNameFP.Text = currentPokemon.pName;
                fp.textBoxNicknameFP.Text = currentPokemon.nickname;
                fp.textBoxTypeFP.Text = currentPokemon.pType;
                fp.numericUpDownLevelFP.Value = currentPokemon.pLevel;
                fp.textBoxTrainerId.Text = controller.FindTrainerFromPokemon(pk);
                fp.ShowDialog();
            }
            else
            {
                pk = Int32.Parse(dataGridView.CurrentRow.Cells[1].Value.ToString());
                currentTrainer = controller.FindTrainer(pk);
                FormTrainer ft = new FormTrainer(this);
                ft.textBoxTrainerIdFT.Text = currentTrainer.tId.ToString();
                ft.textBoxNameFT.Text = currentTrainer.tName;
                ft.numericUpDownNbrBadgesFT.Value = currentTrainer.nbrOfBadges;
                ft.dataGridView1.DataSource = controller.FindPokemonsTrainer(pk);

                ft.ShowDialog();
            }
        }
        public void CurrentTarget()
        {
            int pk;
            if (dataGridView.ColumnCount > 3)
            {
                pk = Int32.Parse(dataGridView.CurrentRow.Cells[3].Value.ToString());
                currentPokemon = controller.FindPokemon(pk);
                currentTrainer = new Trainer();
            }
            else if (dataGridView.ColumnCount < 3)
            {
                pk = Int32.Parse(dataGridView.CurrentRow.Cells[1].Value.ToString());
                currentTrainer = controller.FindTrainer(pk);
                currentPokemon = new Pok�mon();
            }
        }

        private void RadioBtnPokemon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPokemon.Checked == true)
            {
                textBoxNickname.Visible = true;
                textBoxType.Visible = true;
                numericUpDownLevel.Maximum = 100;
                numericUpDownLevel.Minimum = 0;
            }
        }

        private void RadioBtnTrainer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnTrainer.Checked == true)
            {
                textBoxNickname.Visible = false;
                textBoxType.Visible = false;
                numericUpDownLevel.Maximum = 8;
                numericUpDownLevel.Minimum = 0;
            }
        }
    }
}
