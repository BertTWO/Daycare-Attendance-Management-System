using Bunifu;
namespace Attendance_Management_System.Forms.Controlls
{
    partial class ScanQr
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanQr));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dgvScanStatus = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pbxCamera = new System.Windows.Forms.PictureBox();
            this.btnScan = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnStop = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtResultID = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbQrName = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScanStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCamera)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuPanel1.BorderRadius = 35;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.dgvScanStatus);
            this.bunifuPanel1.Location = new System.Drawing.Point(17, 17);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(601, 529);
            this.bunifuPanel1.TabIndex = 14;
            // 
            // dgvScanStatus
            // 
            this.dgvScanStatus.AllowCustomTheming = false;
            this.dgvScanStatus.AllowUserToAddRows = false;
            this.dgvScanStatus.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvScanStatus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScanStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScanStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScanStatus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvScanStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScanStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScanStatus.ColumnHeadersHeight = 40;
            this.dgvScanStatus.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvScanStatus.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvScanStatus.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvScanStatus.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvScanStatus.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvScanStatus.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvScanStatus.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvScanStatus.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvScanStatus.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvScanStatus.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvScanStatus.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvScanStatus.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvScanStatus.CurrentTheme.Name = null;
            this.dgvScanStatus.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvScanStatus.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvScanStatus.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvScanStatus.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvScanStatus.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScanStatus.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvScanStatus.EnableHeadersVisualStyles = false;
            this.dgvScanStatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvScanStatus.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvScanStatus.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvScanStatus.HeaderForeColor = System.Drawing.Color.White;
            this.dgvScanStatus.Location = new System.Drawing.Point(12, 27);
            this.dgvScanStatus.Name = "dgvScanStatus";
            this.dgvScanStatus.ReadOnly = true;
            this.dgvScanStatus.RowHeadersVisible = false;
            this.dgvScanStatus.RowTemplate.Height = 40;
            this.dgvScanStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScanStatus.Size = new System.Drawing.Size(570, 479);
            this.dgvScanStatus.TabIndex = 0;
            this.dgvScanStatus.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // pbxCamera
            // 
            this.pbxCamera.BackColor = System.Drawing.Color.White;
            this.pbxCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCamera.Location = new System.Drawing.Point(32, 49);
            this.pbxCamera.Name = "pbxCamera";
            this.pbxCamera.Size = new System.Drawing.Size(295, 194);
            this.pbxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCamera.TabIndex = 0;
            this.pbxCamera.TabStop = false;
            // 
            // btnScan
            // 
            this.btnScan.AllowAnimations = true;
            this.btnScan.AllowMouseEffects = true;
            this.btnScan.AllowToggling = false;
            this.btnScan.AnimationSpeed = 200;
            this.btnScan.AutoGenerateColors = false;
            this.btnScan.AutoRoundBorders = false;
            this.btnScan.AutoSizeLeftIcon = true;
            this.btnScan.AutoSizeRightIcon = true;
            this.btnScan.BackColor = System.Drawing.Color.Transparent;
            this.btnScan.BackColor1 = System.Drawing.Color.White;
            this.btnScan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScan.BackgroundImage")));
            this.btnScan.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnScan.ButtonText = "START";
            this.btnScan.ButtonTextMarginLeft = 0;
            this.btnScan.ColorContrastOnClick = 45;
            this.btnScan.ColorContrastOnHover = 45;
            this.btnScan.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnScan.CustomizableEdges = borderEdges1;
            this.btnScan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnScan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnScan.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnScan.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnScan.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnScan.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnScan.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScan.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnScan.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnScan.IconMarginLeft = 11;
            this.btnScan.IconPadding = 10;
            this.btnScan.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScan.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnScan.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnScan.IconSize = 25;
            this.btnScan.IdleBorderColor = System.Drawing.Color.LightGray;
            this.btnScan.IdleBorderRadius = 30;
            this.btnScan.IdleBorderThickness = 1;
            this.btnScan.IdleFillColor = System.Drawing.Color.White;
            this.btnScan.IdleIconLeftImage = null;
            this.btnScan.IdleIconRightImage = null;
            this.btnScan.IndicateFocus = false;
            this.btnScan.Location = new System.Drawing.Point(32, 323);
            this.btnScan.Name = "btnScan";
            this.btnScan.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnScan.OnDisabledState.BorderRadius = 30;
            this.btnScan.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnScan.OnDisabledState.BorderThickness = 1;
            this.btnScan.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnScan.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnScan.OnDisabledState.IconLeftImage = null;
            this.btnScan.OnDisabledState.IconRightImage = null;
            this.btnScan.onHoverState.BorderColor = System.Drawing.Color.LightGray;
            this.btnScan.onHoverState.BorderRadius = 30;
            this.btnScan.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnScan.onHoverState.BorderThickness = 1;
            this.btnScan.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(1)))));
            this.btnScan.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnScan.onHoverState.IconLeftImage = null;
            this.btnScan.onHoverState.IconRightImage = null;
            this.btnScan.OnIdleState.BorderColor = System.Drawing.Color.LightGray;
            this.btnScan.OnIdleState.BorderRadius = 30;
            this.btnScan.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnScan.OnIdleState.BorderThickness = 1;
            this.btnScan.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnScan.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnScan.OnIdleState.IconLeftImage = null;
            this.btnScan.OnIdleState.IconRightImage = null;
            this.btnScan.OnPressedState.BorderColor = System.Drawing.Color.LightGray;
            this.btnScan.OnPressedState.BorderRadius = 30;
            this.btnScan.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnScan.OnPressedState.BorderThickness = 1;
            this.btnScan.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(5)))));
            this.btnScan.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnScan.OnPressedState.IconLeftImage = null;
            this.btnScan.OnPressedState.IconRightImage = null;
            this.btnScan.Size = new System.Drawing.Size(130, 33);
            this.btnScan.TabIndex = 14;
            this.btnScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnScan.TextMarginLeft = 0;
            this.btnScan.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnScan.UseDefaultRadiusAndThickness = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnStop
            // 
            this.btnStop.AllowAnimations = true;
            this.btnStop.AllowMouseEffects = true;
            this.btnStop.AllowToggling = false;
            this.btnStop.AnimationSpeed = 200;
            this.btnStop.AutoGenerateColors = false;
            this.btnStop.AutoRoundBorders = false;
            this.btnStop.AutoSizeLeftIcon = true;
            this.btnStop.AutoSizeRightIcon = true;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackColor1 = System.Drawing.Color.White;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStop.ButtonText = "STOP";
            this.btnStop.ButtonTextMarginLeft = 0;
            this.btnStop.ColorContrastOnClick = 45;
            this.btnStop.ColorContrastOnHover = 45;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnStop.CustomizableEdges = borderEdges2;
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnStop.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnStop.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnStop.Enabled = false;
            this.btnStop.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnStop.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnStop.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnStop.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnStop.IconMarginLeft = 11;
            this.btnStop.IconPadding = 10;
            this.btnStop.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnStop.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnStop.IconSize = 25;
            this.btnStop.IdleBorderColor = System.Drawing.Color.LightGray;
            this.btnStop.IdleBorderRadius = 30;
            this.btnStop.IdleBorderThickness = 1;
            this.btnStop.IdleFillColor = System.Drawing.Color.White;
            this.btnStop.IdleIconLeftImage = null;
            this.btnStop.IdleIconRightImage = null;
            this.btnStop.IndicateFocus = false;
            this.btnStop.Location = new System.Drawing.Point(193, 323);
            this.btnStop.Name = "btnStop";
            this.btnStop.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnStop.OnDisabledState.BorderRadius = 30;
            this.btnStop.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStop.OnDisabledState.BorderThickness = 1;
            this.btnStop.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnStop.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnStop.OnDisabledState.IconLeftImage = null;
            this.btnStop.OnDisabledState.IconRightImage = null;
            this.btnStop.onHoverState.BorderColor = System.Drawing.Color.LightGray;
            this.btnStop.onHoverState.BorderRadius = 30;
            this.btnStop.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStop.onHoverState.BorderThickness = 1;
            this.btnStop.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(1)))));
            this.btnStop.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnStop.onHoverState.IconLeftImage = null;
            this.btnStop.onHoverState.IconRightImage = null;
            this.btnStop.OnIdleState.BorderColor = System.Drawing.Color.LightGray;
            this.btnStop.OnIdleState.BorderRadius = 30;
            this.btnStop.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStop.OnIdleState.BorderThickness = 1;
            this.btnStop.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnStop.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnStop.OnIdleState.IconLeftImage = null;
            this.btnStop.OnIdleState.IconRightImage = null;
            this.btnStop.OnPressedState.BorderColor = System.Drawing.Color.LightGray;
            this.btnStop.OnPressedState.BorderRadius = 30;
            this.btnStop.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStop.OnPressedState.BorderThickness = 1;
            this.btnStop.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(5)))));
            this.btnStop.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnStop.OnPressedState.IconLeftImage = null;
            this.btnStop.OnPressedState.IconRightImage = null;
            this.btnStop.Size = new System.Drawing.Size(134, 33);
            this.btnStop.TabIndex = 15;
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStop.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStop.TextMarginLeft = 0;
            this.btnStop.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnStop.UseDefaultRadiusAndThickness = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtResultID
            // 
            this.txtResultID.AcceptsReturn = false;
            this.txtResultID.AcceptsTab = false;
            this.txtResultID.AnimationSpeed = 200;
            this.txtResultID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtResultID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtResultID.BackColor = System.Drawing.Color.White;
            this.txtResultID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtResultID.BackgroundImage")));
            this.txtResultID.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtResultID.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtResultID.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtResultID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.txtResultID.BorderRadius = 1;
            this.txtResultID.BorderThickness = 2;
            this.txtResultID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtResultID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResultID.DefaultFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultID.DefaultText = "";
            this.txtResultID.FillColor = System.Drawing.Color.White;
            this.txtResultID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.txtResultID.HideSelection = true;
            this.txtResultID.IconLeft = null;
            this.txtResultID.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResultID.IconPadding = 10;
            this.txtResultID.IconRight = null;
            this.txtResultID.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResultID.Lines = new string[0];
            this.txtResultID.Location = new System.Drawing.Point(30, 262);
            this.txtResultID.MaxLength = 32767;
            this.txtResultID.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtResultID.Modified = false;
            this.txtResultID.Multiline = true;
            this.txtResultID.Name = "txtResultID";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtResultID.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtResultID.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtResultID.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtResultID.OnIdleState = stateProperties4;
            this.txtResultID.Padding = new System.Windows.Forms.Padding(3);
            this.txtResultID.PasswordChar = '\0';
            this.txtResultID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtResultID.PlaceholderText = "STUDENT ID";
            this.txtResultID.ReadOnly = false;
            this.txtResultID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtResultID.SelectedText = "";
            this.txtResultID.SelectionLength = 0;
            this.txtResultID.SelectionStart = 0;
            this.txtResultID.ShortcutsEnabled = true;
            this.txtResultID.Size = new System.Drawing.Size(297, 35);
            this.txtResultID.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtResultID.TabIndex = 16;
            this.txtResultID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResultID.TextMarginBottom = 0;
            this.txtResultID.TextMarginLeft = 3;
            this.txtResultID.TextMarginTop = 0;
            this.txtResultID.TextPlaceholder = "STUDENT ID";
            this.txtResultID.UseSystemPasswordChar = false;
            this.txtResultID.WordWrap = true;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuPanel2.BorderRadius = 35;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.txtResultID);
            this.bunifuPanel2.Controls.Add(this.btnStop);
            this.bunifuPanel2.Controls.Add(this.btnScan);
            this.bunifuPanel2.Controls.Add(this.lbQrName);
            this.bunifuPanel2.Controls.Add(this.pbxCamera);
            this.bunifuPanel2.Location = new System.Drawing.Point(637, 42);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(350, 481);
            this.bunifuPanel2.TabIndex = 8;
            // 
            // lbQrName
            // 
            this.lbQrName.AllowParentOverrides = false;
            this.lbQrName.AutoEllipsis = true;
            this.lbQrName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbQrName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbQrName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQrName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.lbQrName.Location = new System.Drawing.Point(81, 323);
            this.lbQrName.Name = "lbQrName";
            this.lbQrName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbQrName.Size = new System.Drawing.Size(0, 0);
            this.lbQrName.TabIndex = 13;
            this.lbQrName.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lbQrName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ScanQr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuPanel2);
            this.Name = "ScanQr";
            this.Size = new System.Drawing.Size(1009, 559);
            this.Load += new System.EventHandler(this.ScanQr_Load);
            this.Leave += new System.EventHandler(this.ScanQr_Leave);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScanStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCamera)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.PictureBox pbxCamera;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnScan;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnStop;
        private Bunifu.UI.WinForms.BunifuTextBox txtResultID;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuLabel lbQrName;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvScanStatus;
    }
}
