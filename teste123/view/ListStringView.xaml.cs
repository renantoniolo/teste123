using System;
using System.Collections.Generic;
using teste123.Model;
using teste123.viewmodel;
using Xamarin.Forms;

namespace teste123.view
{
    public partial class ListStringView : ContentPage
    {
        public ListStringView(List<TextString> list)
        {
            InitializeComponent();

            this.BindingContext = new ListStringViewModel(list);
        }
    }
}
