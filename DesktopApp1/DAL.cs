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
        private readonly string connectionString = "Server=(local);Database=Project;Integrated security=true";

        public void CreateTrainer(string tName, int nbrOfBadges)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("create_trainer", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@tName", tName));
                command.Parameters.Add(new SqlParameter("@nbrOfBadges", nbrOfBadges));
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public void CreatePokemon(string pName, string nickName, int pLevel, string pType, int tId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("create_pokémon", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@pName", pName));
                command.Parameters.Add(new SqlParameter("@nickName", nickName));
                command.Parameters.Add(new SqlParameter("@pLevel", pLevel));
                command.Parameters.Add(new SqlParameter("@pType", pType));
                command.Parameters.Add(new SqlParameter("@tId", tId));
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public void UpdatePokemon(string pName, string nickName, int pId, int pLevel, string pType, int? tId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("update_pokémon", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@pName", pName));
                command.Parameters.Add(new SqlParameter("@nickName", nickName));
                command.Parameters.Add(new SqlParameter("@pLevel", pLevel));
                command.Parameters.Add(new SqlParameter("@pType", pType));
                if (tId.HasValue)
                {
                    command.Parameters.Add(new SqlParameter("@tId", tId));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("@tId", DBNull.Value));
                }
                command.Parameters.Add(new SqlParameter("@pId", pId));
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public void UpdateTrainer(string tName, int tId, int nbrOfBadges)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("update_trainer", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@tName", tName));
                command.Parameters.Add(new SqlParameter("@nbrOfBadges", nbrOfBadges));
                command.Parameters.Add(new SqlParameter("@tId", tId));
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public void DeleteTrainer(int tId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("delete_trainer", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@tId", tId));
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public void DeletePokemon(int tId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("delete_pokémon", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@pId", tId));
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public DataTable ReadTrainer(int tId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("read_trainer", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@tId", tId));
                sqlConnection.Open();               
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        public DataTable ReadPokemon(int pId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("read_pokémon", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@pId", pId));
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        public DataTable ReadAllTrainers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("read_all_trainer", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        public DataTable ReadAllPokemons()
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("read_all_pokémon", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
    }
}
