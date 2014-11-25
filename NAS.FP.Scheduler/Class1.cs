using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAS.FP.Scheduler.Messages;
using NServiceBus;

namespace NAS.FP.Scheduler
{
    public class Class1 : IWantToRunWhenBusStartsAndStops
    {
        private IBus _bus;
        private Schedule _schedule { get; set; }

        public Class1(IBus bus, Schedule schedule)
        {
            _bus = bus;
            _schedule = schedule;
        }
        
        public void Start()
        {
            _schedule.Every(new TimeSpan(0,0,10), () =>
                _bus.Send(new ISitaMessageProcessingScheduled()) );
        }

        public void Stop()
        {

        }
    }
}
