using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboClone.ViewModel.SA.Enum
{
    public enum Menu
    {
        [Description("Freq")]
        Freq,
        [Description("Span")]
        Span,
        [Description("Amp")]
        Amp,
        [Description("BW")]
        BW,
        [Description("Marker")]
        Marker,
        [Description("Peak")]
        Peak,
        [Description("Trace")]
        Trace,
        [Description("Sweep")]
        Sweep,
        [Description("Standard")]
        Standard,
        [Description("Setup")]
        Setup,
        [Description("Sys")]
        Sys,

    }
}
