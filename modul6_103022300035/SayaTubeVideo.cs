using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300035
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void increaasePlayCount(int increment)
        {
            this.playCount += increment;
        }

        public void printVideoDetails()
        {
            Console.WriteLine($"ID video: {id}");
            Console.WriteLine($"Judul: {title}");
            Console.WriteLine($"Play count: {playCount}");
        }

        public int getPlayCount()
        {
            return playCount;
        }

        public string getTitle()
        {
            return title;
        }


    }
}
