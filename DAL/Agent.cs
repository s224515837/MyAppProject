using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Agent
    {
        public int AgentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public string Status { get; set; }
        public int AgencyID { get; set; }

        //public Agent()
        //{

        //}

        ////ADD
        //public Agent(string name, string surname, string email, string password, int phone, string status, int agencyID)
        //{
        //    // AgentID = agentID;
        //    Name = name;
        //    Surname = surname;
        //    Email = email;
        //    Password = password;
        //    Phone = phone;
        //    Status = status;
        //    AgencyID = agencyID;

        //}
        ////Update
        //public Agent(string email, int phone, string status)
        //{

        //    Email = email;
        //    Phone = phone;
        //    Status = status;


        //}
        ////UPDATE
        //public Agent(int agentID, string name, string surname, string email, string password, int phone, string status, int agencyID)
        //{
        //    AgentID = agentID;
        //    Name = name;
        //    Surname = surname;
        //    Email = email;
        //    Password = password;
        //    Phone = phone;
        //    Status = status;
        //    AgencyID = agencyID;

        //}
    }
}
