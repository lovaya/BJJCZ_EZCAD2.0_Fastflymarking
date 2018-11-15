namespace BJJCZ_Ezcad2_Demo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSetcfg = new System.Windows.Forms.Button();
            this.backgroundWorkerMark = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerUpDataMarkData = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxT5 = new System.Windows.Forms.TextBox();
            this.textBoxT4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxT3 = new System.Windows.Forms.TextBox();
            this.textBoxT2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNowFinishCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxT1 = new System.Windows.Forms.TextBox();
            this.textBoxT0 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInitial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(192, 89);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(175, 70);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "标刻/Mark";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(192, 166);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(175, 70);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止/Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(192, 12);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(175, 70);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "加载模板/LoadEz3";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSetcfg
            // 
            this.btnSetcfg.Location = new System.Drawing.Point(13, 166);
            this.btnSetcfg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetcfg.Name = "btnSetcfg";
            this.btnSetcfg.Size = new System.Drawing.Size(175, 70);
            this.btnSetcfg.TabIndex = 10;
            this.btnSetcfg.Text = "参数/Param";
            this.btnSetcfg.UseVisualStyleBackColor = true;
            this.btnSetcfg.Click += new System.EventHandler(this.btnSetcfg_Click);
            // 
            // backgroundWorkerMark
            // 
            this.backgroundWorkerMark.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMark_DoWork);
            this.backgroundWorkerMark.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerMark_RunWorkerCompleted);
            // 
            // backgroundWorkerUpDataMarkData
            // 
            this.backgroundWorkerUpDataMarkData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUpDataMarkData_DoWork);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(375, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 730);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 607);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 27);
            this.label9.TabIndex = 53;
            this.label9.Text = "Ent5:";
            // 
            // textBoxT5
            // 
            this.textBoxT5.Location = new System.Drawing.Point(126, 604);
            this.textBoxT5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxT5.Name = "textBoxT5";
            this.textBoxT5.ReadOnly = true;
            this.textBoxT5.Size = new System.Drawing.Size(186, 34);
            this.textBoxT5.TabIndex = 52;
            // 
            // textBoxT4
            // 
            this.textBoxT4.Location = new System.Drawing.Point(126, 536);
            this.textBoxT4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxT4.Name = "textBoxT4";
            this.textBoxT4.ReadOnly = true;
            this.textBoxT4.Size = new System.Drawing.Size(186, 34);
            this.textBoxT4.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 539);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 27);
            this.label11.TabIndex = 50;
            this.label11.Text = "Ent4:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 471);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 27);
            this.label4.TabIndex = 49;
            this.label4.Text = "Ent3:";
            // 
            // textBoxT3
            // 
            this.textBoxT3.Location = new System.Drawing.Point(126, 468);
            this.textBoxT3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxT3.Name = "textBoxT3";
            this.textBoxT3.ReadOnly = true;
            this.textBoxT3.Size = new System.Drawing.Size(186, 34);
            this.textBoxT3.TabIndex = 48;
            // 
            // textBoxT2
            // 
            this.textBoxT2.Location = new System.Drawing.Point(126, 400);
            this.textBoxT2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxT2.Name = "textBoxT2";
            this.textBoxT2.ReadOnly = true;
            this.textBoxT2.Size = new System.Drawing.Size(186, 34);
            this.textBoxT2.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 403);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 27);
            this.label5.TabIndex = 46;
            this.label5.Text = "Ent2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 27);
            this.label6.TabIndex = 45;
            this.label6.Text = "Ent1:";
            // 
            // textBoxNowFinishCount
            // 
            this.textBoxNowFinishCount.Location = new System.Drawing.Point(202, 672);
            this.textBoxNowFinishCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNowFinishCount.Name = "textBoxNowFinishCount";
            this.textBoxNowFinishCount.ReadOnly = true;
            this.textBoxNowFinishCount.Size = new System.Drawing.Size(110, 34);
            this.textBoxNowFinishCount.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 675);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 27);
            this.label7.TabIndex = 43;
            this.label7.Text = "MarkTotal:";
            // 
            // textBoxT1
            // 
            this.textBoxT1.Location = new System.Drawing.Point(126, 332);
            this.textBoxT1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxT1.Name = "textBoxT1";
            this.textBoxT1.ReadOnly = true;
            this.textBoxT1.Size = new System.Drawing.Size(186, 34);
            this.textBoxT1.TabIndex = 42;
            // 
            // textBoxT0
            // 
            this.textBoxT0.Location = new System.Drawing.Point(126, 264);
            this.textBoxT0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxT0.Name = "textBoxT0";
            this.textBoxT0.ReadOnly = true;
            this.textBoxT0.Size = new System.Drawing.Size(186, 34);
            this.textBoxT0.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 267);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 27);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ent0:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 89);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 70);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "退出/Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInitial
            // 
            this.btnInitial.Location = new System.Drawing.Point(13, 12);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(175, 70);
            this.btnInitial.TabIndex = 54;
            this.btnInitial.Text = "初始化/Initial";
            this.btnInitial.UseVisualStyleBackColor = true;
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 753);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInitial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxT5);
            this.Controls.Add(this.textBoxT4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxT3);
            this.Controls.Add(this.textBoxT2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNowFinishCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxT1);
            this.Controls.Add(this.textBoxT0);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSetcfg);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BJJCZ-Ezcad2.0-Fly";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSetcfg;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMark;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUpDataMarkData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxT5;
        private System.Windows.Forms.TextBox textBoxT4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxT3;
        private System.Windows.Forms.TextBox textBoxT2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNowFinishCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxT1;
        private System.Windows.Forms.TextBox textBoxT0;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInitial;
    }
}

