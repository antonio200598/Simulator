using System.ComponentModel.DataAnnotations;

namespace Simulator.Platform.Entity
{
    public enum UserType
    {
        [Display(Name = "Aluno")]
        Student = 1,
        [Display(Name = "Professor")]
        Teacher = 2
    }
}
