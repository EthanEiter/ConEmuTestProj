using System;
using Caliburn.Micro;

namespace ConEmuTestProj
{
    public interface IViewModelFactory : IDisposable
    {
        TScreen CreateScreen<TScreen>() where TScreen : Screen;
    }
}
