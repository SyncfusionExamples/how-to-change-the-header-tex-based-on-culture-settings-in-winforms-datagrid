using SfDataGrid_Demo;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;
using System.Resources;
using System.Globalization;

namespace SfDataGrid_Demo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes the new instance for the Form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            sfDataGrid1.DataSource = new OrderInfoCollection().OrdersListDetails;

            ResourceWrapper resourceWrapper = new ResourceWrapper();
            sfDataGrid1.Columns["CustomerID"].HeaderText = resourceWrapper.CustomerIDText;
            sfDataGrid1.Columns["OrderID"].HeaderText = resourceWrapper.OrderIDText;
            sfDataGrid1.Columns["ShipCountry"].HeaderText = resourceWrapper.ShipCountryText;
        }

        #endregion
    }

    public class ResourceWrapper
    {
        const string OrderIDTextName = "OrderIDText";
        const string CustomerIDTextName = "CustomerIDText";
        const string ShipCountryTextName = "ShipCountryText";

        public ResourceWrapper()
        {
            ResourceManager rs = SfDataGrid_Demo.Properties.Resources.ResourceManager;
            OrderIDText = rs.GetString(OrderIDTextName, CultureInfo.CurrentUICulture);
            CustomerIDText = rs.GetString(CustomerIDTextName, CultureInfo.CurrentUICulture);
            ShipCountryText = rs.GetString(ShipCountryTextName, CultureInfo.CurrentUICulture);
        }
        public string OrderIDText { get; set; }
        public string CustomerIDText { get; set; }
        public string ShipCountryText { get; set; }
    }
}
