using ComboClone.ViewModel.SA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboClone.ViewModel
{
    public class SAViewModel :ViewModelBase
    {

        private readonly SubMenuViewModel subMenuViewModel;
        private readonly MainMenuViewModel mainMenuViewModel;
        private object selectedSAViewModel;

        public SAViewModel(SubMenuViewModel subMenuViewModel, MainMenuViewModel mainMenuViewModel) {
            this.subMenuViewModel = subMenuViewModel;
            this.mainMenuViewModel= mainMenuViewModel;

            mainMenuViewModel.ChageSubMenu += subMenuViewModel.SwitchViews;

        }




        public SubMenuViewModel? SubMenuViewModel { get { return subMenuViewModel; } }
        public MainMenuViewModel? MainMenuViewModel { get { return mainMenuViewModel; } }

        public object SelectedSAViewModel
        {
            get => selectedSAViewModel;
            set
            {
                selectedSAViewModel = value;
                OpPropertyChanged("SelectedViewModel");
            }
        }

    }
}
