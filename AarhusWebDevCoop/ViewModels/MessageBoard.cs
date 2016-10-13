using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AarhusWebDevCoop.ViewModels
{
    public class MessageBoard
    {
        [Required(ErrorMessage = "A name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A message is required")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}