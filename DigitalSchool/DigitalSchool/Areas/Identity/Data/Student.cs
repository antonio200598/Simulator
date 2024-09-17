namespace DigitalSchool.Areas.Identity.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Class Class { get; set; }
    }
}
