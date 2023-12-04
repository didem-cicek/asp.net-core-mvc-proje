using System.Security.Cryptography;

namespace PhotoPortfolio.Areas.adminpanel.Service
{
    public interface IMessageService
    {
        void AddError(string messageKey, params object[] args);
        void AddSuccess(string messageKey, params object[] args);
        string GetErrorMessage();
        string GetSuccessMessage();
    }
}
