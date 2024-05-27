using Abdullah_Client.ViewModels;
using Abdullah_Models;

namespace Abdullah_Client.Service.IService
{
    public interface IPaymentService
    {
        public Task<SuccessModelDTO> Checkout(StripePaymentDTO model);

    }
}
