using Accounting.ViewModels.Customers;
using System.Collections.Generic;

namespace Accounting.DataLayer.Repository
{
    public interface ICustomersRepository
    {
        List<Customers> GetAllCustomers();
        List<View_Customers> ListOfCustomers();

        List<ListCutomerViewModel> GetNameCustomers(string filter = "");
        IEnumerable<Customers> GetCustomersByFilter(string parameter);
        Customers GetCustomerById(int CustomerId);
        bool InsertCustomer(Customers customer);
        bool DeleteCusomer(Customers customer);
        bool DeleteCustomer(int CustomerId);
        bool UpdateCustomer(Customers customer);
        int GetCustomerIdByName(string name);
        string GetCustomerNameById(int CustomerId);
        string GetCustomerTypeById(int CustomerId);
        int x(char inav);
    }
}
