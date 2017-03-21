using System.IO;
using System.Reflection;
using System.Threading;
using System.Xml;
using ConEmu.WinForms;

namespace ConEmuTestProj
{
    /// <summary>
    /// Interaction logic for MainShellView.xaml
    /// </summary>
    public partial class MainShellView
    {
        public MainShellView()
        {
            InitializeComponent();
            InitializeConEmuRunner();
        }

        private void InitializeConEmuRunner()
        {
            ConEmuConsole.RunningSession?.CloseConsoleEmulator();

            var config = new XmlDocument();
            config.Load(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), @"Style\ConEmu.xml"));

            // normally I'd import a module here...
            var startupCommand = $"powershell.exe -NoProfile -NoExit –ExecutionPolicy Bypass";

            var startInfo = new ConEmuStartInfo
            {
                IsEchoingConsoleCommandLine = true,
                IsElevated = true,
                ConsoleProcessCommandLine = startupCommand,
                BaseConfiguration = config,
                WhenConsoleProcessExits = WhenConsoleProcessExits.KeepConsoleEmulator
            };

            var count = 0;
            // trying to deal wtih the CloseConsole being slow?
            while (ConEmuConsole.RunningSession != null && count < 100)
            {
                ConEmuConsole.RunningSession?.CloseConsoleEmulator();
                Thread.Sleep(10);
                count++;
            }
            ConEmuConsole.Start(startInfo);
        }
    }
}
