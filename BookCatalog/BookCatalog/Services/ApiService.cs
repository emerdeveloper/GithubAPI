using BookCatalog.Models;
using BookCatalog.Util.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Services
{
    public class ApiService
    {
        #region Properties
        readonly ApiServiceConnection apiServiceConnection;
        #endregion

        #region Constructor
        public ApiService()
        {
            apiServiceConnection = new ApiServiceConnection();
        }
        #endregion

        public async Task<Response> GetUser()
        {
            var response = await apiServiceConnection.Get<Response>(Constants.Url.users);

            if (!response.IsSuccess)
            {
                if (response.Message.Equals("404"))
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = Constants.Message.UserNotFound,
                        Result = null,
                    };
                }

                return response;
            }

            var model = (Models.User.Response.Response)response.Result;

            return new Response
            {
                IsSuccess = true,
                Message = Constants.Message.SuccessResponse,
                Result = model,
            };
        }

        public async Task<Response> GetFollowers()
        {
            var response = await apiServiceConnection.GetList<Response>(Constants.Url.followers);

            if (!response.IsSuccess)
            {
                return response;
            }

            var model = (List<Models.User.Response.Response>)response.Result;

            if (model == null || model.Count == 0)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = Constants.Message.NoFollowers,
                    Result = null,
                };
            }

            return new Response
            {
                IsSuccess = true,
                Message = Constants.Message.SuccessResponse,
                Result = model,
            };
        }
    }
}
