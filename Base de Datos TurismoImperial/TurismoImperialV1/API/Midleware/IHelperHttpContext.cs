using Models.Common;

namespace API.Midleware
{
    public interface IHelperHttpContext
    {
        InfoRequest GetInfoRequest(HttpContext request);
    }
}
