
namespace ShopApp
{
    partial class frmDetailOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailOrder));
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvOrderProduct = new System.Windows.Forms.DataGridView();
            this.Id_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbAddressUser = new System.Windows.Forms.Label();
            this.lbPhoneUser = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbEmailUser = new System.Windows.Forms.Label();
            this.lbNameUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIdUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lbPersonelName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSumMoney = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProduct)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(8, 454);
            this.splitter3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(2376, 7);
            this.splitter3.TabIndex = 3;
            this.splitter3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Controls.Add(this.splitter3);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox3.Size = new System.Drawing.Size(2392, 1245);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết đơn hàng";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.groupBox4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(8, 461);
            this.panel9.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2376, 474);
            this.panel9.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvOrderProduct);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox4.Size = new System.Drawing.Size(2376, 474);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giỏ hàng";
            // 
            // dgvOrderProduct
            // 
            this.dgvOrderProduct.AllowUserToAddRows = false;
            this.dgvOrderProduct.AllowUserToDeleteRows = false;
            this.dgvOrderProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_product,
            this.Names,
            this.Quantity,
            this.Sale_price,
            this.Totals,
            this.Date_created});
            this.dgvOrderProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderProduct.Location = new System.Drawing.Point(8, 56);
            this.dgvOrderProduct.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvOrderProduct.Name = "dgvOrderProduct";
            this.dgvOrderProduct.ReadOnly = true;
            this.dgvOrderProduct.RowHeadersWidth = 102;
            this.dgvOrderProduct.Size = new System.Drawing.Size(2360, 411);
            this.dgvOrderProduct.TabIndex = 0;
            // 
            // Id_product
            // 
            this.Id_product.DataPropertyName = "Id_product";
            this.Id_product.HeaderText = "Mã sản phẩm";
            this.Id_product.MinimumWidth = 12;
            this.Id_product.Name = "Id_product";
            this.Id_product.ReadOnly = true;
            this.Id_product.Width = 300;
            // 
            // Names
            // 
            this.Names.DataPropertyName = "Name";
            this.Names.HeaderText = "Sản phẩm";
            this.Names.MinimumWidth = 12;
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 450;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.MinimumWidth = 12;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 250;
            // 
            // Sale_price
            // 
            this.Sale_price.DataPropertyName = "Sale_price";
            this.Sale_price.HeaderText = "Giá bán";
            this.Sale_price.MinimumWidth = 12;
            this.Sale_price.Name = "Sale_price";
            this.Sale_price.ReadOnly = true;
            this.Sale_price.Width = 300;
            // 
            // Totals
            // 
            this.Totals.DataPropertyName = "Total";
            this.Totals.HeaderText = "Tổng tiền";
            this.Totals.MinimumWidth = 12;
            this.Totals.Name = "Totals";
            this.Totals.ReadOnly = true;
            this.Totals.Width = 350;
            // 
            // Date_created
            // 
            this.Date_created.DataPropertyName = "Date_created";
            this.Date_created.HeaderText = "Ngày bán";
            this.Date_created.MinimumWidth = 12;
            this.Date_created.Name = "Date_created";
            this.Date_created.ReadOnly = true;
            this.Date_created.Width = 300;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.lbAddressUser);
            this.panel4.Controls.Add(this.lbPhoneUser);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.lbEmailUser);
            this.panel4.Controls.Add(this.lbNameUser);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lbIdUser);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(8, 56);
            this.panel4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2376, 398);
            this.panel4.TabIndex = 2;
            // 
            // lbAddressUser
            // 
            this.lbAddressUser.AutoSize = true;
            this.lbAddressUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddressUser.Location = new System.Drawing.Point(224, 513);
            this.lbAddressUser.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbAddressUser.Name = "lbAddressUser";
            this.lbAddressUser.Size = new System.Drawing.Size(55, 49);
            this.lbAddressUser.TabIndex = 11;
            this.lbAddressUser.Text = "...";
            // 
            // lbPhoneUser
            // 
            this.lbPhoneUser.AutoSize = true;
            this.lbPhoneUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneUser.Location = new System.Drawing.Point(224, 403);
            this.lbPhoneUser.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbPhoneUser.Name = "lbPhoneUser";
            this.lbPhoneUser.Size = new System.Drawing.Size(55, 49);
            this.lbPhoneUser.TabIndex = 10;
            this.lbPhoneUser.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 513);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 49);
            this.label10.TabIndex = 9;
            this.label10.Text = "Địa chỉ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 403);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 49);
            this.label11.TabIndex = 8;
            this.label11.Text = "Số ĐT:";
            // 
            // lbEmailUser
            // 
            this.lbEmailUser.AutoSize = true;
            this.lbEmailUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailUser.Location = new System.Drawing.Point(224, 286);
            this.lbEmailUser.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbEmailUser.Name = "lbEmailUser";
            this.lbEmailUser.Size = new System.Drawing.Size(55, 49);
            this.lbEmailUser.TabIndex = 7;
            this.lbEmailUser.Text = "...";
            // 
            // lbNameUser
            // 
            this.lbNameUser.AutoSize = true;
            this.lbNameUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameUser.Location = new System.Drawing.Point(224, 176);
            this.lbNameUser.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbNameUser.Name = "lbNameUser";
            this.lbNameUser.Size = new System.Drawing.Size(55, 49);
            this.lbNameUser.TabIndex = 6;
            this.lbNameUser.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 49);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên KH:";
            // 
            // lbIdUser
            // 
            this.lbIdUser.AutoSize = true;
            this.lbIdUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdUser.Location = new System.Drawing.Point(224, 62);
            this.lbIdUser.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbIdUser.Name = "lbIdUser";
            this.lbIdUser.Size = new System.Drawing.Size(55, 49);
            this.lbIdUser.TabIndex = 2;
            this.lbIdUser.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.lbPersonelName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lbSumMoney);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(8, 935);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2376, 303);
            this.panel3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(2035, 186);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.button2.Size = new System.Drawing.Size(317, 95);
            this.button2.TabIndex = 15;
            this.button2.Text = "     Đóng";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(1621, 186);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.btnPrint.Size = new System.Drawing.Size(371, 95);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "     In hóa đơn";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lbPersonelName
            // 
            this.lbPersonelName.AutoSize = true;
            this.lbPersonelName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonelName.Location = new System.Drawing.Point(312, 43);
            this.lbPersonelName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbPersonelName.Name = "lbPersonelName";
            this.lbPersonelName.Size = new System.Drawing.Size(55, 49);
            this.lbPersonelName.TabIndex = 12;
            this.lbPersonelName.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 49);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tên nhân viên:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(2264, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 49);
            this.label6.TabIndex = 10;
            this.label6.Text = "VNĐ";
            // 
            // lbSumMoney
            // 
            this.lbSumMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSumMoney.AutoSize = true;
            this.lbSumMoney.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumMoney.ForeColor = System.Drawing.Color.Red;
            this.lbSumMoney.Location = new System.Drawing.Point(1936, 43);
            this.lbSumMoney.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbSumMoney.Name = "lbSumMoney";
            this.lbSumMoney.Size = new System.Drawing.Size(55, 49);
            this.lbSumMoney.TabIndex = 9;
            this.lbSumMoney.Text = "...";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1725, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 49);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng tiền:";
            // 
            // frmDetailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2392, 1245);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimumSize = new System.Drawing.Size(1547, 594);
            this.Name = "frmDetailOrder";
            this.Text = "Chi tiết đơn hàng";
            this.Load += new System.EventHandler(this.frmDetailOrder_Load);
            this.groupBox3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProduct)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbAddressUser;
        private System.Windows.Forms.Label lbPhoneUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbEmailUser;
        private System.Windows.Forms.Label lbNameUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIdUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSumMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvOrderProduct;
        private System.Windows.Forms.Label lbPersonelName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_created;
    }
}