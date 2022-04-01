using abpapi.CommodityManagement;
using abpapi.OutPut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using AutoMapper;

namespace abpapi.Services
{
    public class GoodsServices : ApplicationService, IGoodsServices
    {
        private readonly IRepository<Goods,Guid> repository;
        public GoodsServices(IRepository<Goods, Guid> repository)
        {
            this.repository = repository;
        }
        public async Task<Goods> Addbook(string Goods_Img, string Goods_Name, string Goods_Classification, string Goods_SalePrice, string Goods_MarketPrice, string Goods_Sku, string Goods_Shelves, string Goods_Type, string Goods_Coding)
        {
            var list = await repository.InsertAsync(new Goods { Goods_Img = Goods_Img, Goods_Name = Goods_Name, Goods_Classification = Goods_Classification, Goods_SalePrice = Goods_SalePrice, Goods_MarketPrice = Goods_MarketPrice, Goods_Sku = Goods_Sku, Goods_Shelves = Goods_Shelves, Goods_Type = Goods_Type, Goods_Coding = Goods_Coding });
            return new Goods
            {
                Goods_Img = list.Goods_Img,
                Goods_Name = list.Goods_Name,
                Goods_Classification = list.Goods_Classification,
                Goods_SalePrice = list.Goods_SalePrice,
                Goods_MarketPrice = list.Goods_MarketPrice,
                Goods_Sku = list.Goods_Sku,
                Goods_Shelves = list.Goods_Shelves,
                Goods_Type = list.Goods_Type,
                Goods_Coding = list.Goods_Coding
            };
        }

        public async Task<int> DeleteAsync(string id)
        {
            string[] strArr = id.Split(',');

            var all= await  repository.GetListAsync(x => id.ToString().Contains(x.Id.ToString()));

            repository.DeleteManyAsync(all);

            return 0;
         
        }

        public async Task<List<Goods>> Getbook(string Goods_Name, string Goods_Classification, string Goods_SalePrice, string Goods_MarketPrice, string Goods_Sku, string Goods_Shelves, string Goods_Type, string Goods_Coding)
        {
            var list = await repository.GetListAsync();
            if(!string.IsNullOrEmpty(Goods_Name))
            {
                list = list.Where(x => x.Goods_Name.Contains(Goods_Name)).ToList();
            }
            if (!string.IsNullOrEmpty(Goods_Classification))
            {
                list = list.Where(x => x.Goods_Classification.Contains(Goods_Classification)).ToList();
            }
            if (!string.IsNullOrEmpty(Goods_SalePrice))
            {
                list = list.Where(x => x.Goods_SalePrice.Contains(Goods_SalePrice)).ToList();
            }
            if (!string.IsNullOrEmpty(Goods_MarketPrice))
            {
                list = list.Where(x => x.Goods_MarketPrice.Contains(Goods_MarketPrice)).ToList();
            }
            if (!string.IsNullOrEmpty(Goods_Sku))
            {
                list = list.Where(x => x.Goods_Sku.Contains(Goods_Sku)).ToList();
            }
            if (!string.IsNullOrEmpty(Goods_Shelves))
            {
                list = list.Where(x => x.Goods_Shelves.Contains(Goods_Shelves)).ToList();
            }
            if (!string.IsNullOrEmpty(Goods_Type))
            {
                list = list.Where(x => x.Goods_Type.Contains(Goods_Type)).ToList();
            }
            if (!string.IsNullOrEmpty(Goods_Coding))
            {
                list = list.Where(x => x.Goods_Coding.Contains(Goods_Coding)).ToList();
            }
            return list;
        }

        public async Task<Guid> ProModif(Goods_View goods)
        {
            var lists = ObjectMapper.Map<Goods_View, Goods>(goods);
            var list = await repository.UpdateAsync(lists);
            return list.Id;
        }

        public async Task<Guid> ShelvesModif(Goods_View goods)
        {
            var lists = ObjectMapper.Map<Goods_View, Goods>(goods);
            var list = await repository.UpdateAsync(lists);
            return list.Id;
        }
    }
}
