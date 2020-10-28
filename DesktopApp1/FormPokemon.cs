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
        public FormPokemon(Form1 form1)
        {
            form = form1;
            InitializeComponent();
        }
    }
}
