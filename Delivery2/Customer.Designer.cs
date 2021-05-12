
namespace Delivery2
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            System.Windows.Forms.Label код_клієнтаLabel;
            System.Windows.Forms.Label імя_клієнтаLabel;
            System.Windows.Forms.Label телефон_клієнтаLabel;
            System.Windows.Forms.Label адресаLabel;
            this.pIS_BD_2DataSet = new Delivery2.PIS_BD_2DataSet();
            this.клієнтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клієнтTableAdapter = new Delivery2.PIS_BD_2DataSetTableAdapters.КлієнтTableAdapter();
            this.tableAdapterManager = new Delivery2.PIS_BD_2DataSetTableAdapters.TableAdapterManager();
            this.клієнтBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.клієнтBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_клієнтаTextBox = new System.Windows.Forms.TextBox();
            this.імя_клієнтаTextBox = new System.Windows.Forms.TextBox();
            this.телефон_клієнтаTextBox = new System.Windows.Forms.TextBox();
            this.адресаTextBox = new System.Windows.Forms.TextBox();
            код_клієнтаLabel = new System.Windows.Forms.Label();
            імя_клієнтаLabel = new System.Windows.Forms.Label();
            телефон_клієнтаLabel = new System.Windows.Forms.Label();
            адресаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pIS_BD_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingNavigator)).BeginInit();
            this.клієнтBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pIS_BD_2DataSet
            // 
            this.pIS_BD_2DataSet.DataSetName = "PIS_BD_2DataSet";
            this.pIS_BD_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клієнтBindingSource
            // 
            this.клієнтBindingSource.DataMember = "Клієнт";
            this.клієнтBindingSource.DataSource = this.pIS_BD_2DataSet;
            // 
            // клієнтTableAdapter
            // 
            this.клієнтTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Delivery2.PIS_BD_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Власний_транспортTableAdapter = null;
            this.tableAdapterManager.ДоставкаTableAdapter = null;
            this.tableAdapterManager.ЗамовленняTableAdapter = null;
            this.tableAdapterManager.КлієнтTableAdapter = this.клієнтTableAdapter;
            this.tableAdapterManager.Кур_єрTableAdapter = null;
            this.tableAdapterManager.ПродуктиTableAdapter = null;
            this.tableAdapterManager.Рядок_замволенняTableAdapter = null;
            this.tableAdapterManager.Транспорт_фірмиTableAdapter = null;
            this.tableAdapterManager.ЧекTableAdapter = null;
            // 
            // клієнтBindingNavigator
            // 
            this.клієнтBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.клієнтBindingNavigator.BindingSource = this.клієнтBindingSource;
            this.клієнтBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.клієнтBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.клієнтBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.клієнтBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.клієнтBindingNavigatorSaveItem});
            this.клієнтBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.клієнтBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.клієнтBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.клієнтBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.клієнтBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.клієнтBindingNavigator.Name = "клієнтBindingNavigator";
            this.клієнтBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.клієнтBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.клієнтBindingNavigator.TabIndex = 0;
            this.клієнтBindingNavigator.Text = "bindingNavigator1";
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
            // клієнтBindingNavigatorSaveItem
            // 
            this.клієнтBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.клієнтBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("клієнтBindingNavigatorSaveItem.Image")));
            this.клієнтBindingNavigatorSaveItem.Name = "клієнтBindingNavigatorSaveItem";
            this.клієнтBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.клієнтBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.клієнтBindingNavigatorSaveItem.Click += new System.EventHandler(this.клієнтBindingNavigatorSaveItem_Click);
            // 
            // код_клієнтаLabel
            // 
            код_клієнтаLabel.AutoSize = true;
            код_клієнтаLabel.Location = new System.Drawing.Point(71, 84);
            код_клієнтаLabel.Name = "код_клієнтаLabel";
            код_клієнтаLabel.Size = new System.Drawing.Size(89, 17);
            код_клієнтаLabel.TabIndex = 1;
            код_клієнтаLabel.Text = "Код клієнта:";
            // 
            // код_клієнтаTextBox
            // 
            this.код_клієнтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клієнтBindingSource, "Код_клієнта", true));
            this.код_клієнтаTextBox.Location = new System.Drawing.Point(166, 81);
            this.код_клієнтаTextBox.Name = "код_клієнтаTextBox";
            this.код_клієнтаTextBox.Size = new System.Drawing.Size(135, 22);
            this.код_клієнтаTextBox.TabIndex = 2;
            // 
            // імя_клієнтаLabel
            // 
            імя_клієнтаLabel.AutoSize = true;
            імя_клієнтаLabel.Location = new System.Drawing.Point(71, 137);
            імя_клієнтаLabel.Name = "імя_клієнтаLabel";
            імя_клієнтаLabel.Size = new System.Drawing.Size(84, 17);
            імя_клієнтаLabel.TabIndex = 3;
            імя_клієнтаLabel.Text = "Імя клієнта:";
            // 
            // імя_клієнтаTextBox
            // 
            this.імя_клієнтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клієнтBindingSource, "Імя_клієнта", true));
            this.імя_клієнтаTextBox.Location = new System.Drawing.Point(160, 134);
            this.імя_клієнтаTextBox.Name = "імя_клієнтаTextBox";
            this.імя_клієнтаTextBox.Size = new System.Drawing.Size(141, 22);
            this.імя_клієнтаTextBox.TabIndex = 4;
            // 
            // телефон_клієнтаLabel
            // 
            телефон_клієнтаLabel.AutoSize = true;
            телефон_клієнтаLabel.Location = new System.Drawing.Point(71, 201);
            телефон_клієнтаLabel.Name = "телефон_клієнтаLabel";
            телефон_клієнтаLabel.Size = new System.Drawing.Size(124, 17);
            телефон_клієнтаLabel.TabIndex = 5;
            телефон_клієнтаLabel.Text = "Телефон клієнта:";
            // 
            // телефон_клієнтаTextBox
            // 
            this.телефон_клієнтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клієнтBindingSource, "Телефон_клієнта", true));
            this.телефон_клієнтаTextBox.Location = new System.Drawing.Point(201, 198);
            this.телефон_клієнтаTextBox.Name = "телефон_клієнтаTextBox";
            this.телефон_клієнтаTextBox.Size = new System.Drawing.Size(100, 22);
            this.телефон_клієнтаTextBox.TabIndex = 6;
            // 
            // адресаLabel
            // 
            адресаLabel.AutoSize = true;
            адресаLabel.Location = new System.Drawing.Point(71, 267);
            адресаLabel.Name = "адресаLabel";
            адресаLabel.Size = new System.Drawing.Size(60, 17);
            адресаLabel.TabIndex = 7;
            адресаLabel.Text = "Адреса:";
            // 
            // адресаTextBox
            // 
            this.адресаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клієнтBindingSource, "Адреса", true));
            this.адресаTextBox.Location = new System.Drawing.Point(137, 264);
            this.адресаTextBox.Name = "адресаTextBox";
            this.адресаTextBox.Size = new System.Drawing.Size(164, 22);
            this.адресаTextBox.TabIndex = 8;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(адресаLabel);
            this.Controls.Add(this.адресаTextBox);
            this.Controls.Add(телефон_клієнтаLabel);
            this.Controls.Add(this.телефон_клієнтаTextBox);
            this.Controls.Add(імя_клієнтаLabel);
            this.Controls.Add(this.імя_клієнтаTextBox);
            this.Controls.Add(код_клієнтаLabel);
            this.Controls.Add(this.код_клієнтаTextBox);
            this.Controls.Add(this.клієнтBindingNavigator);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pIS_BD_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клієнтBindingNavigator)).EndInit();
            this.клієнтBindingNavigator.ResumeLayout(false);
            this.клієнтBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PIS_BD_2DataSet pIS_BD_2DataSet;
        private System.Windows.Forms.BindingSource клієнтBindingSource;
        private PIS_BD_2DataSetTableAdapters.КлієнтTableAdapter клієнтTableAdapter;
        private PIS_BD_2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator клієнтBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton клієнтBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_клієнтаTextBox;
        private System.Windows.Forms.TextBox імя_клієнтаTextBox;
        private System.Windows.Forms.TextBox телефон_клієнтаTextBox;
        private System.Windows.Forms.TextBox адресаTextBox;
    }
}