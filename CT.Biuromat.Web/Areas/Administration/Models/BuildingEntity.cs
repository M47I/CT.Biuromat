using System;

namespace CT.Biuromat.Web.Areas.Administration.Models
{
    public class BuildingEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}