namespace Fima.Web.Areas.FrontOffice.Models.Client
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using Common;
    using Data.DbModels;
    using Infrastructure.Mapping;

    public class ClientRegisterViewModel : IMapTo<INVESTORS_FUNDS>, IMapFrom<INVESTORS_FUNDS>, IHaveCustomMappings
    {
        [Display(Name = "номер")]
        public int CLIENTID { get; set; }

        public string CLIENTID_STRING { get; set; }

        [Required]
        [Display(Name = "ЕГН / Булстат")]
        public string PERSONALID_BULSTAT { get; set; }

        [Display(Name = "служител / пълномощник")]
        public string CONTRACT_TYPE { get; set; }

        [Display(Name = "тип лице")]
        public string TYPE_PERSON { get; set; }

        [Display(Name = "тип организация")]
        public string TYPE_ORGANIZATION { get; set; }

        [Display(Name = "собствено име")]
        public string FIRSTNAME { get; set; }

        [Display(Name = "презиме")]
        public string SECONDNAME { get; set; }

        [Display(Name = "фамилия")]
        public string LASTNAME { get; set; }

        [Display(Name = "пълно име")]
        public string FULL_NAME { get; set; }

        [Display(Name = "наименование")]
        public string FirmName { get; set; } // not mapped

        [Display(Name = "номер на Л.К. / паспорт")]
        public string PERSONAL_ID { get; set; }

        [Display(Name = "Л.K. издадена на")]
        public string PERSONAL_ID_DATE { get; set; }

        [Display(Name = "Л.К. издадена от")]
        public string PERSONAL_ID_ISSUED_BY { get; set; }

        [Display(Name = "държава")]
        public string COUNTRY_ADDRESS_ID { get; set; }

        [Display(Name = "град")]
        public string TOWN_ADDRESS_ID { get; set; }

        [Display(Name = "адрес")]
        public string ADDRESS_ID { get; set; }

        [EmailAddress]
        [Display(Name = "е-мейл адрес")]
        public string E_MAIL { get; set; }

        [Phone]
        [Display(Name = "телефон")]
        public string TEL_FIXED { get; set; }

        [Phone]
        [Display(Name = "мобилен телефон")]
        public string TEL_MOBILE { get; set; }

        public string AUTHORISED_TYPE { get; set; }

        [Display(Name = "пълномощник 1")]
        public string AUTHORISED_NAME { get; set; }

        public string AUTHORISED_DOC { get; set; }

        public string AUTHORISED_DATE { get; set; }

        public string AUTHORISED_TYPE2 { get; set; }

        [Display(Name = "пълномощник 2")]
        public string AUTHORISED_NAME2 { get; set; }

        public string AUTHORISED_DATE2 { get; set; }

        [Display(Name = "регистрация по ДДС")]
        public string DDS_REGISTERED { get; set; }

        [Display(Name = "данъчен номер")]
        public string ID_NUMBER_TAX_ID { get; set; }

        public string EMPLOYEE_AUTHORISED { get; set; }

        [Display(Name = "дата на раждане")]
        public string CLIENT_BIRTHDATE { get; set; }

        [RegularExpression(GlobalConstants.IbanRegex, ErrorMessage = "IBAN номерът не е валиден")]
        [Display(Name = "IBAN")]
        public string IBAN1 { get; set; }

        [RegularExpression(GlobalConstants.BicRegex, ErrorMessage = "BIC кодът не е валиден")]
        [Display(Name = "BIC код")]
        public string BIC1 { get; set; }

        [Display(Name = "име на банка")]
        public string BANK1 { get; set; }

        [RegularExpression(GlobalConstants.IbanRegex, ErrorMessage = "IBAN номерът не е валиден")]
        [Display(Name = "IBAN")]
        public string IBAN2 { get; set; }

        [RegularExpression(GlobalConstants.BicRegex, ErrorMessage = "BIC кодът не е валиден")]
        [Display(Name = "BIC код")]
        public string BIC2 { get; set; }

        [Display(Name = "име на банка")]
        public string BANK2 { get; set; }

        [RegularExpression(GlobalConstants.IbanRegex, ErrorMessage = "IBAN номерът не е валиден")]
        [Display(Name = "IBAN")]
        public string IBAN3 { get; set; }

        [RegularExpression(GlobalConstants.BicRegex, ErrorMessage = "BIC кодът не е валиден")]
        [Display(Name = "BIC код")]
        public string BIC3 { get; set; }

        [Display(Name = "име на банка")]
        public string BANK3 { get; set; }

        public string AUTH_NOTARY { get; set; }

        public string AUTH_NOTARY2 { get; set; }

        public string AUTHORISED_DOC2 { get; set; }

        public string CL_STATUS { get; set; }

        public int? CD_GLOBID { get; set; }

        public int? CREATED_BY { get; set; }

        public string CREATED_WHEN { get; set; }

        public string CD_REG { get; set; }

        public string user_modified { get; set; }

        public string user_modified_time { get; set; }

        public string CD_BIC { get; set; }

        [Display(Name = "община")]
        public string MUNICIPALITY { get; set; }

        [Display(Name = "квартал")]
        public string RESIDENCE { get; set; }

        [Display(Name = "улица")]
        public string STREET { get; set; }

        [Display(Name = "№")]
        public int STRNUM { get; set; }

        [Display(Name = "ет.")]
        public int FLOOR1 { get; set; }

        [Display(Name = "ап.")]
        public int FLAT { get; set; }

        [Display(Name = "д-ва на раждане")]
        public string COUNTRY1 { get; set; }

        [Display(Name = "град на раждане")]
        public string TOWN1 { get; set; }

        [Display(Name = "д-ва по местоживеене")]
        public string COUNTRY2 { get; set; }

        [Display(Name = "град по местоживеене")]
        public string TOWN2 { get; set; }

        public string DCITIZENS { get; set; }

        public string IBAN_CD_AI { get; set; }

        public string IBAN_CD_AEE { get; set; }

        public string IBAN_CD_AEEO { get; set; }

        public string IBAN_CD_AGT { get; set; }

        public string IBAN_CD_ACF { get; set; }

        public IEnumerable<string> Countries { get; set; }

        public IEnumerable<string> Cities { get; set; }

        public IEnumerable<string> Municipalities { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<INVESTORS_FUNDS, ClientRegisterViewModel>()
                .ForMember(u => u.CONTRACT_TYPE, opt => opt.MapFrom(x => GlobalConstants.ContractType[x.CONTRACT_TYPE]));

            configuration.CreateMap<ClientRegisterViewModel, INVESTORS_FUNDS>()
                .ForMember(u => u.CONTRACT_TYPE, opt => opt.MapFrom(x => Array.IndexOf(GlobalConstants.ContractType, x.CONTRACT_TYPE)));
        }
    }
}
