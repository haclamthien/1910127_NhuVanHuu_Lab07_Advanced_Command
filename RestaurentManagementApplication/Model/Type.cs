using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurentManagementApplication.Model
{
    public class Type
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Type(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
