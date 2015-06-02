using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SearchClaim.Models
{
    public class Book
    {
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Publisher { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset PublishDate { get; set; }
    }
}