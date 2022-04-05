using abpapi.ClassificationType;
using abpapi.Poin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace abpapi.Poins
{
    public class PointServices : ApplicationService, IPointServices
    {
        private readonly IRepository<Point, Guid> db;
        public PointServices(IRepository<Point, Guid> db)
        {
            this.db = db;
        }
        /// <summary>
        /// 添加分类
        /// </summary>
        /// <param name="PName"></param>
        /// <param name="PSName"></param>
        /// <param name="PSort"></param>
        /// <returns></returns>
        public async Task<Point> AddPoint(string PName, string PSName, int PSort)
        {
            var list = await db.InsertAsync(new Point { PName = PName, PSName = PSName, PSort = PSort });
            return new Point
            {
                PName = list.PName,
                PSName = list.PSName,
                PSort = list.PSort,
            };
        }
        /// <summary>
        /// 删除分类
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public async Task DelePoint(Guid guid)
        {
            await db.DeleteAsync(guid);
        }
        /// <summary>
        /// 获取分类信息
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<List<Point>> GetPoint()
        {
            var list = await db.GetListAsync();
            return list;
        }
        /// <summary>
        /// 修改分类信息
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Guid> ProModiPoint(PointOut point)
        {
            var list = ObjectMapper.Map<PointOut, Point>(point);
            var lis = await db.UpdateAsync(list);
            return lis.Id;
        }
    }
}
