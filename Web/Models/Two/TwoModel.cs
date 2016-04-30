namespace InputCheckbox.Web.Models {
	public class TwoModel {

		public TwoModel() {
			// Here's the problem:
			this.Active = true;
		}

		public string Name { get; set; }
		public bool Active { get; set; }
	}
}
