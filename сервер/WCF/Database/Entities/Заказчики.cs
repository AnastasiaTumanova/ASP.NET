using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Database.Entities
{
    public class Заказчики
    {
        [Key] public int Id_клиента { get; set; }

        [Column("Фамилия")]
        [Required]
        [StringLength(50)]
        public String Фамилия { get; set; }

        [Column("Имя")]
        [Required]
        [StringLength(50)]
        public String Имя { get; set; }

        [Column("Отчество")]
        [Required]
        [StringLength(50)]
        public String Отчество { get; set; }

        [Column("Адрес")]
        [Required]
        [StringLength(70)]
        public String Адрес { get; set; }

        [Column("Телефон")]
        [Required]
        [StringLength(20)]
        public String Телефон { get; set; }

        public virtual ICollection<Заказы> Заказы { get; set;}
    }
}
