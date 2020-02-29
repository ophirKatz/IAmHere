using Microsoft.Extensions.Configuration;

namespace IAmHere.Blazor.Helpers
{
    public static class ConfigurationExtensions
    {
        public static TConfig GetFromSection<TConfig>(this IConfiguration configuration, string sectionName)
        {
            return configuration.GetSection(sectionName).Get<TConfig>();
        }

        public static TConfig GetFromSection<TConfig>(this IConfiguration configuration)
        {
            var sectionName = typeof(TConfig).Name;
            return configuration.GetSection(sectionName).Get<TConfig>();
        }
    }
}