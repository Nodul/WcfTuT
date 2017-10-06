using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfTuT.Interfaces
{
    [ServiceContract]
    public interface INumbersService
    {
        [OperationContract]
        DieTossResult GetDieToss(int sides, int throws);

    }
    [DataContract]
    public class DieTossResult
    {
        public DieTossResult(IList<int> result)
        {
            this.Results = result;
        }
        public IList<int> Results { get; private set; }
        int Count { get; }
    }
}
