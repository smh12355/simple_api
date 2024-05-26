using System.Text;

namespace BnipiTask.Core.Models
{
    public class MarkType
    {
        public const int MAX_SHORTNAME_LENGHT = 10;
        public const int MAX_FULLNAME_LENGHT = 50;
        private MarkType(Guid id, string shortName, string fullName)
        {
            Id = id;
            ShortName = shortName;
            FullName = fullName;
        }

        public static (MarkType markType, string Error) Create(Guid id, string shortName, string fullName)
        {
            var error = new StringBuilder();
            if (string.IsNullOrEmpty(shortName) || shortName.Length > MAX_SHORTNAME_LENGHT)
            {
                error.AppendLine($"Shortname can not be empty or longer then {MAX_SHORTNAME_LENGHT} symbols");
            }
            if (string.IsNullOrEmpty(fullName) || fullName.Length > MAX_FULLNAME_LENGHT)
            {
                error.AppendLine($"Shortname can not be empty or longer then {MAX_FULLNAME_LENGHT} symbols");
            }
            var markType = new MarkType(id, shortName, fullName);
            return (markType, error.ToString());
        }
        public Guid Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public ICollection<DocumentationSet> DocumentationSets { get; set; }
    }
}
