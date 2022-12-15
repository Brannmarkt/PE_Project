
namespace PE_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SHA1_textbox = new System.Windows.Forms.TextBox();
            this.SHA256_textbox = new System.Windows.Forms.TextBox();
            this.File_Size_textbox = new System.Windows.Forms.TextBox();
            this.File_Type_textbox = new System.Windows.Forms.TextBox();
            this.File_Bit_Rate_textbox = new System.Windows.Forms.TextBox();
            this.Get_Info_button = new System.Windows.Forms.Button();
            this.Link_textbox = new System.Windows.Forms.TextBox();
            this.Link = new System.Windows.Forms.Label();
            this.Bites_richtextbox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHA-1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "SHA-256";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "File size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "File type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "File bit rate";
            // 
            // SHA1_textbox
            // 
            this.SHA1_textbox.Location = new System.Drawing.Point(146, 128);
            this.SHA1_textbox.Name = "SHA1_textbox";
            this.SHA1_textbox.Size = new System.Drawing.Size(769, 31);
            this.SHA1_textbox.TabIndex = 5;
            // 
            // SHA256_textbox
            // 
            this.SHA256_textbox.Location = new System.Drawing.Point(146, 174);
            this.SHA256_textbox.Name = "SHA256_textbox";
            this.SHA256_textbox.Size = new System.Drawing.Size(769, 31);
            this.SHA256_textbox.TabIndex = 6;
            // 
            // File_Size_textbox
            // 
            this.File_Size_textbox.Location = new System.Drawing.Point(146, 219);
            this.File_Size_textbox.Name = "File_Size_textbox";
            this.File_Size_textbox.Size = new System.Drawing.Size(769, 31);
            this.File_Size_textbox.TabIndex = 7;
            // 
            // File_Type_textbox
            // 
            this.File_Type_textbox.Location = new System.Drawing.Point(146, 268);
            this.File_Type_textbox.Name = "File_Type_textbox";
            this.File_Type_textbox.Size = new System.Drawing.Size(769, 31);
            this.File_Type_textbox.TabIndex = 8;
            // 
            // File_Bit_Rate_textbox
            // 
            this.File_Bit_Rate_textbox.Location = new System.Drawing.Point(146, 316);
            this.File_Bit_Rate_textbox.Name = "File_Bit_Rate_textbox";
            this.File_Bit_Rate_textbox.Size = new System.Drawing.Size(769, 31);
            this.File_Bit_Rate_textbox.TabIndex = 9;
            // 
            // Get_Info_button
            // 
            this.Get_Info_button.Location = new System.Drawing.Point(392, 79);
            this.Get_Info_button.Name = "Get_Info_button";
            this.Get_Info_button.Size = new System.Drawing.Size(112, 34);
            this.Get_Info_button.TabIndex = 10;
            this.Get_Info_button.Text = "Get Info";
            this.Get_Info_button.UseVisualStyleBackColor = true;
            this.Get_Info_button.Click += new System.EventHandler(this.Get_Info_button_Click);
            // 
            // Link_textbox
            // 
            this.Link_textbox.Location = new System.Drawing.Point(265, 30);
            this.Link_textbox.Name = "Link_textbox";
            this.Link_textbox.Size = new System.Drawing.Size(373, 31);
            this.Link_textbox.TabIndex = 11;
            this.Link_textbox.TextChanged += new System.EventHandler(this.Link_textbox_TextChanged);
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Location = new System.Drawing.Point(205, 33);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(43, 25);
            this.Link.TabIndex = 12;
            this.Link.Text = "Link";
            this.Link.Click += new System.EventHandler(this.Link_Click);
            // 
            // Bites_richtextbox
            // 
            this.Bites_richtextbox.Location = new System.Drawing.Point(146, 362);
            this.Bites_richtextbox.Name = "Bites_richtextbox";
            this.Bites_richtextbox.Size = new System.Drawing.Size(769, 215);
            this.Bites_richtextbox.TabIndex = 13;
            this.Bites_richtextbox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bytes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 589);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Bites_richtextbox);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.Link_textbox);
            this.Controls.Add(this.Get_Info_button);
            this.Controls.Add(this.File_Bit_Rate_textbox);
            this.Controls.Add(this.File_Type_textbox);
            this.Controls.Add(this.File_Size_textbox);
            this.Controls.Add(this.SHA256_textbox);
            this.Controls.Add(this.SHA1_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SHA1_textbox;
        private System.Windows.Forms.TextBox SHA256_textbox;
        private System.Windows.Forms.TextBox File_Size_textbox;
        private System.Windows.Forms.TextBox File_Type_textbox;
        private System.Windows.Forms.TextBox File_Bit_Rate_textbox;
        private System.Windows.Forms.Button Get_Info_button;
        private System.Windows.Forms.TextBox Link_textbox;
        private System.Windows.Forms.Label Link;
        private System.Windows.Forms.RichTextBox Bites_richtextbox;
        private System.Windows.Forms.Label label6;
    }
}

