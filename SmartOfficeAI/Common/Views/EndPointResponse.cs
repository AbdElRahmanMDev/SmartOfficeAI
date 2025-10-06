using SmartOfficeAI.Common.Enums;

namespace SmartOfficeAI.Common.Views
{
    public record EndPointResponse<T>(T Data, bool IsSuccess, string Message, ErrorCode ErrorCode)
    {
        public static EndPointResponse<T> Success(T data, string message, bool isAuthorized = true)
        {
            return new EndPointResponse<T>(data, true, message, ErrorCode.Unknown);
        }


        public static EndPointResponse<T> Failure(ErrorCode errorCode, string message)
        {
            return new EndPointResponse<T>(default, false, message, errorCode);
        }





    }
}
