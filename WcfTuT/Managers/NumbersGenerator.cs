using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfTuT.Interfaces;

namespace WcfTuT.Managers
{
    public class NumbersGenerator : INumbersGenerator
    {
        Random rnd;
        public NumbersGenerator()
        {
            rnd = new Random();
        }
        public DieTossResult GenerateDieResults(int sides, int throws)
        {
            if (sides <= 0) throw new Exception("Die sides cannot be less than 1");
            if (throws <= 0) throw new Exception("Die throws cannot be less than 1");

            DieTossResult result = new DieTossResult(CalculateDieResults(sides,throws));

            return result;
        }

        private IList<int> CalculateDieResults(int _sides, int _throws)
        {
            IList<int> result = new List<int>();

            for(int i = 0; i < _throws; i++)
            {
                result.Add(rnd.Next(1, _sides + 1));
            }
            return result;
        }
    }
}