namespace KWDM_projekt
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
            this.txt_server_ip = new System.Windows.Forms.TextBox();
            this.txt_server_port = new System.Windows.Forms.TextBox();
            this.txt_server_aet = new System.Windows.Forms.TextBox();
            this.txt_client_aet = new System.Windows.Forms.TextBox();
            this.txt_client_port = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_server_ip
            // 
            this.txt_server_ip.Location = new System.Drawing.Point(166, 53);
            this.txt_server_ip.Name = "txt_server_ip";
            this.txt_server_ip.Size = new System.Drawing.Size(112, 22);
            this.txt_server_ip.TabIndex = 0;
            this.txt_server_ip.Text = "127.0.0.1";
            // 
            // txt_server_port
            // 
            this.txt_server_port.Location = new System.Drawing.Point(166, 111);
            this.txt_server_port.Name = "txt_server_port";
            this.txt_server_port.Size = new System.Drawing.Size(112, 22);
            this.txt_server_port.TabIndex = 1;
            this.txt_server_port.Text = "10100";
            // 
            // txt_server_aet
            // 
            this.txt_server_aet.Location = new System.Drawing.Point(166, 165);
            this.txt_server_aet.Name = "txt_server_aet";
            this.txt_server_aet.Size = new System.Drawing.Size(112, 22);
            this.txt_server_aet.TabIndex = 2;
            this.txt_server_aet.Text = "ARCHIWUM";
            // 
            // txt_client_aet
            // 
            this.txt_client_aet.Location = new System.Drawing.Point(166, 221);
            this.txt_client_aet.Name = "txt_client_aet";
            this.txt_client_aet.Size = new System.Drawing.Size(112, 22);
            this.txt_client_aet.TabIndex = 3;
            this.txt_client_aet.Text = "KLIENTL";
            // 
            // txt_client_port
            // 
            this.txt_client_port.Location = new System.Drawing.Point(166, 272);
            this.txt_client_port.Name = "txt_client_port";
            this.txt_client_port.Size = new System.Drawing.Size(112, 22);
            this.txt_client_port.TabIndex = 4;
            this.txt_client_port.Text = "10104";
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_connect.Location = new System.Drawing.Point(58, 332);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(220, 48);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Server port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Server AET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Client AET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Client port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(333, 417);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txt_client_port);
            this.Controls.Add(this.txt_client_aet);
            this.Controls.Add(this.txt_server_aet);
            this.Controls.Add(this.txt_server_port);
            this.Controls.Add(this.txt_server_ip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_server_ip;
        private System.Windows.Forms.TextBox txt_server_port;
        private System.Windows.Forms.TextBox txt_server_aet;
        private System.Windows.Forms.TextBox txt_client_aet;
        private System.Windows.Forms.TextBox txt_client_port;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}