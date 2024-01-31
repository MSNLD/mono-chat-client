namespace mono_chat_client
{
    partial class Form1
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
      splitContainer2 = new SplitContainer();
      splitContainer3 = new SplitContainer();
      chatFrame1 = new ChatFrame();
      chatFrame2 = new ChatFrame();
      splitContainer4 = new SplitContainer();
      chatFrame3 = new ChatFrame();
      chatFrame4 = new ChatFrame();
      menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
      splitContainer1.Panel1.SuspendLayout();
      splitContainer1.Panel2.SuspendLayout();
      splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
      splitContainer2.Panel1.SuspendLayout();
      splitContainer2.Panel2.SuspendLayout();
      splitContainer2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
      splitContainer3.Panel1.SuspendLayout();
      splitContainer3.Panel2.SuspendLayout();
      splitContainer3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
      splitContainer4.Panel1.SuspendLayout();
      splitContainer4.Panel2.SuspendLayout();
      splitContainer4.SuspendLayout();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(1349, 24);
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
      newToolStripMenuItem.Size = new Size(107, 22);
      newToolStripMenuItem.Text = "&New...";
      // 
      // exitToolStripMenuItem
      // 
      exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      exitToolStripMenuItem.Size = new Size(107, 22);
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
      statusStrip1.Location = new Point(0, 436);
      statusStrip1.Name = "statusStrip1";
      statusStrip1.Size = new Size(1349, 22);
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
      // 
      // splitContainer1.Panel2
      // 
      splitContainer1.Panel2.Controls.Add(splitContainer2);
      splitContainer1.Size = new Size(1349, 412);
      splitContainer1.SplitterDistance = 345;
      splitContainer1.TabIndex = 3;
      // 
      // treeView1
      // 
      treeView1.Dock = DockStyle.Fill;
      treeView1.Location = new Point(0, 0);
      treeView1.Name = "treeView1";
      treeView1.Size = new Size(345, 412);
      treeView1.TabIndex = 3;
      // 
      // splitContainer2
      // 
      splitContainer2.Dock = DockStyle.Fill;
      splitContainer2.Location = new Point(0, 0);
      splitContainer2.Name = "splitContainer2";
      // 
      // splitContainer2.Panel1
      // 
      splitContainer2.Panel1.Controls.Add(splitContainer3);
      // 
      // splitContainer2.Panel2
      // 
      splitContainer2.Panel2.Controls.Add(splitContainer4);
      splitContainer2.Size = new Size(1000, 412);
      splitContainer2.SplitterDistance = 500;
      splitContainer2.TabIndex = 0;
      // 
      // splitContainer3
      // 
      splitContainer3.Dock = DockStyle.Fill;
      splitContainer3.Location = new Point(0, 0);
      splitContainer3.Name = "splitContainer3";
      // 
      // splitContainer3.Panel1
      // 
      splitContainer3.Panel1.Controls.Add(chatFrame1);
      // 
      // splitContainer3.Panel2
      // 
      splitContainer3.Panel2.Controls.Add(chatFrame2);
      splitContainer3.Size = new Size(500, 412);
      splitContainer3.SplitterDistance = 250;
      splitContainer3.TabIndex = 0;
      // 
      // chatFrame1
      // 
      chatFrame1.AutoSize = true;
      chatFrame1.Dock = DockStyle.Fill;
      chatFrame1.Location = new Point(0, 0);
      chatFrame1.Name = "chatFrame1";
      chatFrame1.Size = new Size(250, 412);
      chatFrame1.TabIndex = 0;
      // 
      // chatFrame2
      // 
      chatFrame2.AutoSize = true;
      chatFrame2.Dock = DockStyle.Fill;
      chatFrame2.Location = new Point(0, 0);
      chatFrame2.Name = "chatFrame2";
      chatFrame2.Size = new Size(246, 412);
      chatFrame2.TabIndex = 0;
      // 
      // splitContainer4
      // 
      splitContainer4.Dock = DockStyle.Fill;
      splitContainer4.Location = new Point(0, 0);
      splitContainer4.Name = "splitContainer4";
      // 
      // splitContainer4.Panel1
      // 
      splitContainer4.Panel1.Controls.Add(chatFrame3);
      // 
      // splitContainer4.Panel2
      // 
      splitContainer4.Panel2.Controls.Add(chatFrame4);
      splitContainer4.Size = new Size(496, 412);
      splitContainer4.SplitterDistance = 248;
      splitContainer4.TabIndex = 0;
      // 
      // chatFrame3
      // 
      chatFrame3.AutoSize = true;
      chatFrame3.Dock = DockStyle.Fill;
      chatFrame3.Location = new Point(0, 0);
      chatFrame3.Name = "chatFrame3";
      chatFrame3.Size = new Size(248, 412);
      chatFrame3.TabIndex = 0;
      // 
      // chatFrame4
      // 
      chatFrame4.AutoSize = true;
      chatFrame4.Dock = DockStyle.Fill;
      chatFrame4.Location = new Point(0, 0);
      chatFrame4.Name = "chatFrame4";
      chatFrame4.Size = new Size(244, 412);
      chatFrame4.TabIndex = 0;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1349, 458);
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
      splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
      splitContainer1.ResumeLayout(false);
      splitContainer2.Panel1.ResumeLayout(false);
      splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
      splitContainer2.ResumeLayout(false);
      splitContainer3.Panel1.ResumeLayout(false);
      splitContainer3.Panel1.PerformLayout();
      splitContainer3.Panel2.ResumeLayout(false);
      splitContainer3.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
      splitContainer3.ResumeLayout(false);
      splitContainer4.Panel1.ResumeLayout(false);
      splitContainer4.Panel1.PerformLayout();
      splitContainer4.Panel2.ResumeLayout(false);
      splitContainer4.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
      splitContainer4.ResumeLayout(false);
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
    private SplitContainer splitContainer2;
    private SplitContainer splitContainer3;
    private ChatFrame chatFrame1;
    private ChatFrame chatFrame2;
    private SplitContainer splitContainer4;
    private ChatFrame chatFrame3;
    private ChatFrame chatFrame4;
  }
}
