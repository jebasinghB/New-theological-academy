namespace studentinfo
{
    
        partial class AddUser
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
                this.panel1 = new System.Windows.Forms.Panel();
                this.SuspendLayout();
                // 
                // panel1
                // 
                this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
                this.panel1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.panel1.Location = new System.Drawing.Point(-2, 1);
                this.panel1.Name = "panel1";
                this.panel1.Size = new System.Drawing.Size(1127, 87);
                this.panel1.TabIndex = 0;
                // 
                // AddUser
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
                this.ClientSize = new System.Drawing.Size(1129, 725);
                this.Controls.Add(this.panel1);
                this.Name = "AddUser";
                this.Text = "AddUser";
                this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Panel panel1;
        }
    
}