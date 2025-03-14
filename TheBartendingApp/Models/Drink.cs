using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBartendingApp.Models
{
    public class Drink
    {
        

        
            public string ingredientString 
        {
            get {return String.Join(", ",ingredients); }
             
        }
            public string[] ingredients { get; set; }
            public string instructions { get; set; }
            public string name { get; set; }
        





    }
}
