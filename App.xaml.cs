using System;
using System.Windows;

namespace ConEmuTestProj
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        static App()
        {
            AppDomain.CurrentDomain.UnhandledException += HandleException;
        }

        public App()
        {
            InitializeComponent();
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject;

            if (ex == null)
                MessageBox.Show("Something happened which should never happen", "Oh, God... what have you done????????");
            else
                MessageBox.Show($"This happened: \r\n{ex}", $"Exception type: {ex.GetType()}");
        }
    }
}
