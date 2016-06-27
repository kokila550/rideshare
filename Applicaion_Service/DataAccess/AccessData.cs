using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class AccessData
    {
        //Login Customer
        public int Login(string phoneno)
        {
            using (rideshareEntities entities = new rideshareEntities())
            {

                var isprecent = entities.tbl_customer.SingleOrDefault(customer => customer.cus_phoneno == phoneno);


                if (isprecent != null)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }



        }

        //Register Customer
        public string RegisterCustomer(string phoneno, string email, string fname, string lname, string password)
        {

            using (rideshareEntities entities = new rideshareEntities())
            {
                var a = entities.tbl_customer.SingleOrDefault(customer => customer.cus_phoneno == phoneno);
                if (a != null)
                {
                    return string.Format("Email Already Exist");
                }
                else
                {
                    tbl_customer customer = new tbl_customer { cus_phoneno = phoneno, cus_password = password, cus_fname = fname, cus_lname = lname, cus_email = email };
                    entities.tbl_customer.Add(customer);
                    entities.SaveChanges();
                    return null;
                }

            }
        }


        //Login Driver
        public int LoginDriver(string phoneno, string password)
        {
            using (rideshareEntities entities = new rideshareEntities())
            {
                var isprecent = from d in entities.tbl_driver where d.dri_phoneno == phoneno && d.dri_password == password select 1;
                if (isprecent == null)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }

            }
        }

        //Get Vehicle List
        public List<VehicleInfo> GetTaxiList()
        {
            using (rideshareEntities entities = new rideshareEntities())
            {
                var vehicleInfo = new List<VehicleInfo>();

                var a = (from v in entities.tbl_vehicle
                         join d in entities.tbl_driver on v.veh_driverid equals d.dri_id
                         select new { v.veh_regno, v.veh_type, v.veh_location, v.veh_description, d.dri_lname, d.dri_phoneno });
                foreach (var k in a)
                {
                    vehicleInfo.Add(new VehicleInfo()
                    {
                        veh_regno = k.veh_regno,
                        veh_type = k.veh_type,
                        veh_location = k.veh_location,
                        veh_description = k.veh_description,
                        dri_lname = k.dri_lname,
                        dri_phoneno = k.dri_phoneno

                    });
                }
                  return vehicleInfo; ;
            }
        }


        //UpdateCustomerDetails
        public string Updateuser(string address,string nic, string phoneno,string fname,string lname, string vehicleno, string licenceno)
        {
            try
            {
                using (rideshareEntities entities = new rideshareEntities())
                {

                    tbl_driver driver = entities.tbl_driver.SingleOrDefault(dri => dri.dri_nic == nic);
                    if (nic != "")
                    {
                        driver.dri_nic = nic;

                    }
                    if (fname != "")
                    {
                        driver.dri_fname = fname;
                    }
                    if (lname != "")
                    {
                        driver.dri_lname = lname;

                    }
                    if (licenceno != "")
                    {
                        driver.dri_licence = licenceno;
                    }
                    if (phoneno != "")
                    {
                        driver.dri_phoneno = phoneno;
                    }

                    if (address != "")
                    {
                        driver.dri_address = address;
                    }
                   
                    
                   
                    return "Sucess";

                }
            }
            catch (Exception)
            {

                throw new  Exception("Oops something wrong try again");
            }
           

        }

       

    }    
}
