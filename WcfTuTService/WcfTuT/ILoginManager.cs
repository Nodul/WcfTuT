﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfTuT
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILoginManager
    {
        [OperationContract]
        string Login(string username, string password);
        [OperationContract]
        string LoginToken(string username, string token);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class LoginResponse
    {
        bool hasLoggedInSuccessfully = false;
        string token;

        [DataMember]
        public bool HasLoggedInSuccessfully
        {
            get { return hasLoggedInSuccessfully; }
            private set { hasLoggedInSuccessfully = value; }
        }

        [DataMember]
        public string Token
        {
            get { return token; }
            private set { token = value; }
        }
    }
}
