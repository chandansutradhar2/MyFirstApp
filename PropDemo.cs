using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class PropDemo
    {
        Regex regex = new Regex(@"[\d]");

        private string _name="chandan";

        public string Name
        {
            get {
                return _name;
            }
            set {
                if (regex.IsMatch(value))
                {
                    Console.WriteLine("Name cannot be number");
                }
                else {
                    _name = value;
                }
            }
            
        }


    }

    

}
