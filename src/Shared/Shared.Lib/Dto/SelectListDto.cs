namespace Shared.Lib.Dto
{
    public class SelectListDto
    {
        public long Value { get; set; }
        public string Text { get; set; }
        public bool Selected { get; set; }
    }

    public class SelectListItemtDto
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public string Colour { get; set; }
        public bool Selected { get; set; }
    }
}
