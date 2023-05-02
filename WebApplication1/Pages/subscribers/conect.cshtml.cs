using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages.subscribers
{
    public class conectModel : PageModel
    {
        public static bool conected = false;
        public string echec = "";
        public string reussi = "";
        
        public void OnGet()
        {
            
        }
        public void OnPost()
        {
            
            foreach(var clt in clientModel.listSubscriber)
            {
                if (Request.Form["name"] == clt.name && Request.Form["passworld"] == clt.passworld)
                {
                    conected = true;
                }
                else
                {
                    echec = "wrong information, or no acoumpt created";
                    return;
                }
                
            }
            echec = "";
        }
        public void disconect_Click(object sender, EventArgs e)
        {
            conected = false;
            reussi = "you have been disconected";
            return;
            //Response.Redirect("/subscribers/conect");
        }
    }
}
