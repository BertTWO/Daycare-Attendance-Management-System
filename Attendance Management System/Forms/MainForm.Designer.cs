namespace Attendance_Management_System.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timerAdd = new System.Windows.Forms.Timer(this.components);
            this.pnlContent = new Bunifu.UI.WinForms.BunifuPanel();
            this.msgLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMessage = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.pnlTop = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnScanQr = new FontAwesome.Sharp.IconButton();
            this.LayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddLayout = new FontAwesome.Sharp.IconButton();
            this.btnAddStudent = new FontAwesome.Sharp.IconButton();
            this.btnAddUser = new FontAwesome.Sharp.IconButton();
            this.timerMsg = new System.Windows.Forms.Timer(this.components);
            this.msgLayoutPanel.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerAdd
            // 
            this.timerAdd.Interval = 1;
            this.timerAdd.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnlContent
            // 
            this.pnlContent.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContent.BackgroundImage")));
            this.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContent.BorderColor = System.Drawing.Color.Transparent;
            this.pnlContent.BorderRadius = 3;
            this.pnlContent.BorderThickness = 1;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlContent.Location = new System.Drawing.Point(173, 37);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.ShowBorders = true;
            this.pnlContent.Size = new System.Drawing.Size(1009, 559);
            this.pnlContent.TabIndex = 14;
            // 
            // msgLayoutPanel
            // 
            this.msgLayoutPanel.Controls.Add(this.btnMessage);
            this.msgLayoutPanel.Controls.Add(this.iconButton3);
            this.msgLayoutPanel.Controls.Add(this.iconButton4);
            this.msgLayoutPanel.Location = new System.Drawing.Point(3, 251);
            this.msgLayoutPanel.MaximumSize = new System.Drawing.Size(178, 122);
            this.msgLayoutPanel.MinimumSize = new System.Drawing.Size(176, 39);
            this.msgLayoutPanel.Name = "msgLayoutPanel";
            this.msgLayoutPanel.Size = new System.Drawing.Size(178, 39);
            this.msgLayoutPanel.TabIndex = 19;
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.White;
            this.btnMessage.FlatAppearance.BorderSize = 0;
            this.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnMessage.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpen;
            this.btnMessage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnMessage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMessage.IconSize = 30;
            this.btnMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessage.Location = new System.Drawing.Point(3, 3);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMessage.Size = new System.Drawing.Size(180, 36);
            this.btnMessage.TabIndex = 15;
            this.btnMessage.Text = "Message          >";
            this.btnMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.White;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(3, 45);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(226, 36);
            this.iconButton3.TabIndex = 16;
            this.iconButton3.Text = "Send Message";
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.White;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.iconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(3, 87);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.iconButton4.Size = new System.Drawing.Size(226, 36);
            this.iconButton4.TabIndex = 17;
            this.iconButton4.Text = "Bulk Message";
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.RectangleList;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(3, 296);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(178, 34);
            this.iconButton2.TabIndex = 17;
            this.iconButton2.Text = "Records";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundColor = System.Drawing.Color.White;
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTop.BorderColor = System.Drawing.Color.Transparent;
            this.pnlTop.BorderRadius = 3;
            this.pnlTop.BorderThickness = 0;
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.ShowBorders = true;
            this.pnlTop.Size = new System.Drawing.Size(1182, 37);
            this.pnlTop.TabIndex = 12;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 25;
            this.btnClose.Location = new System.Drawing.Point(1147, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 3;
            this.bunifuPanel1.Controls.Add(this.flowLayoutPanel1);
            this.bunifuPanel1.Location = new System.Drawing.Point(-14, -9);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(193, 614);
            this.bunifuPanel1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.btnScanQr);
            this.flowLayoutPanel1.Controls.Add(this.LayoutPanel);
            this.flowLayoutPanel1.Controls.Add(this.msgLayoutPanel);
            this.flowLayoutPanel1.Controls.Add(this.iconButton2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(193, 614);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 43);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Attendance_Management_System.Properties.Resources.image0_0;
            this.pictureBox1.Location = new System.Drawing.Point(3, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 41);
            this.panel2.TabIndex = 18;
            // 
            // btnScanQr
            // 
            this.btnScanQr.BackColor = System.Drawing.Color.White;
            this.btnScanQr.FlatAppearance.BorderSize = 0;
            this.btnScanQr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanQr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanQr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnScanQr.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.btnScanQr.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnScanQr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnScanQr.IconSize = 30;
            this.btnScanQr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanQr.Location = new System.Drawing.Point(3, 166);
            this.btnScanQr.Name = "btnScanQr";
            this.btnScanQr.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnScanQr.Size = new System.Drawing.Size(178, 34);
            this.btnScanQr.TabIndex = 14;
            this.btnScanQr.Text = "Qr Scanner        ";
            this.btnScanQr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScanQr.UseVisualStyleBackColor = false;
            this.btnScanQr.Click += new System.EventHandler(this.btnScanQr_Click);
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Controls.Add(this.btnAddLayout);
            this.LayoutPanel.Controls.Add(this.btnAddStudent);
            this.LayoutPanel.Controls.Add(this.btnAddUser);
            this.LayoutPanel.Location = new System.Drawing.Point(3, 206);
            this.LayoutPanel.MaximumSize = new System.Drawing.Size(178, 122);
            this.LayoutPanel.MinimumSize = new System.Drawing.Size(176, 39);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(178, 39);
            this.LayoutPanel.TabIndex = 16;
            // 
            // btnAddLayout
            // 
            this.btnAddLayout.BackColor = System.Drawing.Color.White;
            this.btnAddLayout.FlatAppearance.BorderSize = 0;
            this.btnAddLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLayout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnAddLayout.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddLayout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnAddLayout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddLayout.IconSize = 30;
            this.btnAddLayout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLayout.Location = new System.Drawing.Point(3, 3);
            this.btnAddLayout.Name = "btnAddLayout";
            this.btnAddLayout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAddLayout.Size = new System.Drawing.Size(180, 36);
            this.btnAddLayout.TabIndex = 15;
            this.btnAddLayout.Text = "Add                  >";
            this.btnAddLayout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddLayout.UseVisualStyleBackColor = false;
            this.btnAddLayout.Click += new System.EventHandler(this.btnAddLayout_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.White;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnAddStudent.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnAddStudent.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnAddStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddStudent.IconSize = 30;
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(3, 45);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAddStudent.Size = new System.Drawing.Size(226, 36);
            this.btnAddStudent.TabIndex = 16;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.White;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnAddUser.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnAddUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddUser.IconSize = 30;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(3, 87);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAddUser.Size = new System.Drawing.Size(226, 36);
            this.btnAddUser.TabIndex = 17;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // timerMsg
            // 
            this.timerMsg.Interval = 5;
            this.timerMsg.Tick += new System.EventHandler(this.timerMsg_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1182, 596);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msgLayoutPanel.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private Bunifu.UI.WinForms.BunifuPanel pnlTop;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnScanQr;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel;
        private FontAwesome.Sharp.IconButton btnAddStudent;
        private FontAwesome.Sharp.IconButton btnAddLayout;
        private FontAwesome.Sharp.IconButton btnAddUser;
        private System.Windows.Forms.Timer timerAdd;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Bunifu.UI.WinForms.BunifuPanel pnlContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel msgLayoutPanel;
        private FontAwesome.Sharp.IconButton btnMessage;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Timer timerMsg;
    }
}