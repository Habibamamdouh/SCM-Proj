using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPService
{
    // The implementation of the service contract
    public class CustomerService : ICustomerService
    {
        // Implementation of the GetCustomerDetails method
        public string GetCustomerDetails(int customerId)
        {
            // For simplicity, returning a mock customer detail as a string
            // In a real scenario, you could query a database or another data source here
            return $"Customer details for ID {customerId}: John Doe, Age 30, Location: USA";
        }
    }
}