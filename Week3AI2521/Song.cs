using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal class Song:Media,IDownloadable
    {
        public Song(string title) : base(title)
        {
        }

        public override void play()
        {
            Console.WriteLine("Playing Song");
        }

        public override void Download()
        {
            Console.WriteLine("Downloading Song");
        }
    }
}
