using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using Cmd = View_manager.RunCommandLine;
using System.Text.RegularExpressions;

namespace View_manager
{
    public partial class View_manager : Form
    {
        private readonly string Templates_path = @"E:\bosch\Apps\Copy_Code_Manager\Templates";
        private ContextMenuStrip cms_tv_server = new ContextMenuStrip();
        public View_manager()
        {
            InitializeComponent();

            ToolStripMenuItem addVobs_interf = new ToolStripMenuItem();
            cms_tv_server.ItemClicked += new ToolStripItemClickedEventHandler(Cms_tV_sevrer_Click);
            addVobs_interf.Text = "Add Vobs";
            cms_tv_server.Items.Add(addVobs_interf);
            tV_Vobs.ContextMenuStrip = cms_tv_server;
        }

        private void Cms_tV_sevrer_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            List<TreeNode> tree_nodes = new List<TreeNode>();
            if (e.ClickedItem.Text == "Add Vobs")
            {
                List<String> mounted_vobs = new List<string>();
                foreach (TreeNode node in tV_Vobs.Nodes)
                {
                    mounted_vobs.Add(node.Text);
                }
                f_Add_Vobs f_Add_Vobs = new f_Add_Vobs();
                f_Add_Vobs.Load_AllVobs(mounted_vobs);
                f_Add_Vobs.ShowDialog();
                foreach (String vob in f_Add_Vobs.Mounted_vobs)
                {
                    if (tV_Vobs.Nodes.Find(vob, false).Length == 0)
                    {
                        try
                        {
                            TreeNode tn = new TreeNode();
                            tree_nodes.Add(LoadDirectory("N:\\" + tV_Vobs.Text + "\\" + vob));
                        }
                        catch { }
                    }
                }
            }
            tV_Vobs.BeginUpdate();
            tV_Vobs.Nodes.AddRange(tree_nodes.ToArray());
            tV_Vobs.EndUpdate();
        }

