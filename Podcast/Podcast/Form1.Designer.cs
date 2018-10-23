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
            this.lblFeedUrl = new System.Windows.Forms.Label();
            this.lblFeedFrequency = new System.Windows.Forms.Label();
            this.lblFeedCategory = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblChangeFeed = new System.Windows.Forms.Label();
            this.btnUpdateFeed = new System.Windows.Forms.Button();
            this.btnAddNewFeed = new System.Windows.Forms.Button();
            this.btnDeleteFeed = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnChangeCategory = new System.Windows.Forms.Button();
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
            this.lvFeed.Size = new System.Drawing.Size(412, 155);
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
            this.lvEpisodes.Location = new System.Drawing.Point(12, 337);
            this.lvEpisodes.Name = "lvEpisodes";
            this.lvEpisodes.Size = new System.Drawing.Size(301, 101);
            this.lvEpisodes.TabIndex = 3;
            this.lvEpisodes.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 312);
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
            // lblFeedUrl
            // 
            this.lblFeedUrl.AutoSize = true;
            this.lblFeedUrl.Location = new System.Drawing.Point(231, 224);
            this.lblFeedUrl.Name = "lblFeedUrl";
            this.lblFeedUrl.Size = new System.Drawing.Size(29, 13);
            this.lblFeedUrl.TabIndex = 7;
            this.lblFeedUrl.Text = "URL";
            // 
            // lblFeedFrequency
            // 
            this.lblFeedFrequency.AutoSize = true;
            this.lblFeedFrequency.Location = new System.Drawing.Point(165, 251);
            this.lblFeedFrequency.Name = "lblFeedFrequency";
            this.lblFeedFrequency.Size = new System.Drawing.Size(95, 13);
            this.lblFeedFrequency.TabIndex = 8;
            this.lblFeedFrequency.Text = "Update Frequency";
            this.lblFeedFrequency.Click += new System.EventHandler(this.lblFeedFrequency_Click);
            // 
            // lblFeedCategory
            // 
            this.lblFeedCategory.AutoSize = true;
            this.lblFeedCategory.Location = new System.Drawing.Point(211, 278);
            this.lblFeedCategory.Name = "lblFeedCategory";
            this.lblFeedCategory.Size = new System.Drawing.Size(49, 13);
            this.lblFeedCategory.TabIndex = 9;
            this.lblFeedCategory.Text = "Category";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(281, 270);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(76, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(281, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 20);
            this.textBox2.TabIndex = 12;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(16, 213);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(101, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // lblChangeFeed
            // 
            this.lblChangeFeed.AutoSize = true;
            this.lblChangeFeed.Location = new System.Drawing.Point(16, 197);
            this.lblChangeFeed.Name = "lblChangeFeed";
            this.lblChangeFeed.Size = new System.Drawing.Size(128, 13);
            this.lblChangeFeed.TabIndex = 14;
            this.lblChangeFeed.Text = "Change selected podcast";
            // 
            // btnUpdateFeed
            // 
            this.btnUpdateFeed.Location = new System.Drawing.Point(16, 241);
            this.btnUpdateFeed.Name = "btnUpdateFeed";
            this.btnUpdateFeed.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateFeed.TabIndex = 15;
            this.btnUpdateFeed.Text = "Update";
            this.btnUpdateFeed.UseVisualStyleBackColor = true;
            // 
            // btnAddNewFeed
            // 
            this.btnAddNewFeed.Location = new System.Drawing.Point(281, 302);
            this.btnAddNewFeed.Name = "btnAddNewFeed";
            this.btnAddNewFeed.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewFeed.TabIndex = 16;
            this.btnAddNewFeed.Text = "Add new";
            this.btnAddNewFeed.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFeed
            // 
            this.btnDeleteFeed.Location = new System.Drawing.Point(16, 270);
            this.btnDeleteFeed.Name = "btnDeleteFeed";
            this.btnDeleteFeed.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFeed.TabIndex = 17;
            this.btnDeleteFeed.Text = "Delete";
            this.btnDeleteFeed.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(536, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 18;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(536, 226);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(54, 21);
            this.comboBox4.TabIndex = 19;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(663, 195);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(121, 23);
            this.btnAddCategory.TabIndex = 20;
            this.btnAddCategory.Text = "Add category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(663, 253);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(121, 23);
            this.btnDeleteCategory.TabIndex = 21;
            this.btnDeleteCategory.Text = "Delete category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.Location = new System.Drawing.Point(663, 224);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(121, 23);
            this.btnChangeCategory.TabIndex = 22;
            this.btnChangeCategory.Text = "Change category";
            this.btnChangeCategory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeCategory);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnDeleteFeed);
            this.Controls.Add(this.btnAddNewFeed);
            this.Controls.Add(this.btnUpdateFeed);
            this.Controls.Add(this.lblChangeFeed);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblFeedCategory);
            this.Controls.Add(this.lblFeedFrequency);
            this.Controls.Add(this.lblFeedUrl);
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
        private System.Windows.Forms.Label lblFeedUrl;
        private System.Windows.Forms.Label lblFeedFrequency;
        private System.Windows.Forms.Label lblFeedCategory;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblChangeFeed;
        private System.Windows.Forms.Button btnUpdateFeed;
        private System.Windows.Forms.Button btnAddNewFeed;
        private System.Windows.Forms.Button btnDeleteFeed;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnChangeCategory;
    }
}

