namespace Contracts.WebApi.Controllers
{
    public sealed class ErrorMessage
    {
        private string Message { get; }

        public ErrorMessage(string message) => Message = message;
    }
}