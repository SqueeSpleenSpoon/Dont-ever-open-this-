
namespace Delivery2
{
    partial class FirmsTransport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmsTransport));
            System.Windows.Forms.Label номер_транспорту_підприємстваLabel;
            System.Windows.Forms.Label код_курєраLabel;
            System.Windows.Forms.Label код_доставкиLabel;
            this.pIS_BD_2DataSet = new Delivery2.PIS_BD_2DataSet();
            this.транспорт_фірмиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.транспорт_фірмиTableAdapter = new Delivery2.PIS_BD_2DataSetTableAdapters.Транспорт_фірмиTableAdapter();
            this.tableAdapterManager = new Delivery2.PIS_BD_2DataSetTableAdapters.TableAdapterManager();
            this.транспорт_фірмиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.транспорт_фірмиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_транспорту_підприємстваTextBox = new System.Windows.Forms.TextBox();
            this.код_курєраComboBox = new System.Windows.Forms.ComboBox();
            this.код_доставкиComboBox = new System.Windows.Forms.ComboBox();
            this.курєрBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кур_єрTableAdapter = new Delivery2.PIS_BD_2DataSetTableAdapters.Кур_єрTableAdapter();
            this.доставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставкаTableAdapter = new Delivery2.PIS_BD_2DataSetTableAdapters.ДоставкаTableAdapter();
            номер_транспорту_підприємстваLabel = new System.Windows.Forms.Label();
            код_курєраLabel = new System.Windows.Forms.Label();
            код_доставкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pIS_BD_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспорт_фірмиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспорт_фірмиBindingNavigator)).BeginInit();
            this.транспорт_фірмиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.курєрBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pIS_BD_2DataSet
            // 
            this.pIS_BD_2DataSet.DataSetName = "PIS_BD_2DataSet";
            this.pIS_BD_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // транспорт_фірмиBindingSource
            // 
            this.транспорт_фірмиBindingSource.DataMember = "Транспорт_фірми";
            this.транспорт_фірмиBindingSource.DataSource = this.pIS_BD_2DataSet;
            // 
            // транспорт_фірмиTableAdapter
            // 
            this.транспорт_фірмиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Delivery2.PIS_BD_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Власний_транспортTableAdapter = null;
            this.tableAdapterManager.ДоставкаTableAdapter = this.доставкаTableAdapter;
            this.tableAdapterManager.ЗамовленняTableAdapter = null;
            this.tableAdapterManager.КлієнтTableAdapter = null;
            this.tableAdapterManager.Кур_єрTableAdapter = this.кур_єрTableAdapter;
            this.tableAdapterManager.ПродуктиTableAdapter = null;
            this.tableAdapterManager.Рядок_замволенняTableAdapter = null;
            this.tableAdapterManager.Транспорт_фірмиTableAdapter = this.транспорт_фірмиTableAdapter;
            this.tableAdapterManager.ЧекTableAdapter = null;
            // 
            // транспорт_фірмиBindingNavigator
            // 
            this.транспорт_фірмиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.транспорт_фірмиBindingNavigator.BindingSource = this.транспорт_фірмиBindingSource;
            this.транспорт_фірмиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.транспорт_фірмиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.транспорт_фірмиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.транспорт_фірмиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.транспорт_фірмиBindingNavigatorSaveItem});
            this.транспорт_фірмиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.транспорт_фірмиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.транспорт_фірмиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.транспорт_фірмиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.транспорт_фірмиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.транспорт_фірмиBindingNavigator.Name = "транспорт_фірмиBindingNavigator";
            this.транспорт_фірмиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.транспорт_фірмиBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.транспорт_фірмиBindingNavigator.TabIndex = 0;
            this.транспорт_фірмиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // транспорт_фірмиBindingNavigatorSaveItem
            // 
            this.транспорт_фірмиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.транспорт_фірмиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("транспорт_фірмиBindingNavigatorSaveItem.Image")));
            this.транспорт_фірмиBindingNavigatorSaveItem.Name = "транспорт_фірмиBindingNavigatorSaveItem";
            this.транспорт_фірмиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.транспорт_фірмиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.транспорт_фірмиBindingNavigatorSaveItem.Click += new System.EventHandler(this.транспорт_фірмиBindingNavigatorSaveItem_Click_1);
            // 
            // номер_транспорту_підприємстваLabel
            // 
            номер_транспорту_підприємстваLabel.AutoSize = true;
            номер_транспорту_підприємстваLabel.Location = new System.Drawing.Point(159, 145);
            номер_транспорту_підприємстваLabel.Name = "номер_транспорту_підприємстваLabel";
            номер_транспорту_підприємстваLabel.Size = new System.Drawing.Size(227, 17);
            номер_транспорту_підприємстваLabel.TabIndex = 1;
            номер_транспорту_підприємстваLabel.Text = "Номер транспорту підприємства:";
            // 
            // номер_транспорту_підприємстваTextBox
            // 
            this.номер_транспорту_підприємстваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.транспорт_фірмиBindingSource, "Номер_транспорту_підприємства", true));
            this.номер_транспорту_підприємстваTextBox.Location = new System.Drawing.Point(392, 142);
            this.номер_транспорту_підприємстваTextBox.Name = "номер_транспорту_підприємстваTextBox";
            this.номер_транспорту_підприємстваTextBox.Size = new System.Drawing.Size(100, 22);
            this.номер_транспорту_підприємстваTextBox.TabIndex = 2;
            // 
            // код_курєраLabel
            // 
            код_курєраLabel.AutoSize = true;
            код_курєраLabel.Location = new System.Drawing.Point(159, 198);
            код_курєраLabel.Name = "код_курєраLabel";
            код_курєраLabel.Size = new System.Drawing.Size(86, 17);
            код_курєраLabel.TabIndex = 3;
            код_курєраLabel.Text = "Код курєра:";
            // 
            // код_курєраComboBox
            // 
            this.код_курєраComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.транспорт_фірмиBindingSource, "Код_курєра", true));
            this.код_курєраComboBox.DataSource = this.курєрBindingSource;
            this.код_курєраComboBox.DisplayMember = "Код_курєра";
            this.код_курєраComboBox.FormattingEnabled = true;
            this.код_курєраComboBox.Location = new System.Drawing.Point(251, 195);
            this.код_курєраComboBox.Name = "код_курєраComboBox";
            this.код_курєраComboBox.Size = new System.Drawing.Size(121, 24);
            this.код_курєраComboBox.TabIndex = 4;
            this.код_курєраComboBox.ValueMember = "Код_курєра";
            // 
            // код_доставкиLabel
            // 
            код_доставкиLabel.AutoSize = true;
            код_доставкиLabel.Location = new System.Drawing.Point(159, 240);
            код_доставкиLabel.Name = "код_доставкиLabel";
            код_доставкиLabel.Size = new System.Drawing.Size(101, 17);
            код_доставкиLabel.TabIndex = 5;
            код_доставкиLabel.Text = "Код доставки:";
            // 
            // код_доставкиComboBox
            // 
            this.код_доставкиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.транспорт_фірмиBindingSource, "Код_доставки", true));
            this.код_доставкиComboBox.DataSource = this.доставкаBindingSource;
            this.код_доставкиComboBox.DisplayMember = "Код_доставки";
            this.код_доставкиComboBox.FormattingEnabled = true;
            this.код_доставкиComboBox.Location = new System.Drawing.Point(266, 237);
            this.код_доставкиComboBox.Name = "код_доставкиComboBox";
            this.код_доставкиComboBox.Size = new System.Drawing.Size(121, 24);
            this.код_доставкиComboBox.TabIndex = 6;
            this.код_доставкиComboBox.ValueMember = "Код_доставки";
            // 
            // курєрBindingSource
            // 
            this.курєрBindingSource.DataMember = "Кур_єр";
            this.курєрBindingSource.DataSource = this.pIS_BD_2DataSet;
            // 
            // кур_єрTableAdapter
            // 
            this.кур_єрTableAdapter.ClearBeforeFill = true;
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
            // FirmsTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(код_доставкиLabel);
            this.Controls.Add(this.код_доставкиComboBox);
            this.Controls.Add(код_курєраLabel);
            this.Controls.Add(this.код_курєраComboBox);
            this.Controls.Add(номер_транспорту_підприємстваLabel);
            this.Controls.Add(this.номер_транспорту_підприємстваTextBox);
            this.Controls.Add(this.транспорт_фірмиBindingNavigator);
            this.Name = "FirmsTransport";
            this.Text = "FirmsTransport";
            this.Load += new System.EventHandler(this.FirmsTransport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pIS_BD_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспорт_фірмиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспорт_фірмиBindingNavigator)).EndInit();
            this.транспорт_фірмиBindingNavigator.ResumeLayout(false);
            this.транспорт_фірмиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.курєрBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PIS_BD_2DataSet pIS_BD_2DataSet;
        private System.Windows.Forms.BindingSource транспорт_фірмиBindingSource;
        private PIS_BD_2DataSetTableAdapters.Транспорт_фірмиTableAdapter транспорт_фірмиTableAdapter;
        private PIS_BD_2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator транспорт_фірмиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton транспорт_фірмиBindingNavigatorSaveItem;
        private PIS_BD_2DataSetTableAdapters.Кур_єрTableAdapter кур_єрTableAdapter;
        private System.Windows.Forms.TextBox номер_транспорту_підприємстваTextBox;
        private System.Windows.Forms.ComboBox код_курєраComboBox;
        private System.Windows.Forms.ComboBox код_доставкиComboBox;
        private System.Windows.Forms.BindingSource курєрBindingSource;
        private PIS_BD_2DataSetTableAdapters.ДоставкаTableAdapter доставкаTableAdapter;
        private System.Windows.Forms.BindingSource доставкаBindingSource;
    }
}