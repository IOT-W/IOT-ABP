using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Qiniu.Http;
using Qiniu.Storage;
using Qiniu.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mcks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QiniuController : ControllerBase
    {
        private class Settings
        {
            public static string AccessKey { get; set; } = "kOXD8FET1LhOjYj45VrUNgPHF9XJCSGqrt0VYV6y";
            public static string SecretKey { get; set; } = "LigQDACAR1N-UcYPHtFmsIwgS2LgEE2L_oXAwIdn";
        }
        [HttpPost, Route("content/uploadqiniu")]
        public IActionResult Qiniu(IFormFile file)
        {
            // 生成(上传)凭证时需要使用此Mac
            // 这个示例单独使用了一个Settings类，其中包含AccessKey和SecretKey
            // 实际应用中，请自行设置您的AccessKey和SecretKey
            Mac mac = new Mac(Settings.AccessKey, Settings.SecretKey);
            string rootdir = AppContext.BaseDirectory.Split(@"\bin\")[0];
            string bucket = "wujunhao"; //这个是我们在七牛云上创建的“存储空间”名称
            string saveKey = DateTime.Now.ToString("yyyyMMddHHmmssffff") + System.IO.Path.GetExtension(file.FileName); //这个abc 相当于一个文件夹，是我们只设定的。2.png是我们上传文件的文件名，上传成功后通过它来读
            string path = rootdir + @"\Upload\" + saveKey;
            using (System.IO.FileStream fs = System.IO.File.Create(path))
            {
                file.CopyTo(fs);
                fs.Flush();//清空文件流
            }
            string localFile = path; //文件路径
            PutPolicy putPolicy = new PutPolicy();
            // 如果需要设置为"覆盖"上传(如果云端已有同名文件则覆盖)，请使用 SCOPE = "BUCKET:KEY"
            // putPolicy.Scope = bucket + ":" + saveKey;
            putPolicy.Scope = bucket;
            // 上传策略有效期(对应于生成的凭证的有效期)          
            putPolicy.SetExpires(3600);
            // 上传到云端多少天后自动删除该文件，如果不设置（即保持默认默认）则不删除
            //putPolicy.DeleteAfterDays = 1;
            // 生成上传凭证                    
            string jstr = putPolicy.ToJsonString();
            string token = Auth.CreateUploadToken(mac, jstr);

            //Config配置类中可以配置区域，比如在我在七牛云上创建的fanin这个存储空间的区域选择的是“华南”这里就将它设为Zone=Zone.ZONE_CN_South 
            //UseHttps表示：是否采用https域名
            //UseCdnDomains表示：上传是否使用CDN上传加速
            //MaxRetryTimes表示：重试请求次数 华北North China            
            UploadManager um = new UploadManager(new Config()
            {
                Zone = Zone.ZONE_CN_South,
                UseHttps = true,
                UseCdnDomains = true,
                MaxRetryTimes = 3
            });
            HttpResult result = um.UploadFile(localFile, saveKey, token, new PutExtra());
            return Ok(new {img= "http://r9n14zrki.hn-bkt.clouddn.com/" + saveKey });

        }
    }
}