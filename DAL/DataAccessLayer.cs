using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccessLayer
    {
        static string sConn = "Data Source=CARVENX;Initial Catalog=PropertyDB;Integrated Security=True;";
        SqlConnection dbConn = new SqlConnection(sConn);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        //propertyType
        public int AddPropertyType(PropertyType Py)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddPropertyType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyTypeDescription", Py.PropertyTypeDescription);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetPropertyType()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetPropertyType", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public int UpdatePropertyType(PropertyType pt)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdatePropertyType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyTypeID", pt.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@PropertyTypeDescription", pt.PropertyTypeDescription);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }





        //properties
        public int AddProperty(Prop p)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Description", p.Description);
            dbComm.Parameters.AddWithValue("@Price", p.Price);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", p.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Status", p.Status);
            dbComm.Parameters.AddWithValue("@SurbubID", p.SurbubID);
            dbComm.Parameters.AddWithValue("@Image", p.Image);
            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        public int UpdateProperty(Prop p)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyID", p.PropertyID);
            dbComm.Parameters.AddWithValue("@Price", p.Price);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", p.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Status", p.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteProperty(Prop p)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyID", p.PropertyID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetProperty()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetProperty", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }

        //Admin
        public int AddAdmin(Admin a)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddAdmin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", a.Name);
            dbComm.Parameters.AddWithValue("@Surname", a.Surname);
            dbComm.Parameters.AddWithValue("@Email", a.Email);
            dbComm.Parameters.AddWithValue("@Password", a.Password);
            dbComm.Parameters.AddWithValue("@Status", a.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetAdmin()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetAdmin", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }


        //Province
        public int AddProvince(Province pr)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddProvince", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Description", pr.Description);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetProvince()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetProvince", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }




        //Cities
        public int AddCity(City c)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddCity", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@CityDescription", c.CityDescription);
            dbComm.Parameters.AddWithValue("@ProvinceID", c.ProvinceID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetCity()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetCity", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }



        //Surbubs
        public int AddSurbub(Surbub s)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddSurbub", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@SurbubDescription", s.SuburbDescription);
            dbComm.Parameters.AddWithValue("@PostalCode", s.PostalCode);
            dbComm.Parameters.AddWithValue("@CityID", s.CityID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetSurbub()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetSurbub", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }


        //Agencies
        public int AddAgencies(Agency ac)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddAgencies", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AgencyName", ac.AgencyName);
            dbComm.Parameters.AddWithValue("@SurbubID", ac.SuburbID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int DeleteAgencies(Agency ac)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteAgencies", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AgencyID", ac.AgencyID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetAgencies()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetAgencies", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }




        //Agent
        public int AddAgent(Agent agent)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", agent.Name);
            dbComm.Parameters.AddWithValue("@Surname", agent.Surname);
            dbComm.Parameters.AddWithValue("@Email", agent.Email);
            dbComm.Parameters.AddWithValue("@Password", agent.Password);
            dbComm.Parameters.AddWithValue("@Phone", agent.Phone);
            dbComm.Parameters.AddWithValue("@Status", agent.Status);
            dbComm.Parameters.AddWithValue("@AgencyID", agent.AgencyID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateAgent(Agent agent)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AgentID", agent.AgentID);
            dbComm.Parameters.AddWithValue("@Email", agent.Email);
            dbComm.Parameters.AddWithValue("@Phone", agent.Phone);
            dbComm.Parameters.AddWithValue("@Status", agent.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteAgent(Agent agent)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AgentID", agent.AgentID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetAgent()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetAgent", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }



        //Tenant
        public int AddTenant(Tenant t)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", t.Name);
            dbComm.Parameters.AddWithValue("@Surname", t.Surname);
            dbComm.Parameters.AddWithValue("@Email", t.Email);
            dbComm.Parameters.AddWithValue("@Password", t.Password);
            dbComm.Parameters.AddWithValue("@Phone", t.Phone);
            dbComm.Parameters.AddWithValue("@Status", t.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateTenant(Tenant t)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TenantID", t.TenantID);
            dbComm.Parameters.AddWithValue("@Email", t.Email);
            dbComm.Parameters.AddWithValue("@Phone", t.Phone);
            dbComm.Parameters.AddWithValue("@Status", t.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteTenant(Tenant t)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TenantID", t.TenantID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetTenant()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetTenant", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }


        //property Agent
        public int AddPropertyAgent(PropertyAgent pa)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddPropertyAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyID", pa.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", pa.AgentID);
            dbComm.Parameters.AddWithValue("@Date", pa.Date);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdatePropertyAgent(PropertyAgent pa)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdatePropertyAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyAgentID", pa.PropertyAgentID);
            dbComm.Parameters.AddWithValue("@PropertyID", pa.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", pa.AgentID);
            dbComm.Parameters.AddWithValue("@Date", pa.Date);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public DataTable GetPropertyAgent()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetPropertyAgent", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }



        //Rental
        public int AddRental(Rental r)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AddTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyTenantID", r.PropertyTenantID);
            dbComm.Parameters.AddWithValue("@Tenant", r.TenantID);
            dbComm.Parameters.AddWithValue("@StartDate", r.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", r.EndDate);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateRental(Rental r)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@RentalID", r.RentalID);
            dbComm.Parameters.AddWithValue("@StartDate", r.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", r.EndDate);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteRental(Rental r)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@RentalID", r.RentalID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetRental()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetRental", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        //LOGIN

        public DataTable LoginAdmin(string email, string password)
        {
            dbConn.Open();
            string sql = "sp_LoginAdmin";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", email);
            dbComm.Parameters.AddWithValue("@Password", password);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable AgentLogin(string email, string password)
        {
            dbConn.Open();
            string sql = "sp_LoginAgent";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", email);
            dbComm.Parameters.AddWithValue("@Password", password);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable TenantLogin(string email, string password)
        {
            dbConn.Open();
            string sql = "sp_LoginTenant";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", email);
            dbComm.Parameters.AddWithValue("@Password", password);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        //reporting
        public DataTable GetRequestReport(string description, string name, double price, string startDate, string endDate)
        {
            dbConn.Open();
            string sql = "sp_GetRequestReport";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Description", description);
            dbComm.Parameters.AddWithValue("@Name", name);
            dbComm.Parameters.AddWithValue("@Price", price);
            dbComm.Parameters.AddWithValue("@StartDate", startDate);
            dbComm.Parameters.AddWithValue("@EndDate", endDate);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        //GetReport
        public DataTable GetRequestRent()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetApplyRent", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public DataTable GetList()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetList", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
       

        public DataTable GetTenantAgent()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetTenantAgent", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetEndedDate(string endDate,string startDate)
        {
            dbConn.Open();
            string sql = "sp_GetEndedDate";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StartDate", startDate);
            dbComm.Parameters.AddWithValue("@EndDate", endDate);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetAmount(double price)
        {
            dbConn.Open();
            string sql = "sp_GetAmount";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Price", price);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public DataTable GetOverTime(string endDate)
        {
            dbConn.Open();
            string sql = "sp_GetOverTime";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@EndDate", endDate);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetMost()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetMost", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
    }
}
