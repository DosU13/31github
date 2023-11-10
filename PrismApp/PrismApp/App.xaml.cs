using Example;
using Prism.DryIoc;
using Prism.Ioc;
using PrismApp.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace PrismApp;

public partial class App : PrismApplication
{
    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.Register<ICustomerStore, DbCustomerStore>();
        containerRegistry.Register<Services.ICustomerStore, Services.DbCustomerStore>();
    }

    protected override Window CreateShell()
    {
        var w = Container.Resolve<MainWindow>();
        return w;
    }
}
