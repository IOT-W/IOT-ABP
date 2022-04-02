using abpapi.ClassificationType;
using abpapi.Poin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace abpapi
{
    public interface IPointServices: IApplicationService
    {
        Task<Point> AddPoint(string PName,string PSName,int PSort);
        /// <summary>
        /// 品牌列表
        /// </summary>
        /// <returns></returns>
        Task<List<Point>> GetPoint();
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        Task<Guid> ProModiPoint(PointOut brand);
        Task DelePoint(Guid guid);
    }
}
