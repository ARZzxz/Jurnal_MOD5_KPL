using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using modul5_1302200027;

namespace modul_1302200027
{
    internal class Program
    {
        public class SayaTubeUser
        {
            private int id;
            private List<SayaTubeVideo> uploadedVideos;
            private string Username;
            private List<SayaTubeVideo> uploadedVideo;

            public SayaTubeUser(string username)
            {
                Random shuffle = new Random();
                id = shuffle.Next(0, 100000);
                uploadedVideos = new List<SayaTubeVideo>();
            }

            public int GetTotalVideoPlayCount()
            {
                int total = 0;
                foreach (SayaTubeVideo video in uploadedVideos)
                {
                    total += video.GetPlaycount();
                }
                return total;
            }

            public void AddVideo(SayaTubeVideo video)
            {
                uploadedVideos.Add(video);

            }

            public void PrintAllVideoPlaycount()
            {
                Console.WriteLine("User : " + this.AddVideo);
                for (int i = 0; i < uploadedVideos.Count; i++)
                {
                    Console.WriteLine("Video " + (i + 1) + " Judul : " + uploadedVideos[i].GetTitle());
                }
            }
        }
    }
}
