﻿namespace Character_Builder_Builder
{
    partial class WeaponForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.preview = new System.Windows.Forms.WebBrowser();
            this.userControl11 = new Character_Builder_Builder.UserControl1();
            this.DamageType = new System.Windows.Forms.ComboBox();
            this.basicItem1 = new Character_Builder_Builder.ItemForms.BasicItem();
            this.label2 = new System.Windows.Forms.Label();
            this.Damage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.abort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(1, 492);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 30);
            this.panel1.TabIndex = 0;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save.Location = new System.Drawing.Point(863, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save && Exit";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // abort
            // 
            this.abort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.abort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abort.Location = new System.Drawing.Point(944, 4);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(78, 23);
            this.abort.TabIndex = 0;
            this.abort.Text = "Exit";
            this.abort.UseVisualStyleBackColor = true;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // preview
            // 
            this.preview.CausesValidation = false;
            this.preview.Dock = System.Windows.Forms.DockStyle.Right;
            this.preview.Location = new System.Drawing.Point(776, 24);
            this.preview.MinimumSize = new System.Drawing.Size(20, 20);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(250, 468);
            this.preview.TabIndex = 10;
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControl11.Editor = null;
            this.userControl11.Location = new System.Drawing.Point(1, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1025, 24);
            this.userControl11.TabIndex = 9;
            // 
            // DamageType
            // 
            this.DamageType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DamageType.FormattingEnabled = true;
            this.DamageType.Items.AddRange(new object[] {
            "bludgeoning",
            "piercing",
            "slashing"});
            this.DamageType.Location = new System.Drawing.Point(1, 471);
            this.DamageType.Name = "DamageType";
            this.DamageType.Size = new System.Drawing.Size(775, 21);
            this.DamageType.TabIndex = 18;
            this.DamageType.SelectedIndexChanged += new System.EventHandler(this.DamageType_SelectedIndexChanged);
            this.DamageType.TextChanged += new System.EventHandler(this.DamageType_TextChanged);
            this.DamageType.Enter += new System.EventHandler(this.showPreview);
            // 
            // basicItem1
            // 
            this.basicItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicItem1.HistoryManager = null;
            this.basicItem1.Item = null;
            this.basicItem1.Location = new System.Drawing.Point(1, 24);
            this.basicItem1.Name = "basicItem1";
            this.basicItem1.Size = new System.Drawing.Size(775, 401);
            this.basicItem1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(1, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Damage:";
            // 
            // Damage
            // 
            this.Damage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Damage.Location = new System.Drawing.Point(1, 438);
            this.Damage.Name = "Damage";
            this.Damage.Size = new System.Drawing.Size(775, 20);
            this.Damage.TabIndex = 20;
            this.Damage.TextChanged += new System.EventHandler(this.Damage_TextChanged);
            this.Damage.Enter += new System.EventHandler(this.showPreview);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(1, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Damagetype:";
            // 
            // WeaponForm
            // 
            this.AcceptButton = this.save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.abort;
            this.ClientSize = new System.Drawing.Size(1027, 522);
            this.Controls.Add(this.basicItem1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Damage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DamageType);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.Name = "WeaponForm";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Weapon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RaceForm_FormClosing);
            this.Shown += new System.EventHandler(this.RaceForm_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button abort;
        private UserControl1 userControl11;
        private System.Windows.Forms.WebBrowser preview;
        private System.Windows.Forms.ComboBox DamageType;
        private ItemForms.BasicItem basicItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Damage;
        private System.Windows.Forms.Label label1;
    }
}