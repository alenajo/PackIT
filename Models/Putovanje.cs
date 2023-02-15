using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMA_Tim6.Models
{
    public class Putovanje
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Duration { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFavorite { get; set; }
        public string Description { get; set; }
        public List<string> Clothing { get; set; }
        public List<string> Hygiene { get; set; }
        public List<string> Health { get; set; }
        public List<string> Documents { get; set; }
        public List<string> Gadgets { get; set; }
        public List<string> Camping { get; set; }
        public List<string> Beach { get; set; }
        public List<string> Gym { get; set; }
        public List<string> Hiking { get; set; }
        public List<string> Skiing { get; set; }
        public List<string> Business { get; set; }


    }
}
