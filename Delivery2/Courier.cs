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
    public partial class Courier : Form
    {
        public Courier()
        {
            InitializeComponent();
        }

        private void кур_єрBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.кур_єрBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pIS_BD_2DataSet);

        }

        private void Courier_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pIS_BD_2DataSet.Кур_єр". При необходимости она может быть перемещена или удалена.
            this.кур_єрTableAdapter.Fill(this.pIS_BD_2DataSet.Кур_єр);

        }
    }
}
