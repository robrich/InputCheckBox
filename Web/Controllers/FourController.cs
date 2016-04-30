namespace InputCheckbox.Web.Controllers {
	using System.Web.Mvc;
	using InputCheckbox.Web.Models;

	public class FourController : Controller {

		public ActionResult Index() {
			// database gave us this:
			FourEntity entity = new FourEntity {
				Name = "Four Thing"
			};
			FourModel model = FourModelHelper.EntityToModel(entity);
			return View(model);
		}

		[HttpPost]
		public ActionResult Index(FourModel Model) {
			FourEntity entity = new FourEntity(); // got from the db
			FourModelHelper.ModelToEntity(entity, Model);
			// Save entity to database
			return RedirectToAction("Index");
		}

	}
}
