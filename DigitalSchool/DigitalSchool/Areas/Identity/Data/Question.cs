namespace DigitalSchool.Areas.Identity.Data
{
    public class Question
    {
        public int Id { get; set; }
        public string Enunciated { get; set; }
        public string RightAnswer { get; set; }
        public List<string> Choices { get; set; }
    }
}
