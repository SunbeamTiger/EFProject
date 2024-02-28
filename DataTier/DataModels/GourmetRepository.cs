using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier.Context;
using DataTier.DataModels;

namespace DataTier.DataModels
{
    public class GourmetRepository
    {
        private GourmetContext _context;
        public GourmetRepository() 
        { 
            _context = new GourmetContext();
        }  
        public List <Customer> GetCustomers() 
        { 
            return _context.Customers.ToList();  
        }
    }
}
