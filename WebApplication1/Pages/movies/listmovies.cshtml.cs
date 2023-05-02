using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages.movies
{
    public class listmoviesModel : PageModel
    {
        public static List<Movies> listedesfilfm = new List<Movies>();
        public static bool listfilmesttcree = false;
        public void OnGet()
        {
            if (listfilmesttcree == false)
            {
                Movies film1 = new Movies("Mad MAX : fury Road", "Tom Hardy, Charlize Theron, Nicholas Hoult", "george Miller", "very good movie | tom hardy is perfect | beatifull picture", "people are racing after oil and bullets in the desert, they fight for life!!!", "never seen beofore\n revolution", 2015);
                Movies film2 = new Movies("Full Metal Jacket", "R.Lee Ermey,Matthew Modine, Vincent D'Onofrio", "Stanley Kubrick", "amazing war mouvie | best war mouvie this year ", "young american train in order to fight in vietnam", "never seen beofore\n revolution", 1987);
                Movies film3 = new Movies("Reservoir Dogs", "Harvey keitel, Michael Madsen, Tim Roth", "Quentin Tarantino", "very suprising but exelent | i recoment to go see it", "six bad guys find each other in a garage after a miss bank robery...", "never seen beofore\n revolution", 1992);
                listedesfilfm.Add(film1);
                listedesfilfm.Add(film2);
                listedesfilfm.Add(film3);
                listfilmesttcree = true;
            }
        }
        public static void addflim(SubscriberInfo sub)
        {
            clientModel.listSubscriber.Add(sub);
        }
    }
}
