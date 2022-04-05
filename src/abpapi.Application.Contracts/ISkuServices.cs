using abpapi.ClassificationType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace abpapi
{
    public interface ISkuServices: IApplicationService
    {
        Task<Sku> AddSku(string Color, decimal ShopMarkPrice, decimal ShopPrice, int ShopNum);
    }
}
