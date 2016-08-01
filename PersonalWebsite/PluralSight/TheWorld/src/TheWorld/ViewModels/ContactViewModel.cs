﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.ViewModels
{

    /// <summary>
    /// The purpose of this class is to be able to communicate with the
    ///     contact page and retrieve the data.
    /// </summary>
    public class ContactViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(4096, MinimumLength = 10)]
        public string Message { get; set; }
        
    }
}
