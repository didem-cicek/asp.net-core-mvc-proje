namespace PhotoPortfolio.Areas.adminpanel.Service
{
    public class MessageService : IMessageService
    {
        private string _errorMessage;
        private string _successMessage;
        public void AddError(string messageKey, params object[] args)
        {
            // Dil çevirisi ve mesaj formatlama işlemleri burada gerçekleştirilebilir
            _errorMessage = string.Format(GetMessage(messageKey), args);
        }

        public void AddSuccess(string messageKey, params object[] args)
        {
            // Dil çevirisi ve mesaj formatlama işlemleri burada gerçekleştirilebilir
            _successMessage = string.Format(GetMessage(messageKey), args);
        }

        public string GetErrorMessage()
        {
            return _errorMessage;
        }

        public string GetSuccessMessage()
        {
            return _successMessage;
        }

        // Dil çevirisi, mesaj formatlama vb. işlemleri burada gerçekleştirilebilir
        private string GetMessage(string messageKey)
        {
            // Örnek olarak, bir dil çevirisi servisi kullanılabilir
            return messageKey;
        }
    }
}
