using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Util.Enums
{
    public class Constants
    {
        public struct Url
        {
            public const string BaseAdress = "https://api.github.com";
            public const string users = "users";
            public const string followers = "followers";
        }

        public struct Message
        {
            public const string SuccessResponse = "OK";
            public const string ErrorResponse = "Ocurrió un error inesperado";
            public const string UserNotFound = "No se encontró al usuario";
            public const string NoFollowers = "No tiene seguidores";
        }
    }
}
