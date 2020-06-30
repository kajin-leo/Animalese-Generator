namespace Animalese_Generator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.vowelsTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.pitchTrackBar = new System.Windows.Forms.TrackBar();
            this.pitchValueIndicator = new System.Windows.Forms.Label();
            this.toneLabel = new System.Windows.Forms.Label();
            this.toneGroupBox = new System.Windows.Forms.GroupBox();
            this.manRadioButton = new System.Windows.Forms.RadioButton();
            this.girlRadioButton = new System.Windows.Forms.RadioButton();
            this.boyRadioButton = new System.Windows.Forms.RadioButton();
            this.pitchGroupBox = new System.Windows.Forms.GroupBox();
            this.vowelGroupBox = new System.Windows.Forms.GroupBox();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pitchTrackBar)).BeginInit();
            this.toneGroupBox.SuspendLayout();
            this.pitchGroupBox.SuspendLayout();
            this.vowelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // vowelsTextBox
            // 
            resources.ApplyResources(this.vowelsTextBox, "vowelsTextBox");
            this.vowelsTextBox.Name = "vowelsTextBox";
            // 
            // instructionLabel
            // 
            resources.ApplyResources(this.instructionLabel, "instructionLabel");
            this.instructionLabel.Name = "instructionLabel";
            // 
            // pitchTrackBar
            // 
            resources.ApplyResources(this.pitchTrackBar, "pitchTrackBar");
            this.pitchTrackBar.LargeChange = 2;
            this.pitchTrackBar.Maximum = 36;
            this.pitchTrackBar.Minimum = 28;
            this.pitchTrackBar.Name = "pitchTrackBar";
            this.pitchTrackBar.SmallChange = 2;
            this.pitchTrackBar.Value = 28;
            this.pitchTrackBar.Scroll += new System.EventHandler(this.pitchTrackBar_Scroll);
            // 
            // pitchValueIndicator
            // 
            resources.ApplyResources(this.pitchValueIndicator, "pitchValueIndicator");
            this.pitchValueIndicator.Name = "pitchValueIndicator";
            // 
            // toneLabel
            // 
            resources.ApplyResources(this.toneLabel, "toneLabel");
            this.toneLabel.Name = "toneLabel";
            // 
            // toneGroupBox
            // 
            resources.ApplyResources(this.toneGroupBox, "toneGroupBox");
            this.toneGroupBox.Controls.Add(this.manRadioButton);
            this.toneGroupBox.Controls.Add(this.girlRadioButton);
            this.toneGroupBox.Controls.Add(this.boyRadioButton);
            this.toneGroupBox.Name = "toneGroupBox";
            this.toneGroupBox.TabStop = false;
            // 
            // manRadioButton
            // 
            resources.ApplyResources(this.manRadioButton, "manRadioButton");
            this.manRadioButton.Name = "manRadioButton";
            this.manRadioButton.TabStop = true;
            this.manRadioButton.UseVisualStyleBackColor = true;
            this.manRadioButton.CheckedChanged += new System.EventHandler(this.manRadioButton_CheckedChanged);
            // 
            // girlRadioButton
            // 
            resources.ApplyResources(this.girlRadioButton, "girlRadioButton");
            this.girlRadioButton.Name = "girlRadioButton";
            this.girlRadioButton.TabStop = true;
            this.girlRadioButton.UseVisualStyleBackColor = true;
            this.girlRadioButton.CheckedChanged += new System.EventHandler(this.girlRadioButton_CheckedChanged);
            // 
            // boyRadioButton
            // 
            resources.ApplyResources(this.boyRadioButton, "boyRadioButton");
            this.boyRadioButton.Name = "boyRadioButton";
            this.boyRadioButton.TabStop = true;
            this.boyRadioButton.UseVisualStyleBackColor = true;
            this.boyRadioButton.CheckedChanged += new System.EventHandler(this.boyRadioButton_CheckedChanged);
            // 
            // pitchGroupBox
            // 
            resources.ApplyResources(this.pitchGroupBox, "pitchGroupBox");
            this.pitchGroupBox.Controls.Add(this.pitchValueIndicator);
            this.pitchGroupBox.Controls.Add(this.pitchTrackBar);
            this.pitchGroupBox.Name = "pitchGroupBox";
            this.pitchGroupBox.TabStop = false;
            // 
            // vowelGroupBox
            // 
            resources.ApplyResources(this.vowelGroupBox, "vowelGroupBox");
            this.vowelGroupBox.Controls.Add(this.vowelsTextBox);
            this.vowelGroupBox.Controls.Add(this.instructionLabel);
            this.vowelGroupBox.Name = "vowelGroupBox";
            this.vowelGroupBox.TabStop = false;
            // 
            // generateButton
            // 
            resources.ApplyResources(this.generateButton, "generateButton");
            this.generateButton.Name = "generateButton";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.vowelGroupBox);
            this.Controls.Add(this.pitchGroupBox);
            this.Controls.Add(this.toneGroupBox);
            this.Controls.Add(this.toneLabel);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pitchTrackBar)).EndInit();
            this.toneGroupBox.ResumeLayout(false);
            this.toneGroupBox.PerformLayout();
            this.pitchGroupBox.ResumeLayout(false);
            this.pitchGroupBox.PerformLayout();
            this.vowelGroupBox.ResumeLayout(false);
            this.vowelGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vowelsTextBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TrackBar pitchTrackBar;
        private System.Windows.Forms.Label pitchValueIndicator;
        private System.Windows.Forms.Label toneLabel;
        private System.Windows.Forms.GroupBox toneGroupBox;
        private System.Windows.Forms.RadioButton manRadioButton;
        private System.Windows.Forms.RadioButton girlRadioButton;
        private System.Windows.Forms.RadioButton boyRadioButton;
        private System.Windows.Forms.GroupBox pitchGroupBox;
        private System.Windows.Forms.GroupBox vowelGroupBox;
        private System.Windows.Forms.Button generateButton;
    }
}

