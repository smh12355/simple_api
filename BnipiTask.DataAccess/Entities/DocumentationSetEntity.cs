using BnipiTask.Core.Models;

namespace BnipiTask.DataAccess.Entities
{
    public class DocumentationSetEntity
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public Guid DesignObjectId { get; set; }
        public DesignObjectEntity DesignObject { get; set; }
        public Guid MarkTypeId { get; set; }
        public MarkTypeEntity MarkType { get; set; }
    }
}
