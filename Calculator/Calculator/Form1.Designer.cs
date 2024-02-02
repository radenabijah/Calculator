namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtboxOutput = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btnDel = new Button();
            btn9 = new Button();
            btnNeg = new Button();
            btnTimes = new Button();
            btn6 = new Button();
            btnDivide = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnMinus = new Button();
            btn3 = new Button();
            btnEquals = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnPlus = new Button();
            btnPoint = new Button();
            btn0 = new Button();
            btnClear = new Button();
            labelCurrentOperation = new Label();
            SuspendLayout();
            // 
            // txtboxOutput
            // 
            txtboxOutput.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtboxOutput.Location = new Point(37, 63);
            txtboxOutput.Multiline = true;
            txtboxOutput.Name = "txtboxOutput";
            txtboxOutput.Size = new Size(343, 47);
            txtboxOutput.TabIndex = 0;
            txtboxOutput.Text = "0";
            txtboxOutput.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(37, 125);
            btn7.Name = "btn7";
            btn7.Size = new Size(58, 52);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button_click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(101, 125);
            btn8.Name = "btn8";
            btn8.Size = new Size(58, 52);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button_click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.Location = new Point(322, 125);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(58, 52);
            btnDel.TabIndex = 3;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(165, 125);
            btn9.Name = "btn9";
            btn9.Size = new Size(58, 52);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button_click;
            // 
            // btnNeg
            // 
            btnNeg.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNeg.Location = new Point(258, 125);
            btnNeg.Name = "btnNeg";
            btnNeg.Size = new Size(58, 52);
            btnNeg.TabIndex = 4;
            btnNeg.Text = "+/-";
            btnNeg.UseVisualStyleBackColor = true;
            btnNeg.Click += btnNeg_Click;
            // 
            // btnTimes
            // 
            btnTimes.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimes.Location = new Point(258, 196);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(58, 52);
            btnTimes.TabIndex = 9;
            btnTimes.Text = "*";
            btnTimes.UseVisualStyleBackColor = true;
            btnTimes.Click += operator_click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(165, 196);
            btn6.Name = "btn6";
            btn6.Size = new Size(58, 52);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button_click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.Location = new Point(322, 196);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(58, 52);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += operator_click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(101, 196);
            btn5.Name = "btn5";
            btn5.Size = new Size(58, 52);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button_click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(37, 196);
            btn4.Name = "btn4";
            btn4.Size = new Size(58, 52);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button_click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.Location = new Point(258, 265);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(58, 52);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += operator_click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(165, 265);
            btn3.Name = "btn3";
            btn3.Size = new Size(58, 52);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button_click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.Location = new Point(322, 265);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(58, 120);
            btnEquals.TabIndex = 13;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(101, 265);
            btn2.Name = "btn2";
            btn2.Size = new Size(58, 52);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button_click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(37, 265);
            btn1.Name = "btn1";
            btn1.Size = new Size(58, 52);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button_click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.Location = new Point(258, 333);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(58, 52);
            btnPlus.TabIndex = 19;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += operator_click;
            // 
            // btnPoint
            // 
            btnPoint.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPoint.Location = new Point(165, 333);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(58, 52);
            btnPoint.TabIndex = 17;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += button_click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(101, 333);
            btn0.Name = "btn0";
            btn0.Size = new Size(58, 52);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button_click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(37, 333);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(58, 52);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.Location = new Point(334, 34);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(0, 15);
            labelCurrentOperation.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 417);
            Controls.Add(labelCurrentOperation);
            Controls.Add(btnPlus);
            Controls.Add(btnPoint);
            Controls.Add(btn0);
            Controls.Add(btnClear);
            Controls.Add(btnMinus);
            Controls.Add(btn3);
            Controls.Add(btnEquals);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnTimes);
            Controls.Add(btn6);
            Controls.Add(btnDivide);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnNeg);
            Controls.Add(btn9);
            Controls.Add(btnDel);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtboxOutput);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxOutput;
        private Button btn7;
        private Button btn8;
        private Button btnDel;
        private Button btn9;
        private Button btnNeg;
        private Button btnTimes;
        private Button btn6;
        private Button btnDivide;
        private Button btn5;
        private Button btn4;
        private Button btnMinus;
        private Button btn3;
        private Button btnEquals;
        private Button btn2;
        private Button btn1;
        private Button btnPlus;
        private Button btnPoint;
        private Button btn0;
        private Button btnClear;
        private Label labelCurrentOperation;
    }
}