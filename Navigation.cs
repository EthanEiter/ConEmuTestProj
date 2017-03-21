namespace ConEmuTestProj
{
    internal class Navigation
    {
        public Screens Screen { get; private set; }

        public Navigation(Screens screen)
        {
            Screen = screen;
        }
    }
}