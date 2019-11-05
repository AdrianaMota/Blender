using System.Collections.Generic;
using System.Threading.Tasks;
using Blender.Models;
using Refit;

namespace Blender.Views
{
    internal interface IMakeupApi
    {
        [Get("https://makeup-api.herokuapp.com/api/v1/products.json")]
        Task<List<MakeupInfo>> GetMakeups();
    }
}