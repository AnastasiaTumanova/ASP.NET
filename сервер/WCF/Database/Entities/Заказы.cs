using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Database.Entities
{
    public class Заказы
    {
        [Key] public int Id_заказа { get; set; }


        [Column("id_заказчика")]
        public int id_заказчика { get; set; }

        [Column("Дата")]
        public DateTime Дата { get; set; }
        [IgnoreDataMember]
        public virtual Заказчики Заказчики { get; set; }
    }
}
