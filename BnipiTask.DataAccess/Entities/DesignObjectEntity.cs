using BnipiTask.Core.Models;

namespace BnipiTask.DataAccess.Entities
{
    public class DesignObjectEntity
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid ProjectId { get; set; }
        public ProjectEntity Project { get; set; }
        public ICollection<DocumentationSetEntity> DocumentSets { get; set; }
        //public DesignObjectEntity()
        //{
        //    DocumentSets = new List<DocumentationSetEntity>();
        //}
    }
}
