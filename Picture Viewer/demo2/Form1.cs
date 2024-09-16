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

namespace demo2
{
    public partial class Form1 : Form
    {
        private ImageList imageList;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.View = View.LargeIcon;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                imageList = new ImageList();
                imageList.ImageSize = new Size(64, 64);

                var itemsFolder = new List<ListViewItem>();
                foreach (var fpath in Directory.GetFiles(folderBrowserDialog1.SelectedPath))
                {
                    if (fpath.EndsWith(".png") || fpath.EndsWith(".jpg") || fpath.EndsWith(".ico"))
                    {
                        imageList.Images.Add(Image.FromFile(fpath));
                        itemsFolder.Add(new ListViewItem(Path.GetFileName(fpath)) { ImageIndex = imageList.Images.Count - 1 });
                    }
                }

                listView1.LargeImageList = imageList;
                listView1.Items.AddRange(itemsFolder.ToArray());
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
                private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedItemIndex = listView1.SelectedItems[0].Index;
                pictureBox1.Image = imageList.Images[selectedItemIndex];
            };
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
