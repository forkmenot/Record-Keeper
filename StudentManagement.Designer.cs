namespace StudentManagement
{
    partial class StudentManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mstrpSM = new MenuStrip();
            filesToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            flProfile = new ToolStripMenuItem();
            flAccount = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            fsProfile = new ToolStripMenuItem();
            fsAccount = new ToolStripMenuItem();
            panelSM = new Panel();
            spltcPanel = new SplitContainer();
            dgvProfile = new DataGridView();
            cmsProfle = new ContextMenuStrip(components);
            pAdd = new ToolStripMenuItem();
            paROW = new ToolStripMenuItem();
            paCOL = new ToolStripMenuItem();
            pDelete = new ToolStripMenuItem();
            pdROW = new ToolStripMenuItem();
            pdCOL = new ToolStripMenuItem();
            lblProfile = new Label();
            dgvAccount = new DataGridView();
            cmsAccount = new ContextMenuStrip(components);
            aAdd = new ToolStripMenuItem();
            aaROW = new ToolStripMenuItem();
            aaCOL = new ToolStripMenuItem();
            aDelete = new ToolStripMenuItem();
            adROW = new ToolStripMenuItem();
            adCOL = new ToolStripMenuItem();
            lblAccount = new Label();
            mstrpSM.SuspendLayout();
            panelSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spltcPanel).BeginInit();
            spltcPanel.Panel1.SuspendLayout();
            spltcPanel.Panel2.SuspendLayout();
            spltcPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProfile).BeginInit();
            cmsProfle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            cmsAccount.SuspendLayout();
            SuspendLayout();
            // 
            // mstrpSM
            // 
            mstrpSM.BackColor = Color.Bisque;
            mstrpSM.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mstrpSM.Items.AddRange(new ToolStripItem[] { filesToolStripMenuItem });
            mstrpSM.Location = new Point(0, 0);
            mstrpSM.Name = "mstrpSM";
            mstrpSM.Size = new Size(1165, 28);
            mstrpSM.TabIndex = 0;
            mstrpSM.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, saveToolStripMenuItem });
            filesToolStripMenuItem.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(42, 24);
            filesToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { flProfile, flAccount });
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(180, 24);
            loadToolStripMenuItem.Text = "Load";
            // 
            // flProfile
            // 
            flProfile.Name = "flProfile";
            flProfile.Size = new Size(158, 24);
            flProfile.Text = "Student Profile";
            flProfile.Click += flProfile_Click;
            // 
            // flAccount
            // 
            flAccount.Name = "flAccount";
            flAccount.Size = new Size(158, 24);
            flAccount.Text = "Accounting";
            flAccount.Click += flAccount_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fsProfile, fsAccount });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 24);
            saveToolStripMenuItem.Text = "Save";
            // 
            // fsProfile
            // 
            fsProfile.Name = "fsProfile";
            fsProfile.Size = new Size(180, 24);
            fsProfile.Text = "Student Profile";
            fsProfile.Click += fsProfile_Click;
            // 
            // fsAccount
            // 
            fsAccount.Name = "fsAccount";
            fsAccount.Size = new Size(180, 24);
            fsAccount.Text = "Accounting";
            fsAccount.Click += fsAccount_Click;
            // 
            // panelSM
            // 
            panelSM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSM.BorderStyle = BorderStyle.FixedSingle;
            panelSM.Controls.Add(spltcPanel);
            panelSM.Location = new Point(12, 31);
            panelSM.Name = "panelSM";
            panelSM.Size = new Size(1141, 624);
            panelSM.TabIndex = 1;
            // 
            // spltcPanel
            // 
            spltcPanel.Dock = DockStyle.Fill;
            spltcPanel.IsSplitterFixed = true;
            spltcPanel.Location = new Point(0, 0);
            spltcPanel.Name = "spltcPanel";
            spltcPanel.Orientation = Orientation.Horizontal;
            // 
            // spltcPanel.Panel1
            // 
            spltcPanel.Panel1.Controls.Add(dgvProfile);
            spltcPanel.Panel1.Controls.Add(lblProfile);
            // 
            // spltcPanel.Panel2
            // 
            spltcPanel.Panel2.Controls.Add(dgvAccount);
            spltcPanel.Panel2.Controls.Add(lblAccount);
            spltcPanel.Size = new Size(1139, 622);
            spltcPanel.SplitterDistance = 310;
            spltcPanel.TabIndex = 0;
            // 
            // dgvProfile
            // 
            dgvProfile.AllowUserToAddRows = false;
            dgvProfile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProfile.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProfile.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProfile.BackgroundColor = Color.AntiqueWhite;
            dgvProfile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfile.ContextMenuStrip = cmsProfle;
            dgvProfile.Location = new Point(3, 35);
            dgvProfile.Name = "dgvProfile";
            dgvProfile.Size = new Size(1133, 272);
            dgvProfile.TabIndex = 1;
            // 
            // cmsProfle
            // 
            cmsProfle.Font = new Font("Arial Narrow", 11.25F);
            cmsProfle.Items.AddRange(new ToolStripItem[] { pAdd, pDelete });
            cmsProfle.Name = "cmsProfle";
            cmsProfle.Size = new Size(115, 52);
            // 
            // pAdd
            // 
            pAdd.DropDownItems.AddRange(new ToolStripItem[] { paROW, paCOL });
            pAdd.Name = "pAdd";
            pAdd.Size = new Size(114, 24);
            pAdd.Text = "Add";
            // 
            // paROW
            // 
            paROW.Name = "paROW";
            paROW.Size = new Size(122, 24);
            paROW.Text = "Row";
            paROW.Click += paROW_Click;
            // 
            // paCOL
            // 
            paCOL.Name = "paCOL";
            paCOL.Size = new Size(122, 24);
            paCOL.Text = "Column";
            paCOL.Click += paCOL_Click;
            // 
            // pDelete
            // 
            pDelete.DropDownItems.AddRange(new ToolStripItem[] { pdROW, pdCOL });
            pDelete.Name = "pDelete";
            pDelete.Size = new Size(114, 24);
            pDelete.Text = "Delete";
            // 
            // pdROW
            // 
            pdROW.Name = "pdROW";
            pdROW.Size = new Size(122, 24);
            pdROW.Text = "Row";
            pdROW.Click += pdROW_Click;
            // 
            // pdCOL
            // 
            pdCOL.Name = "pdCOL";
            pdCOL.Size = new Size(122, 24);
            pdCOL.Text = "Column";
            pdCOL.Click += pdCOL_Click;
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfile.Location = new Point(6, 9);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(126, 20);
            lblProfile.TabIndex = 0;
            lblProfile.Text = "STUDENT PROFILE";
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAccount.BackgroundColor = Color.AntiqueWhite;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.ContextMenuStrip = cmsAccount;
            dgvAccount.Location = new Point(3, 33);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.Size = new Size(1133, 272);
            dgvAccount.TabIndex = 2;
            // 
            // cmsAccount
            // 
            cmsAccount.Font = new Font("Arial Narrow", 11.25F);
            cmsAccount.Items.AddRange(new ToolStripItem[] { aAdd, aDelete });
            cmsAccount.Name = "cmsProfle";
            cmsAccount.Size = new Size(115, 52);
            // 
            // aAdd
            // 
            aAdd.DropDownItems.AddRange(new ToolStripItem[] { aaROW, aaCOL });
            aAdd.Name = "aAdd";
            aAdd.Size = new Size(114, 24);
            aAdd.Text = "Add";
            // 
            // aaROW
            // 
            aaROW.Name = "aaROW";
            aaROW.Size = new Size(122, 24);
            aaROW.Text = "Row";
            aaROW.Click += aaROW_Click;
            // 
            // aaCOL
            // 
            aaCOL.Name = "aaCOL";
            aaCOL.Size = new Size(122, 24);
            aaCOL.Text = "Column";
            aaCOL.Click += aaCOL_Click;
            // 
            // aDelete
            // 
            aDelete.DropDownItems.AddRange(new ToolStripItem[] { adROW, adCOL });
            aDelete.Name = "aDelete";
            aDelete.Size = new Size(114, 24);
            aDelete.Text = "Delete";
            // 
            // adROW
            // 
            adROW.Name = "adROW";
            adROW.Size = new Size(122, 24);
            adROW.Text = "Row";
            adROW.Click += adROW_Click;
            // 
            // adCOL
            // 
            adCOL.Name = "adCOL";
            adCOL.Size = new Size(122, 24);
            adCOL.Text = "Column";
            adCOL.Click += adCOL_Click;
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccount.Location = new Point(6, 7);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(95, 20);
            lblAccount.TabIndex = 1;
            lblAccount.Text = "ACCOUNTING";
            // 
            // StudentManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1165, 667);
            Controls.Add(panelSM);
            Controls.Add(mstrpSM);
            Name = "StudentManagement";
            ShowIcon = false;
            mstrpSM.ResumeLayout(false);
            mstrpSM.PerformLayout();
            panelSM.ResumeLayout(false);
            spltcPanel.Panel1.ResumeLayout(false);
            spltcPanel.Panel1.PerformLayout();
            spltcPanel.Panel2.ResumeLayout(false);
            spltcPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spltcPanel).EndInit();
            spltcPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProfile).EndInit();
            cmsProfle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            cmsAccount.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mstrpSM;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Panel panelSM;
        private SplitContainer spltcPanel;
        private Label lblProfile;
        private Label lblAccount;
        private DataGridView dgvProfile;
        private DataGridView dgvAccount;
        private ContextMenuStrip cmsProfle;
        private ToolStripMenuItem pAdd;
        private ToolStripMenuItem paROW;
        private ToolStripMenuItem paCOL;
        private ToolStripMenuItem pDelete;
        private ToolStripMenuItem pdROW;
        private ToolStripMenuItem pdCOL;
        private ContextMenuStrip cmsAccount;
        private ToolStripMenuItem aAdd;
        private ToolStripMenuItem aaROW;
        private ToolStripMenuItem aaCOL;
        private ToolStripMenuItem aDelete;
        private ToolStripMenuItem adROW;
        private ToolStripMenuItem adCOL;
        private ToolStripMenuItem flProfile;
        private ToolStripMenuItem flAccount;
        private ToolStripMenuItem fsProfile;
        private ToolStripMenuItem fsAccount;
    }
}
