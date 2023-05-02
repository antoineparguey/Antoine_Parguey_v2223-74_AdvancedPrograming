using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class contactModel : PageModel
    {
        public bool hasdata = false;
        public string firstname = "";
        public string lastname = "";
        public string message = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasdata = true;
            firstname = Request.Form["firstname"];
            lastname = Request.Form["lastname"];
            message = Request.Form["message"];
        }
    }
}
