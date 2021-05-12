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
    public partial class OwnTransport : Form
    {
        public OwnTransport()
        {
            InitializeComponent();
        }

        private void власний_транспортBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.власний_транспортBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pIS_BD_2DataSet);

        }

        private void власний_транспортBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.власний_транспортBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pIS_BD_2DataSet);

        }

        private void OwnTransport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pIS_BD_2DataSet.Доставка". При необходимости она может быть перемещена или удалена.
            this.доставкаTableAdapter.Fill(this.pIS_BD_2DataSet.Доставка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pIS_BD_2DataSet.Кур_єр". При необходимости она может быть перемещена или удалена.
            this.кур_єрTableAdapter.Fill(this.pIS_BD_2DataSet.Кур_єр);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pIS_BD_2DataSet.Власний_транспорт". При необходимости она может быть перемещена или удалена.
            this.власний_транспортTableAdapter.Fill(this.pIS_BD_2DataSet.Власний_транспорт);

        }
    }
}
