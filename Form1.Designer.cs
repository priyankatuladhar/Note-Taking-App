namespace NoteTakingApp
{
    partial class NoteTaker
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
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.PreviousNote = new System.Windows.Forms.DataGridView();
            this.Load_Button = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousNote)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.Color.Lavender;
            this.TitleBox.Location = new System.Drawing.Point(684, 56);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(692, 26);
            this.TitleBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(680, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(681, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // note
            // 
            this.note.BackColor = System.Drawing.Color.Lavender;
            this.note.Location = new System.Drawing.Point(684, 142);
            this.note.Multiline = true;
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(692, 559);
            this.note.TabIndex = 4;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Lavender;
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(330, 650);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(216, 51);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // PreviousNote
            // 
            this.PreviousNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PreviousNote.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.PreviousNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreviousNote.Location = new System.Drawing.Point(12, 20);
            this.PreviousNote.Name = "PreviousNote";
            this.PreviousNote.RowHeadersWidth = 62;
            this.PreviousNote.RowTemplate.Height = 28;
            this.PreviousNote.Size = new System.Drawing.Size(638, 552);
            this.PreviousNote.TabIndex = 10;
            this.PreviousNote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PreviousNote_CellContentClick);
            // 
            // Load_Button
            // 
            this.Load_Button.BackColor = System.Drawing.Color.Lavender;
            this.Load_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Load_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Button.Location = new System.Drawing.Point(89, 590);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(216, 51);
            this.Load_Button.TabIndex = 11;
            this.Load_Button.Text = "Load";
            this.Load_Button.UseVisualStyleBackColor = false;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click_1);
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.Color.Lavender;
            this.New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(89, 650);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(216, 51);
            this.New.TabIndex = 12;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Lavender;
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(330, 590);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(216, 51);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1388, 760);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.PreviousNote);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.note);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleBox);
            this.Name = "NoteTaker";
            this.Text = "Note Taker";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreviousNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView PreviousNote;
        private System.Windows.Forms.Button Load_Button;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Delete;
    }
}

