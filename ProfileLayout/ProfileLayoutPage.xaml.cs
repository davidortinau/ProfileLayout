using ProfileLayout.ViewModels;
using Xamarin.Forms;

namespace ProfileLayout
{
	public partial class ProfileLayoutPage : ContentPage
	{
		public ProfileLayoutPage()
		{
			InitializeComponent();

			BindingContext = new UserProfileViewModel();

		}
	}
}
