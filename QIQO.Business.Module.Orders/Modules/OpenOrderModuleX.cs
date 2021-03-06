﻿using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using QIQO.Business.Client.Core.Infrastructure;
using QIQO.Business.Module.Orders.Views;

namespace QIQO.Business.Module.Orders.Modules
{
    public class OpenOrderModuleX : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.DashboardRegion1, typeof(OpenOrderViewX));
        }
        public void RegisterTypes(IContainerRegistry containerRegistry) { }
    }
}
