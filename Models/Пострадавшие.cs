using System;
using System.Collections.Generic;

#nullable disable

namespace MVD_BD.Models
{
    public partial class Пострадавшие
    {
        public long КодПострадавшего { get; set; }
        public long Фио { get; set; }
        public long ДатаРождения { get; set; }
        public long Пол { get; set; }
        public long Адес { get; set; }
    }
}
