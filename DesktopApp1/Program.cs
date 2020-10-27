using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DesktopApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            DAL dal = new DAL();
            Controller controller = new Controller();
            /*controller.CreateTrainer("David", 8);
            controller.CreateTrainer("Ash Ketchup", 5);
            controller.CreatePokemon("Blastoise", "Blasse", 50, "Water", null);
            controller.CreatePokemon("Charmander", "Charre", 5, "Fire", null);
            controller.UpdatePokemon("Farfetch'd", "Farre", 3, 30, "Normal", 8);
            controller.DeletePokemon(2);
            controller.DeleteTrainer(2);*/
            controller.UpdateTrainer("Jakob", 5, 10);
            //controller.CreatePokemon("Raichu", "Simon", 3, "Electric", null);    
        }
    }
}
