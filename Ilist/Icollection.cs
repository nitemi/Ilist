using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    //ICollection
    //Dictionary
    //list, stack, queue,and set
    public delegate bool newrecord(Collection collection);
    public class Collection
    { 
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
            
    }
}
