namespace RecordKeeper
{
    partial class RecordKeeper
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
            mstrpFile = new ToolStripMenuItem();
            mstrpLoad = new ToolStripMenuItem();
            flRA = new ToolStripMenuItem();
            flRB = new ToolStripMenuItem();
            mstrpSave = new ToolStripMenuItem();
            fsRA = new ToolStripMenuItem();
            fsRB = new ToolStripMenuItem();
            panelSM = new Panel();
            spltcPanel = new SplitContainer();
            dgvRA = new DataGridView();
            cmsA = new ContextMenuStrip(components);
            aAdd = new ToolStripMenuItem();
            aaROW = new ToolStripMenuItem();
            aaCOL = new ToolStripMenuItem();
            aDelete = new ToolStripMenuItem();
            adROW = new ToolStripMenuItem();
            adCOL = new ToolStripMenuItem();
            lblRA = new Label();
            dgvRB = new DataGridView();
            cmsB = new ContextMenuStrip(components);
            bAdd = new ToolStripMenuItem();
            baROW = new ToolStripMenuItem();
            baCOL = new ToolStripMenuItem();
            bDelete = new ToolStripMenuItem();
            bdROW = new ToolStripMenuItem();
            bdCOL = new ToolStripMenuItem();
            lblRB = new Label();
            mstrpSM.SuspendLayout();
            panelSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spltcPanel).BeginInit();
            spltcPanel.Panel1.SuspendLayout();
            spltcPanel.Panel2.SuspendLayout();
            spltcPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRA).BeginInit();
            cmsA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRB).BeginInit();
            cmsB.SuspendLayout();
            SuspendLayout();
            // 
            // mstrpSM
            // 
            mstrpSM.BackColor = Color.Bisque;
            mstrpSM.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mstrpSM.Items.AddRange(new ToolStripItem[] { mstrpFile });
            mstrpSM.Location = new Point(0, 0);
            mstrpSM.Name = "mstrpSM";
            mstrpSM.Size = new Size(1165, 28);
            mstrpSM.TabIndex = 0;
            mstrpSM.Text = "menuStrip1";
            // 
            // mstrpFile
            // 
            mstrpFile.DropDownItems.AddRange(new ToolStripItem[] { mstrpLoad, mstrpSave });
            mstrpFile.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mstrpFile.Name = "mstrpFile";
            mstrpFile.Size = new Size(42, 24);
            mstrpFile.Text = "File";
            // 
            // mstrpLoad
            // 
            mstrpLoad.DropDownItems.AddRange(new ToolStripItem[] { flRA, flRB });
            mstrpLoad.Name = "mstrpLoad";
            mstrpLoad.Size = new Size(106, 24);
            mstrpLoad.Text = "Load";
            // 
            // flRA
            // 
            flRA.Name = "flRA";
            flRA.Size = new Size(180, 24);
            flRA.Text = "Record A";
            flRA.Click += flRA_Click;
            // 
            // flRB
            // 
            flRB.Name = "flRB";
            flRB.Size = new Size(180, 24);
            flRB.Text = "Record B";
            flRB.Click += flRB_Click;
            // 
            // mstrpSave
            // 
            mstrpSave.DropDownItems.AddRange(new ToolStripItem[] { fsRA, fsRB });
            mstrpSave.Name = "mstrpSave";
            mstrpSave.Size = new Size(106, 24);
            mstrpSave.Text = "Save";
            // 
            // fsRA
            // 
            fsRA.Name = "fsRA";
            fsRA.Size = new Size(180, 24);
            fsRA.Text = "Record A";
            fsRA.Click += fsRA_Click;
            // 
            // fsRB
            // 
            fsRB.Name = "fsRB";
            fsRB.Size = new Size(180, 24);
            fsRB.Text = "Record B";
            fsRB.Click += fsRB_Click;
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
            spltcPanel.Panel1.Controls.Add(dgvRA);
            spltcPanel.Panel1.Controls.Add(lblRA);
            // 
            // spltcPanel.Panel2
            // 
            spltcPanel.Panel2.Controls.Add(dgvRB);
            spltcPanel.Panel2.Controls.Add(lblRB);
            spltcPanel.Size = new Size(1139, 622);
            spltcPanel.SplitterDistance = 310;
            spltcPanel.TabIndex = 0;
            // 
            // dgvRA
            // 
            dgvRA.AllowUserToAddRows = false;
            dgvRA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRA.BackgroundColor = Color.AntiqueWhite;
            dgvRA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRA.ContextMenuStrip = cmsA;
            dgvRA.Location = new Point(3, 35);
            dgvRA.Name = "dgvRA";
            dgvRA.Size = new Size(1133, 272);
            dgvRA.TabIndex = 1;
            // 
            // cmsA
            // 
            cmsA.Font = new Font("Arial Narrow", 11.25F);
            cmsA.Items.AddRange(new ToolStripItem[] { aAdd, aDelete });
            cmsA.Name = "cmsProfle";
            cmsA.Size = new Size(115, 52);
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
            // lblRA
            // 
            lblRA.AutoSize = true;
            lblRA.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRA.Location = new Point(6, 9);
            lblRA.Name = "lblRA";
            lblRA.Size = new Size(75, 20);
            lblRA.TabIndex = 0;
            lblRA.Text = "RECORD A";
            // 
            // dgvRB
            // 
            dgvRB.AllowUserToAddRows = false;
            dgvRB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRB.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRB.BackgroundColor = Color.AntiqueWhite;
            dgvRB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRB.ContextMenuStrip = cmsB;
            dgvRB.Location = new Point(3, 33);
            dgvRB.Name = "dgvRB";
            dgvRB.Size = new Size(1133, 272);
            dgvRB.TabIndex = 2;
            // 
            // cmsB
            // 
            cmsB.Font = new Font("Arial Narrow", 11.25F);
            cmsB.Items.AddRange(new ToolStripItem[] { bAdd, bDelete });
            cmsB.Name = "cmsProfle";
            cmsB.Size = new Size(115, 52);
            // 
            // bAdd
            // 
            bAdd.DropDownItems.AddRange(new ToolStripItem[] { baROW, baCOL });
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(114, 24);
            bAdd.Text = "Add";
            // 
            // baROW
            // 
            baROW.Name = "baROW";
            baROW.Size = new Size(122, 24);
            baROW.Text = "Row";
            baROW.Click += baROW_Click;
            // 
            // baCOL
            // 
            baCOL.Name = "baCOL";
            baCOL.Size = new Size(122, 24);
            baCOL.Text = "Column";
            baCOL.Click += baCOL_Click;
            // 
            // bDelete
            // 
            bDelete.DropDownItems.AddRange(new ToolStripItem[] { bdROW, bdCOL });
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(114, 24);
            bDelete.Text = "Delete";
            // 
            // bdROW
            // 
            bdROW.Name = "bdROW";
            bdROW.Size = new Size(122, 24);
            bdROW.Text = "Row";
            bdROW.Click += bdROW_Click;
            // 
            // bdCOL
            // 
            bdCOL.Name = "bdCOL";
            bdCOL.Size = new Size(122, 24);
            bdCOL.Text = "Column";
            bdCOL.Click += bdCOL_Click;
            // 
            // lblRB
            // 
            lblRB.AutoSize = true;
            lblRB.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRB.Location = new Point(6, 7);
            lblRB.Name = "lblRB";
            lblRB.Size = new Size(75, 20);
            lblRB.TabIndex = 1;
            lblRB.Text = "RECORD B";
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
            ((System.ComponentModel.ISupportInitialize)dgvRA).EndInit();
            cmsA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRB).EndInit();
            cmsB.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mstrpSM;
        private ToolStripMenuItem mstrpFile;
        private ToolStripMenuItem mstrpLoad;
        private ToolStripMenuItem mstrpSave;
        private Panel panelSM;
        private SplitContainer spltcPanel;
        private Label lblRA;
        private Label lblRB;
        private DataGridView dgvRA;
        private DataGridView dgvRB;
        private ContextMenuStrip cmsA;
        private ToolStripMenuItem aAdd;
        private ToolStripMenuItem aaROW;
        private ToolStripMenuItem aaCOL;
        private ToolStripMenuItem aDelete;
        private ToolStripMenuItem adROW;
        private ToolStripMenuItem adCOL;
        private ContextMenuStrip cmsB;
        private ToolStripMenuItem bAdd;
        private ToolStripMenuItem baROW;
        private ToolStripMenuItem baCOL;
        private ToolStripMenuItem bDelete;
        private ToolStripMenuItem bdROW;
        private ToolStripMenuItem bdCOL;
        private ToolStripMenuItem flRA;
        private ToolStripMenuItem flRB;
        private ToolStripMenuItem fsRA;
        private ToolStripMenuItem fsRB;
    }
}
