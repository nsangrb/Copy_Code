namespace View_manager
{
    partial class View_manager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_manager));
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.bt_List = new System.Windows.Forms.Button();
            this.cB_ListView = new System.Windows.Forms.ComboBox();
            this.tV_Vobs = new System.Windows.Forms.TreeView();
            this.imList = new System.Windows.Forms.ImageList(this.components);
            this.bt_Add = new System.Windows.Forms.Button();
            this.lV_Infos = new System.Windows.Forms.ListView();
            this.cH1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cB_TxtEditer = new System.Windows.Forms.ComboBox();
            this.tTip_1 = new System.Windows.Forms.ToolTip(this.components);
            this.cB_Copy2 = new System.Windows.Forms.ComboBox();
            this.bt_Browse = new System.Windows.Forms.Button();
            this.lb_Copy2 = new System.Windows.Forms.Label();
            this.bt_Run = new System.Windows.Forms.Button();
            this.cB_Threads = new System.Windows.Forms.ComboBox();
            this.lb_Thread = new System.Windows.Forms.Label();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.tablLay_1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tB_7z = new System.Windows.Forms.TextBox();
            this.lb_7z = new System.Windows.Forms.Label();
            this.bt_7z = new System.Windows.Forms.Button();
            this.cb_Templates = new System.Windows.Forms.ComboBox();
            this.lb_Templates = new System.Windows.Forms.Label();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Load = new System.Windows.Forms.Button();
            this.lb_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tablLay_1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tB_ID
            // 
            this.tB_ID.Location = new System.Drawing.Point(15, 13);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.Size = new System.Drawing.Size(97, 20);
            this.tB_ID.TabIndex = 0;
            // 
            // bt_List
            // 
            this.bt_List.Location = new System.Drawing.Point(118, 11);
            this.bt_List.Name = "bt_List";
            this.bt_List.Size = new System.Drawing.Size(75, 23);
            this.bt_List.TabIndex = 1;
            this.bt_List.Text = "List view";
            this.bt_List.UseVisualStyleBackColor = true;
            this.bt_List.Click += new System.EventHandler(this.Bt_List_Click);
            // 
            // cB_ListView
            // 
            this.cB_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cB_ListView.FormattingEnabled = true;
            this.cB_ListView.Items.AddRange(new object[] {
            "CODE_D7u2",
            "CODE_vcc"});
            this.cB_ListView.Location = new System.Drawing.Point(15, 39);
            this.cB_ListView.Name = "cB_ListView";
            this.cB_ListView.Size = new System.Drawing.Size(944, 21);
            this.cB_ListView.TabIndex = 2;
            this.cB_ListView.SelectedIndexChanged += new System.EventHandler(this.CB_ListView_SelectedIndexChanged);
            // 
            // tV_Vobs
            // 
            this.tV_Vobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tV_Vobs.Location = new System.Drawing.Point(3, 3);
            this.tV_Vobs.Name = "tV_Vobs";
            this.tV_Vobs.Size = new System.Drawing.Size(439, 190);
            this.tV_Vobs.StateImageList = this.imList;
            this.tV_Vobs.TabIndex = 3;
            this.tV_Vobs.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tV_Vobs_AfterExpand);
            this.tV_Vobs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TV_Vobs_MouseMove);
            // 
            // imList
            // 
            this.imList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imList.ImageStream")));
            this.imList.TransparentColor = System.Drawing.Color.Transparent;
            this.imList.Images.SetKeyName(0, "folder.ico");
            this.imList.Images.SetKeyName(1, "file.ico");
            // 
            // bt_Add
            // 
            this.bt_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Add.Location = new System.Drawing.Point(3, 3);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(48, 89);
            this.bt_Add.TabIndex = 4;
            this.bt_Add.Text = ">>";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.Bt_Add_Click);
            // 
            // lV_Infos
            // 
            this.lV_Infos.AllowColumnReorder = true;
            this.lV_Infos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH1,
            this.cH2});
            this.lV_Infos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lV_Infos.HideSelection = false;
            this.lV_Infos.Location = new System.Drawing.Point(508, 3);
            this.lV_Infos.Name = "lV_Infos";
            this.lV_Infos.ShowItemToolTips = true;
            this.lV_Infos.Size = new System.Drawing.Size(439, 190);
            this.lV_Infos.TabIndex = 5;
            this.lV_Infos.UseCompatibleStateImageBehavior = false;
            this.lV_Infos.View = System.Windows.Forms.View.Details;
            this.lV_Infos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lV_Infos_MouseDown);
            this.lV_Infos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lV_Infos_MouseUp);
            // 
            // cH1
            // 
            this.cH1.Text = "Path";
            this.cH1.Width = 323;
            // 
            // cH2
            // 
            this.cH2.Text = "Exts";
            this.cH2.Width = 88;
            // 
            // cB_TxtEditer
            // 
            this.cB_TxtEditer.FormattingEnabled = true;
            this.cB_TxtEditer.Items.AddRange(new object[] {
            "*.c *.h *.mak *.kgt *.kon",
            "*.c *.h",
            "*.py",
            "*.*"});
            this.cB_TxtEditer.Location = new System.Drawing.Point(520, 16);
            this.cB_TxtEditer.Name = "cB_TxtEditer";
            this.cB_TxtEditer.Size = new System.Drawing.Size(56, 21);
            this.cB_TxtEditer.TabIndex = 6;
            this.cB_TxtEditer.Visible = false;
            this.cB_TxtEditer.SelectedIndexChanged += new System.EventHandler(this.CB_TxtEditer_SelectedIndexChanged);
            this.cB_TxtEditer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cB_TxtEditer_KeyDown);
            this.cB_TxtEditer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CB_TxtEditer_KeyUp);
            this.cB_TxtEditer.Validated += new System.EventHandler(this.CB_TxtEditer_Validated);
            // 
            // cB_Copy2
            // 
            this.cB_Copy2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cB_Copy2.FormattingEnabled = true;
            this.cB_Copy2.Location = new System.Drawing.Point(72, 300);
            this.cB_Copy2.Name = "cB_Copy2";
            this.cB_Copy2.Size = new System.Drawing.Size(806, 21);
            this.cB_Copy2.TabIndex = 7;
            this.cB_Copy2.Text = "U:\\";
            // 
            // bt_Browse
            // 
            this.bt_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Browse.Location = new System.Drawing.Point(884, 300);
            this.bt_Browse.Name = "bt_Browse";
            this.bt_Browse.Size = new System.Drawing.Size(75, 23);
            this.bt_Browse.TabIndex = 8;
            this.bt_Browse.Text = "Browse";
            this.bt_Browse.UseVisualStyleBackColor = true;
            this.bt_Browse.Click += new System.EventHandler(this.Bt_Browse_Click);
            // 
            // lb_Copy2
            // 
            this.lb_Copy2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Copy2.AutoSize = true;
            this.lb_Copy2.Location = new System.Drawing.Point(12, 305);
            this.lb_Copy2.Name = "lb_Copy2";
            this.lb_Copy2.Size = new System.Drawing.Size(46, 13);
            this.lb_Copy2.TabIndex = 9;
            this.lb_Copy2.Text = "Copy to:";
            // 
            // bt_Run
            // 
            this.bt_Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Run.Location = new System.Drawing.Point(181, 328);
            this.bt_Run.Name = "bt_Run";
            this.bt_Run.Size = new System.Drawing.Size(44, 23);
            this.bt_Run.TabIndex = 10;
            this.bt_Run.Text = "Run";
            this.bt_Run.UseVisualStyleBackColor = true;
            this.bt_Run.Click += new System.EventHandler(this.Bt_Run_Click);
            // 
            // cB_Threads
            // 
            this.cB_Threads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cB_Threads.FormattingEnabled = true;
            this.cB_Threads.Items.AddRange(new object[] {
            "8",
            "16",
            "32",
            "64",
            "128"});
            this.cB_Threads.Location = new System.Drawing.Point(72, 273);
            this.cB_Threads.Name = "cB_Threads";
            this.cB_Threads.Size = new System.Drawing.Size(40, 21);
            this.cB_Threads.TabIndex = 11;
            this.cB_Threads.Text = "32";
            // 
            // lb_Thread
            // 
            this.lb_Thread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Thread.AutoSize = true;
            this.lb_Thread.Location = new System.Drawing.Point(12, 276);
            this.lb_Thread.Name = "lb_Thread";
            this.lb_Thread.Size = new System.Drawing.Size(55, 13);
            this.lb_Thread.TabIndex = 12;
            this.lb_Thread.Text = "Thread(s):";
            // 
            // bt_Remove
            // 
            this.bt_Remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Remove.Location = new System.Drawing.Point(3, 98);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(48, 89);
            this.bt_Remove.TabIndex = 13;
            this.bt_Remove.Text = "<<";
            this.bt_Remove.UseVisualStyleBackColor = true;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // tablLay_1
            // 
            this.tablLay_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablLay_1.ColumnCount = 3;
            this.tablLay_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablLay_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tablLay_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablLay_1.Controls.Add(this.tV_Vobs, 0, 0);
            this.tablLay_1.Controls.Add(this.lV_Infos, 2, 0);
            this.tablLay_1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tablLay_1.Location = new System.Drawing.Point(12, 66);
            this.tablLay_1.Name = "tablLay_1";
            this.tablLay_1.RowCount = 1;
            this.tablLay_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablLay_1.Size = new System.Drawing.Size(950, 196);
            this.tablLay_1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.bt_Remove, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bt_Add, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(448, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(54, 190);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tB_7z
            // 
            this.tB_7z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_7z.Location = new System.Drawing.Point(625, 330);
            this.tB_7z.Name = "tB_7z";
            this.tB_7z.Size = new System.Drawing.Size(253, 20);
            this.tB_7z.TabIndex = 15;
            this.tB_7z.Text = "C:\\Program Files (x86)\\7-Zip\\7z.exe";
            // 
            // lb_7z
            // 
            this.lb_7z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_7z.AutoSize = true;
            this.lb_7z.Location = new System.Drawing.Point(563, 333);
            this.lb_7z.Name = "lb_7z";
            this.lb_7z.Size = new System.Drawing.Size(56, 13);
            this.lb_7z.TabIndex = 16;
            this.lb_7z.Text = "7-zip path:";
            // 
            // bt_7z
            // 
            this.bt_7z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_7z.Location = new System.Drawing.Point(884, 328);
            this.bt_7z.Name = "bt_7z";
            this.bt_7z.Size = new System.Drawing.Size(75, 23);
            this.bt_7z.TabIndex = 17;
            this.bt_7z.Text = "...";
            this.bt_7z.UseVisualStyleBackColor = true;
            this.bt_7z.Click += new System.EventHandler(this.bt_7z_Click);
            // 
            // cb_Templates
            // 
            this.cb_Templates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Templates.FormattingEnabled = true;
            this.cb_Templates.Location = new System.Drawing.Point(792, 13);
            this.cb_Templates.Name = "cb_Templates";
            this.cb_Templates.Size = new System.Drawing.Size(167, 21);
            this.cb_Templates.TabIndex = 18;
            this.cb_Templates.DropDown += new System.EventHandler(this.cb_Templates_DropDown);
            this.cb_Templates.SelectedIndexChanged += new System.EventHandler(this.cb_Templates_SelectedIndexChanged);
            // 
            // lb_Templates
            // 
            this.lb_Templates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Templates.AutoSize = true;
            this.lb_Templates.Location = new System.Drawing.Point(727, 16);
            this.lb_Templates.Name = "lb_Templates";
            this.lb_Templates.Size = new System.Drawing.Size(59, 13);
            this.lb_Templates.TabIndex = 19;
            this.lb_Templates.Text = "Templates:";
            // 
            // bt_Save
            // 
            this.bt_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Save.Location = new System.Drawing.Point(884, 265);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(75, 23);
            this.bt_Save.TabIndex = 20;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Load
            // 
            this.bt_Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Load.Location = new System.Drawing.Point(759, 265);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(119, 23);
            this.bt_Load.TabIndex = 21;
            this.bt_Load.Text = "Load  your template";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(12, 333);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(38, 13);
            this.lb_Name.TabIndex = 22;
            this.lb_Name.Text = "Name:";
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_Name.Location = new System.Drawing.Point(72, 330);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(97, 20);
            this.tb_Name.TabIndex = 23;
            // 
            // View_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 361);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.bt_Load);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.lb_Templates);
            this.Controls.Add(this.cb_Templates);
            this.Controls.Add(this.bt_7z);
            this.Controls.Add(this.lb_7z);
            this.Controls.Add(this.tB_7z);
            this.Controls.Add(this.tablLay_1);
            this.Controls.Add(this.lb_Thread);
            this.Controls.Add(this.cB_Threads);
            this.Controls.Add(this.bt_Run);
            this.Controls.Add(this.lb_Copy2);
            this.Controls.Add(this.bt_Browse);
            this.Controls.Add(this.cB_Copy2);
            this.Controls.Add(this.cB_TxtEditer);
            this.Controls.Add(this.cB_ListView);
            this.Controls.Add(this.bt_List);
            this.Controls.Add(this.tB_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View_manager";
            this.Text = "Copy Code Manager";
            this.Load += new System.EventHandler(this.ViewManager_Load);
            this.tablLay_1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.Button bt_List;
        private System.Windows.Forms.ComboBox cB_ListView;
        private System.Windows.Forms.TreeView tV_Vobs;
        private System.Windows.Forms.ImageList imList;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.ListView lV_Infos;
        private System.Windows.Forms.ColumnHeader cH1;
        private System.Windows.Forms.ColumnHeader cH2;
        private System.Windows.Forms.ComboBox cB_TxtEditer;
        private System.Windows.Forms.ToolTip tTip_1;
        private System.Windows.Forms.ComboBox cB_Copy2;
        private System.Windows.Forms.Button bt_Browse;
        private System.Windows.Forms.Label lb_Copy2;
        private System.Windows.Forms.Button bt_Run;
        private System.Windows.Forms.ComboBox cB_Threads;
        private System.Windows.Forms.Label lb_Thread;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.TableLayoutPanel tablLay_1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tB_7z;
        private System.Windows.Forms.Label lb_7z;
        private System.Windows.Forms.Button bt_7z;
        private System.Windows.Forms.ComboBox cb_Templates;
        private System.Windows.Forms.Label lb_Templates;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox tb_Name;
    }
}

