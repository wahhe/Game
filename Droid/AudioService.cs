using System;
using Xamarin.Forms;
using IIIIIIIIIII.Droid;  // change to your namespace
using Android.Media;
using Android.Content.Res;

[assembly: Dependency(typeof(AudioService))]
namespace IIIIIIIIIII.Droid
{
	public class AudioService
	{
		public AudioService()
		{
		}
		public void PlayAudioFile(string fileName)
		{
			var player = new MediaPlayer();
			var fd = global::Android.App.Application.Context.Assets.OpenFd(fileName);
			player.Prepared += (s, e) =>
			{
				player.Start();
			};
			player.SetDataSource(fd.FileDescriptor, fd.StartOffset, fd.Length);
			player.Prepare();
		}


	}
}
