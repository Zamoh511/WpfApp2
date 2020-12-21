
using DevExpress.DataProcessing;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Printing;
using DevExpress.Xpo;
using RapidCMv1.Module;
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
using RapidCMv1.Module.BusinessObjects;
using RapidCMv1.Module.BusinessObjects.RapidCMV1_Master;
using DevExpress.Mvvm;
using System.Windows.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;
//using DevExpress.Mvvm.POCO;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
        public ListWindow()
        {
            InitializeComponent();
        }
        //private static NavigationService NavigationService { get; } = (Application.Current.MainWindow as MainWindow).mainFrame.NavigationService;

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            TestXtraReport report = new TestXtraReport();
            report.Parameters[0].Visible = false;
            //report.getId(99659);
            PrintHelper.ShowRibbonPrintPreviewDialog(this, report);
        }

        private void tile1_Click(object sender, EventArgs e)
        {

            var newForm = new MainWindow(); 
            newForm.Show();
            this.Close();

        }
        private void tile2_Click(object sender, EventArgs e)
        {

            var newForm = new GridWindow();
            newForm.Show();
            this.Close();

        }
        private void tile3_Click(object sender, EventArgs e)
        {
            TestXtraReport report = new TestXtraReport();
            //report.Parameters[0].Visible = false;
            //report.getId(99659);
            PrintHelper.ShowRibbonPrintPreviewDialog(this, report);

        }
    }
}
