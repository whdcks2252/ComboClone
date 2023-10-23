using ComboClone.Command;
using ComboClone.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace ComboClone.ViewModel
{
    public class CategoryViewModel:ViewModelBase
    {
        private CollectionViewSource categorysCollection;
        public ICollectionView SourceCollection => categorysCollection.View;
        public event Action<object> ChageMainView;

        public CategoryViewModel()
        {
            ObservableCollection<CategoryModel> categorys = new ObservableCollection<CategoryModel>
            {
                new CategoryModel{CategoryName="5G/LTE" },
                new CategoryModel{CategoryName="SA"},
                new CategoryModel{CategoryName="VSWR"},
                new CategoryModel{CategoryName="DTF"},
                new CategoryModel{CategoryName="Cable Loss"},


            };

            categorysCollection = new CollectionViewSource { Source = categorys };
        }

        private ICommand chageView;

        public ICommand ChageView
        {
            get
            {
                if (chageView == null)
                {
                    chageView = new RelayCommand<object>(param => ChageMainView(param), null);
                }
                return chageView;
            }
        }



        public string Time { get; set; } = "10:10:10";

    }
}
