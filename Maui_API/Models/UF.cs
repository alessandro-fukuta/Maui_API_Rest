using System;
using System.Collections.Generic;
using System.Text;

namespace Maui_API.Models
{


    public class Rootobject
    {
        public UF[] Property1 { get; set; }
    }

    public class UF
    {
        public int id { get; set; }
        public string? sigla { get; set; }
        public string? nome { get; set; }
        public Regiao? regiao { get; set; }
    }

    public class Regiao
    {
        public int id { get; set; }
        public string sigla { get; set; }
        public string nome { get; set; }
    }


}
