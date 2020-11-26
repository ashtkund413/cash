namespace cash
{
    partial class Form1
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
            this.burgernumber = new System.Windows.Forms.TextBox();
            this.friesnumber = new System.Windows.Forms.TextBox();
            this.drinksnumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.Label();
            this.ordernumber = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.TextBox();
            this.taxtotal = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.burgertext = new System.Windows.Forms.Label();
            this.friestext1 = new System.Windows.Forms.Label();
            this.drinkstext1 = new System.Windows.Forms.Label();
            this.taxtext = new System.Windows.Forms.Label();
            this.totaltext = new System.Windows.Forms.Label();
            this.subtext = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // burgernumber
            // 
            this.burgernumber.Location = new System.Drawing.Point(288, 47);
            this.burgernumber.Name = "burgernumber";
            this.burgernumber.Size = new System.Drawing.Size(133, 20);
            this.burgernumber.TabIndex = 3;
            // 
            // friesnumber
            // 
            this.friesnumber.Location = new System.Drawing.Point(288, 105);
            this.friesnumber.Name = "friesnumber";
            this.friesnumber.Size = new System.Drawing.Size(133, 20);
            this.friesnumber.TabIndex = 4;
            // 
            // drinksnumber
            // 
            this.drinksnumber.Location = new System.Drawing.Point(288, 159);
            this.drinksnumber.Name = "drinksnumber";
            this.drinksnumber.Size = new System.Drawing.Size(133, 20);
            this.drinksnumber.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.subtext);
            this.panel1.Controls.Add(this.totaltext);
            this.panel1.Controls.Add(this.taxtext);
            this.panel1.Controls.Add(this.drinkstext1);
            this.panel1.Controls.Add(this.friestext1);
            this.panel1.Controls.Add(this.burgertext);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.ordernumber);
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(440, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 360);
            this.panel1.TabIndex = 6;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(130, 51);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 13);
            this.date.TabIndex = 2;
            // 
            // ordernumber
            // 
            this.ordernumber.AutoSize = true;
            this.ordernumber.Location = new System.Drawing.Point(3, 51);
            this.ordernumber.Name = "ordernumber";
            this.ordernumber.Size = new System.Drawing.Size(0, 13);
            this.ordernumber.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(36, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 22);
            this.label.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "calculate total ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "sub total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "total";
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(313, 349);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 23);
            this.print.TabIndex = 11;
            this.print.Text = "print receipt";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.Print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "number of bugrers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "number of fries";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "number of dirnks";
            // 
            // subtotal
            // 
            this.subtotal.Location = new System.Drawing.Point(288, 263);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(125, 20);
            this.subtotal.TabIndex = 18;
            // 
            // taxtotal
            // 
            this.taxtotal.Location = new System.Drawing.Point(288, 290);
            this.taxtotal.Name = "taxtotal";
            this.taxtotal.Size = new System.Drawing.Size(125, 20);
            this.taxtotal.TabIndex = 19;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(288, 317);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(125, 20);
            this.total.TabIndex = 20;
            // 
            // burgertext
            // 
            this.burgertext.AutoSize = true;
            this.burgertext.Location = new System.Drawing.Point(37, 100);
            this.burgertext.Name = "burgertext";
            this.burgertext.Size = new System.Drawing.Size(0, 13);
            this.burgertext.TabIndex = 3;
            // 
            // friestext1
            // 
            this.friestext1.AutoSize = true;
            this.friestext1.Location = new System.Drawing.Point(40, 134);
            this.friestext1.Name = "friestext1";
            this.friestext1.Size = new System.Drawing.Size(0, 13);
            this.friestext1.TabIndex = 4;
            // 
            // drinkstext1
            // 
            this.drinkstext1.AutoSize = true;
            this.drinkstext1.Location = new System.Drawing.Point(40, 173);
            this.drinkstext1.Name = "drinkstext1";
            this.drinkstext1.Size = new System.Drawing.Size(0, 13);
            this.drinkstext1.TabIndex = 5;
            // 
            // taxtext
            // 
            this.taxtext.AutoSize = true;
            this.taxtext.Location = new System.Drawing.Point(37, 237);
            this.taxtext.Name = "taxtext";
            this.taxtext.Size = new System.Drawing.Size(0, 13);
            this.taxtext.TabIndex = 6;
            // 
            // totaltext
            // 
            this.totaltext.AutoSize = true;
            this.totaltext.Location = new System.Drawing.Point(37, 258);
            this.totaltext.Name = "totaltext";
            this.totaltext.Size = new System.Drawing.Size(0, 13);
            this.totaltext.TabIndex = 7;
            // 
            // subtext
            // 
            this.subtext.AutoSize = true;
            this.subtext.Location = new System.Drawing.Point(37, 214);
            this.subtext.Name = "subtext";
            this.subtext.Size = new System.Drawing.Size(0, 13);
            this.subtext.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.total);
            this.Controls.Add(this.taxtotal);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.print);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drinksnumber);
            this.Controls.Add(this.friesnumber);
            this.Controls.Add(this.burgernumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       // private System.Windows.Forms.Label burgers;
       // private System.Windows.Forms.Label fries;
      // private System.Windows.Forms.Label drinks;
        private System.Windows.Forms.TextBox burgernumber;
        private System.Windows.Forms.TextBox friesnumber;
        private System.Windows.Forms.TextBox drinksnumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subtotal;
        private System.Windows.Forms.TextBox taxtotal;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label ordernumber;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label drinkstext1;
        private System.Windows.Forms.Label friestext1;
        private System.Windows.Forms.Label burgertext;
        private System.Windows.Forms.Label subtext;
        private System.Windows.Forms.Label totaltext;
        private System.Windows.Forms.Label taxtext;
    }
}

