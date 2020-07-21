using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace _20200721_Assignment
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juras Rabačauskas\source\repos\_20200721_Assignment\RobotDataBase.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void uzsakymaiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uzsakymaiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.robotDataBaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'robotDataBaseDataSet.Uzsakymai' table. You can move, or remove it, as needed.
            this.uzsakymaiTableAdapter.Fill(this.robotDataBaseDataSet.Uzsakymai);

        }


        private void SearchByCodeButton_Click(object sender, EventArgs e)
        {
            DataContext dataContext = new DataContext(ConnectionString);

            var tableData = dataContext.GetTable<DrawingInDB>().Where(x => OrderNumberTextBox.Text == x.Sheet.Uzsakymai.OrderNumber);

            DataGridViewData.DataSource = tableData.Select(x => new { 
                x.Sheet.Amount,
                x.Code,
                x.Package,
                x.TrueName,
                x.Sheet.Uzsakymai.Name,
                x.Sheet.Uzsakymai.DeliveryDate
            });

            TotalCountLabel.Text = tableData.ToList().Count.ToString();
        }

        private void SearchByDateButton_Click(object sender, EventArgs e)
        {
            DataContext dataContext = new DataContext(ConnectionString);

            var tableData = dataContext.GetTable<DrawingInDB>().Where(x => DateTimeFrom.Value <= x.Sheet.Uzsakymai.DeliveryDate && DateTimeTo.Value >= x.Sheet.Uzsakymai.DeliveryDate);
            
            DataGridViewData.DataSource = tableData.Select(x => new {
                x.Sheet.Amount,
                x.Code,
                x.Package,
                x.TrueName,
                x.Sheet.Uzsakymai.Name,
                x.Sheet.Uzsakymai.DeliveryDate
            });

            TotalCountLabel.Text = tableData.ToList().Count.ToString();
        }
    }
}
