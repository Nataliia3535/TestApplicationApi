namespace TestApplicationApi.Model
{
    public class ResponseHandler
    {
        public static ApiResponce GetExceptionResponse(Exception ex)
        {
            ApiResponce response = new ApiResponce();
            response.Code = "1";
            response.ResponseData = ex.Message;
            return response;
        }
        public static ApiResponce GetAppResponse(ResponseType type, object? contract)
        {
            ApiResponce response;

            response = new ApiResponce { ResponseData = contract };
            switch (type)
            {
                case ResponseType.Success:
                    response.Code = "0";
                    response.Message = "Success";

                    break;
                case ResponseType.NotFound:
                    response.Code = "2";
                    response.Message = "No record available";
                    break;
            }
            return response;
        }
    }
}

