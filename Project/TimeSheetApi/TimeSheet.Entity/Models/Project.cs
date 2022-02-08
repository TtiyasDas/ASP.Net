﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TimeSheet.Entity.Models
{
    public class Project
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }
    }
}
