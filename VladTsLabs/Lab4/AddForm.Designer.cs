namespace Lab4
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.bookAuthors = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookSubjectHeadings = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bookPublisher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bookYear = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.bookCirculating = new System.Windows.Forms.CheckBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.bookLccn = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bookYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookLccn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // bookTitle
            // 
            this.bookTitle.Location = new System.Drawing.Point(224, 23);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(587, 29);
            this.bookTitle.TabIndex = 1;
            // 
            // bookAuthors
            // 
            this.bookAuthors.Location = new System.Drawing.Point(224, 74);
            this.bookAuthors.Name = "bookAuthors";
            this.bookAuthors.Size = new System.Drawing.Size(587, 29);
            this.bookAuthors.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Authors";
            // 
            // bookSubjectHeadings
            // 
            this.bookSubjectHeadings.Location = new System.Drawing.Point(224, 179);
            this.bookSubjectHeadings.Name = "bookSubjectHeadings";
            this.bookSubjectHeadings.Size = new System.Drawing.Size(587, 29);
            this.bookSubjectHeadings.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subject Headings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "LCCN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Year";
            // 
            // bookPublisher
            // 
            this.bookPublisher.Location = new System.Drawing.Point(224, 228);
            this.bookPublisher.Name = "bookPublisher";
            this.bookPublisher.Size = new System.Drawing.Size(587, 29);
            this.bookPublisher.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Publisher";
            // 
            // bookYear
            // 
            this.bookYear.Location = new System.Drawing.Point(224, 280);
            this.bookYear.Maximum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.bookYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.bookYear.Name = "bookYear";
            this.bookYear.Size = new System.Drawing.Size(120, 29);
            this.bookYear.TabIndex = 12;
            this.bookYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Circulating?";
            // 
            // bookCirculating
            // 
            this.bookCirculating.AutoSize = true;
            this.bookCirculating.Location = new System.Drawing.Point(224, 336);
            this.bookCirculating.Name = "bookCirculating";
            this.bookCirculating.Size = new System.Drawing.Size(22, 21);
            this.bookCirculating.TabIndex = 15;
            this.bookCirculating.UseVisualStyleBackColor = true;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(645, 420);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(166, 56);
            this.addBookButton.TabIndex = 16;
            this.addBookButton.Text = "Add";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // bookLccn
            // 
            this.bookLccn.Location = new System.Drawing.Point(224, 128);
            this.bookLccn.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.bookLccn.Name = "bookLccn";
            this.bookLccn.Size = new System.Drawing.Size(587, 29);
            this.bookLccn.TabIndex = 17;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 497);
            this.Controls.Add(this.bookLccn);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.bookCirculating);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bookYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bookPublisher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bookSubjectHeadings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookAuthors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Form";
            ((System.ComponentModel.ISupportInitialize)(this.bookYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookLccn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookTitle;
        private System.Windows.Forms.TextBox bookAuthors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookSubjectHeadings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookPublisher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown bookYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox bookCirculating;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.NumericUpDown bookLccn;
    }
}