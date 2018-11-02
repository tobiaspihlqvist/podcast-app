
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
            this.Episodes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblFeedUrl = new System.Windows.Forms.Label();
            this.lblFeedFrequency = new System.Windows.Forms.Label();
            this.lblFeedCategory = new System.Windows.Forms.Label();
            this.cmbUpdate = new System.Windows.Forms.ComboBox();
            this.cmbFeedCategory = new System.Windows.Forms.ComboBox();
            this.txtInputURL = new System.Windows.Forms.TextBox();
            this.cmbPodcast = new System.Windows.Forms.ComboBox();
            this.lblChangeFeed = new System.Windows.Forms.Label();
            this.btnUpdateFeed = new System.Windows.Forms.Button();
            this.btnAddNewFeed = new System.Windows.Forms.Button();
            this.btnDeleteFeed = new System.Windows.Forms.Button();
            this.txtInputCategory = new System.Windows.Forms.TextBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnChangeCategory = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
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
            this.lvFeed.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clName,
            this.clFrequency,
            this.clCategory});
            this.lvFeed.Location = new System.Drawing.Point(19, 29);
            this.lvFeed.Name = "lvFeed";
            this.lvFeed.Size = new System.Drawing.Size(412, 155);
            this.lvFeed.TabIndex = 1;
            this.lvFeed.UseCompatibleStateImageBehavior = false;
            this.lvFeed.View = System.Windows.Forms.View.Details;
            this.lvFeed.ItemActivate += new System.EventHandler(this.lvFeed_ItemActivate);
            this.lvFeed.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvFeed_ItemSelectionChanged);
            this.lvFeed.Enter += new System.EventHandler(this.lvFeed_Enter);
            // 
            // clName
            // 
            this.clName.Text = "Name";
            this.clName.Width = 210;
            // 
            // clFrequency
            // 
            this.clFrequency.Text = "Update frequency";
            this.clFrequency.Width = 118;
            // 
            // clCategory
            // 
            this.clCategory.Text = "Category";
            this.clCategory.Width = 155;
            // 
            // lvCategory
            // 
            this.lvCategory.Location = new System.Drawing.Point(536, 30);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(220, 155);
            this.lvCategory.TabIndex = 2;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.List;
            this.lvCategory.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvCategory_ItemSelectionChanged);
            // 
            // lvEpisodes
            // 
            this.lvEpisodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Episodes});
            this.lvEpisodes.Location = new System.Drawing.Point(12, 337);
            this.lvEpisodes.Name = "lvEpisodes";
            this.lvEpisodes.Size = new System.Drawing.Size(361, 101);
            this.lvEpisodes.TabIndex = 3;
            this.lvEpisodes.UseCompatibleStateImageBehavior = false;
            this.lvEpisodes.View = System.Windows.Forms.View.Details;
            this.lvEpisodes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvEpisodes_ItemSelectionChanged);
            // 
            // Episodes
            // 
            this.Episodes.Text = "Episodes";
            this.Episodes.Width = 294;
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
            this.lblFeedFrequency.Location = new System.Drawing.Point(136, 251);
            this.lblFeedFrequency.Name = "lblFeedFrequency";
            this.lblFeedFrequency.Size = new System.Drawing.Size(140, 13);
            this.lblFeedFrequency.TabIndex = 8;
            this.lblFeedFrequency.Text = "Update Frequency (minutes)";
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
            // cmbUpdate
            // 
            this.cmbUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdate.Location = new System.Drawing.Point(281, 248);
            this.cmbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUpdate.Name = "cmbUpdate";
            this.cmbUpdate.Size = new System.Drawing.Size(92, 21);
            this.cmbUpdate.TabIndex = 24;
            // 
            // cmbFeedCategory
            // 
            this.cmbFeedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeedCategory.Location = new System.Drawing.Point(281, 275);
            this.cmbFeedCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFeedCategory.Name = "cmbFeedCategory";
            this.cmbFeedCategory.Size = new System.Drawing.Size(92, 21);
            this.cmbFeedCategory.TabIndex = 23;
            // 
            // txtInputURL
            // 
            this.txtInputURL.Location = new System.Drawing.Point(281, 221);
            this.txtInputURL.Name = "txtInputURL";
            this.txtInputURL.Size = new System.Drawing.Size(92, 20);
            this.txtInputURL.TabIndex = 12;
            // 
            // cmbPodcast
            // 
            this.cmbPodcast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPodcast.FormattingEnabled = true;
            this.cmbPodcast.Location = new System.Drawing.Point(16, 213);
            this.cmbPodcast.Name = "cmbPodcast";
            this.cmbPodcast.Size = new System.Drawing.Size(101, 21);
            this.cmbPodcast.TabIndex = 13;
            this.cmbPodcast.SelectedIndexChanged += new System.EventHandler(this.cmbPodcast_SelectedIndexChanged);
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
            this.btnAddNewFeed.Click += new System.EventHandler(this.btnAddNewFeed_Click);
            // 
            // btnDeleteFeed
            // 
            this.btnDeleteFeed.Location = new System.Drawing.Point(16, 270);
            this.btnDeleteFeed.Name = "btnDeleteFeed";
            this.btnDeleteFeed.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFeed.TabIndex = 17;
            this.btnDeleteFeed.Text = "Delete";
            this.btnDeleteFeed.UseVisualStyleBackColor = true;
            this.btnDeleteFeed.Click += new System.EventHandler(this.btnDeleteFeed_Click);
            // 
            // txtInputCategory
            // 
            this.txtInputCategory.Location = new System.Drawing.Point(536, 197);
            this.txtInputCategory.Name = "txtInputCategory";
            this.txtInputCategory.Size = new System.Drawing.Size(121, 20);
            this.txtInputCategory.TabIndex = 18;
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(536, 226);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(121, 21);
            this.cmbCategories.TabIndex = 19;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(663, 195);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(121, 23);
            this.btnAddCategory.TabIndex = 20;
            this.btnAddCategory.Text = "Add category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(663, 253);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(121, 23);
            this.btnDeleteCategory.TabIndex = 21;
            this.btnDeleteCategory.Text = "Delete category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.Location = new System.Drawing.Point(663, 224);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(121, 23);
            this.btnChangeCategory.TabIndex = 22;
            this.btnChangeCategory.Text = "Change category";
            this.btnChangeCategory.UseVisualStyleBackColor = true;
            this.btnChangeCategory.Click += new System.EventHandler(this.btnChangeCategory_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(281, 194);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(92, 20);
            this.tbTitle.TabIndex = 25;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(225, 200);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(533, 312);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(101, 13);
            this.lblDescription.TabIndex = 28;
            this.lblDescription.Text = "Episode Description";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(536, 337);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(220, 96);
            this.rtbDescription.TabIndex = 29;
            this.rtbDescription.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnChangeCategory);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.txtInputCategory);
            this.Controls.Add(this.btnDeleteFeed);
            this.Controls.Add(this.btnAddNewFeed);
            this.Controls.Add(this.btnUpdateFeed);
            this.Controls.Add(this.lblChangeFeed);
            this.Controls.Add(this.cmbPodcast);
            this.Controls.Add(this.txtInputURL);
            this.Controls.Add(this.cmbFeedCategory);
            this.Controls.Add(this.cmbUpdate);
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
        private System.Windows.Forms.ComboBox cmbUpdate;
        private System.Windows.Forms.ComboBox cmbFeedCategory;
        private System.Windows.Forms.TextBox txtInputURL;
        private System.Windows.Forms.ComboBox cmbPodcast;
        private System.Windows.Forms.Label lblChangeFeed;
        private System.Windows.Forms.Button btnUpdateFeed;
        private System.Windows.Forms.Button btnAddNewFeed;
        private System.Windows.Forms.Button btnDeleteFeed;
        private System.Windows.Forms.TextBox txtInputCategory;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnChangeCategory;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ColumnHeader Episodes;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
    }
}

