using System;
using System.Diagnostics;
using System.Threading.Tasks;
using teste123.view;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace teste123
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PageFraseView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        #region Navigation

        public async static Task NavigationPush(Page page)
        {
            try
            {
                await App.Current.MainPage.Navigation.PushAsync(page);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Falha ao carregar a Navigation Page. " + ex.Message);
            }
        }

        public async static Task NavigationPop()
        {
            try
            {
                await App.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Falha ao carregar a Navigation Page. " + ex.Message);
            }
        }

        #endregion
    }
}
