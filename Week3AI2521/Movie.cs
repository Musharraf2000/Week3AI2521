using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal class Movie:Media,IDownloadable
    {
        public Movie(string title) : base(title)
        {
        }

        public override void play()
        {
            Console.WriteLine("Playing Movie");
        }

        public override void Download()
        {
            Console.WriteLine("Downloading Movie");
        }
    }
}
