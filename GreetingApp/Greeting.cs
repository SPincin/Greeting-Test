using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingApp
{
    public class Greeting
    {
        public string Greet(params string[] names)
        {
            if(names == null)
            {
                return "Hello, my friend.";
            }
            if (names.Length == 1)
            {
                return names[0] == names[0].ToUpper()
                       ? $"HELLO, {names[0]}!"
                       : $"Hello, {names[0]}.";
            }
            if(names.Length == 2)
            {
                return $"Hello, {names[0]} and {names[1]}.";
            }

            var pref = "Hello,";
            var namesAggregate = names.SkipLast(1).Aggregate((prev, next) => $"{prev}, {next}");
            return $"{pref} {namesAggregate}, and {names.Last()}.";
        }

    }
}
