using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.Repository
{
    public class CustomersRepository : ICustomersRepository

    {
        Accounting_DBEntities2 db;

        public CustomersRepository(Accounting_DBEntities2 context)
        {
            db = context;
        }

        public bool DeleteCusomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int CustomerId)
        {
            try
            {
                var customer = GetCustomerById(CustomerId);
                DeleteCusomer(customer);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customers GetCustomerById(int CustomerId)
        {
            return db.Customers.Find(CustomerId);
        }

        public int GetCustomerIdByName(string name)
        {
            return db.Customers.First(c => c.FullName == name).CustomersID;
        }

        public string GetCustomerNameById(int CustomerId)
        {
            return db.Customers.Find(CustomerId).FullName;
        }

        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return db.Customers.Where(c => c.FullName.Contains(parameter) || c.Mobile.Contains(parameter) || c.Email.Contains(parameter)).ToList();
        }

        public string GetCustomerTypeById(int CustomerId)
        {
            var x = db.Customers.Find(CustomerId).EntityID;
            return db.EntityType.Find(x).EntityTitle;
        }

        public List<ListCutomerViewModel> GetNameCustomers(string filter = "")
        {
            if (filter == "")
            {
                return db.Customers.Select(c => new ListCutomerViewModel()
                {
                    CustomerID = c.CustomersID,
                    FullName = c.FullName
                }
                ).ToList();
            }
            return db.Customers.Where(c => c.FullName.Contains(filter)).Select(c => new ListCutomerViewModel()
            {
                CustomerID = c.CustomersID,
                FullName = c.FullName
            }
                ).ToList();
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<View_Customers> ListOfCustomers()
        {
            return db.View_Customers.ToList();
        }

        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
