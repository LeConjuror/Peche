using System.Windows.Forms;

namespace Peche
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
            this.intkey_comboBox = new System.Windows.Forms.ComboBox();
            this.fishStatus = new System.Windows.Forms.Label();
            this.intkeyLabel = new System.Windows.Forms.Label();
            this.hotkey_checkBox = new System.Windows.Forms.CheckBox();
            this.beep_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // intkey_comboBox
            // 
            this.intkey_comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.intkey_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intkey_comboBox.FormattingEnabled = true;
            this.intkey_comboBox.Location = new System.Drawing.Point(169, 203);
            this.intkey_comboBox.Name = "intkey_comboBox";
            this.intkey_comboBox.Size = new System.Drawing.Size(43, 24);
            this.intkey_comboBox.TabIndex = 1;
            this.intkey_comboBox.SelectedIndexChanged += new System.EventHandler(this.intkey_comboBox_SelectedIndexChanged);
            // 
            // fishStatus
            // 
            this.fishStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fishStatus.Font = new System.Drawing.Font("DS-Digital", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fishStatus.ForeColor = System.Drawing.Color.White;
            this.fishStatus.Location = new System.Drawing.Point(-48, 35);
            this.fishStatus.Name = "fishStatus";
            this.fishStatus.Size = new System.Drawing.Size(483, 34);
            this.fishStatus.TabIndex = 1;
            this.fishStatus.Text = "Press Hotkey to Start";
            this.fishStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intkeyLabel
            // 
            this.intkeyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.intkeyLabel.Font = new System.Drawing.Font("DS-Digital", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intkeyLabel.ForeColor = System.Drawing.Color.White;
            this.intkeyLabel.Location = new System.Drawing.Point(-45, 168);
            this.intkeyLabel.Name = "intkeyLabel";
            this.intkeyLabel.Size = new System.Drawing.Size(482, 22);
            this.intkeyLabel.TabIndex = 2;
            this.intkeyLabel.Text = "Interact Key: ";
            this.intkeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hotkey_checkBox
            // 
            this.hotkey_checkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hotkey_checkBox.AutoSize = true;
            this.hotkey_checkBox.Font = new System.Drawing.Font("DS-Digital", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotkey_checkBox.ForeColor = System.Drawing.Color.White;
            this.hotkey_checkBox.Location = new System.Drawing.Point(127, 94);
            this.hotkey_checkBox.Name = "hotkey_checkBox";
            this.hotkey_checkBox.Size = new System.Drawing.Size(130, 26);
            this.hotkey_checkBox.TabIndex = 3;
            this.hotkey_checkBox.Text = "HOTKEY: F2";
            this.hotkey_checkBox.UseVisualStyleBackColor = true;
            this.hotkey_checkBox.CheckedChanged += new System.EventHandler(this.hotkey_checkBox_CheckedChanged);
            // 
            // beep_checkBox
            // 
            this.beep_checkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.beep_checkBox.AutoSize = true;
            this.beep_checkBox.Checked = true;
            this.beep_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.beep_checkBox.Font = new System.Drawing.Font("DS-Digital", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beep_checkBox.ForeColor = System.Drawing.Color.White;
            this.beep_checkBox.Location = new System.Drawing.Point(127, 129);
            this.beep_checkBox.Name = "beep_checkBox";
            this.beep_checkBox.Size = new System.Drawing.Size(125, 26);
            this.beep_checkBox.TabIndex = 4;
            this.beep_checkBox.Text = "Beep Boop";
            this.beep_checkBox.UseVisualStyleBackColor = true;
            this.beep_checkBox.CheckedChanged += new System.EventHandler(this.beep_checkBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.beep_checkBox);
            this.Controls.Add(this.hotkey_checkBox);
            this.Controls.Add(this.intkeyLabel);
            this.Controls.Add(this.fishStatus);
            this.Controls.Add(this.intkey_comboBox);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "Peche Automatique";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox intkey_comboBox;
        private System.Windows.Forms.Label fishStatus;
        private System.Windows.Forms.Label intkeyLabel;
        private CheckBox hotkey_checkBox;
        private CheckBox beep_checkBox;
    }
}

