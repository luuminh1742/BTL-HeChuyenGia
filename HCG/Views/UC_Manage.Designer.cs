
namespace HCG.Views
{
    partial class UC_Manage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcManage = new System.Windows.Forms.TabControl();
            this.tpProduct = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnInsertProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtCamera = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tpRules = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.btnUpdateRule = new System.Windows.Forms.Button();
            this.btnInsertRule = new System.Windows.Forms.Button();
            this.txtRuleRight = new System.Windows.Forms.TextBox();
            this.txtRuleLeft = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tpEvent = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnEvent = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbGD = new System.Windows.Forms.Label();
            this.lbOU = new System.Windows.Forms.Label();
            this.lbPP = new System.Windows.Forms.Label();
            this.lbPR = new System.Windows.Forms.Label();
            this.lbBR = new System.Windows.Forms.Label();
            this.lbCL = new System.Windows.Forms.Label();
            this.tcManage.SuspendLayout();
            this.tpProduct.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpRules.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            this.panel3.SuspendLayout();
            this.tpEvent.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnEvent.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcManage
            // 
            this.tcManage.Controls.Add(this.tpProduct);
            this.tcManage.Controls.Add(this.tpRules);
            this.tcManage.Controls.Add(this.tpEvent);
            this.tcManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcManage.Location = new System.Drawing.Point(0, 0);
            this.tcManage.Name = "tcManage";
            this.tcManage.SelectedIndex = 0;
            this.tcManage.Size = new System.Drawing.Size(1037, 658);
            this.tcManage.TabIndex = 0;
            // 
            // tpProduct
            // 
            this.tpProduct.Controls.Add(this.panel2);
            this.tpProduct.Controls.Add(this.panel1);
            this.tpProduct.Location = new System.Drawing.Point(4, 29);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpProduct.Size = new System.Drawing.Size(1029, 625);
            this.tpProduct.TabIndex = 0;
            this.tpProduct.Text = "Sản phẩm";
            this.tpProduct.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 428);
            this.panel2.TabIndex = 2;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1023, 428);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemoveProduct);
            this.panel1.Controls.Add(this.btnUpdateProduct);
            this.panel1.Controls.Add(this.btnInsertProduct);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 191);
            this.panel1.TabIndex = 1;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(417, 151);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(183, 34);
            this.btnRemoveProduct.TabIndex = 13;
            this.btnRemoveProduct.Text = "Xóa sản phẩm";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(194, 151);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(199, 34);
            this.btnUpdateProduct.TabIndex = 12;
            this.btnUpdateProduct.Text = "Cập nhật sản phẩm";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnInsertProduct
            // 
            this.btnInsertProduct.Location = new System.Drawing.Point(10, 150);
            this.btnInsertProduct.Name = "btnInsertProduct";
            this.btnInsertProduct.Size = new System.Drawing.Size(160, 35);
            this.btnInsertProduct.TabIndex = 11;
            this.btnInsertProduct.Text = "Thêm sản phẩm";
            this.btnInsertProduct.UseVisualStyleBackColor = true;
            this.btnInsertProduct.Click += new System.EventHandler(this.btnInsertProduct_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtOS, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtStorage, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtRam, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtCamera, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label16, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.label17, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBrand, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtScreen, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtPrice, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtColor, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label15, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1017, 141);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(881, 97);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(122, 26);
            this.txtOS.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Price";
            // 
            // txtStorage
            // 
            this.txtStorage.Location = new System.Drawing.Point(881, 50);
            this.txtStorage.Name = "txtStorage";
            this.txtStorage.Size = new System.Drawing.Size(122, 26);
            this.txtStorage.TabIndex = 8;
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(470, 97);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(210, 26);
            this.txtRam.TabIndex = 6;
            // 
            // txtCamera
            // 
            this.txtCamera.Location = new System.Drawing.Point(881, 3);
            this.txtCamera.Name = "txtCamera";
            this.txtCamera.Size = new System.Drawing.Size(122, 26);
            this.txtCamera.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Brand";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(724, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Operating system";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(724, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Storage";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(105, 97);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(210, 26);
            this.txtBrand.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 26);
            this.txtName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(724, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Camera";
            // 
            // txtScreen
            // 
            this.txtScreen.Location = new System.Drawing.Point(470, 50);
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.Size = new System.Drawing.Size(210, 26);
            this.txtScreen.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(105, 50);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(210, 26);
            this.txtPrice.TabIndex = 2;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(470, 3);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(210, 26);
            this.txtColor.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(369, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Color";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(369, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Screen";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(369, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ram";
            // 
            // tpRules
            // 
            this.tpRules.Controls.Add(this.panel4);
            this.tpRules.Controls.Add(this.panel3);
            this.tpRules.Location = new System.Drawing.Point(4, 29);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(3);
            this.tpRules.Size = new System.Drawing.Size(1029, 625);
            this.tpRules.TabIndex = 1;
            this.tpRules.Text = "Tập luật";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvRules);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 188);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1023, 434);
            this.panel4.TabIndex = 2;
            // 
            // dgvRules
            // 
            this.dgvRules.BackgroundColor = System.Drawing.Color.White;
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRules.Location = new System.Drawing.Point(0, 0);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.RowHeadersWidth = 51;
            this.dgvRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRules.Size = new System.Drawing.Size(1023, 434);
            this.dgvRules.TabIndex = 0;
            this.dgvRules.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRules_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeleteRule);
            this.panel3.Controls.Add(this.btnUpdateRule);
            this.panel3.Controls.Add(this.btnInsertRule);
            this.panel3.Controls.Add(this.txtRuleRight);
            this.panel3.Controls.Add(this.txtRuleLeft);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1023, 185);
            this.panel3.TabIndex = 1;
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Location = new System.Drawing.Point(370, 126);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(153, 37);
            this.btnDeleteRule.TabIndex = 5;
            this.btnDeleteRule.Text = "Xóa luật";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // btnUpdateRule
            // 
            this.btnUpdateRule.Location = new System.Drawing.Point(198, 126);
            this.btnUpdateRule.Name = "btnUpdateRule";
            this.btnUpdateRule.Size = new System.Drawing.Size(138, 37);
            this.btnUpdateRule.TabIndex = 4;
            this.btnUpdateRule.Text = "Cập nhật luật";
            this.btnUpdateRule.UseVisualStyleBackColor = true;
            this.btnUpdateRule.Click += new System.EventHandler(this.btnUpdateRule_Click);
            // 
            // btnInsertRule
            // 
            this.btnInsertRule.Location = new System.Drawing.Point(19, 126);
            this.btnInsertRule.Name = "btnInsertRule";
            this.btnInsertRule.Size = new System.Drawing.Size(145, 37);
            this.btnInsertRule.TabIndex = 3;
            this.btnInsertRule.Text = "Thêm luật";
            this.btnInsertRule.UseVisualStyleBackColor = true;
            this.btnInsertRule.Click += new System.EventHandler(this.btnInsertRule_Click);
            // 
            // txtRuleRight
            // 
            this.txtRuleRight.Location = new System.Drawing.Point(211, 59);
            this.txtRuleRight.Name = "txtRuleRight";
            this.txtRuleRight.Size = new System.Drawing.Size(232, 26);
            this.txtRuleRight.TabIndex = 2;
            // 
            // txtRuleLeft
            // 
            this.txtRuleLeft.Location = new System.Drawing.Point(211, 19);
            this.txtRuleLeft.Name = "txtRuleLeft";
            this.txtRuleLeft.Size = new System.Drawing.Size(232, 26);
            this.txtRuleLeft.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(94, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Vế phải";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(94, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Vế trái";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Luật";
            // 
            // tpEvent
            // 
            this.tpEvent.Controls.Add(this.flowLayoutPanel1);
            this.tpEvent.Location = new System.Drawing.Point(4, 29);
            this.tpEvent.Name = "tpEvent";
            this.tpEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tpEvent.Size = new System.Drawing.Size(1029, 625);
            this.tpEvent.TabIndex = 2;
            this.tpEvent.Text = "Sự kiện";
            this.tpEvent.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pnEvent);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1023, 619);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // pnEvent
            // 
            this.pnEvent.Controls.Add(this.tableLayoutPanel1);
            this.pnEvent.Location = new System.Drawing.Point(2, 2);
            this.pnEvent.Margin = new System.Windows.Forms.Padding(2);
            this.pnEvent.Name = "pnEvent";
            this.pnEvent.Size = new System.Drawing.Size(1005, 618);
            this.pnEvent.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.32203F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.67797F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbGD, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbOU, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbPP, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbPR, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbBR, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbCL, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 618);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhóm luật";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "1. Giới tính sử dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(603, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Luật";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "2. Đối tượng sử dụng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "3. Mục đích chính sử dụng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 325);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "4. Khoảng giá tiền có thể mua";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 421);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "5. Hãng điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 517);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "6. Mầu sắc yêu thích";
            // 
            // lbGD
            // 
            this.lbGD.AutoSize = true;
            this.lbGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGD.Location = new System.Drawing.Point(398, 37);
            this.lbGD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGD.Name = "lbGD";
            this.lbGD.Size = new System.Drawing.Size(603, 94);
            this.lbGD.TabIndex = 2;
            this.lbGD.Text = "label10";
            // 
            // lbOU
            // 
            this.lbOU.AutoSize = true;
            this.lbOU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOU.Location = new System.Drawing.Point(398, 133);
            this.lbOU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOU.Name = "lbOU";
            this.lbOU.Size = new System.Drawing.Size(603, 94);
            this.lbOU.TabIndex = 2;
            this.lbOU.Text = "label10";
            // 
            // lbPP
            // 
            this.lbPP.AutoSize = true;
            this.lbPP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPP.Location = new System.Drawing.Point(398, 229);
            this.lbPP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPP.Name = "lbPP";
            this.lbPP.Size = new System.Drawing.Size(603, 94);
            this.lbPP.TabIndex = 2;
            this.lbPP.Text = "label10";
            // 
            // lbPR
            // 
            this.lbPR.AutoSize = true;
            this.lbPR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPR.Location = new System.Drawing.Point(398, 325);
            this.lbPR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPR.Name = "lbPR";
            this.lbPR.Size = new System.Drawing.Size(603, 94);
            this.lbPR.TabIndex = 2;
            this.lbPR.Text = "label10";
            // 
            // lbBR
            // 
            this.lbBR.AutoSize = true;
            this.lbBR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBR.Location = new System.Drawing.Point(398, 421);
            this.lbBR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBR.Name = "lbBR";
            this.lbBR.Size = new System.Drawing.Size(603, 94);
            this.lbBR.TabIndex = 2;
            this.lbBR.Text = "label10";
            // 
            // lbCL
            // 
            this.lbCL.AutoSize = true;
            this.lbCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCL.Location = new System.Drawing.Point(398, 517);
            this.lbCL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCL.Name = "lbCL";
            this.lbCL.Size = new System.Drawing.Size(603, 99);
            this.lbCL.TabIndex = 2;
            this.lbCL.Text = "label10";
            // 
            // UC_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcManage);
            this.Name = "UC_Manage";
            this.Size = new System.Drawing.Size(1037, 658);
            this.Load += new System.EventHandler(this.UC_Manage_Load);
            this.tcManage.ResumeLayout(false);
            this.tpProduct.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tpRules.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpEvent.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnEvent.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManage;
        private System.Windows.Forms.TabPage tpProduct;
        private System.Windows.Forms.TabPage tpRules;
        private System.Windows.Forms.TabPage tpEvent;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridView dgvRules;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbGD;
        private System.Windows.Forms.Label lbOU;
        private System.Windows.Forms.Label lbPP;
        private System.Windows.Forms.Label lbPR;
        private System.Windows.Forms.Label lbBR;
        private System.Windows.Forms.Label lbCL;
        private System.Windows.Forms.Panel pnEvent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.TextBox txtCamera;
        private System.Windows.Forms.TextBox txtScreen;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnInsertProduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteRule;
        private System.Windows.Forms.Button btnUpdateRule;
        private System.Windows.Forms.Button btnInsertRule;
        private System.Windows.Forms.TextBox txtRuleRight;
        private System.Windows.Forms.TextBox txtRuleLeft;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
    }
}
