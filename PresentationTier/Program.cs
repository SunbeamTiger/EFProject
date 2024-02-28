using DataTier.Context;
using DataTier.DataModels;
namespace PresentationTier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GourmetRepository repository = new GourmetRepository();
            List<Customer> myCustomers = repository.GetCustomers();
         
            foreach ( var customer in myCustomers) 
            { 
                Console.WriteLine( customer.LastName );  
            }
        }
    }
}
