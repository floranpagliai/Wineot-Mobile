using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Reflection;
using System.Threading.Tasks;
using Plugin.Media;

namespace Wineot
{
	public partial class CameraPage : ContentPage
	{
		public CameraPage ()
		{
			this.Icon = "camera.png";
			InitializeComponent ();

			takePhoto.Clicked += async (sender, args) =>
			{

				if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
				{
					DisplayAlert("No Camera", ":( No camera available.", "OK");
					return;
				}

				var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
					{
						Directory = "Wineot",
						Name = "test.jpg"
					});

				byte[] bytes = new byte[file.GetStream().Length];
				file.GetStream().Read(bytes, 0, Convert.ToInt32(file.GetStream().Length));
				String picture = Convert.ToBase64String(bytes);
				WineService.Instance.GetWineRecognitionAction(picture);
				ImageTest.Source = ImageSource.FromStream(() =>
					{
						var stream = file.GetStream();
						file.Dispose();
						return stream;
					});
			};
		}


	}
}

