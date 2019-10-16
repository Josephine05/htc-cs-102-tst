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

        public List<string> Actors;

        public movieClasses(string title, string genre, double reviewScore)
        {
            Title = title;
            Genre = genre;
            ReviewScore = reviewScore;
        }

        public void DisplayInfomation() 
        {
            MessageBox.Show($"Title:{Title} \n Genre:{Genre} \n ReviewScore:{ReviewScore}");
        }
    }
}
