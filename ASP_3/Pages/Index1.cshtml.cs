using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_3.Pages
{
    public class Index1Model : PageModel
    {
        public Index1Model()
        {
            Films = new List<Film> {
            new Film("Freeze", "Marshal", "Magic","About Winter", new string [5] {"10:00","12:00","14:00","16:00","18:00" }),
            new Film("AntiFreeze", "Lamansh", "Reality","About AntiFreeze", new string [5] {"09:00","11:00","13:00","15:00","17:00" }),
            new Film("Killer", "Kiler", "Action","About Killer", new string [5] {"09:30","11:30","13:30","15:30","17:30" }),
            new Film("AntiKiller", "AntiKiller", "Action","About AntiKiller", new string [5] {"10:30","12:30","14:30","16:30","18:30" })


        };
        }
        public List <Film> Films { set; get; }
        public string[] Session { set; get; }
        public void OnGet()
        {
            Films = Films;
            Session = Films[0].Session;

        }
    }
}
