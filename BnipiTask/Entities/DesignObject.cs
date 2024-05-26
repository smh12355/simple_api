namespace BnipiTask.Models
{
    public class DesignObject
    {
        public int Id { get; set; }
        // navigation to Project
        public int ProjectId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        // navigation to Project
        public Project Project { get; set; }
        // navigation to DocSet
        public ICollection<DocSet> DocSets { get; set; }
    }
}
