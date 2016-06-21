using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace rideshare_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBindingService" in both code and config file together.
    [ServiceContract]
    public interface IBindingService
    {
  
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Email/{email}")]
        tbl_customer ReadUser(string email);

        //[OperationContract]
        //string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);


        [OperationContract]
        [WebGet]
        List<tbl_customer> GetUserList();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Auth/{email}")]
        int Login(string email);
    

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "AddUser/{email}")]
        string AddUser(string email);
        // TODO: Add your service operations here
    }
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";
        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
        [DataMember]
        public string email
        {
            get { return email; }
            set { email = value; }
        }
        [DataMember]
        public string password
        {
            get { return password; }
            set { password = value; }
        }
    }

      
}
