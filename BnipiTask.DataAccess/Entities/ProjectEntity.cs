using BnipiTask.Core.Models;

namespace BnipiTask.DataAccess.Entities
{
    public class ProjectEntity
    {
        //public ProjectEntity()
        //{
        //    _designObjects = new List<DesignObjectEntity>();
        //}
        //public ICollection<DesignObjectEntity> DesignObjects
        //{
        //    get => _designObjects ?? (_designObjects = new List<DesignObjectEntity>());
        //    set => _designObjects = value;
        //}
        //private ICollection<DesignObjectEntity> _designObjects;
        public Guid Id { get; set; }
        public string Cipher { get; set; }
        public string Name { get; set; }
        public ICollection<DesignObjectEntity> DesignObjects { get; set; }

    }
}
