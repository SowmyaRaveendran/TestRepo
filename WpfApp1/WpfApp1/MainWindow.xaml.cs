using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public string MyButton { get; set; } = "Add";
        public string MyText { get; set; } = "Intro to WPF";
        public ObservableCollection<string> MyList { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.Resources["ButtonColorBrush"] = new SolidColorBrush(Colors.LightGray);
            DataContext = this;
            MyList = new ObservableCollection<string>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyList.Add("New Item");
        }

        private void ChangeText_Click(object sender, RoutedEventArgs e)
        {
            MyText = "DataBinding works!!";
            NotifyPropertyChange(nameof(MyText));
        }

        /// <summary>
        /// Event that Should Happen when Property Values are Changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Methods that Invoke the Event.
        /// </summary>
        /// <param name="property">Name of the Property.</param>
        protected void NotifyPropertyChange(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
}
