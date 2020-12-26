﻿using AnimalRescue.Contracts.BusinessLogic.Interfaces.CRUD;
using AnimalRescue.Contracts.BusinessLogic.Models.Configurations;
using AnimalRescue.Contracts.BusinessLogic.Models.Configurations.Donations;
using AnimalRescue.Contracts.BusinessLogic.Models.Configurations.Info;

using System.Threading.Tasks;

namespace AnimalRescue.Contracts.BusinessLogic.Interfaces
{
    public interface IConfigurationService :
        IBlCreateAsync<AboutDto>,
        IBlCreateAsync<AboutFinancialReportsDto>,
        IBlCreateAsync<AboutRulesDto>,
        IBlCreateAsync<CmsConfigurationDto>,
        IBlCreateAsync<DonationConfigurationDto>,
        IBlCreateAsync<HomeDto>,
        IBlCreateAsync<HomePopupDto>,
        IBlCreateAsync<HelpPopupDto>,
        IBlCreateAsync<AdoptTopicDto>,
        IBlCreateAsync<HelpAdoptDto>,
        IBlCreateAsync<HowToHelpDto>,
        IBlCreateAsync<LanguagesConfigDto>,
        IBlCreateAsync<FinancialReportsInfoDto>
    {
        Task<AboutDto> GetAboutConfigurationAsync();
        Task<AboutFinancialReportsDto> GetAboutFinancialReportsConfigurationAsync();
        Task<AboutRulesDto> GetAboutRulesConfigurationAsync();
        Task<CmsConfigurationDto> GetCmsConfigurationAsync();
        Task<DonationConfigurationDto> GetDonationConfigurationAsync();
        Task<HomeDto> GetHomeConfigurationAsync();
        Task<HomePopupDto> GetHomePopupConfigurationAsync();
        Task<HelpPopupDto> GetHelpPopupConfigurationAsync();
        Task<AdoptTopicDto> GetAdoptTopicConfigurationAsync();
        Task<HelpAdoptDto> GetHelpAdoptConfigurationAsync();
        Task<HowToHelpDto> GetHowToHelpConfigurationAsync();
        Task<LanguagesConfigDto> GetLanguagesConfigurationAsync();
        Task<FinancialReportsInfoDto> GetFinancialReportsInfoConfigurationAsync();
    }
}
