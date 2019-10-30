using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieApplication
{
    class movieClasses
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public double ReviewScore { get; set; }
        public string Director { get; set; }
        public double Length { get; set; }

        public List<string> Actors;

        public movieClasses(string title, string genre, double reviewScore, string director, double length)
        {
            Title = title;
            Genre = genre;
            ReviewScore = reviewScore;
            Director = director;
            Length = length;
        }

        public void DisplayInfomation() 
        {
            MessageBox.Show($"Title:{Title} \n Genre:{Genre} \n ReviewScore:{ReviewScore} /n Director:{Director} /n Length:{Length}");
        }
    }
}
