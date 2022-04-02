using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace abpapi.ILogin.DTO
{
    public class logintableDTO 
    {
        /// <summary>
        /// 用户账号
        /// </summary>
        public string Login_account { get; set; }

        /// <summary>
        /// 支付宝用户名称
        /// </summary>
        public string Login_name { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string Login_avatar { get; set; }

        /// <summary>
        /// 账号状态
        /// </summary>
        public int Login_state { get; set; }
    }
}
