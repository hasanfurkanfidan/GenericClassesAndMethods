using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara","İzmir","Adana");
            foreach (var item in result  )
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer());
            Console.ReadLine();
        }
    }

   public class Utilities
   {
       public List<T> BuildList<T>(params T[] items)
       {
            return new List<T>(items);
       }
   }

    class Product:IProductDal
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    interface IProductDal:IRepository<Product>
    {
        
    }

    class Customer:ICustomerDal
    {
        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }
    }

    interface ICustomerDal:IRepository<Customer>
    {
        void Custom();
    }

    interface IStudentDal:IRepository<Student>//Buraya generic sınırlarla string,int konulmasını önleyebiliriz...
    {
        
    }

    class Student:IEntity
    {
        
    }

    interface IEntity
    {
        
    }
    interface IRepository<T> where T:class,IEntity,new()        //T hem referans tip hemde newlenebilir olmalıdır.IEntityden implement edilmeli 
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    
}
