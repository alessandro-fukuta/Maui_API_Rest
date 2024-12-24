using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_API.Models
{
    public class Brands
    {
        public int id { get; set; }
        public string title { get; set; }
        public string logo { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

    }
}
