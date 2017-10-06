using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfTuT.Interfaces
{
    public interface INumbersGenerator
    {
        DieTossResult GenerateDieResults(int sides, int throws);
    }
}
