using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesHub
{
    /// <summary>
    /// Stores information about the games in your library
    /// </summary>
    public class GamesHubFile
    {
        public FileInfo file { get; set; }
        public FileVersionInfo versionInfo { get; set; }

        public GamesHubFile(FileInfo file, FileVersionInfo vInfo)
        {
            this.file = file;
            this.versionInfo = vInfo;
        }
    }
}
