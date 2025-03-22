using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Persons")]  // Đặt tên bảng trong CSDL
    public class Person
    {
        [Key]  // Đánh dấu PersonId là khóa chính
        public string PersonId { get; set; }

        [Required]  // Thuộc tính bắt buộc nhập
        public string FullName { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
