using ComboClone.ViewModel.SA.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ComboClone.ViewModel.SA.ViewSource
{
    public class ViewSouce
    {
        public ViewSouce(){
            meas = new CollectionViewSource { Source = Meas };
            freq = new CollectionViewSource { Source = Freq };
            span = new CollectionViewSource { Source = Span };
            amp = new CollectionViewSource { Source = Amp };
            bw = new CollectionViewSource { Source = BW };
            marker1 = new CollectionViewSource { Source = MarkerMore1 };
            marker2= new CollectionViewSource { Source = MarkerMore2 };
            peak= new CollectionViewSource { Source = Peak };
            trace = new CollectionViewSource { Source = Trace };
            sweep = new CollectionViewSource { Source = Sweep };
            standard = new CollectionViewSource { Source = Standard };
            setup = new CollectionViewSource { Source = Setup };
            sys = new CollectionViewSource { Source = Sys };


        }
        public CollectionViewSource meas;
        public CollectionViewSource freq;
        public CollectionViewSource span;
        public CollectionViewSource amp;
        public CollectionViewSource bw;
        public CollectionViewSource marker1;
        public CollectionViewSource marker2;
        public CollectionViewSource peak;
        public CollectionViewSource trace;
        public CollectionViewSource sweep;
        public CollectionViewSource standard;
        public CollectionViewSource setup;
        public CollectionViewSource sys;

        public ObservableCollection<SubMenuModel> Meas = new ObservableCollection<SubMenuModel>
            {
                new SubMenuModel{SubMenuName="Swept SA" },
                new SubMenuModel{SubMenuName="Channel Power"},
                new SubMenuModel{SubMenuName="Occupied BW"},
                new SubMenuModel{SubMenuName="ACLR"},
                new SubMenuModel{SubMenuName="SEM"},
                new SubMenuModel{SubMenuName="Spurious Emission"},
                new SubMenuModel{SubMenuName="Transmit On/Off"},
            };
        public ObservableCollection<SubMenuModel> Freq = new ObservableCollection<SubMenuModel>
            {
                new SubMenuModel{SubMenuName="Center Freq" },
                new SubMenuModel{SubMenuName="Start Freq"},
                new SubMenuModel{SubMenuName="Stop Freq"},

             };
        public ObservableCollection<SubMenuModel> Span = new ObservableCollection<SubMenuModel>
            {
                new SubMenuModel{SubMenuName="Span" },
                new SubMenuModel{SubMenuName="Full Span"},
                new SubMenuModel{SubMenuName="Zero Span"},
                new SubMenuModel{SubMenuName="Last Span"},

             };
        public ObservableCollection<SubMenuModel> Amp = new ObservableCollection<SubMenuModel>
            {
                new SubMenuModel{SubMenuName="Ref.Level" },
                new SubMenuModel{SubMenuName="Attenuator"},
                new SubMenuModel{SubMenuName="Preamp"},
                new SubMenuModel{SubMenuName="Scale/Div"},
                new SubMenuModel{SubMenuName="Offset"},

             };
        public ObservableCollection<SubMenuModel> BW = new ObservableCollection<SubMenuModel>
            {
                new SubMenuModel{SubMenuName="RBW" },
                new SubMenuModel{SubMenuName="VBW"},

             };
        public ObservableCollection<SubMenuModel> MarkerMore1 = new ObservableCollection<SubMenuModel>
            {
                new SubMenuModel{SubMenuName="Select Maker" },
                new SubMenuModel{SubMenuName="Normal"},
                new SubMenuModel{SubMenuName="Delta"},
                new SubMenuModel{SubMenuName="Fixed"},
                new SubMenuModel{SubMenuName="Off"},
                new SubMenuModel{SubMenuName="More"},

             };
        public ObservableCollection<SubMenuModel> MarkerMore2 = new ObservableCollection<SubMenuModel>
            {
                new SubMenuModel{SubMenuName="Frequency" },
                new SubMenuModel{SubMenuName="Relative To"},
                new SubMenuModel{SubMenuName="Marker Trace"},
                new SubMenuModel{SubMenuName="Marker Table"},
                new SubMenuModel{SubMenuName="All Marker Off"},
                new SubMenuModel{SubMenuName="More"},
             };
        public ObservableCollection<SubMenuModel> Peak = new ObservableCollection<SubMenuModel>
            {
                new SubMenuModel{SubMenuName="Continuous" },
               
             };
        public ObservableCollection<SubMenuModel> Trace = new ObservableCollection<SubMenuModel>
            {
                new SubMenuModel{SubMenuName="Select Trace" },
                new SubMenuModel{SubMenuName="Trace Mode"},
                new SubMenuModel{SubMenuName="Trace Type"},
                new SubMenuModel{SubMenuName="Detector"},
             };
        public ObservableCollection<SubMenuModel> Sweep = new ObservableCollection<SubMenuModel>
            {
                new SubMenuModel{SubMenuName="Sweep Time" },
                new SubMenuModel{SubMenuName="Gate"},
             };
        public ObservableCollection<SubMenuModel> Standard = new ObservableCollection<SubMenuModel>
            {
                new SubMenuModel{SubMenuName="None" },
                new SubMenuModel{SubMenuName="WCDMA"},
                new SubMenuModel{SubMenuName="LTE"},
                new SubMenuModel{SubMenuName="5G NR"},
             };
        public ObservableCollection<SubMenuModel> Setup = new ObservableCollection<SubMenuModel>
            {
                new SubMenuModel{SubMenuName="Avg/Hold Num" },
             };
        public ObservableCollection<SubMenuModel> Sys = new ObservableCollection<SubMenuModel>
            {
                new SubMenuModel{SubMenuName="Version" },
                new SubMenuModel{SubMenuName="FW Update" },
                new SubMenuModel{SubMenuName="Clock Source" },
                new SubMenuModel{SubMenuName="Holdover Opt" },
                new SubMenuModel{SubMenuName="Connect LNA" },
             };

    }
}
