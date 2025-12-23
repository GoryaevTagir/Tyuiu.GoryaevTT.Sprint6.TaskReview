
namespace Tyuiu.GoryaevTT.Sprint6.TaskReview.App
{
    partial class FormName
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
            panelUpper_GTT = new Panel();
            groupTaskButtons_GTT = new GroupBox();
            textColumns_GTT = new TextBox();
            textRows_GTT = new TextBox();
            buttonBuildMatrix_GTT = new Button();
            textTask_GTT = new TextBox();
            panelLeft_GTT = new Panel();
            groupStart_GTT = new GroupBox();
            buttonGetResult_GTT = new Button();
            textResult_GTT = new TextBox();
            textDataInput_GTT = new TextBox();
            textInfo_GTT = new TextBox();
            splitterPanels_GTT = new Splitter();
            panelFIll_GTT = new Panel();
            groupMatrix_GTT = new GroupBox();
            dataGridViewMatrix_GTT = new DataGridView();
            panelUpper_GTT.SuspendLayout();
            groupTaskButtons_GTT.SuspendLayout();
            panelLeft_GTT.SuspendLayout();
            groupStart_GTT.SuspendLayout();
            panelFIll_GTT.SuspendLayout();
            groupMatrix_GTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_GTT).BeginInit();
            SuspendLayout();
            // 
            // panelUpper_GTT
            // 
            panelUpper_GTT.Controls.Add(groupTaskButtons_GTT);
            panelUpper_GTT.Dock = DockStyle.Top;
            panelUpper_GTT.Location = new Point(0, 0);
            panelUpper_GTT.Name = "panelUpper_GTT";
            panelUpper_GTT.Size = new Size(800, 86);
            panelUpper_GTT.TabIndex = 0;
            // 
            // groupTaskButtons_GTT
            // 
            groupTaskButtons_GTT.Controls.Add(textColumns_GTT);
            groupTaskButtons_GTT.Controls.Add(textRows_GTT);
            groupTaskButtons_GTT.Controls.Add(buttonBuildMatrix_GTT);
            groupTaskButtons_GTT.Controls.Add(textTask_GTT);
            groupTaskButtons_GTT.Dock = DockStyle.Fill;
            groupTaskButtons_GTT.Location = new Point(0, 0);
            groupTaskButtons_GTT.Name = "groupTaskButtons_GTT";
            groupTaskButtons_GTT.Size = new Size(800, 86);
            groupTaskButtons_GTT.TabIndex = 0;
            groupTaskButtons_GTT.TabStop = false;
            groupTaskButtons_GTT.Text = "Задание:";
            // 
            // textColumns_GTT
            // 
            textColumns_GTT.Location = new Point(552, 34);
            textColumns_GTT.Name = "textColumns_GTT";
            textColumns_GTT.Size = new Size(70, 35);
            textColumns_GTT.TabIndex = 2;
            // 
            // textRows_GTT
            // 
            textRows_GTT.Location = new Point(459, 34);
            textRows_GTT.Name = "textRows_GTT";
            textRows_GTT.Size = new Size(70, 35);
            textRows_GTT.TabIndex = 2;
            // 
            // buttonBuildMatrix_GTT
            // 
            buttonBuildMatrix_GTT.Location = new Point(638, 18);
            buttonBuildMatrix_GTT.Name = "buttonBuildMatrix_GTT";
            buttonBuildMatrix_GTT.Size = new Size(150, 68);
            buttonBuildMatrix_GTT.TabIndex = 1;
            buttonBuildMatrix_GTT.Text = "построить матрицу:";
            buttonBuildMatrix_GTT.UseVisualStyleBackColor = true;
            buttonBuildMatrix_GTT.Click += buttonLoad_GTT;
            // 
            // textTask_GTT
            // 
            textTask_GTT.BorderStyle = BorderStyle.None;
            textTask_GTT.Location = new Point(28, 28);
            textTask_GTT.Multiline = true;
            textTask_GTT.Name = "textTask_GTT";
            textTask_GTT.ReadOnly = true;
            textTask_GTT.Size = new Size(394, 52);
            textTask_GTT.TabIndex = 0;
            textTask_GTT.Text = "УСЛОВИЕ 27";
            // 
            // panelLeft_GTT
            // 
            panelLeft_GTT.Controls.Add(groupStart_GTT);
            panelLeft_GTT.Dock = DockStyle.Left;
            panelLeft_GTT.Location = new Point(0, 86);
            panelLeft_GTT.Name = "panelLeft_GTT";
            panelLeft_GTT.Size = new Size(393, 364);
            panelLeft_GTT.TabIndex = 1;
            // 
            // groupStart_GTT
            // 
            groupStart_GTT.Controls.Add(buttonGetResult_GTT);
            groupStart_GTT.Controls.Add(textResult_GTT);
            groupStart_GTT.Controls.Add(textDataInput_GTT);
            groupStart_GTT.Controls.Add(textInfo_GTT);
            groupStart_GTT.Dock = DockStyle.Fill;
            groupStart_GTT.Location = new Point(0, 0);
            groupStart_GTT.Name = "groupStart_GTT";
            groupStart_GTT.Size = new Size(393, 364);
            groupStart_GTT.TabIndex = 1;
            groupStart_GTT.TabStop = false;
            groupStart_GTT.Text = "Исходные данные:";
            // 
            // buttonGetResult_GTT
            // 
            buttonGetResult_GTT.Location = new Point(12, 260);
            buttonGetResult_GTT.Name = "buttonGetResult_GTT";
            buttonGetResult_GTT.Size = new Size(234, 34);
            buttonGetResult_GTT.TabIndex = 3;
            buttonGetResult_GTT.Text = "Получить результат:";
            buttonGetResult_GTT.UseVisualStyleBackColor = true;
            buttonGetResult_GTT.Click += buttonDone_GTT;
            // 
            // textResult_GTT
            // 
            textResult_GTT.BorderStyle = BorderStyle.FixedSingle;
            textResult_GTT.Location = new Point(12, 317);
            textResult_GTT.Name = "textResult_GTT";
            textResult_GTT.ReadOnly = true;
            textResult_GTT.Size = new Size(209, 35);
            textResult_GTT.TabIndex = 2;
            // 
            // textDataInput_GTT
            // 
            textDataInput_GTT.Location = new Point(12, 198);
            textDataInput_GTT.Name = "textDataInput_GTT";
            textDataInput_GTT.Size = new Size(375, 35);
            textDataInput_GTT.TabIndex = 2;
            // 
            // textInfo_GTT
            // 
            textInfo_GTT.BorderStyle = BorderStyle.None;
            textInfo_GTT.Location = new Point(12, 34);
            textInfo_GTT.Multiline = true;
            textInfo_GTT.Name = "textInfo_GTT";
            textInfo_GTT.ReadOnly = true;
            textInfo_GTT.Size = new Size(375, 158);
            textInfo_GTT.TabIndex = 2;
            textInfo_GTT.Text = "Введите значения через запятые без пробела. От какого числа рандомизация значений, до какого числа,строку счета,от какого столбика, до какого столбика";
            // 
            // splitterPanels_GTT
            // 
            splitterPanels_GTT.Location = new Point(393, 86);
            splitterPanels_GTT.Name = "splitterPanels_GTT";
            splitterPanels_GTT.Size = new Size(12, 364);
            splitterPanels_GTT.TabIndex = 2;
            splitterPanels_GTT.TabStop = false;
            // 
            // panelFIll_GTT
            // 
            panelFIll_GTT.Controls.Add(groupMatrix_GTT);
            panelFIll_GTT.Dock = DockStyle.Fill;
            panelFIll_GTT.Location = new Point(405, 86);
            panelFIll_GTT.Name = "panelFIll_GTT";
            panelFIll_GTT.Size = new Size(395, 364);
            panelFIll_GTT.TabIndex = 3;
            // 
            // groupMatrix_GTT
            // 
            groupMatrix_GTT.Controls.Add(dataGridViewMatrix_GTT);
            groupMatrix_GTT.Dock = DockStyle.Fill;
            groupMatrix_GTT.Location = new Point(0, 0);
            groupMatrix_GTT.Name = "groupMatrix_GTT";
            groupMatrix_GTT.Size = new Size(395, 364);
            groupMatrix_GTT.TabIndex = 0;
            groupMatrix_GTT.TabStop = false;
            groupMatrix_GTT.Text = "Матрица:";
            // 
            // dataGridViewMatrix_GTT
            // 
            dataGridViewMatrix_GTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_GTT.ColumnHeadersVisible = false;
            dataGridViewMatrix_GTT.Dock = DockStyle.Fill;
            dataGridViewMatrix_GTT.Location = new Point(3, 31);
            dataGridViewMatrix_GTT.Name = "dataGridViewMatrix_GTT";
            dataGridViewMatrix_GTT.RowHeadersVisible = false;
            dataGridViewMatrix_GTT.RowHeadersWidth = 62;
            dataGridViewMatrix_GTT.Size = new Size(389, 330);
            dataGridViewMatrix_GTT.TabIndex = 0;
            // 
            // FormName
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFIll_GTT);
            Controls.Add(splitterPanels_GTT);
            Controls.Add(panelLeft_GTT);
            Controls.Add(panelUpper_GTT);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormName";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт ревью|Вариант | Горяев Тагир";
            panelUpper_GTT.ResumeLayout(false);
            groupTaskButtons_GTT.ResumeLayout(false);
            groupTaskButtons_GTT.PerformLayout();
            panelLeft_GTT.ResumeLayout(false);
            groupStart_GTT.ResumeLayout(false);
            groupStart_GTT.PerformLayout();
            panelFIll_GTT.ResumeLayout(false);
            groupMatrix_GTT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_GTT).EndInit();
            ResumeLayout(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelUpper_GTT;
        private Panel panelLeft_GTT;
        private Splitter splitterPanels_GTT;
        private Panel panelFIll_GTT;
        private GroupBox groupTaskButtons_GTT;
        private TextBox textTask_GTT;
        private GroupBox groupStart_GTT;
        private GroupBox groupMatrix_GTT;
        private DataGridView dataGridViewMatrix_GTT;
        private TextBox textInfo_GTT;
        private TextBox textDataInput_GTT;
        private Button buttonBuildMatrix_GTT;
        private TextBox textResult_GTT;
        private TextBox textColumns_GTT;
        private TextBox textRows_GTT;
        private Button buttonGetResult_GTT;
    }
}
