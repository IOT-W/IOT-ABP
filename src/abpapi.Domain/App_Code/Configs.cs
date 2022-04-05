using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// config 的摘要说明
/// </summary>
public class Configs
{
    public Configs()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    // 应用ID,您的APPID
    public static string app_id = "2021000119653448";

    // 支付宝网关
    public static string gatewayUrl = "https://openapi.alipaydev.com/gateway.do";

    // 商户私钥，您的原始格式RSA私钥
    public static string private_key = "MIIEowIBAAKCAQEApRHKQymMKDaqqY775Er0kqSnC1WbC5d9TpfkWrWqkclYNVicLgwMg5Gl1uB+mAab3/DCEHkdQ7ZUdQYmqEVmrQVYadKlzq17I6vHG6YeZFmXqBwKJtp2mSToTG9c7VTc3v/8tr5RG1y/yX/XeXYstj9IMsRMzivPvvofGTYzUVtMK4sDwBOnGnG4Uf6fnl3bt7W3kPFBb2HvcaMX/KBYVAPwtyp4vrLCMoIZmQySK0llVsvpPbL/BNfDZkcn2SUdMKu43ckJEQ3Ph9pZdL8+Ouap9uX6lnHXnLCpRNjdnis6VZfAwoMo+SQflQIiQZbyRqAgrYF6OazUtwuye2baSwIDAQABAoIBAAFFntJfqpXQvgXqdSRwM2xB2ouq0DQJqcyGPRs51SOkcoqOsT1lmF8XKzj5p+ASBPd3yncIB+Kyr/nq3zdiuYTRyrmeBusNySogM7uRzyAk1JdWB/n+qvVJJIUaQpQNmFobjN33n3Zfg5bQ5l8oOvX4jNzfSFw6WDJ3iO/PzBtvXnv9E3df8H1mX4c57mIO14Z9li4TU5x6g7GNdd7tjzUydw6ayaxwFNoOrGkpzxZ7khMZDqJAl/asfFOYLmHjK2awHiCzUYbdbpY4uXwzTXmJCeDlpQRxc8bGIb3t2mhXwz4dTxR6FysDxOKkBKHwnCESR7hEza3Hhsajs8NCAskCgYEA352gAywTVRasCv4Pzos8TmlMQVMok1TnDit5QyNiTQLPw8jHnEHYyfpy3OUryeyqYvfmKDG316jhQSEpIB98cCdkpvaEPKcy7mgZ539X02bK1tbZtZBE2g+JVskCeLTaVKQ0Q+2WNc8oV5i8z0bCEaolkpSPiVFczoFQoArzOU0CgYEAvPmcMokmaKeUio19dlbyHJlhhJtPLO9TwlE84VMxzx2pp5K121wGbsU6FsP9CwL5+Wn7sClEjJwditjiOV6jddpggojA4ZyRpwCrz0WbSfXQFQ8N1XRy1eVn8qSY4ofmJR8c7PjUzBO14BxBoxieGAc7zS994WdyuJC8Y5GEVfcCgYEAhpXD/KTGbevbWDJZKSK8BSVy884tGZ98ARdBQJtHSrpqeZeaK/2lkMrf3vs/Q6ThV/eD2qUx1OabzCs9KUxKBOZwudyc8jRffwXAsYf/QAkaA/wDxDc0eVnoewc4KZYP4emCW2/ffDtWOIKBAO/BVghl3Lb1PNxvUwqZj/mHMfECgYAUx0VbcSUeAL8edOxEpM6+Qkcss38DK9WD2jbdd65UXaiX2lPQqM+0Qk9ezXH3Uf52ZCbeecslwsykxbAqKrPCc56E+9BpfjOtry80/SxT94lHp34X6FPwHOdPELYWwmaV0lP14m5Teh9XYwP8kOphLfpvVzd6H0vH63IraIaqhQKBgFevbIAYNekHcvKJ66Im4hCan4q8fKGzEnS6FXDJxlH04ipGskXA8Z03EowrgzjU6oguFaWguKLJPCoq0X3bRFa37Sz/uaAC8YZSSx28sYFuHaBr9NLtKIYQilSmnDOR+sgoy7tuX/AltianFqGjpzzmtjznx66R3LtTvW/841TA";

    // 支付宝公钥,查看地址：https://openhome.alipay.com/platform/keyManage.htm 对应APPID下的支付宝公钥。
    public static string alipay_public_key = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAktIHo8HPuHIeQGnfpi4KGVPII11ZJ8ctm9NHxgGUKad3NTJWhHdt+fTydWbxGNDpEwfTnXeAos/ukqhjNgA5KxyhK810cWObCoIzOUZQE4pCeEdib41zgbIa9sh9J4Rgov7wkMEinVLpdomMZDyc6KlkWdWXy57PYbm2rMZAbgTuOPy4GGrsGy87coylp0WSLynbf2O8SP0ZyzCu+Mlz6YbetNgXDeIItQdqUxxilOFJevZop8ja2uBXAEXidMniBCtOxbRznzCZev0+rGbMldioq/8+JJyLGd31sPGLyPftHJhTULBR+LLeMmYTz+xKpW9olMCuYtuhE4ve6jngfwIDAQAB";

    // 签名方式
    public static string sign_type = "RSA2";

    // 编码格式
    public static string charset = "UTF-8";
}