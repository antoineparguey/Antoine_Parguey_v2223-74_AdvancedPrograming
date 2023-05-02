using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages.movies
{
    public class CreateFilmModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            Movies nvxflm = new Movies();
            nvxflm.title = Request.Form["title"];
            nvxflm.acteur = Request.Form["acteurs"];
            nvxflm.realisateur = Request.Form["director"];
            nvxflm.commentaire = "";
            nvxflm.notes = 2.5;
            nvxflm.resume = Request.Form["summary"];
            nvxflm.commentairepresse = "";
            try
            {
                nvxflm.datesortie = Convert.ToInt32(Request.Form["drelease"]);
            }
            catch
            {
                nvxflm.datesortie = 0;
            }

            listmoviesModel.listedesfilfm.Add(nvxflm);
            Response.Redirect("/movies/listmovies");

        }
    }
}
