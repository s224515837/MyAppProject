using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Agency
    {

        public int AgencyID { get; set; }
        public string AgencyName { get; set; }
        public int SuburbID { get; set; }

        public Agency()
        {

        }
        //add agencies
        public Agency(int agencyID, string agencyName, int surbubID)
        {
            AgencyName = agencyName;
            AgencyID = agencyID;
            SuburbID = surbubID;

        }
        //Delete
        public Agency(int agencyID, string agencyName)
        {
            AgencyName = agencyName;
            AgencyID = agencyID;
            // SuburbID = surbubID;

        }
    }
}
