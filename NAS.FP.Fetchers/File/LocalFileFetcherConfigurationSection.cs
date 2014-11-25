using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAS.FP.Fetchers.File
{
    public class LocalFileFetcherConfigurationSection : ConfigurationSection
    {
        public const String SectionName = "LocalFileFetcherConfigurationSection";

        [ConfigurationProperty("directoryToReadFrom", IsRequired = true)]
        public string DirectoryToReadFrom
        {
            get { return (string)this["directoryToReadFrom"]; }
            set { this["directoryToReadFrom"] = value; }
        }

        [ConfigurationProperty("filePattern", IsRequired = true)]
        public string FilePattern
        {
            get { return (string)this["filePattern"]; }
            set { this["filePattern"] = value; }
        }
    }

}
