using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dll = new DataAccessLayer();
      

        //propertyType
        public int AddPropertyType(PropertyType pt)
        {
            return dll.AddPropertyType(pt);
        }
        public DataTable GetPropertyType()
        {
            return dll.GetPropertyType();
        }


        public DataTable GetRequestRent()
        {
            return dll.GetRequestRent();

        }



        //prop
        public int AddProperty(Prop p)
        {
            return dll.AddProperty(p);
        }
        public int UpdateProperty(Prop p)
        {
            return dll.UpdateProperty(p);
        }
        public int DeleteProperty(Prop p)
        {
            return dll.DeleteProperty(p);
        }
        public DataTable GetProperty()
        {
            return dll.GetProperty();

        }




        //Province
        public int AddProvince(Province pr)
        {
            return dll.AddProvince(pr);

        }
        public DataTable GetProvince()
        {

            return dll.GetProvince();
        }




        //Cities
        public int AddCity(City c)
        {
            return dll.AddCity(c);
        }
        public DataTable GetCity()
        {
            return dll.GetCity();

        }



        //Surbubs
        public int AddSurbub(Surbub s)
        {
            return dll.AddSurbub(s);
        }
        public DataTable GetSurbub()
        {
            return dll.GetSurbub();

        }


        //Agencies
        public int AddAgencies(Agency ac)
        {
            return dll.AddAgencies(ac) ;
        }

        public int DeleteAgencies(Agency ac)
        {
            return dll.DeleteAgencies(ac);

        }
        public DataTable GetAgencies()
        {
            return dll.GetAgencies();

        }




        //Agent
        public int AddAgent(Agent agent)
        {
            return dll.AddAgent(agent);
        }
        public int UpdateAgent(Agent agent)
        {
            return dll.UpdateAgent(agent);
        }
        public int DeleteAgent(Agent agent)
        {
            return dll.DeleteAgent(agent);
        }
        public DataTable GetAgent()
        {
            return dll.GetAgent();

        }

        //Admin
        public int AddAdmin(Admin admin)
        {
            return dll.AddAdmin(admin);
        }
        public DataTable GetAdmin()
        {
            return dll.GetAdmin();
        }

        //Tenant
        public int AddTenant(Tenant t)
        {
            return dll.AddTenant(t);
        }
        public int UpdateTenant(Tenant t)
        {
            return dll.UpdateTenant(t);
        }
        public int DeleteTenant(Tenant t)
        {
            return dll.DeleteTenant(t);
        }
        public DataTable GetTenant()
        {
            return dll.GetTenant();
        }


        //property Agent
        public int AddPropertyAgent(PropertyAgent pa)
        {
            return dll.AddPropertyAgent(pa);
        }
        public int UpdatePropertyAgent(PropertyAgent pa)
        {
            return dll.UpdatePropertyAgent(pa);
        }

        public DataTable GetPropertyAgent()
        {
            return dll.GetPropertyAgent();
        }



        //Rental
        public int AddRental(Rental r)
        {
            return dll.AddRental(r);
        }
        public int UpdateRental(Rental r)
        {
            return dll.UpdateRental(r);
        }
        public int DeleteRental(Rental r)
        {
            return dll.UpdateRental(r);

        }
        public DataTable GetRental()
        {
            return dll.GetRental();

        }

        //login
        public DataTable AgentLogin(string email, string password)
        {
            return dll.AgentLogin(email, password);
        }
        public DataTable LoginAdmin(string email, string password)
        {
            return dll.LoginAdmin(email, password);
        }
        public DataTable TenantLogin(string email, string password)
        {
            return dll.TenantLogin(email, password);
        }

        // report
        public DataTable GetRequestReport(string description, string name, double price, string startDate, string endDate)
        {
            return dll.GetRequestReport(description, name, price, startDate, endDate);
        }


        //REQUIREMENT
       public DataTable GetList()
        {
            return dll.GetList();
        }


        public DataTable GetTenantAgent()
        {
            return dll.GetTenantAgent();
        }


        public DataTable GetEndedDate(string endDate,string startDate)
        {
            return dll.GetEndedDate(endDate,startDate);
        }


        public DataTable GetAmount(double price)
        {
            return dll.GetAmount(price);

        }


        public DataTable GetOverTime(string endDate)
        {
            return dll.GetOverTime(endDate);
        }


        public DataTable GetMost()
        {
            return dll.GetMost();
        }
    }
}
