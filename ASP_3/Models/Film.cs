using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_3
{
    public class Film
    {
        public string Name { set; get; }
        public string Editor { set; get; }
        public string Style { set; get; }
        public string Description { set; get; }
        public string[] Session { get; set; }
        public Film(string name, string editor, string style, string description, string [] session)
        {
            Name = name;
            Editor = editor;
            Style = style;
            Description = description;
            Session = session;
        }
        

    }
}
