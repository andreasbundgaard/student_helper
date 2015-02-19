using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace student_helper
{
    class DatabaseController
    {
        public static SqlConnection connectToSql()
        {
            SqlConnection con = new SqlConnection(
                "Server=ealdb1.eal.local;" +
                "Database=EJL15_DB;" +
                "User Id=ejl15_usr;" +
                "Password=Baz1nga15"
                );
            return con;
        }
        public bool AddEventToDb(DateTime startdate, DateTime enddate, string comment, string eventtype)
        {
            SqlConnection con = connectToSql();
            try
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand("CreateEvent", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(new SqlParameter("@Startdate", startdate));
                sqlCmd.Parameters.Add(new SqlParameter("@Enddate", enddate));
                sqlCmd.Parameters.Add(new SqlParameter("@Comment", comment));
                sqlCmd.Parameters.Add(new SqlParameter("@EventType", eventtype));
                sqlCmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        public void GetEvents(string eventtype)
        {
            SqlConnection con = connectToSql();
            try
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand("GetEvent", con);
                sqlCmd.Parameters.Add(new SqlParameter("@EventType", eventtype));
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader;
                reader = sqlCmd.ExecuteReader();
                List<Schedule> eventList = new List<Schedule>();
                while (reader.Read())
                {
                    if (reader["EventType"].ToString().Equals("Schedule") || reader["EventType"].ToString().Equals("Other"))
                    {
                        Schedule events = new Schedule();
                        events.Startdate = Convert.ToDateTime(reader["Startdate"]);
                        events.Enddate = Convert.ToDateTime(reader["Enddate"]);
                        events.Comment = reader["Comment"].ToString();
                        events.EventType = reader["EventType"].ToString();
                        eventList.Add(events);
                    }
                    if (reader["EventType"].ToString().Equals("Homework"))
                    {
                        Schedule events = new Schedule();
                        events.Enddate = Convert.ToDateTime(reader["Enddate"]);
                        events.Comment = reader["Comment"].ToString();
                        events.EventType = reader["EventType"].ToString();
                        eventList.Add(events);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
