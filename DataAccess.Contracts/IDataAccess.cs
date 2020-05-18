using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IDataAccess : IService
    {
        Task SaveLog(string userId, DateTime date, string info);
    }
}
