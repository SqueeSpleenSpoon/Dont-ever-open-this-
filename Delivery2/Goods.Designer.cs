
namespace Delivery2
{
    partial class Goods
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
            System.Windows.Forms.Label код_продуктівLabel;
            System.Windows.Forms.Label назваLabel;
            System.Windows.Forms.Label ціна_за_одLabel;
            System.Windows.Forms.Label упаковкаLabel;
            System.Windows.Forms.Label вага_кг_одинLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goods));
            this.pIS_BD_2DataSet = new Delivery2.PIS_BD_2DataSet();
            this.продуктиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продуктиTableAdapter = new Delivery2.PIS_BD_2DataSetTableAdapters.ПродуктиTableAdapter();
            this.tableAdapterManager = new Delivery2.PIS_BD_2DataSetTableAdapters.TableAdapterManager();
            this.продуктиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.продуктиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_продуктівTextBox = new System.Windows.Forms.TextBox();
            this.назваTextBox = new System.Windows.Forms.TextBox();
            this.ціна_за_одTextBox = new System.Windows.Forms.TextBox();
            this.упаковкаTextBox = new System.Windows.Forms.TextBox();
            this.вага_кг_одинTextBox = new System.Windows.Forms.TextBox();
            код_продуктівLabel = new System.Windows.Forms.Label();
            назваLabel = new System.Windows.Forms.Label();
            ціна_за_одLabel = new System.Windows.Forms.Label();
            упаковкаLabel = new System.Windows.Forms.Label();
            вага_кг_одинLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pIS_BD_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктиBindingNavigator)).BeginInit();
            this.продуктиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_продуктівLabel
            // 
            код_продуктівLabel.AutoSize = true;
            код_продуктівLabel.Location = new System.Drawing.Point(115, 79);
            код_продуктівLabel.Name = "код_продуктівLabel";
            код_продуктівLabel.Size = new System.Drawing.Size(104, 17);
            код_продуктівLabel.TabIndex = 1;
            код_продуктівLabel.Text = "Код продуктів:";
            // 
            // назваLabel
            // 
            назваLabel.AutoSize = true;
            назваLabel.Location = new System.Drawing.Point(115, 132);
            назваLabel.Name = "назваLabel";
            назваLabel.Size = new System.Drawing.Size(52, 17);
            назваLabel.TabIndex = 3;
            назваLabel.Text = "Назва:";
            // 
            // ціна_за_одLabel
            // 
            ціна_за_одLabel.AutoSize = true;
            ціна_за_одLabel.Location = new System.Drawing.Point(115, 187);
            ціна_за_одLabel.Name = "ціна_за_одLabel";
            ціна_за_одLabel.Size = new System.Drawing.Size(81, 17);
            ціна_за_одLabel.TabIndex = 5;
            ціна_за_одLabel.Text = "Ціна за од:";
            // 
            // упаковкаLabel
            // 
            упаковкаLabel.AutoSize = true;
            упаковкаLabel.Location = new System.Drawing.Point(115, 254);
            упаковкаLabel.Name = "упаковкаLabel";
            упаковкаLabel.Size = new System.Drawing.Size(74, 17);
            упаковкаLabel.TabIndex = 7;
            упаковкаLabel.Text = "Упаковка:";
            // 
            // вага_кг_одинLabel
            // 
            вага_кг_одинLabel.AutoSize = true;
            вага_кг_одинLabel.Location = new System.Drawing.Point(115, 311);
            вага_кг_одинLabel.Name = "вага_кг_одинLabel";
            вага_кг_одинLabel.Size = new System.Drawing.Size(94, 17);
            вага_кг_одинLabel.TabIndex = 9;
            вага_кг_одинLabel.Text = "Вага кг один:";
            // 
            // pIS_BD_2DataSet
            // 
            this.pIS_BD_2DataSet.DataSetName = "PIS_BD_2DataSet";
            this.pIS_BD_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продуктиBindingSource
            // 
            this.продуктиBindingSource.DataMember = "Продукти";
            this.продуктиBindingSource.DataSource = this.pIS_BD_2DataSet;
            // 
            // продуктиTableAdapter
            // 
            this.продуктиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Delivery2.PIS_BD_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Власний_транспортTableAdapter = null;
            this.tableAdapterManager.ДоставкаTableAdapter = null;
            this.tableAdapterManager.ЗамовленняTableAdapter = null;
            this.tableAdapterManager.КлієнтTableAdapter = null;
            this.tableAdapterManager.Кур_єрTableAdapter = null;
            this.tableAdapterManager.ПродуктиTableAdapter = this.продуктиTableAdapter;
            this.tableAdapterManager.Рядок_замволенняTableAdapter = null;
            this.tableAdapterManager.Транспорт_фірмиTableAdapter = null;
            this.tableAdapterManager.ЧекTableAdapter = null;
            // 
            // продуктиBindingNavigator
            // 
            this.продуктиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.продуктиBindingNavigator.BindingSource = this.продуктиBindingSource;
            this.продуктиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.продуктиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.продуктиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.продуктиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.продуктиBindingNavigatorSaveItem});
            this.продуктиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.продуктиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.продуктиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.продуктиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.продуктиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.продуктиBindingNavigator.Name = "продуктиBindingNavigator";
            this.продуктиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.продуктиBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.продуктиBindingNavigator.TabIndex = 0;
            this.продуктиBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // продуктиBindingNavigatorSaveItem
            // 
            this.продуктиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.продуктиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("продуктиBindingNavigatorSaveItem.Image")));
            this.продуктиBindingNavigatorSaveItem.Name = "продуктиBindingNavigatorSaveItem";
            this.продуктиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.продуктиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.продуктиBindingNavigatorSaveItem.Click += new System.EventHandler(this.продуктиBindingNavigatorSaveItem_Click);
            // 
            // код_продуктівTextBox
            // 
            this.код_продуктівTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продуктиBindingSource, "Код_продуктів", true));
            this.код_продуктівTextBox.Location = new System.Drawing.Point(225, 76);
            this.код_продуктівTextBox.Name = "код_продуктівTextBox";
            this.код_продуктівTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_продуктівTextBox.TabIndex = 2;
            this.код_продуктівTextBox.TextChanged += new System.EventHandler(this.код_продуктівTextBox_TextChanged);
            // 
            // назваTextBox
            // 
            this.назваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продуктиBindingSource, "Назва", true));
            this.назваTextBox.Location = new System.Drawing.Point(173, 129);
            this.назваTextBox.Name = "назваTextBox";
            this.назваTextBox.Size = new System.Drawing.Size(152, 22);
            this.назваTextBox.TabIndex = 4;
            // 
            // ціна_за_одTextBox
            // 
            this.ціна_за_одTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продуктиBindingSource, "Ціна_за_од", true));
            this.ціна_за_одTextBox.Location = new System.Drawing.Point(202, 184);
            this.ціна_за_одTextBox.Name = "ціна_за_одTextBox";
            this.ціна_за_одTextBox.Size = new System.Drawing.Size(123, 22);
            this.ціна_за_одTextBox.TabIndex = 6;
            // 
            // упаковкаTextBox
            // 
            this.упаковкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продуктиBindingSource, "Упаковка", true));
            this.упаковкаTextBox.Location = new System.Drawing.Point(195, 251);
            this.упаковкаTextBox.Name = "упаковкаTextBox";
            this.упаковкаTextBox.Size = new System.Drawing.Size(130, 22);
            this.упаковкаTextBox.TabIndex = 8;
            // 
            // вага_кг_одинTextBox
            // 
            this.вага_кг_одинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продуктиBindingSource, "Вага_кг_один", true));
            this.вага_кг_одинTextBox.Location = new System.Drawing.Point(215, 308);
            this.вага_кг_одинTextBox.Name = "вага_кг_одинTextBox";
            this.вага_кг_одинTextBox.Size = new System.Drawing.Size(110, 22);
            this.вага_кг_одинTextBox.TabIndex = 10;
            // 
            // Goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(вага_кг_одинLabel);
            this.Controls.Add(this.вага_кг_одинTextBox);
            this.Controls.Add(упаковкаLabel);
            this.Controls.Add(this.упаковкаTextBox);
            this.Controls.Add(ціна_за_одLabel);
            this.Controls.Add(this.ціна_за_одTextBox);
            this.Controls.Add(назваLabel);
            this.Controls.Add(this.назваTextBox);
            this.Controls.Add(код_продуктівLabel);
            this.Controls.Add(this.код_продуктівTextBox);
            this.Controls.Add(this.продуктиBindingNavigator);
            this.Name = "Goods";
            this.Text = "Goods";
            this.Load += new System.EventHandler(this.Goods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pIS_BD_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктиBindingNavigator)).EndInit();
            this.продуктиBindingNavigator.ResumeLayout(false);
            this.продуктиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PIS_BD_2DataSet pIS_BD_2DataSet;
        private System.Windows.Forms.BindingSource продуктиBindingSource;
        private PIS_BD_2DataSetTableAdapters.ПродуктиTableAdapter продуктиTableAdapter;
        private PIS_BD_2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator продуктиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton продуктиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_продуктівTextBox;
        private System.Windows.Forms.TextBox назваTextBox;
        private System.Windows.Forms.TextBox ціна_за_одTextBox;
        private System.Windows.Forms.TextBox упаковкаTextBox;
        private System.Windows.Forms.TextBox вага_кг_одинTextBox;
    }
}