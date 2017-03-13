using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        private string name;        

        public string Name
        {
            get { return name; }
            set {  name = value.ToUpper(); }
        }

        public string Description { get; set; }
    }
}
