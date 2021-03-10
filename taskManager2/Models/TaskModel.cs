using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace taskManager2.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        [DisplayName("Nazwa")]
        public string Name{ get; set; }
        [DisplayName("Opis")]
        public string  Description { get; set; }
        public bool Done { get; set; }
    }
}
