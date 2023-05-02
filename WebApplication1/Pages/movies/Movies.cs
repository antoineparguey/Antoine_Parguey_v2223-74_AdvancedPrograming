using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Pages.movies
{
    public class Movies
    {
        public string title;
        public string acteur;
        public string realisateur;
        public double notes;
        public string commentaire;
        public string resume;
        public string commentairepresse;
        public int datesortie;

        public Movies()
        {
            title = "";
            realisateur = "";
            resume = "";
            datesortie = 0;
        }
        public Movies(string tit, string act, string real, string comm,string res, string compre, int dat)
        {
            title = tit;
            acteur = act;
            realisateur = real;
            notes = 2.5;
            commentaire = comm;
            resume = res;
            commentairepresse = compre;
            datesortie = dat;

        }
    }
}
