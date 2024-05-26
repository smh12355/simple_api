using System.Text;

namespace BnipiTask.Core.Models
{
    public class DocumentationSet
    {
        private DocumentationSet(Guid id, int number, Guid designObjectId, Guid marktypeId)
        {
            Id = id;
            Number = number;
            DesignObjectId = designObjectId;
            MarkTypeId = marktypeId;
        }

        public static (DocumentationSet documentationSet, string Error) Create(Guid id, int number, Guid designObjectId, Guid marktypeId)
        {
            var error = new StringBuilder();
            if (number < 0)
            {
                error.AppendLine("Number must be a positive integer or zero.");
            }
            var documentationSet = new DocumentationSet(id, number, designObjectId, marktypeId);
            return (documentationSet, error.ToString());
        }

        public Guid Id { get; set; }
        public int Number { get; set; }
        public Guid DesignObjectId { get; set; }
        public DesignObject DesignObject { get; set; }
        public Guid MarkTypeId { get; set; }
        public MarkType MarkType { get; set; }
    }
}
