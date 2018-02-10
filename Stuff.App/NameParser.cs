using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuff.App
{
    public class NameParser
    {
        public Name Parse(string name)
        {

            if (name.Contains(" "))
            {
                var nameParts = name.Split(' ');

                return new Name
                {
                    FirstName = nameParts[0],
                    LastName = nameParts[1]
                };
            }
            else
            {
                return new Name
                {
                    FirstName = name
                };
            }


        }
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
