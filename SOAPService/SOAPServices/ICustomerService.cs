using System.ServiceModel;

namespace SOAPService
{
    // The service contract interface
    [ServiceContract]
    public interface ICustomerService
    {
        // Operation contract for getting customer details
        [OperationContract]
        string GetCustomerDetails(int customerId);
    }
}