namespace tracm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabUpload = new System.Windows.Forms.TabPage();
            this.TranscodeIndicator = new System.Windows.Forms.Label();
            this.QueueError = new System.Windows.Forms.Label();
            this.AddToQueue = new System.Windows.Forms.Button();
            this.Length = new System.Windows.Forms.TextBox();
            this.Cue = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.Producer = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.Inentifier = new System.Windows.Forms.TextBox();
            this.VideoFileButton = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVideoFile = new System.Windows.Forms.Label();
            this.tabDownload = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.cablecastGroup = new System.Windows.Forms.GroupBox();
            this.cablecastFormats = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cablecastLocation = new System.Windows.Forms.ComboBox();
            this.useCablecast = new System.Windows.Forms.CheckBox();
            this.RefreshQueue = new System.Windows.Forms.Button();
            this.tabQueue = new System.Windows.Forms.TabPage();
            this.QueueErrorLabel = new System.Windows.Forms.Label();
            this.DeleteQueueItem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.FileBrowse = new System.Windows.Forms.Button();
            this.DownloadPath = new System.Windows.Forms.TextBox();
            this.labelDownloadFolder = new System.Windows.Forms.Label();
            this.groupBoxCablecast = new System.Windows.Forms.GroupBox();
            this.CablecastServer = new System.Windows.Forms.TextBox();
            this.CablecastPassword = new System.Windows.Forms.TextBox();
            this.labelCablecastServer = new System.Windows.Forms.Label();
            this.CablecastUsername = new System.Windows.Forms.TextBox();
            this.labelCablecastUsername = new System.Windows.Forms.Label();
            this.labelCablecastPassword = new System.Windows.Forms.Label();
            this.groupBoxACM = new System.Windows.Forms.GroupBox();
            this.passiveFTP = new System.Windows.Forms.CheckBox();
            this.ACMServer = new System.Windows.Forms.TextBox();
            this.ACMPassword = new System.Windows.Forms.TextBox();
            this.labelACMServer = new System.Windows.Forms.Label();
            this.ACMUsername = new System.Windows.Forms.TextBox();
            this.labelACMUsername = new System.Windows.Forms.Label();
            this.labelACMPassword = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabUpload.SuspendLayout();
            this.tabDownload.SuspendLayout();
            this.cablecastGroup.SuspendLayout();
            this.tabQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.groupBoxCablecast.SuspendLayout();
            this.groupBoxACM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabWelcome);
            this.tabControl1.Controls.Add(this.tabUpload);
            this.tabControl1.Controls.Add(this.tabDownload);
            this.tabControl1.Controls.Add(this.tabQueue);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 354);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabWelcome
            // 
            this.tabWelcome.Controls.Add(this.richTextBox1);
            this.tabWelcome.Controls.Add(this.pictureBox2);
            this.tabWelcome.Controls.Add(this.pictureBox1);
            this.tabWelcome.Location = new System.Drawing.Point(4, 22);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabWelcome.Size = new System.Drawing.Size(448, 328);
            this.tabWelcome.TabIndex = 0;
            this.tabWelcome.Text = "Welcome";
            this.tabWelcome.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(35, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabUpload
            // 
            this.tabUpload.Controls.Add(this.TranscodeIndicator);
            this.tabUpload.Controls.Add(this.QueueError);
            this.tabUpload.Controls.Add(this.AddToQueue);
            this.tabUpload.Controls.Add(this.Length);
            this.tabUpload.Controls.Add(this.Cue);
            this.tabUpload.Controls.Add(this.Description);
            this.tabUpload.Controls.Add(this.Producer);
            this.tabUpload.Controls.Add(this.Genre);
            this.tabUpload.Controls.Add(this.Subject);
            this.tabUpload.Controls.Add(this.Title);
            this.tabUpload.Controls.Add(this.Inentifier);
            this.tabUpload.Controls.Add(this.VideoFileButton);
            this.tabUpload.Controls.Add(this.FilePath);
            this.tabUpload.Controls.Add(this.label8);
            this.tabUpload.Controls.Add(this.label7);
            this.tabUpload.Controls.Add(this.label6);
            this.tabUpload.Controls.Add(this.label5);
            this.tabUpload.Controls.Add(this.label4);
            this.tabUpload.Controls.Add(this.label3);
            this.tabUpload.Controls.Add(this.label2);
            this.tabUpload.Controls.Add(this.label1);
            this.tabUpload.Controls.Add(this.labelVideoFile);
            this.tabUpload.Location = new System.Drawing.Point(4, 22);
            this.tabUpload.Name = "tabUpload";
            this.tabUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpload.Size = new System.Drawing.Size(448, 370);
            this.tabUpload.TabIndex = 1;
            this.tabUpload.Text = "Upload";
            this.tabUpload.UseVisualStyleBackColor = true;
            // 
            // TranscodeIndicator
            // 
            this.TranscodeIndicator.AutoSize = true;
            this.TranscodeIndicator.Location = new System.Drawing.Point(9, 299);
            this.TranscodeIndicator.Name = "TranscodeIndicator";
            this.TranscodeIndicator.Size = new System.Drawing.Size(0, 13);
            this.TranscodeIndicator.TabIndex = 22;
            // 
            // QueueError
            // 
            this.QueueError.AutoSize = true;
            this.QueueError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QueueError.Location = new System.Drawing.Point(12, 301);
            this.QueueError.Name = "QueueError";
            this.QueueError.Size = new System.Drawing.Size(0, 13);
            this.QueueError.TabIndex = 20;
            // 
            // AddToQueue
            // 
            this.AddToQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToQueue.Location = new System.Drawing.Point(341, 294);
            this.AddToQueue.Name = "AddToQueue";
            this.AddToQueue.Size = new System.Drawing.Size(98, 23);
            this.AddToQueue.TabIndex = 19;
            this.AddToQueue.Text = "Add to Queue";
            this.AddToQueue.UseVisualStyleBackColor = true;
            this.AddToQueue.Click += new System.EventHandler(this.AddToQueue_Click);
            // 
            // Length
            // 
            this.Length.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Length.Location = new System.Drawing.Point(72, 267);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(112, 20);
            this.Length.TabIndex = 18;
            // 
            // Cue
            // 
            this.Cue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Cue.Location = new System.Drawing.Point(72, 241);
            this.Cue.Name = "Cue";
            this.Cue.Size = new System.Drawing.Size(112, 20);
            this.Cue.TabIndex = 17;
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.Location = new System.Drawing.Point(72, 175);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(368, 60);
            this.Description.TabIndex = 16;
            // 
            // Producer
            // 
            this.Producer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Producer.Location = new System.Drawing.Point(72, 146);
            this.Producer.Name = "Producer";
            this.Producer.Size = new System.Drawing.Size(368, 20);
            this.Producer.TabIndex = 15;
            // 
            // Genre
            // 
            this.Genre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Genre.Location = new System.Drawing.Point(72, 120);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(368, 20);
            this.Genre.TabIndex = 14;
            // 
            // Subject
            // 
            this.Subject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Subject.Location = new System.Drawing.Point(72, 94);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(368, 20);
            this.Subject.TabIndex = 13;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Location = new System.Drawing.Point(72, 68);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(368, 20);
            this.Title.TabIndex = 12;
            // 
            // Inentifier
            // 
            this.Inentifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Inentifier.Location = new System.Drawing.Point(72, 42);
            this.Inentifier.Name = "Inentifier";
            this.Inentifier.Size = new System.Drawing.Size(112, 20);
            this.Inentifier.TabIndex = 11;
            this.Inentifier.Validating += new System.ComponentModel.CancelEventHandler(this.Inentifier_Validating);
            // 
            // VideoFileButton
            // 
            this.VideoFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoFileButton.Location = new System.Drawing.Point(365, 14);
            this.VideoFileButton.Name = "VideoFileButton";
            this.VideoFileButton.Size = new System.Drawing.Size(75, 23);
            this.VideoFileButton.TabIndex = 10;
            this.VideoFileButton.Text = "Browse...";
            this.VideoFileButton.UseVisualStyleBackColor = true;
            this.VideoFileButton.Click += new System.EventHandler(this.VideoFileButton_Click);
            // 
            // FilePath
            // 
            this.FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePath.Enabled = false;
            this.FilePath.Location = new System.Drawing.Point(72, 16);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(287, 20);
            this.FilePath.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Length:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cue:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Producer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ShowID:";
            // 
            // labelVideoFile
            // 
            this.labelVideoFile.AutoSize = true;
            this.labelVideoFile.Location = new System.Drawing.Point(8, 19);
            this.labelVideoFile.Name = "labelVideoFile";
            this.labelVideoFile.Size = new System.Drawing.Size(56, 13);
            this.labelVideoFile.TabIndex = 0;
            this.labelVideoFile.Text = "Video File:";
            // 
            // tabDownload
            // 
            this.tabDownload.Controls.Add(this.label11);
            this.tabDownload.Controls.Add(this.cablecastGroup);
            this.tabDownload.Controls.Add(this.useCablecast);
            this.tabDownload.Controls.Add(this.RefreshQueue);
            this.tabDownload.Location = new System.Drawing.Point(4, 22);
            this.tabDownload.Name = "tabDownload";
            this.tabDownload.Size = new System.Drawing.Size(448, 370);
            this.tabDownload.TabIndex = 4;
            this.tabDownload.Text = "Download";
            this.tabDownload.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(172, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 6;
            // 
            // cablecastGroup
            // 
            this.cablecastGroup.Controls.Add(this.cablecastFormats);
            this.cablecastGroup.Controls.Add(this.label10);
            this.cablecastGroup.Controls.Add(this.label9);
            this.cablecastGroup.Controls.Add(this.cablecastLocation);
            this.cablecastGroup.Enabled = false;
            this.cablecastGroup.Location = new System.Drawing.Point(8, 39);
            this.cablecastGroup.Name = "cablecastGroup";
            this.cablecastGroup.Size = new System.Drawing.Size(432, 100);
            this.cablecastGroup.TabIndex = 5;
            this.cablecastGroup.TabStop = false;
            this.cablecastGroup.Text = "Cablecast Options";
            // 
            // cablecastFormats
            // 
            this.cablecastFormats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cablecastFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cablecastFormats.FormattingEnabled = true;
            this.cablecastFormats.Location = new System.Drawing.Point(63, 46);
            this.cablecastFormats.Name = "cablecastFormats";
            this.cablecastFormats.Size = new System.Drawing.Size(363, 21);
            this.cablecastFormats.TabIndex = 3;
            this.cablecastFormats.SelectedIndexChanged += new System.EventHandler(this.cablecastFormats_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Format:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Location:";
            // 
            // cablecastLocation
            // 
            this.cablecastLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cablecastLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cablecastLocation.FormattingEnabled = true;
            this.cablecastLocation.Location = new System.Drawing.Point(63, 19);
            this.cablecastLocation.Name = "cablecastLocation";
            this.cablecastLocation.Size = new System.Drawing.Size(363, 21);
            this.cablecastLocation.TabIndex = 0;
            this.cablecastLocation.SelectedIndexChanged += new System.EventHandler(this.cablecastLocation_SelectedIndexChanged);
            // 
            // useCablecast
            // 
            this.useCablecast.AutoSize = true;
            this.useCablecast.Enabled = false;
            this.useCablecast.Location = new System.Drawing.Point(8, 16);
            this.useCablecast.Name = "useCablecast";
            this.useCablecast.Size = new System.Drawing.Size(142, 17);
            this.useCablecast.TabIndex = 4;
            this.useCablecast.Text = "Add Shows to Cablecast";
            this.useCablecast.UseVisualStyleBackColor = true;
            this.useCablecast.CheckedChanged += new System.EventHandler(this.useCablecast_CheckedChanged);
            this.useCablecast.EnabledChanged += new System.EventHandler(this.useCablecast_EnabledChanged);
            // 
            // RefreshQueue
            // 
            this.RefreshQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshQueue.Location = new System.Drawing.Point(313, 297);
            this.RefreshQueue.Name = "RefreshQueue";
            this.RefreshQueue.Size = new System.Drawing.Size(127, 23);
            this.RefreshQueue.TabIndex = 3;
            this.RefreshQueue.Text = "Refresh SCS Queue";
            this.RefreshQueue.UseVisualStyleBackColor = true;
            this.RefreshQueue.Click += new System.EventHandler(this.RefreshQueue_Click);
            // 
            // tabQueue
            // 
            this.tabQueue.Controls.Add(this.QueueErrorLabel);
            this.tabQueue.Controls.Add(this.DeleteQueueItem);
            this.tabQueue.Controls.Add(this.dataGridView1);
            this.tabQueue.Location = new System.Drawing.Point(4, 22);
            this.tabQueue.Name = "tabQueue";
            this.tabQueue.Size = new System.Drawing.Size(448, 370);
            this.tabQueue.TabIndex = 2;
            this.tabQueue.Text = "Queue";
            this.tabQueue.UseVisualStyleBackColor = true;
            // 
            // QueueErrorLabel
            // 
            this.QueueErrorLabel.AutoSize = true;
            this.QueueErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QueueErrorLabel.Location = new System.Drawing.Point(9, 311);
            this.QueueErrorLabel.Name = "QueueErrorLabel";
            this.QueueErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.QueueErrorLabel.TabIndex = 3;
            // 
            // DeleteQueueItem
            // 
            this.DeleteQueueItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteQueueItem.Location = new System.Drawing.Point(314, 302);
            this.DeleteQueueItem.Name = "DeleteQueueItem";
            this.DeleteQueueItem.Size = new System.Drawing.Size(126, 23);
            this.DeleteQueueItem.TabIndex = 1;
            this.DeleteQueueItem.Text = "Remove Completed";
            this.DeleteQueueItem.UseVisualStyleBackColor = true;
            this.DeleteQueueItem.Click += new System.EventHandler(this.DeleteQueueItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(448, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.groupBoxFiles);
            this.tabSettings.Controls.Add(this.groupBoxCablecast);
            this.tabSettings.Controls.Add(this.groupBoxACM);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(448, 370);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiles.Controls.Add(this.FileBrowse);
            this.groupBoxFiles.Controls.Add(this.DownloadPath);
            this.groupBoxFiles.Controls.Add(this.labelDownloadFolder);
            this.groupBoxFiles.Location = new System.Drawing.Point(6, 249);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(434, 48);
            this.groupBoxFiles.TabIndex = 8;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // FileBrowse
            // 
            this.FileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileBrowse.Location = new System.Drawing.Point(353, 16);
            this.FileBrowse.Name = "FileBrowse";
            this.FileBrowse.Size = new System.Drawing.Size(75, 23);
            this.FileBrowse.TabIndex = 4;
            this.FileBrowse.Text = "Browse...";
            this.FileBrowse.UseVisualStyleBackColor = true;
            this.FileBrowse.Click += new System.EventHandler(this.FileBrowse_Click);
            // 
            // DownloadPath
            // 
            this.DownloadPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadPath.Location = new System.Drawing.Point(105, 19);
            this.DownloadPath.Name = "DownloadPath";
            this.DownloadPath.Size = new System.Drawing.Size(241, 20);
            this.DownloadPath.TabIndex = 3;
            this.DownloadPath.Validating += new System.ComponentModel.CancelEventHandler(this.DownloadPath_Validating);
            // 
            // labelDownloadFolder
            // 
            this.labelDownloadFolder.AutoSize = true;
            this.labelDownloadFolder.Location = new System.Drawing.Point(9, 22);
            this.labelDownloadFolder.Name = "labelDownloadFolder";
            this.labelDownloadFolder.Size = new System.Drawing.Size(90, 13);
            this.labelDownloadFolder.TabIndex = 0;
            this.labelDownloadFolder.Text = "Download Folder:";
            // 
            // groupBoxCablecast
            // 
            this.groupBoxCablecast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCablecast.Controls.Add(this.CablecastServer);
            this.groupBoxCablecast.Controls.Add(this.CablecastPassword);
            this.groupBoxCablecast.Controls.Add(this.labelCablecastServer);
            this.groupBoxCablecast.Controls.Add(this.CablecastUsername);
            this.groupBoxCablecast.Controls.Add(this.labelCablecastUsername);
            this.groupBoxCablecast.Controls.Add(this.labelCablecastPassword);
            this.groupBoxCablecast.Location = new System.Drawing.Point(6, 141);
            this.groupBoxCablecast.Name = "groupBoxCablecast";
            this.groupBoxCablecast.Size = new System.Drawing.Size(434, 102);
            this.groupBoxCablecast.TabIndex = 7;
            this.groupBoxCablecast.TabStop = false;
            this.groupBoxCablecast.Text = "Cablecast";
            // 
            // CablecastServer
            // 
            this.CablecastServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CablecastServer.Location = new System.Drawing.Point(105, 19);
            this.CablecastServer.Name = "CablecastServer";
            this.CablecastServer.Size = new System.Drawing.Size(322, 20);
            this.CablecastServer.TabIndex = 3;
            this.CablecastServer.Validating += new System.ComponentModel.CancelEventHandler(this.CablecastServer_Validating);
            // 
            // CablecastPassword
            // 
            this.CablecastPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CablecastPassword.Location = new System.Drawing.Point(105, 71);
            this.CablecastPassword.Name = "CablecastPassword";
            this.CablecastPassword.Size = new System.Drawing.Size(322, 20);
            this.CablecastPassword.TabIndex = 5;
            this.CablecastPassword.UseSystemPasswordChar = true;
            this.CablecastPassword.Validating += new System.ComponentModel.CancelEventHandler(this.CablecastPassword_Validating);
            // 
            // labelCablecastServer
            // 
            this.labelCablecastServer.AutoSize = true;
            this.labelCablecastServer.Location = new System.Drawing.Point(9, 22);
            this.labelCablecastServer.Name = "labelCablecastServer";
            this.labelCablecastServer.Size = new System.Drawing.Size(82, 13);
            this.labelCablecastServer.TabIndex = 0;
            this.labelCablecastServer.Text = "Server Address:";
            // 
            // CablecastUsername
            // 
            this.CablecastUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CablecastUsername.Location = new System.Drawing.Point(105, 45);
            this.CablecastUsername.Name = "CablecastUsername";
            this.CablecastUsername.Size = new System.Drawing.Size(322, 20);
            this.CablecastUsername.TabIndex = 4;
            this.CablecastUsername.Validating += new System.ComponentModel.CancelEventHandler(this.CablecastUsername_Validating);
            // 
            // labelCablecastUsername
            // 
            this.labelCablecastUsername.AutoSize = true;
            this.labelCablecastUsername.Location = new System.Drawing.Point(9, 48);
            this.labelCablecastUsername.Name = "labelCablecastUsername";
            this.labelCablecastUsername.Size = new System.Drawing.Size(58, 13);
            this.labelCablecastUsername.TabIndex = 1;
            this.labelCablecastUsername.Text = "Username:";
            // 
            // labelCablecastPassword
            // 
            this.labelCablecastPassword.AutoSize = true;
            this.labelCablecastPassword.Location = new System.Drawing.Point(9, 74);
            this.labelCablecastPassword.Name = "labelCablecastPassword";
            this.labelCablecastPassword.Size = new System.Drawing.Size(56, 13);
            this.labelCablecastPassword.TabIndex = 2;
            this.labelCablecastPassword.Text = "Password:";
            // 
            // groupBoxACM
            // 
            this.groupBoxACM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxACM.Controls.Add(this.passiveFTP);
            this.groupBoxACM.Controls.Add(this.ACMServer);
            this.groupBoxACM.Controls.Add(this.ACMPassword);
            this.groupBoxACM.Controls.Add(this.labelACMServer);
            this.groupBoxACM.Controls.Add(this.ACMUsername);
            this.groupBoxACM.Controls.Add(this.labelACMUsername);
            this.groupBoxACM.Controls.Add(this.labelACMPassword);
            this.groupBoxACM.Location = new System.Drawing.Point(6, 12);
            this.groupBoxACM.Name = "groupBoxACM";
            this.groupBoxACM.Size = new System.Drawing.Size(434, 123);
            this.groupBoxACM.TabIndex = 6;
            this.groupBoxACM.TabStop = false;
            this.groupBoxACM.Text = "ACM SCS";
            // 
            // passiveFTP
            // 
            this.passiveFTP.AutoSize = true;
            this.passiveFTP.Location = new System.Drawing.Point(105, 98);
            this.passiveFTP.Name = "passiveFTP";
            this.passiveFTP.Size = new System.Drawing.Size(108, 17);
            this.passiveFTP.TabIndex = 6;
            this.passiveFTP.Text = "Use Passive FTP";
            this.passiveFTP.UseVisualStyleBackColor = true;
            this.passiveFTP.CheckedChanged += new System.EventHandler(this.passiveFTP_CheckedChanged);
            // 
            // ACMServer
            // 
            this.ACMServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ACMServer.Location = new System.Drawing.Point(105, 19);
            this.ACMServer.Name = "ACMServer";
            this.ACMServer.Size = new System.Drawing.Size(322, 20);
            this.ACMServer.TabIndex = 3;
            this.ACMServer.Validating += new System.ComponentModel.CancelEventHandler(this.ACMServer_Validating);
            // 
            // ACMPassword
            // 
            this.ACMPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ACMPassword.Location = new System.Drawing.Point(105, 71);
            this.ACMPassword.Name = "ACMPassword";
            this.ACMPassword.Size = new System.Drawing.Size(322, 20);
            this.ACMPassword.TabIndex = 5;
            this.ACMPassword.UseSystemPasswordChar = true;
            this.ACMPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ACMPassword_Validating);
            // 
            // labelACMServer
            // 
            this.labelACMServer.AutoSize = true;
            this.labelACMServer.Location = new System.Drawing.Point(9, 22);
            this.labelACMServer.Name = "labelACMServer";
            this.labelACMServer.Size = new System.Drawing.Size(81, 13);
            this.labelACMServer.TabIndex = 0;
            this.labelACMServer.Text = "Server address:";
            // 
            // ACMUsername
            // 
            this.ACMUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ACMUsername.Location = new System.Drawing.Point(105, 45);
            this.ACMUsername.Name = "ACMUsername";
            this.ACMUsername.Size = new System.Drawing.Size(322, 20);
            this.ACMUsername.TabIndex = 4;
            this.ACMUsername.Validating += new System.ComponentModel.CancelEventHandler(this.ACMUsername_Validating);
            // 
            // labelACMUsername
            // 
            this.labelACMUsername.AutoSize = true;
            this.labelACMUsername.Location = new System.Drawing.Point(9, 48);
            this.labelACMUsername.Name = "labelACMUsername";
            this.labelACMUsername.Size = new System.Drawing.Size(58, 13);
            this.labelACMUsername.TabIndex = 1;
            this.labelACMUsername.Text = "Username:";
            // 
            // labelACMPassword
            // 
            this.labelACMPassword.AutoSize = true;
            this.labelACMPassword.Location = new System.Drawing.Point(9, 74);
            this.labelACMPassword.Name = "labelACMPassword";
            this.labelACMPassword.Size = new System.Drawing.Size(56, 13);
            this.labelACMPassword.TabIndex = 2;
            this.labelACMPassword.Text = "Password:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(tracm.Cablecast.Location);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 229);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(434, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(7, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(430, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 354);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "tracm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabUpload.ResumeLayout(false);
            this.tabUpload.PerformLayout();
            this.tabDownload.ResumeLayout(false);
            this.tabDownload.PerformLayout();
            this.cablecastGroup.ResumeLayout(false);
            this.cablecastGroup.PerformLayout();
            this.tabQueue.ResumeLayout(false);
            this.tabQueue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.groupBoxFiles.ResumeLayout(false);
            this.groupBoxFiles.PerformLayout();
            this.groupBoxCablecast.ResumeLayout(false);
            this.groupBoxCablecast.PerformLayout();
            this.groupBoxACM.ResumeLayout(false);
            this.groupBoxACM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.TabPage tabUpload;
        private System.Windows.Forms.TabPage tabQueue;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label labelACMServer;
        private System.Windows.Forms.GroupBox groupBoxACM;
        private System.Windows.Forms.TextBox ACMPassword;
        private System.Windows.Forms.TextBox ACMUsername;
        private System.Windows.Forms.TextBox ACMServer;
        private System.Windows.Forms.Label labelACMPassword;
        private System.Windows.Forms.Label labelACMUsername;
        private System.Windows.Forms.GroupBox groupBoxCablecast;
        private System.Windows.Forms.TextBox CablecastServer;
        private System.Windows.Forms.TextBox CablecastPassword;
        private System.Windows.Forms.Label labelCablecastServer;
        private System.Windows.Forms.TextBox CablecastUsername;
        private System.Windows.Forms.Label labelCablecastUsername;
        private System.Windows.Forms.Label labelCablecastPassword;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.TextBox DownloadPath;
        private System.Windows.Forms.Label labelDownloadFolder;
        private System.Windows.Forms.Button FileBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVideoFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.TextBox Cue;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox Producer;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Inentifier;
        private System.Windows.Forms.Button VideoFileButton;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button AddToQueue;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label QueueError;
        private System.Windows.Forms.Button DeleteQueueItem;
		private System.Windows.Forms.Label QueueErrorLabel;
		private System.Windows.Forms.Label TranscodeIndicator;
		private System.Windows.Forms.TabPage tabDownload;
		private System.Windows.Forms.Button RefreshQueue;
		private System.Windows.Forms.CheckBox useCablecast;
		private System.Windows.Forms.GroupBox cablecastGroup;
		private System.Windows.Forms.ComboBox cablecastLocation;
		private System.Windows.Forms.CheckBox passiveFTP;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.BindingSource locationBindingSource;
		private System.Windows.Forms.ComboBox cablecastFormats;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}

