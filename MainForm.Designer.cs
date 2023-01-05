using System.ComponentModel;

namespace DevonsProgrammerCalc
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnModulus = new System.Windows.Forms.Button();
            this.btnShiftLeft = new System.Windows.Forms.Button();
            this.btnShiftRight = new System.Windows.Forms.Button();
            this.btnXor = new System.Windows.Forms.Button();
            this.btnOr = new System.Windows.Forms.Button();
            this.btnAnd = new System.Windows.Forms.Button();
            this.btnLeftParen = new System.Windows.Forms.Button();
            this.btnRightParen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelNumbers = new System.Windows.Forms.Panel();
            this.btnNumD = new System.Windows.Forms.Button();
            this.btnNumE = new System.Windows.Forms.Button();
            this.btnNumF = new System.Windows.Forms.Button();
            this.btnNumA = new System.Windows.Forms.Button();
            this.btnNumB = new System.Windows.Forms.Button();
            this.btnNumC = new System.Windows.Forms.Button();
            this.panelOperators = new System.Windows.Forms.Panel();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnOctal = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.panelBases = new System.Windows.Forms.Panel();
            this.radioBase2 = new System.Windows.Forms.RadioButton();
            this.radioBase16 = new System.Windows.Forms.RadioButton();
            this.radioBase8 = new System.Windows.Forms.RadioButton();
            this.radioBase10 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioByte = new System.Windows.Forms.RadioButton();
            this.radioWord = new System.Windows.Forms.RadioButton();
            this.radioDword = new System.Windows.Forms.RadioButton();
            this.radioQword = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioUnsigned = new System.Windows.Forms.RadioButton();
            this.radioSigned = new System.Windows.Forms.RadioButton();
            this.panelCalcFuncs = new System.Windows.Forms.Panel();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.panelNumbers.SuspendLayout();
            this.panelOperators.SuspendLayout();
            this.panelBases.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCalcFuncs.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtExpression
            // 
            this.txtExpression.Location = new System.Drawing.Point(14, 14);
            this.txtExpression.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExpression.Size = new System.Drawing.Size(492, 23);
            this.txtExpression.TabIndex = 0;
            this.txtExpression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNum7
            // 
            this.btnNum7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum7.Location = new System.Drawing.Point(4, 105);
            this.btnNum7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(52, 44);
            this.btnNum7.TabIndex = 1;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnNum8
            // 
            this.btnNum8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum8.Location = new System.Drawing.Point(63, 105);
            this.btnNum8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(52, 44);
            this.btnNum8.TabIndex = 2;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnNum9
            // 
            this.btnNum9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum9.Location = new System.Drawing.Point(122, 105);
            this.btnNum9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(52, 44);
            this.btnNum9.TabIndex = 3;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnNum4
            // 
            this.btnNum4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum4.Location = new System.Drawing.Point(4, 156);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(52, 44);
            this.btnNum4.TabIndex = 4;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnNum5
            // 
            this.btnNum5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum5.Location = new System.Drawing.Point(63, 156);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(52, 44);
            this.btnNum5.TabIndex = 5;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnNum6
            // 
            this.btnNum6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum6.Location = new System.Drawing.Point(122, 156);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(52, 44);
            this.btnNum6.TabIndex = 6;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnNum1
            // 
            this.btnNum1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum1.Location = new System.Drawing.Point(4, 205);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(52, 44);
            this.btnNum1.TabIndex = 7;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnNum2
            // 
            this.btnNum2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum2.Location = new System.Drawing.Point(63, 205);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(52, 44);
            this.btnNum2.TabIndex = 8;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnNum3
            // 
            this.btnNum3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum3.Location = new System.Drawing.Point(122, 205);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(52, 44);
            this.btnNum3.TabIndex = 9;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnNum0
            // 
            this.btnNum0.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum0.Location = new System.Drawing.Point(4, 256);
            this.btnNum0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(172, 44);
            this.btnNum0.TabIndex = 10;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEquals.Location = new System.Drawing.Point(63, 3);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(52, 44);
            this.btnEquals.TabIndex = 11;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.Button_Equals);
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.SystemColors.Window;
            this.txtResults.Location = new System.Drawing.Point(14, 45);
            this.txtResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(492, 23);
            this.txtResults.TabIndex = 12;
            this.txtResults.Text = "0";
            this.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(4, 156);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(52, 44);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtract.Location = new System.Drawing.Point(4, 105);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(52, 44);
            this.btnSubtract.TabIndex = 14;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(4, 54);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(52, 44);
            this.btnMultiply.TabIndex = 15;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(4, 3);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(52, 44);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnModulus
            // 
            this.btnModulus.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModulus.Location = new System.Drawing.Point(63, 3);
            this.btnModulus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModulus.Name = "btnModulus";
            this.btnModulus.Size = new System.Drawing.Size(52, 44);
            this.btnModulus.TabIndex = 17;
            this.btnModulus.Text = "%";
            this.btnModulus.UseVisualStyleBackColor = true;
            this.btnModulus.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnShiftLeft
            // 
            this.btnShiftLeft.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShiftLeft.Location = new System.Drawing.Point(63, 54);
            this.btnShiftLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShiftLeft.Name = "btnShiftLeft";
            this.btnShiftLeft.Size = new System.Drawing.Size(52, 44);
            this.btnShiftLeft.TabIndex = 18;
            this.btnShiftLeft.Text = "<<";
            this.btnShiftLeft.UseVisualStyleBackColor = true;
            this.btnShiftLeft.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnShiftRight
            // 
            this.btnShiftRight.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShiftRight.Location = new System.Drawing.Point(63, 105);
            this.btnShiftRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShiftRight.Name = "btnShiftRight";
            this.btnShiftRight.Size = new System.Drawing.Size(52, 44);
            this.btnShiftRight.TabIndex = 19;
            this.btnShiftRight.Text = ">>";
            this.btnShiftRight.UseVisualStyleBackColor = true;
            this.btnShiftRight.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnXor
            // 
            this.btnXor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXor.Location = new System.Drawing.Point(122, 105);
            this.btnXor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXor.Name = "btnXor";
            this.btnXor.Size = new System.Drawing.Size(52, 44);
            this.btnXor.TabIndex = 23;
            this.btnXor.Text = "^";
            this.btnXor.UseVisualStyleBackColor = true;
            this.btnXor.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnOr
            // 
            this.btnOr.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOr.Location = new System.Drawing.Point(122, 54);
            this.btnOr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(52, 44);
            this.btnOr.TabIndex = 22;
            this.btnOr.Text = "|";
            this.btnOr.UseVisualStyleBackColor = true;
            this.btnOr.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnAnd
            // 
            this.btnAnd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnd.Location = new System.Drawing.Point(122, 3);
            this.btnAnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(52, 44);
            this.btnAnd.TabIndex = 21;
            this.btnAnd.Text = "&&";
            this.btnAnd.UseVisualStyleBackColor = true;
            this.btnAnd.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnLeftParen
            // 
            this.btnLeftParen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeftParen.Location = new System.Drawing.Point(63, 156);
            this.btnLeftParen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLeftParen.Name = "btnLeftParen";
            this.btnLeftParen.Size = new System.Drawing.Size(52, 44);
            this.btnLeftParen.TabIndex = 24;
            this.btnLeftParen.Text = "(";
            this.btnLeftParen.UseVisualStyleBackColor = true;
            this.btnLeftParen.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnRightParen
            // 
            this.btnRightParen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRightParen.Location = new System.Drawing.Point(122, 156);
            this.btnRightParen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRightParen.Name = "btnRightParen";
            this.btnRightParen.Size = new System.Drawing.Size(52, 44);
            this.btnRightParen.TabIndex = 25;
            this.btnRightParen.Text = ")";
            this.btnRightParen.UseVisualStyleBackColor = true;
            this.btnRightParen.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(122, 3);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 44);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "CL";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Button_Clear);
            // 
            // panelNumbers
            // 
            this.panelNumbers.Controls.Add(this.btnNumD);
            this.panelNumbers.Controls.Add(this.btnNumE);
            this.panelNumbers.Controls.Add(this.btnNumF);
            this.panelNumbers.Controls.Add(this.btnNumA);
            this.panelNumbers.Controls.Add(this.btnNumB);
            this.panelNumbers.Controls.Add(this.btnNumC);
            this.panelNumbers.Controls.Add(this.btnNum7);
            this.panelNumbers.Controls.Add(this.btnNum8);
            this.panelNumbers.Controls.Add(this.btnNum9);
            this.panelNumbers.Controls.Add(this.btnNum4);
            this.panelNumbers.Controls.Add(this.btnNum5);
            this.panelNumbers.Controls.Add(this.btnNum6);
            this.panelNumbers.Controls.Add(this.btnNum1);
            this.panelNumbers.Controls.Add(this.btnNum2);
            this.panelNumbers.Controls.Add(this.btnNum3);
            this.panelNumbers.Controls.Add(this.btnNum0);
            this.panelNumbers.Location = new System.Drawing.Point(200, 76);
            this.panelNumbers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelNumbers.Name = "panelNumbers";
            this.panelNumbers.Size = new System.Drawing.Size(178, 305);
            this.panelNumbers.TabIndex = 28;
            // 
            // btnNumD
            // 
            this.btnNumD.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumD.Location = new System.Drawing.Point(4, 3);
            this.btnNumD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNumD.Name = "btnNumD";
            this.btnNumD.Size = new System.Drawing.Size(52, 44);
            this.btnNumD.TabIndex = 28;
            this.btnNumD.Text = "D";
            this.btnNumD.UseVisualStyleBackColor = true;
            this.btnNumD.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnNumE
            // 
            this.btnNumE.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumE.Location = new System.Drawing.Point(63, 3);
            this.btnNumE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNumE.Name = "btnNumE";
            this.btnNumE.Size = new System.Drawing.Size(52, 44);
            this.btnNumE.TabIndex = 29;
            this.btnNumE.Text = "E";
            this.btnNumE.UseVisualStyleBackColor = true;
            this.btnNumE.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnNumF
            // 
            this.btnNumF.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumF.Location = new System.Drawing.Point(122, 3);
            this.btnNumF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNumF.Name = "btnNumF";
            this.btnNumF.Size = new System.Drawing.Size(52, 44);
            this.btnNumF.TabIndex = 30;
            this.btnNumF.Text = "F";
            this.btnNumF.UseVisualStyleBackColor = true;
            this.btnNumF.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnNumA
            // 
            this.btnNumA.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumA.Location = new System.Drawing.Point(4, 54);
            this.btnNumA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNumA.Name = "btnNumA";
            this.btnNumA.Size = new System.Drawing.Size(52, 44);
            this.btnNumA.TabIndex = 31;
            this.btnNumA.Text = "A";
            this.btnNumA.UseVisualStyleBackColor = true;
            this.btnNumA.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnNumB
            // 
            this.btnNumB.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumB.Location = new System.Drawing.Point(63, 54);
            this.btnNumB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNumB.Name = "btnNumB";
            this.btnNumB.Size = new System.Drawing.Size(52, 44);
            this.btnNumB.TabIndex = 32;
            this.btnNumB.Text = "B";
            this.btnNumB.UseVisualStyleBackColor = true;
            this.btnNumB.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnNumC
            // 
            this.btnNumC.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNumC.Location = new System.Drawing.Point(122, 54);
            this.btnNumC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNumC.Name = "btnNumC";
            this.btnNumC.Size = new System.Drawing.Size(52, 44);
            this.btnNumC.TabIndex = 33;
            this.btnNumC.Text = "C";
            this.btnNumC.UseVisualStyleBackColor = true;
            this.btnNumC.Click += new System.EventHandler(this.Button_Insert);
            // 
            // panelOperators
            // 
            this.panelOperators.Controls.Add(this.btnPower);
            this.panelOperators.Controls.Add(this.btnSqrt);
            this.panelOperators.Controls.Add(this.btnOctal);
            this.panelOperators.Controls.Add(this.btnHex);
            this.panelOperators.Controls.Add(this.btnBinary);
            this.panelOperators.Controls.Add(this.btnDivide);
            this.panelOperators.Controls.Add(this.btnComma);
            this.panelOperators.Controls.Add(this.btnPlus);
            this.panelOperators.Controls.Add(this.btnRightParen);
            this.panelOperators.Controls.Add(this.btnSubtract);
            this.panelOperators.Controls.Add(this.btnLeftParen);
            this.panelOperators.Controls.Add(this.btnMultiply);
            this.panelOperators.Controls.Add(this.btnXor);
            this.panelOperators.Controls.Add(this.btnModulus);
            this.panelOperators.Controls.Add(this.btnOr);
            this.panelOperators.Controls.Add(this.btnShiftLeft);
            this.panelOperators.Controls.Add(this.btnAnd);
            this.panelOperators.Controls.Add(this.btnShiftRight);
            this.panelOperators.Location = new System.Drawing.Point(14, 76);
            this.panelOperators.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelOperators.Name = "panelOperators";
            this.panelOperators.Size = new System.Drawing.Size(178, 305);
            this.panelOperators.TabIndex = 29;
            // 
            // btnPower
            // 
            this.btnPower.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPower.Location = new System.Drawing.Point(63, 207);
            this.btnPower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(52, 44);
            this.btnPower.TabIndex = 31;
            this.btnPower.Text = "pow";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.Button_InsertFunc);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSqrt.Location = new System.Drawing.Point(122, 207);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(52, 44);
            this.btnSqrt.TabIndex = 32;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.Button_InsertFunc);
            // 
            // btnOctal
            // 
            this.btnOctal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOctal.Location = new System.Drawing.Point(63, 257);
            this.btnOctal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(52, 44);
            this.btnOctal.TabIndex = 36;
            this.btnOctal.Text = "0o";
            this.btnOctal.UseVisualStyleBackColor = true;
            this.btnOctal.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnHex
            // 
            this.btnHex.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHex.Location = new System.Drawing.Point(122, 257);
            this.btnHex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(52, 44);
            this.btnHex.TabIndex = 35;
            this.btnHex.Text = "0x";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnBinary
            // 
            this.btnBinary.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBinary.Location = new System.Drawing.Point(4, 257);
            this.btnBinary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(52, 44);
            this.btnBinary.TabIndex = 34;
            this.btnBinary.Text = "0b";
            this.btnBinary.UseVisualStyleBackColor = true;
            this.btnBinary.Click += new System.EventHandler(this.Button_Insert);
            // 
            // btnComma
            // 
            this.btnComma.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComma.Location = new System.Drawing.Point(4, 207);
            this.btnComma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(52, 44);
            this.btnComma.TabIndex = 33;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = true;
            this.btnComma.Click += new System.EventHandler(this.Button_Insert);
            // 
            // panelBases
            // 
            this.panelBases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBases.Controls.Add(this.radioBase2);
            this.panelBases.Controls.Add(this.radioBase16);
            this.panelBases.Controls.Add(this.radioBase8);
            this.panelBases.Controls.Add(this.radioBase10);
            this.panelBases.Location = new System.Drawing.Point(385, 80);
            this.panelBases.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelBases.Name = "panelBases";
            this.panelBases.Size = new System.Drawing.Size(121, 108);
            this.panelBases.TabIndex = 31;
            // 
            // radioBase2
            // 
            this.radioBase2.AutoSize = true;
            this.radioBase2.Location = new System.Drawing.Point(4, 83);
            this.radioBase2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBase2.Name = "radioBase2";
            this.radioBase2.Size = new System.Drawing.Size(58, 19);
            this.radioBase2.TabIndex = 0;
            this.radioBase2.Text = "Binary";
            this.radioBase2.UseVisualStyleBackColor = true;
            this.radioBase2.CheckedChanged += new System.EventHandler(this.radioBase2_CheckedChanged);
            // 
            // radioBase16
            // 
            this.radioBase16.AutoSize = true;
            this.radioBase16.Location = new System.Drawing.Point(4, 3);
            this.radioBase16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBase16.Name = "radioBase16";
            this.radioBase16.Size = new System.Drawing.Size(94, 19);
            this.radioBase16.TabIndex = 3;
            this.radioBase16.Text = "Hexadecimal";
            this.radioBase16.UseVisualStyleBackColor = true;
            this.radioBase16.CheckedChanged += new System.EventHandler(this.radioBase16_CheckedChanged);
            // 
            // radioBase8
            // 
            this.radioBase8.AutoSize = true;
            this.radioBase8.Location = new System.Drawing.Point(4, 57);
            this.radioBase8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBase8.Name = "radioBase8";
            this.radioBase8.Size = new System.Drawing.Size(53, 19);
            this.radioBase8.TabIndex = 1;
            this.radioBase8.Text = "Octal";
            this.radioBase8.UseVisualStyleBackColor = true;
            this.radioBase8.CheckedChanged += new System.EventHandler(this.radioBase8_CheckedChanged);
            // 
            // radioBase10
            // 
            this.radioBase10.AutoSize = true;
            this.radioBase10.Checked = true;
            this.radioBase10.Location = new System.Drawing.Point(4, 30);
            this.radioBase10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBase10.Name = "radioBase10";
            this.radioBase10.Size = new System.Drawing.Size(68, 19);
            this.radioBase10.TabIndex = 2;
            this.radioBase10.TabStop = true;
            this.radioBase10.Text = "Decimal";
            this.radioBase10.UseVisualStyleBackColor = true;
            this.radioBase10.CheckedChanged += new System.EventHandler(this.radioBase10_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioByte);
            this.panel1.Controls.Add(this.radioWord);
            this.panel1.Controls.Add(this.radioDword);
            this.panel1.Controls.Add(this.radioQword);
            this.panel1.Location = new System.Drawing.Point(385, 195);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 108);
            this.panel1.TabIndex = 32;
            // 
            // radioByte
            // 
            this.radioByte.AutoSize = true;
            this.radioByte.Location = new System.Drawing.Point(4, 83);
            this.radioByte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioByte.Name = "radioByte";
            this.radioByte.Size = new System.Drawing.Size(48, 19);
            this.radioByte.TabIndex = 3;
            this.radioByte.Text = "Byte";
            this.radioByte.UseVisualStyleBackColor = true;
            this.radioByte.CheckedChanged += new System.EventHandler(this.radioByte_CheckedChanged);
            // 
            // radioWord
            // 
            this.radioWord.AutoSize = true;
            this.radioWord.Location = new System.Drawing.Point(4, 57);
            this.radioWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioWord.Name = "radioWord";
            this.radioWord.Size = new System.Drawing.Size(54, 19);
            this.radioWord.TabIndex = 2;
            this.radioWord.Text = "Word";
            this.radioWord.UseVisualStyleBackColor = true;
            this.radioWord.CheckedChanged += new System.EventHandler(this.radioWord_CheckedChanged);
            // 
            // radioDword
            // 
            this.radioDword.AutoSize = true;
            this.radioDword.Location = new System.Drawing.Point(4, 30);
            this.radioDword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioDword.Name = "radioDword";
            this.radioDword.Size = new System.Drawing.Size(60, 19);
            this.radioDword.TabIndex = 1;
            this.radioDword.Text = "Dword";
            this.radioDword.UseVisualStyleBackColor = true;
            this.radioDword.CheckedChanged += new System.EventHandler(this.radioDword_CheckedChanged);
            // 
            // radioQword
            // 
            this.radioQword.AutoSize = true;
            this.radioQword.Checked = true;
            this.radioQword.Location = new System.Drawing.Point(4, 3);
            this.radioQword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioQword.Name = "radioQword";
            this.radioQword.Size = new System.Drawing.Size(61, 19);
            this.radioQword.TabIndex = 0;
            this.radioQword.TabStop = true;
            this.radioQword.Text = "Qword";
            this.radioQword.UseVisualStyleBackColor = true;
            this.radioQword.CheckedChanged += new System.EventHandler(this.radioQword_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioUnsigned);
            this.panel2.Controls.Add(this.radioSigned);
            this.panel2.Location = new System.Drawing.Point(385, 310);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 65);
            this.panel2.TabIndex = 33;
            // 
            // radioUnsigned
            // 
            this.radioUnsigned.AutoSize = true;
            this.radioUnsigned.Location = new System.Drawing.Point(4, 37);
            this.radioUnsigned.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioUnsigned.Name = "radioUnsigned";
            this.radioUnsigned.Size = new System.Drawing.Size(75, 19);
            this.radioUnsigned.TabIndex = 1;
            this.radioUnsigned.Text = "Unsigned";
            this.radioUnsigned.UseVisualStyleBackColor = true;
            this.radioUnsigned.CheckedChanged += new System.EventHandler(this.radioUnsigned_CheckedChanged);
            // 
            // radioSigned
            // 
            this.radioSigned.AutoSize = true;
            this.radioSigned.Checked = true;
            this.radioSigned.Location = new System.Drawing.Point(4, 9);
            this.radioSigned.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioSigned.Name = "radioSigned";
            this.radioSigned.Size = new System.Drawing.Size(61, 19);
            this.radioSigned.TabIndex = 0;
            this.radioSigned.TabStop = true;
            this.radioSigned.Text = "Signed";
            this.radioSigned.UseVisualStyleBackColor = true;
            this.radioSigned.CheckedChanged += new System.EventHandler(this.radioSigned_CheckedChanged);
            // 
            // panelCalcFuncs
            // 
            this.panelCalcFuncs.Controls.Add(this.btnBackspace);
            this.panelCalcFuncs.Controls.Add(this.btnClear);
            this.panelCalcFuncs.Controls.Add(this.btnEquals);
            this.panelCalcFuncs.Location = new System.Drawing.Point(200, 389);
            this.panelCalcFuncs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelCalcFuncs.Name = "panelCalcFuncs";
            this.panelCalcFuncs.Size = new System.Drawing.Size(178, 51);
            this.panelCalcFuncs.TabIndex = 34;
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackspace.Location = new System.Drawing.Point(4, 3);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(52, 44);
            this.btnBackspace.TabIndex = 27;
            this.btnBackspace.Text = "<-";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.Button_Backspace);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnEquals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 453);
            this.Controls.Add(this.panelCalcFuncs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBases);
            this.Controls.Add(this.panelOperators);
            this.Controls.Add(this.panelNumbers);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtExpression);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Devon\'s Programmer Calculator";
            this.panelNumbers.ResumeLayout(false);
            this.panelOperators.ResumeLayout(false);
            this.panelBases.ResumeLayout(false);
            this.panelBases.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCalcFuncs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private TextBox txtExpression;
		private Button btnNum7;
		private Button btnNum8;
		private Button btnNum9;
		private Button btnNum4;
		private Button btnNum5;
		private Button btnNum6;
		private Button btnNum1;
		private Button btnNum2;
		private Button btnNum3;
		private Button btnNum0;
		private Button btnEquals;
		private TextBox txtResults;
		private Button btnPlus;
		private Button btnSubtract;
		private Button btnMultiply;
		private Button btnDivide;
		private Button btnModulus;
		private Button btnShiftLeft;
		private Button btnShiftRight;
		private Button btnXor;
		private Button btnOr;
		private Button btnAnd;
		private Button btnLeftParen;
		private Button btnRightParen;
		private Button btnClear;
		private Panel panelNumbers;
		private Panel panelOperators;
		private Button btnPower;
		private Button btnComma;
		private Button btnSqrt;
		private Button btnOctal;
		private Button btnHex;
		private Button btnBinary;
		private Button btnNumD;
		private Button btnNumE;
		private Button btnNumF;
		private Button btnNumA;
		private Button btnNumB;
		private Button btnNumC;
		private Panel panelBases;
		private RadioButton radioBase16;
		private RadioButton radioBase10;
		private RadioButton radioBase8;
		private RadioButton radioBase2;
		private Panel panel1;
		private RadioButton radioByte;
		private RadioButton radioWord;
		private RadioButton radioDword;
		private RadioButton radioQword;
		private Panel panel2;
		private RadioButton radioUnsigned;
		private RadioButton radioSigned;
		private Panel panelCalcFuncs;
		private Button btnBackspace;
	}
}