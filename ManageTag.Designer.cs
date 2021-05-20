namespace TimeTableM
{
    partial class ManageTag
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTag));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonview = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRelatedTag = new System.Windows.Forms.ComboBox();
            this.txtSubjectTagCode = new System.Windows.Forms.TextBox();
            this.txtSubjectTagName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtSubCodeSearch = new System.Windows.Forms.TextBox();
            this.dgvMgTag = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMgTag)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label6.Location = new System.Drawing.Point(137, 546);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(127, 26);
            label6.TabIndex = 37;
            label6.Text = "Related Tag";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label4.Location = new System.Drawing.Point(137, 494);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(180, 26);
            label4.TabIndex = 35;
            label4.Text = "Subject Tag Code";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.buttonview);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbRelatedTag);
            this.panel2.Controls.Add(this.txtSubjectTagCode);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(this.txtSubjectTagName);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.txtSubCodeSearch);
            this.panel2.Controls.Add(this.dgvMgTag);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.SpringGreen;
            this.panel2.Location = new System.Drawing.Point(-9, -5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 676);
            this.panel2.TabIndex = 5;
            // 
            // buttonview
            // 
            this.buttonview.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonview.ForeColor = System.Drawing.Color.White;
            this.buttonview.Location = new System.Drawing.Point(40, 106);
            this.buttonview.Margin = new System.Windows.Forms.Padding(2);
            this.buttonview.Name = "buttonview";
            this.buttonview.Size = new System.Drawing.Size(62, 42);
            this.buttonview.TabIndex = 41;
            this.buttonview.Text = "VIEW";
            this.buttonview.UseVisualStyleBackColor = false;
            this.buttonview.Click += new System.EventHandler(this.buttonview_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(657, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tag Code";
            // 
            // cmbRelatedTag
            // 
            this.cmbRelatedTag.FormattingEnabled = true;
            this.cmbRelatedTag.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Lab"});
            this.cmbRelatedTag.Location = new System.Drawing.Point(344, 543);
            this.cmbRelatedTag.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRelatedTag.Name = "cmbRelatedTag";
            this.cmbRelatedTag.Size = new System.Drawing.Size(333, 30);
            this.cmbRelatedTag.TabIndex = 39;
            // 
            // txtSubjectTagCode
            // 
            this.txtSubjectTagCode.Location = new System.Drawing.Point(344, 492);
            this.txtSubjectTagCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubjectTagCode.Name = "txtSubjectTagCode";
            this.txtSubjectTagCode.Size = new System.Drawing.Size(333, 29);
            this.txtSubjectTagCode.TabIndex = 38;
            this.txtSubjectTagCode.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtSubjectTagName
            // 
            this.txtSubjectTagName.Location = new System.Drawing.Point(344, 440);
            this.txtSubjectTagName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubjectTagName.Name = "txtSubjectTagName";
            this.txtSubjectTagName.Size = new System.Drawing.Size(333, 29);
            this.txtSubjectTagName.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(137, 439);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "Subject Tag Name";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Honeydew;
            this.button6.Location = new System.Drawing.Point(896, 83);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 39);
            this.button6.TabIndex = 32;
            this.button6.Text = "SEARCH";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtSubCodeSearch
            // 
            this.txtSubCodeSearch.Location = new System.Drawing.Point(752, 93);
            this.txtSubCodeSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubCodeSearch.Name = "txtSubCodeSearch";
            this.txtSubCodeSearch.Size = new System.Drawing.Size(120, 29);
            this.txtSubCodeSearch.TabIndex = 31;
            // 
            // dgvMgTag
            // 
            this.dgvMgTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMgTag.Location = new System.Drawing.Point(142, 134);
            this.dgvMgTag.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMgTag.Name = "dgvMgTag";
            this.dgvMgTag.RowTemplate.Height = 24;
            this.dgvMgTag.Size = new System.Drawing.Size(504, 276);
            this.dgvMgTag.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(708, 193);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 37);
            this.button3.TabIndex = 19;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(708, 275);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(708, 362);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(896, 32);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "HOME";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(881, 624);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "WE_R_51";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(323, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Tag";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManageTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 609);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageTag";
            this.Text = "Manage Tag";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMgTag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtSubCodeSearch;
        private System.Windows.Forms.DataGridView dgvMgTag;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRelatedTag;
        private System.Windows.Forms.TextBox txtSubjectTagCode;
        private System.Windows.Forms.TextBox txtSubjectTagName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonview;
        private System.Windows.Forms.Label label5;
    }
}