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
            int rawImages = 3;
            int allRaw = (allImages / rawImages);
            int outImages = (allImages - allRaw * rawImages);
            Console.WriteLine("Рядов с картинками: {0} оставшиеся картинки: {1}",allRaw , outImages);
        }
    }
}
