namespace CozmicMinner
{
    partial class AddModifyServerForm
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
            this.components = new System.ComponentModel.Container();
            this.lblServerName = new Telerik.WinControls.UI.RadLabel();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtServerName = new Telerik.WinControls.UI.RadTextBox();
            this.drpServerRegion = new Telerik.WinControls.UI.RadDropDownList();
            this.lblServerPort = new Telerik.WinControls.UI.RadLabel();
            this.lblServerRegion = new Telerik.WinControls.UI.RadLabel();
            this.lblServerAddress = new Telerik.WinControls.UI.RadLabel();
            this.lblServerType = new Telerik.WinControls.UI.RadLabel();
            this.drpMinnerType = new Telerik.WinControls.UI.RadDropDownList();
            this.txtServerPort = new Telerik.WinControls.UI.RadTextBox();
            this.txtServerAddress = new Telerik.WinControls.UI.RadTextBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lblServerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpServerRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpMinnerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            this.lblServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.Location = new System.Drawing.Point(32, 9);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(153, 28);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(389, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeName = "ControlDefault";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerName.Location = new System.Drawing.Point(193, 12);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(306, 29);
            this.txtServerName.TabIndex = 2;
            this.txtServerName.ThemeName = "Office2007Black";
            this.txtServerName.TextChanged += new System.EventHandler(this.txtServerName_TextChanged);
            // 
            // drpServerRegion
            // 
            this.drpServerRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpServerRegion.Location = new System.Drawing.Point(193, 82);
            this.drpServerRegion.Name = "drpServerRegion";
            this.drpServerRegion.Size = new System.Drawing.Size(306, 29);
            this.drpServerRegion.TabIndex = 3;
            this.drpServerRegion.ThemeName = "Office2007Black";
            // 
            // lblServerPort
            // 
            this.lblServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerPort.Location = new System.Drawing.Point(122, 48);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(63, 28);
            this.lblServerPort.TabIndex = 4;
            this.lblServerPort.Text = "Port :";
            // 
            // lblServerRegion
            // 
            this.lblServerRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerRegion.Location = new System.Drawing.Point(92, 83);
            this.lblServerRegion.Name = "lblServerRegion";
            this.lblServerRegion.Size = new System.Drawing.Size(93, 28);
            this.lblServerRegion.TabIndex = 6;
            this.lblServerRegion.Text = "Region :";
            // 
            // lblServerAddress
            // 
            this.lblServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerAddress.Location = new System.Drawing.Point(81, 152);
            this.lblServerAddress.Name = "lblServerAddress";
            this.lblServerAddress.Size = new System.Drawing.Size(104, 28);
            this.lblServerAddress.TabIndex = 8;
            this.lblServerAddress.Text = "Address :";
            // 
            // lblServerType
            // 
            this.lblServerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerType.Location = new System.Drawing.Point(51, 118);
            this.lblServerType.Name = "lblServerType";
            this.lblServerType.Size = new System.Drawing.Size(134, 28);
            this.lblServerType.TabIndex = 7;
            this.lblServerType.Text = "Miner Type :";
            // 
            // drpMinnerType
            // 
            this.drpMinnerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpMinnerType.Location = new System.Drawing.Point(193, 117);
            this.drpMinnerType.Name = "drpMinnerType";
            this.drpMinnerType.Size = new System.Drawing.Size(306, 29);
            this.drpMinnerType.TabIndex = 9;
            this.drpMinnerType.ThemeName = "Office2007Black";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerPort.Location = new System.Drawing.Point(193, 48);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(54, 29);
            this.txtServerPort.TabIndex = 10;
            this.txtServerPort.Text = "444";
            this.txtServerPort.ThemeName = "Office2007Black";
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.txtServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerAddress.ForeColor = System.Drawing.Color.Black;
            this.txtServerAddress.Location = new System.Drawing.Point(193, 152);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.ReadOnly = true;
            this.txtServerAddress.Size = new System.Drawing.Size(306, 29);
            this.txtServerAddress.TabIndex = 11;
            this.txtServerAddress.ThemeName = "Office2007Black";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(193, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeName = "ControlDefault";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddModifyServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 221);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtServerAddress);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.drpMinnerType);
            this.Controls.Add(this.lblServerAddress);
            this.Controls.Add(this.lblServerType);
            this.Controls.Add(this.lblServerRegion);
            this.Controls.Add(this.lblServerPort);
            this.Controls.Add(this.drpServerRegion);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblServerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddModifyServerForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Server";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.lblServerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpServerRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpMinnerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblServerName;
        private Telerik.WinControls.UI.RadLabel lblServerPort;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadTextBox txtServerName;
        private Telerik.WinControls.UI.RadDropDownList drpServerRegion;
        private Telerik.WinControls.UI.RadLabel lblServerRegion;
        private Telerik.WinControls.UI.RadLabel lblServerAddress;
        private Telerik.WinControls.UI.RadLabel lblServerType;
        private Telerik.WinControls.UI.RadTextBox txtServerPort;
        private Telerik.WinControls.UI.RadDropDownList drpMinnerType;
        private Telerik.WinControls.UI.RadTextBox txtServerAddress;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
