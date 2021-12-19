using System.Collections.Generic;
using CT.Biuromat.Web.Areas.Administration.Models;
using CT.Biuromat.Web.Areas.Administration.ViewModels;
using CT.Biuromat.Web.Data;

namespace CT.Biuromat.Web.Areas.Administration.Services.Impl
{
    public class RoomsService : IRoomsService
    {
        private readonly ApplicationDbContext _dbContext;
        
        public RoomsService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public RoomsIndexVm PrepareVmForIndex()
        {
            throw new System.NotImplementedException();
        }

        public RoomsDetailsVm PrepareVmForDetails(int id)
        {
            throw new System.NotImplementedException();
        }

        public RoomsEditVm PrepareVmForEdit(int id)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<RoomEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public RoomEntity GetOne(int id)
        {
            throw new System.NotImplementedException();
        }

        public void AddToDatabase(RoomsCreateVm model)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateRoom(RoomsEditVm model)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteRoom(int id)
        {
            throw new System.NotImplementedException();
        }

        public void HardDeleteRoom(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}