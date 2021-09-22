using System;
using System.Collections.Generic;
using teste123.viewmodel;
using Xamarin.Forms;

namespace teste123.view
{
    public partial class PageFraseView : ContentPage
    {
        public PageFraseView()
        {
            InitializeComponent();

            this.BindingContext = new PageFraseViewModel();
        }
    }
}
