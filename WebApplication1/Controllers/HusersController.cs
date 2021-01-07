using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HusersController : ControllerBase
    {
        //依赖注入的方式引入数据库
        private HongDaContext db;
        //日志
        private ILogger<HusersController> _log;
        /// <summary>
        /// 通过构造方法进行依赖注入
        /// </summary>
        /// <param name="hongDaContext"></param>
        public HusersController(HongDaContext hongDaContext,ILogger<HusersController> logger) {
            db = hongDaContext;
            _log = logger;
        }
        public BackInfo GetInfo(string name,int pageNow,int pageSize) {
            List<Huser> lists = new List<Huser>();
            if (string.IsNullOrEmpty(name))
            {
                lists = db.Husers.ToList();
            }
            lists = db.Husers.Where(o => o.UserName.Contains(name)).ToList();
            return new BackInfo()
            {
                state = 1,
                message = "返回成功",
                result = lists

            };
        }
        public BackInfo Insert(string nickname, string pwd) {
            if (string.IsNullOrEmpty(nickname)||string.IsNullOrEmpty(pwd))
            {
                return new BackInfo()
                {
                    state = 0,
                    message = "参数不能为空",
                    result = ""
                };
            }
            Huser huser = new Huser();
            huser.UserNick = nickname;
            huser.UserPwd = pwd;
            db.Husers.Add(huser);
            int v=db.SaveChanges();
            if (v>0)
            {
                return new BackInfo()
                {
                    state = 1,
                    message = "保存成功",
                    result =""
                };
            }
            else
            {
                return new BackInfo()
                {
                    state = 1,
                    message = "保存成功",
                    result =""
                };
            }
        }

    }
}
