﻿namespace Character_Builder_Builder.FeatureForms
{
    partial class CollectionChoiceFeatureForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UniqueID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.AllowSameChoice = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Expression = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.basicFeature1 = new Character_Builder_Builder.FeatureForms.BasicFeature();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(2, 435);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(770, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "Okay";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(2, 422);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(770, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "In addition all keywords of the feature can be used as boolean values.";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(2, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(770, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Note: The Expression must result in a boolean value. The following values can be " +
    "used: Category, Name (lowercase) and Level (number) of the feature.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(2, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Unique ID: (to identify the choice in the character file)";
            // 
            // UniqueID
            // 
            this.UniqueID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UniqueID.Location = new System.Drawing.Point(2, 389);
            this.UniqueID.Name = "UniqueID";
            this.UniqueID.Size = new System.Drawing.Size(770, 20);
            this.UniqueID.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.AllowSameChoice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 21);
            this.panel1.TabIndex = 80;
            // 
            // Amount
            // 
            this.Amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Amount.Location = new System.Drawing.Point(0, 0);
            this.Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(563, 20);
            this.Amount.TabIndex = 60;
            this.Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AllowSameChoice
            // 
            this.AllowSameChoice.AutoSize = true;
            this.AllowSameChoice.Dock = System.Windows.Forms.DockStyle.Right;
            this.AllowSameChoice.Location = new System.Drawing.Point(563, 0);
            this.AllowSameChoice.Name = "AllowSameChoice";
            this.AllowSameChoice.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AllowSameChoice.Size = new System.Drawing.Size(207, 21);
            this.AllowSameChoice.TabIndex = 59;
            this.AllowSameChoice.Text = "Allow the same choice multiple times";
            this.AllowSameChoice.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(2, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Condition: (NCalc Expression)";
            // 
            // Expression
            // 
            this.Expression.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Expression.Location = new System.Drawing.Point(2, 322);
            this.Expression.Name = "Expression";
            this.Expression.Size = new System.Drawing.Size(770, 20);
            this.Expression.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(2, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 13);
            this.label9.TabIndex = 81;
            this.label9.Text = "Amount of Selectable Features";
            // 
            // basicFeature1
            // 
            this.basicFeature1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.basicFeature1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicFeature1.Feature = null;
            this.basicFeature1.Location = new System.Drawing.Point(2, 2);
            this.basicFeature1.Name = "basicFeature1";
            this.basicFeature1.Size = new System.Drawing.Size(770, 307);
            this.basicFeature1.TabIndex = 84;
            // 
            // CollectionChoiceFeatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(774, 462);
            this.Controls.Add(this.basicFeature1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Expression);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UniqueID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "CollectionChoiceFeatureForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Feature Collection Choice Feature";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UniqueID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.CheckBox AllowSameChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Expression;
        private System.Windows.Forms.Label label9;
        private BasicFeature basicFeature1;
    }
}