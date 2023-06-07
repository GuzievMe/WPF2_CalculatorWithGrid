using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace WpfHomeApp2_CalculatorWithGrid
{
    internal class History
    {
        public string? Body { get; set; }
        public string  End { get; set; }

        public static  History getHistory(string? bdy, string  net)
        {
            return new History()
            {
                Body = bdy, End = net
            };
        }
        public override string ToString()
        {
            return (Body + "\n" + End);
        }
    }
}
