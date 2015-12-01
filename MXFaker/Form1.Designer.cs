namespace MXFaker
{
  partial class Form1
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
      this.trackFolders = new System.Windows.Forms.TrackBar();
      this.label1 = new System.Windows.Forms.Label();
      this.txtFolders = new System.Windows.Forms.TextBox();
      this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.label2 = new System.Windows.Forms.Label();
      this.textFolder = new System.Windows.Forms.TextBox();
      this.btnFolder = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.trackSize = new System.Windows.Forms.TrackBar();
      this.txtSize = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtFiles = new System.Windows.Forms.TextBox();
      this.trackFiles = new System.Windows.Forms.TrackBar();
      this.label6 = new System.Windows.Forms.Label();
      this.btnGenerate = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.trackFolders)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackSize)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackFiles)).BeginInit();
      this.SuspendLayout();
      // 
      // trackFolders
      // 
      this.trackFolders.Location = new System.Drawing.Point(137, 38);
      this.trackFolders.Maximum = 20;
      this.trackFolders.Minimum = 1;
      this.trackFolders.Name = "trackFolders";
      this.trackFolders.Size = new System.Drawing.Size(269, 45);
      this.trackFolders.TabIndex = 0;
      this.trackFolders.Value = 10;
      this.trackFolders.ValueChanged += new System.EventHandler(this.trackFolders_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(118, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Number of MXF Folders";
      // 
      // txtFolders
      // 
      this.txtFolders.Location = new System.Drawing.Point(412, 40);
      this.txtFolders.Name = "txtFolders";
      this.txtFolders.Size = new System.Drawing.Size(75, 20);
      this.txtFolders.TabIndex = 2;
      this.txtFolders.Text = "10";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Folder";
      // 
      // textFolder
      // 
      this.textFolder.Location = new System.Drawing.Point(137, 12);
      this.textFolder.Name = "textFolder";
      this.textFolder.ReadOnly = true;
      this.textFolder.Size = new System.Drawing.Size(269, 20);
      this.textFolder.TabIndex = 4;
      this.textFolder.Text = "D:\\Test_Media\\Edit1\\Avid MediaFiles\\MXF";
      // 
      // btnFolder
      // 
      this.btnFolder.Location = new System.Drawing.Point(412, 11);
      this.btnFolder.Name = "btnFolder";
      this.btnFolder.Size = new System.Drawing.Size(75, 23);
      this.btnFolder.TabIndex = 5;
      this.btnFolder.Text = "Browse";
      this.btnFolder.UseVisualStyleBackColor = true;
      this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 140);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(54, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Total Size";
      // 
      // trackSize
      // 
      this.trackSize.Location = new System.Drawing.Point(137, 140);
      this.trackSize.Maximum = 20;
      this.trackSize.Minimum = 1;
      this.trackSize.Name = "trackSize";
      this.trackSize.Size = new System.Drawing.Size(269, 45);
      this.trackSize.TabIndex = 7;
      this.trackSize.Value = 1;
      this.trackSize.ValueChanged += new System.EventHandler(this.trackSize_ValueChanged);
      // 
      // txtSize
      // 
      this.txtSize.Location = new System.Drawing.Point(412, 140);
      this.txtSize.Name = "txtSize";
      this.txtSize.Size = new System.Drawing.Size(75, 20);
      this.txtSize.TabIndex = 8;
      this.txtSize.Text = "1";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(493, 143);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(21, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "TB";
      // 
      // txtFiles
      // 
      this.txtFiles.Location = new System.Drawing.Point(412, 89);
      this.txtFiles.Name = "txtFiles";
      this.txtFiles.Size = new System.Drawing.Size(75, 20);
      this.txtFiles.TabIndex = 12;
      this.txtFiles.Text = "1000";
      // 
      // trackFiles
      // 
      this.trackFiles.LargeChange = 1000;
      this.trackFiles.Location = new System.Drawing.Point(137, 89);
      this.trackFiles.Maximum = 10000;
      this.trackFiles.Minimum = 1000;
      this.trackFiles.Name = "trackFiles";
      this.trackFiles.Size = new System.Drawing.Size(269, 45);
      this.trackFiles.SmallChange = 500;
      this.trackFiles.TabIndex = 11;
      this.trackFiles.TickFrequency = 500;
      this.trackFiles.Value = 1000;
      this.trackFiles.ValueChanged += new System.EventHandler(this.trackFiles_ValueChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 89);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(80, 13);
      this.label6.TabIndex = 10;
      this.label6.Text = "Number of Files";
      // 
      // btnGenerate
      // 
      this.btnGenerate.Location = new System.Drawing.Point(412, 185);
      this.btnGenerate.Name = "btnGenerate";
      this.btnGenerate.Size = new System.Drawing.Size(75, 23);
      this.btnGenerate.TabIndex = 13;
      this.btnGenerate.Text = "Go";
      this.btnGenerate.UseVisualStyleBackColor = true;
      this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(739, 471);
      this.Controls.Add(this.btnGenerate);
      this.Controls.Add(this.txtFiles);
      this.Controls.Add(this.trackFiles);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtSize);
      this.Controls.Add(this.trackSize);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnFolder);
      this.Controls.Add(this.textFolder);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtFolders);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.trackFolders);
      this.Name = "Form1";
      this.Text = "MXFaker";
      ((System.ComponentModel.ISupportInitialize)(this.trackFolders)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackSize)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackFiles)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TrackBar trackFolders;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtFolders;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textFolder;
    private System.Windows.Forms.Button btnFolder;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TrackBar trackSize;
    private System.Windows.Forms.TextBox txtSize;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtFiles;
    private System.Windows.Forms.TrackBar trackFiles;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnGenerate;
  }
}

