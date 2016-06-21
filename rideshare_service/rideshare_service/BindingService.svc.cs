using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;  

namespace rideshare_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BindingService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BindingService.svc or BindingService.svc.cs at the Solution Explorer and start debugging.
    public class BindingService : IBindingService
    {
        public int Login(string email)
        {
            try
            {

                using (rideshareDBEntities entities = new rideshareDBEntities())
                {
                    var isprecent = from c in entities.tbl_customer where c.cus_email == email select 1;

                    int loginok;
                    if (isprecent is Nullable)
                    {
                        loginok = 0;
                    }
                    else
	{
                        loginok = 1;
                    }
                    return loginok;
                }
            }


            catch (Exception)
            {

                throw new FaultException("Something went wrong");
            }

        }
        public tbl_customer ReadUser(string email)
        {
            try
            {

                using (rideshareDBEntities entities = new rideshareDBEntities())
                {
                    var isprecent = from c in entities.tbl_customer where c.cus_email == email select 1;
                     var a = entities.tbl_customer.SingleOrDefault(customer => customer.cus_email == email);
                 return a;
                }
            }


            catch (Exception)
            {

                throw new FaultException("Something went wrong");
            }

        }

        public List<tbl_customer> GetUserList()
        {
            using (rideshareDBEntities entities = new rideshareDBEntities())
            {
                return entities.tbl_customer.ToList();
            }
        }

        public string AddUser(string email)
        {

            using (rideshareDBEntities entities = new rideshareDBEntities())
            {
                var a = entities.tbl_customer.SingleOrDefault(customer => customer.cus_email == email);
                if (a != null)
                {
                    return string.Format("Email Already Exist");
                }
                else
                {
                    tbl_customer customer = new tbl_customer { cus_email = email, cus_password = email };
                    entities.tbl_customer.Add(customer);
                    //   entities.Books.AddObject(book);
                    entities.SaveChanges();
                    return null;
                }

            }
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
