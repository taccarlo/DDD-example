using Autofac;
using NimblePros.DotNetConf.Core.Interfaces;
using NimblePros.DotNetConf.Core.Services;

namespace NimblePros.DotNetConf.Core;

public class DefaultCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ToDoItemSearchService>()
            .As<IToDoItemSearchService>().InstancePerLifetimeScope();
    }
}
