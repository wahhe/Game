using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IIIIIIIIIII
{
	public partial class titlePages : ContentPage
	{
		public titlePages()
		{
			InitializeComponent();
		}
		public void playButton_Clicked(object sender, EventArgs args)
		{
			DependencyService.Get<IIIIIIIIIIIIIIII.IAudio>().PlayAudioFile("gmclick.wav");
			Application.Current.MainPage = new MainScreen();


		}

	}
}
