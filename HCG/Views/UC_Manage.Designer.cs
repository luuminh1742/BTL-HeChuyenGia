
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.tpRules = new System.Windows.Forms.TabPage();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.tpEvent = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tpRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            this.tpEvent.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tcManage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcManage.Name = "tcManage";
            this.tcManage.SelectedIndex = 0;
            this.tcManage.Size = new System.Drawing.Size(1383, 810);
            this.tcManage.TabIndex = 0;
            // 
            // tpProduct
            // 
            this.tpProduct.Controls.Add(this.dgvProduct);
            this.tpProduct.Location = new System.Drawing.Point(4, 34);
            this.tpProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpProduct.Size = new System.Drawing.Size(1375, 772);
            this.tpProduct.TabIndex = 0;
            this.tpProduct.Text = "Sản phẩm";
            this.tpProduct.UseVisualStyleBackColor = true;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(4, 4);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1367, 764);
            this.dgvProduct.TabIndex = 0;
            // 
            // tpRules
            // 
            this.tpRules.Controls.Add(this.dgvRules);
            this.tpRules.Location = new System.Drawing.Point(4, 34);
            this.tpRules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpRules.Size = new System.Drawing.Size(1375, 772);
            this.tpRules.TabIndex = 1;
            this.tpRules.Text = "Tập luật";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // dgvRules
            // 
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRules.Location = new System.Drawing.Point(4, 4);
            this.dgvRules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.RowHeadersWidth = 51;
            this.dgvRules.Size = new System.Drawing.Size(1367, 764);
            this.dgvRules.TabIndex = 0;
            // 
            // tpEvent
            // 
            this.tpEvent.Controls.Add(this.flowLayoutPanel1);
            this.tpEvent.Location = new System.Drawing.Point(4, 34);
            this.tpEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpEvent.Name = "tpEvent";
            this.tpEvent.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpEvent.Size = new System.Drawing.Size(1375, 772);
            this.tpEvent.TabIndex = 2;
            this.tpEvent.Text = "Sự kiện";
            this.tpEvent.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1367, 764);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 761);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sự kiện";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1302, 705);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhóm luật";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(781, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "Luật";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "1. Giới tính sử dụng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "2. Đối tượng sử dụng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "3. Mục đích chính sử dụng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "4. Khoảng giá tiền có thể mua";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "5. Hãng điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 595);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "6. Mầu sắc yêu thích";
            // 
            // lbGD
            // 
            this.lbGD.AutoSize = true;
            this.lbGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGD.Location = new System.Drawing.Point(516, 45);
            this.lbGD.Name = "lbGD";
            this.lbGD.Size = new System.Drawing.Size(781, 108);
            this.lbGD.TabIndex = 2;
            this.lbGD.Text = "label10";
            // 
            // lbOU
            // 
            this.lbOU.AutoSize = true;
            this.lbOU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOU.Location = new System.Drawing.Point(516, 155);
            this.lbOU.Name = "lbOU";
            this.lbOU.Size = new System.Drawing.Size(781, 108);
            this.lbOU.TabIndex = 2;
            this.lbOU.Text = "label10";
            // 
            // lbPP
            // 
            this.lbPP.AutoSize = true;
            this.lbPP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPP.Location = new System.Drawing.Point(516, 265);
            this.lbPP.Name = "lbPP";
            this.lbPP.Size = new System.Drawing.Size(781, 108);
            this.lbPP.TabIndex = 2;
            this.lbPP.Text = "label10";
            // 
            // lbPR
            // 
            this.lbPR.AutoSize = true;
            this.lbPR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPR.Location = new System.Drawing.Point(516, 375);
            this.lbPR.Name = "lbPR";
            this.lbPR.Size = new System.Drawing.Size(781, 108);
            this.lbPR.TabIndex = 2;
            this.lbPR.Text = "label10";
            // 
            // lbBR
            // 
            this.lbBR.AutoSize = true;
            this.lbBR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBR.Location = new System.Drawing.Point(516, 485);
            this.lbBR.Name = "lbBR";
            this.lbBR.Size = new System.Drawing.Size(781, 108);
            this.lbBR.TabIndex = 2;
            this.lbBR.Text = "label10";
            // 
            // lbCL
            // 
            this.lbCL.AutoSize = true;
            this.lbCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCL.Location = new System.Drawing.Point(516, 595);
            this.lbCL.Name = "lbCL";
            this.lbCL.Size = new System.Drawing.Size(781, 108);
            this.lbCL.TabIndex = 2;
            this.lbCL.Text = "label10";
            // 
            // UC_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcManage);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Manage";
            this.Size = new System.Drawing.Size(1383, 810);
            this.Load += new System.EventHandler(this.UC_Manage_Load);
            this.tcManage.ResumeLayout(false);
            this.tpProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tpRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            this.tpEvent.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbGD;
        private System.Windows.Forms.Label lbOU;
        private System.Windows.Forms.Label lbPP;
        private System.Windows.Forms.Label lbPR;
        private System.Windows.Forms.Label lbBR;
        private System.Windows.Forms.Label lbCL;
    }
}
