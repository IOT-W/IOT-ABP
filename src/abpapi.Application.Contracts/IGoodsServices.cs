using abpapi.CommodityManagement;
using abpapi.OutPut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace abpapi
{
    public interface IGoodsServices:IApplicationService
    {
        Task<List<Goods>> Getbook(string Goods_Name,string Goods_Classification,string Goods_SalePrice,string Goods_MarketPrice,string Goods_Sku,int Goods_Shelves,string Goods_Type,string Goods_Coding);
        Task<Goods> Addbook(string Goods_Img, string Goods_Name, string Goods_Classification, string Goods_SalePrice,string Goods_MarketPrice,string Goods_Sku,int Goods_Shelves,string Goods_Type,string Goods_Coding);
        Task<int> DeleteAsync(string id);
        Task<Guid> ProModif(Goods_View goods);
        Task<int> ShelvesModif(Guid id,int State);

    }
}
