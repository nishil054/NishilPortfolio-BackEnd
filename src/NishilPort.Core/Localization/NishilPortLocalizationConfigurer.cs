using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace NishilPort.Localization
{
    public static class NishilPortLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(NishilPortConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(NishilPortLocalizationConfigurer).GetAssembly(),
                        "NishilPort.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
