using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamLabAppiumHometask
{
    public class RandomNumberGenerator
    {
        public static string GetRandomNumber()
        {
            Random random = new Random();
            string randonNumber = random.Next(1, 1000).ToString();
            return randonNumber;
        }
    }
}
