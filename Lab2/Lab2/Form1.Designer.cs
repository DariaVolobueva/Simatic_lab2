namespace Lab2
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_CPU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ScanMode = new System.Windows.Forms.Label();
            this.checkBox_Input1 = new System.Windows.Forms.CheckBox();
            this.checkBox_Input2 = new System.Windows.Forms.CheckBox();
            this.checkBox_Input3 = new System.Windows.Forms.CheckBox();
            this.checkBox_Output = new System.Windows.Forms.CheckBox();
            this.comboBox_CPUState = new System.Windows.Forms.ComboBox();
            this.comboBox_ScanMode = new System.Windows.Forms.ComboBox();
            this.timer_ReadOutput = new System.Windows.Forms.Timer(this.components);
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.picture4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU_state";
            // 
            // label_CPU
            // 
            this.label_CPU.AutoSize = true;
            this.label_CPU.Location = new System.Drawing.Point(104, 60);
            this.label_CPU.Name = "label_CPU";
            this.label_CPU.Size = new System.Drawing.Size(50, 20);
            this.label_CPU.TabIndex = 2;
            this.label_CPU.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Scan Mode";
            // 
            // label_ScanMode
            // 
            this.label_ScanMode.AutoSize = true;
            this.label_ScanMode.Location = new System.Drawing.Point(104, 92);
            this.label_ScanMode.Name = "label_ScanMode";
            this.label_ScanMode.Size = new System.Drawing.Size(50, 20);
            this.label_ScanMode.TabIndex = 4;
            this.label_ScanMode.Text = "label3";
            // 
            // checkBox_Input1
            // 
            this.checkBox_Input1.AutoSize = true;
            this.checkBox_Input1.Location = new System.Drawing.Point(11, 364);
            this.checkBox_Input1.Name = "checkBox_Input1";
            this.checkBox_Input1.Size = new System.Drawing.Size(54, 24);
            this.checkBox_Input1.TabIndex = 5;
            this.checkBox_Input1.Text = "I0.0";
            this.checkBox_Input1.UseVisualStyleBackColor = true;
            this.checkBox_Input1.CheckedChanged += new System.EventHandler(this.checkBox_Input1_CheckedChanged);
            // 
            // checkBox_Input2
            // 
            this.checkBox_Input2.AutoSize = true;
            this.checkBox_Input2.Location = new System.Drawing.Point(11, 395);
            this.checkBox_Input2.Name = "checkBox_Input2";
            this.checkBox_Input2.Size = new System.Drawing.Size(54, 24);
            this.checkBox_Input2.TabIndex = 6;
            this.checkBox_Input2.Text = "I0.1";
            this.checkBox_Input2.UseVisualStyleBackColor = true;
            this.checkBox_Input2.CheckedChanged += new System.EventHandler(this.checkBox_Input2_CheckedChanged);
            // 
            // checkBox_Input3
            // 
            this.checkBox_Input3.AutoSize = true;
            this.checkBox_Input3.Location = new System.Drawing.Point(11, 424);
            this.checkBox_Input3.Name = "checkBox_Input3";
            this.checkBox_Input3.Size = new System.Drawing.Size(54, 24);
            this.checkBox_Input3.TabIndex = 7;
            this.checkBox_Input3.Text = "I0.2";
            this.checkBox_Input3.UseVisualStyleBackColor = true;
            this.checkBox_Input3.CheckedChanged += new System.EventHandler(this.checkBox_Input3_CheckedChanged);
            // 
            // checkBox_Output
            // 
            this.checkBox_Output.AutoSize = true;
            this.checkBox_Output.Location = new System.Drawing.Point(93, 364);
            this.checkBox_Output.Name = "checkBox_Output";
            this.checkBox_Output.Size = new System.Drawing.Size(61, 24);
            this.checkBox_Output.TabIndex = 8;
            this.checkBox_Output.Text = "Q0.0";
            this.checkBox_Output.UseVisualStyleBackColor = true;
            this.checkBox_Output.CheckedChanged += new System.EventHandler(this.checkBox_Output_CheckedChanged);
            // 
            // comboBox_CPUState
            // 
            this.comboBox_CPUState.FormattingEnabled = true;
            this.comboBox_CPUState.Items.AddRange(new object[] {
            "RUN_P",
            "RUN",
            "STOP"});
            this.comboBox_CPUState.Location = new System.Drawing.Point(11, 123);
            this.comboBox_CPUState.Name = "comboBox_CPUState";
            this.comboBox_CPUState.Size = new System.Drawing.Size(151, 28);
            this.comboBox_CPUState.TabIndex = 9;
            this.comboBox_CPUState.SelectedIndexChanged += new System.EventHandler(this.comboBox_CPUState_SelectedIndexChanged);
            // 
            // comboBox_ScanMode
            // 
            this.comboBox_ScanMode.FormattingEnabled = true;
            this.comboBox_ScanMode.Items.AddRange(new object[] {
            "Single Scan",
            "Continious Scan"});
            this.comboBox_ScanMode.Location = new System.Drawing.Point(11, 165);
            this.comboBox_ScanMode.Name = "comboBox_ScanMode";
            this.comboBox_ScanMode.Size = new System.Drawing.Size(151, 28);
            this.comboBox_ScanMode.TabIndex = 10;
            this.comboBox_ScanMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_ScanMode_SelectedIndexChanged);
            // 
            // timer_ReadOutput
            // 
            this.timer_ReadOutput.Enabled = true;
            this.timer_ReadOutput.Tick += new System.EventHandler(this.timer_ReadOutput_Tick);
            // 
            // picture1
            // 
            this.picture1.Location = new System.Drawing.Point(245, 69);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(48, 51);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture1.TabIndex = 11;
            this.picture1.TabStop = false;
            // 
            // picture2
            // 
            this.picture2.Location = new System.Drawing.Point(245, 227);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(48, 51);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture2.TabIndex = 12;
            this.picture2.TabStop = false;
            // 
            // picture3
            // 
            this.picture3.Location = new System.Drawing.Point(385, 69);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(48, 51);
            this.picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture3.TabIndex = 13;
            this.picture3.TabStop = false;
            // 
            // picture4
            // 
            this.picture4.Location = new System.Drawing.Point(608, 69);
            this.picture4.Name = "picture4";
            this.picture4.Size = new System.Drawing.Size(48, 51);
            this.picture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture4.TabIndex = 14;
            this.picture4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Тиск до фільтру";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Включити продування";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Тиск після фільтра";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Продування фільтру";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picture4);
            this.Controls.Add(this.picture3);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.comboBox_ScanMode);
            this.Controls.Add(this.comboBox_CPUState);
            this.Controls.Add(this.checkBox_Output);
            this.Controls.Add(this.checkBox_Input3);
            this.Controls.Add(this.checkBox_Input2);
            this.Controls.Add(this.checkBox_Input1);
            this.Controls.Add(this.label_ScanMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_CPU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label_CPU;
        private Label label2;
        private Label label_ScanMode;
        private CheckBox checkBox_Input1;
        private CheckBox checkBox_Input2;
        private CheckBox checkBox_Input3;
        private CheckBox checkBox_Output;
        private ComboBox comboBox_CPUState;
        private ComboBox comboBox_ScanMode;
        private System.Windows.Forms.Timer timer_ReadOutput;
        private PictureBox picture1;
        private PictureBox picture2;
        private PictureBox picture3;
        private PictureBox picture4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}