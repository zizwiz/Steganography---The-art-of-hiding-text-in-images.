using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CenteredMessagebox;

namespace Encoder
{
    public partial class Form1 : Form
    {
        // The unmodified and modified pictures.
        private Bitmap
            OriginalImage = null,
            EncodedImage = null,
            MarkedImage = null;

        private Bitmap bmp = null;

        public Form1()
        {
            InitializeComponent();
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            picbx_logo.Image = null;
            rchtxtbx_data.Text = "";
            txtbx_in_key.Text = "";
            ActiveForm.Size = new Size(818, 482);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            string text = "";

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Lossless Image Files|*.bmp;*.png;*.tiff|Lossy Image Files|*.jpg;*.gif|All Files|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        Application.DoEvents();

                        if (txtbx_in_key.Text != "")
                        {
                            //open file in picturebox
                            OriginalImage = new Bitmap(openFileDialog.FileName);
                            MarkedImage = null;
                            EncodedImage = null;
                            radOriginal.Checked = true;
                            picbx_logo.Image = OriginalImage;
                            btn_save.Enabled = false;

                            // Size to show the whole picture.
                            int wid = Math.Max(ClientSize.Width, picbx_logo.Bounds.Right + picbx_logo.Left);
                            int hgt = Math.Max(ClientSize.Height, picbx_logo.Bounds.Bottom + picbx_logo.Left);
                            ClientSize = new Size(wid, hgt);

                            text = rchtxtbx_data.Text;

                            Cursor = Cursors.WaitCursor;
                            Application.DoEvents();

                            // Copy the original message.
                            EncodedImage = (Bitmap)OriginalImage.Clone();
                            MarkedImage = (Bitmap)OriginalImage.Clone();

                            // Encode.
                            try
                            {
                                text = Crypto.EncryptStringAES(text, txtbx_in_key.Text);
                                Encode.EncodeMessageInImage(EncodedImage, MarkedImage, txtbx_in_key.Text, text);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            // Display the results.
                            radMarked.Checked = true;
                            picbx_logo.Image = MarkedImage;

                            btn_save.Enabled = true;
                            Cursor = Cursors.Default;

                        }
                        else
                        {
                            MsgBox.Show("You cannot have empty box.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Cursor = Cursors.Default;
                            return;
                        }
                    }
                    else
                    {
                        MsgBox.Show("You must choose a Logo", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Cursor = Cursors.Default;
                        return;
                    }
                }

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MsgBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // Display the appropriate image.
        private void radOriginal_CheckedChanged(object sender, EventArgs e)
        {
            picbx_logo.Image = OriginalImage;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (EncodedImage == null)
            {
                MessageBox.Show("You have not added to the image.");
            }
            else
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Lossless Image Files | *.bmp; *.png; *.tiff | Lossy Image Files| *.jpg; *.gif | All Files | *.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;


                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            FileInfo file_info = new FileInfo(saveFileDialog.FileName);
                            switch (file_info.Extension)
                            {
                                case ".png":
                                    //EncodedImage.Save(saveFileDialog.FileName, ImageFormat.Png);
                                    picbx_logo.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                                    break;
                                case ".bmp":
                                    picbx_logo.Image.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                                    break;
                                case ".gif":
                                    picbx_logo.Image.Save(saveFileDialog.FileName, ImageFormat.Gif);
                                    break;
                                case ".tiff":
                                case ".tif":
                                    picbx_logo.Image.Save(saveFileDialog.FileName, ImageFormat.Tiff);
                                    break;
                                case ".jpg":
                                case ".jpeg":
                                    picbx_logo.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            MsgBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_save.Enabled = false;
            txtbx_in_key.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            rchtxtbx_data.Text = Assembly.GetExecutingAssembly().GetName().Name;

            lbl_ver.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version;
        }

       

        private void radEncoded_CheckedChanged(object sender, EventArgs e)
        {
            picbx_logo.Image = EncodedImage;
        }
        private void radMarked_CheckedChanged(object sender, EventArgs e)
        {
            picbx_logo.Image = MarkedImage;
        }
    }
}