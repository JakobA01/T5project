using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp1
{
    class Controller
    {
        DAL dal = new DAL();

        public Trainer FindTrainer(int tId)
        {
            List<Trainer> trainers = dal.ReadTrainer(tId);
            Trainer trainer = new Trainer();
            foreach (Trainer t in trainers)
            {
                trainer = t;
            }
            return trainer;
        }
        public Pokémon FindPokemon(int pId)
        {
            List<Pokémon> pokemons = dal.ReadPokemon(pId);
            Pokémon pokemon = new Pokémon();
            foreach (Pokémon p in pokemons)
            {
                pokemon = p;
            }
            return pokemon;
        }
        public List<Pokémon> FindAllPokemons()
        {
            return dal.ReadAllPokemon().ToList();
        }
        public List<Trainer> FindAllTrainers()
        {
            return dal.ReadAllTrainer().ToList();
        }
        public void CreatePokemon(string pName, string nickName, int pLevel, string pType, int? tId)
        {
            dal.CreatePokemon(pName, nickName, pLevel, pType, tId);
        }
        public void createTrainer(string tName, int nbrOfBadges)
        {
            dal.CreateTrainer(tName, nbrOfBadges);
        }
        public List<Pokémon> FindPokemonsTrainer(int tId)
        {
            return dal.ReadPokemonsTrainer(tId).ToList();
        }
        public void UpdatePokemon(string pName, string nickName, int pId, int pLevel, string pType, int? tId)
        {
            dal.UpdatePokemon(pName, nickName, pId, pLevel, pType, tId);
        }
        public void UpdateTrainer(string tName, int tId, int nbrOfBadges)
        {
            dal.UpdateTrainer(tName, tId, nbrOfBadges);
        }
        public void DeleteTrainer(int tId)
        {
            dal.DeleteTrainer(tId);
        }
        public void DeletePokemon(int pId)
        {
            dal.DeletePokemon(pId);
        }

    }
}
