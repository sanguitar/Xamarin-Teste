using System.Windows.Input;
using Xamarin.Forms;

namespace Grupo_Pommer_e_Barbosa___App
{
    public class MasterViewModel
    {
        public ICommand NavigationCommand
        {
            get
            {
                return new Command((value) =>
                {
                    //// COMMENT: This is just quick demo code. Please don't put this in a production app.
                    //var mdp = (Application.Current.MainPage as MasterDetailPage);
                    //var navPage = mdp.Detail as NavigationPage;

                    //// Hide the Master page
                    //mdp.IsPresented = false;

                    switch (value)
                    {
                        case "1":
                            App.NavigationMasterDetail(new Views.ItemsPage());
                            break;
                        case "2":
                            App.NavigationMasterDetail(new Views.BusinessPartner());
                            break;
                    }

                });
            }
        }
    }
}
