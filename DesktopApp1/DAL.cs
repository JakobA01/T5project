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

        public void CreateTrainer(string tName, int nbrOfBadges)
        {
            using (ProjectEntities projectEntities = new ProjectEntities())
            {
                projectEntities.create_trainer(tName, nbrOfBadges);
            }
        }
        public void CreatePokemon (string pName, string nickName, int pLevel, string pType, int tId)
        {
            using (ProjectEntities projectEntities = new ProjectEntities())
            {
                projectEntities.create_pokémon(pName,nickName,pLevel,pType,tId);
            }
        }
        public void UpdatePokemon(string pName, string nickName, int pId, int pLevel, string pType, int tId)
        {
            using (ProjectEntities projectEntities = new ProjectEntities())
            {
                projectEntities.update_pokémon(pName, nickName, pLevel, pType, tId, pId);
            }
        }
        public void UpdateTrainer(string tName, int tId, int nbrOfBadges)
        {
            using (ProjectEntities projectEntities = new ProjectEntities())
            {
                projectEntities.update_trainer(tName, tId, nbrOfBadges);
            }
        }
        public void DeleteTrainer(int tId)
        {
            using (ProjectEntities projectEntities = new ProjectEntities())
            {
                projectEntities.delete_trainer(tId);
            }
        }
        public void DeletePokemon(int pId)
        {
            using (ProjectEntities projectEntities = new ProjectEntities())
            {
                projectEntities.delete_pokémon(pId);
            }
        }
        public List<Trainer> ReadTrainer(int tId)
        {
            using (ProjectEntities projectEntities = new ProjectEntities())
            {
                return projectEntities.read_trainer(tId).ToList();
            }
        }
        public List<Pokémon> ReadPokemon(int pId)
        {
            using (ProjectEntities projectEntities = new ProjectEntities())
            {
                return projectEntities.read_pokémon(pId).ToList();
            }
        }
        public List<Pokémon> ReadAllPokemon()
        {
            using (ProjectEntities projectEntities = new ProjectEntities())
            {
                return projectEntities.read_all_pokémon().ToList();
            }
        }
        public List<Trainer> ReadAllTrainer()
        {
            using (ProjectEntities projectEntities = new ProjectEntities())
            {
                return projectEntities.read_all_trainer().ToList();
            }
        }
    }
}
