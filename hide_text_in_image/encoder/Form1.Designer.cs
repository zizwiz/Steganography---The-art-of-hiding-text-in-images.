namespace Encoder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picbx_logo = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.rchtxtbx_data = new System.Windows.Forms.RichTextBox();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.radMarked = new System.Windows.Forms.RadioButton();
            this.btn_clear = new System.Windows.Forms.Button();
            this.radEncoded = new System.Windows.Forms.RadioButton();
            this.btn_open = new System.Windows.Forms.Button();
            this.radOriginal = new System.Windows.Forms.RadioButton();
            this.txtbx_in_key = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbx_logo
            // 
            this.picbx_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbx_logo.Location = new System.Drawing.Point(0, 0);
            this.picbx_logo.Name = "picbx_logo";
            this.picbx_logo.Size = new System.Drawing.Size(588, 373);
            this.picbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_logo.TabIndex = 0;
            this.picbx_logo.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbl_ver);
            this.splitContainer1.Panel2.Controls.Add(this.btn_save);
            this.splitContainer1.Panel2.Controls.Add(this.radMarked);
            this.splitContainer1.Panel2.Controls.Add(this.btn_clear);
            this.splitContainer1.Panel2.Controls.Add(this.radEncoded);
            this.splitContainer1.Panel2.Controls.Add(this.btn_open);
            this.splitContainer1.Panel2.Controls.Add(this.radOriginal);
            this.splitContainer1.Panel2.Controls.Add(this.txtbx_in_key);
            this.splitContainer1.Panel2.Controls.Add(this.btn_close);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.rchtxtbx_data);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.picbx_logo);
            this.splitContainer2.Size = new System.Drawing.Size(800, 373);
            this.splitContainer2.SplitterDistance = 208;
            this.splitContainer2.TabIndex = 0;
            // 
            // rchtxtbx_data
            // 
            this.rchtxtbx_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtbx_data.Location = new System.Drawing.Point(0, 0);
            this.rchtxtbx_data.Name = "rchtxtbx_data";
            this.rchtxtbx_data.Size = new System.Drawing.Size(208, 373);
            this.rchtxtbx_data.TabIndex = 0;
            this.rchtxtbx_data.Text = "";
            // 
            // lbl_ver
            // 
            this.lbl_ver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.Location = new System.Drawing.Point(605, 9);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(20, 17);
            this.lbl_ver.TabIndex = 16;
            this.lbl_ver.Text = "...";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.Location = new System.Drawing.Point(105, 14);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 48);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // radMarked
            // 
            this.radMarked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radMarked.AutoSize = true;
            this.radMarked.Location = new System.Drawing.Point(445, 43);
            this.radMarked.Margin = new System.Windows.Forms.Padding(4);
            this.radMarked.Name = "radMarked";
            this.radMarked.Size = new System.Drawing.Size(76, 21);
            this.radMarked.TabIndex = 14;
            this.radMarked.TabStop = true;
            this.radMarked.Text = "Marked";
            this.radMarked.UseVisualStyleBackColor = true;
            this.radMarked.CheckedChanged += new System.EventHandler(this.radMarked_CheckedChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.Location = new System.Drawing.Point(608, 29);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(87, 35);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // radEncoded
            // 
            this.radEncoded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radEncoded.AutoSize = true;
            this.radEncoded.Location = new System.Drawing.Point(346, 43);
            this.radEncoded.Margin = new System.Windows.Forms.Padding(4);
            this.radEncoded.Name = "radEncoded";
            this.radEncoded.Size = new System.Drawing.Size(85, 21);
            this.radEncoded.TabIndex = 13;
            this.radEncoded.TabStop = true;
            this.radEncoded.Text = "Encoded";
            this.radEncoded.UseVisualStyleBackColor = true;
            this.radEncoded.CheckedChanged += new System.EventHandler(this.radEncoded_CheckedChanged);
            // 
            // btn_open
            // 
            this.btn_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_open.Location = new System.Drawing.Point(12, 14);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(87, 48);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // radOriginal
            // 
            this.radOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radOriginal.AutoSize = true;
            this.radOriginal.Location = new System.Drawing.Point(258, 43);
            this.radOriginal.Margin = new System.Windows.Forms.Padding(4);
            this.radOriginal.Name = "radOriginal";
            this.radOriginal.Size = new System.Drawing.Size(78, 21);
            this.radOriginal.TabIndex = 12;
            this.radOriginal.TabStop = true;
            this.radOriginal.Text = "Original";
            this.radOriginal.UseVisualStyleBackColor = true;
            this.radOriginal.CheckedChanged += new System.EventHandler(this.radOriginal_CheckedChanged);
            // 
            // txtbx_in_key
            // 
            this.txtbx_in_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_in_key.Location = new System.Drawing.Point(205, 14);
            this.txtbx_in_key.Name = "txtbx_in_key";
            this.txtbx_in_key.Size = new System.Drawing.Size(388, 22);
            this.txtbx_in_key.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(701, 29);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(87, 35);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Encoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_logo)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbx_logo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox rchtxtbx_data;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.RadioButton radMarked;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RadioButton radEncoded;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.RadioButton radOriginal;
        private System.Windows.Forms.TextBox txtbx_in_key;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_ver;
    }
}

