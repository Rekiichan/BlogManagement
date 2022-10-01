using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogManagement;
using System.Data;

namespace BlogManagement.Database
{
    internal class Dtb
    {
        private string _connectionString;
        public Dtb(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Default");
        }

        public List<Blogger> GetBloggers()
        {
            var bloggers = new List<Blogger>();
            try
            {
                using var con = new SqlConnection(_connectionString);
                SqlCommand cmd = new SqlCommand("GetBloggers",con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bloggers.Add(new Blogger
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Name = reader["Name"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Email = reader["Email"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        BirthDate = reader.GetDateTime("Birthday"),
                        RegistrationDate = reader.GetDateTime("RegistrationDate"),
                        Address = reader["Address"].ToString(),
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return bloggers;
        }
        public void WriteBlogger(List<Blogger> Blg)
        {
            var bloggers = new List<Blogger>();
            try
            {
                using var con = new SqlConnection(_connectionString);
                SqlCommand cmd = new SqlCommand("GetBloggers", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bloggers.Add(new Blogger
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Name = reader["Name"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Email = reader["Email"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        BirthDate = reader.GetDateTime("Birthday"),
                        RegistrationDate = reader.GetDateTime("RegistrationDate"),
                        Address = reader["Address"].ToString(),
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
