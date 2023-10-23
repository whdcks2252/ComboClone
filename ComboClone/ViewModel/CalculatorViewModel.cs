using ComboClone.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows;
using ComboClone.Model;

namespace ComboClone.ViewModel
{
    public class CalculatorViewModel
    {
        private CollectionViewSource MenuItemsCollection;
        private CollectionViewSource MenuItemsCollection2;

        public ICollectionView SourceCollection => MenuItemsCollection.View;
        public ICollectionView SourceCollection2 => MenuItemsCollection2.View;

        public CalculatorViewModel()
        {

            ObservableCollection<CalculatorModel> menuItems = new ObservableCollection<CalculatorModel>
            {
                new CalculatorModel{ Cal="1"},
                new CalculatorModel{ Cal="2"},
                new CalculatorModel{ Cal="3"},
                new CalculatorModel{ Cal="4"},
                new CalculatorModel{ Cal="5"},
                new CalculatorModel{ Cal="6"},
                new CalculatorModel{ Cal="7"},
                new CalculatorModel{ Cal="8"},
                new CalculatorModel{ Cal="9"},
                new CalculatorModel{ Cal="+"},
                new CalculatorModel{ Cal="-"},
                new CalculatorModel{ Cal="*"},

            };

            MenuItemsCollection = new CollectionViewSource { Source = menuItems };

            ObservableCollection<CalculatorModel> menuItems2 = new ObservableCollection<CalculatorModel>
            {
                new CalculatorModel{ Cal="1"},
                new CalculatorModel{ Cal="2"},
                new CalculatorModel{ Cal="3"},
                new CalculatorModel{ Cal="4"},
           

            };

            MenuItemsCollection2 = new CollectionViewSource { Source = menuItems2 };
        }

        private ICommand menuCommand;
        public ICommand MenuCommand
        {
            get
            {
                if (menuCommand == null)
                {
                    menuCommand = new RelayCommand<object>(param => Cal(param), null);
                }
                return menuCommand;
            }
        }

        public void Cal(object cal)
        {
            string calresult = (string)cal;
            bool isNumeric = int.TryParse(calresult, out _);

            if (calresult == "+" || calresult == "-" || calresult == "*")
            {
                Txt2 = calresult + Txt1;
                Txt1 = null;

            }

            else
            {
                MessageBox.Show("잘못된 입력값 입니다");
                //string modifiedString = Txt1.Substring(0, Txt1.Length - 1);

            }

        }


        private string txt1;
        public string Txt1
        {
            get => txt1;
            set
            {
                txt1 = value;
                OpPropertyChanged("Txt1");
            }
        }
        private string txt2;
        public string Txt2
        {
            get => txt2;
            set
            {
                txt2 = value;
                OpPropertyChanged("Txt2");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OpPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
