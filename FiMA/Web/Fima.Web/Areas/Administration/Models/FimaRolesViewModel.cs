namespace Fima.Web.Areas.Administration.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using AutoMapper;
    using Data.DbModels;
    using Infrastructure.Mapping;

    public class FimaRolesViewModel : IMapTo<FimaRoles>, IMapFrom<FimaRoles>, IHaveCustomMappings
    {
        [Display(Name = "Номер")]
        public int Id { get; set; }

        [Display(Name = "Роля")]
        public string Name { get; set; }

        [Display(Name = "Потребители")]
        public IEnumerable<string> FimaUsers { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<FimaRoles, FimaRolesViewModel>()
                .ForMember(u => u.FimaUsers, opt => opt.MapFrom(x => x.FimaUsers.Select(y => y.UserName).ToList()));
        }
    }
}
