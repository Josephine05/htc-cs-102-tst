using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        ObservableCollection <movieClasses> movieList = new ObservableCollection<movieClasses>();

        public MainWindow()
        {
            InitializeComponent();
            MovieListView.ItemsSource = movieList;
        }

        private void SubmitMovieButton_Click(object sender, RoutedEventArgs e)
        {

            movieClasses submittedMovie = new movieClasses(TitletextBox_Copy.Text, genretextbox.Text, Double.Parse(reviewscoreTextBox.Text));

            movieList.Add(submittedMovie);
            //submittedMovie.Title = TitletextBox_Copy.Text;
            //submittedMovie.Genre = genretextbox.Text;
            //submittedMovie.ReviewScore = Convert.ToDouble(reviewscoreTextBox.Text);
            //submittedMovie.ReviewScore = Double.Parse(reviewscoreTextBox.Text);

             submittedMovie.DisplayInfomation();

            TitletextBox_Copy.Clear();
            genretextbox.Clear();
            reviewscoreTextBox.Clear();
        }

    }
}
