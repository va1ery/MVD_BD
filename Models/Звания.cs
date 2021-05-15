using System;
using System.Collections.Generic;

#nullable disable

namespace MVD_BD.Models
{
    public partial class Звания
    {
        public long КодЗвания { get; set; }
        public long Наименование { get; set; }
        public long Надбавка { get; set; }
        public long Обязанности { get; set; }
        public long Требования { get; set; }

        public virtual Сотрудники Сотрудники { get; set; }
    }
}
