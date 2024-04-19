using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task2
{
    internal class EuTime : MTime
    {
        public string FormatDateTime()
        {
            CultureInfo myCIintl = new CultureInfo("es-ES", false);
            return DateTime.Now.ToString(myCIintl);
        }
    }
}
