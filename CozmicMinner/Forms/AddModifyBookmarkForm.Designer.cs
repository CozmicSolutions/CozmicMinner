namespace CozmicMinner.Forms
{
    using System.ComponentModel;

    using DevExpress.LookAndFeel;
    using DevExpress.XtraEditors;

    using Telerik.WinControls.UI;

    partial class AddModifyBookmarkForm
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
            this.components = new System.ComponentModel.Container();
            this.lbBookmark = new Telerik.WinControls.UI.RadLabel();
            this.lblBookmarkAddress = new Telerik.WinControls.UI.RadLabel();
            this.txtBookmarkAddress = new Telerik.WinControls.UI.RadTextBox();
            this.cmbBookmarkIndex = new DevExpress.XtraEditors.ComboBoxEdit();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.cmbBookmarkAddress = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)this.lbBookmark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.lblBookmarkAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtBookmarkAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cmbBookmarkIndex.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cmbBookmarkAddress.Properties).BeginInit();
            this.SuspendLayout();

            // lbBookmark
            this.lbBookmark.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                12F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                (byte)(0));
            this.lbBookmark.Location = new System.Drawing.Point(5, 22);
            this.lbBookmark.Name = "lbBookmark";
            this.lbBookmark.Size = new System.Drawing.Size(94, 22);
            this.lbBookmark.TabIndex = 3;
            this.lbBookmark.Text = "Bookmark :";

            // lblBookmarkAddress
            this.lblBookmarkAddress.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                12F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                (byte)(0));
            this.lblBookmarkAddress.Location = new System.Drawing.Point(23, 57);
            this.lblBookmarkAddress.Name = "lblBookmarkAddress";
            this.lblBookmarkAddress.Size = new System.Drawing.Size(80, 22);
            this.lblBookmarkAddress.TabIndex = 5;
            this.lblBookmarkAddress.Text = "Address :";

            // txtBookmarkAddress
            this.txtBookmarkAddress.BackColor = System.Drawing.Color.FromArgb(
                (int)(((byte)(255))),
                (int)(((byte)(253))),
                (int)(((byte)(221))));
            this.txtBookmarkAddress.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                12F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                (byte)(0));
            this.txtBookmarkAddress.ForeColor = System.Drawing.Color.Black;
            this.txtBookmarkAddress.Location = new System.Drawing.Point(138, 57);
            this.txtBookmarkAddress.Name = "txtBookmarkAddress";
            this.txtBookmarkAddress.ReadOnly = true;
            this.txtBookmarkAddress.Size = new System.Drawing.Size(306, 24);
            this.txtBookmarkAddress.TabIndex = 12;
            this.txtBookmarkAddress.ThemeName = "Office2007Black";

            // cmbBookmarkIndex
            this.cmbBookmarkIndex.Location = new System.Drawing.Point(138, 92);
            this.cmbBookmarkIndex.Name = "cmbBookmarkIndex";
            this.cmbBookmarkIndex.Properties.Appearance.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                12F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                (byte)(0));
            this.cmbBookmarkIndex.Properties.Appearance.Options.UseFont = true;
            this.cmbBookmarkIndex.Properties.Buttons.AddRange(
                new[]
                    {
                        new DevExpress.XtraEditors.Controls.EditorButton(
                            DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
                    });
            this.cmbBookmarkIndex.Size = new System.Drawing.Size(100, 26);
            this.cmbBookmarkIndex.TabIndex = 13;

            // radLabel1
            this.radLabel1.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                12F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                (byte)(0));
            this.radLabel1.Location = new System.Drawing.Point(23, 91);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(59, 22);
            this.radLabel1.TabIndex = 14;
            this.radLabel1.Text = "Index :";

            // defaultLookAndFeel1
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Dark";

            // cmbBookmarkAddress
            this.cmbBookmarkAddress.Location = new System.Drawing.Point(138, 19);
            this.cmbBookmarkAddress.Name = "cmbBookmarkAddress";
            this.cmbBookmarkAddress.Properties.Appearance.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                12F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                (byte)(0));
            this.cmbBookmarkAddress.Properties.Appearance.Options.UseFont = true;
            this.cmbBookmarkAddress.Properties.Buttons.AddRange(
                new[]
                    {
                        new DevExpress.XtraEditors.Controls.EditorButton(
                            DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
                    });
            this.cmbBookmarkAddress.Size = new System.Drawing.Size(306, 26);
            this.cmbBookmarkAddress.TabIndex = 15;

            // AddModifyBookmarkForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 133);
            this.Controls.Add(this.cmbBookmarkAddress);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.cmbBookmarkIndex);
            this.Controls.Add(this.txtBookmarkAddress);
            this.Controls.Add(this.lblBookmarkAddress);
            this.Controls.Add(this.lbBookmark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddModifyBookmarkForm";
            this.Text = "AddModifyBookmarkForm";
            ((System.ComponentModel.ISupportInitialize)this.lbBookmark).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.lblBookmarkAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtBookmarkAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cmbBookmarkIndex.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cmbBookmarkAddress.Properties).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private RadLabel lbBookmark;
        private RadLabel lblBookmarkAddress;
        private RadLabel radLabel1;
        private RadTextBox txtBookmarkAddress;
        private ComboBoxEdit cmbBookmarkIndex;
        private DefaultLookAndFeel defaultLookAndFeel1;
        private ComboBoxEdit cmbBookmarkAddress;
    }
}