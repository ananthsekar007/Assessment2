using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public class LicenseTimeSolution
    {
        public static int LicenseTime(string me, int availableAgents, string others)
        {

            string[] names = others.Split(' ');
            Array.Resize(ref names, names.Length + 1);
            names[names.Length - 1] = me;
            Array.Sort(names);

            int myIndex = Array.IndexOf(names, me);
            int groups = (myIndex + availableAgents) / availableAgents;
            return groups * 20;

        }

        public static void Main(string[] args)
        {
            Console.WriteLine(LicenseTime("Eric", 2, "Adam Caroline Rebecca Frank"));
        }
    }
}
