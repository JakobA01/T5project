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
        Pokémon currentPokemon;
        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
            ShowSearch();
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
                DialogResult removePokemonDR = MessageBox.Show($"Are you sure you want to delete {currentPokemon.pName} with Id: {currentPokemon.pId}?", "Remove Pokémon", MessageBoxButtons.YesNo);
                if (removePokemonDR == DialogResult.Yes)
                {
                    controller.DeletePokemon(pk);
                    if (controller.FindPokemon(pk).pId.Equals(0))
                    {
                        ShowSearch();
                        MessageBox.Show($"Pokemon {pk} deleted");
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
                        ShowSearch();
                        MessageBox.Show($"Trainer {pk} deleted");
                    }
                }
            }
            PopulateCbxTrainer();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string nickname = textBoxNickname.Text;
            string type = textBoxType.Text;
            int? trainerId = (int?)comboBoxTrainer.SelectedValue;
            int level = (int)Math.Round(numericUpDownLevel.Value, 0);


            controller.CreatePokemon(name, nickname, level, type, trainerId);
            
            Console.WriteLine(name + nickname + type);
            Console.WriteLine(trainerId);
            Console.WriteLine(level);
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

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            ShowSearch();
        }

        private void ShowSearch()
        {
            dataGridView.DataSource = null;
            if (radioBtnSearchPokemon.Checked == true)
            {
                dataGridView.DataSource = controller.FindAllPokemons();
                dataGridView.Columns.Remove("Trainer");
                dataGridView.Columns["pId"].HeaderText = "PokémonId";
                dataGridView.Columns["tId"].HeaderText = "TrainerId";

            }
            else if (radioBtnSearchTrainer.Checked == true)
            {
                dataGridView.DataSource = controller.FindAllTrainers();
                dataGridView.Columns.Remove("Pokémon");
                dataGridView.Columns["tId"].HeaderText = "TrainerId";
            }
            dataGridView.ClearSelection();
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
                currentPokemon = new Pokémon();
            }
        }
    }
}
