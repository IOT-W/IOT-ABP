using abpapi.ClassificationType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace abpapi.Skuc
{
    public class SkuServices : ApplicationService, ISkuServices
    {
        private readonly IRepository<Sku, Guid> db;
        public SkuServices(IRepository<Sku, Guid> db)
        {
            this.db = db;
        }
        public async Task<Sku> AddSku(string Color, decimal ShopMarkPrice, decimal ShopPrice, int ShopNum)
        {
            var list = await db.InsertAsync(new Sku { Color = Color, ShopMarkPrice = ShopMarkPrice, ShopPrice = ShopPrice, ShopNum = ShopNum });
            return new Sku
            {
                Color = list.Color,
                ShopMarkPrice = list.ShopMarkPrice,
                ShopPrice = list.ShopPrice,
                ShopNum = ShopNum
            };
           
        }
    }
}
