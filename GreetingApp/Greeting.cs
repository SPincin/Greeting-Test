using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GreetingApp
{
    public class Greeting
    {
        public string Greet(params string[] names)
        {

            if (names != null && names.Length > 2 && names.Any(n => n.Equals(n.ToUpper())))
            {
                var isUpper = names.ToLookup(n => n.ToUpper()== n);
                var resultLow = GreetBase(isUpper[false].ToArray());
               
                return $"{resultLow} AND HELLO {isUpper[true].First()}!";
            }

            if(names !=null && names.Length >= 2)
            {
                if(names.Any(element=>element.Contains(@"""")))
                        {
                            var namesWithoutQuotes = names.Select(name => name.Replace("\"", "")).ToArray();
                            return GreetBase(namesWithoutQuotes);
                                
                        }
                var selectMany = names.SelectMany(name => name.Split(", ")).ToArray();

                return GreetBase(selectMany);
                
            }
            

            return GreetBase(names);
        }

            private string GreetBase(params string[]? names)
            {
                if (names == null)
                {
                    return "Hello, my friend.";
                }
                if (names.Length == 1)
                {
                    return names[0] == names[0].ToUpper()
                           ? $"HELLO, {names[0]}!"
                           : $"Hello, {names[0]}.";
                }
                if (names.Length == 2)
                {
                    return $"Hello, {names[0]} and {names[1]}.";
                }
                else
                {

                    var pref = "Hello,";
                    var namesAggregate = names.SkipLast(1).Aggregate((prev, next) => $"{prev}, {next}");
                    return $"{pref} {namesAggregate}, and {names.Last()}.";
                }

               

            }
        }
    }