        private bool IsContentInVobs(List<string> vobs, string str)
        {
            foreach (string item in vobs)
            {
                if (item.Contains(str)) return true;
            }
            return false;
        }
        public TreeNode LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            TreeNode tds = new TreeNode(di.Name);
            tds.Tag = di.FullName;
            tds.ImageIndex = 0;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
            return tds;
        }
        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {

                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                //LoadFiles(subdirectory, tds);
                //LoadSubDirectories(subdirectory, tds);

            }
        }
        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");

            // Loop through them to see files  
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
            }
        }
        private void TV_Vobs_MouseMove(object sender, MouseEventArgs e)
        {
            TreeNode theNode = this.tV_Vobs.GetNodeAt(e.X, e.Y);

            // Set a ToolTip only if the mouse pointer is actually paused on a node.  
            if (theNode != null && theNode.Tag != null)
            {
                // Change the ToolTip only if the pointer moved to a new node.  
                if (theNode.Tag.ToString() != this.tTip_1.GetToolTip(this.tV_Vobs))
                    this.tTip_1.SetToolTip(this.tV_Vobs, theNode.Tag.ToString());

            }
            else     // Pointer is not over a node so clear the ToolTip.  
            {
                this.tTip_1.SetToolTip(this.tV_Vobs, "");
            }
        }
        private void Bt_List_Click(object sender, EventArgs e)
        {
            ListView();
            cB_ListView.Focus();
        }

        private void ListView()
        {
            cB_ListView.Items.Clear();
            List<String> Views = Cleartool.Instance.ListView_by_ID(tB_ID.Text);
            foreach (string item in Views)
            {
                cB_ListView.Items.Add(item);
            }
            cB_ListView.DroppedDown = true;
        }

        private void CB_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Templates.Text = "";
            lV_Infos.Items.Clear();
            tV_Vobs.Nodes.Clear();
            //Disable_all_elements();
            Cleartool.Instance.MountVobs_by_ConfigSpecs(cB_ListView.Text);
            Cleartool.Instance.Start_view(cB_ListView.Text);            
            List<string> view_path = DirectoryAlternative.EnumerateDirectories(@"N:\" + cB_ListView.Text).ToList();
            List_vobs(view_path);
        }
        void List_vobs(List<string> view_path)
        {
            List<TreeNode> tree_nodes = new List<TreeNode>();
            try
            {
                foreach (string item in view_path)
                {
                    try
                    {
                        if (DirectoryAlternative.EnumerateDirectories(item).Count() > 0)
                        {

                            this.Invoke((MethodInvoker)delegate ()
                            {
                                tree_nodes.Add(LoadDirectory(item));
                            });


                        }
                    }
                    catch { }
                }
            }
            catch { }
            tV_Vobs.BeginUpdate();
            tV_Vobs.Nodes.AddRange(tree_nodes.ToArray());
            tV_Vobs.EndUpdate();
        }
        private void ViewManager_Load(object sender, EventArgs e)
        {
            tB_ID.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1].ToLower();

            if (!File.Exists(tB_7z.Text))
            {
                if (tB_7z.Text.ToLower().Contains("program files (x86)")) tB_7z.Text = tB_7z.Text.Replace("Program Files (x86)", "Program Files");
                else tB_7z.Text = tB_7z.Text.Replace("Program Files", "Program Files (x86)");
            }
            if (!File.Exists(tB_7z.Text))
            {
                MessageBox.Show("Can't find Notepad++'s directory! Please choose the correct path!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(tV_Vobs.SelectedNode.Tag.ToString()))
                {
                    if (lV_Infos.FindItemWithText(tV_Vobs.SelectedNode.Tag.ToString()) == null)
                    {
                        ListViewItem __listViewItem = new ListViewItem(tV_Vobs.SelectedNode.Tag.ToString());
                        __listViewItem.SubItems.Add("*.*");
                        __listViewItem.Tag = tV_Vobs.SelectedNode.Tag.ToString();
                        __listViewItem.ToolTipText = tV_Vobs.SelectedNode.Tag.ToString();

                        lV_Infos.Items.Add(__listViewItem);
                    }
                }
                else
                {
                    if (File.Exists(tV_Vobs.SelectedNode.Tag.ToString()))
                    {
                        MessageBox.Show("Can NOT add a file!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch { }
        }
        ListViewItem.ListViewSubItem SelectedLSI;
        bool _isEditable = false;
        private void lV_Infos_MouseUp(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo i = lV_Infos.HitTest(e.X, e.Y);
            SelectedLSI = i.SubItem;
            if (SelectedLSI == null)
                return;

            int border = 0;
            switch (lV_Infos.BorderStyle)
            {
                case BorderStyle.FixedSingle:
                    border = 1;
                    break;
                case BorderStyle.Fixed3D:
                    border = 2;
                    break;
            }

            int CellWidth = SelectedLSI.Bounds.Width;
            int CellHeight = SelectedLSI.Bounds.Height;
            int CellLeft = border + lV_Infos.Left + i.SubItem.Bounds.Left + 13;
            int CellTop = tablLay_1.Top + i.SubItem.Bounds.Top + 2;
            // First Column
            if (i.SubItem != i.Item.SubItems[0])
            {
                _isEditable = true;
                cB_TxtEditer.Location = new Point(CellLeft, CellTop);
                cB_TxtEditer.Size = new Size(CellWidth, CellHeight);
                cB_TxtEditer.Visible = true;
                cB_TxtEditer.BringToFront();
                cB_TxtEditer.Text = i.SubItem.Text;
                cB_TxtEditer.Select();
                cB_TxtEditer.SelectAll();
            }
        }

        private void lV_Infos_MouseDown(object sender, MouseEventArgs e)
        {
            HideTextEditor();
        }

        private void TxtEdit_Leave(object sender, EventArgs e)
        {
            HideTextEditor();
        }

        private void TxtEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                HideTextEditor();
        }



        private void CB_TxtEditer_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideTextEditor();
        }

        private void CB_TxtEditer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HideTextEditor();
            }
        }
        private void CB_TxtEditer_Validated(object sender, EventArgs e)
        {
            HideTextEditor();
        }
        private void HideTextEditor()
        {
            cB_TxtEditer.Visible = false;
            if (SelectedLSI != null && _isEditable)
            {
                SelectedLSI.Text = cB_TxtEditer.Text;
                _isEditable = false;
            }
            SelectedLSI = null;
            cB_TxtEditer.Text = "";
        }

        private void Bt_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.SelectedPath = cB_Copy2.Text;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                cB_Copy2.Text = dlg.SelectedPath;
                string strTmp = cB_Copy2.Text;
                try
                {
                    if (strTmp == cB_Copy2.Items[0].ToString()) return;
                }
                catch { }
                if (cB_Copy2.FindStringExact(strTmp) != -1) cB_Copy2.Items.Remove(strTmp);
                cB_Copy2.Items.Insert(0, strTmp);
                cB_Copy2.SelectedIndex = 0;
            }
        }

        string _new_path = "";
        private void CreateRoot(string target, string source, int startindexRoot = 0)
        {
            string[] root_parts = source.Replace(@"\\", "\\").Split('\\');
            if (startindexRoot < root_parts.Count())
            {
                string new_targ = target + @"\" + root_parts[startindexRoot];
                _new_path = new_targ;
                if (startindexRoot == 0)
                {
                    root_parts[0] = root_parts[0].Remove(root_parts[0].IndexOf(':'));
                }
                if (!Directory.Exists(new_targ))
                {
                    Directory.CreateDirectory(new_targ);
                }
                CreateRoot(new_targ, source, startindexRoot + 1);
            }
        }
        private void Bt_Run_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text == "" || Regex.IsMatch(tb_Name.Text.Trim(), @"[/\\:*?<>|]"))
            {
                MessageBox.Show("Invalid folder name!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Name.Focus();
                tb_Name.SelectAll();
                return;
            }
            String cmd_str = "";
            Cmd.Instance.Delete_Dir(Path.Combine(Application.UserAppDataPath, tb_Name.Text));

            if (File.Exists(Path.Combine(Application.UserAppDataPath, tb_Name.Text + ".7z")))
            {
                File.Delete(Path.Combine(Application.UserAppDataPath, tb_Name.Text + ".7z"));
            }

            Directory.CreateDirectory(Path.Combine(Application.UserAppDataPath, tb_Name.Text));

            _new_path = "";
            foreach (ListViewItem lv_item in lV_Infos.Items)
            {
                CreateRoot(Path.Combine(Application.UserAppDataPath, tb_Name.Text), lv_item.Text, 2);
                cmd_str += "robocopy " + lv_item.Text + " " + _new_path + " " + lv_item.SubItems[1].Text + " /E /MT:" + cB_Threads.Text + "\r\n";
            }
            string _7z_path = "";
            if (tB_7z.Text.ToLower().IndexOf(@"c:\program files\") == 0) _7z_path = tB_7z.Text.ToLower().Replace("program files", "progra~1");
            else if (tB_7z.Text.ToLower().IndexOf(@"c:\program files (x86)\") == 0) _7z_path = tB_7z.Text.ToLower().Replace("program files (x86)", "progra~2");
            cmd_str += "\r\n" + _7z_path + " a -t7z " + Path.Combine(Application.UserAppDataPath, tb_Name.Text) + ".7z " + Path.Combine(Application.UserAppDataPath, tb_Name.Text);
            cmd_str += "\r\nxcopy " + Path.Combine(Application.UserAppDataPath, tb_Name.Text + ".7z") + " " + cB_Copy2.Text + " /y";
            Cmd.Instance.Run_cmd_batch(cmd_str,false);
            Cmd.Instance.Delete_Dir(Path.Combine(Application.UserAppDataPath, tb_Name.Text));

            if (File.Exists(Path.Combine(Application.UserAppDataPath, tb_Name.Text + ".7z")))
            {
                File.Delete(Path.Combine(Application.UserAppDataPath, tb_Name.Text + ".7z"));
            }
        }

        private void tV_Vobs_AfterExpand(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode td in e.Node.Nodes)
            {
                try
                {
                    if (td.GetNodeCount(false) == 0)
                    {
                        string Dir = td.Tag.ToString();
                        LoadSubDirectories(Dir, td);
                    }
                }
                catch { }
            }
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (lV_Infos.SelectedItems != null)
            {
                foreach (ListViewItem lv_item in lV_Infos.SelectedItems)
                {
                    lV_Infos.Items.Remove(lv_item);
                }
            }
        }

        private void cB_TxtEditer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cB_TxtEditer.FindStringExact(cB_TxtEditer.Text) != -1) cB_TxtEditer.Items.Remove(cB_TxtEditer.Text);
                cB_TxtEditer.Items.Insert(0, cB_TxtEditer.Text);
            }
        }

        private void bt_7z_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.FileName))
                {
                    tB_7z.Text = fbd.FileName;
                }
                else
                {
                    return;
                }

            }
        }

        private void cb_Templates_DropDown(object sender, EventArgs e)
        {
            cb_Templates.Items.Clear();
            FileInfo[] files = new DirectoryInfo(Templates_path).GetFiles();
            foreach (FileInfo file in files)
            {
                cb_Templates.Items.Add(file.Name);
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (lV_Infos.Items.Count == 0)
            {
                MessageBox.Show("Please choose paths to copy!!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tb_Name.Text == "" || Regex.IsMatch(tb_Name.Text.Trim(), @"[/\\:*?<>|]"))
            {
                MessageBox.Show("Please choose valid folder name!!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Name.Focus();
                tb_Name.SelectAll();
                return;
            }
            string save_path = "";
            using (var fbd = new SaveFileDialog())
            {
                fbd.InitialDirectory = Templates_path;
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.FileName))
                {
                    save_path = fbd.FileName;
                }
                else
                {
                    return;
                }

            }
            Save_Template(save_path);
        }

        private void Save_Template(string save_path)
        {
            string contents = "";
            foreach (TreeNode tn in tV_Vobs.Nodes)
            {
                contents += "@Vob:" + tn.Text + "\r\n";
            }
            contents += "@Name:" + tb_Name.Text + "\r\n";
            foreach (ListViewItem item in lV_Infos.Items)
            {
                contents += "@Path:" + item.Text.Replace("\\" + cB_ListView.Text + "\\", "\\<View_name>\\") + "|" + item.SubItems[1].Text + "\r\n";
            }

            try
            {
                if (File.Exists(save_path))
                {
                    // Schreibschutz aufheben:
                    FileAttributes attributes = File.GetAttributes(save_path);
                    if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    {
                        FileAttributes newAttributes = attributes ^ FileAttributes.ReadOnly;
                        File.SetAttributes(save_path, newAttributes);
                    }
                    // Datei löschen:
                    File.Delete(save_path);
                }
                FileStream fileStream = new FileStream(save_path, FileMode.Create, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(contents);

                streamWriter.Close();
                fileStream.Close();
            }
            catch (Exception)
            {
            }
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            if (cB_ListView.Text == "")
            {
                MessageBox.Show("Please select view name!!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cB_ListView.Focus();
                return;
            }
            string template_path = "";
            using (var fbd = new OpenFileDialog())
            {
                fbd.InitialDirectory = Templates_path;
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.FileName))
                {
                    template_path = fbd.FileName;
                }
                else
                {
                    return;
                }
            }
            Load_Template(template_path);
        }

        private void Load_Template(string template_path)
        {
            List<string> Lines = File.ReadAllLines(template_path).ToList();
            List<string> Vobs = new List<string>();
            tV_Vobs.Nodes.Clear();
            lV_Infos.Items.Clear();
            foreach (string line in Lines)
            {
                if (line.Contains("@Vob:"))
                {
                    Cleartool.Instance.Mount_vob(line.Replace("@Vob:", ""));
                    Vobs.Add("N:\\" + cB_ListView.Text + "\\" + line.Replace("@Vob:", ""));
                }
                else if (line.Contains("@Name:"))
                {
                    tb_Name.Text = line.Replace("@Name:", "");
                }
                else if (line.Contains("@Path:"))
                {
                    string[] path_infos = line.Split('|');
                    ListViewItem __listViewItem = new ListViewItem(path_infos[0].Replace("@Path:","").Replace("<View_name>",cB_ListView.Text));
                    __listViewItem.SubItems.Add(path_infos[1]);
                    __listViewItem.Tag = path_infos[0].Replace("@Path:", "").Replace("<View_name>", cB_ListView.Text);
                    __listViewItem.ToolTipText = path_infos[0].Replace("@Path:", "").Replace("<View_name>", cB_ListView.Text);
                    lV_Infos.Items.Add(__listViewItem);
                }
            }

            List_vobs(Vobs);
        }

        private void cb_Templates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_ListView.Text == "")
            {                
                MessageBox.Show("Please select view name!!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cB_ListView.Focus();
                return;
            }
            Load_Template(Path.Combine(Templates_path, cb_Templates.Text));
        }
    }
}
