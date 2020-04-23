using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone2
{
    public partial class SongInventoryForm : Form
    {
        private List<Song> songList = new List<Song>();
        public SongInventoryForm()
        {
            InitializeComponent();
        }

        private void getSongData(Song song)
        {
            decimal price;

            song.SongTitle = tb_songTitle.Text;
            song.Artist = tb_artist.Text;
            song.Album = tb_album.Text;
            song.ReleaseDate = tb_releaseDate.Text;

            if (decimal.TryParse(tb_price.Text, out price))
            {
                song.Price = price; // $0.00
            }
            else
            {
                MessageBox.Show("Invalid Price");
            }
        }

        private void btn_addSong_Click(object sender, EventArgs e)
        {
            Song mysong = new Song();
            getSongData(mysong);

            if (tb_songTitle.Text == "" || tb_artist.Text == "" || tb_price.Text == "")
            {
                MessageBox.Show("Please Enter in a Song Title & Artist");
                tb_songTitle.Focus();
                tb_artist.Focus();
                tb_price.Focus();
            }
            else
            {
                songList.Add(mysong);
                songListBox.Items.Add("Album: " + mysong.Album + " - " + mysong.SongTitle + ", " + mysong.Artist + ", " + mysong.ReleaseDate +
                    "$" + mysong.Price);
                string[] songs = { mysong.Album, mysong.SongTitle, mysong.Artist, mysong.ReleaseDate };
                System.IO.File.WriteAllLines(@"C:\Users\Public\VS.TextFiles\Milestone4.txt", songs);
            }

            tb_songTitle.Clear();
            tb_artist.Clear();
            tb_releaseDate.Clear();
            tb_album.Clear();
            tb_price.Clear();

            tb_songTitle.Focus();
        }

        private void songListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int index = songListBox.SelectedIndex;
            // MessageBox.Show(songList[index].Price.ToString("c"));

            try
            {
                tb_updateSong.Text = songListBox.SelectedItem.ToString();
            }
            catch { }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class Song
        {
            private string songTitle;
            private string artist;
            private string album;
            private string releaseDate;
            private decimal price;

            public Song()
            {
                songTitle = "";
                artist = "";
                album = "";
                releaseDate = "";
                price = 0m;
            }

            public string SongTitle
            {
                get { return songTitle; }
                set { songTitle = value; }
            }

            public string Artist
            {
                get { return artist; }
                set { artist = value; }
            }

            public string Album
            {
                get { return album; }
                set { album = value; }
            }

            public string ReleaseDate
            {
                get { return releaseDate; }
                set { releaseDate = value; }
            }

            public decimal Price
            {
                get { return price; }
                set { price = value; }
            }
        }

        private void btn_deleteSong_Click(object sender, EventArgs e)
        {
            songListBox.Items.Remove(songListBox.SelectedItem);

            string path = @"C:\Users\Public\VS.TextFiles\Milestone4.txt";
            string deleteSong = Convert.ToString(songListBox.SelectedItem);
            var oldLines = System.IO.File.ReadAllLines(path);
            var newLines = oldLines.Where(line => !line.Contains(deleteSong));
            System.IO.File.WriteAllLines(path, newLines);
            FileStream obj = new FileStream(path, FileMode.Append);
            obj.Close();
        }

        private void btn_searchSong_Click(object sender, EventArgs e)
        {
            string searchSong = tb_searchSong.Text;
            songListBox.SelectedItems.Clear();
            for (int i = songListBox.Items.Count - 1; i >= 0; i--)
            {
                if (songListBox.Items[i].ToString().ToLower().Contains(searchSong.ToLower()))
                {
                    songListBox.SetSelected(i, true);
                }
            }
            MessageBox.Show(songListBox.SelectedItems.Count.ToString() + " Item(s) Found!");
        }

        private void btn_updateSong_Click(object sender, EventArgs e)
        {
            int index = songListBox.SelectedIndex;
            songListBox.Items.RemoveAt(index);
            songListBox.Items.Insert(index, tb_updateSong.Text);
        }
    }
}
