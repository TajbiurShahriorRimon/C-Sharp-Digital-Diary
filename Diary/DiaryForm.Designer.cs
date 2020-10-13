namespace Diary
{
    partial class DiaryForm
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
            this.storyText = new System.Windows.Forms.TextBox();
            this.done = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.modifiedTime = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eventName = new System.Windows.Forms.Label();
            this.eventText = new System.Windows.Forms.TextBox();
            this.createdText = new System.Windows.Forms.Label();
            this.createdTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.importanceBox = new System.Windows.Forms.ComboBox();
            this.importance = new System.Windows.Forms.Label();
            this.idLabel2 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.showPicture = new System.Windows.Forms.Button();
            this.evIdLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // storyText
            // 
            this.storyText.Location = new System.Drawing.Point(32, 64);
            this.storyText.Multiline = true;
            this.storyText.Name = "storyText";
            this.storyText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.storyText.Size = new System.Drawing.Size(441, 113);
            this.storyText.TabIndex = 0;
            this.storyText.Text = "Enter Your Feelings";
            // 
            // done
            // 
            this.done.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.done.Location = new System.Drawing.Point(368, 193);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(105, 38);
            this.done.TabIndex = 1;
            this.done.Text = "Done!";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(479, 193);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(111, 37);
            this.edit.TabIndex = 2;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // modifiedTime
            // 
            this.modifiedTime.AutoSize = true;
            this.modifiedTime.Location = new System.Drawing.Point(175, 243);
            this.modifiedTime.Name = "modifiedTime";
            this.modifiedTime.Size = new System.Drawing.Size(0, 17);
            this.modifiedTime.TabIndex = 3;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(679, 213);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 4;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox1.Location = new System.Drawing.Point(679, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eventName.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName.Location = new System.Drawing.Point(30, 35);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(103, 20);
            this.eventName.TabIndex = 6;
            this.eventName.Text = "Event Name";
            // 
            // eventText
            // 
            this.eventText.Location = new System.Drawing.Point(156, 36);
            this.eventText.Name = "eventText";
            this.eventText.Size = new System.Drawing.Size(231, 22);
            this.eventText.TabIndex = 7;
            // 
            // createdText
            // 
            this.createdText.AutoSize = true;
            this.createdText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.createdText.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdText.Location = new System.Drawing.Point(30, 208);
            this.createdText.Name = "createdText";
            this.createdText.Size = new System.Drawing.Size(65, 23);
            this.createdText.TabIndex = 8;
            this.createdText.Text = "Created";
            // 
            // createdTime
            // 
            this.createdTime.AutoSize = true;
            this.createdTime.Location = new System.Drawing.Point(153, 208);
            this.createdTime.Name = "createdTime";
            this.createdTime.Size = new System.Drawing.Size(46, 17);
            this.createdTime.TabIndex = 9;
            this.createdTime.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Modified";
            // 
            // importanceBox
            // 
            this.importanceBox.FormattingEnabled = true;
            this.importanceBox.Items.AddRange(new object[] {
            "High",
            "Moderate",
            "Less Important"});
            this.importanceBox.Location = new System.Drawing.Point(679, 55);
            this.importanceBox.Name = "importanceBox";
            this.importanceBox.Size = new System.Drawing.Size(136, 24);
            this.importanceBox.TabIndex = 11;
            // 
            // importance
            // 
            this.importance.AutoSize = true;
            this.importance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.importance.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importance.Location = new System.Drawing.Point(531, 55);
            this.importance.Name = "importance";
            this.importance.Size = new System.Drawing.Size(127, 26);
            this.importance.TabIndex = 12;
            this.importance.Text = "Importance";
            // 
            // idLabel2
            // 
            this.idLabel2.AutoSize = true;
            this.idLabel2.Location = new System.Drawing.Point(676, 342);
            this.idLabel2.Name = "idLabel2";
            this.idLabel2.Size = new System.Drawing.Size(46, 17);
            this.idLabel2.TabIndex = 13;
            this.idLabel2.Text = "label1";
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Location = new System.Drawing.Point(676, 386);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(46, 17);
            this.nameLabel2.TabIndex = 14;
            this.nameLabel2.Text = "label1";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(217, 363);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(256, 63);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // showPicture
            // 
            this.showPicture.Location = new System.Drawing.Point(760, 210);
            this.showPicture.Name = "showPicture";
            this.showPicture.Size = new System.Drawing.Size(77, 28);
            this.showPicture.TabIndex = 16;
            this.showPicture.Text = "Show";
            this.showPicture.UseVisualStyleBackColor = true;
            this.showPicture.Click += new System.EventHandler(this.showPicture_Click);
            // 
            // evIdLabel
            // 
            this.evIdLabel.AutoSize = true;
            this.evIdLabel.Location = new System.Drawing.Point(687, 421);
            this.evIdLabel.Name = "evIdLabel";
            this.evIdLabel.Size = new System.Drawing.Size(46, 17);
            this.evIdLabel.TabIndex = 17;
            this.evIdLabel.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(37, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 93);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // DiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(874, 490);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.evIdLabel);
            this.Controls.Add(this.showPicture);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nameLabel2);
            this.Controls.Add(this.idLabel2);
            this.Controls.Add(this.importance);
            this.Controls.Add(this.importanceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createdTime);
            this.Controls.Add(this.createdText);
            this.Controls.Add(this.eventText);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.modifiedTime);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.done);
            this.Controls.Add(this.storyText);
            this.Name = "DiaryForm";
            this.Text = "DiaryForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DiaryForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox storyText;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label modifiedTime;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label eventName;
        private System.Windows.Forms.TextBox eventText;
        private System.Windows.Forms.Label createdText;
        private System.Windows.Forms.Label createdTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox importanceBox;
        private System.Windows.Forms.Label importance;
        private System.Windows.Forms.Label idLabel2;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button showPicture;
        private System.Windows.Forms.Label evIdLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}