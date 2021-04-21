using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortpolioWeb.Models
{
    public class Board
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="제목을 입력하세요")]
        [DataType(DataType.Text)]
        [StringLength(250)]
        public string Subject { get; set; }
        public string Contents { get; set; }
        public DateTime RegDate { get; set; }
        public  int ReadCount { get; set; }
        public string Writer { get; set; }
        //[Required(ErrorMessage ="작성자를 입력하세요")]
        //[DataType(DataType.Text)]
        //[StringLength(25)]
    }
}
