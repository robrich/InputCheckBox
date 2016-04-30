namespace InputCheckbox.Web.Models {
	public class FourEntity {

		public FourEntity() {
			// This data-tier concern is now separate from the presentation-tier concern of model binding:
			this.Active = true;
		}

		public string Name { get; set; }
		public bool Active { get; set; }
	}
}
