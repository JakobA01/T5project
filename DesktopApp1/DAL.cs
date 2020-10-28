using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DesktopApp1
{
    class DAL
    {
        //private readonly string connectionString = "Server=(local);Database=Project;Integrated security=true";
        ErrorHandling error = new ErrorHandling();
        ProjectEntities projectEntities = new ProjectEntities();
        public void CreateTrainer(string tName, int nbrOfBadges)
        {
            try
            {
                projectEntities.create_trainer(tName, nbrOfBadges);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void CreatePokemon (string pName, string nickName, int pLevel, string pType, int? tId)
        {
            try
            {                
                projectEntities.create_pokémon(pName, nickName, pLevel, pType, tId);
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
                projectEntities.update_pokémon(pName, nickName, pLevel, pType, tId, pId);
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
                projectEntities.update_trainer(tName, nbrOfBadges, tId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Pokémon> ReadPokemonsTrainer(int tId)
        {
            try
            {
                return projectEntities.read_pokemon_trainer(tId).ToList();
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
                projectEntities.delete_trainer(tId);
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
                projectEntities.delete_pokémon(pId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Trainer> ReadTrainer(int tId)
        {
            try
            {
                return projectEntities.read_trainer(tId).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Pokémon> ReadPokemon(int pId)
        {
            try
            {
                return projectEntities.read_pokémon(pId).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Pokémon> ReadAllPokemon()
        {
            try
            {
                return projectEntities.read_all_pokémon().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Trainer> ReadAllTrainer()
        {
            try
            {
                return projectEntities.read_all_trainer().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
