using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trumvn
{
    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        [Key]
        public virtual TPrimaryKey Id { get; set; }
    }
}
