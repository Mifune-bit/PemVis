namespace FinTrack
{
    partial class FormMain
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
            panelHeader = new Panel();
            btnLogout = new Button();
            label1 = new Label();
            btnReset = new Button();
            dgvTransaksi = new DataGridView();
            grpFilter = new GroupBox();
            btnFilter = new Button();
            cmbFilterJenis = new ComboBox();
            label2 = new Label();
            dtpFilterFrom = new DateTimePicker();
            dtpFilterTo = new DateTimePicker();
            btnCetak = new Button();
            grpAksi = new GroupBox();
            btnHapus = new Button();
            btnEdit = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            grpInput = new GroupBox();
            btnSimpan = new Button();
            label3 = new Label();
            lblDeskripsi = new Label();
            label5 = new Label();
            lblKategori = new Label();
            lblJumlah = new Label();
            cmbJenis = new ComboBox();
            txtDeskripsi = new TextBox();
            cmbKategori = new ComboBox();
            dtpTanggal = new DateTimePicker();
            txtJumlah = new TextBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            grpFilter.SuspendLayout();
            grpAksi.SuspendLayout();
            grpInput.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Controls.Add(label1);
            panelHeader.Location = new Point(12, 1);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(868, 48);
            panelHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(371, 18);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome to FinTrack";
            label1.Click += label1_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(413, 14);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksi.Location = new Point(386, 103);
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.Size = new Size(497, 276);
            dgvTransaksi.TabIndex = 8;
            dgvTransaksi.CellClick += dgvTransaksi_CellClick;
            dgvTransaksi.CellContentClick += dataGridView1_CellContentClick;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(btnFilter);
            grpFilter.Controls.Add(cmbFilterJenis);
            grpFilter.Controls.Add(label2);
            grpFilter.Controls.Add(dtpFilterFrom);
            grpFilter.Controls.Add(dtpFilterTo);
            grpFilter.Controls.Add(btnReset);
            grpFilter.Location = new Point(386, 55);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(494, 43);
            grpFilter.TabIndex = 9;
            grpFilter.TabStop = false;
            grpFilter.Text = "Filter";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(332, 14);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 14;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // cmbFilterJenis
            // 
            cmbFilterJenis.FormattingEnabled = true;
            cmbFilterJenis.Location = new Point(243, 14);
            cmbFilterJenis.Name = "cmbFilterJenis";
            cmbFilterJenis.Size = new Size(73, 23);
            cmbFilterJenis.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 18);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 12;
            label2.Text = "s.d.";
            // 
            // dtpFilterFrom
            // 
            dtpFilterFrom.Location = new Point(31, 14);
            dtpFilterFrom.Name = "dtpFilterFrom";
            dtpFilterFrom.Size = new Size(79, 23);
            dtpFilterFrom.TabIndex = 10;
            // 
            // dtpFilterTo
            // 
            dtpFilterTo.Location = new Point(147, 14);
            dtpFilterTo.Name = "dtpFilterTo";
            dtpFilterTo.Size = new Size(79, 23);
            dtpFilterTo.TabIndex = 11;
            dtpFilterTo.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // btnCetak
            // 
            btnCetak.Location = new Point(15, 108);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(75, 23);
            btnCetak.TabIndex = 10;
            btnCetak.Text = "Cetak";
            btnCetak.UseVisualStyleBackColor = true;
            // 
            // grpAksi
            // 
            grpAksi.Controls.Add(btnHapus);
            grpAksi.Controls.Add(btnEdit);
            grpAksi.Controls.Add(btnCetak);
            grpAksi.Location = new Point(281, 99);
            grpAksi.Name = "grpAksi";
            grpAksi.Size = new Size(99, 163);
            grpAksi.TabIndex = 11;
            grpAksi.TabStop = false;
            grpAksi.Text = "Aksi";
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(15, 65);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(75, 23);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(15, 27);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Ubah";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(421, 385);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(75, 23);
            btnPrev.TabIndex = 12;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(768, 385);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 13;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(btnSimpan);
            grpInput.Controls.Add(label3);
            grpInput.Controls.Add(lblDeskripsi);
            grpInput.Controls.Add(label5);
            grpInput.Controls.Add(lblKategori);
            grpInput.Controls.Add(lblJumlah);
            grpInput.Controls.Add(cmbJenis);
            grpInput.Controls.Add(txtDeskripsi);
            grpInput.Controls.Add(cmbKategori);
            grpInput.Controls.Add(dtpTanggal);
            grpInput.Controls.Add(txtJumlah);
            grpInput.Location = new Point(12, 99);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(246, 233);
            grpInput.TabIndex = 14;
            grpInput.TabStop = false;
            grpInput.Text = "Input";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(83, 190);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 20;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 56);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 19;
            label3.Text = "Jenis";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Location = new Point(45, 143);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(54, 15);
            lblDeskripsi.TabIndex = 18;
            lblDeskripsi.Text = "Deskripsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 85);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 17;
            label5.Text = "Tanggal";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(45, 114);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(51, 15);
            lblKategori.TabIndex = 16;
            lblKategori.Text = "Kategori";
            lblKategori.Click += lblKategori_Click;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(45, 27);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(45, 15);
            lblJumlah.TabIndex = 15;
            lblJumlah.Text = "Jumlah";
            // 
            // cmbJenis
            // 
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Location = new Point(105, 53);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(124, 23);
            cmbJenis.TabIndex = 9;
            cmbJenis.Text = "Pilih Jenis";
            cmbJenis.SelectedIndexChanged += cmbJenis_SelectedIndexChanged;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(105, 140);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(124, 44);
            txtDeskripsi.TabIndex = 8;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(105, 111);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(124, 23);
            cmbKategori.TabIndex = 7;
            cmbKategori.Text = "Pilih Kategori";
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(105, 82);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(124, 23);
            dtpTanggal.TabIndex = 6;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(105, 22);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(124, 23);
            txtJumlah.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 450);
            Controls.Add(grpInput);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(grpAksi);
            Controls.Add(grpFilter);
            Controls.Add(dgvTransaksi);
            Controls.Add(panelHeader);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            grpAksi.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Button btnLogout;
        private Button btnReset;
        private DataGridView dgvTransaksi;
        private GroupBox grpFilter;
        private DateTimePicker dtpFilterFrom;
        private DateTimePicker dtpFilterTo;
        private Button btnCetak;
        private Label label2;
        private GroupBox grpAksi;
        private Button btnPrev;
        private Button btnNext;
        private Button btnEdit;
        private Button btnHapus;
        private GroupBox grpInput;
        private TextBox txtDeskripsi;
        private ComboBox cmbKategori;
        private DateTimePicker dtpTanggal;
        private TextBox txtJumlah;
        private ComboBox cmbJenis;
        private Label lblDeskripsi;
        private Label label5;
        private Label lblKategori;
        private Label lblJumlah;
        private Label label3;
        private Button btnSimpan;
        private ComboBox cmbFilterJenis;
        private Button btnFilter;
    }
}