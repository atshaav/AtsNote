using System;                    //süsteemi toimimiseks
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atsnote
{
    public partial class Form1 : Form  //teeb põhiakna
    {
        public Form1()
        {
            InitializeComponent();
        }
        //väljumise nupp
        private void suleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Lõikamise nupp
        private void lõikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        //kopeerimise nupp
        private void kopeeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        //kleepimise nupp
        private void kleebiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        //valimise nupp
        private void valiKõikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        //uue faili tegemise nupp
        private void uusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        //undo nupp
        private void tagasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        //redo nupp
        private void edasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        //faili avamise nupp
        private void avaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ava = new OpenFileDialog(); //avab lisaakna failide otsimiseks
            ava.Title = "Ava"; //lisaakna nimi
            ava.Filter = "Txt dokument (.txt)|*.txt|Rtf document (.rtf)|*.rtf|kõik failid (*.*)|*.*"; //failid mida saab avada
            if (ava.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(ava.FileName, RichTextBoxStreamType.PlainText);
            this.Text = ava.FileName;
        }
        //faili salvestamise nupp
        private void salvestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sal = new SaveFileDialog(); //avab lisaakna failide salvestamiseks
            sal.Title = "Ava"; //lisaakna nimi
            sal.Filter = "Txt dokument (.txt)|*.txt|Rtf document (.rtf)|*.rtf|kõik failid (*.*)|*.*"; //failid mida saab avada
            sal.OverwritePrompt = true;
            if (sal.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(sal.FileName, RichTextBoxStreamType.RichText);
            this.Text = sal.FileName;
        }
        
        }
    }

