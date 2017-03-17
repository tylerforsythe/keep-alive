namespace KeepAlive
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnPauseResume = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeUntilRefresh = new System.Windows.Forms.Label();
            this.txtUrlsToKeepAlive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.prgbarStatus = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.Location = new System.Drawing.Point(16, 91);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(119, 23);
            this.btnPauseResume.TabIndex = 0;
            this.btnPauseResume.Text = "Pause / Resume";
            this.btnPauseResume.UseVisualStyleBackColor = true;
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Until Next Refresh:";
            // 
            // lblTimeUntilRefresh
            // 
            this.lblTimeUntilRefresh.AutoSize = true;
            this.lblTimeUntilRefresh.Location = new System.Drawing.Point(16, 64);
            this.lblTimeUntilRefresh.Name = "lblTimeUntilRefresh";
            this.lblTimeUntilRefresh.Size = new System.Drawing.Size(26, 13);
            this.lblTimeUntilRefresh.TabIndex = 2;
            this.lblTimeUntilRefresh.Text = "time";
            // 
            // txtUrlsToKeepAlive
            // 
            this.txtUrlsToKeepAlive.AcceptsReturn = true;
            this.txtUrlsToKeepAlive.Location = new System.Drawing.Point(16, 152);
            this.txtUrlsToKeepAlive.Multiline = true;
            this.txtUrlsToKeepAlive.Name = "txtUrlsToKeepAlive";
            this.txtUrlsToKeepAlive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUrlsToKeepAlive.Size = new System.Drawing.Size(362, 118);
            this.txtUrlsToKeepAlive.TabIndex = 3;
            this.txtUrlsToKeepAlive.Text = "http://imlocal:8080,http://lucylocal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "URLs to Keep Alive: (csv && || line break)";
            // 
            // txtStatus
            // 
            this.txtStatus.AcceptsReturn = true;
            this.txtStatus.Location = new System.Drawing.Point(19, 314);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(362, 118);
            this.txtStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "URL Keep Alive Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Keep Alive";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(319, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // prgbarStatus
            // 
            this.prgbarStatus.Location = new System.Drawing.Point(141, 285);
            this.prgbarStatus.Name = "prgbarStatus";
            this.prgbarStatus.Size = new System.Drawing.Size(237, 23);
            this.prgbarStatus.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 459);
            this.Controls.Add(this.prgbarStatus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrlsToKeepAlive);
            this.Controls.Add(this.lblTimeUntilRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPauseResume);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPauseResume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeUntilRefresh;
        private System.Windows.Forms.TextBox txtUrlsToKeepAlive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ProgressBar prgbarStatus;
    }
}

