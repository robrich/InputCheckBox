namespace InputCheckbox.Web.Controllers {
	using System.Web.Mvc;
	using InputCheckbox.Web.Models;

	public class OneController : Controller {

		public ActionResult Index() {
			// database gave us this:
			OneModel model = new OneModel {
				Name = "One Thing"
			};
			return View(model);
		}

		[HttpPost]
		public ActionResult Index(OneModel Model) {
			// Save to database
			return RedirectToAction("Index");
		}

	}
}
