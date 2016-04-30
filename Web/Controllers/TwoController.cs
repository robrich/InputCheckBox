namespace InputCheckbox.Web.Controllers {
	using System.Web.Mvc;
	using InputCheckbox.Web.Models;

	public class TwoController : Controller {

		public ActionResult Index() {
			// database gave us this:
			TwoModel model = new TwoModel {
				Name = "Two Thing"
			};
			return View(model);
		}

		[HttpPost]
		public ActionResult Index(TwoModel Model) {
			// Save to database
			return RedirectToAction("Index");
		}

	}
}
