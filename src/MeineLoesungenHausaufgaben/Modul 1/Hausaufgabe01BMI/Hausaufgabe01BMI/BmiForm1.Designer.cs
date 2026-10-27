namespace Hausaufgabe01BMI
{
  partial class BmiForm
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
      LblWeight = new Label();
      TxtWeight = new TextBox();
      TxtHeight = new TextBox();
      LblHeight = new Label();
      CmdBmiCalculate = new Button();
      LblResult = new Label();
      errorProvider1 = new ErrorProvider(components);
      ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
      SuspendLayout();
      // 
      // LblWeight
      // 
      LblWeight.AutoSize = true;
      LblWeight.Location = new Point(42, 39);
      LblWeight.Name = "LblWeight";
      LblWeight.Size = new Size(74, 15);
      LblWeight.TabIndex = 0;
      LblWeight.Text = "Gewicht (kg)";
      // 
      // TxtWeight
      // 
      TxtWeight.Location = new Point(149, 31);
      TxtWeight.Name = "TxtWeight";
      TxtWeight.Size = new Size(100, 23);
      TxtWeight.TabIndex = 1;
      // 
      // TxtHeight
      // 
      TxtHeight.Location = new Point(149, 69);
      TxtHeight.Name = "TxtHeight";
      TxtHeight.Size = new Size(100, 23);
      TxtHeight.TabIndex = 2;
      // 
      // LblHeight
      // 
      LblHeight.AutoSize = true;
      LblHeight.Location = new Point(42, 77);
      LblHeight.Name = "LblHeight";
      LblHeight.Size = new Size(64, 15);
      LblHeight.TabIndex = 3;
      LblHeight.Text = "Grösse (m)";
      // 
      // CmdBmiCalculate
      // 
      CmdBmiCalculate.Location = new Point(149, 140);
      CmdBmiCalculate.Name = "CmdBmiCalculate";
      CmdBmiCalculate.Size = new Size(100, 25);
      CmdBmiCalculate.TabIndex = 4;
      CmdBmiCalculate.Text = "BMI berechnen";
      CmdBmiCalculate.UseVisualStyleBackColor = true;
      CmdBmiCalculate.Click += CmdBmiCalculate_Click;
      // 
      // LblResult
      // 
      LblResult.AutoSize = true;
      LblResult.Location = new Point(42, 120);
      LblResult.Name = "LblResult";
      LblResult.Size = new Size(52, 15);
      LblResult.TabIndex = 5;
      LblResult.Text = "Ergebnis";
      // 
      // errorProvider1
      // 
      errorProvider1.ContainerControl = this;
      // 
      // BmiForm
      // 
      AcceptButton = CmdBmiCalculate;
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(309, 195);
      Controls.Add(LblResult);
      Controls.Add(CmdBmiCalculate);
      Controls.Add(LblHeight);
      Controls.Add(TxtHeight);
      Controls.Add(TxtWeight);
      Controls.Add(LblWeight);
      Name = "BmiForm";
      Text = "BMI-Rechner";
      ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label LblWeight;
    private TextBox TxtWeight;
    private TextBox TxtHeight;
    private Label LblHeight;
    private Button CmdBmiCalculate;
    private Label LblResult;
    private ErrorProvider errorProvider1;
  }
}
