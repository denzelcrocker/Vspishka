using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace razmetka
{
    class Base
    {
        private static string name;
        private static string sh1;
        private static string cash;
        private static string password;

        public static string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;

            }
        }
        public static string Sh1
        {
            get
            {
                return sh1;
            }
            set
            {
                sh1 = value;

            }
        }
        public static string Cash
        {
            get
            {
                return cash;
            }
            set
            {
                cash = value;

            }
        }
        public static string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;

            }
        }
        public static void Registration(string[] DataPlus)
        {
            StreamWriter users = new StreamWriter("info.txt", append: true);
            string line = $"{DataPlus[0]};{DataPlus[1]};{DataPlus[2]}";
            users.WriteLine(line);
            users.Close();
        }
    }
}
