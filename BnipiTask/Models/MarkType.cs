namespace BnipiTask.Models
{
    public enum MarkType
    {
        TX,
        AC,
        CM,
    }
    public static class MarkTypeExtensions
    {
        private static readonly Dictionary<MarkType, string> _descriptions = new Dictionary<MarkType, string>
        {
            { MarkType.TX, "Технология производства" },
            { MarkType.AC, "AC Description" },
            { MarkType.CM, "CM Description" }
        };

        public static string GetDescription(this MarkType markType)
        {
            return _descriptions[markType];
        }
    }
}
