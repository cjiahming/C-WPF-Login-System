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

namespace Intern_Application
{
    /// <summary>
    /// Interaction logic for CRUDpage.xaml
    /// </summary>
    public partial class CRUDpage : Page
    {
        public CRUDpage()
        {
            InitializeComponent();
        }

        private void homepageBtn_Click(object sender, RoutedEventArgs e)
        {
            Homepage hp = new Homepage();
            this.Crud.Content = hp;
        }

        private void crudPageBtn_Click(object sender, RoutedEventArgs e)
        {
            CRUDpage cp = new CRUDpage();
            this.Crud.Content = cp;
        }
    }
}
