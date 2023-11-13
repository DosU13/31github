using MuzU_Studio.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using SequenceList;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MuzU_Studio;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : PrismApplication
{
    protected override Window CreateShell() => Container.Resolve<MuzU_Studio.Views.MainWindow>();

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {

    }

    protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
        moduleCatalog.AddModule<SequenceListModule>();
    }
}
