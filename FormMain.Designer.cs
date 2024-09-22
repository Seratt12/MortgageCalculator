namespace Mortgage_calculator
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            checkBox1 = new CheckBox();
            InitialPaymentInput = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label8 = new Label();
            ProcentInput = new TextBox();
            PeriodInputBox = new TextBox();
            FullPriceInput = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            CalculateBtn = new Button();
            Result = new Label();
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            resources.ApplyResources(checkBox1, "checkBox1");
            checkBox1.Name = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // InitialPaymentInput
            // 
            resources.ApplyResources(InitialPaymentInput, "InitialPaymentInput");
            InitialPaymentInput.Name = "InitialPaymentInput";
            InitialPaymentInput.KeyPress += Int_KeyPress;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            label4.UseMnemonic = false;
            label4.Click += label4_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            label5.Click += label5_Click;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // ProcentInput
            // 
            resources.ApplyResources(ProcentInput, "ProcentInput");
            ProcentInput.Name = "ProcentInput";
            ProcentInput.KeyPress += Float_KeyPress;
            // 
            // PeriodInputBox
            // 
            resources.ApplyResources(PeriodInputBox, "PeriodInputBox");
            PeriodInputBox.Name = "PeriodInputBox";
            // 
            // FullPriceInput
            // 
            resources.ApplyResources(FullPriceInput, "FullPriceInput");
            FullPriceInput.Name = "FullPriceInput";
            FullPriceInput.KeyPress += Int_KeyPress;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            resources.ApplyResources(radioButton2, "radioButton2");
            radioButton2.Name = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            resources.ApplyResources(radioButton1, "radioButton1");
            radioButton1.Checked = true;
            radioButton1.Name = "radioButton1";
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // CalculateBtn
            // 
            resources.ApplyResources(CalculateBtn, "CalculateBtn");
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // Result
            // 
            resources.ApplyResources(Result, "Result");
            Result.Name = "Result";
            // 
            // BottomToolStripPanel
            // 
            resources.ApplyResources(BottomToolStripPanel, "BottomToolStripPanel");
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            // 
            // TopToolStripPanel
            // 
            resources.ApplyResources(TopToolStripPanel, "TopToolStripPanel");
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            TopToolStripPanel.Click += toolStripContainer1_TopToolStripPanel_Click;
            // 
            // RightToolStripPanel
            // 
            resources.ApplyResources(RightToolStripPanel, "RightToolStripPanel");
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            // 
            // LeftToolStripPanel
            // 
            resources.ApplyResources(LeftToolStripPanel, "LeftToolStripPanel");
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            // 
            // ContentPanel
            // 
            resources.ApplyResources(ContentPanel, "ContentPanel");
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(Result);
            Controls.Add(CalculateBtn);
            Controls.Add(checkBox1);
            Controls.Add(InitialPaymentInput);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(PeriodInputBox);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(FullPriceInput);
            Controls.Add(label5);
            Controls.Add(ProcentInput);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            ShowIcon = false;
            Load += label3_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button CalculateBtn;
        private Label Result;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private TextBox FullPriceInput;
        private TextBox PeriodInputBox;
        private TextBox ProcentInput;
        private Label label8;
        private TextBox InitialPaymentInput;
    }
}