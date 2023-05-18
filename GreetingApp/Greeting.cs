using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingApp
{
    public class Greeting
    {
        public string Greet(string name)
        {
             return name == null? "Hello, my friend." : (name == name.ToUpper())? $"HELLO, {name}!" : $"Hello, {name}.";
          
        }

    }
}
