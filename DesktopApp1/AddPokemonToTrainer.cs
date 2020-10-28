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
    public partial class AddPokemonToTrainer : Form
    {
        FormTrainer form;
        Controller controller = new Controller();
        ErrorHandling error = new ErrorHandling();
        Pokémon currentPokemon = new Pokémon();
        public int currentTID;
        public AddPokemonToTrainer(FormTrainer form)
        {
            this.form = form;
            InitializeComponent();                  
        }

        private void DataGridViewAddPokemon_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridViewAddPokemon.Columns.Contains("Trainer"))
            {
                dataGridViewAddPokemon.Columns.Remove("Trainer");
            }
        }

        private void BtnAddToTrainer_Click(object sender, EventArgs e)
        {
            AddPokemonToT();        
        }
        private void ErrorMessagebox(String errormessage)
        {
            String caption = "Error occured";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(errormessage, caption, buttons);
        }

        private void DataGridViewAddPokemon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddPokemonToT();
        }
        private void AddPokemonToT()
        {
            int pk;
            pk = Int32.Parse(dataGridViewAddPokemon.CurrentRow.Cells["pId"].Value.ToString());
            try
            {
                currentPokemon = controller.FindPokemon(pk);
                controller.UpdatePokemon(currentPokemon.pName, currentPokemon.nickname, pk, currentPokemon.pLevel, currentPokemon.pType, currentTID);
                dataGridViewAddPokemon.DataSource = controller.FindAllPokemons();
                dataGridViewAddPokemon.ClearSelection();
                foreach (DataGridViewRow row in dataGridViewAddPokemon.Rows)
                {
                    if (row.Cells["pId"].Value.ToString().Equals(pk.ToString()))
                    {
                        row.Selected = true;
                    }
                }
                MessageBox.Show($"{currentPokemon.pName} with ID {currentPokemon.pId} added!", "New Pokémon", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                string errormessage = error.GetMessage(ex);
                ErrorMessagebox(errormessage);
            }
        }
    }
}
