using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using CenteredMessagebox;

namespace Autocad_Viewer
{
    public partial class Form1 : Form
    {
        private Bitmap bmp = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            string text = "";

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {

                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        Application.DoEvents();

                        if (txtbx_key.Text != "")
                        {
                            //open file in picturebox
                            picbx_gallery.Image = new Bitmap(openFileDialog.FileName);
                            text = Decode.DecodeMessageInImage((Bitmap)picbx_gallery.Image, txtbx_key.Text);
                            text = Crypto.DecryptStringAES(text, txtbx_key.Text);
                            
                            txtbx_result.Text = text;
                            //MsgBox.Show(text, "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MsgBox.Show("You have no version info.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Cursor = Cursors.Default;
                            return;
                        }
                    }
                    else
                    {
                        MsgBox.Show("You must choose a Drawing", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Cursor = Cursors.Default;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Cursor = Cursors.Default;
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtbx_key.Text = "";
            txtbx_result.Clear();
            picbx_gallery.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbx_key.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lbl_ver.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
