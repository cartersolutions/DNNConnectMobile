using System.Collections.Generic;
using System.Threading.Tasks;

using DNNConnect.Helpers;

namespace DNNConnect.Repositories
{
    public class ItemRepository
    {
        public ItemRepository()
        {
        }

        /// <summary>
        /// Gets the stores.
        /// </summary>
        /// <returns>The stores.</returns>
        public static async Task<List<ItemModel>> GetItemsAsync()
        {
            string url = "http://dnndev.me/DesktopModules/DnnSpaModule1/API/Item";
            return await APIHelper.ExecuteAsync<List<ItemModel>>(url);
        }
    }
}

