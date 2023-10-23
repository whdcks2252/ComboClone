using ComboClone.Command;
using ComboClone.Utils;
using ComboClone.ViewModel.SA.Enum;
using ComboClone.ViewModel.SA.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace ComboClone.ViewModel.SA
{
    public class MainMenuViewModel :ViewModelBase
    {
        private CollectionViewSource SubMenuCollection;
        public ICollectionView SourceCollection => SubMenuCollection.View;
        public event Action<object> ChageSubMenu;

        public MainMenuViewModel()
        {
            ObservableCollection<MainMenuModel> Meas = new ObservableCollection<MainMenuModel>
            {
                new MainMenuModel{MainMenuName=Menu.Freq.Description()},
                new MainMenuModel{MainMenuName=Menu.Span.Description()},
                new MainMenuModel{MainMenuName=Menu.Amp.Description()},
                new MainMenuModel{MainMenuName=Menu.BW.Description()},
                new MainMenuModel{MainMenuName=Menu.Marker.Description()},
                new MainMenuModel{MainMenuName=Menu.Peak.Description()},
                new MainMenuModel{MainMenuName=Menu.Trace.Description()},
                new MainMenuModel{MainMenuName=Menu.Sweep.Description()},
                new MainMenuModel{MainMenuName=Menu.Standard.Description()},
                new MainMenuModel{MainMenuName=Menu.Setup.Description()},
               new MainMenuModel{MainMenuName=Menu.Sys.Description()},

            };

            SubMenuCollection = new CollectionViewSource { Source = Meas };
        }


        private ICommand chageSASubMenu;

        public ICommand ChageSASubMenu
        {
            get
            {
                if (chageSASubMenu == null)
                {
                    chageSASubMenu = new RelayCommand<object>(param => ChageSubMenu(param), null);
                }
                return chageSASubMenu;
            }
        }



    }
}
