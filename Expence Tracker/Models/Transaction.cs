using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Expence_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //CategoryID
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
