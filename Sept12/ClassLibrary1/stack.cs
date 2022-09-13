using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Stereodisc("Song name", "language", "lyrics")]
    public class song
    {
        [Stereodisc("Ae Dil Hai Mushkil", "Hindi", "lyrics")]
        public string sName
        {
            get;
            set;
        }
        [Stereodisc("Nee Kavithaigala", "Tamil", "lyrics")]
        public int Count
        {
            get;
        }


    }
}