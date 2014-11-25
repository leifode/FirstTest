using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAS.FP.Fetchers.File;

namespace NAS.FP.Fetchers.File
{
    public class LocalFileFetcher : IFetchFiles<LocalFileInfo>
    {
        private string _directoryToReadFrom;
        private string _fileNamePattern;

        public LocalFileFetcher()
        {
            var configSection = ConfigurationManager.GetSection(LocalFileFetcherConfigurationSection.SectionName) as LocalFileFetcherConfigurationSection;
            if (configSection != null)
            {
                _directoryToReadFrom = configSection.DirectoryToReadFrom;
                _fileNamePattern = configSection.FilePattern;
            }
        }




        public LocalFileFetcher(string directoryToReadFrom, string fileNamePattern)
        {
            _directoryToReadFrom = directoryToReadFrom;
            _fileNamePattern = fileNamePattern;
        }

        public IEnumerable<LocalFileInfo> FetchFiles()
        {
            return null;
        }
    }

    public class RemoteFileFetcher : IFetchFiles<RemoteFileInfo>
    {

        public RemoteFileFetcher(string directoryToReadFrom, string fileNamePattern)
        {

        }

        IEnumerable<RemoteFileInfo> IFetchFiles<RemoteFileInfo>.FetchFiles()
        {
            return null;
        }
    }
}
