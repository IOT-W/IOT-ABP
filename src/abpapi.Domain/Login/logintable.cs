using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace abpapi.Login
{
    public class logintable : Entity<Guid>
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        public string Login_userid { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string Login_account { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string Login_pwd { get; set; }

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
