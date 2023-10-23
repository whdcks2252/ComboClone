using ComboClone.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComboClone.ViewModel.SA.Commands
{
    public class SubMenuCommand : CommandBase
    {
        private readonly SubMenuViewModel subMenuViewModel;

        public SubMenuCommand(SubMenuViewModel subMenuViewModel) {
            this.subMenuViewModel = subMenuViewModel;
        }

        void test()
        {
            subMenuViewModel.Invoke();

        }

        public override bool CanExecute(object parameter)
        {

            return true;
        }

        public override void Execute(object parameter)
        {
            test();
        }
    }
}
