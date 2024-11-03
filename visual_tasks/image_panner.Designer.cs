namespace visual_tasks
{
    partial class image_panner
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
            this.deletebtn = new System.Windows.Forms.Button();
            this.buttonAdd_Click = new System.Windows.Forms.Button();
            this.buttonPrevious_Click = new System.Windows.Forms.Button();
            this.buttonNext_Click = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(627, 260);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 9;
            this.deletebtn.Text = "dd";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // buttonAdd_Click
            // 
            this.buttonAdd_Click.Location = new System.Drawing.Point(603, 154);
            this.buttonAdd_Click.Name = "buttonAdd_Click";
            this.buttonAdd_Click.Size = new System.Drawing.Size(139, 31);
            this.buttonAdd_Click.TabIndex = 8;
            this.buttonAdd_Click.Text = "add ";
            this.buttonAdd_Click.UseVisualStyleBackColor = true;
            this.buttonAdd_Click.Click += new System.EventHandler(this.buttonAdd_Click_Click);
            // 
            // buttonPrevious_Click
            // 
            this.buttonPrevious_Click.Location = new System.Drawing.Point(366, 364);
            this.buttonPrevious_Click.Name = "buttonPrevious_Click";
            this.buttonPrevious_Click.Size = new System.Drawing.Size(230, 27);
            this.buttonPrevious_Click.TabIndex = 7;
            this.buttonPrevious_Click.Text = "previous";
            this.buttonPrevious_Click.UseVisualStyleBackColor = true;
            this.buttonPrevious_Click.Click += new System.EventHandler(this.buttonPrevious_Click_Click);
            // 
            // buttonNext_Click
            // 
            this.buttonNext_Click.Location = new System.Drawing.Point(93, 359);
            this.buttonNext_Click.Name = "buttonNext_Click";
            this.buttonNext_Click.Size = new System.Drawing.Size(227, 32);
            this.buttonNext_Click.TabIndex = 6;
            this.buttonNext_Click.Text = "next";
            this.buttonNext_Click.UseVisualStyleBackColor = true;
            this.buttonNext_Click.Click += new System.EventHandler(this.buttonNext_Click_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(59, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 235);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 235);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // image_panner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.buttonAdd_Click);
            this.Controls.Add(this.buttonPrevious_Click);
            this.Controls.Add(this.buttonNext_Click);
            this.Controls.Add(this.groupBox1);
            this.Name = "image_panner";
            this.Text = "image_panner";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button buttonAdd_Click;
        private System.Windows.Forms.Button buttonPrevious_Click;
        private System.Windows.Forms.Button buttonNext_Click;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}