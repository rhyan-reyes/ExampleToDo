using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class ToDoService
    {
        public List<ToDo> GetAll()
        {
            using (var con = GetConnection())
            {
                var cmd = con.CreateCommand();

                cmd.CommandText = "ToDo_GetAll";
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = cmd.ExecuteReader())
                {
                    var totods = new List<ToDo>();

                    while (reader.Read()) {
                        var todo = new ToDo
                        {
                            Id = (int)reader["id"];
                        Task = (string)reader["task"];
                        DateCreated = (string)reader["dateCreated"];
                        }
                    }
                }
            }
        }

        public int Create(ToDoCreate request)
        {
        using (var con = GetConnection())
        {

        }
        }

        SqlConnection GetConnection()
        {
            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
            con.Open();

            return con;
        }
    }
}