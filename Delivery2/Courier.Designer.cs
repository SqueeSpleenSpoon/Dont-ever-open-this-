
namespace Delivery2
{
    partial class Courier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Courier));
            System.Windows.Forms.Label код_курєраLabel;
            System.Windows.Forms.Label імя_курєраLabel;
            System.Windows.Forms.Label телефон_курєраLabel;
            this.pIS_BD_2DataSet = new Delivery2.PIS_BD_2DataSet();
            this.кур_єрBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кур_єрTableAdapter = new Delivery2.PIS_BD_2DataSetTableAdapters.Кур_єрTableAdapter();
            this.tableAdapterManager = new Delivery2.PIS_BD_2DataSetTableAdapters.TableAdapterManager();
            this.кур_єрBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.кур_єрBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_курєраTextBox = new System.Windows.Forms.TextBox();
            this.імя_курєраTextBox = new System.Windows.Forms.TextBox();
            this.телефон_курєраTextBox = new System.Windows.Forms.TextBox();
            код_курєраLabel = new System.Windows.Forms.Label();
            імя_курєраLabel = new System.Windows.Forms.Label();
            телефон_курєраLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pIS_BD_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кур_єрBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кур_єрBindingNavigator)).BeginInit();
            this.кур_єрBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pIS_BD_2DataSet
            // 
            this.pIS_BD_2DataSet.DataSetName = "PIS_BD_2DataSet";
            this.pIS_BD_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кур_єрBindingSource
            // 
            this.кур_єрBindingSource.DataMember = "Кур_єр";
            this.кур_єрBindingSource.DataSource = this.pIS_BD_2DataSet;
            // 
            // кур_єрTableAdapter
            // 
            this.кур_єрTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Delivery2.PIS_BD_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Власний_транспортTableAdapter = null;
            this.tableAdapterManager.ДоставкаTableAdapter = null;
            this.tableAdapterManager.ЗамовленняTableAdapter = null;
            this.tableAdapterManager.КлієнтTableAdapter = null;
            this.tableAdapterManager.Кур_єрTableAdapter = this.кур_єрTableAdapter;
            this.tableAdapterManager.ПродуктиTableAdapter = null;
            this.tableAdapterManager.Рядок_замволенняTableAdapter = null;
            this.tableAdapterManager.Транспорт_фірмиTableAdapter = null;
            this.tableAdapterManager.ЧекTableAdapter = null;
            // 
            // кур_єрBindingNavigator
            // 
            this.кур_єрBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.кур_єрBindingNavigator.BindingSource = this.кур_єрBindingSource;
            this.кур_єрBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.кур_єрBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.кур_єрBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.кур_єрBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.кур_єрBindingNavigatorSaveItem});
            this.кур_єрBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.кур_єрBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.кур_єрBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.кур_єрBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.кур_єрBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.кур_єрBindingNavigator.Name = "кур_єрBindingNavigator";
            this.кур_єрBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.кур_єрBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.кур_єрBindingNavigator.TabIndex = 0;
            this.кур_єрBindingNavigator.Text = "bindingNavigator1";
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
            // кур_єрBindingNavigatorSaveItem
            // 
            this.кур_єрBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.кур_єрBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("кур_єрBindingNavigatorSaveItem.Image")));
            this.кур_єрBindingNavigatorSaveItem.Name = "кур_єрBindingNavigatorSaveItem";
            this.кур_єрBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.кур_єрBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.кур_єрBindingNavigatorSaveItem.Click += new System.EventHandler(this.кур_єрBindingNavigatorSaveItem_Click);
            // 
            // код_курєраLabel
            // 
            код_курєраLabel.AutoSize = true;
            код_курєраLabel.Location = new System.Drawing.Point(58, 77);
            код_курєраLabel.Name = "код_курєраLabel";
            код_курєраLabel.Size = new System.Drawing.Size(86, 17);
            код_курєраLabel.TabIndex = 1;
            код_курєраLabel.Text = "Код курєра:";
            // 
            // код_курєраTextBox
            // 
            this.код_курєраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кур_єрBindingSource, "Код_курєра", true));
            this.код_курєраTextBox.Location = new System.Drawing.Point(150, 74);
            this.код_курєраTextBox.Name = "код_курєраTextBox";
            this.код_курєраTextBox.Size = new System.Drawing.Size(139, 22);
            this.код_курєраTextBox.TabIndex = 2;
            // 
            // імя_курєраLabel
            // 
            імя_курєраLabel.AutoSize = true;
            імя_курєраLabel.Location = new System.Drawing.Point(62, 121);
            імя_курєраLabel.Name = "імя_курєраLabel";
            імя_курєраLabel.Size = new System.Drawing.Size(81, 17);
            імя_курєраLabel.TabIndex = 3;
            імя_курєраLabel.Text = "Імя курєра:";
            // 
            // імя_курєраTextBox
            // 
            this.імя_курєраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кур_єрBindingSource, "Імя_курєра", true));
            this.імя_курєраTextBox.Location = new System.Drawing.Point(149, 118);
            this.імя_курєраTextBox.Name = "імя_курєраTextBox";
            this.імя_курєраTextBox.Size = new System.Drawing.Size(140, 22);
            this.імя_курєраTextBox.TabIndex = 4;
            // 
            // телефон_курєраLabel
            // 
            телефон_курєраLabel.AutoSize = true;
            телефон_курєраLabel.Location = new System.Drawing.Point(62, 164);
            телефон_курєраLabel.Name = "телефон_курєраLabel";
            телефон_курєраLabel.Size = new System.Drawing.Size(121, 17);
            телефон_курєраLabel.TabIndex = 5;
            телефон_курєраLabel.Text = "Телефон курєра:";
            // 
            // телефон_курєраTextBox
            // 
            this.телефон_курєраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кур_єрBindingSource, "Телефон_курєра", true));
            this.телефон_курєраTextBox.Location = new System.Drawing.Point(189, 161);
            this.телефон_курєраTextBox.Name = "телефон_курєраTextBox";
            this.телефон_курєраTextBox.Size = new System.Drawing.Size(100, 22);
            this.телефон_курєраTextBox.TabIndex = 6;
            // 
            // Courier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(телефон_курєраLabel);
            this.Controls.Add(this.телефон_курєраTextBox);
            this.Controls.Add(імя_курєраLabel);
            this.Controls.Add(this.імя_курєраTextBox);
            this.Controls.Add(код_курєраLabel);
            this.Controls.Add(this.код_курєраTextBox);
            this.Controls.Add(this.кур_єрBindingNavigator);
            this.Name = "Courier";
            this.Text = "Courier";
            this.Load += new System.EventHandler(this.Courier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pIS_BD_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кур_єрBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кур_єрBindingNavigator)).EndInit();
            this.кур_єрBindingNavigator.ResumeLayout(false);
            this.кур_єрBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PIS_BD_2DataSet pIS_BD_2DataSet;
        private System.Windows.Forms.BindingSource кур_єрBindingSource;
        private PIS_BD_2DataSetTableAdapters.Кур_єрTableAdapter кур_єрTableAdapter;
        private PIS_BD_2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator кур_єрBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton кур_єрBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_курєраTextBox;
        private System.Windows.Forms.TextBox імя_курєраTextBox;
        private System.Windows.Forms.TextBox телефон_курєраTextBox;
    }
}