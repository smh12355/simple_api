namespace BnipiTask.Models
{
    public class DocSet
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public MarkType MarkType { get; set; }
        // navigation to DesignObject
        public DesignObject DesignObject { get; set; }
    }
}
