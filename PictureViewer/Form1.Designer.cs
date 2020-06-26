namespace PictureViewer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.closeBUTTON = new System.Windows.Forms.Button();
            this.backgroundColorBUTTON = new System.Windows.Forms.Button();
            this.clearPictureBUTTON = new System.Windows.Forms.Button();
            this.displayPictureBUTTON = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.72325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.27676F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.58147F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.41853F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 313);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 264);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(3, 273);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Fit?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.backgroundColorBUTTON);
            this.flowLayoutPanel1.Controls.Add(this.displayPictureBUTTON);
            this.flowLayoutPanel1.Controls.Add(this.clearPictureBUTTON);
            this.flowLayoutPanel1.Controls.Add(this.closeBUTTON);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(137, 273);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(402, 37);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // closeBUTTON
            // 
            this.closeBUTTON.AutoSize = true;
            this.closeBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBUTTON.ForeColor = System.Drawing.Color.Red;
            this.closeBUTTON.Location = new System.Drawing.Point(275, 3);
            this.closeBUTTON.Name = "closeBUTTON";
            this.closeBUTTON.Size = new System.Drawing.Size(85, 30);
            this.closeBUTTON.TabIndex = 0;
            this.closeBUTTON.Text = "CLOSE";
            this.closeBUTTON.UseVisualStyleBackColor = true;
            this.closeBUTTON.Click += new System.EventHandler(this.closeBUTTON_Click);
            // 
            // backgroundColorBUTTON
            // 
            this.backgroundColorBUTTON.AutoSize = true;
            this.backgroundColorBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundColorBUTTON.Location = new System.Drawing.Point(3, 3);
            this.backgroundColorBUTTON.Name = "backgroundColorBUTTON";
            this.backgroundColorBUTTON.Size = new System.Drawing.Size(112, 30);
            this.backgroundColorBUTTON.TabIndex = 1;
            this.backgroundColorBUTTON.Text = "Background";
            this.backgroundColorBUTTON.UseVisualStyleBackColor = true;
            this.backgroundColorBUTTON.Click += new System.EventHandler(this.backgroundColorBUTTON_Click);
            // 
            // clearPictureBUTTON
            // 
            this.clearPictureBUTTON.AutoSize = true;
            this.clearPictureBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearPictureBUTTON.Location = new System.Drawing.Point(206, 3);
            this.clearPictureBUTTON.Name = "clearPictureBUTTON";
            this.clearPictureBUTTON.Size = new System.Drawing.Size(63, 30);
            this.clearPictureBUTTON.TabIndex = 2;
            this.clearPictureBUTTON.Text = "Clear";
            this.clearPictureBUTTON.UseVisualStyleBackColor = true;
            this.clearPictureBUTTON.Click += new System.EventHandler(this.clearPictureBUTTON_Click);
            // 
            // displayPictureBUTTON
            // 
            this.displayPictureBUTTON.AutoSize = true;
            this.displayPictureBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPictureBUTTON.Location = new System.Drawing.Point(121, 3);
            this.displayPictureBUTTON.Name = "displayPictureBUTTON";
            this.displayPictureBUTTON.Size = new System.Drawing.Size(79, 30);
            this.displayPictureBUTTON.TabIndex = 3;
            this.displayPictureBUTTON.Text = "Display";
            this.displayPictureBUTTON.UseVisualStyleBackColor = true;
            this.displayPictureBUTTON.Click += new System.EventHandler(this.displayPictureBUTTON_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files(*.PNG*.BMP;*.JPG;*.GIF)|*.PNG*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Please Select an Image File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 313);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "PictureViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button closeBUTTON;
        private System.Windows.Forms.Button backgroundColorBUTTON;
        private System.Windows.Forms.Button clearPictureBUTTON;
        private System.Windows.Forms.Button displayPictureBUTTON;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

