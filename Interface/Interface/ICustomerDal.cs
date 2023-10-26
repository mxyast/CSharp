using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");

        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");

        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("Oracle Added");

        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("Oracle Deleted");

        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("Oracle Updated");

        }
    }
    class MySqlServerCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("MySql Added");

        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("MySql Deleted");

        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("MySql Updated");

        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }

}
