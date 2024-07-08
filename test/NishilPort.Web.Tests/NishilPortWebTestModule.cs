using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NishilPort.EntityFrameworkCore;
using NishilPort.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace NishilPort.Web.Tests
{
    [DependsOn(
        typeof(NishilPortWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class NishilPortWebTestModule : AbpModule
    {
        public NishilPortWebTestModule(NishilPortEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NishilPortWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(NishilPortWebMvcModule).Assembly);
        }
    }
}