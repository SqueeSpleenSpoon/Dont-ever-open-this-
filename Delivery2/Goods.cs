using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery2
{
    public partial class Goods : Form
    {
        public Goods()
        {
            InitializeComponent();
        }

        private void продуктиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.продуктиBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.pIS_BD_2DataSet);
            try
            {
                this.tableAdapterManager.UpdateAll(this.pIS_BD_2DataSet);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка");
            }

        }

        private void Goods_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pIS_BD_2DataSet.Продукти". При необходимости она может быть перемещена или удалена.
            this.продуктиTableAdapter.Fill(this.pIS_BD_2DataSet.Продукти);

        }

        private void код_продуктівTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
