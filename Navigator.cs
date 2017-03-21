using Caliburn.Micro;

namespace ConEmuTestProj
{
    internal class Navigator
    {
        private readonly IEventAggregator _eventAggregator;

        public Navigator(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void NavigateTo(Screens screen)
        {
            _eventAggregator.PublishOnUIThread(new Navigation(screen));
        }
    }
}