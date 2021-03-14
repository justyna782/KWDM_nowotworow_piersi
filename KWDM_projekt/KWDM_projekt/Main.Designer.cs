namespace KWDM_projekt
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cb_study = new System.Windows.Forms.ComboBox();
            this.lb_patients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.cb_series = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_images = new System.Windows.Forms.ComboBox();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.pb_images = new System.Windows.Forms.PictureBox();
            this.btn_segmentuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_images)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_study
            // 
            this.cb_study.FormattingEnabled = true;
            this.cb_study.Location = new System.Drawing.Point(353, 109);
            this.cb_study.Name = "cb_study";
            this.cb_study.Size = new System.Drawing.Size(456, 24);
            this.cb_study.TabIndex = 0;
            this.cb_study.SelectedIndexChanged += new System.EventHandler(this.cb_study_SelectedIndexChanged);
            // 
            // lb_patients
            // 
            this.lb_patients.FormattingEnabled = true;
            this.lb_patients.ItemHeight = 16;
            this.lb_patients.Location = new System.Drawing.Point(37, 59);
            this.lb_patients.Name = "lb_patients";
            this.lb_patients.Size = new System.Drawing.Size(298, 436);
            this.lb_patients.TabIndex = 1;
            this.lb_patients.SelectedIndexChanged += new System.EventHandler(this.lb_patients_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Study";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patients list";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_refresh.Location = new System.Drawing.Point(37, 519);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(298, 46);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cb_series
            // 
            this.cb_series.FormattingEnabled = true;
            this.cb_series.Location = new System.Drawing.Point(353, 219);
            this.cb_series.Name = "cb_series";
            this.cb_series.Size = new System.Drawing.Size(456, 24);
            this.cb_series.TabIndex = 7;
            this.cb_series.SelectedIndexChanged += new System.EventHandler(this.cb_series_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Series";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Images";
            // 
            // cb_images
            // 
            this.cb_images.FormattingEnabled = true;
            this.cb_images.Location = new System.Drawing.Point(353, 317);
            this.cb_images.Name = "cb_images";
            this.cb_images.Size = new System.Drawing.Size(456, 24);
            this.cb_images.TabIndex = 10;
            this.cb_images.SelectedIndexChanged += new System.EventHandler(this.cb_images_SelectedIndexChanged);
            // 
            // btn_left
            // 
            this.btn_left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_left.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_left.Image = ((System.Drawing.Image)(resources.GetObject("btn_left.Image")));
            this.btn_left.Location = new System.Drawing.Point(972, 519);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(72, 40);
            this.btn_left.TabIndex = 12;
            this.btn_left.UseVisualStyleBackColor = false;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_right.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_right.Image = ((System.Drawing.Image)(resources.GetObject("btn_right.Image")));
            this.btn_right.Location = new System.Drawing.Point(1059, 519);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(72, 40);
            this.btn_right.TabIndex = 11;
            this.btn_right.UseVisualStyleBackColor = false;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // pb_images
            // 
            this.pb_images.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_images.Location = new System.Drawing.Point(848, 81);
            this.pb_images.Name = "pb_images";
            this.pb_images.Size = new System.Drawing.Size(400, 414);
            this.pb_images.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_images.TabIndex = 6;
            this.pb_images.TabStop = false;
            // 
            // btn_segmentuj
            // 
            this.btn_segmentuj.Location = new System.Drawing.Point(471, 451);
            this.btn_segmentuj.Name = "btn_segmentuj";
            this.btn_segmentuj.Size = new System.Drawing.Size(242, 44);
            this.btn_segmentuj.TabIndex = 13;
            this.btn_segmentuj.Text = "button1";
            this.btn_segmentuj.UseVisualStyleBackColor = true;
            this.btn_segmentuj.Click += new System.EventHandler(this.btn_segmentuj_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1494, 659);
            this.Controls.Add(this.btn_segmentuj);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.cb_images);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_series);
            this.Controls.Add(this.pb_images);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_patients);
            this.Controls.Add(this.cb_study);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.pb_images)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_study;
        private System.Windows.Forms.ListBox lb_patients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.PictureBox pb_images;
        private System.Windows.Forms.ComboBox cb_series;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_images;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_segmentuj;
    }
}