using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NishilPort.Authorization;

namespace NishilPort
{
    [DependsOn(
        typeof(NishilPortCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NishilPortApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NishilPortAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NishilPortApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
