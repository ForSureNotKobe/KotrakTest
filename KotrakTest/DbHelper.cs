using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotrakTest
{
    class DbHelper
    {
        private static string defaultConnectionString = @"Data Source=DESKTOP-15SVUOL\SQLEXPRESS; 
                        Initial Catalog=KotrakDB; Integrated Security=True";        

        private static string defaultUpdateString = "UPDATE Contractors SET name = @name," +
                " code = @code, nip = @nip, phone = @phone, email = @email " +
                "WHERE contractor_id = @ID";

        private static string defaultInsertString = "INSERT INTO Contractors VALUES " +
            "(@code, @name, @nip, @phone, @email)";

        private static string defaultDeleteString = "DELETE FROM Contractors WHERE contractor_id = @ID";


        public static string DefaultConnectionString
        {
            get
            {
                return defaultConnectionString;
            }
        }
        public static string DefaultUpdateString
        {
            get
            {
                return defaultUpdateString;
            }
        }
        public static string DefaultInsertString
        {
            get
            {
                return defaultInsertString;
            }
        }
        public static string DefaultDeleteString
        {
            get
            {
                return defaultDeleteString;
            }
        }

        public static void UpdateData(int ID, string name,
            string code, string nip, string phone, string email)
        {
            SqlConnection sqlConnect = new SqlConnection(DefaultConnectionString);

            SqlCommand cmd = new SqlCommand(DefaultUpdateString, sqlConnect);

            try
            {
                sqlConnect.Open();

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@nip", nip);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);

                cmd.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Wprowadzono niepoprawne dane!");
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        public static void InsertData(string name,
            string code, string nip, string phone, string email)
        {
            SqlConnection sqlConnect = new SqlConnection(DefaultConnectionString);

            SqlCommand cmd = new SqlCommand(DefaultInsertString, sqlConnect);

            try
            {
                sqlConnect.Open();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@nip", nip);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);

                cmd.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Wprowadzono niepoprawne dane!");
            }

            finally
            {
                sqlConnect.Close();
            }
        }

        public static void DeleteRowData(int ID)
        {
            SqlConnection sqlConnect = new SqlConnection(DefaultConnectionString);

            SqlCommand cmd = new SqlCommand(DefaultDeleteString, sqlConnect);

            sqlConnect.Open();
            cmd.Parameters.AddWithValue("@ID", ID);

            cmd.ExecuteNonQuery();
            sqlConnect.Close();
        }
    }
}
