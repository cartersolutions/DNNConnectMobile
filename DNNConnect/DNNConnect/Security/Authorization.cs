using System.Threading.Tasks;

using Newtonsoft.Json;

using DNNConnect.Helpers;
using DNNConnect.Models;

namespace DNNConnect.Security
{
    public class Authorization
    {
        public Authorization()
        {
        }

        public static async Task<JWTModel> GetTokenAsync(string username, string password)
        {
            var login = new LoginModel { Username = username, Password = password };
            var loginJson = JsonConvert.SerializeObject(login).ToString();

            string url = "http://dnndev.me/DesktopModules/JwtAuth/API/mobile/login";
            return await APIHelper.PostEncodedData<JWTModel>(url, JsonConvert.SerializeObject(login).ToString());
        }
    }
}

