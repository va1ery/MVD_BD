using System;
using System.Collections.Generic;

#nullable disable

namespace MVD_BD.Models
{
    public partial class ВидыПреступлений
    {
        public ВидыПреступлений()
        {
            Преступникиs = new HashSet<Преступники>();
        }

        public long КодВидаПреступления { get; set; }
        public long Наименование { get; set; }
        public long Статья { get; set; }
        public long Наказание { get; set; }
        public long Срок { get; set; }

        public virtual ICollection<Преступники> Преступникиs { get; set; }
    }
}
