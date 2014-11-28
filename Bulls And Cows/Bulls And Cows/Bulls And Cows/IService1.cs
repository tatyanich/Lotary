using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Bulls_And_Cows
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBulls_And_Cows
    {
        [OperationContract]
        Answer GetAnswer(string str);
    
        [OperationContract]
        string GetCombination();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations
    [DataContract]
    public class Answer
    {
        [DataMember]
        public string result { get; set; }
        
       
        
        public Answer()
        {
            result = null;
           
        }
    }
}
