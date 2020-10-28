using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DesktopApp1
{
    class Controller
    {
        DAL dal = new DAL();
        ErrorHandling error = new ErrorHandling();
        public Trainer FindTrainer(int tId)
        {
            try
            {
                List<Trainer> trainers = dal.ReadTrainer(tId);
                Trainer trainer = new Trainer();
                foreach (Trainer t in trainers)
                {
                    trainer = t;
                }
                return trainer;
            }
            catch (Exception e)
            {
                throw e;
            }           
        }
        public Pokémon FindPokemon(int pId)
        {
            try
            {
                List<Pokémon> pokemons = dal.ReadPokemon(pId);
                Pokémon pokemon = new Pokémon();
                foreach (Pokémon p in pokemons)
                {
                    pokemon = p;
                }
                return pokemon;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Pokémon> FindAllPokemons()
        {
            try
            {
                return dal.ReadAllPokemon().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Trainer> FindAllTrainers()
        {
            try
            {
                return dal.ReadAllTrainer().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
        public void CreatePokemon(string pName, string nickName, int pLevel, string pType, int? tId)
        {
            try
            {
                dal.CreatePokemon(pName, nickName, pLevel, pType, tId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void CreateTrainer(string tName, int nbrOfBadges)
        {
            try
            {
                dal.CreateTrainer(tName, nbrOfBadges);
            }
            catch (Exception e)
            {
                throw e;
            }           
        }
        public List<Pokémon> FindPokemonsTrainer(int tId)
        {
            try
            {
                return dal.ReadPokemonsTrainer(tId).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void UpdatePokemon(string pName, string nickName, int pId, int pLevel, string pType, int? tId)
        {
            try
            {
                dal.UpdatePokemon(pName, nickName, pId, pLevel, pType, tId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void UpdateTrainer(string tName, int nbrOfBadges, int tId)
        {
            try
            {
                dal.UpdateTrainer(tName, nbrOfBadges, tId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeleteTrainer(int tId)
        {
            try
            {
                dal.DeleteTrainer(tId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeletePokemon(int pId)
        {
            try
            {
                dal.DeletePokemon(pId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string FindTrainerFromPokemon(int pId)
        {
            string tmpString = "";
            Pokémon p = FindPokemon(pId);
            Console.WriteLine("FindTrainer from pokemon:");
            Console.WriteLine(p.tId);
            if(p.tId.GetValueOrDefault() != 0)
            {
                Console.WriteLine("Inne i ifSatsen");
                Console.WriteLine(p.tId);
                Trainer t = FindTrainer((int)p.tId);
                tmpString = t.tName + t.tId.ToString();
                Console.WriteLine(tmpString);
            }
            else
            {
                tmpString = "Stray pokémon";
            }
            return tmpString;
        }
        
    }
}
