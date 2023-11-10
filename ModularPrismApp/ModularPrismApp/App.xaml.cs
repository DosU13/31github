using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System.ComponentModel;
using System.Windows;

namespace ModularPrismApp;

public partial class App : PrismApplication
{
    protected override Window CreateShell()
    {
        return Container.Resolve<MainWindow>();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        // Register types here if needed
    }

    protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
        // Register your modules here
        moduleCatalog.AddModule<ModuleAModule.ModuleAModule>();
        moduleCatalog.AddModule<ModuleBModule.ModuleBModule>();
    }
}
