namespace Detyra
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
            this.txt_filter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_shto = new System.Windows.Forms.Button();
            this.btn_modifiko = new System.Windows.Forms.Button();
            this.btn_lexo = new System.Windows.Forms.Button();
            this.btn_shkarko = new System.Windows.Forms.Button();
            this.txt_refresh = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_filter
            // 
            this.txt_filter.Location = new System.Drawing.Point(101, 12);
            this.txt_filter.Name = "txt_filter";
            this.txt_filter.Size = new System.Drawing.Size(342, 20);
            this.txt_filter.TabIndex = 0;
            this.txt_filter.TextChanged += new System.EventHandler(this.Txt_filter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kerko Kerkesen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(658, 370);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_shto
            // 
            this.btn_shto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_shto.Location = new System.Drawing.Point(12, 415);
            this.btn_shto.Name = "btn_shto";
            this.btn_shto.Size = new System.Drawing.Size(83, 23);
            this.btn_shto.TabIndex = 3;
            this.btn_shto.Text = "Shto";
            this.btn_shto.UseVisualStyleBackColor = true;
            this.btn_shto.Click += new System.EventHandler(this.Btn_shto_Click);
            // 
            // btn_modifiko
            // 
            this.btn_modifiko.Location = new System.Drawing.Point(101, 415);
            this.btn_modifiko.Name = "btn_modifiko";
            this.btn_modifiko.Size = new System.Drawing.Size(90, 23);
            this.btn_modifiko.TabIndex = 4;
            this.btn_modifiko.Text = "Modifiko";
            this.btn_modifiko.UseVisualStyleBackColor = true;
            this.btn_modifiko.Click += new System.EventHandler(this.Btn_modifiko_Click);
            // 
            // btn_lexo
            // 
            this.btn_lexo.Location = new System.Drawing.Point(198, 415);
            this.btn_lexo.Name = "btn_lexo";
            this.btn_lexo.Size = new System.Drawing.Size(86, 23);
            this.btn_lexo.TabIndex = 5;
            this.btn_lexo.Text = "Lexo";
            this.btn_lexo.UseVisualStyleBackColor = true;
            this.btn_lexo.Click += new System.EventHandler(this.Btn_lexo_Click);
            // 
            // btn_shkarko
            // 
            this.btn_shkarko.Location = new System.Drawing.Point(545, 415);
            this.btn_shkarko.Name = "btn_shkarko";
            this.btn_shkarko.Size = new System.Drawing.Size(125, 23);
            this.btn_shkarko.TabIndex = 6;
            this.btn_shkarko.Text = "Shkarko Dokumentin";
            this.btn_shkarko.UseVisualStyleBackColor = true;
            this.btn_shkarko.Click += new System.EventHandler(this.Btn_shkarko_Click);
            // 
            // txt_refresh
            // 
            this.txt_refresh.Location = new System.Drawing.Point(595, 9);
            this.txt_refresh.Name = "txt_refresh";
            this.txt_refresh.Size = new System.Drawing.Size(75, 23);
            this.txt_refresh.TabIndex = 7;
            this.txt_refresh.Text = "Refresh";
            this.txt_refresh.UseVisualStyleBackColor = true;
            this.txt_refresh.Click += new System.EventHandler(this.Txt_refresh_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_delete.Location = new System.Drawing.Point(291, 415);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_delete.Size = new System.Drawing.Size(90, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.UseWaitCursor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_refresh);
            this.Controls.Add(this.btn_shkarko);
            this.Controls.Add(this.btn_lexo);
            this.Controls.Add(this.btn_modifiko);
            this.Controls.Add(this.btn_shto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_filter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_shto;
        private System.Windows.Forms.Button btn_modifiko;
        private System.Windows.Forms.Button btn_lexo;
        private System.Windows.Forms.Button btn_shkarko;
        private System.Windows.Forms.Button txt_refresh;
        private System.Windows.Forms.Button btn_delete;
    }
}

