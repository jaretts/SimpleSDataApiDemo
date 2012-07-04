using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleSDataApiDemo.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using MobileReports.Models;

    namespace WebApiSDataProvider.Controllers
    {
        public class CustomerController : ApiController
        {

            IQueryable<Customer> custs;

            public Customer GetTemplate()
            {
                return new Customer();
            }

            // GET api/customers
            [Queryable] 
            public IQueryable<Customer> Get()
            {
                return GetAllCustomers();
            }

            // GET api/customers/5
            public Customer Get(string selector)
            {
                return new Customer()
                {
                    _id = selector,
                    addressline1 = "some address: " + selector,
                    city = "some city: " + selector,
                    customername = "Customer Number: " + selector,
                    openorderamt = int.Parse(selector) * 10,
                    state = "CA",
                    telephoneno = "555-123-4567",
                    zipcode = "90210",
                };
            }

            private IQueryable<Customer> GetAllCustomers()
            {
                if (custs == null)
                {
                    List<Customer> custList = new List<Customer>();

                    for (int i = 0; i < 10; i++)
                    {
                        custList.Add(new Customer()
                        {
                            _id = "id" + i,
                            addressline1 = "some address: " + i,
                            city = "some city: " + i,
                            customername = "Customer Number: " + i,
                            openorderamt = i * 10,
                            state = "CA",
                            telephoneno = "555-123-4567",
                            zipcode = "90210",
                        });
                    }

                    custs = custList.AsQueryable<Customer>();
                }

                return custs;
            }


            // POST api/customers
            public void Post(string value)
            {
            }

            // PUT api/customers/5
            public void Put(int id, string value)
            {
            }

            // DELETE api/customers/5
            public void Delete(int id)
            {
            }
        }
    }
}
