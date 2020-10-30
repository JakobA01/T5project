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
        public void CreateTrainer (string tName, int nbrOfBadges)
        {
            try
            {
                ProjectEntities entity = new ProjectEntities();
                entity.create_trainer(tName, nbrOfBadges);               
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
                ProjectEntities entity = new ProjectEntities();
                entity.create_pokémon(pName, nickName, pLevel, pType, tId);
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
                ProjectEntities entity = new ProjectEntities();
                entity.update_pokémon(pName, nickName, pLevel, pType, tId, pId);
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
                ProjectEntities entity = new ProjectEntities();
                entity.update_trainer(tName, nbrOfBadges, tId);
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
                ProjectEntities entity = new ProjectEntities();
                return entity.read_pokemon_trainer(tId).ToList();
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
                ProjectEntities entity = new ProjectEntities();
                entity.delete_trainer(tId);
                //projectEntities.SaveChanges();
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
                ProjectEntities entity = new ProjectEntities();
                entity.delete_pokémon(pId);
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
                ProjectEntities entity = new ProjectEntities();
                return entity.read_trainer(tId).ToList();
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
                ProjectEntities entity = new ProjectEntities();
                return entity.read_pokémon(pId).ToList();
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
                ProjectEntities entity = new ProjectEntities();
                return entity.read_all_pokémon().ToList();
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
                ProjectEntities entity = new ProjectEntities();
                return entity.read_all_trainer().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
