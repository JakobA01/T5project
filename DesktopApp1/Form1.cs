using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;

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
        System.Timers.Timer timer = new System.Timers.Timer(3000);
        public Form1()
        {
            InitializeComponent();
            //ShowSearch();
            //PopulateCbxTrainer();

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
            try
            {
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
                //PopulateCbxTrainer();
            }
            catch (Exception ex)
            {
                String errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
            }
            
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioBtnPokemon.Checked == true)
                {                
                    string name = textBoxName.Text;
                    string nickname = textBoxNickname.Text;
                    string type = textBoxType.Text;
                    int? trainerId = null;
                    int level = (int)Math.Round(numericUpDownLevel.Value, 0);
                    controller.CreatePokemon(name, nickname, level, type, trainerId);
                    MessageBox.Show("Pokemon was added");
                    textBoxName.Text = "Name";
                    textBoxNickname.Text = "Nickname";
                    textBoxType.Text = "Type";
                    numericUpDownLevel.Value = 1;
                    ShowSearch();
                    
                }
                else if (radioBtnTrainer.Checked == true)
                {
                    string name = textBoxName.Text;
                    int nbrOfBadges = (int)Math.Round(numericUpDownLevel.Value, 0);
                    controller.CreateTrainer(name, nbrOfBadges);
                    MessageBox.Show("Trainer was added");
                    textBoxName.Text = "Name";
                    ShowSearch();
                }
            }
            catch (Exception ex)
            {
                String errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            ShowSearch();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
            stopWatch.Stop();
        }

        private void ShowSearch()
        {
            try
            {
                if (radioBtnSearchPokemon.Checked == true)
                {
                    if (String.IsNullOrEmpty(textBoxSearch.Text.Trim()))
                    {
                        dataGridView.DataSource = controller.FindAllPokemons();
                        dataGridView.Columns.Remove("Trainer");
                        dataGridView.Columns["pId"].HeaderText = "Pokémon ID";
                        dataGridView.Columns["tId"].HeaderText = "Trainer ID";
                        dataGridView.Columns["pLevel"].HeaderText = "Level";
                        dataGridView.Columns["pType"].HeaderText = "Type";
                        dataGridView.Columns["pName"].HeaderText = "Name";
                        dataGridView.Columns["nickName"].HeaderText = "Nickname";
                    }
                    else
                    {
                        List<Pokémon> pokémons = controller.FindAllPokemons();
                        string search = textBoxSearch.Text.Trim();
                        List<Pokémon> searchList = new List<Pokémon>();
                        foreach (Pokémon p in pokémons)
                        {
                            if (p.pName.Equals(search))
                            {
                                searchList.Add(p);
                            }
                            else if (p.nickname.Equals(search))
                            {
                                searchList.Add(p);
                            }
                            else if (p.pId.ToString().Equals(search))
                            {
                                searchList.Add(p);
                            }
                            else if (p.pLevel.ToString().Equals(search))
                            {
                                searchList.Add(p);
                            }
                            else if (p.tId.ToString().Equals(search))
                            {
                                searchList.Add(p);
                            }
                            else if (p.pType.Equals(search))
                            {
                                searchList.Add(p);
                            }
                            else if (search.Equals("0") && !p.tId.HasValue)
                            {
                                searchList.Add(p);
                            }
                            else if (search.Equals("HasTrainer") && p.tId.HasValue)
                            {
                                searchList.Add(p);
                            }
                        }
                        dataGridView.DataSource = searchList;
                        dataGridView.Columns.Remove("Trainer");
                        dataGridView.Columns["pId"].HeaderText = "Pokémon ID";
                        dataGridView.Columns["tId"].HeaderText = "Trainer ID";
                        dataGridView.Columns["pLevel"].HeaderText = "Level";
                        dataGridView.Columns["pType"].HeaderText = "Type";
                        dataGridView.Columns["pName"].HeaderText = "Name";
                        dataGridView.Columns["nickName"].HeaderText = "Nickname";

                    }

                }
                else if (radioBtnSearchTrainer.Checked == true)
                {
                    if (String.IsNullOrEmpty(textBoxSearch.Text.Trim()))
                    {
                        dataGridView.DataSource = controller.FindAllTrainers();
                        dataGridView.Columns.Remove("Pokémon");
                        dataGridView.Columns["tId"].HeaderText = "Trainer ID";
                        dataGridView.Columns["nbrOfBadges"].HeaderText = "Badges";
                        dataGridView.Columns["tName"].HeaderText = "Name";
                    }
                    else
                    {
                        List<Trainer> trainers = controller.FindAllTrainers();
                        string search = textBoxSearch.Text.Trim();
                        List<Trainer> searchList = new List<Trainer>();
                        foreach (Trainer t in trainers)
                        {
                            if (t.tName.Equals(search))
                            {
                                searchList.Add(t);
                            }
                            else if (t.tId.ToString().Equals(search))
                            {
                                searchList.Add(t);
                            }
                            else if (t.nbrOfBadges.ToString().Equals(search))
                            {
                                searchList.Add(t);
                            }
                        }
                        dataGridView.DataSource = searchList;
                        dataGridView.Columns.Remove("Pokémon");
                        dataGridView.Columns["tId"].HeaderText = "Trainer ID";
                        dataGridView.Columns["nbrOfBadges"].HeaderText = "Badges";
                        dataGridView.Columns["tName"].HeaderText = "Name";

                    }
                }
                dataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                String errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*private void PopulateCbxTrainer()
        {
            comboBoxTrainer.DataSource = controller.FindAllTrainers();
            comboBoxTrainer.DisplayMember = "tName";
            comboBoxTrainer.ValueMember = "tId";

        }*/


        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateWindowOpen();
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {

        }
        private void UpdateWindowOpen()
        {
            try
            {
                int pk;
                if (dataGridView.Columns.Contains("pId"))
                {                   
                    pk = Int32.Parse(dataGridView.CurrentRow.Cells["pId"].Value.ToString());
                    currentPokemon = controller.FindPokemon(pk);
                    FormPokemon fp = new FormPokemon(this);
                    fp.textBoxPidFP.Text = currentPokemon.pId.ToString();
                    fp.textBoxNameFP.Text = currentPokemon.pName;
                    fp.textBoxNicknameFP.Text = currentPokemon.nickname;
                    fp.textBoxTypeFP.Text = currentPokemon.pType;
                    fp.numericUpDownLevelFP.Value = currentPokemon.pLevel;
                    fp.textBoxTrainerId.Text = controller.FindTrainerFromPokemon(pk);
                    fp.FormClosing += new FormClosingEventHandler(this.FormPokemon_FormClosing);
                    fp.ShowDialog();
                }
                else
                {
                    try
                    {
                        pk = Int32.Parse(dataGridView.CurrentRow.Cells["tId"].Value.ToString());
                        currentTrainer = controller.FindTrainer(pk);
                        FormTrainer ft = new FormTrainer(this);
                        ft.textBoxTrainerIdFT.Text = currentTrainer.tId.ToString();
                        ft.textBoxNameFT.Text = currentTrainer.tName;
                        ft.numericUpDownNbrBadgesFT.Value = currentTrainer.nbrOfBadges;
                        ft.dataGridView1.DataSource = controller.FindPokemonsTrainer(pk);
                        ft.dataGridView1.Columns["pId"].HeaderText = "Pokémon ID";
                        ft.dataGridView1.Columns["tId"].HeaderText = "Trainer ID";
                        ft.dataGridView1.Columns["pLevel"].HeaderText = "Level";
                        ft.dataGridView1.Columns["pType"].HeaderText = "Type";
                        ft.dataGridView1.Columns["pName"].HeaderText = "Name";
                        ft.dataGridView1.Columns["nickName"].HeaderText = "Nickname";
                        ft.FormClosing += new FormClosingEventHandler(this.FormTrainer_FormClosing);
                        ft.ShowDialog();
                    }
                    catch (NullReferenceException exe)
                    {
                        MessageBox.Show("Please select something first");
                    }
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
            ShowSearch();
        }
        private void FormTrainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowSearch();
        }
        public void CurrentTarget()
        {
            try
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
            catch (Exception ex)
            {
                String errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
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

        private void RadioBtnTrainer_CheckedChanged_1(object sender, EventArgs e)
        {
            textBoxName.Text = "Name";
            textBoxNickname.Visible = false;
            textBoxType.Visible = false;
            lblLevel.Text = "Badges:";
        }

        private void RadioBtnPokemon_CheckedChanged_1(object sender, EventArgs e)
        {
            textBoxName.Text = "Name";
            textBoxNickname.Text = "Nick name";
            textBoxType.Text = "Type";
            textBoxNickname.Visible = true;
            textBoxType.Visible = true;
            lblLevel.Text = "Level:";
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult pikachuMessage = MessageBox.Show("Pika pika :)", "Secret Pikachu message", MessageBoxButtons.OK);
            if (pikachuMessage == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=rg6CiPI6h2g");
            }
        }

        private void BtnBattle_Click(object sender, EventArgs e)
        {
            FormBattle fb = new FormBattle(this);
            fb.progressBarYou.Value = 100;
            fb.progressBarOpponent.Value = 100;
            fb.lblBattleText.Text = "A wild machoke appeared!";
            fb.lblOpponentHP.Text = "HP: 100%";
            fb.lblYourHP.Text = "HP: 100%";
            fb.ShowDialog();
        }


        /* private void DataGridView_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
         {

         }

         private void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             DataGridViewColumn column = dataGridView.Columns[e.ColumnIndex];
             dataGridView.Sort(column, ListSortDirection.Ascending);
         }

         private void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
         {
             foreach(DataGridViewColumn column in dataGridView.Columns)
             {
                 column.SortMode = DataGridViewColumnSortMode.Programmatic;
             }
         }*/
    }
}
