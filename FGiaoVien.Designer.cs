namespace ThucHanh1
{
    partial class FGiaoVien
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
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCmnd = new TextBox();
            txtAddress = new TextBox();
            gvGvien = new DataGridView();
            dtpDate = new DateTimePicker();
            txtName = new TextBox();
            lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)gvGvien).BeginInit();
            SuspendLayout();
            // 
            // btnSua
            // 
            btnSua.Location = new Point(674, 393);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 25;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(353, 393);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(86, 393);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 23;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 264);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 22;
            label3.Text = "Ngay thang nam sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 117);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 21;
            label2.Text = "Dia chi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 186);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 20;
            label1.Text = "CMND";
            // 
            // txtCmnd
            // 
            txtCmnd.Location = new Point(186, 183);
            txtCmnd.Name = "txtCmnd";
            txtCmnd.Size = new Size(250, 27);
            txtCmnd.TabIndex = 19;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(186, 110);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 18;
            // 
            // gvGvien
            // 
            gvGvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvGvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvGvien.Location = new Point(451, 29);
            gvGvien.Name = "gvGvien";
            gvGvien.RowHeadersWidth = 51;
            gvGvien.Size = new Size(499, 262);
            gvGvien.TabIndex = 17;
            gvGvien.CellClick += gvGvien_CellClick;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(186, 264);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Location = new Point(186, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 15;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(31, 45);
            lbl.Name = "lbl";
            lbl.Size = new Size(75, 20);
            lbl.TabIndex = 14;
            lbl.Text = "Ho va Ten";
            // 
            // FGiaoVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 450);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCmnd);
            Controls.Add(txtAddress);
            Controls.Add(gvGvien);
            Controls.Add(dtpDate);
            Controls.Add(txtName);
            Controls.Add(lbl);
            Name = "FGiaoVien";
            Text = "FGiaoVien";
            Load += FGiaoVien_Load;
            ((System.ComponentModel.ISupportInitialize)gvGvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCmnd;
        private TextBox txtAddress;
        private DataGridView gvGvien;
        private DateTimePicker dtpDate;
        private TextBox txtName;
        private Label lbl;
    }
}