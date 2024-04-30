using HospitalService.Shared.EmailServices.EmailDomaines.EmailModels;

namespace HospitalService.Shared.EmailServices.EmailContracts
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
