using abpapi.GwcModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abpapi.IGwc
{
    public interface IGwcServices
    {
        int AddGwcRedis(GwcInputModels gwc, string UserName);
        List<GwcOutPutModels> GetRedis(string UserName);
        int DeleteRedis(int id, string UserName);
        int DeleteAllRedis(string id, string UserName);
        void EmptyRedis(string UserName);
        void UpdRedis(int id, int num, string UserName);
    }
}
