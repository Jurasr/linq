namespace _20200721_Assignment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.robotDataBaseDataSet = new _20200721_Assignment.RobotDataBaseDataSet();
            this.uzsakymaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uzsakymaiTableAdapter = new _20200721_Assignment.RobotDataBaseDataSetTableAdapters.UzsakymaiTableAdapter();
            this.tableAdapterManager = new _20200721_Assignment.RobotDataBaseDataSetTableAdapters.TableAdapterManager();
            this.uzsakymaiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.uzsakymaiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.OrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.SearchByCodeButton = new System.Windows.Forms.Button();
            this.DataGridViewData = new System.Windows.Forms.DataGridView();
            this.SearchByDateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.robotDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymaiBindingNavigator)).BeginInit();
            this.uzsakymaiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // robotDataBaseDataSet
            // 
            this.robotDataBaseDataSet.DataSetName = "RobotDataBaseDataSet";
            this.robotDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uzsakymaiBindingSource
            // 
            this.uzsakymaiBindingSource.DataMember = "Uzsakymai";
            this.uzsakymaiBindingSource.DataSource = this.robotDataBaseDataSet;
            // 
            // uzsakymaiTableAdapter
            // 
            this.uzsakymaiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvariniaiPranesimaiTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DrawingInDBTableAdapter = null;
            this.tableAdapterManager.LINESQLTableAdapter = null;
            this.tableAdapterManager.SheetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _20200721_Assignment.RobotDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UzsakymaiTableAdapter = this.uzsakymaiTableAdapter;
            // 
            // uzsakymaiBindingNavigator
            // 
            this.uzsakymaiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uzsakymaiBindingNavigator.BindingSource = this.uzsakymaiBindingSource;
            this.uzsakymaiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uzsakymaiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uzsakymaiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uzsakymaiBindingNavigatorSaveItem});
            this.uzsakymaiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uzsakymaiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uzsakymaiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uzsakymaiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uzsakymaiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uzsakymaiBindingNavigator.Name = "uzsakymaiBindingNavigator";
            this.uzsakymaiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uzsakymaiBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.uzsakymaiBindingNavigator.TabIndex = 0;
            this.uzsakymaiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // uzsakymaiBindingNavigatorSaveItem
            // 
            this.uzsakymaiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uzsakymaiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uzsakymaiBindingNavigatorSaveItem.Image")));
            this.uzsakymaiBindingNavigatorSaveItem.Name = "uzsakymaiBindingNavigatorSaveItem";
            this.uzsakymaiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uzsakymaiBindingNavigatorSaveItem.Text = "Save Data";
            this.uzsakymaiBindingNavigatorSaveItem.Click += new System.EventHandler(this.uzsakymaiBindingNavigatorSaveItem_Click);
            // 
            // OrderNumberTextBox
            // 
            this.OrderNumberTextBox.Location = new System.Drawing.Point(121, 45);
            this.OrderNumberTextBox.Name = "OrderNumberTextBox";
            this.OrderNumberTextBox.Size = new System.Drawing.Size(149, 20);
            this.OrderNumberTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uzsakymo kodas:";
            // 
            // DateTimeFrom
            // 
            this.DateTimeFrom.Location = new System.Drawing.Point(88, 75);
            this.DateTimeFrom.Name = "DateTimeFrom";
            this.DateTimeFrom.Size = new System.Drawing.Size(200, 20);
            this.DateTimeFrom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "nuo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "iki";
            // 
            // DateTimeTo
            // 
            this.DateTimeTo.Location = new System.Drawing.Point(323, 75);
            this.DateTimeTo.Name = "DateTimeTo";
            this.DateTimeTo.Size = new System.Drawing.Size(200, 20);
            this.DateTimeTo.TabIndex = 9;
            // 
            // SearchByCodeButton
            // 
            this.SearchByCodeButton.Location = new System.Drawing.Point(289, 41);
            this.SearchByCodeButton.Name = "SearchByCodeButton";
            this.SearchByCodeButton.Size = new System.Drawing.Size(75, 20);
            this.SearchByCodeButton.TabIndex = 11;
            this.SearchByCodeButton.Text = "Ieškoti";
            this.SearchByCodeButton.UseVisualStyleBackColor = true;
            this.SearchByCodeButton.Click += new System.EventHandler(this.SearchByCodeButton_Click);
            // 
            // DataGridViewData
            // 
            this.DataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewData.Location = new System.Drawing.Point(27, 140);
            this.DataGridViewData.Name = "DataGridViewData";
            this.DataGridViewData.Size = new System.Drawing.Size(761, 298);
            this.DataGridViewData.TabIndex = 12;
            // 
            // SearchByDateButton
            // 
            this.SearchByDateButton.Location = new System.Drawing.Point(538, 74);
            this.SearchByDateButton.Name = "SearchByDateButton";
            this.SearchByDateButton.Size = new System.Drawing.Size(75, 20);
            this.SearchByDateButton.TabIndex = 13;
            this.SearchByDateButton.Text = "Ieškoti";
            this.SearchByDateButton.UseVisualStyleBackColor = true;
            this.SearchByDateButton.Click += new System.EventHandler(this.SearchByDateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rasta gaminių:";
            // 
            // TotalCountLabel
            // 
            this.TotalCountLabel.AutoSize = true;
            this.TotalCountLabel.Location = new System.Drawing.Point(108, 111);
            this.TotalCountLabel.Name = "TotalCountLabel";
            this.TotalCountLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalCountLabel.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalCountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchByDateButton);
            this.Controls.Add(this.DataGridViewData);
            this.Controls.Add(this.SearchByCodeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateTimeTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTimeFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderNumberTextBox);
            this.Controls.Add(this.uzsakymaiBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.robotDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uzsakymaiBindingNavigator)).EndInit();
            this.uzsakymaiBindingNavigator.ResumeLayout(false);
            this.uzsakymaiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RobotDataBaseDataSet robotDataBaseDataSet;
        private System.Windows.Forms.BindingSource uzsakymaiBindingSource;
        private RobotDataBaseDataSetTableAdapters.UzsakymaiTableAdapter uzsakymaiTableAdapter;
        private RobotDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uzsakymaiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uzsakymaiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox OrderNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateTimeTo;
        private System.Windows.Forms.Button SearchByCodeButton;
        private System.Windows.Forms.DataGridView DataGridViewData;
        private System.Windows.Forms.Button SearchByDateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalCountLabel;
    }
}

