using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace mayur_education.Models
{
    public class Contactdb
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dharmesh\\source\\repos\\mayur_education\\App_Data\\Mayur_Eduction.mdf;Integrated Security=True");
    
        public string ServerRecord(ContactModel ct)
        {

            try
            {
                SqlCommand com = new SqlCommand("Sp_Contact_Add", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", ct.Name);
                com.Parameters.AddWithValue("@Email", ct.Email);
                com.Parameters.AddWithValue("@Phone", ct.Phone);
                com.Parameters.AddWithValue("@Message", ct.Message);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                return ("OK");
            }
            catch (Exception ex)
            { 
                if(con.State==ConnectionState.Open)
                {
                    con.Close() ;
                }
                return (ex.Message.ToString());
            }

            
        }
    
    }
}
