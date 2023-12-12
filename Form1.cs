using System.Data;
using Npgsql;

namespace Responsi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi2";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from st_insert(:_nama, :_nama_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", txtName.Text);
                cmd.Parameters.AddWithValue("_nama_dep", txtDepartemen.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Berhasil diinputkan", "Keren", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    /*btnLoaddata.PerformClick();*/
                    txtName.Text = txtDepartemen.Text = null;
                }
            }
            catch
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih dulu baris yang mau diupdate", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();
                sql = @"select * from st_updatet(:_nama, :_nama_dep)";
                cmd = new NpgsqlCommand(sql, conn);


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Delete FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                if (r == null)
                {
                    MessageBox.Show("Mohon pilih baris data yang akan dihapus", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Apakah anda ingin menghapus data " + r.Cells["_name"].Value.ToString() + "?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        sql = @"select * from st_delete(:id_karyawan)";
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                        if ((int)cmd.ExecuteScalar() == 1)
                        {
                            MessageBox.Show("Data Users Berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                            btnLoaddata.PerformClick();
                            txtName.Text = txtDepartemen.Text = null;
                        r = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message, "Delete FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                txtName.Text = r.Cells["nama"].Value.ToString();
                txtDepartemen.Text = r.Cells["departemen"].Value.ToString();
            }
        }

        private void btnLoaddata_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = @"select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}