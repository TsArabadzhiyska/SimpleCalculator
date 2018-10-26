namespace Calculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHronology = new System.Windows.Forms.Label();
            this.clearHronologyB = new System.Windows.Forms.Button();
            this.hronologyTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TrackLabelCalc = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MemoryRead = new System.Windows.Forms.Button();
            this.MemoryClear = new System.Windows.Forms.Button();
            this.MemoryAddition = new System.Windows.Forms.Button();
            this.MemorySave = new System.Windows.Forms.Button();
            this.MemorySubstraction = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button23 = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PositiveNegativeButton = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SubstractionButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.ClearOneDigit = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Button();
            this.ClearDisplayButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.PowButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.MultipicationButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.MaximizeButton);
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // MaximizeButton
            // 
            resources.ApplyResources(this.MaximizeButton, "MaximizeButton");
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // MinimizeButton
            // 
            resources.ApplyResources(this.MinimizeButton, "MinimizeButton");
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbHronology);
            this.panel2.Controls.Add(this.clearHronologyB);
            this.panel2.Controls.Add(this.hronologyTextBox);
            this.panel2.Controls.Add(this.label3);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lbHronology
            // 
            resources.ApplyResources(this.lbHronology, "lbHronology");
            this.lbHronology.Name = "lbHronology";
            // 
            // clearHronologyB
            // 
            resources.ApplyResources(this.clearHronologyB, "clearHronologyB");
            this.clearHronologyB.Name = "clearHronologyB";
            this.clearHronologyB.UseVisualStyleBackColor = true;
            this.clearHronologyB.Click += new System.EventHandler(this.clearHronologyB_Click);
            // 
            // hronologyTextBox
            // 
            this.hronologyTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hronologyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.hronologyTextBox, "hronologyTextBox");
            this.hronologyTextBox.Name = "hronologyTextBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TrackLabelCalc);
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Controls.Add(this.display);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // TrackLabelCalc
            // 
            resources.ApplyResources(this.TrackLabelCalc, "TrackLabelCalc");
            this.TrackLabelCalc.Name = "TrackLabelCalc";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.MemoryRead, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MemoryClear, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MemoryAddition, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.MemorySave, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.MemorySubstraction, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // MemoryRead
            // 
            this.MemoryRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.MemoryRead, "MemoryRead");
            this.MemoryRead.FlatAppearance.BorderSize = 0;
            this.MemoryRead.Name = "MemoryRead";
            this.MemoryRead.UseVisualStyleBackColor = false;
            this.MemoryRead.Click += new System.EventHandler(this.MemoryRead_Click);
            // 
            // MemoryClear
            // 
            this.MemoryClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.MemoryClear, "MemoryClear");
            this.MemoryClear.FlatAppearance.BorderSize = 0;
            this.MemoryClear.Name = "MemoryClear";
            this.MemoryClear.UseVisualStyleBackColor = false;
            this.MemoryClear.Click += new System.EventHandler(this.MemoryClear_Click);
            // 
            // MemoryAddition
            // 
            this.MemoryAddition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.MemoryAddition, "MemoryAddition");
            this.MemoryAddition.FlatAppearance.BorderSize = 0;
            this.MemoryAddition.Name = "MemoryAddition";
            this.MemoryAddition.UseVisualStyleBackColor = false;
            this.MemoryAddition.Click += new System.EventHandler(this.MemoryAddition_Click);
            // 
            // MemorySave
            // 
            this.MemorySave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.MemorySave, "MemorySave");
            this.MemorySave.FlatAppearance.BorderSize = 0;
            this.MemorySave.Name = "MemorySave";
            this.MemorySave.UseVisualStyleBackColor = false;
            this.MemorySave.Click += new System.EventHandler(this.MemorySave_Click);
            // 
            // MemorySubstraction
            // 
            this.MemorySubstraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.MemorySubstraction, "MemorySubstraction");
            this.MemorySubstraction.FlatAppearance.BorderSize = 0;
            this.MemorySubstraction.Name = "MemorySubstraction";
            this.MemorySubstraction.UseVisualStyleBackColor = false;
            this.MemorySubstraction.Click += new System.EventHandler(this.MemorySubstraction_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.button23, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.ZeroButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.PositiveNegativeButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Three, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.TwoButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.OneButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SubstractionButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.SixButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.FiveButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.FourButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.NineButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.EightButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SevenButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ClearOneDigit, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ClearAllButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Sqrt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Percent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClearDisplayButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.PowButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DivisionButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.MultipicationButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.AdditionButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.equalsButton, 3, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.button23, "button23");
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.Name = "button23";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.NumbersOnly_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.ZeroButton, "ZeroButton");
            this.ZeroButton.FlatAppearance.BorderSize = 0;
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.NumbersOnly_Click);
            // 
            // PositiveNegativeButton
            // 
            this.PositiveNegativeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.PositiveNegativeButton, "PositiveNegativeButton");
            this.PositiveNegativeButton.FlatAppearance.BorderSize = 0;
            this.PositiveNegativeButton.Name = "PositiveNegativeButton";
            this.PositiveNegativeButton.UseVisualStyleBackColor = false;
            this.PositiveNegativeButton.Click += new System.EventHandler(this.PositiveNegativeButton_Click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.Three, "Three");
            this.Three.FlatAppearance.BorderSize = 0;
            this.Three.Name = "Three";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.NumbersOnly_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.TwoButton, "TwoButton");
            this.TwoButton.FlatAppearance.BorderSize = 0;
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.NumbersOnly_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.OneButton, "OneButton");
            this.OneButton.FlatAppearance.BorderSize = 0;
            this.OneButton.Name = "OneButton";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.NumbersOnly_Click);
            // 
            // SubstractionButton
            // 
            this.SubstractionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.SubstractionButton, "SubstractionButton");
            this.SubstractionButton.FlatAppearance.BorderSize = 0;
            this.SubstractionButton.Name = "SubstractionButton";
            this.SubstractionButton.UseVisualStyleBackColor = false;
            this.SubstractionButton.Click += new System.EventHandler(this.MathOperations_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.SixButton, "SixButton");
            this.SixButton.FlatAppearance.BorderSize = 0;
            this.SixButton.Name = "SixButton";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.NumbersOnly_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.FiveButton, "FiveButton");
            this.FiveButton.FlatAppearance.BorderSize = 0;
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.NumbersOnly_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.FourButton, "FourButton");
            this.FourButton.FlatAppearance.BorderSize = 0;
            this.FourButton.Name = "FourButton";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.NumbersOnly_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.NineButton, "NineButton");
            this.NineButton.FlatAppearance.BorderSize = 0;
            this.NineButton.Name = "NineButton";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NumbersOnly_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.EightButton, "EightButton");
            this.EightButton.FlatAppearance.BorderSize = 0;
            this.EightButton.Name = "EightButton";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.NumbersOnly_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.SevenButton, "SevenButton");
            this.SevenButton.FlatAppearance.BorderSize = 0;
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.NumbersOnly_Click);
            // 
            // ClearOneDigit
            // 
            this.ClearOneDigit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.ClearOneDigit, "ClearOneDigit");
            this.ClearOneDigit.FlatAppearance.BorderSize = 0;
            this.ClearOneDigit.Name = "ClearOneDigit";
            this.ClearOneDigit.UseVisualStyleBackColor = false;
            this.ClearOneDigit.Click += new System.EventHandler(this.ClearOneDigit_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.ClearAllButton, "ClearAllButton");
            this.ClearAllButton.FlatAppearance.BorderSize = 0;
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.UseVisualStyleBackColor = false;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.Sqrt, "Sqrt");
            this.Sqrt.FlatAppearance.BorderSize = 0;
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = false;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Percent
            // 
            this.Percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.Percent, "Percent");
            this.Percent.FlatAppearance.BorderSize = 0;
            this.Percent.Name = "Percent";
            this.Percent.UseVisualStyleBackColor = false;
            this.Percent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // ClearDisplayButton
            // 
            this.ClearDisplayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.ClearDisplayButton, "ClearDisplayButton");
            this.ClearDisplayButton.FlatAppearance.BorderSize = 0;
            this.ClearDisplayButton.Name = "ClearDisplayButton";
            this.ClearDisplayButton.UseVisualStyleBackColor = false;
            this.ClearDisplayButton.Click += new System.EventHandler(this.ClearDisplayButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.button4, "button4");
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PowButton
            // 
            this.PowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.PowButton, "PowButton");
            this.PowButton.FlatAppearance.BorderSize = 0;
            this.PowButton.Name = "PowButton";
            this.PowButton.UseVisualStyleBackColor = false;
            this.PowButton.Click += new System.EventHandler(this.PowButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.DivisionButton, "DivisionButton");
            this.DivisionButton.FlatAppearance.BorderSize = 0;
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.UseVisualStyleBackColor = false;
            this.DivisionButton.Click += new System.EventHandler(this.MathOperations_Click);
            // 
            // MultipicationButton
            // 
            this.MultipicationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.MultipicationButton, "MultipicationButton");
            this.MultipicationButton.FlatAppearance.BorderSize = 0;
            this.MultipicationButton.Name = "MultipicationButton";
            this.MultipicationButton.UseVisualStyleBackColor = false;
            this.MultipicationButton.Click += new System.EventHandler(this.MathOperations_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.AdditionButton, "AdditionButton");
            this.AdditionButton.FlatAppearance.BorderSize = 0;
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.UseVisualStyleBackColor = false;
            this.AdditionButton.Click += new System.EventHandler(this.MathOperations_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.equalsButton, "equalsButton");
            this.equalsButton.FlatAppearance.BorderSize = 0;
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.UseVisualStyleBackColor = false;
            this.equalsButton.Click += new System.EventHandler(this.Equals_Click);
            // 
            // display
            // 
            resources.ApplyResources(this.display, "display");
            this.display.Name = "display";
            // 
            // CalculatorForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculatorForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button PositiveNegativeButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SubstractionButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button MultipicationButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button ClearOneDigit;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button PowButton;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.Button ClearDisplayButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button MemoryRead;
        private System.Windows.Forms.Button MemorySave;
        private System.Windows.Forms.Button MemoryClear;
        private System.Windows.Forms.Button MemorySubstraction;
        private System.Windows.Forms.Button MemoryAddition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TrackLabelCalc;
        private System.Windows.Forms.RichTextBox hronologyTextBox;
        private System.Windows.Forms.Button clearHronologyB;
        private System.Windows.Forms.Label lbHronology;
    }
}

