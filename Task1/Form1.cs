using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;


namespace Task1
{
    public partial class Form1 : Form
    {
        static StringCollection log = new StringCollection();
        string filter = "*.*";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] drives = System.Environment.GetLogicalDrives();
            foreach (string dr in drives)
            {
                DriveInfo driveInfo = new DriveInfo(dr);
                lbxDrives.Items.Add(driveInfo);
            }

        }

        private void ListDirectory(TreeView treeView,DirectoryInfo directoryInfo)
        {
            treeView.Nodes.Clear();
            treeView.Nodes.Add(WalkDirectoryTree(directoryInfo));
        }
        
        private TreeNode WalkDirectoryTree(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            try
            {
                foreach (var directory in directoryInfo.GetDirectories())
                {
                    directoryNode.Nodes.Add(WalkDirectoryTree(directory));
                }
                foreach (var file in directoryInfo.GetFiles(filter))
                {
                    directoryNode.Nodes.Add(new TreeNode(file.Name));
                }
            }
            catch (UnauthorizedAccessException e)
            {
                log.Add(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                log.Add(e.Message);
            }

            return directoryNode;
        }

        private void lbxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ClearTextBox();
                DriveInfoAndTree();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                log.Add(ex.Message);
            }
        }

        private void DriveInfoTxtBox(DriveInfo drive)
        {
            txtDriveInfo.Text = "Drive letter: " + drive.Name.ElementAt(0) +
                  "\t Drive name : " + drive.Name + "\t Free space : " + drive.AvailableFreeSpace / 1073741824
                  + " GB" + "\t Total size : " + drive.TotalSize / 1073741824 + " GB";
        }

        private void ClearTextBox()
        {
            txtItemName.Text = "";
            txtItemSize.Text = "";
            txtItemAttribute.Text = "";
        }

        private void DriveInfoAndTree()
        {
            DriveInfo drive = (DriveInfo)lbxDrives.SelectedItem;
            DriveInfoTxtBox(drive);
            DirectoryInfo rootDir = drive.RootDirectory;
            ListDirectory(tvTree, rootDir);
        }

        private void tvTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string typeOfNode;
            string secondDetail = " ";
            string attribute = " ";
            bool isNodeFolder = true;

            if (!Directory.Exists(tvTree.SelectedNode.FullPath))
            {
                isNodeFolder = false;
            }
            if (!isNodeFolder)
            {
                var selectedDirectory = new DirectoryInfo(tvTree.SelectedNode.Parent.FullPath);
                foreach (var file in selectedDirectory.GetFiles())
                {
                    if (tvTree.SelectedNode.Text == file.Name)
                    {
                        FileInfo selectedFile = file;
                        secondDetail = "File size : " + (selectedFile.Length / 1024).ToString() + " KB";
                        attribute = selectedFile.Attributes.ToString();
                    }
                }
                typeOfNode = "File";
                SelectedItemInfo(typeOfNode, secondDetail, attribute);
            }
            else
            {
                typeOfNode = "Folder";
                var selectedDirectory = new DirectoryInfo(tvTree.SelectedNode.FullPath);
                secondDetail = "Number of files : " + (tvTree.SelectedNode.GetNodeCount(true)).ToString();
                attribute = selectedDirectory.Attributes.ToString();
                SelectedItemInfo(typeOfNode, secondDetail, attribute);
            }
        }

        private void SelectedItemInfo(string typeOfNode, string secondDetail, string attribute)
        {
            txtItemName.Text = "Name of " + typeOfNode + " : " + tvTree.SelectedNode.ToString().Replace("TreeNode: ", "");
            txtItemSize.Text = secondDetail;
            txtItemAttribute.Text = typeOfNode + " attribute: " + attribute;
        }

        private void tvTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            System.Diagnostics.Process.Start(tvTree.SelectedNode.FullPath);
        }
        
        private void btnFileFilter_Click(object sender, EventArgs e)
        {
            if (lbxDrives.SelectedIndex == -1)
            {
                lbxDrives.SelectedIndex = 0;
            }

            if (txtFileType.Text == "" || txtFileType.Text == " ")
            {
                filter = "*.*";
            }
            else
                filter = "*." + txtFileType.Text;
            DriveInfoAndTree();
        }
    }
}
