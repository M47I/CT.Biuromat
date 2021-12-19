using System.Collections.Generic;
using CT.Biuromat.Web.Areas.Administration.Models;
using CT.Biuromat.Web.Areas.Administration.ViewModels;

namespace CT.Biuromat.Web.Areas.Administration.Services
{
    public interface IBuildingsService
    {
        // vm
        BuildingsIndexVm PrepareVmForIndex();
        BuildingsDetailsVm PrepareVmForDetails(int id);
        BuildingsEditVm PrepareVmForEdit(int id);
        
        // baza danych
        ICollection<BuildingEntity> GetAll();
        BuildingEntity GetOne(int id);
        
        // co zwraca? nazwa? (parametry?)
        void AddToDatabase(BuildingsCreateVm model);
        void UpdateBuilding(BuildingsEditVm model);
        void DeleteBuilding(int id);
        void HardDeleteBuilding(int id);
    }
}