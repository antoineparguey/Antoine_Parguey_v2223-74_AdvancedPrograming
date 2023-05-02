using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages.subscribers
{
    public class createModel : PageModel
    {
        
        public string error = "";
        public string success = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            SubscriberInfo subcreate = new SubscriberInfo();
            subcreate.name = Request.Form["name"];
            subcreate.passworld = Request.Form["passworld"];
            subcreate.age = Request.Form["age"];
            subcreate.address = Request.Form["address"];
            subcreate.email= Request.Form["email"];
            subcreate.phone = Request.Form["phone"];

            if(subcreate.name.Length==0|| subcreate.passworld.Length ==0|| subcreate.age.Length ==0|| subcreate.address.Length ==0|| subcreate.email.Length ==0|| subcreate.phone.Length == 0)
            {
                error = "please full all the information";
                return;
            }
            clientModel.addsub(subcreate);

            Response.Redirect("/subscribers/conect");
            /*
            subcreate.name = "";
            subcreate.passworld = "";
            subcreate.age = "";
            subcreate.address = "";
            subcreate.email = "";
            subcreate.phone = "";*/


            
        }
        
    }
}
