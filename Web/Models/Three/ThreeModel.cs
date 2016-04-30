namespace InputCheckbox.Web.Models {
	public class ThreeModel {

		public ThreeModel() {
			// Here's the problem, but we don't want to fix it
			this.Active = true;
		}

		public string Name { get; set; }
		public bool Active { get; set; }
	}
}
