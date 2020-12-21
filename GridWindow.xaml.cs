using DevExpress.Xpo;
using RapidCMv1.Module.BusinessObjects.RapidCMV1_Master;
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
using DevExpress.Xpf.Printing;
using DevExpress.Xpo;
using RapidCMv1.Module;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
            PopulateGridControl();
        }

        string connectionString = @"XpoProvider=MSSqlServer;data source=DESKTOP-32QVBUV\SQL2017;user id=201619;password=pPqtKc19;initial catalog=RapidCM_Master_Dev2;Persist Security Info=true";


        public void PopulateGridControl()
        {
            var inMemoryDAL = XpoDefault.GetDataLayer(connectionString, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            try
            {
                using (var uow = new UnitOfWork(inMemoryDAL))
                {
                    dataGrid1.ItemsSource = new XPCollection<Product_ProductReceive>(uow).Select(i => new {  OrderNo = i.RecOrderID.OrderNo,ArrivalDate= i.ArrivalDate, TruckReg = i.TruckRegistration ,WbTicket=i.WBTicket,ID=i.ID.ToString()}).ToList();
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        private void Click_Edit(object sender, RoutedEventArgs e)
        {

            //this.Frame.Navigate(typeof(Product_RecievesPage), ((RapidCM_WeighBridge.RapidCM_PGS_Dev.Product_ProductReceive)((Windows.UI.Xaml.FrameworkElement)e.OriginalSource).DataContext).ID);
            GRN report = new GRN();
            report.Parameters[0].Visible = false;
            report.getId(((System.Windows.FrameworkElement)e.Source).DataContext.ToString());
            PrintHelper.ShowRibbonPrintPreviewDialog(this, report);
        }


    }
}
