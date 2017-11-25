﻿namespace Fima.Web.Areas.Administration.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using AutoMapper;
    using Data.DbModels;
    using Infrastructure.Mapping;

    public class FimaUsersViewModel : IMapTo<FimaUsers>, IMapFrom<FimaUsers>, IHaveCustomMappings
    {
        [Display(Name = "Номер")]
        public int Id { get; set; }

        [Display(Name="Потребител")]
        [StringLength(256, ErrorMessage = "Потребителското име трябва да е поне {2} символа!", MinimumLength = 3)]
        public string UserName { get; set; }

        [Display(Name = "Парола")]
        public string strEmpPassword { get; set; }

        [Display(Name = "Достъп")]
        public string strAccess { get; set; }

        [Display(Name = "Име")]
        public string strName { get; set; }

        [Display(Name = "Град")]
        public string strTown { get; set; }

        [Display(Name = "Индекс")]
        public string strIndex { get; set; }

        [Display(Name = "Позиция")]
        public string EmpFunction { get; set; }

        [Display(Name = "Адрес")]
        public string emptown { get; set; }

        [Display(Name = "Е-мейл")]
        [EmailAddress(ErrorMessage = "Попълнете валиден е-мейл адрес!")]
        public string Email { get; set; }

        [Display(Name = "Телефон")]
        [Phone (ErrorMessage = "Попълнете валиден телефонен номер!")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Опити")]
        public int? AccessFailedCount { get; set; }

        [Display(Name = "Роли")]
        public IEnumerable<string> FimaRoles { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<FimaUsers, FimaUsersViewModel>()
                .ForMember(u => u.FimaRoles, opt => opt.MapFrom(x => x.FimaRoles.Select(y => y.Name).ToList()));
        }
    }
}