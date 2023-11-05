namespace CS311_Project3_RLV
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
            picPizza = new PictureBox();
            lblName = new Label();
            lblSize = new Label();
            lblCrust = new Label();
            lblOrderSummary = new Label();
            lblToppings = new Label();
            lblSubT = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            cboSizes = new ComboBox();
            grpCrust = new GroupBox();
            rdoThick = new RadioButton();
            rdoReg = new RadioButton();
            rdoThin = new RadioButton();
            ckbPepp = new CheckBox();
            ckbSausage = new CheckBox();
            ckbCanadianB = new CheckBox();
            ckbSItalianSausage = new CheckBox();
            ckbOnion = new CheckBox();
            ckbGreenPepp = new CheckBox();
            ckbBlackO = new CheckBox();
            ckbGreenO = new CheckBox();
            ckbBananaPepper = new CheckBox();
            ckbJalepeno = new CheckBox();
            ckbExtraCheese = new CheckBox();
            ckbMushroom = new CheckBox();
            btnCalculate = new Button();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            txtSubtotal = new TextBox();
            rtfOrderSummary = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)picPizza).BeginInit();
            grpCrust.SuspendLayout();
            SuspendLayout();
            // 
            // picPizza
            // 
            picPizza.BackColor = Color.SaddleBrown;
            picPizza.BackgroundImageLayout = ImageLayout.None;
            picPizza.BorderStyle = BorderStyle.Fixed3D;
            picPizza.Image = Properties.Resources.CS311_bearpizza;
            picPizza.Location = new Point(1208, 23);
            picPizza.Name = "picPizza";
            picPizza.Size = new Size(459, 479);
            picPizza.SizeMode = PictureBoxSizeMode.CenterImage;
            picPizza.TabIndex = 0;
            picPizza.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Berlin Sans FB", 63.8571434F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblName.Location = new Point(28, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(1154, 185);
            lblName.TabIndex = 1;
            lblName.Text = "The Bear's Slice";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Berlin Sans FB Demi", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblSize.Location = new Point(46, 299);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(78, 38);
            lblSize.TabIndex = 2;
            lblSize.Text = "Size:";
            // 
            // lblCrust
            // 
            lblCrust.AutoSize = true;
            lblCrust.Font = new Font("Berlin Sans FB Demi", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblCrust.Location = new Point(512, 299);
            lblCrust.Name = "lblCrust";
            lblCrust.Size = new Size(182, 38);
            lblCrust.TabIndex = 3;
            lblCrust.Text = "Crust Type:";
            // 
            // lblOrderSummary
            // 
            lblOrderSummary.AutoSize = true;
            lblOrderSummary.Font = new Font("Berlin Sans FB Demi", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderSummary.Location = new Point(46, 712);
            lblOrderSummary.Name = "lblOrderSummary";
            lblOrderSummary.Size = new Size(259, 38);
            lblOrderSummary.TabIndex = 4;
            lblOrderSummary.Text = "Order Summary:";
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Font = new Font("Berlin Sans FB Demi", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblToppings.Location = new Point(46, 422);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(159, 38);
            lblToppings.TabIndex = 5;
            lblToppings.Text = "Toppings:";
            // 
            // lblSubT
            // 
            lblSubT.AutoSize = true;
            lblSubT.Font = new Font("Berlin Sans FB Demi", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubT.Location = new Point(1269, 620);
            lblSubT.Name = "lblSubT";
            lblSubT.Size = new Size(145, 38);
            lblSubT.TabIndex = 6;
            lblSubT.Text = "Subtotal:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Berlin Sans FB Demi", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblTax.Location = new Point(1269, 695);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(77, 38);
            lblTax.TabIndex = 7;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Berlin Sans FB Demi", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(1269, 773);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 38);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total:";
            // 
            // cboSizes
            // 
            cboSizes.BackColor = SystemColors.Info;
            cboSizes.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboSizes.FormattingEnabled = true;
            cboSizes.Items.AddRange(new object[] { "Small", "Medium", "Large", "Xtra Large", "Ginormous" });
            cboSizes.Location = new Point(139, 302);
            cboSizes.Name = "cboSizes";
            cboSizes.Size = new Size(330, 39);
            cboSizes.TabIndex = 9;
            // 
            // grpCrust
            // 
            grpCrust.Controls.Add(rdoThick);
            grpCrust.Controls.Add(rdoReg);
            grpCrust.Controls.Add(rdoThin);
            grpCrust.Location = new Point(695, 295);
            grpCrust.Name = "grpCrust";
            grpCrust.Size = new Size(420, 53);
            grpCrust.TabIndex = 11;
            grpCrust.TabStop = false;
            grpCrust.Enter += label1_Click_1;
            // 
            // rdoThick
            // 
            rdoThick.AutoSize = true;
            rdoThick.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdoThick.Location = new Point(148, 7);
            rdoThick.Name = "rdoThick";
            rdoThick.Size = new Size(108, 37);
            rdoThick.TabIndex = 2;
            rdoThick.TabStop = true;
            rdoThick.Text = "Thick";
            rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoReg
            // 
            rdoReg.AutoSize = true;
            rdoReg.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdoReg.Location = new Point(278, 7);
            rdoReg.Name = "rdoReg";
            rdoReg.Size = new Size(139, 37);
            rdoReg.TabIndex = 1;
            rdoReg.TabStop = true;
            rdoReg.Text = "Regular";
            rdoReg.UseVisualStyleBackColor = true;
            rdoReg.CheckedChanged += Form1_Load;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdoThin.Location = new Point(21, 7);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(95, 37);
            rdoThin.TabIndex = 0;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin";
            rdoThin.UseVisualStyleBackColor = true;
            // 
            // ckbPepp
            // 
            ckbPepp.AutoSize = true;
            ckbPepp.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbPepp.Location = new Point(65, 485);
            ckbPepp.Name = "ckbPepp";
            ckbPepp.Size = new Size(174, 37);
            ckbPepp.TabIndex = 12;
            ckbPepp.Text = "Pepperoni";
            ckbPepp.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            ckbSausage.AutoSize = true;
            ckbSausage.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbSausage.Location = new Point(65, 543);
            ckbSausage.Name = "ckbSausage";
            ckbSausage.Size = new Size(141, 37);
            ckbSausage.TabIndex = 13;
            ckbSausage.Text = "Sausage";
            ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianB
            // 
            ckbCanadianB.AutoSize = true;
            ckbCanadianB.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbCanadianB.Location = new Point(65, 607);
            ckbCanadianB.Name = "ckbCanadianB";
            ckbCanadianB.Size = new Size(248, 37);
            ckbCanadianB.TabIndex = 14;
            ckbCanadianB.Text = "Canadian Bacon";
            ckbCanadianB.UseVisualStyleBackColor = true;
            ckbCanadianB.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // ckbSItalianSausage
            // 
            ckbSItalianSausage.AutoSize = true;
            ckbSItalianSausage.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbSItalianSausage.Location = new Point(329, 485);
            ckbSItalianSausage.Name = "ckbSItalianSausage";
            ckbSItalianSausage.Size = new Size(301, 37);
            ckbSItalianSausage.TabIndex = 15;
            ckbSItalianSausage.Text = "Spicy Italian Sausage";
            ckbSItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            ckbOnion.AutoSize = true;
            ckbOnion.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbOnion.Location = new Point(329, 548);
            ckbOnion.Name = "ckbOnion";
            ckbOnion.Size = new Size(118, 37);
            ckbOnion.TabIndex = 16;
            ckbOnion.Text = "Onion";
            ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepp
            // 
            ckbGreenPepp.AutoSize = true;
            ckbGreenPepp.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbGreenPepp.Location = new Point(329, 610);
            ckbGreenPepp.Name = "ckbGreenPepp";
            ckbGreenPepp.Size = new Size(218, 37);
            ckbGreenPepp.TabIndex = 17;
            ckbGreenPepp.Text = "Green Pepper";
            ckbGreenPepp.UseVisualStyleBackColor = true;
            // 
            // ckbBlackO
            // 
            ckbBlackO.AutoSize = true;
            ckbBlackO.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbBlackO.Location = new Point(650, 485);
            ckbBlackO.Name = "ckbBlackO";
            ckbBlackO.Size = new Size(194, 37);
            ckbBlackO.TabIndex = 18;
            ckbBlackO.Text = "Black Olives";
            ckbBlackO.UseVisualStyleBackColor = true;
            // 
            // ckbGreenO
            // 
            ckbGreenO.AutoSize = true;
            ckbGreenO.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbGreenO.Location = new Point(650, 544);
            ckbGreenO.Name = "ckbGreenO";
            ckbGreenO.Size = new Size(201, 37);
            ckbGreenO.TabIndex = 19;
            ckbGreenO.Text = "Green Olives";
            ckbGreenO.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPepper
            // 
            ckbBananaPepper.AutoSize = true;
            ckbBananaPepper.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbBananaPepper.Location = new Point(650, 606);
            ckbBananaPepper.Name = "ckbBananaPepper";
            ckbBananaPepper.Size = new Size(249, 37);
            ckbBananaPepper.TabIndex = 20;
            ckbBananaPepper.Text = "Banana Peppers";
            ckbBananaPepper.UseVisualStyleBackColor = true;
            // 
            // ckbJalepeno
            // 
            ckbJalepeno.AutoSize = true;
            ckbJalepeno.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbJalepeno.Location = new Point(912, 486);
            ckbJalepeno.Name = "ckbJalepeno";
            ckbJalepeno.Size = new Size(152, 37);
            ckbJalepeno.TabIndex = 21;
            ckbJalepeno.Text = "Jalepeno";
            ckbJalepeno.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            ckbExtraCheese.AutoSize = true;
            ckbExtraCheese.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbExtraCheese.Location = new Point(912, 545);
            ckbExtraCheese.Name = "ckbExtraCheese";
            ckbExtraCheese.Size = new Size(204, 37);
            ckbExtraCheese.TabIndex = 22;
            ckbExtraCheese.Text = "Extra Cheese";
            ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbMushroom
            // 
            ckbMushroom.AutoSize = true;
            ckbMushroom.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbMushroom.Location = new Point(912, 607);
            ckbMushroom.Name = "ckbMushroom";
            ckbMushroom.Size = new Size(172, 37);
            ckbMushroom.TabIndex = 23;
            ckbMushroom.Text = "Mushroom";
            ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.Info;
            btnCalculate.Font = new Font("Berlin Sans FB Demi", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Image = Properties.Resources.CS311_buttonpizza1;
            btnCalculate.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalculate.Location = new Point(1269, 862);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(360, 92);
            btnCalculate.TabIndex = 24;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtTax
            // 
            txtTax.BackColor = SystemColors.Info;
            txtTax.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTax.Location = new Point(1454, 705);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(175, 38);
            txtTax.TabIndex = 25;
            txtTax.TextChanged += txtTax_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.Info;
            txtTotal.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(1454, 773);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(175, 38);
            txtTotal.TabIndex = 26;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // txtSubtotal
            // 
            txtSubtotal.BackColor = SystemColors.Info;
            txtSubtotal.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubtotal.Location = new Point(1454, 620);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(175, 38);
            txtSubtotal.TabIndex = 27;
            txtSubtotal.TextChanged += txtSubtotal_TextChanged;
            // 
            // rtfOrderSummary
            // 
            rtfOrderSummary.BackColor = SystemColors.Info;
            rtfOrderSummary.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtfOrderSummary.Location = new Point(46, 773);
            rtfOrderSummary.Name = "rtfOrderSummary";
            rtfOrderSummary.Size = new Size(1111, 327);
            rtfOrderSummary.TabIndex = 28;
            rtfOrderSummary.Text = "";
            rtfOrderSummary.TextChanged += rtfOrderSummary_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1707, 1158);
            Controls.Add(rtfOrderSummary);
            Controls.Add(txtSubtotal);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(btnCalculate);
            Controls.Add(ckbMushroom);
            Controls.Add(ckbExtraCheese);
            Controls.Add(ckbJalepeno);
            Controls.Add(ckbBananaPepper);
            Controls.Add(ckbGreenO);
            Controls.Add(ckbBlackO);
            Controls.Add(ckbGreenPepp);
            Controls.Add(ckbOnion);
            Controls.Add(ckbSItalianSausage);
            Controls.Add(ckbCanadianB);
            Controls.Add(ckbSausage);
            Controls.Add(ckbPepp);
            Controls.Add(grpCrust);
            Controls.Add(cboSizes);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubT);
            Controls.Add(lblToppings);
            Controls.Add(lblOrderSummary);
            Controls.Add(lblCrust);
            Controls.Add(lblSize);
            Controls.Add(lblName);
            Controls.Add(picPizza);
            Name = "Form1";
            Text = "The Bear's Slice";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picPizza).EndInit();
            grpCrust.ResumeLayout(false);
            grpCrust.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        #endregion

        private PictureBox picPizza;
        private Label lblName;
        private Label lblSize;
        private Label lblCrust;
        private Label lblOrderSummary;
        private Label lblToppings;
        private Label lblSubT;
        private Label lblTax;
        private Label lblTotal;
        private ComboBox cboSizes;
        private GroupBox grpCrust;
        private RadioButton rdoThick;
        private RadioButton rdoReg;
        private RadioButton rdoThin;
        private CheckBox ckbPepp;
        private CheckBox ckbSausage;
        private CheckBox ckbCanadianB;
        private CheckBox ckbSItalianSausage;
        private CheckBox ckbOnion;
        private CheckBox ckbGreenPepp;
        private CheckBox ckbBlackO;
        private CheckBox ckbGreenO;
        private CheckBox ckbBananaPepper;
        private CheckBox ckbJalepeno;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbMushroom;
        private Button btnCalculate;
        private TextBox txtTax;
        private TextBox txtTotal;
        private TextBox txtSubtotal;
        private RichTextBox rtfOrderSummary;
    }
}