using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationDetails.Models;
using DataMapper;
using System.Web.Services;
using System.Data.SqlClient;

namespace RegistrationDetails.Controllers
{
    public class RegistrationController : Controller
    {
        List<SelectListItem> courseList = new List<SelectListItem>();
        DetailMapper detailMapper = new DetailMapper();
        string ConnectionString = @"Data Source= IGL183259;Initial Catalog = master; Integrated Security = True";
        // GET: Registration
        public ActionResult Index()
        {
            
            List<SelectListItem> list = new List<SelectListItem>();
            if (ViewBag.CountryList == null)
            {
                var ListOfCountry = detailMapper.GetAllCountry();
   
                for (int i = 0; i < ListOfCountry.Count; i++)
                {
                    list.Add(new SelectListItem
                    {
                        Text = ListOfCountry[i],
                        Value = ListOfCountry[i]
                    });
                }
            }
            ViewBag.CountryList = list;
            List<SelectListItem> CityList = new List<SelectListItem>();
            ViewData["CityList"] = CityList;
            ViewBag.StateList = courseList;
            var obj=new RegistrationDetailsModel();
            var ListAllDATA = new List<RegistrationDetailsModel>();
            SqlConnection con;
            using (con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("GetAllData", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var temp = new RegistrationDetailsModel();
                    temp.Name = Convert.ToString(dr["Name"]);
                    temp.Email = Convert.ToString(dr["Email"]);
                    temp.Address = Convert.ToString(dr["Address"]);
                    temp.Country = Convert.ToString(dr["Country"]);
                    temp.City = Convert.ToString(dr["City"]);
                    temp.Course = Convert.ToString(dr["Course"]);
                    temp.State = Convert.ToString(dr["State"]);
                    temp.Mobile = Convert.ToString(dr["Mobile"]);

                    ListAllDATA.Add(temp);
                }
                obj.dataList = ListAllDATA;
                con.Close();
            }
            return View(obj);
            
        }
        
        public ActionResult Submit(RegistrationDetailsModel registrationDetailsModel)
        {
           
            if (Request.Form["state"] != null)
            {
                var st = Request.Form["state"].ToString();
            }
            
            int result = detailMapper.SaveDetails(registrationDetailsModel.Name, registrationDetailsModel.Email,
                registrationDetailsModel.Address, registrationDetailsModel.Mobile, registrationDetailsModel.Country, registrationDetailsModel.State, registrationDetailsModel.City, registrationDetailsModel.Course);
            Index();
            
            return View("Index");
        }

        [HttpPost]
        public string GetAllState(string country)
        {
           
            return detailMapper.GetAllState(country);
            
        }
        [HttpPost]
        public string GetAllCity(string state,string country)
        {
           
            return detailMapper.GetAllState(state,country);
            
        }
        [HttpPost]
        public string checkEm(string email)
        {
            string result = "";
           

            int c = detailMapper.checkEmail(email);
            if (c > 0)
            {

                result = "1";

            }
            else {
                result = "0";
            }
            return result;
        }
          

    }
}