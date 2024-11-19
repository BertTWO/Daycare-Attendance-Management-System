using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Attendance_Management_System.Services
{
    public class Connection
    {


        public static MySqlConnection GetConnection()
        {
            string ConnectionString = "datasource=localhost;database=daycaredb;username=root;password=;";

            var conn = new MySqlConnection(ConnectionString);

            try
            {
                conn.Open();
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Server Error:\n" + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("System Error:\n" + ex.Message);
            }

            return conn;
        }

        public static int GetNextId(string tableName, string columnName)
        {
            int nextId = 1000;

            try
            {
                using (MySqlConnection connection = GetConnection())
                {

                    string query = $"SELECT MAX({columnName}) FROM {tableName}";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        var result = command.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            nextId = Convert.ToInt32(result) + 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return nextId;
        }

        public static void CreateUpdateDelete(string query, Dictionary<string, object> parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    using (MySqlCommand comm = new MySqlCommand(query, conn))
                    {
                        foreach (var item in parameters)
                        {
                            comm.Parameters.AddWithValue(item.Key, item.Value);
                        }
                        comm.ExecuteNonQuery();
                    }
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show("Server Error:\n" + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("System Error:\n" + ex.Message);
                }

            }
        }
    }
}
