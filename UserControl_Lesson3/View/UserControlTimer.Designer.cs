namespace UserControl_Lesson3.View
{
    partial class UserControlTimer
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
            this.components = new System.ComponentModel.Container();
            this.imgSecondSc = new System.Windows.Forms.PictureBox();
            this.imgMinuteFr = new System.Windows.Forms.PictureBox();
            this.imgSecondFr = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.imgSeperate = new System.Windows.Forms.PictureBox();
            this.imgMinuteSc = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgSecondSc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinuteFr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSecondFr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeperate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinuteSc)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSecondSc
            // 
            this.imgSecondSc.Image = global::UserControl_Lesson3.Properties.Resources._0;
            this.imgSecondSc.Location = new System.Drawing.Point(139, 19);
            this.imgSecondSc.Name = "imgSecondSc";
            this.imgSecondSc.Size = new System.Drawing.Size(20, 30);
            this.imgSecondSc.TabIndex = 14;
            this.imgSecondSc.TabStop = false;
            // 
            // imgMinuteFr
            // 
            this.imgMinuteFr.Image = global::UserControl_Lesson3.Properties.Resources._0;
            this.imgMinuteFr.Location = new System.Drawing.Point(45, 19);
            this.imgMinuteFr.Name = "imgMinuteFr";
            this.imgMinuteFr.Size = new System.Drawing.Size(20, 30);
            this.imgMinuteFr.TabIndex = 13;
            this.imgMinuteFr.TabStop = false;
            // 
            // imgSecondFr
            // 
            this.imgSecondFr.Image = global::UserControl_Lesson3.Properties.Resources._0;
            this.imgSecondFr.Location = new System.Drawing.Point(116, 19);
            this.imgSecondFr.Name = "imgSecondFr";
            this.imgSecondFr.Size = new System.Drawing.Size(20, 30);
            this.imgSecondFr.TabIndex = 12;
            this.imgSecondFr.TabStop = false;
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(103, 72);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(87, 33);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 72);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 33);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imgSeperate
            // 
            this.imgSeperate.Image = global::UserControl_Lesson3.Properties.Resources._;
            this.imgSeperate.Location = new System.Drawing.Point(92, 19);
            this.imgSeperate.Name = "imgSeperate";
            this.imgSeperate.Size = new System.Drawing.Size(18, 30);
            this.imgSeperate.TabIndex = 9;
            this.imgSeperate.TabStop = false;
            // 
            // imgMinuteSc
            // 
            this.imgMinuteSc.Image = global::UserControl_Lesson3.Properties.Resources._0;
            this.imgMinuteSc.Location = new System.Drawing.Point(68, 19);
            this.imgMinuteSc.Name = "imgMinuteSc";
            this.imgMinuteSc.Size = new System.Drawing.Size(20, 30);
            this.imgMinuteSc.TabIndex = 8;
            this.imgMinuteSc.TabStop = false;
            // 
            // UserControlTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.imgSecondSc);
            this.Controls.Add(this.imgMinuteFr);
            this.Controls.Add(this.imgSecondFr);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.imgSeperate);
            this.Controls.Add(this.imgMinuteSc);
            this.Name = "UserControlTimer";
            this.Size = new System.Drawing.Size(208, 170);
            ((System.ComponentModel.ISupportInitialize)(this.imgSecondSc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinuteFr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSecondFr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeperate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinuteSc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgSecondSc;
        private System.Windows.Forms.PictureBox imgMinuteFr;
        private System.Windows.Forms.PictureBox imgSecondFr;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox imgSeperate;
        private System.Windows.Forms.PictureBox imgMinuteSc;
        private System.Windows.Forms.Timer timer;
    }
}
