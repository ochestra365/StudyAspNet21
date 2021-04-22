using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortpolioWeb.Models
{
    public class Manages
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="카테고리는 필수입니다.")]
        [DataType(DataType.Text)]
        public string Subject { get; set; }
        public string Category { get; set; }
        [Required(ErrorMessage = "페이지 내용은 필수입니다.")]
        [DataType(DataType.Text)]
        public string Contents { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime RegDate { get; set; }
    }
}
