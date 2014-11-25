using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace NAS.FP.Scheduler.Messages
{
    public class ISitaMessageProcessingScheduled : IMessage
    {
        public Guid Id;


    }
}
