using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public class LicensePlate
    {
        string dmvString;
        int seperatorNumber;

        public LicensePlate(string licenseString, int seperatorNumber)
        {
            this.dmvString = licenseString;
            this.seperatorNumber = seperatorNumber;
        }

        public string GetResultLicense()
        {
            string str = this.dmvString.Replace("-","").ToUpper();

            List<string> list = new List<string>();
            for (int i = str.Length - 1; i >= 0; i -= this.seperatorNumber)
            {
                int length = Math.Min(this.seperatorNumber, i + 1);
                string group = str.Substring(i - length + 1, length);
                list.Add(group);
            }

            list.Reverse();
            string[] arr = list.ToArray();

            return string.Join("-", arr);
        }
    }
    public class LicensePlateSolution
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the license number : ");
            string licenseNumber = Console.ReadLine()!;
            Console.WriteLine("Enter the seperator : ");
            int seperatorNumber = Convert.ToInt32(Console.ReadLine());


            LicensePlate licensePlate = new(licenseNumber, seperatorNumber);
            Console.WriteLine($"The Modified License Number is : {licensePlate.GetResultLicense()} ");
        }
    }
}
