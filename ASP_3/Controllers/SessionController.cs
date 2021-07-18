using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_3
{
    public class SessionController
    {
        public List<string> sessions { set; get; }
        public SessionController(Film film)
        {
            sessions.AddRange(film.Session);
        }
        public void AddSession(string session)
        {
            sessions.Add(session);
            sessions.Sort();
        }
    }
}
