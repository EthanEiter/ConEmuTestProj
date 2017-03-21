using System.Linq;
using Caliburn.Micro;
using Castle.Core;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.ModelBuilder.Inspectors;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace ConEmuTestProj
{
    public sealed class MainInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var kernel = container.Kernel;
            kernel.Resolver.AddSubResolver(new CollectionResolver(kernel));
            container.AddFacility<TypedFactoryFacility>();

            // only inject ctors, not properties
            var propInjector = kernel.ComponentModelBuilder
                .Contributors
                .OfType<PropertiesDependenciesModelInspector>()
                .Single();
            kernel.ComponentModelBuilder.RemoveContributor(propInjector);

            container.Register(
                Component.For<ILazyComponentLoader>().ImplementedBy<LazyOfTComponentLoader>(),
                Component.For<IWindowManager>().Instance(new WindowManager()),
                Component.For<Navigator>(),
                Component.For<IEventAggregator>().ImplementedBy<EventAggregator>().LifeStyle.Is(LifestyleType.Singleton),
                Component.For<IShell>().ImplementedBy<MainShellViewModel>().LifeStyle.Is(LifestyleType.Singleton),
                Component.For<IViewModelFactory>().AsFactory(),
                Classes.FromAssembly(GetType().Assembly)
                    .BasedOn<Screen>()
                    .WithServiceSelf()
                    .LifestyleTransient()
                    .AllowMultipleMatches()
            );
        }
    }
}
