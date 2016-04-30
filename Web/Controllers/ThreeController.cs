namespace InputCheckbox.Web.Controllers {
	using System.Web.Mvc;
	using InputCheckbox.Web.Models;

	public class ThreeController : Controller {

		public ActionResult Index() {
			// database gave us this:
			ThreeModel model = new ThreeModel {
				Name = "Three Thing"
			};
			return View(model);
		}

		[HttpPost]
		public ActionResult Index(ThreeModel Model) {
			// Save to database
			return RedirectToAction("Index");
		}

	}
}
