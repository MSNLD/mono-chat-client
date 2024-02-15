namespace mono_chat_client
{
    partial class MainWindow
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
      menuStrip1 = new MenuStrip();
      fileToolStripMenuItem = new ToolStripMenuItem();
      newToolStripMenuItem = new ToolStripMenuItem();
      exitToolStripMenuItem = new ToolStripMenuItem();
      helpToolStripMenuItem = new ToolStripMenuItem();
      aboutToolStripMenuItem = new ToolStripMenuItem();
      statusStrip1 = new StatusStrip();
      splitContainer1 = new SplitContainer();
      treeView1 = new TreeView();
      viewToolStripMenuItem = new ToolStripMenuItem();
      optionsToolStripMenuItem = new ToolStripMenuItem();
      menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
      splitContainer1.Panel1.SuspendLayout();
      splitContainer1.SuspendLayout();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(938, 24);
      menuStrip1.TabIndex = 0;
      menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, exitToolStripMenuItem });
      fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      fileToolStripMenuItem.Size = new Size(37, 20);
      fileToolStripMenuItem.Text = "&File";
      // 
      // newToolStripMenuItem
      // 
      newToolStripMenuItem.Enabled = false;
      newToolStripMenuItem.Name = "newToolStripMenuItem";
      newToolStripMenuItem.Size = new Size(180, 22);
      newToolStripMenuItem.Text = "&New...";
      // 
      // exitToolStripMenuItem
      // 
      exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      exitToolStripMenuItem.Size = new Size(180, 22);
      exitToolStripMenuItem.Text = "E&xit";
      exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
      // 
      // helpToolStripMenuItem
      // 
      helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
      helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      helpToolStripMenuItem.Size = new Size(44, 20);
      helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      aboutToolStripMenuItem.Enabled = false;
      aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      aboutToolStripMenuItem.Size = new Size(107, 22);
      aboutToolStripMenuItem.Text = "&About";
      // 
      // statusStrip1
      // 
      statusStrip1.Location = new Point(0, 435);
      statusStrip1.Name = "statusStrip1";
      statusStrip1.Size = new Size(938, 22);
      statusStrip1.TabIndex = 1;
      statusStrip1.Text = "statusStrip1";
      // 
      // splitContainer1
      // 
      splitContainer1.Dock = DockStyle.Fill;
      splitContainer1.Location = new Point(0, 24);
      splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      splitContainer1.Panel1.Controls.Add(treeView1);
      splitContainer1.Size = new Size(938, 411);
      splitContainer1.SplitterDistance = 199;
      splitContainer1.TabIndex = 3;
      // 
      // treeView1
      // 
      treeView1.Dock = DockStyle.Fill;
      treeView1.Location = new Point(0, 0);
      treeView1.Name = "treeView1";
      treeView1.Size = new Size(199, 411);
      treeView1.TabIndex = 3;
      // 
      // viewToolStripMenuItem
      // 
      viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
      viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      viewToolStripMenuItem.Size = new Size(44, 20);
      viewToolStripMenuItem.Text = "&View";
      // 
      // optionsToolStripMenuItem
      // 
      optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      optionsToolStripMenuItem.Size = new Size(180, 22);
      optionsToolStripMenuItem.Text = "&Options";
      optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(938, 457);
      Controls.Add(splitContainer1);
      Controls.Add(statusStrip1);
      Controls.Add(menuStrip1);
      MainMenuStrip = menuStrip1;
      Name = "Form1";
      Text = "Mono Chat Client";
      Load += Form1_Load;
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      splitContainer1.Panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
      splitContainer1.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private StatusStrip statusStrip1;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem newToolStripMenuItem;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private SplitContainer splitContainer1;
    private TreeView treeView1;
    private ToolStripMenuItem viewToolStripMenuItem;
    private ToolStripMenuItem optionsToolStripMenuItem;
  }
}
