using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            if (title == null)
            {
                throw new ArgumentException("Judul video tidak boleh null");

            }
            if (title.Length > 200)
            {
                throw new ArgumentException("Judul video tidak boleh lebih dari 200 karalter");
            }
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;

            validateInvariant();
        }

        public void increaasePlayCount(int increment)
        {
            try
            {
                checked
                {
                    this.playCount += increment;
                }
            } catch (OverflowException)
            {
                Console.WriteLine("ERROR: playcount melebihi batas integer");
            }
            validateInvariant();
            
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

        private void validateInvariant()
        {
            Debug.Assert(this.id >= 10000 && this.id <= 99999, "ID harus 5 digit");
            Debug.Assert(this.title.Length > 0 && this.title.Length <= 200, "title harus memiliki panjang kurang dari 200 karakter");
            Debug.Assert(this.playCount >= 0 && this.playCount <= 25000000, "playcount tidak boleh negatif");
        }
    }
}
