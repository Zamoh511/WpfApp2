
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
using System.IO;
using DevExpress.Mvvm.POCO;
//using WpfApp2.RapidCM_PGS_Dev;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //this.NavigationService.Navigate(new ListWindow());
            //MainWindow.NavigationService.Navigate(new Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
           
            InitializeComponent();      
            SetFakeData();
            PopulateImgCombobox();
            PopulateSupplierCombobox();
            PopulateTransCombobox();
            updateLookupEdit();
            PopulateGridControl();

        }

        string connectionString = @"XpoProvider=MSSqlServer;data source=DESKTOP-32QVBUV\SQL2017;user id=201619;password=pPqtKc19;initial catalog=RapidCM_Master_Dev2;Persist Security Info=true";
       
        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
        bool updateRec = false;
        int RecId = 0;
      
        double tar, gross;
        string Transporter;
        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            TestXtraReport report = new TestXtraReport();
            report.Parameters[0].Visible = false;
            //report.getId(99659);
            PrintHelper.ShowRibbonPrintPreviewDialog(this, report);
        }
        private void SetFakeData()
        {
            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private int _Weight;
        public int Weight
        {
            get
            {
                return _Weight;
            }
            set
            {
                _Weight = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
        private void Set<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            ListWindow p2 = new ListWindow();
            //NavigationService.Navigate(p2, "data");
        }
        private void Timer_Tick(object sender, object e)
        {
            Random random = new Random();
            Weight = random.Next(0, 12);
        }
        public void updateGauge()
        {
            
            //arcScales.StartValue = 0;
            //arcScales.EndValue = 12;
            //arcScales.StartAngle = -90;
            //arcScales.EndAngle = 270;
            //arcScales.MajorIntervalCount = 12;
            //arcScales.MinorIntervalCount = 5;

            //arcScaleMarker.Value = 5;

            //arcScaleNeedle.Value = 4;
            //arcScaleNeedle.Value = 10;

            //arcScaleRangeBar.AnchorValue = 8;
            //arcScaleRangeBar.Value = 2;
            ////Add Items
            //arcScales.RangeBars.Add(arcScaleRangeBar);
            //arcScales.Needles.Add(arcScaleNeedle);
            //arcScales.Markers.Add(arcScaleMarker);

            //gauge1.Scales.Add(arcScales);
            //arcScaleMarker.Value = 10;
            ////System.Threading.Thread.Sleep(5000);
            //arcScaleMarker.Value = 1;

        }
        private void Click_Edit(object sender, RoutedEventArgs e)
        {

            //this.Frame.Navigate(typeof(Product_RecievesPage), ((RapidCM_WeighBridge.RapidCM_PGS_Dev.Product_ProductReceive)((Windows.UI.Xaml.FrameworkElement)e.OriginalSource).DataContext).ID);
            TestXtraReport report = new TestXtraReport();
            report.Parameters[0].Visible = false;
            //report.getId(99659);
            PrintHelper.ShowRibbonPrintPreviewDialog(this, report);
        }
        public void updateLookupEdit()
        {
            var inMemoryDAL = XpoDefault.GetDataLayer(connectionString, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            try
            {
                using (var uow = new UnitOfWork(inMemoryDAL))
                {
                   var listitems = new XPCollection<Order_OrderIn>(uow).Select(i => new { /*ID = (i.ID).ToString(),*/ Name = i.OrderNo ,Quantity= i.Quantity}).ToList();

                    OrderLookupEdit.ItemsSource = listitems;
                    //dataGrid1.ItemsSource = listitems;
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
        private void TransComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(String.IsNullOrEmpty(Transporter))
            {
                Transporter = ((System.Windows.Controls.ContentControl)((object[])e.AddedItems)[0]).Content.ToString();
            }
        }         
        private void SupplierComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void PopulateTransCombobox()
        {
            var inMemoryDAL = XpoDefault.GetDataLayer(connectionString, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            try
            {
                using (var uow = new UnitOfWork(inMemoryDAL))
                {
                    XPCollection<Library_Transporter> Library_Transporters = new XPCollection<Library_Transporter>(uow);
                    //LookupEdit2.ItemsSource = new XPCollection<Order_OrderIn>(uow);
                    var list = Library_Transporters.Select(i => new { ID = (i.ID).ToString(), Name = i.Name }).ToList();
                    foreach (var item in list.Distinct())
                    {
                        ComboBoxItem comboItem = new ComboBoxItem();
                        comboItem.Content = item.Name;
                        comboItem.Tag = item.ID;
                        TransComboBox.Items.Add(comboItem);
                    }
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
        public void PopulateSupplierCombobox()
         {
            var inMemoryDAL = XpoDefault.GetDataLayer(connectionString, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            try
            {
                using (var uow = new UnitOfWork(inMemoryDAL))
                {
                    XPCollection<Library_TruckType> Library_TruckTypes = new XPCollection<Library_TruckType>(uow);
                    var list = Library_TruckTypes.Select(x => x.Name).ToList();

                    foreach (string item in list.Distinct())
                    {
                        SupplierComboBox.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
        //insert records
        private void commitButton_Click(object sender, RoutedEventArgs e)
        {
            //validateInput();

            if (updateRec == true)
            {
                updateRecord(RecId);

            }
            else
            {
                saveRecord();
                NavigationService.Navigate("GridWindow", null, this);

            }
            //this.Frame.Navigate(typeof(ProductRecieveListViewPage));
            //this.NavigationService.Navigate(newpage);
        }
        public void updateRecord(int id)
        {
            var inMemoryDAL = XpoDefault.GetDataLayer(connectionString, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            id = RecId;
            try
            {

                using (var uow = new UnitOfWork(inMemoryDAL))
                {
                    Order_OrderIn searchItem = new XPQuery<Order_OrderIn>(uow).FirstOrDefault(i => i.ID.Equals(lblOrderNo.Text));
                    //ExpectedTrucks searchTruck = new XPQuery<ExpectedTrucks>(uow).FirstOrDefault(i => i.ID == Convert.ToInt32(lblExpTruck.Text));
                    //Library_Supplier L_SearchItem = new XPQuery<Library_Supplier>(uow).FirstOrDefault(i => i.Name == (SupplierComboBox.SelectedValue.ToString()));
                    Library_Transporter LT_SearchItem = new XPQuery<Library_Transporter>(uow).FirstOrDefault(i => i.Name == (TransComboBox.SelectedValue.ToString()));
                    Product_ProductReceive pr = new XPQuery<Product_ProductReceive>(uow).FirstOrDefault(i => i.ID .Equals(id));
                    tar = Convert.ToDouble(txtTar.Text);
                    gross = Convert.ToDouble(txtGross.Text);
                    txtNett.Text = calcNettWeight(tar, gross).ToString();
                    pr.TarWeight = tar;
                    pr.GrossWeight = gross;
                    pr.NettWeight = calcNettWeight(tar, gross);
                    //pr.SupplierID = L_SearchItem;
                    pr.RecOrderID = searchItem;
                    //pr.ExpectedID = searchTruck;
                    pr.TransporterID = LT_SearchItem;
                    //pr.DateModified = DateTime.Now;
                    pr.DriverName = newDriver.Text;
                    pr.NettWeight = calcNettWeight(Convert.ToDouble(txtGross.Text), Convert.ToDouble(txtNett.Text));
                    uow.CommitChanges();

                }
            }
            catch (Exception ex)
            {

            }
        }
        public void saveRecord()
        {
            var inMemoryDAL = XpoDefault.GetDataLayer(connectionString, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);

            validateInput();
            try
            {
                using (var uow = new UnitOfWork(inMemoryDAL))
                {

                    string val = OrderLookupEdit.SelectedItem.ToString();
                    Order_OrderIn searchItem = new XPQuery<Order_OrderIn>(uow).FirstOrDefault(i => i.OrderNo.Equals(cleanString(val)));
                    
                    //ExpectedTrucks searchTruck = new XPQuery<ExpectedTrucks>(uow).FirstOrDefault(i => i.ID.Equals(lblExpTruck.Text));
                    //Library_Supplier L_SearchItem = new XPQuery<Library_Supplier>(uow).FirstOrDefault(i => i.Name == (SupplierComboBox.SelectedValue.ToString()));
                    // var result = TransComboBox.SelectedItem.Content.ToString();
                    Library_Transporter LT_SearchItem = new XPQuery<Library_Transporter>(uow).FirstOrDefault(i => i.Name.Equals(Transporter));

                    Product_ProductReceive pr = new Product_ProductReceive(uow);
                    var item = OrderLookupEdit.SelectedItem;
                    try
                     {
                        tar = Convert.ToDouble(txtTar.Text);
                        gross = Convert.ToDouble(txtGross.Text);
                        txtNett.Text = calcNettWeight(tar, gross).ToString();
                        pr.NettWeight = calcNettWeight(tar, gross);
                        //pr.SupplierID = L_SearchItem;
                        pr.RecOrderID = searchItem;
                        //pr.ExpectedID = searchTruck;
                        pr.TransporterID = LT_SearchItem;
                        pr.ArrivalDate = DateTime.Now;
                        pr.DriverName = newDriver.Text;

                        pr.NettWeight = calcNettWeight(Convert.ToDouble(txtGross.Text), Convert.ToDouble(txtNett.Text));

                        //pr.TruckRegistration = searchTruck.TruckRegistration;
                        //pr.ContainerNo = newContainer.Text;
                        pr.WBTicket = Convert.ToInt32(txtWbTicket.Text);
                        pr.Save();
                    }
                    catch
                    {
                        DisplayDialog("An Input Error Occured");
                        return;
                    }
                    uow.CommitChanges();
                    clearInput();
                    DisplayDialog("Transaction Saved");
                }

            }

            catch (Exception ex)
            {
                var Name = ex.Message;

                DisplayDialog("An input error occured");
            }
        }
        public void clearInput()
        {

            txtWbTicket.Text = null;
            txtNett.Text = null;
            newDriver.Text = null;
            //txtNote.Text = null;
            txtNett.Text = null;
            txtRef.Text = null;
            txtSealNo.Text = null;
            txtTar.Text = null;
            ImgCombobox.SelectedItem = null;
            SupplierComboBox.SelectedItem = null;
            TransComboBox.SelectedItem = null;
            //validateInput();
        }
        public double calcNettWeight(double tar, double gross)
        {
            double nett = 0;
            if (tar < gross)
            {
                nett = (gross - tar);
            }
            else
            {
                nett = 0;
                //DisplayDialog("The TarWeight cannot be greater than the GrossWeight");
            }
            return nett;
        }
        public void PopulateImgCombobox()
        {
            var inMemoryDAL = XpoDefault.GetDataLayer(connectionString, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            try
            {
                using (var uow = new UnitOfWork(inMemoryDAL))
                {
                    XPCollection<Library_Site> sites = new XPCollection<Library_Site>(uow);
                    var list = sites.Select(i => new { Logo = ImageFromBytes(i.Logo), i.Name }).ToList();
                    //var list = sites.Select(i => i.Name).ToList();
                    foreach (var item in list.Distinct())
                    {
                        ImgCombobox.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
        public static BitmapImage ImageFromBytes(Byte[] bytes)
        {
            BitmapImage image = new BitmapImage();

            using (var mem = new MemoryStream(bytes))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }       
        private void GetEmpty_Click(object sender, RoutedEventArgs e)
        {
            txtTar.Text = Weight.ToString();
        }
        private void GetFull_Click(object sender, RoutedEventArgs e)
        {
            txtGross.Text = Weight.ToString();
            //txtNett.Text = (calcNettWeight(Convert.ToDouble(txtGross.Text), Convert.ToDouble(txtNett.Text)).ToString());
        }
        private async void DisplayDialog(string msg)
        {
            string message = msg;
            string caption = "An Error Occured";
            MessageBoxButton buttons = MessageBoxButton.OKCancel;
            // Show message box
            MessageBoxResult result = MessageBox.Show(message, caption, buttons);
        }
        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        protected void OnNavigatedTo(NavigationEventArgs e)
        {
            //base.OnNavigatedTo(e);
            updateRec = true;
            //ExpectedTrucksComboBox expCombo = new ExpectedTrucksComboBox();
            //var parameters = (Product_ProductReceive)e.Parameter;
            try
            {
                var param = e.Content;
                RecId = Convert.ToInt32(param);
                var inMemoryDAL = XpoDefault.GetDataLayer(connectionString, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
                using (var uow = new UnitOfWork(inMemoryDAL))
                {
                    //XPQuery<Product_ProductReceive> items = new XPQuery<Product_ProductReceive>(uow);
                    Product_ProductReceive searchItem = new XPQuery<Product_ProductReceive>(uow).FirstOrDefault(i => i.ID.Equals(param));

                    if (searchItem.WBTicket != 0)
                    {
                        txtWbTicket.Text = (searchItem.WBTicket).ToString();
                    }
                    if (!String.IsNullOrEmpty(searchItem.DriverName))
                    {
                        newDriver.Text = (searchItem.DriverName).ToString();
                    }
                    if (!String.IsNullOrEmpty(searchItem.Seal1Number))
                    {
                        txtSealNo.Text = (searchItem.Seal1Number).ToString();
                    }
                    //if (searchItem.ExpectedID != null)
                    //{
                    //    //expCombo.ExpectedId = searchItem.ExpectedID.ID;
                    //}
                    if (!String.IsNullOrEmpty(searchItem.Seal1Number))
                    {
                        txtSealNo.Text = (searchItem.Seal1Number).ToString();
                    }
                    if (!String.IsNullOrEmpty(searchItem.Seal1Number))
                    {
                        txtSealNo.Text = (searchItem.Seal1Number).ToString();
                    }
                    if (!String.IsNullOrEmpty(searchItem.Seal1Number))
                    {
                        txtSealNo.Text = (searchItem.Seal1Number).ToString();
                    }
                    //if (searchItem.TransporterID != null)
                    //{
                    //    TransComboBox.SelectedIndex = searchItem.TransporterID.ID;
                    //}
                    //if (searchItem.SiteID != null)
                    //{
                    //    TransComboBox.SelectedIndex = searchItem.SiteID.ID;
                    //}

                    //newWbTicket.Text = (searchItem.WBTicket).ToString();
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
            //return true;
        }
        public void PopulateGridControl()
        {
            var inMemoryDAL = XpoDefault.GetDataLayer(connectionString, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            try
            {
                using (var uow = new UnitOfWork(inMemoryDAL))
                {
                    //var receives = new XPCollection<Library_Transporter>(uow);//.Select(i => new { ID = (i.ID).ToString(), TruckRegistation = i.TruckRegistration, ArrivalDate=i.ArrivalDate,WBTicket = i.WBTicket, OrderNo = i.RecOrderID.OrderNo }).ToList();

                    //dataGrid1.DataContext = receives;
                    //dxGrid1.ItemsSource = new XPCollection<Library_Product>(uow);

                }
            }
            catch (Exception ex)
            {
                //var msg = ex.Message;
            }
        }
        public void validateInput()
        {

            if (String.IsNullOrEmpty(txtSealNo.Text))
            {
                txtSealNo.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                txtSealNo.Background = new SolidColorBrush(Colors.Transparent);
            }

            if (String.IsNullOrEmpty(txtTar.Text))
            {
                txtTar.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                txtTar.Background = new SolidColorBrush(Colors.Transparent);
            }

            if (String.IsNullOrEmpty(txtWbTicket.Text))
            {
                txtWbTicket.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                txtWbTicket.Background = new SolidColorBrush(Colors.Transparent);
            }
            //if (String.IsNullOrEmpty(txtNote.Text))
            //{
            //    txtNote.Background = new SolidColorBrush(Colors.Red);
            //}
            //else
            //{
            //    txtNote.Background = new SolidColorBrush(Colors.Transparent);
            //}
            if (String.IsNullOrEmpty(txtRef.Text))
            {
                txtRef.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                txtRef.Background = new SolidColorBrush(Colors.Transparent);
            }
            if (String.IsNullOrEmpty(newDriver.Text))
            {
                newDriver.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                newDriver.Background = new SolidColorBrush(Colors.Transparent);
            }
            if (String.IsNullOrEmpty(txtGross.Text))
            {
                txtGross.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                txtGross.Background = new SolidColorBrush(Colors.Transparent);
            }
            if (String.IsNullOrEmpty(txtNett.Text))
            {
                txtNett.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                txtNett.Background = new SolidColorBrush(Colors.Transparent);
            }
            if (SupplierComboBox.SelectedValue == null)
            {
                SupplierComboBox.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                SupplierComboBox.Background = new SolidColorBrush(Colors.Transparent);
            }
            if (ImgCombobox.SelectedValue == null)
            {
                ImgCombobox.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                ImgCombobox.Background = new SolidColorBrush(Colors.Transparent);
            }
            //TransComboBox
            if (TransComboBox.SelectedValue == null)
            {
                TransComboBox.Background= new SolidColorBrush(Colors.Red);
            }
            else
            {
                TransComboBox.Background = new SolidColorBrush(Colors.Transparent);
            }

        }
        public string cleanString(string val)
        {
            string[] list = val.Split('=');
            string NewVal = list[1].Split(',')[0];
            string order= NewVal.Trim();
            return order;
        }
    }
}

