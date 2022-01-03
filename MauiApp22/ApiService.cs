using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp22
{
    public interface IApiService
    {
        Task<List<NameModel>> GetNameData();
    }

    public class ApiService : IApiService
    {
        public Task<List<NameModel>> GetNameData()
        {
            List<NameModel> list = new();
            for (int i = 0; i < 15; i++)
            {
                list.Add(new NameModel
                {
                    Code = i.ToString(),
                    Name = i.ToString(),
                });
            }

            return Task.FromResult(list);
        }
    }
}
