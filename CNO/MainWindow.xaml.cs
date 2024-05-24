using System.Windows;
using System.Windows.Controls;

namespace CNO
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ItemList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ItemList.SelectedItem is ListBoxItem selectedItem)
            {
                string itemContent = selectedItem.Content.ToString();
                AddTextBlockToCanvas(itemContent);
            }
        }

        private void AddTextBlockToCanvas(string text)
        {
            TextBlock textBlock = new TextBlock
            {
                Text = text,
                Name = text, // Definindo o nome do objeto como o texto
                Margin = new Thickness(10)
            };

            ItemCanvas.Children.Add(textBlock);
        }
    }
}
