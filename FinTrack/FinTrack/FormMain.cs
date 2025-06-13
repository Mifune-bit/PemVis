using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinTrack
{
    public partial class FormMain : Form
    {
        private int selectedId = -1;
        private int currentPage = 1;
        private int rowsPerPage = 10;
        private int userId;

        public FormMain(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDown;
            cmbJenis.Items.AddRange(new[] { "Pemasukan", "Pengeluaran" });
            LoadKategori();
            LoadData();
        }

        private void LoadKategori()
        {
            cmbKategori.Items.Clear();

            if (cmbJenis.SelectedItem is not string jenis || string.IsNullOrWhiteSpace(jenis))
                return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                string query = "SELECT nama_kategori FROM kategori WHERE jenis = @jenis ORDER BY nama_kategori ASC";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@jenis", jenis);

                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbKategori.Items.Add(reader.GetString("nama_kategori"));
                }
            }
        }


        private void AddKategoriIfNew(string kategori)
        {
            if (cmbJenis.SelectedItem is not string jenis || string.IsNullOrWhiteSpace(jenis))
                return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                string cek = "SELECT COUNT(*) FROM kategori WHERE nama_kategori = @kategori AND jenis = @jenis";
                MySqlCommand cmd = new MySqlCommand(cek, conn);
                cmd.Parameters.AddWithValue("@kategori", kategori);
                cmd.Parameters.AddWithValue("@jenis", jenis);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    string insert = "INSERT INTO kategori (nama_kategori, jenis) VALUES (@kategori, @jenis)";
                    MySqlCommand cmdInsert = new MySqlCommand(insert, conn);
                    cmdInsert.Parameters.AddWithValue("@kategori", kategori);
                    cmdInsert.Parameters.AddWithValue("@jenis", jenis);
                    cmdInsert.ExecuteNonQuery();
                }
            }
        }


        private void LoadData()
        {
            int offset = (currentPage - 1) * rowsPerPage;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                string query = @"SELECT t.id, t.jumlah, k.nama_kategori, t.tanggal, t.deskripsi, t.jenis 
                         FROM transaksi t
                         JOIN kategori k ON t.kategori_id = k.id
                         WHERE t.user_id = @user_id
                         ORDER BY t.tanggal DESC
                         LIMIT @limit OFFSET @offset";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user_id", userId);
                cmd.Parameters.AddWithValue("@limit", rowsPerPage);
                cmd.Parameters.AddWithValue("@offset", offset);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTransaksi.DataSource = dt;
            }
        }

        private void LoadDataFiltered()
        {
            int offset = (currentPage - 1) * rowsPerPage;
            string filterJenis = cmbFilterJenis.SelectedItem?.ToString() ?? "Semua";
            DateTime filterFrom = dtpFilterFrom.Value.Date;
            DateTime filterTo = dtpFilterTo.Value.Date;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();

                string query = @"SELECT t.id, t.jumlah, k.nama_kategori, t.tanggal, t.deskripsi, t.jenis 
                         FROM transaksi t
                         JOIN kategori k ON t.kategori_id = k.id
                         WHERE t.user_id = @user_id
                         AND t.tanggal BETWEEN @from AND @to";

                if (filterJenis != "Semua")
                {
                    query += " AND t.jenis = @jenis";
                }

                query += " ORDER BY t.tanggal DESC LIMIT @limit OFFSET @offset";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user_id", userId);
                cmd.Parameters.AddWithValue("@from", filterFrom);
                cmd.Parameters.AddWithValue("@to", filterTo);
                if (filterJenis != "Semua")
                    cmd.Parameters.AddWithValue("@jenis", filterJenis);
                cmd.Parameters.AddWithValue("@limit", rowsPerPage);
                cmd.Parameters.AddWithValue("@offset", offset);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTransaksi.DataSource = dt;
            }
        }



        private void ClearForm()
        {
            txtJumlah.Clear();
            cmbKategori.Text = "";
            txtDeskripsi.Clear();
            dtpTanggal.Value = DateTime.Now;
            selectedId = -1;
            btnSimpan.Enabled = true;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grpInput_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }



        private int GetKategoriId(string nama)
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                string query = "SELECT id FROM kategori WHERE nama_kategori = @nama";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", nama);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private void dgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dgvTransaksi.Rows[e.RowIndex].Cells["id"].Value);
                txtJumlah.Text = dgvTransaksi.Rows[e.RowIndex].Cells["jumlah"].Value.ToString();
                cmbKategori.Text = dgvTransaksi.Rows[e.RowIndex].Cells["nama_kategori"].Value.ToString();
                dtpTanggal.Value = Convert.ToDateTime(dgvTransaksi.Rows[e.RowIndex].Cells["tanggal"].Value);
                txtDeskripsi.Text = dgvTransaksi.Rows[e.RowIndex].Cells["deskripsi"].Value.ToString();
                cmbJenis.SelectedItem = dgvTransaksi.Rows[e.RowIndex].Cells["jenis"].Value.ToString();
                btnSimpan.Enabled = false;
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            decimal.TryParse(txtJumlah.Text, out decimal jumlah);
            string kategori = cmbKategori.Text.Trim();
            AddKategoriIfNew(kategori);
            int kategoriId = GetKategoriId(kategori);
            if (cmbJenis.SelectedItem is string jenis && !string.IsNullOrWhiteSpace(jenis))
            {

            }
            else
            {
                MessageBox.Show("Silakan pilih jenis transaksi terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                string query = "UPDATE transaksi SET kategori_id=@kategori_id, jumlah=@jumlah, tanggal=@tanggal, " +
                               "deskripsi=@deskripsi, jenis=@jenis WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.Parameters.AddWithValue("@kategori_id", kategoriId);
                cmd.Parameters.AddWithValue("@jumlah", jumlah);
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value);
                cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);
                cmd.Parameters.AddWithValue("@jenis", jenis);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil diperbarui!");
                ClearForm();
                LoadData();
            }
        }


        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                string query = "DELETE FROM transaksi WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil dihapus!");
                ClearForm();
                LoadData();
            }
        }

        private void lblKategori_Click(object sender, EventArgs e)
        {

        }

        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadKategori();
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtJumlah.Text, out decimal jumlah))
            {
                MessageBox.Show("Jumlah tidak valid!");
                return;
            }

            string kategori = cmbKategori.Text.Trim();
            if (string.IsNullOrWhiteSpace(kategori))
            {
                MessageBox.Show("Kategori wajib diisi!");
                return;
            }

            if (cmbJenis.SelectedItem is not string jenis || string.IsNullOrWhiteSpace(jenis))
            {
                MessageBox.Show("Silakan pilih jenis transaksi terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddKategoriIfNew(kategori);
            int kategoriId = GetKategoriId(kategori);
            if (kategoriId == -1) return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                string query = "INSERT INTO transaksi (user_id, kategori_id, jumlah, tanggal, deskripsi, jenis) " +
                               "VALUES (@user_id, @kategori_id, @jumlah, @tanggal, @deskripsi, @jenis)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user_id", userId);
                cmd.Parameters.AddWithValue("@kategori_id", kategoriId);
                cmd.Parameters.AddWithValue("@jumlah", jumlah);
                cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value);
                cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);
                cmd.Parameters.AddWithValue("@jenis", jenis);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil disimpan!");
                ClearForm();
                LoadData();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadDataFiltered();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbFilterJenis.SelectedIndex = 0;
            dtpFilterFrom.Value = DateTime.Today;
            dtpFilterTo.Value = DateTime.Today;
            currentPage = 1;
            LoadData();
        }
    }
}