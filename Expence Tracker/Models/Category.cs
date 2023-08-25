﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expence_Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "nvarchar(80)")]
        public string Type { get; set; } = "Expense";

        [NotMapped]
        public string? TitleWithIcon {
            get
            {
                return this.Icon + " "+ this.Title;
            } 
        }

    }
}
