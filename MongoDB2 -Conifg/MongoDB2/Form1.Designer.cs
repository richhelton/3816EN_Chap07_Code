namespace MongoDB2
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
            this.btnDeleteUnicasts = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteEndpoints = new System.Windows.Forms.Button();
            this.btnGetEndpoints = new System.Windows.Forms.Button();
            this.btnGetUnicasts = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateData = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteUnicasts
            // 
            this.btnDeleteUnicasts.Location = new System.Drawing.Point(322, 11);
            this.btnDeleteUnicasts.Name = "btnDeleteUnicasts";
            this.btnDeleteUnicasts.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteUnicasts.TabIndex = 6;
            this.btnDeleteUnicasts.Text = "Delete Unicasts";
            this.btnDeleteUnicasts.UseVisualStyleBackColor = true;
            this.btnDeleteUnicasts.Click += new System.EventHandler(this.btnDeleteUnicasts_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDeleteEndpoints
            // 
            this.btnDeleteEndpoints.Location = new System.Drawing.Point(441, 12);
            this.btnDeleteEndpoints.Name = "btnDeleteEndpoints";
            this.btnDeleteEndpoints.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteEndpoints.TabIndex = 7;
            this.btnDeleteEndpoints.Text = "Delete Endpoints";
            this.btnDeleteEndpoints.UseVisualStyleBackColor = true;
            this.btnDeleteEndpoints.Click += new System.EventHandler(this.btnDeleteEndpoints_Click);
            // 
            // btnGetEndpoints
            // 
            this.btnGetEndpoints.Location = new System.Drawing.Point(222, 11);
            this.btnGetEndpoints.Name = "btnGetEndpoints";
            this.btnGetEndpoints.Size = new System.Drawing.Size(94, 23);
            this.btnGetEndpoints.TabIndex = 5;
            this.btnGetEndpoints.Text = "Get Message Endpoins";
            this.btnGetEndpoints.UseVisualStyleBackColor = true;
            this.btnGetEndpoints.Click += new System.EventHandler(this.btnGetEndpoints_Click);
            // 
            // btnGetUnicasts
            // 
            this.btnGetUnicasts.Location = new System.Drawing.Point(118, 12);
            this.btnGetUnicasts.Name = "btnGetUnicasts";
            this.btnGetUnicasts.Size = new System.Drawing.Size(98, 23);
            this.btnGetUnicasts.TabIndex = 4;
            this.btnGetUnicasts.Text = "Get Unicasts";
            this.btnGetUnicasts.UseVisualStyleBackColor = true;
            this.btnGetUnicasts.Click += new System.EventHandler(this.btnGetUnicasts_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteEndpoints);
            this.panel1.Controls.Add(this.btnDeleteUnicasts);
            this.panel1.Controls.Add(this.btnGetEndpoints);
            this.panel1.Controls.Add(this.btnGetUnicasts);
            this.panel1.Controls.Add(this.btnCreateData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 69);
            this.panel1.TabIndex = 2;
            // 
            // btnCreateData
            // 
            this.btnCreateData.Location = new System.Drawing.Point(12, 12);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(100, 23);
            this.btnCreateData.TabIndex = 3;
            this.btnCreateData.Text = "Create Data";
            this.btnCreateData.UseVisualStyleBackColor = true;
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 297);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteUnicasts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteEndpoints;
        private System.Windows.Forms.Button btnGetEndpoints;
        private System.Windows.Forms.Button btnGetUnicasts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateData;
        private System.Windows.Forms.Panel panel2;
    }
}

