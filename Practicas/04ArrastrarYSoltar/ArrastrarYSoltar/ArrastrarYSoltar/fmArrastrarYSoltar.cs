﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrastrarYSoltar
{
    public partial class fmArrastrarYSoltar : Form
    {
        public fmArrastrarYSoltar()
        {
            InitializeComponent();
        }

        private void lb1_MouseDown(object sender, MouseEventArgs e)
        {
            if (lb1.SelectedIndex >= 0)
            {
                lb2.DoDragDrop(lb1.SelectedItem, DragDropEffects.All);//Indica operación de arrastre.
            }
        }

        private void lb2_MouseDown(object sender, MouseEventArgs e)
        {
            if (lb2.SelectedIndex >= 0)
            {
                lb1.DoDragDrop(lb2.SelectedItem, DragDropEffects.All);
            }
        }

        private void lb1_DragDrop(object sender, DragEventArgs e)
        {
            ListBox miListBox = (ListBox)sender;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] ficheros = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                foreach (var fichero in ficheros)
                {
                    StreamReader miArchivo = new StreamReader(fichero, Encoding.Default);
                    while (miArchivo.Peek() >= 0)
                    {
                        miListBox.Items.Add(Convert.ToString(miArchivo.ReadLine()));
                    }
                    miArchivo.Close();
                }
            }
            else
            {
                if (e.Data.GetDataPresent(DataFormats.Text))
                {
                    if (sender == lb1 && lb2.SelectedIndex > -1)
                    {
                        anyadeListBox(lb1, lb2);
                        borraListBox(lb2);
                    }
                    if (sender == lb2 && lb1.SelectedIndex > -1)
                    {
                        anyadeListBox(lb2, lb1);
                        borraListBox(lb1);
                    }
                }
            }
        }

        private void borraListBox(ListBox lbBorra)
        {
            int i = 0;
            while (i < lbBorra.Items.Count)
            {
                if (lbBorra.GetSelected(i))
                {
                    lbBorra.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void anyadeListBox(ListBox lbAcopla, ListBox lbArrastra)
        {
            for (int i=0; i < lbArrastra.Items.Count; i++)
            {
                if (lbArrastra.GetSelected(i))
                {
                    lbAcopla.Items.Add(lbArrastra.Items[i]);
                }
            }
        }

        private void lb1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
/**
* Poner la propiedad selection mode a multisimple
* Poner la propiedadd allowdrop a true
* Usamos los eventos dragenter dragdrop
*/
