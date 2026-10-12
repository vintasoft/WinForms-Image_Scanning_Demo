using System.Drawing;
using System.Windows.Forms;

namespace ImageScanningDemo
{
    partial class MainForm
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
            devicesLabel = new Label();
            devicesComboBox = new ComboBox();
            imagePixelTypesComboBox = new ComboBox();
            imagePixelTypeLabel = new Label();
            imageResolutionsComboBox = new ComboBox();
            imageResolutionLabel = new Label();
            pageSizesComboBox = new ComboBox();
            pageSizeLabel = new Label();
            scanImagesButton = new Button();
            scannedImagePictureBox = new PictureBox();
            previousImageButton = new Button();
            nextImageButton = new Button();
            saveImageButton = new Button();
            saveAllImagesButton = new Button();
            deleteAllImagesButton = new Button();
            imageEncodersComboBox = new ComboBox();
            imageEncoderLabel = new Label();
            showDeviceUiCheckBox = new CheckBox();
            scannedImagesInfoLabel = new Label();
            useDocumentFeederCheckBox = new CheckBox();
            useDuplexScanningCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)scannedImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // devicesLabel
            // 
            devicesLabel.AutoSize = true;
            devicesLabel.Location = new Point(12, 17);
            devicesLabel.Name = "devicesLabel";
            devicesLabel.Size = new Size(50, 15);
            devicesLabel.TabIndex = 0;
            devicesLabel.Text = "Devices:";
            // 
            // devicesComboBox
            // 
            devicesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            devicesComboBox.FormattingEnabled = true;
            devicesComboBox.Location = new Point(115, 12);
            devicesComboBox.Name = "devicesComboBox";
            devicesComboBox.Size = new Size(493, 23);
            devicesComboBox.TabIndex = 1;
            devicesComboBox.SelectedIndexChanged += devicesComboBox_SelectedIndexChanged;
            // 
            // imagePixelTypesComboBox
            // 
            imagePixelTypesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            imagePixelTypesComboBox.FormattingEnabled = true;
            imagePixelTypesComboBox.Items.AddRange(new object[] { "Black-white", "Grayscale", "RGB" });
            imagePixelTypesComboBox.Location = new Point(115, 70);
            imagePixelTypesComboBox.Name = "imagePixelTypesComboBox";
            imagePixelTypesComboBox.Size = new Size(180, 23);
            imagePixelTypesComboBox.TabIndex = 3;
            // 
            // imagePixelTypeLabel
            // 
            imagePixelTypeLabel.AutoSize = true;
            imagePixelTypeLabel.Location = new Point(12, 73);
            imagePixelTypeLabel.Name = "imagePixelTypeLabel";
            imagePixelTypeLabel.Size = new Size(97, 15);
            imagePixelTypeLabel.TabIndex = 2;
            imagePixelTypeLabel.Text = "Image pixel type:";
            // 
            // imageResolutionsComboBox
            // 
            imageResolutionsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            imageResolutionsComboBox.FormattingEnabled = true;
            imageResolutionsComboBox.Items.AddRange(new object[] { "200 dpi", "300 dpi", "600 dpi" });
            imageResolutionsComboBox.Location = new Point(429, 70);
            imageResolutionsComboBox.Name = "imageResolutionsComboBox";
            imageResolutionsComboBox.Size = new Size(180, 23);
            imageResolutionsComboBox.TabIndex = 5;
            // 
            // imageResolutionLabel
            // 
            imageResolutionLabel.AutoSize = true;
            imageResolutionLabel.Location = new Point(325, 73);
            imageResolutionLabel.Name = "imageResolutionLabel";
            imageResolutionLabel.Size = new Size(99, 15);
            imageResolutionLabel.TabIndex = 4;
            imageResolutionLabel.Text = "Image resolution:";
            // 
            // pageSizesComboBox
            // 
            pageSizesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pageSizesComboBox.FormattingEnabled = true;
            pageSizesComboBox.Items.AddRange(new object[] { "US Letter (8.5 x 11 inches)", "A5 (5.8 x 8.2 inches)", "A4 (8.2 x 11.6 inches)", "B5 dpi (6.9 x 9.8 inches)" });
            pageSizesComboBox.Location = new Point(115, 99);
            pageSizesComboBox.Name = "pageSizesComboBox";
            pageSizesComboBox.Size = new Size(180, 23);
            pageSizesComboBox.TabIndex = 7;
            // 
            // pageSizeLabel
            // 
            pageSizeLabel.AutoSize = true;
            pageSizeLabel.Location = new Point(12, 101);
            pageSizeLabel.Name = "pageSizeLabel";
            pageSizeLabel.Size = new Size(58, 15);
            pageSizeLabel.TabIndex = 6;
            pageSizeLabel.Text = "Page size:";
            // 
            // scanImagesButton
            // 
            scanImagesButton.Location = new Point(12, 134);
            scanImagesButton.Name = "scanImagesButton";
            scanImagesButton.Size = new Size(596, 37);
            scanImagesButton.TabIndex = 8;
            scanImagesButton.Text = "Scan images";
            scanImagesButton.UseVisualStyleBackColor = true;
            scanImagesButton.Click += scanImagesButton_Click;
            // 
            // scannedImagePictureBox
            // 
            scannedImagePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scannedImagePictureBox.BorderStyle = BorderStyle.FixedSingle;
            scannedImagePictureBox.Location = new Point(12, 184);
            scannedImagePictureBox.Name = "scannedImagePictureBox";
            scannedImagePictureBox.Size = new Size(596, 516);
            scannedImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            scannedImagePictureBox.TabIndex = 9;
            scannedImagePictureBox.TabStop = false;
            // 
            // previousImageButton
            // 
            previousImageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            previousImageButton.Location = new Point(12, 727);
            previousImageButton.Name = "previousImageButton";
            previousImageButton.Size = new Size(110, 23);
            previousImageButton.TabIndex = 10;
            previousImageButton.Text = "Previous image";
            previousImageButton.UseVisualStyleBackColor = true;
            previousImageButton.Click += previousImageButton_Click;
            // 
            // nextImageButton
            // 
            nextImageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nextImageButton.Location = new Point(134, 727);
            nextImageButton.Name = "nextImageButton";
            nextImageButton.Size = new Size(110, 23);
            nextImageButton.TabIndex = 11;
            nextImageButton.Text = "Next image";
            nextImageButton.UseVisualStyleBackColor = true;
            nextImageButton.Click += nextImageButton_Click;
            // 
            // saveImageButton
            // 
            saveImageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            saveImageButton.Location = new Point(258, 727);
            saveImageButton.Name = "saveImageButton";
            saveImageButton.Size = new Size(110, 23);
            saveImageButton.TabIndex = 12;
            saveImageButton.Text = "Save image";
            saveImageButton.UseVisualStyleBackColor = true;
            saveImageButton.Click += saveImageButton_Click;
            // 
            // saveAllImagesButton
            // 
            saveAllImagesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            saveAllImagesButton.Location = new Point(378, 727);
            saveAllImagesButton.Name = "saveAllImagesButton";
            saveAllImagesButton.Size = new Size(110, 23);
            saveAllImagesButton.TabIndex = 13;
            saveAllImagesButton.Text = "Save all images";
            saveAllImagesButton.UseVisualStyleBackColor = true;
            saveAllImagesButton.Click += saveAllImagesButton_Click;
            // 
            // deleteAllImagesButton
            // 
            deleteAllImagesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            deleteAllImagesButton.Location = new Point(499, 727);
            deleteAllImagesButton.Name = "deleteAllImagesButton";
            deleteAllImagesButton.Size = new Size(110, 23);
            deleteAllImagesButton.TabIndex = 14;
            deleteAllImagesButton.Text = "Delete all images";
            deleteAllImagesButton.UseVisualStyleBackColor = true;
            deleteAllImagesButton.Click += deleteAllImagesButton_Click;
            // 
            // imageEncodersComboBox
            // 
            imageEncodersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            imageEncodersComboBox.FormattingEnabled = true;
            imageEncodersComboBox.Items.AddRange(new object[] { "PNG", "JPG", "TIF", "PDF", "BMP" });
            imageEncodersComboBox.Location = new Point(428, 99);
            imageEncodersComboBox.Name = "imageEncodersComboBox";
            imageEncodersComboBox.Size = new Size(180, 23);
            imageEncodersComboBox.TabIndex = 16;
            // 
            // imageEncoderLabel
            // 
            imageEncoderLabel.AutoSize = true;
            imageEncoderLabel.Location = new Point(325, 101);
            imageEncoderLabel.Name = "imageEncoderLabel";
            imageEncoderLabel.Size = new Size(89, 15);
            imageEncoderLabel.TabIndex = 15;
            imageEncoderLabel.Text = "Image encoder:";
            // 
            // showDeviceUiCheckBox
            // 
            showDeviceUiCheckBox.AutoSize = true;
            showDeviceUiCheckBox.Location = new Point(16, 44);
            showDeviceUiCheckBox.Name = "showDeviceUiCheckBox";
            showDeviceUiCheckBox.Size = new Size(106, 19);
            showDeviceUiCheckBox.TabIndex = 17;
            showDeviceUiCheckBox.Text = "Show device UI";
            showDeviceUiCheckBox.UseVisualStyleBackColor = true;
            // 
            // scannedImagesInfoLabel
            // 
            scannedImagesInfoLabel.Location = new Point(258, 703);
            scannedImagesInfoLabel.Name = "scannedImagesInfoLabel";
            scannedImagesInfoLabel.Size = new Size(110, 21);
            scannedImagesInfoLabel.TabIndex = 18;
            scannedImagesInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // useDocumentFeederCheckBox
            // 
            useDocumentFeederCheckBox.AutoSize = true;
            useDocumentFeederCheckBox.Location = new Point(138, 44);
            useDocumentFeederCheckBox.Name = "useDocumentFeederCheckBox";
            useDocumentFeederCheckBox.Size = new Size(159, 19);
            useDocumentFeederCheckBox.TabIndex = 19;
            useDocumentFeederCheckBox.Text = "Use the document feeder";
            useDocumentFeederCheckBox.UseVisualStyleBackColor = true;
            // 
            // useDuplexScanningCheckBox
            // 
            useDuplexScanningCheckBox.AutoSize = true;
            useDuplexScanningCheckBox.Location = new Point(315, 44);
            useDuplexScanningCheckBox.Name = "useDuplexScanningCheckBox";
            useDuplexScanningCheckBox.Size = new Size(135, 19);
            useDuplexScanningCheckBox.TabIndex = 20;
            useDuplexScanningCheckBox.Text = "Use duplex scanning";
            useDuplexScanningCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 758);
            Controls.Add(useDuplexScanningCheckBox);
            Controls.Add(useDocumentFeederCheckBox);
            Controls.Add(scannedImagesInfoLabel);
            Controls.Add(showDeviceUiCheckBox);
            Controls.Add(imageEncodersComboBox);
            Controls.Add(imageEncoderLabel);
            Controls.Add(deleteAllImagesButton);
            Controls.Add(saveAllImagesButton);
            Controls.Add(saveImageButton);
            Controls.Add(nextImageButton);
            Controls.Add(previousImageButton);
            Controls.Add(scannedImagePictureBox);
            Controls.Add(scanImagesButton);
            Controls.Add(pageSizesComboBox);
            Controls.Add(pageSizeLabel);
            Controls.Add(imageResolutionsComboBox);
            Controls.Add(imageResolutionLabel);
            Controls.Add(imagePixelTypesComboBox);
            Controls.Add(imagePixelTypeLabel);
            Controls.Add(devicesComboBox);
            Controls.Add(devicesLabel);
            MinimumSize = new Size(637, 797);
            Name = "MainForm";
            Text = "VintaSoft Image Scanning Demo";
            FormClosing += Form1_FormClosing;
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)scannedImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label devicesLabel;
        private ComboBox devicesComboBox;
        private ComboBox imagePixelTypesComboBox;
        private Label imagePixelTypeLabel;
        private ComboBox imageResolutionsComboBox;
        private Label imageResolutionLabel;
        private ComboBox pageSizesComboBox;
        private Label pageSizeLabel;
        private Button scanImagesButton;
        private PictureBox scannedImagePictureBox;
        private Button previousImageButton;
        private Button nextImageButton;
        private Button saveImageButton;
        private Button saveAllImagesButton;
        private Button deleteAllImagesButton;
        private ComboBox imageEncodersComboBox;
        private Label imageEncoderLabel;
        private CheckBox showDeviceUiCheckBox;
        private Label scannedImagesInfoLabel;
        private CheckBox useDocumentFeederCheckBox;
        private CheckBox useDuplexScanningCheckBox;
    }
}
