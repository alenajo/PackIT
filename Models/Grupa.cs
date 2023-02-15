using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMA_Tim6.Models
{
    public class Grupa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Items { get; set; }
      
    }
}
