using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for WindowBooks.xaml
    /// </summary>
    public partial class WindowBooks : Window
    {
       
        public WindowBooks()
        {
            InitializeComponent();

            List<BookData> bookdatas = new List<BookData>();
            bookdatas.Add(item: new BookData { Title = "הארי פוטר", Language = "עברית", BorrowDate = new DateTime (22 / 10 / 2025), PageNum = 30,
                ReturnDate = new DateTime(1 / 1 / 2026 )});
            bookdatas.Add(item: new BookData { Title = "שר הטבעות", Language = "עברית", BorrowDate = new DateTime(28 / 8 / 2025), PageNum = 46,
                ReturnDate = new DateTime(20/11/2025), ImageURL = "C:\\Users\\User\\source\\repos\\WpfApp2\\WpfApp2\\Pictures\\שרק הטבעות.jpg" });
            bookdatas.Add(item: new BookData { Title = "משחקי הרעב", Language = "עברית", BorrowDate = new DateTime(11 / 5 / 2026), PageNum = 300,
                ReturnDate = new DateTime(30 / 7 / 2026), ImageURL = "C:\\Users\\User\\source\\repos\\WpfApp2\\WpfApp2\\Pictures\\משחקי הרעב.jpg"});
            bookdatas.Add(item: new BookData { Title = "דוד אריה", Language = "עברית", BorrowDate = new DateTime(7 / 9 / 2025), PageNum = 30, 
                ReturnDate = new DateTime(8 / 2 / 2026), ImageURL = "C:\\Users\\User\\source\\repos\\WpfApp2\\WpfApp2\\Pictures\\דוד אריה.jpg" });
            bookdatas.Add(item: new BookData { Title = "פרסי ג'קסון", Language = "עברית", BorrowDate = new DateTime(2 / 3 / 2026), PageNum = 30, 
                ReturnDate = new DateTime(3 / 4 / 2026), ImageURL = "C:\\Users\\User\\source\\repos\\WpfApp2\\WpfApp2\\Pictures\\.פרסי גקשוןjpg" });

            foreach (BookData book in bookdatas)
            {
                  UserControl1 userControl = new UserControl1(book);
                booksp.Children.Add(userControl);
            }


        }
    }


    public class BookData
    {
        public string Title { get; set; }
        public string Language { get; set; }
        public string ImageURL { get; set; }
        public int PageNum { get; set; }
        public DateTime  BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }


    }
}
