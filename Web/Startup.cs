using InputCheckbox.Web;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace InputCheckbox.Web {
	using Owin;

	public class Startup {
		public void Configuration(IAppBuilder app) {
		}
	}
}
