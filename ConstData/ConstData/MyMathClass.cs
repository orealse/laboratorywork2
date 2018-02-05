using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        // Попытка установить PI в конструкторе?
        public const double PI = 3.14;
        public MyMathClass()
        {
            // Ошибка!
            const double PI = 3.14;
        }
    }
}
