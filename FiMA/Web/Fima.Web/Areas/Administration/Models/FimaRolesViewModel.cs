namespace Fima.Web.Areas.Administration.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Data.DbModels;
    using Infrastructure.Mapping;

    public class FimaRolesViewModel : IMapTo<FimaRoles>, IMapFrom<FimaRoles>
    {
        [Display(Name = "Номер")]
        public int Id { get; set; }

        [Display(Name = "Роля")]
        public string Name { get; set; }

        [Display(Name = "Потребители")]
        public ICollection<FimaUsers> FimaUsers { get; set; }
    }
}
