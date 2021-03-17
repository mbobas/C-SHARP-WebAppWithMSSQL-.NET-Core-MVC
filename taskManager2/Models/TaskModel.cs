using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace taskManager2.Models
{
    [Table("Tasks")]
    public class TaskModel
    {
        [Key]
        public int TaskId { get; set; }
        [DisplayName("Nazwa")]
        [Required(ErrorMessage ="Pole nazwa jest wymagane")]
        [MaxLength(50)]
        public string Name{ get; set; }
        [DisplayName("Opis")]
        [MaxLength(2000)]
        public string  Description { get; set; }
        public bool Done { get; set; }
    }
}
