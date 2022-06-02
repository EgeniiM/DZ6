using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            int allImages = 52;
            int imagesInRaw = 3;
            int allFullRaw = (allImages / imagesInRaw);
            int outImages = (allImages % imagesInRaw);
            Console.WriteLine("Рядов с картинками: {0} оставшиеся картинки: {1}",allFullRaw , outImages);
        }
    }
}
