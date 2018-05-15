using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Company.IBLL;
using Company.Model;

namespace Company.UI.Controllers
{
    public class CommpanyController: Controller
    {
        private IStaffService StaffService = BLLContainer.Container.Resolve<IStaffService>();
        // GET: Home
        public ActionResult Index()
        {
            List<user> list = StaffService.GetModels(p => true).ToList();
            return View(list);
        }
        public ActionResult Add(user staff)
        {
            if (StaffService.Add(staff))
            {
                return Redirect("Index");
            }
            else
            {
                return Content("no");
            }
        }
        public ActionResult Update(user staff)
        {
            if (StaffService.Update(staff))
            {
                return Redirect("Index");
            }
            else
            {
                return Content("no");
            }
        }
        public ActionResult Delete(int Id)
        {
            var staff = StaffService.GetModels(p => p.ID == Id).FirstOrDefault();
            if (StaffService.Delete(staff))
            {
                return Redirect("Index");
            }
            else
            {
                return Content("no");
            }
        }
    }
}