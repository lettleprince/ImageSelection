// Group2: Jingfei Yao, Grace Pauly, Xiaotong Han.

using System.Windows;

namespace ImageSelection
{
    /// Using the image files provided in the folder Group 2 Images, create an application that displays these images in Image/Button controls. 
    /// The application should perform the following actions:
    /// When the user clicks the 1 image, the application will display the word One in a message box.
    /// When the user clicks the 2 image, the application will display the word Two in a message box.
    /// When the user clicks the 3 image, the application will display the word Three in a message box.
    /// When the user clicks the 4 image, the application will display the word Four in a message box.
    /// When the user clicks the 5 image, the application will display the word Five in a message box.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("One", caption: "Image Clicked");
        }

        private void Image_2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Two", caption: "Image Clicked");
        }

        private void Image_3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Three", caption: "Image Clicked");
        }

        private void Image_4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Four", caption: "Image Clicked");
        }

        private void Image_5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Five", caption: "Image Clicked");
        }
    }
}
