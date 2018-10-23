namespace Podcast
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
            this.lblFeed = new System.Windows.Forms.Label();
            this.lvFeed = new System.Windows.Forms.ListView();
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCategory = new System.Windows.Forms.ListView();
            this.lvEpisodes = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFeedUrl = new System.Windows.Forms.Label();
            this.lblFeedFrequency = new System.Windows.Forms.Label();
            this.lblFeedCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFeed
            // 
            this.lblFeed.AutoSize = true;
            this.lblFeed.Location = new System.Drawing.Point(13, 13);
            this.lblFeed.Name = "lblFeed";
            this.lblFeed.Size = new System.Drawing.Size(75, 13);
            this.lblFeed.TabIndex = 0;
            this.lblFeed.Text = "Podcast feeds";
            // 
            // lvFeed
            // 
            this.lvFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clName,
            this.clFrequency,
            this.clCategory});
            this.lvFeed.Location = new System.Drawing.Point(16, 30);
            this.lvFeed.Name = "lvFeed";
            this.lvFeed.Size = new System.Drawing.Size(301, 155);
            this.lvFeed.TabIndex = 1;
            this.lvFeed.UseCompatibleStateImageBehavior = false;
            this.lvFeed.View = System.Windows.Forms.View.Details;
            // 
            // clName
            // 
            this.clName.Text = "Name";
            // 
            // clFrequency
            // 
            this.clFrequency.Text = "Update frequency";
            this.clFrequency.Width = 130;
            // 
            // clCategory
            // 
            this.clCategory.Text = "Category";
            // 
            // lvCategory
            // 
            this.lvCategory.Location = new System.Drawing.Point(536, 30);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(220, 155);
            this.lvCategory.TabIndex = 2;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            // 
            // lvEpisodes
            // 
            this.lvEpisodes.Location = new System.Drawing.Point(16, 296);
            this.lvEpisodes.Name = "lvEpisodes";
            this.lvEpisodes.Size = new System.Drawing.Size(301, 101);
            this.lvEpisodes.TabIndex = 3;
            this.lvEpisodes.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Episodes";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(533, 13);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(57, 13);
            this.lblCategories.TabIndex = 5;
            this.lblCategories.Text = "Categories";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(536, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 6;
            // 
            // lblFeedUrl
            // 
            this.lblFeedUrl.AutoSize = true;
            this.lblFeedUrl.Location = new System.Drawing.Point(16, 199);
            this.lblFeedUrl.Name = "lblFeedUrl";
            this.lblFeedUrl.Size = new System.Drawing.Size(29, 13);
            this.lblFeedUrl.TabIndex = 7;
            this.lblFeedUrl.Text = "URL";
            // 
            // lblFeedFrequency
            // 
            this.lblFeedFrequency.AutoSize = true;
            this.lblFeedFrequency.Location = new System.Drawing.Point(144, 199);
            this.lblFeedFrequency.Name = "lblFeedFrequency";
            this.lblFeedFrequency.Size = new System.Drawing.Size(95, 13);
            this.lblFeedFrequency.TabIndex = 8;
            this.lblFeedFrequency.Text = "Update Frequency";
            this.lblFeedFrequency.Click += new System.EventHandler(this.lblFeedFrequency_Click);
            // 
            // lblFeedCategory
            // 
            this.lblFeedCategory.AutoSize = true;
            this.lblFeedCategory.Location = new System.Drawing.Point(282, 199);
            this.lblFeedCategory.Name = "lblFeedCategory";
            this.lblFeedCategory.Size = new System.Drawing.Size(49, 13);
            this.lblFeedCategory.TabIndex = 9;
            this.lblFeedCategory.Text = "Category";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFeedCategory);
            this.Controls.Add(this.lblFeedFrequency);
            this.Controls.Add(this.lblFeedUrl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvEpisodes);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.lvFeed);
            this.Controls.Add(this.lblFeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeed;
        private System.Windows.Forms.ListView lvFeed;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clFrequency;
        private System.Windows.Forms.ColumnHeader clCategory;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.ListView lvEpisodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFeedUrl;
        private System.Windows.Forms.Label lblFeedFrequency;
        private System.Windows.Forms.Label lblFeedCategory;
    }
}

