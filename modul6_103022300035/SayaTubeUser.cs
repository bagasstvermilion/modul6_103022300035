using System;
using System.Collections.Generic;
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
        }

        public int getTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                total += uploadedVideos[i].getPlayCount();
            }
            return total;
        }

        public void addVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
            
        }
        
        public void printAllVideoPlaycount()
        {
            Console.WriteLine($"User: {username}\n");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i+1} judul: {uploadedVideos[i].getTitle()}");
            }
        }
    }
}
