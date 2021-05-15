using System;
using System.Collections.Generic;

#nullable disable

namespace MVD_BD.Models
{
    public partial class Сотрудники
    {
        public Сотрудники()
        {
            Преступникиs = new HashSet<Преступники>();
        }

        public long Фио { get; set; }
        public long Возраст { get; set; }
        public long Адрес { get; set; }
        public long Телефон { get; set; }
        public long ПаспортныеДанные { get; set; }
        public long Пол { get; set; }
        public long КодСотрудника { get; set; }
        public long КодДолжности { get; set; }
        public long КодЗвания { get; set; }

        public virtual Должности КодДолжностиNavigation { get; set; }
        public virtual Звания КодЗванияNavigation { get; set; }
        public virtual ICollection<Преступники> Преступникиs { get; set; }
    }
}
