namespace InputCheckbox.Web.Models {
	public class FourModel {

		// no constructor

		public string Name { get; set; }
		public bool Active { get; set; }
	}

	public static class FourModelHelper {
		public static FourModel EntityToModel(FourEntity FourEntity) {
			return new FourModel {
				Name = FourEntity.Name,
				Active = FourEntity.Active
			};
		}

		public static void ModelToEntity(FourEntity FourEntity, FourModel Model) {
			FourEntity.Name = Model.Name;
			FourEntity.Active = Model.Active;
		}
	}
}
