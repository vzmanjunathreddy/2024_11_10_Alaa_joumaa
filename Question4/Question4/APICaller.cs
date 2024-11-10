using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    public interface IAPICaller
    {
        Task<string> FetchDataFromAPI1();
        Task<string> FetchDataFromAPI2();
        Task<string> FetchAll();
        Task<string> FetchAny();
    }

    public class APICaller : IAPICaller
    {
        public async Task<string> FetchAll()
        {
            string[] result = await Task.WhenAll<string>(new Task<string>[]
                                                        {
                                                            FetchDataFromAPI1(),
                                                            FetchDataFromAPI2()
                                                        }.ToList());

            return string.Join(",",result);
        }

        public async Task<string> FetchAny()
        {
            Task<string> result = await Task.WhenAny<string>(new Task<string>[]
                                                    {
                                                         FetchDataFromAPI1(),
                                                         FetchDataFromAPI2()
                                                    }.ToList());

            return string.Join(",", result.Result);
        }

        public async Task<string> FetchDataFromAPI1()
        {
            throw new NotImplementedException();
        }

        public async Task<string> FetchDataFromAPI2()
        {
            throw new NotImplementedException();
        }
    }
}
