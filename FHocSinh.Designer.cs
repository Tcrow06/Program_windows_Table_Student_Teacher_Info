namespace ThucHanh1
{
    partial class FHocSinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl = new Label();
            txtName = new TextBox();
            dtpDate = new DateTimePicker();
            gvHsinh = new DataGridView();
            txtAddress = new TextBox();
            txtCmnd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)gvHsinh).BeginInit();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(21, 36);
            lbl.Name = "lbl";
            lbl.Size = new Size(75, 20);
            lbl.TabIndex = 0;
            lbl.Text = "Ho va Ten";
            // 
            // txtName
            // 
            txtName.Location = new Point(176, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 1;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(176, 255);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 2;
            // 
            // gvHsinh
            // 
            gvHsinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvHsinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvHsinh.Location = new Point(441, 20);
            gvHsinh.Name = "gvHsinh";
            gvHsinh.RowHeadersWidth = 51;
            gvHsinh.Size = new Size(499, 262);
            gvHsinh.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(176, 101);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 5;
            // 
            // txtCmnd
            // 
            txtCmnd.Location = new Point(176, 174);
            txtCmnd.Name = "txtCmnd";
            txtCmnd.Size = new Size(250, 27);
            txtCmnd.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 177);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 7;
            label1.Text = "CMND";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 108);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 8;
            label2.Text = "Dia chi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 255);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 9;
            label3.Text = "Ngay thang nam sinh";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(35, 384);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 10;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(244, 384);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button2_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(462, 384);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += sua_hs_Click;
            // 
            // FHocSinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 450);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCmnd);
            Controls.Add(txtAddress);
            Controls.Add(gvHsinh);
            Controls.Add(dtpDate);
            Controls.Add(txtName);
            Controls.Add(lbl);
            Name = "FHocSinh";
            Text = "FHocSinh";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)gvHsinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private TextBox txtName;
        private DateTimePicker dtpDate;
        private DataGridView gvHsinh;
        private TextBox txtAddress;
        private TextBox txtCmnd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
