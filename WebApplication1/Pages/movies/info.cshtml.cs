using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages.movies
{
    public class infoModel : PageModel
    {
        public string index = "";
        public static int Idexf = 0;
        public string ec = "";
        
        public void OnGet()
        {
             index = Request.Query["index"];
             infoModel.Idexf = Convert.ToInt32(index);
            
        }
        public void OnPost()
        {
            bool estentier = false;
            double gr=2.5;
            string com = "";

            try
            {
                gr = Convert.ToInt32(Request.Form["grade"]);
                estentier = true;
                com = " | " + Request.Form["comment"];
            }
            catch
            {
                ec = " Please rite a numer between 0 and 5";
                return;
            }
            ec = "";

            if (estentier == true)
            {
                listmoviesModel.listedesfilfm[Idexf].notes = (listmoviesModel.listedesfilfm[Idexf].notes + gr) / 2;
                listmoviesModel.listedesfilfm[Idexf].commentaire = listmoviesModel.listedesfilfm[Idexf].commentaire + com;
            }
        }
    }
}
