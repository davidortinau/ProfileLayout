using System;
using System.Collections.Generic;
using ProfileLayout.ViewModels;
using Xamarin.Forms;

namespace ProfileLayout.Views
{
	public partial class ConnectSocialButtonView : ContentView
	{
		public ConnectSocialButtonView()
		{
			InitializeComponent();

			BindingContext = new SocialServiceViewModel {
				Network = "Facebook",
				DisconnectedImageUrl = "facebook_icon_grey.png",
				ConnectedImageUrl = "facebook_icon_white.png",
				CanConnect = false
			};

		}
	}
}

