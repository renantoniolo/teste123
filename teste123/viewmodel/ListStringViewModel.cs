using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using teste123.Model;

namespace teste123.viewmodel
{
    public class ListStringViewModel : BaseViewModel
    {

        public ListStringViewModel(List<TextString> list)
        {
            ListString = new ObservableCollection<TextString>(list);
        }

        #region Propriedade

        private ObservableCollection<TextString> listString;
        public ObservableCollection<TextString> ListString
        {
            get { return listString; }
            set
            {
                listString = value;
                this.Notify(nameof(ListString));
            }
        }

        #endregion
    }
}
