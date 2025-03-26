using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300035
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private String username;

        public SayaTubeUser(string user)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.username = user;
            this.uploadedVideos = new List<SayaTubeVideo>();
            validateInvariant();
        }

        public int getTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                total += uploadedVideos[i].getPlayCount();
            }
            return total;
            validateInvariant();
        }

        public void addVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
            validateInvariant();
            
        }
        
        public void printAllVideoPlaycount()
        {
            Console.WriteLine($"User: {username}\n");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i+1} judul: {uploadedVideos[i].getTitle()}");
            }
            validateInvariant()
        }

        private void validateInvariant()
        {
            Debug.Assert(this.username.Length > 0 && this.username.Length <= 100, "maksimal karakter username 100");
            Debug.Assert(this.uploadedVideos != null, "Video tidak boleh null");
        }
    }
}
