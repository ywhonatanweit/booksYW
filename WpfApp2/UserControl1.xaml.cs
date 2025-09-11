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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1(BookData b)
        {
            InitializeComponent();
            this.BookData = b;
            
            this.BookName.Text=b.Title;
            this.BookLanguage.Text = b.Language;
            this.BookBorrow.Text = b.BorrowDate.ToString();
            this.BookPageNum.Text = b.PageNum.ToString();
            this.BookReturn.Text = b.ReturnDate.ToString();
            try
            {
                this.BookPic.Source = new BitmapImage(new Uri(BookData.ImageURL, uriKind: UriKind.RelativeOrAbsolute) );
            }
            catch (Exception ex) {
                MessageBox.Show("Url faild");
            }

        }
        private void OpenShowLoadData(object sender, RoutedEventArgs e)
        {
            
        

        }



        public event EventHandler MyEvent;

       public BookData BookData { get; private set; }
            public UserControl1()
        {
              InitializeComponent();
        }
       
    }
}
