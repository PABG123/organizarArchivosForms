﻿using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace organizarArchivosForms
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            ChooseFolder();
            Organizar();
        }
        DirectoryInfo folderInfo;
        private void ChooseFolder()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //folderBrowserDialog.ShowDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                tvArchivos.AfterSelect += tvArchivos_AfterSelect;
                txtRuta.Text = folderInfo.FullName;
                LlenarArbol(folderInfo, tvArchivos.Nodes);
            }
            
        }

        private void tvArchivos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtRuta.Text = e.Node.Name;
           
        }

        ArrayList archivos = new ArrayList();
        private void LlenarArbol(DirectoryInfo di, TreeNodeCollection node)
        {
            TreeNode nodo = node.Add(di.Name);
            foreach (FileInfo archivo in di.GetFiles())
            {
                nodo.Nodes.Add(archivo.FullName, archivo.Name);
                archivos.Add(archivo);
            }
            foreach (DirectoryInfo sdi in di.GetDirectories())
            {
                LlenarArbol(sdi, nodo.Nodes);
            }
        }

        private void btnOrganizar_Click(object sender, EventArgs e)
        {
            
        }

        private void Organizar()
        {
            
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            MessageBox.Show("Selecciona donde se creara la nueva carpeta");
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(folderBrowserDialog.SelectedPath + "\\Carpeta");
                DirectoryInfo carpetaOrganizadaInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                MoverArchivos(carpetaOrganizadaInfo);
            }
        }
        private void MoverArchivos(DirectoryInfo di)
        {
            //foreach (FileInfo file in folderInfo.GetFiles())
            //{ File.Move(file.FullName, di + "\\Carpeta Organizada\\" + file); }
            //foreach (DirectoryInfo directoryInfo in folderInfo.GetDirectories())
            //{
            //    MoverArchivos(directoryInfo);
            //}
            foreach (FileInfo file in archivos)
            {

                { File.Copy(file.FullName, di + "\\Carpeta\\" + file); }
            }
        }
    }
}
