﻿using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using QIQO.Business.Client.Core.Infrastructure;
using QIQO.Business.Module.General.Views;

namespace QIQO.Business.Module.General.Modules
{
    public class TitleBarModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.TitleBarRegion, typeof(TitleBarView));
        }
        public void RegisterTypes(IContainerRegistry containerRegistry) { }
    }
}
