using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLazy_e_commerce.Controllers
{
    /// <summary>
    /// 订单控制器
    /// </summary>
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 显示订单视图
        /// </summary>
        /// <returns></returns>
        public ActionResult xian()
        {
            return View();
        }
    }
}