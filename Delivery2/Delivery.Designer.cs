
namespace Delivery2
{
    partial class Delivery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_доставкиLabel;
            System.Windows.Forms.Label код_курєраLabel;
            System.Windows.Forms.Label маршрутLabel;
            System.Windows.Forms.Label дата_доставкиLabel;
            System.Windows.Forms.Label код_замовленняLabel;
            System.Windows.Forms.Label вид_транспортуLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            this.pIS_BD_2DataSet = new Delivery2.PIS_BD_2DataSet();
            this.доставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставкаTableAdapter = new Delivery2.PIS_BD_2DataSetTableAdapters.ДоставкаTableAdapter();
            this.tableAdapterManager = new Delivery2.PIS_BD_2DataSetTableAdapters.TableAdapterManager();
            this.замовленняTableAdapter = new Delivery2.PIS_BD_2DataSetTableAdapters.ЗамовленняTableAdapter();
            this.кур_єрTableAdapter = new Delivery2.PIS_BD_2DataSetTableAdapters.Кур_єрTableAdapter();
            this.доставкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.доставкаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_доставкиTextBox = new System.Windows.Forms.TextBox();
            this.код_курєраComboBox = new System.Windows.Forms.ComboBox();
            this.курєрBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.маршрутTextBox = new System.Windows.Forms.TextBox();
            this.дата_доставкиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_замовленняComboBox = new System.Windows.Forms.ComboBox();
            this.замовленняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вид_транспортуTextBox = new System.Windows.Forms.TextBox();
            this.доставкаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            код_доставкиLabel = new System.Windows.Forms.Label();
            код_курєраLabel = new System.Windows.Forms.Label();
            маршрутLabel = new System.Windows.Forms.Label();
            дата_доставкиLabel = new System.Windows.Forms.Label();
            код_замовленняLabel = new System.Windows.Forms.Label();
            вид_транспортуLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pIS_BD_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingNavigator)).BeginInit();
            this.доставкаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.курєрBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовленняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // код_доставкиLabel
            // 
            код_доставкиLabel.AutoSize = true;
            код_доставкиLabel.Location = new System.Drawing.Point(115, 70);
            код_доставкиLabel.Name = "код_доставкиLabel";
            код_доставкиLabel.Size = new System.Drawing.Size(101, 17);
            код_доставкиLabel.TabIndex = 1;
            код_доставкиLabel.Text = "Код доставки:";
            // 
            // код_курєраLabel
            // 
            код_курєраLabel.AutoSize = true;
            код_курєраLabel.Location = new System.Drawing.Point(115, 123);
            код_курєраLabel.Name = "код_курєраLabel";
            код_курєраLabel.Size = new System.Drawing.Size(86, 17);
            код_курєраLabel.TabIndex = 3;
            код_курєраLabel.Text = "Код курєра:";
            // 
            // маршрутLabel
            // 
            маршрутLabel.AutoSize = true;
            маршрутLabel.Location = new System.Drawing.Point(293, 303);
            маршрутLabel.Name = "маршрутLabel";
            маршрутLabel.Size = new System.Drawing.Size(72, 17);
            маршрутLabel.TabIndex = 5;
            маршрутLabel.Text = "Маршрут:";
            // 
            // дата_доставкиLabel
            // 
            дата_доставкиLabel.AutoSize = true;
            дата_доставкиLabel.Location = new System.Drawing.Point(298, 366);
            дата_доставкиLabel.Name = "дата_доставкиLabel";
            дата_доставкиLabel.Size = new System.Drawing.Size(110, 17);
            дата_доставкиLabel.TabIndex = 7;
            дата_доставкиLabel.Text = "Дата доставки:";
            // 
            // код_замовленняLabel
            // 
            код_замовленняLabel.AutoSize = true;
            код_замовленняLabel.Location = new System.Drawing.Point(115, 167);
            код_замовленняLabel.Name = "код_замовленняLabel";
            код_замовленняLabel.Size = new System.Drawing.Size(120, 17);
            код_замовленняLabel.TabIndex = 9;
            код_замовленняLabel.Text = "Код замовлення:";
            // 
            // вид_транспортуLabel
            // 
            вид_транспортуLabel.AutoSize = true;
            вид_транспортуLabel.Location = new System.Drawing.Point(115, 219);
            вид_транспортуLabel.Name = "вид_транспортуLabel";
            вид_транспортуLabel.Size = new System.Drawing.Size(117, 17);
            вид_транспортуLabel.TabIndex = 11;
            вид_транспортуLabel.Text = "Вид транспорту:";
            // 
            // pIS_BD_2DataSet
            // 
            this.pIS_BD_2DataSet.DataSetName = "PIS_BD_2DataSet";
            this.pIS_BD_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // доставкаBindingSource
            // 
            this.доставкаBindingSource.DataMember = "Доставка";
            this.доставкаBindingSource.DataSource = this.pIS_BD_2DataSet;
            // 
            // доставкаTableAdapter
            // 
            this.доставкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Delivery2.PIS_BD_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Власний_транспортTableAdapter = null;
            this.tableAdapterManager.ДоставкаTableAdapter = this.доставкаTableAdapter;
            this.tableAdapterManager.ЗамовленняTableAdapter = this.замовленняTableAdapter;
            this.tableAdapterManager.КлієнтTableAdapter = null;
            this.tableAdapterManager.Кур_єрTableAdapter = this.кур_єрTableAdapter;
            this.tableAdapterManager.ПродуктиTableAdapter = null;
            this.tableAdapterManager.Рядок_замволенняTableAdapter = null;
            this.tableAdapterManager.Транспорт_фірмиTableAdapter = null;
            this.tableAdapterManager.ЧекTableAdapter = null;
            // 
            // замовленняTableAdapter
            // 
            this.замовленняTableAdapter.ClearBeforeFill = true;
            // 
            // кур_єрTableAdapter
            // 
            this.кур_єрTableAdapter.ClearBeforeFill = true;
            // 
            // доставкаBindingNavigator
            // 
            this.доставкаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.доставкаBindingNavigator.BindingSource = this.доставкаBindingSource;
            this.доставкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.доставкаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.доставкаBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.доставкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.доставкаBindingNavigatorSaveItem});
            this.доставкаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.доставкаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.доставкаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.доставкаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.доставкаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.доставкаBindingNavigator.Name = "доставкаBindingNavigator";
            this.доставкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.доставкаBindingNavigator.Size = new System.Drawing.Size(932, 27);
            this.доставкаBindingNavigator.TabIndex = 0;
            this.доставкаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // доставкаBindingNavigatorSaveItem
            // 
            this.доставкаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.доставкаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("доставкаBindingNavigatorSaveItem.Image")));
            this.доставкаBindingNavigatorSaveItem.Name = "доставкаBindingNavigatorSaveItem";
            this.доставкаBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.доставкаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.доставкаBindingNavigatorSaveItem.Click += new System.EventHandler(this.доставкаBindingNavigatorSaveItem_Click);
            // 
            // код_доставкиTextBox
            // 
            this.код_доставкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставкаBindingSource, "Код_доставки", true));
            this.код_доставкиTextBox.Location = new System.Drawing.Point(222, 67);
            this.код_доставкиTextBox.Name = "код_доставкиTextBox";
            this.код_доставкиTextBox.Size = new System.Drawing.Size(140, 22);
            this.код_доставкиTextBox.TabIndex = 2;
            // 
            // код_курєраComboBox
            // 
            this.код_курєраComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставкаBindingSource, "Код_курєра", true));
            this.код_курєраComboBox.DataSource = this.курєрBindingSource;
            this.код_курєраComboBox.DisplayMember = "Код_курєра";
            this.код_курєраComboBox.FormattingEnabled = true;
            this.код_курєраComboBox.Location = new System.Drawing.Point(207, 120);
            this.код_курєраComboBox.Name = "код_курєраComboBox";
            this.код_курєраComboBox.Size = new System.Drawing.Size(155, 24);
            this.код_курєраComboBox.TabIndex = 4;
            this.код_курєраComboBox.ValueMember = "Код_курєра";
            // 
            // курєрBindingSource
            // 
            this.курєрBindingSource.DataMember = "Кур_єр";
            this.курєрBindingSource.DataSource = this.pIS_BD_2DataSet;
            // 
            // маршрутTextBox
            // 
            this.маршрутTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставкаBindingSource, "Маршрут", true));
            this.маршрутTextBox.Location = new System.Drawing.Point(371, 300);
            this.маршрутTextBox.Name = "маршрутTextBox";
            this.маршрутTextBox.Size = new System.Drawing.Size(243, 22);
            this.маршрутTextBox.TabIndex = 6;
            // 
            // дата_доставкиDateTimePicker
            // 
            this.дата_доставкиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.доставкаBindingSource, "Дата_доставки", true));
            this.дата_доставкиDateTimePicker.Location = new System.Drawing.Point(414, 362);
            this.дата_доставкиDateTimePicker.Name = "дата_доставкиDateTimePicker";
            this.дата_доставкиDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_доставкиDateTimePicker.TabIndex = 8;
            // 
            // код_замовленняComboBox
            // 
            this.код_замовленняComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставкаBindingSource, "Код_замовлення", true));
            this.код_замовленняComboBox.DataSource = this.замовленняBindingSource;
            this.код_замовленняComboBox.DisplayMember = "Код_замовлення";
            this.код_замовленняComboBox.FormattingEnabled = true;
            this.код_замовленняComboBox.Location = new System.Drawing.Point(241, 164);
            this.код_замовленняComboBox.Name = "код_замовленняComboBox";
            this.код_замовленняComboBox.Size = new System.Drawing.Size(121, 24);
            this.код_замовленняComboBox.TabIndex = 10;
            this.код_замовленняComboBox.ValueMember = "Код_замовлення";
            // 
            // замовленняBindingSource
            // 
            this.замовленняBindingSource.DataMember = "Замовлення";
            this.замовленняBindingSource.DataSource = this.pIS_BD_2DataSet;
            // 
            // вид_транспортуTextBox
            // 
            this.вид_транспортуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставкаBindingSource, "Вид_транспорту", true));
            this.вид_транспортуTextBox.Location = new System.Drawing.Point(238, 216);
            this.вид_транспортуTextBox.Name = "вид_транспортуTextBox";
            this.вид_транспортуTextBox.Size = new System.Drawing.Size(124, 22);
            this.вид_транспортуTextBox.TabIndex = 12;
            // 
            // доставкаDataGridView
            // 
            this.доставкаDataGridView.AutoGenerateColumns = false;
            this.доставкаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.доставкаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.доставкаDataGridView.DataSource = this.доставкаBindingSource;
            this.доставкаDataGridView.Location = new System.Drawing.Point(0, 399);
            this.доставкаDataGridView.Name = "доставкаDataGridView";
            this.доставкаDataGridView.RowHeadersWidth = 51;
            this.доставкаDataGridView.RowTemplate.Height = 24;
            this.доставкаDataGridView.Size = new System.Drawing.Size(1042, 220);
            this.доставкаDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_доставки";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_доставки";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код_курєра";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код_курєра";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Маршрут";
            this.dataGridViewTextBoxColumn3.HeaderText = "Маршрут";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_доставки";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата_доставки";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Код_замовлення";
            this.dataGridViewTextBoxColumn5.HeaderText = "Код_замовлення";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Вид_транспорту";
            this.dataGridViewTextBoxColumn6.HeaderText = "Вид_транспорту";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Час_доставки";
            this.dataGridViewTextBoxColumn7.HeaderText = "Час_доставки";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 639);
            this.Controls.Add(this.доставкаDataGridView);
            this.Controls.Add(вид_транспортуLabel);
            this.Controls.Add(this.вид_транспортуTextBox);
            this.Controls.Add(код_замовленняLabel);
            this.Controls.Add(this.код_замовленняComboBox);
            this.Controls.Add(дата_доставкиLabel);
            this.Controls.Add(this.дата_доставкиDateTimePicker);
            this.Controls.Add(маршрутLabel);
            this.Controls.Add(this.маршрутTextBox);
            this.Controls.Add(код_курєраLabel);
            this.Controls.Add(this.код_курєраComboBox);
            this.Controls.Add(код_доставкиLabel);
            this.Controls.Add(this.код_доставкиTextBox);
            this.Controls.Add(this.доставкаBindingNavigator);
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.Delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pIS_BD_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingNavigator)).EndInit();
            this.доставкаBindingNavigator.ResumeLayout(false);
            this.доставкаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.курєрBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовленняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PIS_BD_2DataSet pIS_BD_2DataSet;
        private System.Windows.Forms.BindingSource доставкаBindingSource;
        private PIS_BD_2DataSetTableAdapters.ДоставкаTableAdapter доставкаTableAdapter;
        private PIS_BD_2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator доставкаBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton доставкаBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_доставкиTextBox;
        private PIS_BD_2DataSetTableAdapters.Кур_єрTableAdapter кур_єрTableAdapter;
        private System.Windows.Forms.ComboBox код_курєраComboBox;
        private System.Windows.Forms.TextBox маршрутTextBox;
        private System.Windows.Forms.DateTimePicker дата_доставкиDateTimePicker;
        private System.Windows.Forms.ComboBox код_замовленняComboBox;
        private System.Windows.Forms.TextBox вид_транспортуTextBox;
        private System.Windows.Forms.BindingSource курєрBindingSource;
        private PIS_BD_2DataSetTableAdapters.ЗамовленняTableAdapter замовленняTableAdapter;
        private System.Windows.Forms.BindingSource замовленняBindingSource;
        private System.Windows.Forms.DataGridView доставкаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}