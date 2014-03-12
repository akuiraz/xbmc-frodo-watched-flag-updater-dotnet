using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XbmcWatchedFlagUpdater
{
    /// <summary>
    /// Contains the file name, watched count and last watched date of an individual file
    /// </summary>
    class XbmcFile : IComparable
    {
        public int WatchedCount { get; private set; }
        public string LastWatchedDate { get; private set; }
        public string FileName { get; private set; }

        public XbmcFile(string fileName, int watchedCount, string lastWatchedDate)
        {
            FileName = fileName;
            WatchedCount = watchedCount;
            LastWatchedDate = lastWatchedDate;
        }

        public int CompareTo(object obj)
        {
            XbmcFile itemToCompare = obj as XbmcFile;
            return String.Compare(this.FileName, itemToCompare.FileName);
        }
    }
}
