using System;
using System.Collections.Generic;

#nullable disable

namespace MVD_BD.Models
{
    public partial class Должности
    {
        public long КодДолжности { get; set; }
        public long НаименованиеДолжности { get; set; }
        public long Оклад { get; set; }
        public long Обязанности { get; set; }
        public long Требования { get; set; }

        public virtual Сотрудники Сотрудники { get; set; }
    }
}
