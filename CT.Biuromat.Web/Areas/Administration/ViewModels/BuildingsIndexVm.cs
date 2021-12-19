using System.Collections.Generic;
using CT.Biuromat.Web.Areas.Administration.Models;

namespace CT.Biuromat.Web.Areas.Administration.ViewModels
{
    public class BuildingsIndexVm
    {
        public ICollection<BuildingEntity> Buildings { get; set; }
    }
}