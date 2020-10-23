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
            //dal.CreateTrainer("Kim", 8);
            dal.UpdatePokemon("Pikachu", "Pikapikapika", 2, 30, "Grass", null);
            dal.UpdateTrainer("Simon Olow", 2, 3);
            DataTable dt = dal.ReadAllPokemons();
            foreach(DataRow dr in dt.Rows)
            {
                foreach(var item in dr.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
