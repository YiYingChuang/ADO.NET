namespace ADO.NET.MyHomeWork
{
    partial class FrmAdventureWorks_CRUD
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
            System.Windows.Forms.Label largePhotoLabel;
            System.Windows.Forms.Label nameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdventureWorks_CRUD));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.productPhotoDataGridView = new System.Windows.Forms.DataGridView();
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
            this.productPhotoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productPhotoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.largePhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            largePhotoLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoBindingNavigator)).BeginInit();
            this.productPhotoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.largePhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // largePhotoLabel
            // 
            largePhotoLabel.AutoSize = true;
            largePhotoLabel.Location = new System.Drawing.Point(468, 149);
            largePhotoLabel.Name = "largePhotoLabel";
            largePhotoLabel.Size = new System.Drawing.Size(65, 12);
            largePhotoLabel.TabIndex = 56;
            largePhotoLabel.Text = "Large Photo:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(498, 115);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(35, 12);
            nameLabel1.TabIndex = 55;
            nameLabel1.Text = "Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = " 某 日期區間 的腳踏車";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "~";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(154, 42);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 22);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // productPhotoDataGridView
            // 
            this.productPhotoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productPhotoDataGridView.Location = new System.Drawing.Point(23, 97);
            this.productPhotoDataGridView.Name = "productPhotoDataGridView";
            this.productPhotoDataGridView.RowTemplate.Height = 24;
            this.productPhotoDataGridView.Size = new System.Drawing.Size(431, 259);
            this.productPhotoDataGridView.TabIndex = 20;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
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
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // productPhotoBindingNavigatorSaveItem
            // 
            this.productPhotoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productPhotoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productPhotoBindingNavigatorSaveItem.Image")));
            this.productPhotoBindingNavigatorSaveItem.Name = "productPhotoBindingNavigatorSaveItem";
            this.productPhotoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productPhotoBindingNavigatorSaveItem.Text = "儲存資料";
            // 
            // productPhotoBindingNavigator
            // 
            this.productPhotoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productPhotoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productPhotoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productPhotoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productPhotoBindingNavigatorSaveItem});
            this.productPhotoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productPhotoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productPhotoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productPhotoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productPhotoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productPhotoBindingNavigator.Name = "productPhotoBindingNavigator";
            this.productPhotoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productPhotoBindingNavigator.Size = new System.Drawing.Size(871, 25);
            this.productPhotoBindingNavigator.TabIndex = 19;
            this.productPhotoBindingNavigator.Text = "bindingNavigator1";
            // 
            // largePhotoPictureBox
            // 
            this.largePhotoPictureBox.Location = new System.Drawing.Point(539, 149);
            this.largePhotoPictureBox.Name = "largePhotoPictureBox";
            this.largePhotoPictureBox.Size = new System.Drawing.Size(179, 145);
            this.largePhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.largePhotoPictureBox.TabIndex = 58;
            this.largePhotoPictureBox.TabStop = false;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(539, 112);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox1.TabIndex = 57;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 54;
            this.button2.Text = "排序";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(562, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 52;
            this.label2.Text = "Year:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(539, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 59;
            this.button3.Text = "Browse...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(562, 70);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(170, 23);
            this.button8.TabIndex = 60;
            this.button8.Text = "動態 ORDER BY 各欄位 ???";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // FrmAdventureWorks_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 443);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(largePhotoLabel);
            this.Controls.Add(this.largePhotoPictureBox);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.productPhotoDataGridView);
            this.Controls.Add(this.productPhotoBindingNavigator);
            this.Name = "FrmAdventureWorks_CRUD";
            this.Text = "FrmAdventureWorks_CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoBindingNavigator)).EndInit();
            this.productPhotoBindingNavigator.ResumeLayout(false);
            this.productPhotoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.largePhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView productPhotoDataGridView;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton productPhotoBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator productPhotoBindingNavigator;
        private System.Windows.Forms.PictureBox largePhotoPictureBox;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
    }
}