namespace Detyra
{
    partial class Konfigurim
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
            this.txt_titulli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pershkrimi = new System.Windows.Forms.TextBox();
            this.btn_doc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_doc = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txt_titulli
            // 
            this.txt_titulli.Location = new System.Drawing.Point(134, 76);
            this.txt_titulli.Name = "txt_titulli";
            this.txt_titulli.Size = new System.Drawing.Size(316, 20);
            this.txt_titulli.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulli  i Kerkeses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pershkrimi i Kerkeses";
            // 
            // txt_pershkrimi
            // 
            this.txt_pershkrimi.Location = new System.Drawing.Point(134, 110);
            this.txt_pershkrimi.Multiline = true;
            this.txt_pershkrimi.Name = "txt_pershkrimi";
            this.txt_pershkrimi.Size = new System.Drawing.Size(316, 164);
            this.txt_pershkrimi.TabIndex = 2;
            // 
            // btn_doc
            // 
            this.btn_doc.Location = new System.Drawing.Point(343, 291);
            this.btn_doc.Name = "btn_doc";
            this.btn_doc.Size = new System.Drawing.Size(107, 23);
            this.btn_doc.TabIndex = 3;
            this.btn_doc.Text = "Shto Dokumentin";
            this.btn_doc.UseVisualStyleBackColor = true;
            this.btn_doc.Click += new System.EventHandler(this.Btn_doc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dokumenti i Kerkeses:";
            // 
            // txt_doc
            // 
            this.txt_doc.AutoSize = true;
            this.txt_doc.Location = new System.Drawing.Point(131, 301);
            this.txt_doc.Name = "txt_doc";
            this.txt_doc.Size = new System.Drawing.Size(69, 13);
            this.txt_doc.TabIndex = 1;
            this.txt_doc.Text = "no document";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(182, 361);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(12, 25);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(438, 29);
            this.txt_name.TabIndex = 5;
            this.txt_name.Text = "Shto nje kerksese";
            this.txt_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Konfigurim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 396);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_doc);
            this.Controls.Add(this.txt_pershkrimi);
            this.Controls.Add(this.txt_doc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_titulli);
            this.Name = "Konfigurim";
            this.Text = "Konfigurim";
            this.Load += new System.EventHandler(this.Konfigurim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_titulli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_pershkrimi;
        private System.Windows.Forms.Button btn_doc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_doc;
        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}