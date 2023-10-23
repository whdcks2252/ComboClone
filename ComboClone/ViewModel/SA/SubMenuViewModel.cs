using ComboClone.Command;
using ComboClone.Model;
using ComboClone.Utils;
using ComboClone.ViewModel.SA.Commands;
using ComboClone.ViewModel.SA.Enum;
using ComboClone.ViewModel.SA.Model;
using ComboClone.ViewModel.SA.ViewSource;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace ComboClone.ViewModel.SA
{
    public class SubMenuViewModel :ViewModelBase
    {
        private ICollectionView sourceCollection;
        private ViewSouce viewSouce = new ViewSouce();
        public event Action ViewModal;

        public ICollectionView SourceCollection
        {
            get { return sourceCollection; }
            set
            {
                sourceCollection = value;
                OpPropertyChanged("SourceCollection");
            }
        }

        public SubMenuViewModel()
        {
            SourceCollection = viewSouce.meas.View;

            SubMenuBT = new SubMenuCommand(this);
            
        }

        public ICommand SubMenuBT { get; set; }
       
        public void Invoke()
        {
            ViewModal.Invoke();
        }

        public void SwitchViews(object parameter)
        {
            switch (parameter)
            {
                case "Meas":
                    SourceCollection = viewSouce.meas.View;
                    break;
                case "Freq":
                    SourceCollection = viewSouce.freq.View;
                    break;
                case "Span":
                    SourceCollection = viewSouce.span.View;
                    break;
                case "Amp":
                    SourceCollection = viewSouce.amp.View;
                    break;
                case "BW":
                    SourceCollection = viewSouce.bw.View;
                    break;
                case "Marker":
                    SourceCollection = viewSouce.marker1.View;
                    break;
                case "Peak":
                    SourceCollection = viewSouce.peak.View;
                    break;
                case "Trace":
                    SourceCollection = viewSouce.trace.View;
                    break;
                case "Sweep":
                    SourceCollection = viewSouce.sweep.View;
                    break;
                case "Standard":
                    SourceCollection = viewSouce.standard.View;
                    break;
                case "Setup":
                    SourceCollection = viewSouce.setup.View;
                    break;
                case "Sys":
                    SourceCollection = viewSouce.sys.View;
                    break;

            }

        }




        






    }
}
