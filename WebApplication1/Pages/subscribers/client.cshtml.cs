using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace WebApplication1.Pages
{
    
    
    public class clientModel : PageModel
    {
        public static List<SubscriberInfo> listSubscriber = new List<SubscriberInfo>();

        public static bool creedatabase = false;
        public void OnGet()
        {
            if (creedatabase == false)
            {
                SubscriberInfo sub = new SubscriberInfo("Antoine Parguey", "jojo2001", "20", "Paris,France", "antpargue@gmail.com", "+123456789");
                listSubscriber.Add(sub);
                SubscriberInfo sub2 = new SubscriberInfo("Antoine Dupont", "jojo2002", "24", "Lille,France", "antdupont@gmail.com", "+123456789");
                listSubscriber.Add(sub2);
                SubscriberInfo sub3 = new SubscriberInfo("Gregory Aldritte ", "jojo2003", "25", "Lyon,France", "gergadl@gmail.com", "+123456789");
                listSubscriber.Add(sub3);
                SubscriberInfo sub4 = new SubscriberInfo("uini Atonio", "jojo2004", "30", "La Rochelle,France", "uinoato@gmail.com", "+123456789");
                listSubscriber.Add(sub4);
                creedatabase = true;
            }
            
        }
        
        public static void addsub(SubscriberInfo sub)
        {
            clientModel.listSubscriber.Add(sub);
        }

    
    }


    public class SubscriberInfo
    {
        //public string id;
        public string name;
        public string passworld;
        public string age;
        public string address;
        public string email;
        public string phone;
        

        public SubscriberInfo(string nam, string pass, string ag, string add, string em, string ph)
        {
            name = nam;
            passworld = pass;
            age = ag;
            address = add;
            email = em;
            phone = ph;

        }
        public SubscriberInfo()
        {
            name = "";
            passworld = "";
            age = "";
            address = "";
            email = "";
            phone = "";
        }

    }
}
