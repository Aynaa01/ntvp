namespace ModelView
{
    partial class FigureEdit
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
            this.TabControlFigure = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Rectangle = new System.Windows.Forms.TabPage();
            this.Trangle = new System.Windows.Forms.TabPage();
            this.Radius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Heigth = new System.Windows.Forms.TextBox();
            this.Wigth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.sideA = new System.Windows.Forms.TextBox();
            this.sideB = new System.Windows.Forms.TextBox();
            this.sideC = new System.Windows.Forms.TextBox();
            this.Добавить = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TabControlFigure.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Rectangle.SuspendLayout();
            this.Trangle.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlFigure
            // 
            this.TabControlFigure.Controls.Add(this.tabPage1);
            this.TabControlFigure.Controls.Add(this.Rectangle);
            this.TabControlFigure.Controls.Add(this.Trangle);
            this.TabControlFigure.Location = new System.Drawing.Point(33, 12);
            this.TabControlFigure.Name = "TabControlFigure";
            this.TabControlFigure.SelectedIndex = 0;
            this.TabControlFigure.Size = new System.Drawing.Size(280, 191);
            this.TabControlFigure.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Radius);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(272, 162);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Круг";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Controls.Add(this.label3);
            this.Rectangle.Controls.Add(this.Wigth);
            this.Rectangle.Controls.Add(this.Heigth);
            this.Rectangle.Controls.Add(this.label2);
            this.Rectangle.Location = new System.Drawing.Point(4, 25);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Padding = new System.Windows.Forms.Padding(3);
            this.Rectangle.Size = new System.Drawing.Size(272, 162);
            this.Rectangle.TabIndex = 1;
            this.Rectangle.Text = "Прямоугольник";
            this.Rectangle.UseVisualStyleBackColor = true;
            // 
            // Trangle
            // 
            this.Trangle.Controls.Add(this.sideC);
            this.Trangle.Controls.Add(this.sideB);
            this.Trangle.Controls.Add(this.sideA);
            this.Trangle.Controls.Add(this.C);
            this.Trangle.Controls.Add(this.B);
            this.Trangle.Controls.Add(this.A);
            this.Trangle.Location = new System.Drawing.Point(4, 25);
            this.Trangle.Name = "Trangle";
            this.Trangle.Size = new System.Drawing.Size(272, 162);
            this.Trangle.TabIndex = 2;
            this.Trangle.Text = "Треугольник";
            this.Trangle.UseVisualStyleBackColor = true;
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(119, 18);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(100, 22);
            this.Radius.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Радиус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Высота";
            // 
            // Heigth
            // 
            this.Heigth.Location = new System.Drawing.Point(121, 19);
            this.Heigth.Name = "Heigth";
            this.Heigth.Size = new System.Drawing.Size(100, 22);
            this.Heigth.TabIndex = 1;
            // 
            // Wigth
            // 
            this.Wigth.Location = new System.Drawing.Point(121, 72);
            this.Wigth.Name = "Wigth";
            this.Wigth.Size = new System.Drawing.Size(100, 22);
            this.Wigth.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ширина";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(21, 19);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(77, 17);
            this.A.TabIndex = 0;
            this.A.Text = "Сторона А";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(21, 55);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(77, 17);
            this.B.TabIndex = 1;
            this.B.Text = "Сторона В";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(21, 89);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(77, 17);
            this.C.TabIndex = 2;
            this.C.Text = "Сторона С";
            // 
            // sideA
            // 
            this.sideA.Location = new System.Drawing.Point(114, 16);
            this.sideA.Name = "sideA";
            this.sideA.Size = new System.Drawing.Size(100, 22);
            this.sideA.TabIndex = 3;
            // 
            // sideB
            // 
            this.sideB.Location = new System.Drawing.Point(114, 52);
            this.sideB.Name = "sideB";
            this.sideB.Size = new System.Drawing.Size(100, 22);
            this.sideB.TabIndex = 4;
            // 
            // sideC
            // 
            this.sideC.Location = new System.Drawing.Point(114, 84);
            this.sideC.Name = "sideC";
            this.sideC.Size = new System.Drawing.Size(100, 22);
            this.sideC.TabIndex = 5;
            // 
            // Добавить
            // 
            this.Добавить.Location = new System.Drawing.Point(51, 209);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(89, 23);
            this.Добавить.TabIndex = 1;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FigureEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 250);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Добавить);
            this.Controls.Add(this.TabControlFigure);
            this.Name = "FigureEdit";
            this.Text = "FigureEdit";
            this.TabControlFigure.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Rectangle.ResumeLayout(false);
            this.Rectangle.PerformLayout();
            this.Trangle.ResumeLayout(false);
            this.Trangle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlFigure;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Rectangle;
        private System.Windows.Forms.TabPage Trangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Radius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Wigth;
        private System.Windows.Forms.TextBox Heigth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sideC;
        private System.Windows.Forms.TextBox sideB;
        private System.Windows.Forms.TextBox sideA;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.Button button2;
    }
}