using System;
using System.Collections.Generic;

#nullable disable

namespace MVD_BD.Models
{
    public partial class Преступники
    {
        public long НомерДела { get; set; }
        public long Фио { get; set; }
        public long ДатаРождения { get; set; }
        public long Пол { get; set; }
        public long Адрес { get; set; }
        public long Состояние { get; set; }
        public long КодВидаПреступления { get; set; }
        public long КодПострадавшего { get; set; }
        public long КодСотрудника { get; set; }

        public virtual ВидыПреступлений КодВидаПреступленияNavigation { get; set; }
        public virtual Сотрудники КодСотрудникаNavigation { get; set; }
    }
}
