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
    }
}
