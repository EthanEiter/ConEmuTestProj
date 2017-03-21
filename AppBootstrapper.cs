using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using Caliburn.Micro;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Microsoft.Practices.ServiceLocation;

namespace ConEmuTestProj
{
    public class AppBootstrapper : BootstrapperBase
    {
        private IWindsorContainer _container;

        public AppBootstrapper()
        {
#if DEBUG
            // don't care about invalid SSL certs in debug
            ServicePointManager.ServerCertificateValidationCallback +=
                (s, cert, chain, sslPolicyErrors) => true;
#endif
            //ConfigurationManager.AppSettings["Stackify.Environment"] = Environment.MachineName;
            Initialize();
        }

        protected override void Configure()
        {
            _container = new WindsorContainer();
            _container.Install(FromAssembly.This());
            ServiceLocator.SetLocatorProvider(() => new WindsorServiceLocator(_container));
        }

        protected override object GetInstance(Type serviceType, string key)
        {
            var instance = key == null ? _container.Resolve(serviceType) : _container.Resolve(key, serviceType);

            if (instance != null)
            {
                return instance;
            }

            throw new InvalidOperationException("Could not locate any instances.");
        }

        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return (object[])_container.ResolveAll(serviceType);
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {

            // Initialize ThemeManager
            //ThemeManager.BeginUpdate();

            //try
            //{
            //    ThemesOfficeThemeCatalogRegistrar.Register();
            //    ThemesMetroThemeCatalogRegistrar.Register();
            //    ThemeManager.AreNativeThemesEnabled = true;
            //    var themeName = ThemeName.MetroLight.ToString();
            //    var themes = EnumerateThemes(themeName);
            //    themes.Iter(ThemeManager.RegisterThemeCatalog);
            //    ThemeManager.CurrentTheme = themeName;
            //}
            //finally
            //{
            //    ThemeManager.EndUpdate();
            //}

            DisplayRootViewFor<IShell>();
        }

        protected override void OnExit(object sender, EventArgs e)
        {
            //TODO fix ConEmu errors on close...

            _container?.Dispose();
            Environment.Exit(0);
        }
    }

    public class WindsorServiceLocator : ServiceLocatorImplBase
    {
        private readonly IWindsorContainer _container;

        public WindsorServiceLocator(IWindsorContainer container)
        {
            _container = container;
        }

        protected override object DoGetInstance(Type serviceType, string key)
        {
            return key != null ? _container.Resolve(key, serviceType) : _container.Resolve(serviceType);
        }

        protected override IEnumerable<object> DoGetAllInstances(Type serviceType)
        {
            return (IEnumerable<object>)_container.ResolveAll(serviceType);
        }
    }
}