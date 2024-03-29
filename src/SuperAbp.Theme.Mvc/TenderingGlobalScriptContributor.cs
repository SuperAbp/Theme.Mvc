﻿using SuperAbp.AspNetCore.Mvc.UI.Packages.Bootbox;
using SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapFileInput;
using SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapTable;
using SuperAbp.AspNetCore.Mvc.UI.Packages.ZTree;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Modularity;

namespace SuperAbp.Theme.Mvc
{
    [DependsOn(typeof(BootstrapFileInputScriptContributor),
        typeof(BootstrapTableScriptContributor),
        typeof(ZTreeScriptContributor),
        typeof(BootboxScriptContributor))]
    public class TenderingGlobalScriptContributor : BundleContributor
    {
    }
}
