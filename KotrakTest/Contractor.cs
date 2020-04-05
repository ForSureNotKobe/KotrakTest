using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotrakTest
{
    class Contractor
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Nip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Contractor(int id, string code, string name, string nip, string phone, string email)
        {
            this.ID = id;
            this.Code = code;
            this.Name = name;
            this.Nip = nip;
            this.Phone = phone;
            this.Email = email;
        }

        public Contractor() { }

        public List<Contractor> GetContractors()
        {
            SqlConnection sqlConnect = new SqlConnection(DbHelper.defaultConnectionString);
            sqlConnect.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            sql = "SELECT * FROM Contractors";
            command = new SqlCommand(sql, sqlConnect);
            dataReader = command.ExecuteReader();

            List<Contractor> listOfContractors = new List<Contractor>();

            while (dataReader.Read())
            {
                Contractor contractor = new Contractor
                    (Convert.ToInt32(dataReader.GetValue(0)),
                    Convert.ToString(dataReader.GetValue(1)),
                    Convert.ToString(dataReader.GetValue(2)),
                    Convert.ToString(dataReader.GetValue(3)),
                    Convert.ToString(dataReader.GetValue(4)),
                    Convert.ToString(dataReader.GetValue(5))
                    );
                listOfContractors.Add(contractor);
            }
            sqlConnect.Close();
            return listOfContractors;
        }

        public Contractor GetContractorData(int ConID, List<Contractor> contractors)
        {
            foreach (Contractor con in contractors)
            {
                if (con.ID == ConID)
                {
                    return con;
                }
            }
            return new Contractor();
        }

        public static bool CheckIfDataIsUnique (string checkName, string checkCode, string checkNip)
        {
            Contractor contractor = new Contractor();
            List<Contractor> listOfContractors = contractor.GetContractors();
            foreach (Contractor con in listOfContractors)
            {
                if (checkName == con.Name || checkCode == con.Code || checkNip == con.Nip)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CheckIfDataIsUnique(string checkName, string checkCode, string checkNip, int checkID)
        {
            Contractor contractor = new Contractor();
            List<Contractor> listOfContractors = contractor.GetContractors();
            foreach (Contractor con in listOfContractors)
            {
                if ((checkName == con.Name || checkCode == con.Code || checkNip == con.Nip) && 
                    checkID != con.ID)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
