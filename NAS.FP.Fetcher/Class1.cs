using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAS.FP.Fetchers;
using NAS.FP.Fetchers.File;
using NAS.FP.Scheduler.Messages;
using NServiceBus;

namespace NAS.FP.Fetcher
{
    public class Class1
    {
    }

    public class SITAMessageProcessingHandler : IHandleMessages<ISitaMessageProcessingScheduled>
    {
        private IBus _iBus;
        private IFetchFiles<LocalFileInfo> _iFetchFiles;

        public SITAMessageProcessingHandler(IBus iBus, IFetchFiles<LocalFileInfo> iFetchFiles)
        {
            _iBus = iBus;
            _iFetchFiles = iFetchFiles;
        }


        public void Handle(ISitaMessageProcessingScheduled message)
        {
            Console.WriteLine("Message received...");

            //Using fetcher to get files
            var messages = _iFetchFiles.FetchFiles();
        }
    }

}
