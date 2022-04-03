using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_System.Model;

namespace Warehouse_System.Interface.Warehouses
{
    public partial class NewWarehouse : Form
    {
        public NewWarehouse()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewWarehouse_Load(object sender, EventArgs e)
        {

        }

        private void DataGridFill()
        {
            WarehouseSystem ws = new WarehouseSystem();
            ObservableCollection<Warehouse> list = new ObservableCollection<Warehouse>();
            list = (ObservableCollection<Warehouse>)ws.Warehouses.Where(m=>m.W_Name!=null);
            dataGridView1.DataSource = list;
        }
    }
}
