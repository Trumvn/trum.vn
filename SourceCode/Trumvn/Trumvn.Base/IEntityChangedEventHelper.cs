using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trumvn
{
    public interface IEntityChangedEventHelper
    {
        void TriggerEntityCreatedEvent(object entity);
        void TriggerEntityDeletedEvent(object entity);
        void TriggerEntityUpdatedEvent(object entity);
    }
}
