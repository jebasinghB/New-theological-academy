namespace studentinfo
{
   
        partial class Form2
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
                this.pictureBox1 = new System.Windows.Forms.PictureBox();
                this.label1 = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.label3 = new System.Windows.Forms.Label();
                this.dataGridView1 = new System.Windows.Forms.DataGridView();
                this.button1 = new System.Windows.Forms.Button();
                this.button2 = new System.Windows.Forms.Button();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
                this.SuspendLayout();
                // 
                // pictureBox1
                // 
                this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
                this.pictureBox1.Location = new System.Drawing.Point(1, 3);
                this.pictureBox1.Name = "pictureBox1";
                this.pictureBox1.Size = new System.Drawing.Size(1200, 702);
                this.pictureBox1.TabIndex = 0;
                this.pictureBox1.TabStop = false;
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
                this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
                this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.label1.Location = new System.Drawing.Point(27, 29);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(487, 67);
                this.label1.TabIndex = 1;
                this.label1.Text = "     Fees Detail";
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label2.Location = new System.Drawing.Point(32, 215);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(265, 37);
                this.label2.TabIndex = 2;
                this.label2.Text = "Student Reg NO";
                // 
                // textBox1
                // 
                this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBox1.Location = new System.Drawing.Point(353, 212);
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(229, 44);
                this.textBox1.TabIndex = 3;
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label3.Location = new System.Drawing.Point(33, 335);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(354, 32);
                this.label3.TabIndex = 4;
                this.label3.Text = "Over All Fees Statement ";
                // 
                // dataGridView1
                // 
                this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
                this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dataGridView1.Location = new System.Drawing.Point(91, 381);
                this.dataGridView1.Name = "dataGridView1";
                this.dataGridView1.RowTemplate.Height = 28;
                this.dataGridView1.Size = new System.Drawing.Size(839, 304);
                this.dataGridView1.TabIndex = 5;
                // 
                // button1
                // 
                this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
                this.button1.Location = new System.Drawing.Point(656, 212);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(75, 44);
                this.button1.TabIndex = 6;
                this.button1.UseVisualStyleBackColor = true;
                // 
                // button2
                // 
                this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
                this.button2.Location = new System.Drawing.Point(807, 212);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(75, 44);
                this.button2.TabIndex = 7;
                this.button2.UseVisualStyleBackColor = true;
                // 
                // Form2
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(1199, 706);
                this.Controls.Add(this.button2);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.dataGridView1);
                this.Controls.Add(this.label3);
                this.Controls.Add(this.textBox1);
                this.Controls.Add(this.label2);
                this.Controls.Add(this.label1);
                this.Controls.Add(this.pictureBox1);
                this.Name = "Form2";
                this.Text = "Form2";
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.PictureBox pictureBox1;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.TextBox textBox1;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.DataGridView dataGridView1;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.Button button2;
        }
    }
