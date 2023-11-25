using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Notes");

            PreviousNote.DataSource = notes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(editing)
            {
                notes.Rows[PreviousNote.CurrentCell.RowIndex]["Title"] = TitleBox.Text;
                notes.Rows[PreviousNote.CurrentCell.RowIndex]["Title"] = note.Text;

            }
            else
            {
                notes.Rows.Add(TitleBox.Text, note.Text);
            }
            TitleBox.Text = "";
            note.Text = "";
            editing = false;
        }

        private void Load_Button_Click_1(object sender, EventArgs e)
        {
            TitleBox.Text = notes.Rows[PreviousNote.CurrentCell.RowIndex].ItemArray[0].ToString();
            note.Text = notes.Rows[PreviousNote.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;

        }

        private void New_Click(object sender, EventArgs e)
        {
            TitleBox.Text = "";
            note.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Load_Button_Click(object sender, EventArgs e)
        {

        }

        private void PreviousNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TitleBox.Text = notes.Rows[PreviousNote.CurrentCell.RowIndex].ItemArray[0].ToString();
            note.Text = notes.Rows[PreviousNote.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[PreviousNote.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex) { Console.WriteLine("Not a Valid Note");
            }
        }
    }
}
