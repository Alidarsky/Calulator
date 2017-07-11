namespace Calulator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.field1 = new System.Windows.Forms.TextBox();
            this.field2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cos = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.arccos = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.ctan = new System.Windows.Forms.Button();
            this.tenX = new System.Windows.Forms.Button();
            this.logTen = new System.Windows.Forms.Button();
            this.logTwo = new System.Windows.Forms.Button();
            this.arctan = new System.Windows.Forms.Button();
            this.twoX = new System.Windows.Forms.Button();
            this.logE = new System.Windows.Forms.Button();
            this.minusX = new System.Windows.Forms.Button();
            this.residue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(108, 59);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 0;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.TwoButtonClick);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(27, 59);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 23);
            this.multiplication.TabIndex = 1;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.TwoButtonClick);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(27, 88);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 2;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.TwoButtonClick);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(108, 88);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.TwoButtonClick);
            // 
            // field1
            // 
            this.field1.Location = new System.Drawing.Point(74, 33);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(100, 20);
            this.field1.TabIndex = 4;
            // 
            // field2
            // 
            this.field2.Location = new System.Drawing.Point(199, 33);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(100, 20);
            this.field2.TabIndex = 6;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(140, 217);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "=";
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(189, 59);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 9;
            this.cos.Text = "cos x";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(189, 88);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 10;
            this.sin.Text = "sin x";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // pow
            // 
            this.pow.Location = new System.Drawing.Point(270, 59);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(75, 23);
            this.pow.TabIndex = 11;
            this.pow.Text = "x^2";
            this.pow.UseVisualStyleBackColor = true;
            this.pow.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(270, 88);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(75, 23);
            this.root.TabIndex = 12;
            this.root.Text = "sqrt x";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // arccos
            // 
            this.arccos.Location = new System.Drawing.Point(27, 117);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(75, 23);
            this.arccos.TabIndex = 13;
            this.arccos.Text = "arccos x";
            this.arccos.UseVisualStyleBackColor = true;
            this.arccos.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(108, 117);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(75, 23);
            this.arcsin.TabIndex = 14;
            this.arcsin.Text = "arcsin x";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(189, 117);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 15;
            this.tan.Text = "tan x";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // ctan
            // 
            this.ctan.Location = new System.Drawing.Point(270, 117);
            this.ctan.Name = "ctan";
            this.ctan.Size = new System.Drawing.Size(75, 23);
            this.ctan.TabIndex = 16;
            this.ctan.Text = "ctan x";
            this.ctan.UseVisualStyleBackColor = true;
            this.ctan.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // tenX
            // 
            this.tenX.Location = new System.Drawing.Point(27, 146);
            this.tenX.Name = "tenX";
            this.tenX.Size = new System.Drawing.Size(75, 23);
            this.tenX.TabIndex = 17;
            this.tenX.Text = "10^x";
            this.tenX.UseVisualStyleBackColor = true;
            this.tenX.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // logTen
            // 
            this.logTen.Location = new System.Drawing.Point(108, 146);
            this.logTen.Name = "logTen";
            this.logTen.Size = new System.Drawing.Size(75, 23);
            this.logTen.TabIndex = 18;
            this.logTen.Text = "log10 x";
            this.logTen.UseVisualStyleBackColor = true;
            this.logTen.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // logTwo
            // 
            this.logTwo.Location = new System.Drawing.Point(189, 146);
            this.logTwo.Name = "logTwo";
            this.logTwo.Size = new System.Drawing.Size(75, 23);
            this.logTwo.TabIndex = 19;
            this.logTwo.Text = "log2 x";
            this.logTwo.UseVisualStyleBackColor = true;
            this.logTwo.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // arctan
            // 
            this.arctan.Location = new System.Drawing.Point(270, 146);
            this.arctan.Name = "arctan";
            this.arctan.Size = new System.Drawing.Size(75, 23);
            this.arctan.TabIndex = 20;
            this.arctan.Text = "arctan x";
            this.arctan.UseVisualStyleBackColor = true;
            this.arctan.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // twoX
            // 
            this.twoX.Location = new System.Drawing.Point(27, 175);
            this.twoX.Name = "twoX";
            this.twoX.Size = new System.Drawing.Size(75, 23);
            this.twoX.TabIndex = 21;
            this.twoX.Text = "2^x";
            this.twoX.UseVisualStyleBackColor = true;
            this.twoX.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // logE
            // 
            this.logE.Location = new System.Drawing.Point(108, 175);
            this.logE.Name = "logE";
            this.logE.Size = new System.Drawing.Size(75, 23);
            this.logE.TabIndex = 22;
            this.logE.Text = "ln x";
            this.logE.UseVisualStyleBackColor = true;
            this.logE.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // minusX
            // 
            this.minusX.Location = new System.Drawing.Point(189, 175);
            this.minusX.Name = "minusX";
            this.minusX.Size = new System.Drawing.Size(75, 23);
            this.minusX.TabIndex = 23;
            this.minusX.Text = "-x";
            this.minusX.UseVisualStyleBackColor = true;
            this.minusX.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // residue
            // 
            this.residue.Location = new System.Drawing.Point(270, 175);
            this.residue.Name = "residue";
            this.residue.Size = new System.Drawing.Size(75, 23);
            this.residue.TabIndex = 24;
            this.residue.Text = "%";
            this.residue.UseVisualStyleBackColor = true;
            this.residue.Click += new System.EventHandler(this.TwoButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(380, 292);
            this.Controls.Add(this.residue);
            this.Controls.Add(this.minusX);
            this.Controls.Add(this.logE);
            this.Controls.Add(this.twoX);
            this.Controls.Add(this.arctan);
            this.Controls.Add(this.logTwo);
            this.Controls.Add(this.logTen);
            this.Controls.Add(this.tenX);
            this.Controls.Add(this.ctan);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.arccos);
            this.Controls.Add(this.root);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.field2);
            this.Controls.Add(this.field1);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.division);
            this.Name = "Form1";
            this.Text = "/";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.TextBox field1;
        private System.Windows.Forms.TextBox field2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button arccos;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button ctan;
        private System.Windows.Forms.Button tenX;
        private System.Windows.Forms.Button logTen;
        private System.Windows.Forms.Button logTwo;
        private System.Windows.Forms.Button arctan;
        private System.Windows.Forms.Button twoX;
        private System.Windows.Forms.Button logE;
        private System.Windows.Forms.Button minusX;
        private System.Windows.Forms.Button residue;
    }
}

