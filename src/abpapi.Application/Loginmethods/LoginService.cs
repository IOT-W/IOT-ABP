using abpapi.ILoginService.DTO;
using abpapi.Login;
using Alipay.AopSdk.Core;
using Alipay.AopSdk.Core.Request;
using Alipay.AopSdk.Core.Response;
using IOT.electricity.ILogin;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace IOT.electricity.Loginmethods
{
    public class LoginService : ApplicationService, ILoginService
    {
        private readonly IRepository<logintable, Guid> repository;
        private readonly string alipay_public_key = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA3kOaQsS2p+Zm+uX5EYucSOMJGm3PjnjVCfFXqHycNQDg5qG8QVktKz5BoAYfdN6L2Kj3Sm1e95Q4mOcx3lEx6L3QuSSUzcf+Rwbmig9ADnnW7SNU76jagxXzP41QFraBgMWcozemsikIuB/eVwELW5Wrvc1AChDM3ppHgXFKxA7eeFpXx/KNJQVvve24beNtnZk0ltZDlgxQlSMM25xLd1BZHgUltlhdaaluPgR/esD3rqn+fIPDmQgCeUv7XWVa5kfnXUlFgei90Qen3arZW7DCi2GdsBTOnywD+n5weRFlVHzZJXoCfrvtssy+TqUlmPxcrGn1aGGW1Z7LvI5uOwIDAQAB";
        private readonly string merchant_private_key = "MIIEowIBAAKCAQEAuTxHlG1IH1l3491pbOg1zYAm+q0NZBu5epKysrkqkqA4ykJBChOhHgFbR/O67dr7HQzRKN63usg1tYkPGJLZjrxwgT4yyuxAPy5nBMA5j58IABCQr93zb75xvoEHdcngk0XjxApN1zoIH+1xhPRh37xIGtTPEeOP7uJmgbvSusM2WQ7f+MHeLb1IFEtE4RL60CkzGqV8Y4BXoQJDvCmJGg/SRaLy8170NVJkpEwLcc1qb6QEkjnO+FZ7QXR98IdzkF0kYMP5KsacrFhz3mZrT5v3aoeXGAz2S/nljnMQ9acw/HovmQA4/MEKXvJhi47QHUHdIwfcTafwfF9eDjBFwQIDAQABAoIBAGJkBXVusr+MK2WKxyQFGAcHCi1e3F0PaO8VmvvZ5SYrGt88YAW1NYCVoeHPMbyD85yToUn/O0JodDbwDWe1IQBzUaMk4Z/t65Zj1G6umCSUiZBXPDNeRp9VXl+dc9P6HmK73ebUvlITTht/aSwBDzfjb71oynCrGln+QgqpNJ7khp8Sj4XFKSs9dZa8WMnnTEKag8Jwh+X3qY9/FN/j0nRds+7nztIIqFDgP3DfJBMK0IVV8YpHliWxdUGtFrS1sWz5rvSPWXn0uB6QbIvqcZTo/TqDuIBM7ODdy1YIi0b2YhNfZVg+3Ex5h1+M7K1y+C+sB04uM1E4UA5Heya5RW0CgYEA+fzwOXCUDPodltLjtSVzdbiZWbVF9FgbCyE1YllpwZTdbMIxTx5r6vmR+msy0yZIqVRLKlelKHj5zvY2Rrs5dLXEK1u3A2g6uCTuM44ihdRobCq+uOZ6lm6J5ceIYPflK4keRhqyalzmyChCzmrWQptikKVoIbeiWIn6yXF6Tg8CgYEAvbCwedT4xBJi71gGocU6EBzbwwhm3GJDrCbIZitzBe6qrwUATVt62Ny73Ehcc1bBnKMinh2Y/lMBbq5fU/EX6cmBjP69GGcCgxnjUbuPY446ssfRurmjwCrIKiqulLnrdfYSp1UEX5sj0mF74b1CvK+TZfpnIPrglhE1pOZV/y8CgYEA7guDnM6szCanYmVy253L8j9UF25cLK5xIgn/UaWe5O0iZFwOpC5tyRTZgsHtZc9Axa003h8TcBSym/cr+/JwZchoAnmVLjNkJtFT2dfw28tFnCqf7mXaOcEMord8EAo+OVSadVsapdnNEK/13aUyXb6k/uPi4qiAeRr6qjPaqNUCgYB1JGBXXIYjz5b5Z8rwq/Onb6rnTpD3GFfiQDERp1NpHnKZkuUU4KGEuwvohWdScwktyjDepDiPFoOT7mtAU2sJHT+76rSsFTEf9STEnKd4O6VUMsH6JhpR2hmysJkPj6ExP71VSNNil1QP39O5HD/Sdjr4hyKY41U+V3JhWz1QUQKBgA+Nhe3makElPYHKG3LeydGSxAGvGwmBMayP7aZYolBCfZtLgbnq1HpT2/tMjOBUR1RMSJH8fqbl2MkvdekiT6hnEqJZQhpjsTgkVPbu9jeJBWBjnKTa1g0yIgLQX9NXq2X1gXM0BDjXrobao+1qvxIYXljnGZ77WsYuwobaCUwH";

        public LoginService(IRepository<logintable, Guid> repository)
        {
            this.repository = repository;
        }

        [HttpPost, Route("api/AddLogin")]
        public async Task<logintableDTO> AddLogin(logintable userLogins)
        {
            var emp = await repository.InsertAsync(userLogins);
            return new logintableDTO
            {
                Login_account = emp.Login_account,
                Login_pwd = emp.Login_pwd,
                Login_name = emp.Login_name,
                Login_state = emp.Login_state,
            };
        }

        [HttpGet, Route("api/Login")]
        public async Task<logintableDTO> Getlogin(string name, string pwd)
        {
            var emp = await repository.GetAsync(x => x.Login_account.Equals(name) & x.Login_pwd.Equals(pwd));

            var list = ObjectMapper.Map<logintable, logintableDTO>(emp);

            return list;
        }

        /// <summary>
        /// 支付宝请求用户授权码
        /// </summary>
        /// <param name="rCode"></param>
        /// <returns></returns>
        public string RequestUserCode(string rCode)
        {
            
            IAopClient client = new DefaultAopClient("https://openapi.alipay.com/gateway.do", "2021003125650409", merchant_private_key, "json", "1.0", "RSA2", alipay_public_key, "utf-8", false);
            AlipaySystemOauthTokenRequest request = new AlipaySystemOauthTokenRequest();
            request.GrantType = "authorization_code";
           
            request.Code = rCode;
            AlipaySystemOauthTokenResponse response = client.Execute(request);
            return (response.Body);
        }
        /// <summary>
        /// 支付宝获取用户信息
        /// </summary>
        /// <returns></returns>
        public string GetUserInfo(string authCode)
        {
            IAopClient client = new DefaultAopClient("https://openapi.alipay.com/gateway.do", "2021003125650409", merchant_private_key, "json", "1.0", "RSA2", alipay_public_key, "utf-8", false);
            AlipayUserInfoShareRequest request = new AlipayUserInfoShareRequest();
            AlipayUserInfoShareResponse response = client.Execute(request, authCode);
            return response.Body;
        }
    }
}
