
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
            this.tpRules = new System.Windows.Forms.TabPage();
            this.tpEvent = new System.Windows.Forms.TabPage();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.tcManage.SuspendLayout();
            this.tpProduct.SuspendLayout();
            this.tpRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
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
            this.tpProduct.Controls.Add(this.dgvProduct);
            this.tpProduct.Location = new System.Drawing.Point(4, 29);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpProduct.Size = new System.Drawing.Size(1029, 625);
            this.tpProduct.TabIndex = 0;
            this.tpProduct.Text = "Sản phẩm";
            this.tpProduct.UseVisualStyleBackColor = true;
            // 
            // tpRules
            // 
            this.tpRules.Controls.Add(this.dgvRules);
            this.tpRules.Location = new System.Drawing.Point(4, 29);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(3);
            this.tpRules.Size = new System.Drawing.Size(1029, 625);
            this.tpRules.TabIndex = 1;
            this.tpRules.Text = "Tập luật";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // tpEvent
            // 
            this.tpEvent.Location = new System.Drawing.Point(4, 29);
            this.tpEvent.Name = "tpEvent";
            this.tpEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tpEvent.Size = new System.Drawing.Size(998, 599);
            this.tpEvent.TabIndex = 2;
            this.tpEvent.Text = "Sự kiện";
            this.tpEvent.UseVisualStyleBackColor = true;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(3, 3);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(1023, 619);
            this.dgvProduct.TabIndex = 0;
            // 
            // dgvRules
            // 
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRules.Location = new System.Drawing.Point(3, 3);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.Size = new System.Drawing.Size(1023, 619);
            this.dgvRules.TabIndex = 0;
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
            this.tpRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManage;
        private System.Windows.Forms.TabPage tpProduct;
        private System.Windows.Forms.TabPage tpRules;
        private System.Windows.Forms.TabPage tpEvent;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridView dgvRules;
    }
}
