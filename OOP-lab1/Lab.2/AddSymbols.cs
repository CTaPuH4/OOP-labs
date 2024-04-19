using OOP_task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task2
{
    internal class AddSymbols : MTime
    {
        private MTime DT;

        public AddSymbols(MTime dt)
        {
            DT = dt;
        }
        public string FormatDateTime()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("IIIII ");
            sb.Append(DT.FormatDateTime());
            sb.Append(" NNNNN");
            return sb.ToString();
        }
    }
}
