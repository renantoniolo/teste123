using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;
using teste123.Model;
using teste123.view;
using Xamarin.Forms;

namespace teste123.viewmodel
{
    public class PageFraseViewModel : BaseViewModel
    {
        private List<TextString> listString;

        public PageFraseViewModel()
        {
            listString = new List<TextString>();
        }

        #region Propriedades

        private string inputText = "Esta é uma frase exemplo exemplo";
        public string InputText
        {
            get { return inputText; }
            set
            {
                inputText = value;
                this.Notify(nameof(InputText));
            }
        }

        #endregion

        #region Command

        public ICommand SendCommand
        {
            get
            {
                return new Command(async () =>
                {
                    try
                    {
                        if (IsBusy) return;
                        IsBusy = true;

                        if(String.IsNullOrEmpty(InputText))
                        {
                            IsBusy = false;
                            return;
                        }

                        var frase = InputText;

                        var list = this.checkQtdStringEquals(frase);

                        await App.NavigationPush(new ListStringView(list));

                    }
                    catch(Exception ex)
                    {
                        IsBusy = false;
                        Debug.WriteLine("Error:" + ex.Message);
                    }
                });
            }
        }
        #endregion

        #region Private 
        private List<TextString> checkQtdStringEquals(String frase)
        {
            var vet = frase.Split(' ');
            var olString = "";

            for(int i = 0; i < vet.Length; i++)
            {
                var str = new TextString();
                str.textString = vet[i];

                for (int j = 0; j < vet.Length; j++)
                {
                    var strComparer = vet[j];

                    if (str.textString.Equals(strComparer)) {
                        str.qtd++;
                    }
                }

                if (!str.textString.Equals(olString)) // se for palavra repedira nõa entra
                {
                    listString.Add(str);
                }

                olString = str.textString;
            }

            return listString;
        }
        #endregion
    }
}
