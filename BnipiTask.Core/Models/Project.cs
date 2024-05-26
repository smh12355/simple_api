using System.Text;

namespace BnipiTask.Core.Models
{
    public class Project
    {
        public const int MAX_CIPHER_LENGHT = 20;
        public const int MAX_NAME_LENGHT = 50;
        //public const int MAX_STRINGBUILDER_CAPACITY = 100;
        private Project(Guid id, string cipher, string name)
        {
            Id = id;
            Cipher = cipher;
            Name = name;
            DesignObjects = new List<DesignObject>();
        }
        
        public static (Project project, string Error) Create(Guid id, string cipher, string name)
        {
            var error = new StringBuilder();
            if (string.IsNullOrEmpty(cipher) || cipher.Length > MAX_CIPHER_LENGHT)
            {
                error.AppendLine($"Cipher can not be empty or longer then {MAX_CIPHER_LENGHT} symbols");
            }
            if (string.IsNullOrEmpty(name) || cipher.Length > MAX_NAME_LENGHT)
            {
                error.AppendLine($"Name can not be empty or longer then {MAX_NAME_LENGHT} symbols");
            }
            var project = new Project(id, cipher, name);
            return (project, error.ToString());
        }

        public Guid Id { get; set; }
        public string Cipher { get; set; }  
        public string Name { get; set; }  
        public ICollection<DesignObject> DesignObjects { get; set; }
    }
}
