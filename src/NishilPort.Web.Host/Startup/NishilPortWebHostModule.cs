using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NishilPort.Configuration;

namespace NishilPort.Web.Host.Startup
{
    [DependsOn(
       typeof(NishilPortWebCoreModule))]
    public class NishilPortWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public NishilPortWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NishilPortWebHostModule).GetAssembly());
        }
    }
}
