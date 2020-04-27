using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLazy_e_commerce.Controllers
{
    /// <summary>
    /// 商品购物车控制器
    /// </summary>
    public class ShopGoController : Controller
    {
        // GET: ShopGo
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 购物车列表显示
        /// </summary>
        /// <returns></returns>
        public ActionResult Xian()
        {
            return View();
        }

    }
}