using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace DataMapper
{
    public class DetailMapper
    {
       
    string ConnectionString = @"Data Source= IGL183259;Initial Catalog = master; Integrated Security = True";

    public int SaveDetails(string Name, string Email, string Address, string Mobile, string Country, string State, string City, string Course)

    {
        using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SubmitDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.Parameters.AddWithValue("@Country", Country);
                cmd.Parameters.AddWithValue("@State", State);
                cmd.Parameters.AddWithValue("@City", City);
                cmd.Parameters.AddWithValue("@Course", Course);
                int i= cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }
        }

        public string GetAllState(string country)
        {
            string s= "";
            SqlConnection con;
            using (con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("GetAllState", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Country", country);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    s += Convert.ToString(dr["state"])+",";
                }
                con.Close();
                
                return s;
            }
        }
        
    public string GetAllState(string state,string country)
        {
            string s= "";
            SqlConnection con;
            using (con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("GetAllCity", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@State", state);
                cmd.Parameters.Add("@Country", country);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    s += Convert.ToString(dr["city"])+",";
                }
                con.Close();
                
                return s;
            }
        }
        
        public int checkEmail(string Email)
        {
            int c = 0;
            SqlConnection con;
            using (con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("CheckDuplicateEmail", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Email", Email);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                     c = Convert.ToInt32(dr["CountEmail"]);
                }
                con.Close();
                if (c > 0)
                {
                    c = 1;
                }
                return c;
            }
        }

         public List<string> GetAllCountry()
        {
            List<string> str = new List<string>();
            SqlConnection con;
            using (con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("GetAllCountry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    str.Add(Convert.ToString(dr["country"]));
                }
                con.Close();

                return str;
            }
        }
    }
}

