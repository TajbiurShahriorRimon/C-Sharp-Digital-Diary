namespace Diary
{
    partial class User
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
            this.createNewEvent = new System.Windows.Forms.Button();
            this.eventListTable = new System.Windows.Forms.DataGridView();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // createNewEvent
            // 
            this.createNewEvent.BackColor = System.Drawing.Color.Purple;
            this.createNewEvent.Font = new System.Drawing.Font("Stencil", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewEvent.Location = new System.Drawing.Point(73, 137);
            this.createNewEvent.Name = "createNewEvent";
            this.createNewEvent.Size = new System.Drawing.Size(297, 99);
            this.createNewEvent.TabIndex = 0;
            this.createNewEvent.Text = "Create New Event!";
            this.createNewEvent.UseVisualStyleBackColor = false;
            this.createNewEvent.Click += new System.EventHandler(this.createNewEvent_Click);
            // 
            // eventListTable
            // 
            this.eventListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventListTable.Location = new System.Drawing.Point(521, 83);
            this.eventListTable.Name = "eventListTable";
            this.eventListTable.ReadOnly = true;
            this.eventListTable.RowHeadersWidth = 51;
            this.eventListTable.RowTemplate.Height = 24;
            this.eventListTable.Size = new System.Drawing.Size(259, 246);
            this.eventListTable.TabIndex = 1;
            this.eventListTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventListTable_CellClick);
            // 
            // idLabel1
            // 
            this.idLabel1.AutoSize = true;
            this.idLabel1.Location = new System.Drawing.Point(70, 59);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(46, 17);
            this.idLabel1.TabIndex = 2;
            this.idLabel1.Text = "label1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Location = new System.Drawing.Point(73, 95);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(46, 17);
            this.nameLabel1.TabIndex = 3;
            this.nameLabel1.Text = "label1";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(521, 359);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(110, 41);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(664, 355);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 44);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "label1";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(this.eventListTable);
            this.Controls.Add(this.createNewEvent);
            this.Name = "User";
            this.Text = "User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.User_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.eventListTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewEvent;
        private System.Windows.Forms.DataGridView eventListTable;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label6;
    }
}