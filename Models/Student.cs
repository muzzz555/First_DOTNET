using System.ComponentModel.DataAnnotations;

namespace First_Dotnet.Models
{
    public class Student
    {
		[Key]
        public int Id { get; set;}
		[Required(ErrorMessage ="กรุณาป้อนชื่อนักเรียน")]
        [System.ComponentModel.DisplayName("ชื่อนักเรียน")]
        public string Name { get; set;}
        [System.ComponentModel.DisplayName("คะแนนสอบ")]
        [Range(0, 100, ErrorMessage ="กรุณาป้อนคะแนนสอบนช่วง 0-100")]
        public int Score { get; set;}
    }
}