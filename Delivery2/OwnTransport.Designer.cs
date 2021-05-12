
namespace Delivery2
{
    partial class OwnTransport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnTransport));
            System.Windows.Forms.Label код_доставкиLabel;
            System.Windows.Forms.Label код_курєраLabel;
            System.Windows.Forms.Label ім_я_власникаLabel;
            System.Windows.Forms.Label номерний_знакLabel;
            this.pIS_BD_2DataSet = new Delivery2.PIS_BD_2DataSet();
            this.власний_транспортBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.власний_транспортTableAdapter = new Delivery2.PIS_BD_2DataSetTableAdapters.Власний_транспортTableAdapter();
            this.tableAdapterManager = new Delivery2.PIS_BD_2DataSetTableAdapters.TableAdapterManager();
            this.власний_транспортBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.власний_транспортBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_доставкиComboBox = new System.Windows.Forms.ComboBox();
            this.код_курєраComboBox = new System.Windows.Forms.ComboBox();
            this.ім_я_власникаTextBox = new System.Windows.Forms.TextBox();
            this.номерний_знакTextBox = new System.Windows.Forms.TextBox();
            this.курєрBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кур_єрTableAdapter = new Delivery2.PIS_BD_2DataSetTableAdapters.Кур_єрTableAdapter();
            this.доставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставкаTableAdapter = new Delivery2.PIS_BD_2DataSetTableAdapters.ДоставкаTableAdapter();
            код_доставкиLabel = new System.Windows.Forms.Label();
            код_курєраLabel = new System.Windows.Forms.Label();
            ім_я_власникаLabel = new System.Windows.Forms.Label();
            номерний_знакLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pIS_BD_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.власний_транспортBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.власний_транспортBindingNavigator)).BeginInit();
            this.власний_транспортBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.курєрBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pIS_BD_2DataSet
            // 
            this.pIS_BD_2DataSet.DataSetName = "PIS_BD_2DataSet";
            this.pIS_BD_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // власний_транспортBindingSource
            // 
            this.власний_транспортBindingSource.DataMember = "Власний_транспорт";
            this.власний_транспортBindingSource.DataSource = this.pIS_BD_2DataSet;
            // 
            // власний_транспортTableAdapter
            // 
            this.власний_транспортTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Delivery2.PIS_BD_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Власний_транспортTableAdapter = this.власний_транспортTableAdapter;
            this.tableAdapterManager.ДоставкаTableAdapter = this.доставкаTableAdapter;
            this.tableAdapterManager.ЗамовленняTableAdapter = null;
            this.tableAdapterManager.КлієнтTableAdapter = null;
            this.tableAdapterManager.Кур_єрTableAdapter = this.кур_єрTableAdapter;
            this.tableAdapterManager.ПродуктиTableAdapter = null;
            this.tableAdapterManager.Рядок_замволенняTableAdapter = null;
            this.tableAdapterManager.Транспорт_фірмиTableAdapter = null;
            this.tableAdapterManager.ЧекTableAdapter = null;
            // 
            // власний_транспортBindingNavigator
            // 
            this.власний_транспортBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.власний_транспортBindingNavigator.BindingSource = this.власний_транспортBindingSource;
            this.власний_транспортBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.власний_транспортBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.власний_транспортBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.власний_транспортBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.власний_транспортBindingNavigatorSaveItem});
            this.власний_транспортBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.власний_транспортBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.власний_транспортBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.власний_транспортBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.власний_транспортBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.власний_транспортBindingNavigator.Name = "власний_транспортBindingNavigator";
            this.власний_транспортBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.власний_транспортBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.власний_транспортBindingNavigator.TabIndex = 0;
            this.власний_транспортBindingNavigator.Text = "bindingNavigator1";
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
            // власний_транспортBindingNavigatorSaveItem
            // 
            this.власний_транспортBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.власний_транспортBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("власний_транспортBindingNavigatorSaveItem.Image")));
            this.власний_транспортBindingNavigatorSaveItem.Name = "власний_транспортBindingNavigatorSaveItem";
            this.власний_транспортBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.власний_транспортBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.власний_транспортBindingNavigatorSaveItem.Click += new System.EventHandler(this.власний_транспортBindingNavigatorSaveItem_Click_1);
            // 
            // код_доставкиLabel
            // 
            код_доставкиLabel.AutoSize = true;
            код_доставкиLabel.Location = new System.Drawing.Point(77, 87);
            код_доставкиLabel.Name = "код_доставкиLabel";
            код_доставкиLabel.Size = new System.Drawing.Size(101, 17);
            код_доставкиLabel.TabIndex = 1;
            код_доставкиLabel.Text = "Код доставки:";
            // 
            // код_доставкиComboBox
            // 
            this.код_доставкиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.власний_транспортBindingSource, "Код_доставки", true));
            this.код_доставкиComboBox.DataSource = this.доставкаBindingSource;
            this.код_доставкиComboBox.DisplayMember = "Код_доставки";
            this.код_доставкиComboBox.FormattingEnabled = true;
            this.код_доставкиComboBox.Location = new System.Drawing.Point(184, 84);
            this.код_доставкиComboBox.Name = "код_доставкиComboBox";
            this.код_доставкиComboBox.Size = new System.Drawing.Size(121, 24);
            this.код_доставкиComboBox.TabIndex = 2;
            this.код_доставкиComboBox.ValueMember = "Код_доставки";
            // 
            // код_курєраLabel
            // 
            код_курєраLabel.AutoSize = true;
            код_курєраLabel.Location = new System.Drawing.Point(89, 146);
            код_курєраLabel.Name = "код_курєраLabel";
            код_курєраLabel.Size = new System.Drawing.Size(86, 17);
            код_курєраLabel.TabIndex = 3;
            код_курєраLabel.Text = "Код курєра:";
            // 
            // код_курєраComboBox
            // 
            this.код_курєраComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.власний_транспортBindingSource, "Код_курєра", true));
            this.код_курєраComboBox.DataSource = this.курєрBindingSource;
            this.код_курєраComboBox.DisplayMember = "Код_курєра";
            this.код_курєраComboBox.FormattingEnabled = true;
            this.код_курєраComboBox.Location = new System.Drawing.Point(181, 143);
            this.код_курєраComboBox.Name = "код_курєраComboBox";
            this.код_курєраComboBox.Size = new System.Drawing.Size(121, 24);
            this.код_курєраComboBox.TabIndex = 4;
            this.код_курєраComboBox.ValueMember = "Код_курєра";
            // 
            // ім_я_власникаLabel
            // 
            ім_я_власникаLabel.AutoSize = true;
            ім_я_власникаLabel.Location = new System.Drawing.Point(424, 250);
            ім_я_власникаLabel.Name = "ім_я_власникаLabel";
            ім_я_власникаLabel.Size = new System.Drawing.Size(101, 17);
            ім_я_власникаLabel.TabIndex = 5;
            ім_я_власникаLabel.Text = "Ім я власника:";
            // 
            // ім_я_власникаTextBox
            // 
            this.ім_я_власникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.власний_транспортBindingSource, "Ім_я_власника", true));
            this.ім_я_власникаTextBox.Location = new System.Drawing.Point(531, 247);
            this.ім_я_власникаTextBox.Name = "ім_я_власникаTextBox";
            this.ім_я_власникаTextBox.Size = new System.Drawing.Size(100, 22);
            this.ім_я_власникаTextBox.TabIndex = 6;
            // 
            // номерний_знакLabel
            // 
            номерний_знакLabel.AutoSize = true;
            номерний_знакLabel.Location = new System.Drawing.Point(433, 321);
            номерний_знакLabel.Name = "номерний_знакLabel";
            номерний_знакLabel.Size = new System.Drawing.Size(113, 17);
            номерний_знакLabel.TabIndex = 7;
            номерний_знакLabel.Text = "Номерний знак:";
            // 
            // номерний_знакTextBox
            // 
            this.номерний_знакTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.власний_транспортBindingSource, "Номерний_знак", true));
            this.номерний_знакTextBox.Location = new System.Drawing.Point(552, 318);
            this.номерний_знакTextBox.Name = "номерний_знакTextBox";
            this.номерний_знакTextBox.Size = new System.Drawing.Size(100, 22);
            this.номерний_знакTextBox.TabIndex = 8;
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
            // OwnTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(номерний_знакLabel);
            this.Controls.Add(this.номерний_знакTextBox);
            this.Controls.Add(ім_я_власникаLabel);
            this.Controls.Add(this.ім_я_власникаTextBox);
            this.Controls.Add(код_курєраLabel);
            this.Controls.Add(this.код_курєраComboBox);
            this.Controls.Add(код_доставкиLabel);
            this.Controls.Add(this.код_доставкиComboBox);
            this.Controls.Add(this.власний_транспортBindingNavigator);
            this.Name = "OwnTransport";
            this.Text = "OwnTransport";
            this.Load += new System.EventHandler(this.OwnTransport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pIS_BD_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.власний_транспортBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.власний_транспортBindingNavigator)).EndInit();
            this.власний_транспортBindingNavigator.ResumeLayout(false);
            this.власний_транспортBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.курєрBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PIS_BD_2DataSet pIS_BD_2DataSet;
        private System.Windows.Forms.BindingSource власний_транспортBindingSource;
        private PIS_BD_2DataSetTableAdapters.Власний_транспортTableAdapter власний_транспортTableAdapter;
        private PIS_BD_2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator власний_транспортBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton власний_транспортBindingNavigatorSaveItem;
        private PIS_BD_2DataSetTableAdapters.Кур_єрTableAdapter кур_єрTableAdapter;
        private System.Windows.Forms.ComboBox код_доставкиComboBox;
        private System.Windows.Forms.ComboBox код_курєраComboBox;
        private System.Windows.Forms.TextBox ім_я_власникаTextBox;
        private System.Windows.Forms.TextBox номерний_знакTextBox;
        private System.Windows.Forms.BindingSource курєрBindingSource;
        private PIS_BD_2DataSetTableAdapters.ДоставкаTableAdapter доставкаTableAdapter;
        private System.Windows.Forms.BindingSource доставкаBindingSource;
    }
}