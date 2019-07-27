using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_25_07_19
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayLs ar =  new ArrayLs();
            for (int i = 0; i < 50; i++)
            {
                ar.AddNum(i);
            }
            Console.WriteLine(ar.CountAr());
            ar.RemoveAtNum(10);
            Console.WriteLine(ar.CountAr());
            ar.InsertInArray(25, "Hello");
            Console.WriteLine(ar.CountAr());

        }
    }
}
