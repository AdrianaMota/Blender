using System;
using System.Threading.Tasks;
using Refit;

namespace Blender
{
    public interface IMakeupApi
    {
        [Get("https://makeup-api.herokuapp.com/api/v1/products.json")]
        Task<string> GetMakeups();
    }
}
