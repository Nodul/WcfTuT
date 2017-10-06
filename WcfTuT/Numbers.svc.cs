using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfTuT.Interfaces;

namespace WcfTuT
{
    public class Numbers : INumbersService
    {
        INumbersGenerator NumGen;
        public Numbers(INumbersGenerator NumbersGenerator)
        {
            NumGen = NumbersGenerator;
        }
        public DieTossResult GetDieToss(int sides, int throws)
        {
            return NumGen.GenerateDieResults(sides, throws);
        }
    }
}
