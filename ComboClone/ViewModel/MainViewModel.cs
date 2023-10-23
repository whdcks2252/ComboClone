using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboClone.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        private readonly CategoryViewModel? categoryViewModel;
        private readonly LTE_5G_ViewModel lTE_5G_ViewModel;
        private readonly SAViewModel sAViewModel;
        private readonly VSWRViewModel vSWRViewModel;
        private readonly DTFViewModel dTFViewModel;
        private readonly CableLossViewModel cableLossViewModel;
        private readonly CalculatorViewModel calculatorViewModel;

        private bool isCalculatorModalOpen;
        //select ViewModel
        private object _selectedViewModel;

        public MainViewModel(CategoryViewModel categoryViewModel,LTE_5G_ViewModel lTE_5G_ViewModel,SAViewModel sAViewModel,
                             VSWRViewModel vSWRViewModel,DTFViewModel dTFViewModel,CableLossViewModel cableLossViewModel, 
                             CalculatorViewModel calculatorViewModel)
        {
            this.categoryViewModel = categoryViewModel;
            this.lTE_5G_ViewModel = lTE_5G_ViewModel;
            this.sAViewModel = sAViewModel;
            this.vSWRViewModel = vSWRViewModel;
            this.dTFViewModel = dTFViewModel;
            this.cableLossViewModel = cableLossViewModel;
            this.calculatorViewModel = calculatorViewModel;


            sAViewModel.SubMenuViewModel.ViewModal += ShowModal;
            categoryViewModel.ChageMainView += SwitchViews;
        }

   
        public CategoryViewModel? CategoryViewModel { get { return categoryViewModel; }  }
        public CalculatorViewModel? CalculatorViewModel { get { return calculatorViewModel; } }

        public void SwitchViews(object parameter)
        {
            switch (parameter)
            {
                case "5G_LTE":
                    SelectedViewModel = lTE_5G_ViewModel;
                    break;
                case "SA":
                    SelectedViewModel = sAViewModel;
                    break;
                case "VSWR":
                    SelectedViewModel = vSWRViewModel;
                    break;
                case "DTF":
                    SelectedViewModel = dTFViewModel;
                    break;
                case "CableLoss":
                    SelectedViewModel = cableLossViewModel;
                    break;
                
                default:
                    SelectedViewModel = lTE_5G_ViewModel;
                    break;
            }

        }


        public void ShowModal()
        {
            IsCalculatorModalOpen = true;
        }




        public bool IsCalculatorModalOpen { get => isCalculatorModalOpen;
            set
            {
                isCalculatorModalOpen = value;
                OpPropertyChanged("IsCalculatorModalOpen");

            }
        }


        public object SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                OpPropertyChanged("SelectedViewModel");
            }
        }

       
    }
}
