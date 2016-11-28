namespace LuckyDraw
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblSo6 = new System.Windows.Forms.Label();
            this.lblSo3 = new System.Windows.Forms.Label();
            this.lblSo4 = new System.Windows.Forms.Label();
            this.lblSo1 = new System.Windows.Forms.Label();
            this.lblSo2 = new System.Windows.Forms.Label();
            this.lblSo5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblWinnerName = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhsachTrungthuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUAY SỐ TRÚNG THƯỞNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(225, 468);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 44);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Quay số";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Snow;
            this.lblWinner.Location = new System.Drawing.Point(26, 355);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(726, 50);
            this.lblWinner.TabIndex = 3;
            this.lblWinner.Text = "Chúc mừng người thắng cuộc";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSo6
            // 
            this.lblSo6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSo6.BackColor = System.Drawing.Color.OrangeRed;
            this.lblSo6.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSo6.ForeColor = System.Drawing.Color.White;
            this.lblSo6.Location = new System.Drawing.Point(584, 16);
            this.lblSo6.Name = "lblSo6";
            this.lblSo6.Size = new System.Drawing.Size(100, 160);
            this.lblSo6.TabIndex = 0;
            this.lblSo6.Text = "?";
            this.lblSo6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSo3
            // 
            this.lblSo3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSo3.BackColor = System.Drawing.Color.OrangeRed;
            this.lblSo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSo3.ForeColor = System.Drawing.Color.White;
            this.lblSo3.Location = new System.Drawing.Point(245, 16);
            this.lblSo3.Name = "lblSo3";
            this.lblSo3.Size = new System.Drawing.Size(100, 160);
            this.lblSo3.TabIndex = 1;
            this.lblSo3.Text = "?";
            this.lblSo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSo4
            // 
            this.lblSo4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSo4.BackColor = System.Drawing.Color.OrangeRed;
            this.lblSo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSo4.ForeColor = System.Drawing.Color.White;
            this.lblSo4.Location = new System.Drawing.Point(358, 16);
            this.lblSo4.Name = "lblSo4";
            this.lblSo4.Size = new System.Drawing.Size(100, 160);
            this.lblSo4.TabIndex = 2;
            this.lblSo4.Text = "?";
            this.lblSo4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSo1
            // 
            this.lblSo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSo1.BackColor = System.Drawing.Color.OrangeRed;
            this.lblSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSo1.ForeColor = System.Drawing.Color.White;
            this.lblSo1.Location = new System.Drawing.Point(19, 16);
            this.lblSo1.Name = "lblSo1";
            this.lblSo1.Size = new System.Drawing.Size(100, 160);
            this.lblSo1.TabIndex = 3;
            this.lblSo1.Text = "?";
            this.lblSo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSo2
            // 
            this.lblSo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSo2.BackColor = System.Drawing.Color.OrangeRed;
            this.lblSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSo2.ForeColor = System.Drawing.Color.White;
            this.lblSo2.Location = new System.Drawing.Point(132, 16);
            this.lblSo2.Name = "lblSo2";
            this.lblSo2.Size = new System.Drawing.Size(100, 160);
            this.lblSo2.TabIndex = 4;
            this.lblSo2.Text = "?";
            this.lblSo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSo5
            // 
            this.lblSo5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSo5.BackColor = System.Drawing.Color.OrangeRed;
            this.lblSo5.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSo5.ForeColor = System.Drawing.Color.White;
            this.lblSo5.Location = new System.Drawing.Point(471, 16);
            this.lblSo5.Name = "lblSo5";
            this.lblSo5.Size = new System.Drawing.Size(100, 160);
            this.lblSo5.TabIndex = 5;
            this.lblSo5.Text = "?";
            this.lblSo5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblSo6);
            this.panel1.Controls.Add(this.lblSo5);
            this.panel1.Controls.Add(this.lblSo3);
            this.panel1.Controls.Add(this.lblSo4);
            this.panel1.Controls.Add(this.lblSo2);
            this.panel1.Controls.Add(this.lblSo1);
            this.panel1.Location = new System.Drawing.Point(40, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 192);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(26, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 212);
            this.panel2.TabIndex = 7;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Gray;
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(415, 468);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(147, 44);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Tạm dừng";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblWinnerName
            // 
            this.lblWinnerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWinnerName.BackColor = System.Drawing.Color.Transparent;
            this.lblWinnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerName.ForeColor = System.Drawing.Color.Snow;
            this.lblWinnerName.Location = new System.Drawing.Point(26, 402);
            this.lblWinnerName.Name = "lblWinnerName";
            this.lblWinnerName.Size = new System.Drawing.Size(726, 50);
            this.lblWinnerName.TabIndex = 3;
            this.lblWinnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 18000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhsachTrungthuongToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 120);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.setupToolStripMenuItem.Text = "Cài đặt";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(202, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.infoToolStripMenuItem.Text = "Thông tin Phần mềm";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // danhsachTrungthuongToolStripMenuItem
            // 
            this.danhsachTrungthuongToolStripMenuItem.Name = "danhsachTrungthuongToolStripMenuItem";
            this.danhsachTrungthuongToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.danhsachTrungthuongToolStripMenuItem.Text = "Danh sách Trúng thưởng";
            this.danhsachTrungthuongToolStripMenuItem.Click += new System.EventHandler(this.danhsachTrungthuongToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LuckyDraw.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWinnerName);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUAY SỐ TRÚNG THƯỞNG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblSo6;
        private System.Windows.Forms.Label lblSo5;
        private System.Windows.Forms.Label lblSo2;
        private System.Windows.Forms.Label lblSo1;
        private System.Windows.Forms.Label lblSo4;
        private System.Windows.Forms.Label lblSo3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblWinnerName;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhsachTrungthuongToolStripMenuItem;
    }
}

