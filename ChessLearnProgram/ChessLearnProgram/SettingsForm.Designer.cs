﻿using System.ComponentModel;
using System.Windows.Forms;

namespace ChessLearnProgram
{
    public sealed partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.SettingsLabel      = new System.Windows.Forms.Label();
            this.ValidMovesCheckBox = new System.Windows.Forms.CheckBox();
            this.MoveSoundsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsLabel.AutoSize  = true;
            this.SettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsLabel.Font      = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsLabel.Location  = new System.Drawing.Point(307, 25);
            this.SettingsLabel.Name      = "SettingsLabel";
            this.SettingsLabel.Size      = new System.Drawing.Size(217, 46);
            this.SettingsLabel.TabIndex  = 0;
            this.SettingsLabel.Text      = "Настройки";
            // 
            // ValidMovesCheckBox
            // 
            this.ValidMovesCheckBox.BackColor               =  System.Drawing.Color.BurlyWood;
            this.ValidMovesCheckBox.BackgroundImage         =  ((System.Drawing.Image)(resources.GetObject("ValidMovesCheckBox.BackgroundImage")));
            this.ValidMovesCheckBox.BackgroundImageLayout   =  System.Windows.Forms.ImageLayout.Stretch;
            this.ValidMovesCheckBox.CheckAlign              =  System.Drawing.ContentAlignment.MiddleRight;
            this.ValidMovesCheckBox.Font                    =  new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValidMovesCheckBox.Location                =  new System.Drawing.Point(294, 167);
            this.ValidMovesCheckBox.Name                    =  "ValidMovesCheckBox";
            this.ValidMovesCheckBox.Size                    =  new System.Drawing.Size(239, 81);
            this.ValidMovesCheckBox.TabIndex                =  17;
            this.ValidMovesCheckBox.Text                    =  "Показывать допустимые ходы";
            this.ValidMovesCheckBox.TextAlign               =  System.Drawing.ContentAlignment.MiddleCenter;
            this.ValidMovesCheckBox.UseVisualStyleBackColor =  false;
            this.ValidMovesCheckBox.CheckedChanged          += new System.EventHandler(this.ValidMovesCheckBox_CheckedChanged);
            // 
            // MoveSoundsCheckBox
            // 
            this.MoveSoundsCheckBox.BackColor               =  System.Drawing.Color.BurlyWood;
            this.MoveSoundsCheckBox.BackgroundImage         =  ((System.Drawing.Image)(resources.GetObject("MoveSoundsCheckBox.BackgroundImage")));
            this.MoveSoundsCheckBox.BackgroundImageLayout   =  System.Windows.Forms.ImageLayout.Stretch;
            this.MoveSoundsCheckBox.CheckAlign              =  System.Drawing.ContentAlignment.MiddleRight;
            this.MoveSoundsCheckBox.Font                    =  new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveSoundsCheckBox.Location                =  new System.Drawing.Point(294, 294);
            this.MoveSoundsCheckBox.Name                    =  "MoveSoundsCheckBox";
            this.MoveSoundsCheckBox.Size                    =  new System.Drawing.Size(239, 81);
            this.MoveSoundsCheckBox.TabIndex                =  18;
            this.MoveSoundsCheckBox.Text                    =  "Включить звук хода";
            this.MoveSoundsCheckBox.TextAlign               =  System.Drawing.ContentAlignment.MiddleCenter;
            this.MoveSoundsCheckBox.UseVisualStyleBackColor =  false;
            this.MoveSoundsCheckBox.CheckedChanged          += new System.EventHandler(this.MoveSoundsCheckBox_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage     = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize          = new System.Drawing.Size(821, 559);
            this.Controls.Add(this.MoveSoundsCheckBox);
            this.Controls.Add(this.ValidMovesCheckBox);
            this.Controls.Add(this.SettingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon            = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name            = "SettingsForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Настройки";
            this.TopMost         = true;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label    SettingsLabel;
        private System.Windows.Forms.CheckBox ValidMovesCheckBox;
        private System.Windows.Forms.CheckBox MoveSoundsCheckBox;
    }
}