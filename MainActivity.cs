using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Grupo_Pommer_e_Barbosa___App.Droid
{
    //mais um teste
	[Activity (Label = "Hammer Sales", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar; 

			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeModule());
            FormsPlugin.Iconize.Droid.IconControls.Init();

            LoadApplication (new Grupo_Pommer_e_Barbosa___App.App ());

            var x = typeof(Xamarin.Forms.Themes.LightThemeResources);
            var y = typeof(Xamarin.Forms.Themes.DarkThemeResources);
            var z = typeof(Xamarin.Forms.Themes.Android.UnderlineEffect);
        }
	}
}

