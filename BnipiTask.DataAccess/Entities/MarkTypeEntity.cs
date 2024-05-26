using BnipiTask.Core.Models;

namespace BnipiTask.DataAccess.Entities
{
    public class MarkTypeEntity
    {
        public Guid Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public ICollection<DocumentationSetEntity> DocumentationSets { get; set; }

        //public MarkTypeEntity()
        //{
        //    DocumentationSets = new List<DocumentationSetEntity>();
        //}
    }
}
