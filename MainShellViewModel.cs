using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace ConEmuTestProj
{
    [Export(typeof(IShell))]
    public class MainShellViewModel : Screen, IShell
    {

        public string Title => "CONEMUTESTPROJ";

        private bool _isConsoleVisible = true;
        public bool IsConsoleVisible
        {
            get { return _isConsoleVisible; }
            set
            {
                _isConsoleVisible = value;
                NotifyOfPropertyChange(() => IsConsoleVisible);
            }
        }

        public MainShellViewModel(IViewModelFactory viewModelFactory)
        {
        }
    }
}