using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WPFMidiBand
{
    class Song : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string FileName { get; set; }

        public Song(string fn)
        {
            FileName = fn;
            string[] parts = FileName.Split('\\');
            Name = parts[parts.Length - 1];
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
