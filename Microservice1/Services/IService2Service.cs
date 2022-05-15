using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservice1.Services
{
    public interface IService2Service
    {
        Task<List<string>> getValuesfromService2();
    }
}