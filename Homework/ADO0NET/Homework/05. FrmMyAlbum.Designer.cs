namespace ADO0NET.Homework
{
    partial class FrmMyAlbum
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
            System.Windows.Forms.Label photoIDLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label photoNameLabel;
            System.Windows.Forms.Label pictureLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label categoryIDLabel1;
            System.Windows.Forms.Label categoryNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMyAlbum));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.categoryIDTextBox1 = new System.Windows.Forms.TextBox();
            this.photoCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myAlbumDataSet = new ADO0NET.MyAlbumDataSet();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.photoCategoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.photoCategoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.photoCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.photoIDTextBox = new System.Windows.Forms.TextBox();
            this.photosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryIDTextBox = new System.Windows.Forms.TextBox();
            this.photoNameTextBox = new System.Windows.Forms.TextBox();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.photosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoCategoryTableAdapter = new ADO0NET.MyAlbumDataSetTableAdapters.PhotoCategoryTableAdapter();
            this.tableAdapterManager = new ADO0NET.MyAlbumDataSetTableAdapters.TableAdapterManager();
            this.photosTableAdapter = new ADO0NET.MyAlbumDataSetTableAdapters.PhotosTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            photoIDLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            photoNameLabel = new System.Windows.Forms.Label();
            pictureLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            categoryIDLabel1 = new System.Windows.Forms.Label();
            categoryNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryBindingNavigator)).BeginInit();
            this.photoCategoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // photoIDLabel
            // 
            photoIDLabel.AutoSize = true;
            photoIDLabel.Location = new System.Drawing.Point(30, 73);
            photoIDLabel.Name = "photoIDLabel";
            photoIDLabel.Size = new System.Drawing.Size(50, 12);
            photoIDLabel.TabIndex = 3;
            photoIDLabel.Text = "Photo ID:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(30, 101);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(66, 12);
            categoryIDLabel.TabIndex = 5;
            categoryIDLabel.Text = "Category ID:";
            // 
            // photoNameLabel
            // 
            photoNameLabel.AutoSize = true;
            photoNameLabel.Location = new System.Drawing.Point(30, 129);
            photoNameLabel.Name = "photoNameLabel";
            photoNameLabel.Size = new System.Drawing.Size(65, 12);
            photoNameLabel.TabIndex = 7;
            photoNameLabel.Text = "Photo Name:";
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new System.Drawing.Point(369, 52);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(40, 12);
            pictureLabel.TabIndex = 9;
            pictureLabel.Text = "Picture:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(30, 157);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 12);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(30, 186);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(29, 12);
            dateLabel.TabIndex = 13;
            dateLabel.Text = "Date:";
            // 
            // categoryIDLabel1
            // 
            categoryIDLabel1.AutoSize = true;
            categoryIDLabel1.Location = new System.Drawing.Point(18, 76);
            categoryIDLabel1.Name = "categoryIDLabel1";
            categoryIDLabel1.Size = new System.Drawing.Size(66, 12);
            categoryIDLabel1.TabIndex = 3;
            categoryIDLabel1.Text = "Category ID:";
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Location = new System.Drawing.Point(18, 104);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new System.Drawing.Size(81, 12);
            categoryNameLabel.TabIndex = 5;
            categoryNameLabel.Text = "Category Name:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(978, 586);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "My Album";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(978, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(970, 459);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Review Photo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer4.Size = new System.Drawing.Size(970, 459);
            this.splitContainer4.SplitterDistance = 143;
            this.splitContainer4.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(143, 459);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(823, 459);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(970, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Picture";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel3);
            this.splitContainer2.Size = new System.Drawing.Size(964, 453);
            this.splitContainer2.SplitterDistance = 116;
            this.splitContainer2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Folder...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 31);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(964, 333);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(970, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tools";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer5.Size = new System.Drawing.Size(964, 453);
            this.splitContainer5.SplitterDistance = 66;
            this.splitContainer5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Photo Management";
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.splitContainer7);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer6.Size = new System.Drawing.Size(964, 383);
            this.splitContainer6.SplitterDistance = 294;
            this.splitContainer6.TabIndex = 0;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.AutoScroll = true;
            this.splitContainer7.Panel1.Controls.Add(categoryIDLabel1);
            this.splitContainer7.Panel1.Controls.Add(this.categoryIDTextBox1);
            this.splitContainer7.Panel1.Controls.Add(categoryNameLabel);
            this.splitContainer7.Panel1.Controls.Add(this.categoryNameTextBox);
            this.splitContainer7.Panel1.Controls.Add(this.photoCategoryBindingNavigator);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.photoCategoryDataGridView);
            this.splitContainer7.Size = new System.Drawing.Size(294, 383);
            this.splitContainer7.SplitterDistance = 207;
            this.splitContainer7.TabIndex = 0;
            // 
            // categoryIDTextBox1
            // 
            this.categoryIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoCategoryBindingSource, "CategoryID", true));
            this.categoryIDTextBox1.Location = new System.Drawing.Point(105, 73);
            this.categoryIDTextBox1.Name = "categoryIDTextBox1";
            this.categoryIDTextBox1.Size = new System.Drawing.Size(100, 22);
            this.categoryIDTextBox1.TabIndex = 4;
            // 
            // photoCategoryBindingSource
            // 
            this.photoCategoryBindingSource.DataMember = "PhotoCategory";
            this.photoCategoryBindingSource.DataSource = this.myAlbumDataSet;
            // 
            // myAlbumDataSet
            // 
            this.myAlbumDataSet.DataSetName = "MyAlbumDataSet";
            this.myAlbumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoCategoryBindingSource, "CategoryName", true));
            this.categoryNameTextBox.Location = new System.Drawing.Point(105, 101);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.categoryNameTextBox.TabIndex = 6;
            // 
            // photoCategoryBindingNavigator
            // 
            this.photoCategoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.photoCategoryBindingNavigator.BindingSource = this.photoCategoryBindingSource;
            this.photoCategoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.photoCategoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.photoCategoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.photoCategoryBindingNavigatorSaveItem});
            this.photoCategoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.photoCategoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.photoCategoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.photoCategoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.photoCategoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.photoCategoryBindingNavigator.Name = "photoCategoryBindingNavigator";
            this.photoCategoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.photoCategoryBindingNavigator.Size = new System.Drawing.Size(294, 25);
            this.photoCategoryBindingNavigator.TabIndex = 3;
            this.photoCategoryBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
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
            // photoCategoryBindingNavigatorSaveItem
            // 
            this.photoCategoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.photoCategoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("photoCategoryBindingNavigatorSaveItem.Image")));
            this.photoCategoryBindingNavigatorSaveItem.Name = "photoCategoryBindingNavigatorSaveItem";
            this.photoCategoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.photoCategoryBindingNavigatorSaveItem.Text = "儲存資料";
            // 
            // photoCategoryDataGridView
            // 
            this.photoCategoryDataGridView.AutoGenerateColumns = false;
            this.photoCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.photoCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.photoCategoryDataGridView.DataSource = this.photoCategoryBindingSource;
            this.photoCategoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photoCategoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.photoCategoryDataGridView.Name = "photoCategoryDataGridView";
            this.photoCategoryDataGridView.RowTemplate.Height = 24;
            this.photoCategoryDataGridView.Size = new System.Drawing.Size(294, 172);
            this.photoCategoryDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CategoryName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AutoScroll = true;
            this.splitContainer3.Panel1.Controls.Add(this.button2);
            this.splitContainer3.Panel1.Controls.Add(photoIDLabel);
            this.splitContainer3.Panel1.Controls.Add(this.photoIDTextBox);
            this.splitContainer3.Panel1.Controls.Add(categoryIDLabel);
            this.splitContainer3.Panel1.Controls.Add(this.categoryIDTextBox);
            this.splitContainer3.Panel1.Controls.Add(photoNameLabel);
            this.splitContainer3.Panel1.Controls.Add(this.photoNameTextBox);
            this.splitContainer3.Panel1.Controls.Add(pictureLabel);
            this.splitContainer3.Panel1.Controls.Add(this.picturePictureBox);
            this.splitContainer3.Panel1.Controls.Add(descriptionLabel);
            this.splitContainer3.Panel1.Controls.Add(this.descriptionTextBox);
            this.splitContainer3.Panel1.Controls.Add(dateLabel);
            this.splitContainer3.Panel1.Controls.Add(this.dateDateTimePicker);
            this.splitContainer3.Panel1.Controls.Add(this.bindingNavigator1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Panel2.Controls.Add(this.photosDataGridView);
            this.splitContainer3.Size = new System.Drawing.Size(666, 383);
            this.splitContainer3.SplitterDistance = 205;
            this.splitContainer3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Browser...\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // photoIDTextBox
            // 
            this.photoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "PhotoID", true));
            this.photoIDTextBox.Location = new System.Drawing.Point(102, 70);
            this.photoIDTextBox.Name = "photoIDTextBox";
            this.photoIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.photoIDTextBox.TabIndex = 4;
            // 
            // photosBindingSource
            // 
            this.photosBindingSource.DataMember = "Photos";
            this.photosBindingSource.DataSource = this.myAlbumDataSet;
            // 
            // categoryIDTextBox
            // 
            this.categoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "CategoryID", true));
            this.categoryIDTextBox.Location = new System.Drawing.Point(102, 98);
            this.categoryIDTextBox.Name = "categoryIDTextBox";
            this.categoryIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.categoryIDTextBox.TabIndex = 6;
            // 
            // photoNameTextBox
            // 
            this.photoNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "PhotoName", true));
            this.photoNameTextBox.Location = new System.Drawing.Point(102, 126);
            this.photoNameTextBox.Name = "photoNameTextBox";
            this.photoNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.photoNameTextBox.TabIndex = 8;
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photosBindingSource, "Picture", true));
            this.picturePictureBox.Location = new System.Drawing.Point(371, 73);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(218, 138);
            this.picturePictureBox.TabIndex = 10;
            this.picturePictureBox.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(102, 154);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.photosBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(102, 182);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateDateTimePicker.TabIndex = 14;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BindingSource = this.photosBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(649, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "加入新的";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(27, 22);
            this.toolStripLabel1.Text = "/{0}";
            this.toolStripLabel1.ToolTipText = "項目總數";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "刪除";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到最前面";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到上一個";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "目前的位置";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "移到下一個";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "移到最後面";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // photosDataGridView
            // 
            this.photosDataGridView.AutoGenerateColumns = false;
            this.photosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.photosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.photosDataGridView.DataSource = this.photosBindingSource;
            this.photosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.photosDataGridView.Name = "photosDataGridView";
            this.photosDataGridView.RowTemplate.Height = 24;
            this.photosDataGridView.Size = new System.Drawing.Size(666, 174);
            this.photosDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PhotoID";
            this.dataGridViewTextBoxColumn3.HeaderText = "PhotoID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn4.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PhotoName";
            this.dataGridViewTextBoxColumn5.HeaderText = "PhotoName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // photoCategoryTableAdapter
            // 
            this.photoCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PhotoCategoryTableAdapter = this.photoCategoryTableAdapter;
            this.tableAdapterManager.PhotosTableAdapter = this.photosTableAdapter;
            this.tableAdapterManager.UpdateOrder = ADO0NET.MyAlbumDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // photosTableAdapter
            // 
            this.photosTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 586);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryBindingNavigator)).EndInit();
            this.photoCategoryBindingNavigator.ResumeLayout(false);
            this.photoCategoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryDataGridView)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage tabPage3;
        private MyAlbumDataSet myAlbumDataSet;
        private System.Windows.Forms.BindingSource photoCategoryBindingSource;
        private MyAlbumDataSetTableAdapters.PhotoCategoryTableAdapter photoCategoryTableAdapter;
        private MyAlbumDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.BindingNavigator photoCategoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton photoCategoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView photoCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private MyAlbumDataSetTableAdapters.PhotosTableAdapter photosTableAdapter;
        private System.Windows.Forms.BindingSource photosBindingSource;
        private System.Windows.Forms.DataGridView photosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox photoIDTextBox;
        private System.Windows.Forms.TextBox categoryIDTextBox;
        private System.Windows.Forms.TextBox photoNameTextBox;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox categoryIDTextBox1;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}