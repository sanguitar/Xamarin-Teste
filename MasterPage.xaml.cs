﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grupo_Pommer_e_Barbosa___App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
		public MasterPage ()
		{
			InitializeComponent ();

            BindingContext = new MasterViewModel();

            //ButtonNews.Clicked += async (sender, e) =>
            //{
            //    await App.NavigationMasterDetail(new Views.NewsPage());
            //};

            //ButtonContact.Clicked += async (sender, e) =>
            //{
            //    await App.NavigationMasterDetail(new Views.ContactPage());
            //};
        }
	}
}