using SmartOfficeAI.Abstraction;

namespace SmartOfficeAI.Common.Views
{
    public record EndPointResponse<T>(T Data, bool IsSuccess, string Message, Error ErrorCode)
    {
        public static EndPointResponse<T> Success(T data, string message, bool isAuthorized = true)
        {
            return new EndPointResponse<T>(data, true, message, Error.None);
        }


        public static EndPointResponse<T> Failure(Error error, string message)
        {
            return new EndPointResponse<T>(default, false, message, error);
        }





    }
}
