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
            this.cmbFeedCategory = new System.Windows.Forms.ComboBox();
            this.txtInputURL = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblChangeFeed = new System.Windows.Forms.Label();
            this.btnUpdateFeed = new System.Windows.Forms.Button();
            this.btnAddNewFeed = new System.Windows.Forms.Button();
            this.btnDeleteFeed = new System.Windows.Forms.Button();
            this.txtInputCategory = new System.Windows.Forms.TextBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnChangeCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFeed
            // 
            this.lblFeed.AutoSize = true;
            this.lblFeed.Location = new System.Drawing.Point(17, 16);
            this.lblFeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeed.Name = "lblFeed";
            this.lblFeed.Size = new System.Drawing.Size(98, 17);
            this.lblFeed.TabIndex = 0;
            this.lblFeed.Text = "Podcast feeds";
            // 
            // lvFeed
            // 
            this.lvFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clName,
            this.clFrequency,
            this.clCategory});
            this.lvFeed.Location = new System.Drawing.Point(21, 37);
            this.lvFeed.Margin = new System.Windows.Forms.Padding(4);
            this.lvFeed.Name = "lvFeed";
            this.lvFeed.Size = new System.Drawing.Size(548, 190);
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
            this.lvCategory.Location = new System.Drawing.Point(715, 37);
            this.lvCategory.Margin = new System.Windows.Forms.Padding(4);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(292, 190);
            this.lvCategory.TabIndex = 2;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.List;
            // 
            // lvEpisodes
            // 
            this.lvEpisodes.Location = new System.Drawing.Point(16, 415);
            this.lvEpisodes.Margin = new System.Windows.Forms.Padding(4);
            this.lvEpisodes.Name = "lvEpisodes";
            this.lvEpisodes.Size = new System.Drawing.Size(400, 123);
            this.lvEpisodes.TabIndex = 3;
            this.lvEpisodes.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Episodes";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(711, 16);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(76, 17);
            this.lblCategories.TabIndex = 5;
            this.lblCategories.Text = "Categories";
            // 
            // lblFeedUrl
            // 
            this.lblFeedUrl.AutoSize = true;
            this.lblFeedUrl.Location = new System.Drawing.Point(308, 276);
            this.lblFeedUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedUrl.Name = "lblFeedUrl";
            this.lblFeedUrl.Size = new System.Drawing.Size(36, 17);
            this.lblFeedUrl.TabIndex = 7;
            this.lblFeedUrl.Text = "URL";
            // 
            // lblFeedFrequency
            // 
            this.lblFeedFrequency.AutoSize = true;
            this.lblFeedFrequency.Location = new System.Drawing.Point(220, 309);
            this.lblFeedFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedFrequency.Name = "lblFeedFrequency";
            this.lblFeedFrequency.Size = new System.Drawing.Size(125, 17);
            this.lblFeedFrequency.TabIndex = 8;
            this.lblFeedFrequency.Text = "Update Frequency";
            // 
            // lblFeedCategory
            // 
            this.lblFeedCategory.AutoSize = true;
            this.lblFeedCategory.Location = new System.Drawing.Point(281, 342);
            this.lblFeedCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedCategory.Name = "lblFeedCategory";
            this.lblFeedCategory.Size = new System.Drawing.Size(65, 17);
            this.lblFeedCategory.TabIndex = 9;
            this.lblFeedCategory.Text = "Category";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(375, 299);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // cmbFeedCategory
            // 
            this.cmbFeedCategory.AllowDrop = true;
            this.cmbFeedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeedCategory.FormattingEnabled = true;
            this.cmbFeedCategory.Location = new System.Drawing.Point(375, 332);
            this.cmbFeedCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFeedCategory.Name = "cmbFeedCategory";
            this.cmbFeedCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbFeedCategory.TabIndex = 11;
            // 
            // txtInputURL
            // 
            this.txtInputURL.Location = new System.Drawing.Point(375, 267);
            this.txtInputURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputURL.Name = "txtInputURL";
            this.txtInputURL.Size = new System.Drawing.Size(121, 22);
            this.txtInputURL.TabIndex = 12;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(21, 262);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(133, 24);
            this.comboBox3.TabIndex = 13;
            // 
            // lblChangeFeed
            // 
            this.lblChangeFeed.AutoSize = true;
            this.lblChangeFeed.Location = new System.Drawing.Point(21, 242);
            this.lblChangeFeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeFeed.Name = "lblChangeFeed";
            this.lblChangeFeed.Size = new System.Drawing.Size(168, 17);
            this.lblChangeFeed.TabIndex = 14;
            this.lblChangeFeed.Text = "Change selected podcast";
            // 
            // btnUpdateFeed
            // 
            this.btnUpdateFeed.Location = new System.Drawing.Point(21, 297);
            this.btnUpdateFeed.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateFeed.Name = "btnUpdateFeed";
            this.btnUpdateFeed.Size = new System.Drawing.Size(100, 28);
            this.btnUpdateFeed.TabIndex = 15;
            this.btnUpdateFeed.Text = "Update";
            this.btnUpdateFeed.UseVisualStyleBackColor = true;
            // 
            // btnAddNewFeed
            // 
            this.btnAddNewFeed.Location = new System.Drawing.Point(375, 372);
            this.btnAddNewFeed.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewFeed.Name = "btnAddNewFeed";
            this.btnAddNewFeed.Size = new System.Drawing.Size(100, 28);
            this.btnAddNewFeed.TabIndex = 16;
            this.btnAddNewFeed.Text = "Add new";
            this.btnAddNewFeed.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFeed
            // 
            this.btnDeleteFeed.Location = new System.Drawing.Point(21, 332);
            this.btnDeleteFeed.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFeed.Name = "btnDeleteFeed";
            this.btnDeleteFeed.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteFeed.TabIndex = 17;
            this.btnDeleteFeed.Text = "Delete";
            this.btnDeleteFeed.UseVisualStyleBackColor = true;
            // 
            // txtInputCategory
            // 
            this.txtInputCategory.Location = new System.Drawing.Point(715, 242);
            this.txtInputCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputCategory.Name = "txtInputCategory";
            this.txtInputCategory.Size = new System.Drawing.Size(160, 22);
            this.txtInputCategory.TabIndex = 18;
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(715, 278);
            this.cmbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(160, 24);
            this.cmbCategories.TabIndex = 19;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(884, 240);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(161, 28);
            this.btnAddCategory.TabIndex = 20;
            this.btnAddCategory.Text = "Add category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(884, 311);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(161, 28);
            this.btnDeleteCategory.TabIndex = 21;
            this.btnDeleteCategory.Text = "Delete category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.Location = new System.Drawing.Point(884, 276);
            this.btnChangeCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(161, 28);
            this.btnChangeCategory.TabIndex = 22;
            this.btnChangeCategory.Text = "Change category";
            this.btnChangeCategory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnChangeCategory);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.txtInputCategory);
            this.Controls.Add(this.btnDeleteFeed);
            this.Controls.Add(this.btnAddNewFeed);
            this.Controls.Add(this.btnUpdateFeed);
            this.Controls.Add(this.lblChangeFeed);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.txtInputURL);
            this.Controls.Add(this.cmbFeedCategory);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox cmbFeedCategory;
        private System.Windows.Forms.TextBox txtInputURL;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblChangeFeed;
        private System.Windows.Forms.Button btnUpdateFeed;
        private System.Windows.Forms.Button btnAddNewFeed;
        private System.Windows.Forms.Button btnDeleteFeed;
        private System.Windows.Forms.TextBox txtInputCategory;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnChangeCategory;
    }
}

