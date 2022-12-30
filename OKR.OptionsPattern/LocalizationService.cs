using Microsoft.Extensions.Options;

namespace OKR.OptionsPattern
{
    public class LocalizationService : ILocalizationService
    {
        public string Language { get; private set; }
        public LocalizationService(IOptions<LocalizationOptions> options)
        {
            Language = options.Value.Language;
        }

        //or

        //public LocalizationService(IConfiguration configuration)
        //{
        //    Language = configuration.GetSection("LocalizationOptions:Language").Value;
        //}
    }
}
