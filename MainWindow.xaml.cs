using DevExpress.Xpo;
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
using WpfApp2.RapidCM_PGS_Dev;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateViewItems();
           
        }
       
        const string connectionString = @"XpoProvider=MSSqlServer;data source=DESKTOP-32QVBUV\SQL2017;user id=201619;password=pPqtKc19;initial catalog=RapidCM_PGS_Dev;Persist Security Info=true";


        
        public void PopulateViewItems()
        {
            var inMemoryDAL = XpoDefault.GetDataLayer(connectionString, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);

            try
            {
                using (var uow = new UnitOfWork(inMemoryDAL))
                {

                    Grid1.ItemsSource = new XPQuery<Library_Supplier>(uow);
                    Cmb1.ItemsSource = new XPQuery<Library_Supplier>(uow).Select(x => x.Name);
                     
                    
                    //XPCollection<Library_Supplier> library_Suppliers = new XPCollection<Library_Supplier>(uow);

                }
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
            }
         }



    }
}

