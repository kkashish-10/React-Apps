using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace RegistrationDetails.Models
{
    public class RegistrationDetailsModel
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Course { get; set; }
        public string Mobile { get; set; }
        public List<SelectList> stateList { get; set; }
        public List<RegistrationDetailsModel> dataList { get; set; }


    }
}