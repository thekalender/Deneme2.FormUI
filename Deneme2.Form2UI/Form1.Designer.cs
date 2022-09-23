namespace Deneme2.Form2UI
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
            this.dgrwStudent = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrwStudent
            // 
            this.dgrwStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrwStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrwStudent.Location = new System.Drawing.Point(0, 0);
            this.dgrwStudent.Name = "dgrwStudent";
            this.dgrwStudent.RowHeadersWidth = 56;
            this.dgrwStudent.RowTemplate.Height = 31;
            this.dgrwStudent.Size = new System.Drawing.Size(800, 204);
            this.dgrwStudent.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(282, 246);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 21);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id : ";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(313, 243);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(208, 29);
            this.tbxId.TabIndex = 2;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(313, 278);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(208, 29);
            this.tbxFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(219, 281);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 21);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name : ";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(313, 313);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(208, 29);
            this.tbxLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(221, 316);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 21);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name : ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(367, 348);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgrwStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrwStudent;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnAdd;
    }
}
