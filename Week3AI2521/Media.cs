using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AI2521
{
    internal abstract class Media:IDownloadable
    {
        private string title;

        public Media(string title)
        {
            this.title = title;
        }

        public string Title { get => title; set => title = value; }

        public abstract void play();

        public virtual void Download()
        {
            Console.WriteLine("Downloading Media");
        }
    }
}
