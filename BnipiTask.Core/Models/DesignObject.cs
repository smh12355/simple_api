using System.Text;

namespace BnipiTask.Core.Models
{
    public class DesignObject
    {
        public const int MAX_CODE_LENGTH = 20;
        public const int MAX_NAME_LENGTH = 50;

        private DesignObject(Guid id, string code, string name, Guid projectId)
        {
            Id = id;
            Code = code;
            Name = name;
            ProjectId = projectId;
            DocumentSets = new List<DocumentationSet>();
        }

        public static (DesignObject designObject, string Error) Create(Guid id, string code, string name, Guid projectId)
        {
            var error = new StringBuilder();
            if (string.IsNullOrEmpty(code) || code.Length > MAX_CODE_LENGTH)
            {
                error.AppendLine($"Code cannot be empty or longer than {MAX_CODE_LENGTH} symbols.");
            }
            if (string.IsNullOrEmpty(name) || name.Length > MAX_NAME_LENGTH)
            {
                error.AppendLine($"Name cannot be empty or longer than {MAX_NAME_LENGTH} symbols.");
            }
            var designObject = new DesignObject(id, code, name, projectId);
            return (designObject, error.ToString());
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public ICollection<DocumentationSet> DocumentSets { get; set; }
    }
}
