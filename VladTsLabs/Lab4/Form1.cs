using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab4.Library;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private SaveFileDialog saver = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void topMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void topMenuAdd_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm(this);
            form.ShowDialog();
        }

        private void topMenuNew_Click(object sender, EventArgs e)
        {
            Program.BookLibrary = new Library.Library();
            Enable();
            RefreshTable();
        }

        private void Enable()
        {
            topMenuAdd.Enabled = true;
            topMenuSave.Enabled = true;
            search.Enabled = true;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void RefreshTable()
        {
            BindingSource source = new BindingSource();
            source.DataSource = Program.BookLibrary;
            dataGridView1.DataSource = source;
        }

        public void RefreshTable(Library.Library results)
        {
            BindingSource source = new BindingSource();
            source.DataSource = results;
            dataGridView1.DataSource = source;
        }


        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text.Length == 0)
            {
                RefreshTable();
            }
            else
            {
                RefreshTable(Program.BookLibrary.SearchBySubject(search.Text));
            }
        }

        private void topMenuSave_Click(object sender, EventArgs e)
        {
            if(saver.FileName == "")
            {
                if(saver.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            Stream file = File.Open(saver.FileName, FileMode.OpenOrCreate);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(file, Program.BookLibrary);
            file.Close();
        }

        private void topMenuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opener = new OpenFileDialog();

            if(opener.ShowDialog() == DialogResult.OK)
            {
                Stream file = File.Open(opener.FileName, FileMode.Open);
                BinaryFormatter bFormatter = new BinaryFormatter();
                Library.Library lib = (Library.Library)bFormatter.Deserialize(file);
                file.Close();
                Program.BookLibrary = lib;
                RefreshTable();
                Enable();
            }
        }
    }
}
