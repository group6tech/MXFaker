using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MXFaker
{
  public partial class Form1 : Form
  {

    private const long MinFileSizeMegaBytes = 100; // 100MB
    private const long MaxFileSizeMegaBytes = 10*1024; // 10GB

    public Form1()
    {
      InitializeComponent();
    }

    private void trackFolders_ValueChanged(object sender, EventArgs e)
    {
      txtFolders.Text = trackFolders.Value.ToString();
    }

    private void btnFolder_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrWhiteSpace(textFolder.Text))
      {
        folderBrowserDialog.SelectedPath = textFolder.Text;
      }

      if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        textFolder.Text = folderBrowserDialog.SelectedPath;
      }
    }

    private void trackSize_ValueChanged(object sender, EventArgs e)
    {
      txtSize.Text = trackSize.Value.ToString();
    }

    private void trackFiles_ValueChanged(object sender, EventArgs e)
    {
      txtFiles.Text = trackFiles.Value.ToString();
    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {

      Enabled = false;

      if (string.IsNullOrWhiteSpace(textFolder.Text))
      {
        MessageBox.Show("Pick a folder first");
        return;
      }

      var numberOfFiles = int.Parse(txtFiles.Text);
      var sumWanted = long.Parse(txtSize.Text)*1024*1024;
      var sizes = new long[numberOfFiles];

      randomNumbers(ref sizes, 0, MinFileSizeMegaBytes, MaxFileSizeMegaBytes, sumWanted);

      foreach (var number in sizes)
      {
        writeFile(number);
      }

      Enabled = true;
    }

    private void randomNumbers(ref long[] numbers, int index, long lowerBound, long upperBound, long sum)
    {
      var next = index + 1;
      if (next == numbers.Length)
      {
        numbers[index] = sum;
      }
      else
      {
        var rest = numbers.Length - next;
        var restLowerBound = lowerBound*rest;
        var restUpperBound = upperBound*rest;

        var myLowerBound = Math.Max(lowerBound, sum - restUpperBound);
        var myUpperBound = Math.Min(upperBound, sum - restLowerBound);

        numbers[index] = random(myLowerBound, myUpperBound);
        randomNumbers(ref numbers, next, myLowerBound, myUpperBound, sum - numbers[index]);
      }
    }

    private long random(long lowerBound, long upperBound)
    {
      var r = new Random();
      var x = r.NextDouble();
      var y = lowerBound + x * (upperBound - lowerBound);

      return (long) y;
    }

    private void writeFile(long sizeInMegaBytes)
    {
      var fileSize = sizeInMegaBytes*1024*1024;
      var r = new Random();
      var mxfDir = r.Next(1, int.Parse(txtFolders.Text));

      var dirPath = $"{textFolder.Text}\\{mxfDir}";
      if (!System.IO.Directory.Exists(dirPath))
      {
        System.IO.Directory.CreateDirectory(dirPath);
      }

      var filePath = $"{dirPath}\\{Guid.NewGuid()}.mxf";
      var args = $"file createnew \"{filePath}\" {fileSize}";
      runCmd("fsutil", args);
    }

    private void runCmd(string cmd, string args)
    {
      Console.WriteLine(args);

      var process = new System.Diagnostics.Process
      {
        StartInfo =
        {
          FileName = cmd,
          Arguments = args,
          UseShellExecute = false,
          CreateNoWindow = true,
          RedirectStandardOutput = true,
          RedirectStandardError = true
        }
      };

      process.Start();

      var output = process.StandardOutput.ReadToEnd();
      Console.WriteLine(output);

      var error = process.StandardError.ReadToEnd();
      Console.WriteLine(error);

      process.WaitForExit();
    }
  }
}
