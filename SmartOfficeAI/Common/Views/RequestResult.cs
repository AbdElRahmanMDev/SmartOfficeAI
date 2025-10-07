using SmartOfficeAI.Abstraction;

namespace SmartOfficeAI.Common.Views
{
    public record RequestResult<T>(T Data, bool IsSuccess, string Message, Error ErrorCode)
    {
        public static RequestResult<T> Success(T data, string message)
        {
            return new RequestResult<T>(data, true, message, Error.None);
        }


        public static RequestResult<T> Failure(Error errorCode, string message)
        {
            return new RequestResult<T>(default, false, message, errorCode);
        }

    }
}
