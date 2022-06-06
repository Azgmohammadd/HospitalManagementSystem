using Newtonsoft.Json;
using SharedStorage.Models;

namespace SharedStorage.Extensions
{
    public static class ResponseExtension
    {
        public static ResponseModel<T> GetErrorResponse<T>(this ResponseModel<T> response, Exception e)
        {
            return new ResponseModel<T>()
            {
                HasError = true,
                Message = e.Message
            };
        }

        public static string GetErrorResponseToString<T>(this ResponseModel<T> response, Exception e)
        {
            return JsonConvert.SerializeObject(new ResponseModel<T>()
            {
                HasError = true,
                Message = e.Message
            });
        }
    }
}