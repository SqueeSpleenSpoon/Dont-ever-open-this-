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
    public partial class FirmsTransport : Form
    {
        public FirmsTransport()
        {
            InitializeComponent();
        }

        private void транспорт_фірмиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.транспорт_фірмиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pIS_BD_2DataSet);

        }

        private void транспорт_фірмиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.транспорт_фірмиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pIS_BD_2DataSet);

        }

        private void FirmsTransport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pIS_BD_2DataSet.Доставка". При необходимости она может быть перемещена или удалена.
            this.доставкаTableAdapter.Fill(this.pIS_BD_2DataSet.Доставка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pIS_BD_2DataSet.Кур_єр". При необходимости она может быть перемещена или удалена.
            this.кур_єрTableAdapter.Fill(this.pIS_BD_2DataSet.Кур_єр);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pIS_BD_2DataSet.Транспорт_фірми". При необходимости она может быть перемещена или удалена.
            this.транспорт_фірмиTableAdapter.Fill(this.pIS_BD_2DataSet.Транспорт_фірми);

        }
    }
}
