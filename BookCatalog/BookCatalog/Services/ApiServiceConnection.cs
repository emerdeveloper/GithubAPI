using BookCatalog.Models;
using BookCatalog.Util.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Services
{
    public class ApiServiceConnection
    {
        #region Properties
        HttpClient httpClient;
        #endregion

        #region Constructor
        public ApiServiceConnection()
        {            
        }
        #endregion

        #region Methods
        public async Task<Response> Get<T>(string url)
        {
            try
            {

                httpClient = new HttpClient
                {
                    BaseAddress = new Uri(Constants.Url.BaseAdress)
                };

                var response = await httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = response.StatusCode.ToString(),
                        Result = null,
                    };
                }

                var result = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<T>(result);

                return new Response
                {
                    IsSuccess = true,
                    Message = Constants.Message.SuccessResponse,
                    Result = model,
                };

            }
            catch (Exception e)
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine("::::Class : ApiServiceConnection----- Method: Get<T>(string url)" + e.Message.ToString());
#endif
                    return new Response
                {
                    IsSuccess = false,
                    Message = Constants.Message.ErrorResponse,
                    Result = null,
                };
            }
        }

        public async Task<Response> GetList<T>(string url)
        {
            try
            {

                httpClient = new HttpClient
                {
                    BaseAddress = new Uri(Constants.Url.BaseAdress)
                };

                var response = await httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = response.StatusCode.ToString(),
                        Result = null,
                    };
                }

                var result = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<List<T>>(result);

                return new Response
                {
                    IsSuccess = true,
                    Message = Constants.Message.SuccessResponse,
                    Result = model,
                };

            }
            catch (Exception e)
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine("::::Class : ApiServiceConnection----- Method: Get<T>(string url)" + e.Message.ToString());
#endif
                return new Response
                {
                    IsSuccess = false,
                    Message = Constants.Message.ErrorResponse,
                    Result = null,
                };
            }
        }
            #endregion
        }
}
