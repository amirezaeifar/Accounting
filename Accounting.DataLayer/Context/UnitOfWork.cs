using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork : IDisposable

    {
        Accounting_DBEntities2 db = new Accounting_DBEntities2();


        private ICustomersRepository _customersRepository;
        public ICustomersRepository customersRepository
        {
            get
            {
                if (_customersRepository == null)
                {
                    _customersRepository = new CustomersRepository(db);
                }
                return _customersRepository;
            }
        }

        private GenericRepository<Accounting> _accountingRepository;

        public GenericRepository<Accounting> accountingRepository
        {
            get
            {
                if (_accountingRepository == null)
                {
                    _accountingRepository = new GenericRepository<Accounting>(db);
                }
                return _accountingRepository;
            }
        }

        private GenericRepository<Login> _loginRepository;
        public GenericRepository<Login> LoginRepository 
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new GenericRepository<Login>(db);
                }
                return _loginRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
