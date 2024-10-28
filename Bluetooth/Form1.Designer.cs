namespace Bluetooth
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFindDevices = new System.Windows.Forms.Button();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonSendFile = new System.Windows.Forms.Button();
            this.buttonPairDevices = new System.Windows.Forms.Button();
            this.listBoxDevices = new System.Windows.Forms.ListBox();
            this.labelNearbyDevices = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPairedDevice = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.listBoxServices = new System.Windows.Forms.ListBox();
            this.labelServices = new System.Windows.Forms.Label();
            this.labelTransferFiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFindDevices
            // 
            this.buttonFindDevices.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFindDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFindDevices.Location = new System.Drawing.Point(47, 481);
            this.buttonFindDevices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFindDevices.Name = "buttonFindDevices";
            this.buttonFindDevices.Size = new System.Drawing.Size(306, 42);
            this.buttonFindDevices.TabIndex = 0;
            this.buttonFindDevices.Text = "Find devices";
            this.buttonFindDevices.UseVisualStyleBackColor = false;
            this.buttonFindDevices.Click += new System.EventHandler(this.buttonFindDevices_Click);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSelectFile.Location = new System.Drawing.Point(378, 324);
            this.buttonSelectFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(108, 35);
            this.buttonSelectFile.TabIndex = 1;
            this.buttonSelectFile.Text = "Select file";
            this.buttonSelectFile.UseVisualStyleBackColor = false;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // buttonSendFile
            // 
            this.buttonSendFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSendFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSendFile.Location = new System.Drawing.Point(672, 369);
            this.buttonSendFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSendFile.Name = "buttonSendFile";
            this.buttonSendFile.Size = new System.Drawing.Size(108, 48);
            this.buttonSendFile.TabIndex = 2;
            this.buttonSendFile.Text = "Send file";
            this.buttonSendFile.UseVisualStyleBackColor = false;
            this.buttonSendFile.Click += new System.EventHandler(this.buttonSendFile_Click);
            // 
            // buttonPairDevices
            // 
            this.buttonPairDevices.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPairDevices.Enabled = false;
            this.buttonPairDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPairDevices.Location = new System.Drawing.Point(47, 527);
            this.buttonPairDevices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPairDevices.Name = "buttonPairDevices";
            this.buttonPairDevices.Size = new System.Drawing.Size(306, 42);
            this.buttonPairDevices.TabIndex = 3;
            this.buttonPairDevices.Text = "Pair";
            this.buttonPairDevices.UseVisualStyleBackColor = false;
            this.buttonPairDevices.Click += new System.EventHandler(this.buttonPairDevices_Click);
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.ItemHeight = 22;
            this.listBoxDevices.Location = new System.Drawing.Point(47, 68);
            this.listBoxDevices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.Size = new System.Drawing.Size(306, 400);
            this.listBoxDevices.TabIndex = 4;
            this.listBoxDevices.SelectedIndexChanged += new System.EventHandler(this.listBoxDevices_SelectedIndexChanged);
            // 
            // labelNearbyDevices
            // 
            this.labelNearbyDevices.AutoSize = true;
            this.labelNearbyDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNearbyDevices.Location = new System.Drawing.Point(126, 30);
            this.labelNearbyDevices.Name = "labelNearbyDevices";
            this.labelNearbyDevices.Size = new System.Drawing.Size(153, 25);
            this.labelNearbyDevices.TabIndex = 9;
            this.labelNearbyDevices.Text = "Nearby devices:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatus.Location = new System.Drawing.Point(403, 144);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(66, 22);
            this.labelStatus.TabIndex = 13;
            this.labelStatus.Text = "Status:";
            // 
            // labelPairedDevice
            // 
            this.labelPairedDevice.AutoSize = true;
            this.labelPairedDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPairedDevice.Location = new System.Drawing.Point(475, 144);
            this.labelPairedDevice.Name = "labelPairedDevice";
            this.labelPairedDevice.Size = new System.Drawing.Size(123, 22);
            this.labelPairedDevice.TabIndex = 14;
            this.labelPairedDevice.Text = "not connected";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFilePath.Location = new System.Drawing.Point(492, 328);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(288, 28);
            this.textBoxFilePath.TabIndex = 16;
            // 
            // listBoxServices
            // 
            this.listBoxServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxServices.FormattingEnabled = true;
            this.listBoxServices.ItemHeight = 22;
            this.listBoxServices.Location = new System.Drawing.Point(815, 68);
            this.listBoxServices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxServices.Name = "listBoxServices";
            this.listBoxServices.Size = new System.Drawing.Size(306, 400);
            this.listBoxServices.TabIndex = 17;
            // 
            // labelServices
            // 
            this.labelServices.AutoSize = true;
            this.labelServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelServices.Location = new System.Drawing.Point(817, 30);
            this.labelServices.Name = "labelServices";
            this.labelServices.Size = new System.Drawing.Size(297, 25);
            this.labelServices.TabIndex = 19;
            this.labelServices.Text = "Services available on the device:";
            // 
            // labelTransferFiles
            // 
            this.labelTransferFiles.AutoSize = true;
            this.labelTransferFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTransferFiles.Location = new System.Drawing.Point(539, 293);
            this.labelTransferFiles.Name = "labelTransferFiles";
            this.labelTransferFiles.Size = new System.Drawing.Size(120, 22);
            this.labelTransferFiles.TabIndex = 20;
            this.labelTransferFiles.Text = "Transfer files:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1165, 590);
            this.Controls.Add(this.labelTransferFiles);
            this.Controls.Add(this.labelServices);
            this.Controls.Add(this.listBoxServices);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.labelPairedDevice);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelNearbyDevices);
            this.Controls.Add(this.listBoxDevices);
            this.Controls.Add(this.buttonPairDevices);
            this.Controls.Add(this.buttonSendFile);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.buttonFindDevices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bluetooth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFindDevices;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Button buttonSendFile;
        private System.Windows.Forms.Button buttonPairDevices;
        private System.Windows.Forms.ListBox listBoxDevices;
        private System.Windows.Forms.Label labelNearbyDevices;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelPairedDevice;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.ListBox listBoxServices;
        private System.Windows.Forms.Label labelServices;
        private System.Windows.Forms.Label labelTransferFiles;
    }
}

