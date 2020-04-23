namespace Milestone2
{
    partial class SongInventoryForm
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
            this.gb_addSong = new System.Windows.Forms.GroupBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.btn_addSong = new System.Windows.Forms.Button();
            this.tb_releaseDate = new System.Windows.Forms.TextBox();
            this.tb_album = new System.Windows.Forms.TextBox();
            this.tb_artist = new System.Windows.Forms.TextBox();
            this.tb_songTitle = new System.Windows.Forms.TextBox();
            this.label_releaseDate = new System.Windows.Forms.Label();
            this.label_album = new System.Windows.Forms.Label();
            this.label_artist = new System.Windows.Forms.Label();
            this.label_songTitle = new System.Windows.Forms.Label();
            this.gb_selectSong = new System.Windows.Forms.GroupBox();
            this.btn_searchSong = new System.Windows.Forms.Button();
            this.tb_searchSong = new System.Windows.Forms.TextBox();
            this.label_searchSong = new System.Windows.Forms.Label();
            this.btn_deleteSong = new System.Windows.Forms.Button();
            this.songListBox = new System.Windows.Forms.ListBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_updateSong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_updateSong = new System.Windows.Forms.Label();
            this.tb_updateSong = new System.Windows.Forms.TextBox();
            this.gb_addSong.SuspendLayout();
            this.gb_selectSong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_addSong
            // 
            this.gb_addSong.Controls.Add(this.tb_price);
            this.gb_addSong.Controls.Add(this.label_price);
            this.gb_addSong.Controls.Add(this.btn_addSong);
            this.gb_addSong.Controls.Add(this.tb_releaseDate);
            this.gb_addSong.Controls.Add(this.tb_album);
            this.gb_addSong.Controls.Add(this.tb_artist);
            this.gb_addSong.Controls.Add(this.tb_songTitle);
            this.gb_addSong.Controls.Add(this.label_releaseDate);
            this.gb_addSong.Controls.Add(this.label_album);
            this.gb_addSong.Controls.Add(this.label_artist);
            this.gb_addSong.Controls.Add(this.label_songTitle);
            this.gb_addSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gb_addSong.Location = new System.Drawing.Point(12, 23);
            this.gb_addSong.Name = "gb_addSong";
            this.gb_addSong.Size = new System.Drawing.Size(444, 234);
            this.gb_addSong.TabIndex = 0;
            this.gb_addSong.TabStop = false;
            this.gb_addSong.Text = "Add Song";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(124, 161);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(224, 26);
            this.tb_price.TabIndex = 10;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(70, 164);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(48, 20);
            this.label_price.TabIndex = 9;
            this.label_price.Text = "Price:";
            // 
            // btn_addSong
            // 
            this.btn_addSong.Location = new System.Drawing.Point(124, 193);
            this.btn_addSong.Name = "btn_addSong";
            this.btn_addSong.Size = new System.Drawing.Size(96, 29);
            this.btn_addSong.TabIndex = 8;
            this.btn_addSong.Text = "Add Song";
            this.btn_addSong.UseVisualStyleBackColor = true;
            this.btn_addSong.Click += new System.EventHandler(this.btn_addSong_Click);
            // 
            // tb_releaseDate
            // 
            this.tb_releaseDate.Location = new System.Drawing.Point(125, 125);
            this.tb_releaseDate.Name = "tb_releaseDate";
            this.tb_releaseDate.Size = new System.Drawing.Size(223, 26);
            this.tb_releaseDate.TabIndex = 7;
            // 
            // tb_album
            // 
            this.tb_album.Location = new System.Drawing.Point(125, 92);
            this.tb_album.Name = "tb_album";
            this.tb_album.Size = new System.Drawing.Size(223, 26);
            this.tb_album.TabIndex = 6;
            // 
            // tb_artist
            // 
            this.tb_artist.Location = new System.Drawing.Point(124, 58);
            this.tb_artist.Name = "tb_artist";
            this.tb_artist.Size = new System.Drawing.Size(224, 26);
            this.tb_artist.TabIndex = 5;
            // 
            // tb_songTitle
            // 
            this.tb_songTitle.Location = new System.Drawing.Point(124, 23);
            this.tb_songTitle.Name = "tb_songTitle";
            this.tb_songTitle.Size = new System.Drawing.Size(224, 26);
            this.tb_songTitle.TabIndex = 4;
            // 
            // label_releaseDate
            // 
            this.label_releaseDate.AutoSize = true;
            this.label_releaseDate.Location = new System.Drawing.Point(7, 126);
            this.label_releaseDate.Name = "label_releaseDate";
            this.label_releaseDate.Size = new System.Drawing.Size(111, 20);
            this.label_releaseDate.TabIndex = 3;
            this.label_releaseDate.Text = "Release Date:";
            // 
            // label_album
            // 
            this.label_album.AutoSize = true;
            this.label_album.Location = new System.Drawing.Point(60, 93);
            this.label_album.Name = "label_album";
            this.label_album.Size = new System.Drawing.Size(58, 20);
            this.label_album.TabIndex = 2;
            this.label_album.Text = "Album:";
            // 
            // label_artist
            // 
            this.label_artist.AutoSize = true;
            this.label_artist.Location = new System.Drawing.Point(68, 59);
            this.label_artist.Name = "label_artist";
            this.label_artist.Size = new System.Drawing.Size(50, 20);
            this.label_artist.TabIndex = 1;
            this.label_artist.Text = "Artist:";
            // 
            // label_songTitle
            // 
            this.label_songTitle.AutoSize = true;
            this.label_songTitle.Location = new System.Drawing.Point(32, 26);
            this.label_songTitle.Name = "label_songTitle";
            this.label_songTitle.Size = new System.Drawing.Size(86, 20);
            this.label_songTitle.TabIndex = 0;
            this.label_songTitle.Text = "Song TItle:";
            // 
            // gb_selectSong
            // 
            this.gb_selectSong.Controls.Add(this.btn_searchSong);
            this.gb_selectSong.Controls.Add(this.tb_searchSong);
            this.gb_selectSong.Controls.Add(this.label_searchSong);
            this.gb_selectSong.Controls.Add(this.btn_deleteSong);
            this.gb_selectSong.Controls.Add(this.songListBox);
            this.gb_selectSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gb_selectSong.Location = new System.Drawing.Point(462, 23);
            this.gb_selectSong.Name = "gb_selectSong";
            this.gb_selectSong.Size = new System.Drawing.Size(515, 415);
            this.gb_selectSong.TabIndex = 1;
            this.gb_selectSong.TabStop = false;
            this.gb_selectSong.Text = "Select A Song";
            // 
            // btn_searchSong
            // 
            this.btn_searchSong.Location = new System.Drawing.Point(213, 68);
            this.btn_searchSong.Name = "btn_searchSong";
            this.btn_searchSong.Size = new System.Drawing.Size(103, 26);
            this.btn_searchSong.TabIndex = 4;
            this.btn_searchSong.Text = "Search";
            this.btn_searchSong.UseVisualStyleBackColor = true;
            this.btn_searchSong.Click += new System.EventHandler(this.btn_searchSong_Click);
            // 
            // tb_searchSong
            // 
            this.tb_searchSong.Location = new System.Drawing.Point(130, 36);
            this.tb_searchSong.Name = "tb_searchSong";
            this.tb_searchSong.Size = new System.Drawing.Size(360, 26);
            this.tb_searchSong.TabIndex = 3;
            // 
            // label_searchSong
            // 
            this.label_searchSong.AutoSize = true;
            this.label_searchSong.Location = new System.Drawing.Point(17, 37);
            this.label_searchSong.Name = "label_searchSong";
            this.label_searchSong.Size = new System.Drawing.Size(106, 20);
            this.label_searchSong.TabIndex = 2;
            this.label_searchSong.Text = "Search Song:";
            // 
            // btn_deleteSong
            // 
            this.btn_deleteSong.Location = new System.Drawing.Point(17, 370);
            this.btn_deleteSong.Name = "btn_deleteSong";
            this.btn_deleteSong.Size = new System.Drawing.Size(123, 29);
            this.btn_deleteSong.TabIndex = 1;
            this.btn_deleteSong.Text = "Delete Song";
            this.btn_deleteSong.UseVisualStyleBackColor = true;
            this.btn_deleteSong.Click += new System.EventHandler(this.btn_deleteSong_Click);
            // 
            // songListBox
            // 
            this.songListBox.FormattingEnabled = true;
            this.songListBox.ItemHeight = 20;
            this.songListBox.Location = new System.Drawing.Point(17, 100);
            this.songListBox.Name = "songListBox";
            this.songListBox.Size = new System.Drawing.Size(473, 264);
            this.songListBox.TabIndex = 0;
            this.songListBox.SelectedIndexChanged += new System.EventHandler(this.songListBox_SelectedIndexChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_exit.Location = new System.Drawing.Point(238, 408);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(103, 30);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_updateSong
            // 
            this.btn_updateSong.Location = new System.Drawing.Point(172, 60);
            this.btn_updateSong.Name = "btn_updateSong";
            this.btn_updateSong.Size = new System.Drawing.Size(84, 26);
            this.btn_updateSong.TabIndex = 11;
            this.btn_updateSong.Text = "Update";
            this.btn_updateSong.UseVisualStyleBackColor = true;
            this.btn_updateSong.Click += new System.EventHandler(this.btn_updateSong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_updateSong);
            this.groupBox1.Controls.Add(this.btn_updateSong);
            this.groupBox1.Controls.Add(this.label_updateSong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Song";
            // 
            // label_updateSong
            // 
            this.label_updateSong.AutoSize = true;
            this.label_updateSong.Location = new System.Drawing.Point(7, 31);
            this.label_updateSong.Name = "label_updateSong";
            this.label_updateSong.Size = new System.Drawing.Size(55, 20);
            this.label_updateSong.TabIndex = 12;
            this.label_updateSong.Text = "Song: ";
            // 
            // tb_updateSong
            // 
            this.tb_updateSong.Location = new System.Drawing.Point(64, 28);
            this.tb_updateSong.Name = "tb_updateSong";
            this.tb_updateSong.Size = new System.Drawing.Size(332, 26);
            this.tb_updateSong.TabIndex = 11;
            // 
            // SongInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.gb_selectSong);
            this.Controls.Add(this.gb_addSong);
            this.Name = "SongInventoryForm";
            this.Text = "Song Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_addSong.ResumeLayout(false);
            this.gb_addSong.PerformLayout();
            this.gb_selectSong.ResumeLayout(false);
            this.gb_selectSong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_addSong;
        private System.Windows.Forms.Label label_songTitle;
        private System.Windows.Forms.Label label_album;
        private System.Windows.Forms.Label label_artist;
        private System.Windows.Forms.TextBox tb_songTitle;
        private System.Windows.Forms.Label label_releaseDate;
        private System.Windows.Forms.TextBox tb_album;
        private System.Windows.Forms.TextBox tb_artist;
        private System.Windows.Forms.TextBox tb_releaseDate;
        private System.Windows.Forms.GroupBox gb_selectSong;
        private System.Windows.Forms.ListBox songListBox;
        private System.Windows.Forms.Button btn_addSong;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Button btn_deleteSong;
        private System.Windows.Forms.Label label_searchSong;
        private System.Windows.Forms.TextBox tb_searchSong;
        private System.Windows.Forms.Button btn_searchSong;
        private System.Windows.Forms.Button btn_updateSong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_updateSong;
        private System.Windows.Forms.Label label_updateSong;
    }
}

