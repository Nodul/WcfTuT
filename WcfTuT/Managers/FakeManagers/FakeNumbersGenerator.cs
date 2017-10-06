using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfTuT.Interfaces;

namespace WcfTuT.Managers.FakeManagers
{
    public class FakeNumbersGenerator : INumbersGenerator
    {
        DieTossResult result;

        public FakeNumbersGenerator()
        {
            result = new DieTossResult(new List<int> { 1, 5, 9, 10, 4 });
        }
        public DieTossResult GenerateDieResults(int sides, int throws)
        {
            if (sides <= 0) throw new Exception("Die sides cannot be less than 1");
            if (throws <= 0) throw new Exception("Die throws cannot be less than 1");

            return result;
        }
    }
}