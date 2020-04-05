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
        // Należy zmienić poniższy string aby zawierał w sobie aktualną ścieżkę do bazy danych

        private static string _defaultConnectionString = @"Data Source=DESKTOP-15SVUOL\SQLEXPRESS; 
                        Initial Catalog=TestContractors; Integrated Security=True";

        private static string _defaultUpdateString = "UPDATE Contractors SET name = @name," +
                " code = @code, nip = @nip, phone = @phone, email = @email " +
                "WHERE contractor_id = @ID";

        private static string _defaultInsertString = "INSERT INTO Contractors VALUES " +
            "(@code, @name, @nip, @phone, @email)";

        private static string _defaultDeleteString = "DELETE FROM Contractors WHERE contractor_id = @ID";

        public static string defaultConnectionString
        {
            get
            {
                return _defaultConnectionString;
            }
        }
        public static string defaultUpdateString
        {
            get
            {
                return _defaultUpdateString;
            }
        }
        public static string defaultInsertString
        {
            get
            {
                return _defaultInsertString;
            }
        }
        public static string defaultDeleteString
        {
            get
            {
                return _defaultDeleteString;
            }
        }

        public static void UpdateData(int ID, string name,
            string code, string nip, string phone, string email)
        {
            SqlConnection sqlConnect = new SqlConnection(defaultConnectionString);

            SqlCommand cmd = new SqlCommand(defaultUpdateString, sqlConnect);
            if (Contractor.CheckIfDataIsUnique(name, code, nip, ID))
            {
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
            else
            {
                MessageBox.Show("Istnieje już kontrahent o podanych danych!");
            }
        }

        public static void InsertData(string name,
            string code, string nip, string phone, string email)
        {
            SqlConnection sqlConnect = new SqlConnection(defaultConnectionString);

            SqlCommand cmd = new SqlCommand(defaultInsertString, sqlConnect);

            if (Contractor.CheckIfDataIsUnique(name, code, nip))
            {
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
            else
            {
                MessageBox.Show("Istnieje już kontrahent o podanych danych!");
            }
        }

        public static void DeleteRowData(int ID)
        {
            SqlConnection sqlConnect = new SqlConnection(defaultConnectionString);

            SqlCommand cmd = new SqlCommand(defaultDeleteString, sqlConnect);

            sqlConnect.Open();
            cmd.Parameters.AddWithValue("@ID", ID);

            cmd.ExecuteNonQuery();
            sqlConnect.Close();
        }
    }
}
