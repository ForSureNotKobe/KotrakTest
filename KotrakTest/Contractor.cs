﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotrakTest
{
    class Contractor
    {
        private int id;
        private string code;
        private string name;
        private string nip;
        private string phone;
        private string email;

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
            SqlConnection sqlConnect = new SqlConnection(DbHelper.DefaultConnectionString);
            sqlConnect.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            sql = "SELECT * FROM Contractors";
            command = new SqlCommand(sql, sqlConnect);
            dataReader = command.ExecuteReader();

            List<Contractor> listOfContractors = new List<Contractor> { };

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
            Contractor fake = new Contractor();
            foreach (Contractor con in contractors)
            {
                if (con.ID == ConID)
                {
                    return con;
                }
            }
            return fake;
        }
    }


}
}