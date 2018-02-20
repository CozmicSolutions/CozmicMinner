namespace CozmicMinner.Forms
{
    using System.ComponentModel;
    using System.Windows.Forms;

    using DevExpress.LookAndFeel;
    using DevExpress.XtraEditors;

    using Telerik.WinControls.UI;

    partial class AddModifyMiningServer
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
            this.txtServerAddress = new Telerik.WinControls.UI.RadTextBox();
            this.txtServerPort = new Telerik.WinControls.UI.RadTextBox();
            this.drpMinnerType = new Telerik.WinControls.UI.RadDropDownList();
            this.lblServerAddress = new Telerik.WinControls.UI.RadLabel();
            this.lblServerType = new Telerik.WinControls.UI.RadLabel();
            this.lblServerRegion = new Telerik.WinControls.UI.RadLabel();
            this.lblServerPort = new Telerik.WinControls.UI.RadLabel();
            this.drpServerRegion = new Telerik.WinControls.UI.RadDropDownList();
            this.txtServerName = new Telerik.WinControls.UI.RadTextBox();
            this.lblServerName = new Telerik.WinControls.UI.RadLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtServerDesc = new Telerik.WinControls.UI.RadTextBox();
            this.lblServerDesc = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpMinnerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpServerRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerDesc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(221)))));
            this.txtServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerAddress.ForeColor = System.Drawing.Color.Black;
            this.txtServerAddress.Location = new System.Drawing.Point(130, 177);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.ReadOnly = true;
            this.txtServerAddress.Size = new System.Drawing.Size(306, 24);
            this.txtServerAddress.TabIndex = 23;
            this.txtServerAddress.ThemeName = "Office2007Black";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerPort.Location = new System.Drawing.Point(130, 78);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(54, 24);
            this.txtServerPort.TabIndex = 22;
            this.txtServerPort.Text = "444";
            this.txtServerPort.ThemeName = "Office2007Black";
            // 
            // drpMinnerType
            // 
            this.drpMinnerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpMinnerType.Location = new System.Drawing.Point(130, 144);
            this.drpMinnerType.Name = "drpMinnerType";
            this.drpMinnerType.Size = new System.Drawing.Size(306, 24);
            this.drpMinnerType.TabIndex = 21;
            this.drpMinnerType.ThemeName = "Office2007Black";
            // 
            // lblServerAddress
            // 
            this.lblServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerAddress.Location = new System.Drawing.Point(44, 180);
            this.lblServerAddress.Name = "lblServerAddress";
            this.lblServerAddress.Size = new System.Drawing.Size(80, 22);
            this.lblServerAddress.TabIndex = 20;
            this.lblServerAddress.Text = "Address :";
            // 
            // lblServerType
            // 
            this.lblServerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerType.Location = new System.Drawing.Point(22, 146);
            this.lblServerType.Name = "lblServerType";
            this.lblServerType.Size = new System.Drawing.Size(102, 22);
            this.lblServerType.TabIndex = 19;
            this.lblServerType.Text = "Miner Type :";
            // 
            // lblServerRegion
            // 
            this.lblServerRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerRegion.Location = new System.Drawing.Point(53, 112);
            this.lblServerRegion.Name = "lblServerRegion";
            this.lblServerRegion.Size = new System.Drawing.Size(71, 22);
            this.lblServerRegion.TabIndex = 18;
            this.lblServerRegion.Text = "Region :";
            // 
            // lblServerPort
            // 
            this.lblServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerPort.Location = new System.Drawing.Point(75, 78);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(49, 22);
            this.lblServerPort.TabIndex = 17;
            this.lblServerPort.Text = "Port :";
            // 
            // drpServerRegion
            // 
            this.drpServerRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpServerRegion.Location = new System.Drawing.Point(130, 111);
            this.drpServerRegion.Name = "drpServerRegion";
            this.drpServerRegion.Size = new System.Drawing.Size(306, 24);
            this.drpServerRegion.TabIndex = 16;
            this.drpServerRegion.ThemeName = "Office2007Black";
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerName.Location = new System.Drawing.Point(130, 12);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(306, 24);
            this.txtServerName.TabIndex = 15;
            this.txtServerName.ThemeName = "Office2007Black";
            this.txtServerName.TextChanged += new System.EventHandler(this.txtServerName_TextChanged);
            // 
            // lblServerName
            // 
            this.lblServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.Location = new System.Drawing.Point(7, 10);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(117, 22);
            this.lblServerName.TabIndex = 13;
            this.lblServerName.Text = "Server Name :";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(361, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Submit";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(130, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtServerDesc
            // 
            this.txtServerDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerDesc.Location = new System.Drawing.Point(130, 45);
            this.txtServerDesc.Name = "txtServerDesc";
            this.txtServerDesc.Size = new System.Drawing.Size(306, 24);
            this.txtServerDesc.TabIndex = 28;
            this.txtServerDesc.ThemeName = "Office2007Black";
            // 
            // lblServerDesc
            // 
            this.lblServerDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerDesc.Location = new System.Drawing.Point(21, 44);
            this.lblServerDesc.Name = "lblServerDesc";
            this.lblServerDesc.Size = new System.Drawing.Size(103, 22);
            this.lblServerDesc.TabIndex = 27;
            this.lblServerDesc.Text = "Description :";
            // 
            // AddModifyMiningServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 241);
            this.Controls.Add(this.txtServerDesc);
            this.Controls.Add(this.lblServerDesc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtServerAddress);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.drpMinnerType);
            this.Controls.Add(this.lblServerAddress);
            this.Controls.Add(this.lblServerType);
            this.Controls.Add(this.lblServerRegion);
            this.Controls.Add(this.lblServerPort);
            this.Controls.Add(this.drpServerRegion);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblServerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddModifyMiningServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddModifyMiningServer";
            ((System.ComponentModel.ISupportInitialize)(this.txtServerAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpMinnerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpServerRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblServerDesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadTextBox txtServerAddress;
        private RadTextBox txtServerPort;
        private RadDropDownList drpMinnerType;
        private RadLabel lblServerAddress;
        private RadLabel lblServerType;
        private RadLabel lblServerRegion;
        private RadLabel lblServerPort;
        private RadDropDownList drpServerRegion;
        private RadTextBox txtServerName;
        private RadLabel lblServerName;
        private ErrorProvider errorProvider;
        private DefaultLookAndFeel defaultLookAndFeel1;
        private SimpleButton btnCancel;
        private SimpleButton btnSave;
        private RadTextBox txtServerDesc;
        private RadLabel lblServerDesc;
    }
}