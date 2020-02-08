namespace WinPower
{
    partial class PowerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hibernateBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.backToWinBtn = new System.Windows.Forms.Button();
            this.shutdownBtn = new System.Windows.Forms.Button();
            this.timeoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.secondsLbl = new System.Windows.Forms.Label();
            this.secondsPgb = new System.Windows.Forms.ProgressBar();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.advRestartBtn = new System.Windows.Forms.Button();
            this.debugLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.timeoutPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.hibernateBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.restartBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.backToWinBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.shutdownBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(283, 253);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1097, 429);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // hibernateBtn
            // 
            this.hibernateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hibernateBtn.BackgroundImage")));
            this.hibernateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hibernateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hibernateBtn.FlatAppearance.BorderSize = 0;
            this.hibernateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hibernateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hibernateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hibernateBtn.Location = new System.Drawing.Point(578, 30);
            this.hibernateBtn.Margin = new System.Windows.Forms.Padding(30);
            this.hibernateBtn.Name = "hibernateBtn";
            this.hibernateBtn.Padding = new System.Windows.Forms.Padding(20);
            this.hibernateBtn.Size = new System.Drawing.Size(214, 369);
            this.hibernateBtn.TabIndex = 3;
            this.hibernateBtn.Text = "Hibernate";
            this.hibernateBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hibernateBtn.UseVisualStyleBackColor = true;
            this.hibernateBtn.Click += new System.EventHandler(this.hibernateBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restartBtn.BackgroundImage")));
            this.restartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.restartBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restartBtn.FlatAppearance.BorderSize = 0;
            this.restartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.restartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.restartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartBtn.Location = new System.Drawing.Point(304, 30);
            this.restartBtn.Margin = new System.Windows.Forms.Padding(30);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Padding = new System.Windows.Forms.Padding(20);
            this.restartBtn.Size = new System.Drawing.Size(214, 369);
            this.restartBtn.TabIndex = 2;
            this.restartBtn.Text = "Restart";
            this.restartBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // backToWinBtn
            // 
            this.backToWinBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backToWinBtn.BackgroundImage")));
            this.backToWinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backToWinBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backToWinBtn.FlatAppearance.BorderSize = 0;
            this.backToWinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backToWinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backToWinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToWinBtn.Location = new System.Drawing.Point(852, 30);
            this.backToWinBtn.Margin = new System.Windows.Forms.Padding(30);
            this.backToWinBtn.Name = "backToWinBtn";
            this.backToWinBtn.Padding = new System.Windows.Forms.Padding(20);
            this.backToWinBtn.Size = new System.Drawing.Size(215, 369);
            this.backToWinBtn.TabIndex = 1;
            this.backToWinBtn.Text = "Back to Windows";
            this.backToWinBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backToWinBtn.UseVisualStyleBackColor = true;
            this.backToWinBtn.Click += new System.EventHandler(this.backToWinBtn_Click);
            // 
            // shutdownBtn
            // 
            this.shutdownBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shutdownBtn.BackgroundImage")));
            this.shutdownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shutdownBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shutdownBtn.FlatAppearance.BorderSize = 0;
            this.shutdownBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shutdownBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.shutdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdownBtn.Location = new System.Drawing.Point(30, 30);
            this.shutdownBtn.Margin = new System.Windows.Forms.Padding(30);
            this.shutdownBtn.Name = "shutdownBtn";
            this.shutdownBtn.Padding = new System.Windows.Forms.Padding(20);
            this.shutdownBtn.Size = new System.Drawing.Size(214, 369);
            this.shutdownBtn.TabIndex = 0;
            this.shutdownBtn.Text = "Shutdown";
            this.shutdownBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.shutdownBtn.UseVisualStyleBackColor = true;
            this.shutdownBtn.Click += new System.EventHandler(this.shutdownBtn_Click);
            // 
            // timeoutPnl
            // 
            this.timeoutPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeoutPnl.ColumnCount = 3;
            this.timeoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.timeoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.timeoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.timeoutPnl.Controls.Add(this.secondsLbl, 0, 0);
            this.timeoutPnl.Controls.Add(this.secondsPgb, 1, 0);
            this.timeoutPnl.Controls.Add(this.cancelBtn, 2, 0);
            this.timeoutPnl.Location = new System.Drawing.Point(283, 683);
            this.timeoutPnl.Name = "timeoutPnl";
            this.timeoutPnl.RowCount = 1;
            this.timeoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.timeoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.timeoutPnl.Size = new System.Drawing.Size(1097, 50);
            this.timeoutPnl.TabIndex = 2;
            this.timeoutPnl.Visible = false;
            // 
            // secondsLbl
            // 
            this.secondsLbl.AutoSize = true;
            this.secondsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondsLbl.Location = new System.Drawing.Point(3, 0);
            this.secondsLbl.Name = "secondsLbl";
            this.secondsLbl.Size = new System.Drawing.Size(94, 50);
            this.secondsLbl.TabIndex = 0;
            this.secondsLbl.Text = "60 seconds";
            this.secondsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // secondsPgb
            // 
            this.secondsPgb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondsPgb.Location = new System.Drawing.Point(103, 3);
            this.secondsPgb.Name = "secondsPgb";
            this.secondsPgb.Size = new System.Drawing.Size(885, 44);
            this.secondsPgb.TabIndex = 1;
            this.secondsPgb.Value = 100;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(994, 3);
            this.cancelBtn.MinimumSize = new System.Drawing.Size(100, 0);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 44);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // advRestartBtn
            // 
            this.advRestartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.advRestartBtn.FlatAppearance.BorderSize = 0;
            this.advRestartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advRestartBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advRestartBtn.Location = new System.Drawing.Point(1327, 879);
            this.advRestartBtn.Name = "advRestartBtn";
            this.advRestartBtn.Size = new System.Drawing.Size(309, 78);
            this.advRestartBtn.TabIndex = 3;
            this.advRestartBtn.Text = "Advanced Restart";
            this.advRestartBtn.UseVisualStyleBackColor = true;
            this.advRestartBtn.Click += new System.EventHandler(this.advRestartBtn_Click);
            // 
            // debugLbl
            // 
            this.debugLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.debugLbl.AutoSize = true;
            this.debugLbl.BackColor = System.Drawing.Color.Maroon;
            this.debugLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugLbl.Location = new System.Drawing.Point(645, 87);
            this.debugLbl.Name = "debugLbl";
            this.debugLbl.Size = new System.Drawing.Size(372, 67);
            this.debugLbl.TabIndex = 4;
            this.debugLbl.Text = "DEBUG MODE";
            this.debugLbl.Visible = false;
            // 
            // PowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1663, 986);
            this.Controls.Add(this.debugLbl);
            this.Controls.Add(this.advRestartBtn);
            this.Controls.Add(this.timeoutPnl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "PowerForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinPower";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.timeoutPnl.ResumeLayout(false);
            this.timeoutPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button shutdownBtn;
        private System.Windows.Forms.Button backToWinBtn;
        private System.Windows.Forms.TableLayoutPanel timeoutPnl;
        private System.Windows.Forms.Label secondsLbl;
        private System.Windows.Forms.ProgressBar secondsPgb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button hibernateBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button advRestartBtn;
        private System.Windows.Forms.Label debugLbl;
    }
}