using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery2
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void клієнтBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клієнтBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pIS_BD_2DataSet);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pIS_BD_2DataSet.Клієнт". При необходимости она может быть перемещена или удалена.
            this.клієнтTableAdapter.Fill(this.pIS_BD_2DataSet.Клієнт);

        }
    }
}
