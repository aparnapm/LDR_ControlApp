namespace AmbientLightControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.TableLayoutPanel();
            this.rightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.valuePanel = new System.Windows.Forms.TableLayoutPanel();
            this.valuesPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.alarmPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.currentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.currentValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sessionStartPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sessionend = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.thresholdPanel = new System.Windows.Forms.TableLayoutPanel();
            this.thresholdvalue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.valuesPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.minimumPanel = new System.Windows.Forms.TableLayoutPanel();
            this.minimum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.elapsedPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sessionstart = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maximumPanel = new System.Windows.Forms.TableLayoutPanel();
            this.maximum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countPanel = new System.Windows.Forms.TableLayoutPanel();
            this.thresholdcount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuGauge1 = new Bunifu.Framework.UI.BunifuGauge();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.settingsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.homeScreenPanel1 = new System.Windows.Forms.Panel();
            this.settingspanel = new System.Windows.Forms.TableLayoutPanel();
            this.connect = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.connectionsettings = new System.Windows.Forms.Button();
            this.thresholdSettings = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.minthreshold = new System.Windows.Forms.TextBox();
            this.threshold = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.errorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.view = new System.Windows.Forms.Button();
            this.homebutton = new System.Windows.Forms.Button();
            this.displaySettingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.displayMinThreshold = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.displayPort = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.manualStatus = new System.Windows.Forms.Label();
            this.clientport = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.Panel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.valuePanel.SuspendLayout();
            this.valuesPanel2.SuspendLayout();
            this.alarmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.currentPanel.SuspendLayout();
            this.sessionStartPanel.SuspendLayout();
            this.thresholdPanel.SuspendLayout();
            this.valuesPanel1.SuspendLayout();
            this.minimumPanel.SuspendLayout();
            this.elapsedPanel.SuspendLayout();
            this.maximumPanel.SuspendLayout();
            this.countPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.settingsTablePanel.SuspendLayout();
            this.homeScreenPanel1.SuspendLayout();
            this.settingspanel.SuspendLayout();
            this.thresholdSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.displaySettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.909605F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.09039F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Panel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.errorLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.647141F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.35286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1091, 565);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightCyan;
            this.label11.Location = new System.Drawing.Point(83, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(970, 46);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ambient Light Control Using LDR";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel
            // 
            this.Panel.AutoSize = true;
            this.Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.Panel.ColumnCount = 2;
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.17405F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.82595F));
            this.Panel.Controls.Add(this.rightPanel, 1, 0);
            this.Panel.Controls.Add(this.leftPanel, 0, 0);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(86, 49);
            this.Panel.Name = "Panel";
            this.Panel.RowCount = 1;
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 484F));
            this.Panel.Size = new System.Drawing.Size(964, 484);
            this.Panel.TabIndex = 4;
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.AutoSize = true;
            this.rightPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rightPanel.ColumnCount = 1;
            this.rightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightPanel.Controls.Add(this.valuePanel, 0, 0);
            this.rightPanel.Controls.Add(this.bunifuGauge1, 0, 1);
            this.rightPanel.Location = new System.Drawing.Point(592, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.RowCount = 2;
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.95689F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0431F));
            this.rightPanel.Size = new System.Drawing.Size(369, 478);
            this.rightPanel.TabIndex = 5;
            this.rightPanel.Visible = false;
            // 
            // valuePanel
            // 
            this.valuePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valuePanel.AutoSize = true;
            this.valuePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.valuePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.valuePanel.ColumnCount = 1;
            this.valuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.valuePanel.Controls.Add(this.valuesPanel2, 0, 2);
            this.valuePanel.Controls.Add(this.valuesPanel1, 0, 0);
            this.valuePanel.Controls.Add(this.dataGridView1, 0, 1);
            this.valuePanel.Location = new System.Drawing.Point(3, 3);
            this.valuePanel.Name = "valuePanel";
            this.valuePanel.RowCount = 3;
            this.valuePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.07447F));
            this.valuePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.521276F));
            this.valuePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.67021F));
            this.valuePanel.Size = new System.Drawing.Size(363, 376);
            this.valuePanel.TabIndex = 3;
            // 
            // valuesPanel2
            // 
            this.valuesPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valuesPanel2.AutoSize = true;
            this.valuesPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.valuesPanel2.ColumnCount = 2;
            this.valuesPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.valuesPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.valuesPanel2.Controls.Add(this.alarmPanel, 0, 1);
            this.valuesPanel2.Controls.Add(this.currentPanel, 0, 0);
            this.valuesPanel2.Controls.Add(this.sessionStartPanel, 1, 1);
            this.valuesPanel2.Controls.Add(this.thresholdPanel, 1, 0);
            this.valuesPanel2.Location = new System.Drawing.Point(3, 195);
            this.valuesPanel2.Name = "valuesPanel2";
            this.valuesPanel2.RowCount = 2;
            this.valuesPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.valuesPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.valuesPanel2.Size = new System.Drawing.Size(357, 178);
            this.valuesPanel2.TabIndex = 6;
            // 
            // alarmPanel
            // 
            this.alarmPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alarmPanel.ColumnCount = 2;
            this.alarmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.alarmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.alarmPanel.Controls.Add(this.pictureBox1, 1, 0);
            this.alarmPanel.Controls.Add(this.label7, 0, 0);
            this.alarmPanel.Location = new System.Drawing.Point(3, 92);
            this.alarmPanel.Name = "alarmPanel";
            this.alarmPanel.RowCount = 1;
            this.alarmPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.alarmPanel.Size = new System.Drawing.Size(172, 83);
            this.alarmPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(89, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 77);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 83);
            this.label7.TabIndex = 7;
            this.label7.Text = "Alarm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentPanel
            // 
            this.currentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPanel.ColumnCount = 2;
            this.currentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.currentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.currentPanel.Controls.Add(this.currentValue, 0, 0);
            this.currentPanel.Controls.Add(this.label6, 0, 0);
            this.currentPanel.Location = new System.Drawing.Point(3, 3);
            this.currentPanel.Name = "currentPanel";
            this.currentPanel.RowCount = 1;
            this.currentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.currentPanel.Size = new System.Drawing.Size(172, 83);
            this.currentPanel.TabIndex = 3;
            // 
            // currentValue
            // 
            this.currentValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentValue.AutoSize = true;
            this.currentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentValue.ForeColor = System.Drawing.Color.Teal;
            this.currentValue.Location = new System.Drawing.Point(89, 0);
            this.currentValue.Name = "currentValue";
            this.currentValue.Size = new System.Drawing.Size(80, 83);
            this.currentValue.TabIndex = 14;
            this.currentValue.Text = "-";
            this.currentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 83);
            this.label6.TabIndex = 6;
            this.label6.Text = "Current Reading";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sessionStartPanel
            // 
            this.sessionStartPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionStartPanel.ColumnCount = 2;
            this.sessionStartPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sessionStartPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sessionStartPanel.Controls.Add(this.sessionend, 1, 0);
            this.sessionStartPanel.Controls.Add(this.label5, 0, 0);
            this.sessionStartPanel.Location = new System.Drawing.Point(181, 92);
            this.sessionStartPanel.Name = "sessionStartPanel";
            this.sessionStartPanel.RowCount = 1;
            this.sessionStartPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sessionStartPanel.Size = new System.Drawing.Size(173, 83);
            this.sessionStartPanel.TabIndex = 3;
            // 
            // sessionend
            // 
            this.sessionend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionend.AutoSize = true;
            this.sessionend.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionend.ForeColor = System.Drawing.Color.Teal;
            this.sessionend.Location = new System.Drawing.Point(89, 0);
            this.sessionend.Name = "sessionend";
            this.sessionend.Size = new System.Drawing.Size(81, 83);
            this.sessionend.TabIndex = 17;
            this.sessionend.Text = "-";
            this.sessionend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 83);
            this.label5.TabIndex = 5;
            this.label5.Text = "Elapsed Time";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thresholdPanel
            // 
            this.thresholdPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdPanel.ColumnCount = 2;
            this.thresholdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.thresholdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.thresholdPanel.Controls.Add(this.thresholdvalue, 0, 0);
            this.thresholdPanel.Controls.Add(this.label8, 0, 0);
            this.thresholdPanel.Location = new System.Drawing.Point(181, 3);
            this.thresholdPanel.Name = "thresholdPanel";
            this.thresholdPanel.RowCount = 1;
            this.thresholdPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.thresholdPanel.Size = new System.Drawing.Size(173, 83);
            this.thresholdPanel.TabIndex = 2;
            // 
            // thresholdvalue
            // 
            this.thresholdvalue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdvalue.AutoSize = true;
            this.thresholdvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thresholdvalue.ForeColor = System.Drawing.Color.Teal;
            this.thresholdvalue.Location = new System.Drawing.Point(89, 0);
            this.thresholdvalue.Name = "thresholdvalue";
            this.thresholdvalue.Size = new System.Drawing.Size(81, 83);
            this.thresholdvalue.TabIndex = 10;
            this.thresholdvalue.Text = "-";
            this.thresholdvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 83);
            this.label8.TabIndex = 8;
            this.label8.Text = "Threshold Range";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valuesPanel1
            // 
            this.valuesPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valuesPanel1.AutoSize = true;
            this.valuesPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.valuesPanel1.ColumnCount = 2;
            this.valuesPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.valuesPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.valuesPanel1.Controls.Add(this.minimumPanel, 1, 0);
            this.valuesPanel1.Controls.Add(this.elapsedPanel, 1, 1);
            this.valuesPanel1.Controls.Add(this.maximumPanel, 0, 0);
            this.valuesPanel1.Controls.Add(this.countPanel, 0, 1);
            this.valuesPanel1.Location = new System.Drawing.Point(3, 3);
            this.valuesPanel1.Name = "valuesPanel1";
            this.valuesPanel1.RowCount = 2;
            this.valuesPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.valuesPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.valuesPanel1.Size = new System.Drawing.Size(357, 170);
            this.valuesPanel1.TabIndex = 0;
            // 
            // minimumPanel
            // 
            this.minimumPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumPanel.ColumnCount = 2;
            this.minimumPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.minimumPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.minimumPanel.Controls.Add(this.minimum, 0, 0);
            this.minimumPanel.Controls.Add(this.label2, 0, 0);
            this.minimumPanel.Location = new System.Drawing.Point(181, 3);
            this.minimumPanel.Name = "minimumPanel";
            this.minimumPanel.RowCount = 1;
            this.minimumPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.minimumPanel.Size = new System.Drawing.Size(173, 79);
            this.minimumPanel.TabIndex = 1;
            // 
            // minimum
            // 
            this.minimum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minimum.AutoSize = true;
            this.minimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimum.ForeColor = System.Drawing.Color.Teal;
            this.minimum.Location = new System.Drawing.Point(89, 0);
            this.minimum.Name = "minimum";
            this.minimum.Size = new System.Drawing.Size(81, 79);
            this.minimum.TabIndex = 10;
            this.minimum.Text = "-";
            this.minimum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 79);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minimum Reading";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elapsedPanel
            // 
            this.elapsedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elapsedPanel.ColumnCount = 2;
            this.elapsedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.elapsedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.elapsedPanel.Controls.Add(this.sessionstart, 0, 0);
            this.elapsedPanel.Controls.Add(this.label4, 0, 0);
            this.elapsedPanel.Location = new System.Drawing.Point(181, 88);
            this.elapsedPanel.Name = "elapsedPanel";
            this.elapsedPanel.RowCount = 1;
            this.elapsedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.elapsedPanel.Size = new System.Drawing.Size(173, 79);
            this.elapsedPanel.TabIndex = 2;
            // 
            // sessionstart
            // 
            this.sessionstart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionstart.AutoSize = true;
            this.sessionstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionstart.ForeColor = System.Drawing.Color.Teal;
            this.sessionstart.Location = new System.Drawing.Point(89, 0);
            this.sessionstart.Name = "sessionstart";
            this.sessionstart.Size = new System.Drawing.Size(81, 79);
            this.sessionstart.TabIndex = 13;
            this.sessionstart.Text = "-";
            this.sessionstart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 79);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sesssion Start Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maximumPanel
            // 
            this.maximumPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maximumPanel.ColumnCount = 2;
            this.maximumPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.maximumPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.maximumPanel.Controls.Add(this.maximum, 0, 0);
            this.maximumPanel.Controls.Add(this.label1, 0, 0);
            this.maximumPanel.Location = new System.Drawing.Point(3, 3);
            this.maximumPanel.Name = "maximumPanel";
            this.maximumPanel.RowCount = 1;
            this.maximumPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.maximumPanel.Size = new System.Drawing.Size(172, 79);
            this.maximumPanel.TabIndex = 0;
            // 
            // maximum
            // 
            this.maximum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maximum.AutoSize = true;
            this.maximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximum.ForeColor = System.Drawing.Color.Teal;
            this.maximum.Location = new System.Drawing.Point(89, 0);
            this.maximum.Name = "maximum";
            this.maximum.Size = new System.Drawing.Size(80, 79);
            this.maximum.TabIndex = 11;
            this.maximum.Text = "-";
            this.maximum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maximum Reading";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countPanel
            // 
            this.countPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countPanel.ColumnCount = 2;
            this.countPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.countPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.countPanel.Controls.Add(this.thresholdcount, 0, 0);
            this.countPanel.Controls.Add(this.label3, 0, 0);
            this.countPanel.Location = new System.Drawing.Point(3, 88);
            this.countPanel.Name = "countPanel";
            this.countPanel.RowCount = 1;
            this.countPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.countPanel.Size = new System.Drawing.Size(172, 79);
            this.countPanel.TabIndex = 0;
            // 
            // thresholdcount
            // 
            this.thresholdcount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdcount.AutoSize = true;
            this.thresholdcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thresholdcount.ForeColor = System.Drawing.Color.Teal;
            this.thresholdcount.Location = new System.Drawing.Point(89, 0);
            this.thresholdcount.Name = "thresholdcount";
            this.thresholdcount.Size = new System.Drawing.Size(80, 79);
            this.thresholdcount.TabIndex = 13;
            this.thresholdcount.Text = "-";
            this.thresholdcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 79);
            this.label3.TabIndex = 3;
            this.label3.Text = "Count- Beyond Threshold";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(357, 10);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // bunifuGauge1
            // 
            this.bunifuGauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGauge1.AutoSize = true;
            this.bunifuGauge1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge1.BackgroundImage")));
            this.bunifuGauge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuGauge1.ForeColor = System.Drawing.Color.White;
            this.bunifuGauge1.Location = new System.Drawing.Point(6, 388);
            this.bunifuGauge1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuGauge1.Name = "bunifuGauge1";
            this.bunifuGauge1.ProgressBgColor = System.Drawing.Color.LightBlue;
            this.bunifuGauge1.ProgressColor1 = System.Drawing.Color.Goldenrod;
            this.bunifuGauge1.ProgressColor2 = System.Drawing.Color.DarkGoldenrod;
            this.bunifuGauge1.Size = new System.Drawing.Size(357, 84);
            this.bunifuGauge1.Suffix = "";
            this.bunifuGauge1.TabIndex = 4;
            this.bunifuGauge1.Thickness = 12;
            this.bunifuGauge1.Value = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPanel.AutoSize = true;
            this.leftPanel.Controls.Add(this.settingsTablePanel);
            this.leftPanel.Controls.Add(this.chart1);
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(583, 478);
            this.leftPanel.TabIndex = 6;
            // 
            // settingsTablePanel
            // 
            this.settingsTablePanel.AutoSize = true;
            this.settingsTablePanel.ColumnCount = 2;
            this.settingsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.06985F));
            this.settingsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.93015F));
            this.settingsTablePanel.Controls.Add(this.homeScreenPanel1, 1, 0);
            this.settingsTablePanel.Controls.Add(this.thresholdSettings, 1, 1);
            this.settingsTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTablePanel.Location = new System.Drawing.Point(0, 0);
            this.settingsTablePanel.Name = "settingsTablePanel";
            this.settingsTablePanel.RowCount = 2;
            this.settingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingsTablePanel.Size = new System.Drawing.Size(583, 478);
            this.settingsTablePanel.TabIndex = 0;
            // 
            // homeScreenPanel1
            // 
            this.homeScreenPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.homeScreenPanel1.Controls.Add(this.settingspanel);
            this.homeScreenPanel1.Controls.Add(this.connectionsettings);
            this.homeScreenPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeScreenPanel1.Location = new System.Drawing.Point(335, 3);
            this.homeScreenPanel1.Name = "homeScreenPanel1";
            this.homeScreenPanel1.Size = new System.Drawing.Size(245, 233);
            this.homeScreenPanel1.TabIndex = 0;
            // 
            // settingspanel
            // 
            this.settingspanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.settingspanel.ColumnCount = 3;
            this.settingspanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingspanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.settingspanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.settingspanel.Controls.Add(this.connect, 1, 2);
            this.settingspanel.Controls.Add(this.portBox, 1, 1);
            this.settingspanel.Controls.Add(this.label9, 1, 0);
            this.settingspanel.Location = new System.Drawing.Point(-5, 6);
            this.settingspanel.Name = "settingspanel";
            this.settingspanel.RowCount = 3;
            this.settingspanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingspanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.settingspanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.settingspanel.Size = new System.Drawing.Size(255, 224);
            this.settingspanel.TabIndex = 6;
            this.settingspanel.Visible = false;
            // 
            // connect
            // 
            this.connect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connect.AutoSize = true;
            this.connect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connect.FlatAppearance.BorderSize = 0;
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.ForeColor = System.Drawing.Color.White;
            this.connect.Image = ((System.Drawing.Image)(resources.GetObject("connect.Image")));
            this.connect.Location = new System.Drawing.Point(57, 142);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(130, 79);
            this.connect.TabIndex = 13;
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // portBox
            // 
            this.portBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.portBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portBox.ForeColor = System.Drawing.Color.White;
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(57, 83);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(130, 33);
            this.portBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label9.Location = new System.Drawing.Point(57, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 80);
            this.label9.TabIndex = 0;
            this.label9.Text = "Port Number";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectionsettings
            // 
            this.connectionsettings.AutoSize = true;
            this.connectionsettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectionsettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectionsettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionsettings.FlatAppearance.BorderSize = 0;
            this.connectionsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectionsettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionsettings.ForeColor = System.Drawing.Color.White;
            this.connectionsettings.Image = ((System.Drawing.Image)(resources.GetObject("connectionsettings.Image")));
            this.connectionsettings.Location = new System.Drawing.Point(0, 0);
            this.connectionsettings.Name = "connectionsettings";
            this.connectionsettings.Size = new System.Drawing.Size(245, 233);
            this.connectionsettings.TabIndex = 1;
            this.connectionsettings.Text = "Connection Settings";
            this.connectionsettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.connectionsettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.connectionsettings.UseVisualStyleBackColor = true;
            this.connectionsettings.Click += new System.EventHandler(this.Connectionsettings_Click);
            // 
            // thresholdSettings
            // 
            this.thresholdSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.thresholdSettings.ColumnCount = 3;
            this.thresholdSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.thresholdSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.thresholdSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.thresholdSettings.Controls.Add(this.label10, 0, 0);
            this.thresholdSettings.Controls.Add(this.button7, 2, 3);
            this.thresholdSettings.Controls.Add(this.minthreshold, 1, 1);
            this.thresholdSettings.Controls.Add(this.threshold, 1, 2);
            this.thresholdSettings.Controls.Add(this.label12, 0, 1);
            this.thresholdSettings.Controls.Add(this.label13, 0, 2);
            this.thresholdSettings.Location = new System.Drawing.Point(335, 242);
            this.thresholdSettings.Name = "thresholdSettings";
            this.thresholdSettings.RowCount = 4;
            this.thresholdSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.93507F));
            this.thresholdSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.06493F));
            this.thresholdSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.thresholdSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.thresholdSettings.Size = new System.Drawing.Size(245, 233);
            this.thresholdSettings.TabIndex = 1;
            this.thresholdSettings.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.thresholdSettings.SetColumnSpan(this.label10, 2);
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 50);
            this.label10.TabIndex = 14;
            this.label10.Text = "Threshold Range:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(150, 126);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 104);
            this.button7.TabIndex = 13;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.EstablishConnection_Click);
            // 
            // minthreshold
            // 
            this.minthreshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.minthreshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minthreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minthreshold.ForeColor = System.Drawing.Color.White;
            this.minthreshold.Location = new System.Drawing.Point(73, 53);
            this.minthreshold.Name = "minthreshold";
            this.minthreshold.Size = new System.Drawing.Size(71, 31);
            this.minthreshold.TabIndex = 3;
            // 
            // threshold
            // 
            this.threshold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.threshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threshold.ForeColor = System.Drawing.Color.White;
            this.threshold.Location = new System.Drawing.Point(73, 80);
            this.threshold.Name = "threshold";
            this.threshold.Size = new System.Drawing.Size(71, 31);
            this.threshold.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label12.Location = new System.Drawing.Point(3, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 27);
            this.label12.TabIndex = 6;
            this.label12.Text = "Lower Bound";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label13.Location = new System.Drawing.Point(3, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 46);
            this.label13.TabIndex = 7;
            this.label13.Text = "Upper Bound";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.SlateGray;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineWidth = 0;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.Title = "Time(hh:mm:ss)";
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea1.AxisY.Title = "Light Intensity(LUX)";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(583, 478);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.errorLabel.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.LightGray;
            this.errorLabel.Location = new System.Drawing.Point(86, 544);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(964, 21);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "None";
            this.errorLabel.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.view, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.homebutton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.displaySettingsPanel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.generate, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.disconnect, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.manualStatus, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.38075F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.61925F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(77, 484);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // view
            // 
            this.view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.FlatAppearance.BorderSize = 0;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.Color.White;
            this.view.Image = ((System.Drawing.Image)(resources.GetObject("view.Image")));
            this.view.Location = new System.Drawing.Point(3, 427);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(71, 54);
            this.view.TabIndex = 10;
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.View_Click);
            // 
            // homebutton
            // 
            this.homebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homebutton.FlatAppearance.BorderSize = 0;
            this.homebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebutton.Image = ((System.Drawing.Image)(resources.GetObject("homebutton.Image")));
            this.homebutton.Location = new System.Drawing.Point(3, 3);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(71, 63);
            this.homebutton.TabIndex = 17;
            this.homebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homebutton.UseVisualStyleBackColor = true;
            this.homebutton.Click += new System.EventHandler(this.Homebutton_Click);
            // 
            // displaySettingsPanel
            // 
            this.displaySettingsPanel.ColumnCount = 1;
            this.displaySettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.displaySettingsPanel.Controls.Add(this.displayMinThreshold, 0, 3);
            this.displaySettingsPanel.Controls.Add(this.label16, 0, 2);
            this.displaySettingsPanel.Controls.Add(this.displayPort, 0, 1);
            this.displaySettingsPanel.Controls.Add(this.label14, 0, 0);
            this.displaySettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displaySettingsPanel.Location = new System.Drawing.Point(3, 72);
            this.displaySettingsPanel.Name = "displaySettingsPanel";
            this.displaySettingsPanel.RowCount = 4;
            this.displaySettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.89743F));
            this.displaySettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.10256F));
            this.displaySettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.displaySettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.displaySettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displaySettingsPanel.Size = new System.Drawing.Size(71, 146);
            this.displaySettingsPanel.TabIndex = 13;
            this.displaySettingsPanel.Visible = false;
            // 
            // displayMinThreshold
            // 
            this.displayMinThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayMinThreshold.AutoSize = true;
            this.displayMinThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMinThreshold.ForeColor = System.Drawing.Color.Silver;
            this.displayMinThreshold.Location = new System.Drawing.Point(3, 112);
            this.displayMinThreshold.Name = "displayMinThreshold";
            this.displayMinThreshold.Size = new System.Drawing.Size(65, 34);
            this.displayMinThreshold.TabIndex = 16;
            this.displayMinThreshold.Text = "Automatic";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label16.Location = new System.Drawing.Point(3, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 31);
            this.label16.TabIndex = 15;
            this.label16.Text = "Threshold";
            // 
            // displayPort
            // 
            this.displayPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayPort.AutoSize = true;
            this.displayPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPort.ForeColor = System.Drawing.Color.Silver;
            this.displayPort.Location = new System.Drawing.Point(3, 29);
            this.displayPort.Name = "displayPort";
            this.displayPort.Size = new System.Drawing.Size(65, 52);
            this.displayPort.TabIndex = 14;
            this.displayPort.Text = "Automatic";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 29);
            this.label14.TabIndex = 13;
            this.label14.Text = "Port Number";
            // 
            // generate
            // 
            this.generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generate.FlatAppearance.BorderSize = 0;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.ForeColor = System.Drawing.Color.White;
            this.generate.Image = ((System.Drawing.Image)(resources.GetObject("generate.Image")));
            this.generate.Location = new System.Drawing.Point(3, 358);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(71, 63);
            this.generate.TabIndex = 9;
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Visible = false;
            this.generate.Click += new System.EventHandler(this.Generate_Click_1);
            // 
            // disconnect
            // 
            this.disconnect.AutoSize = true;
            this.disconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.disconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disconnect.FlatAppearance.BorderSize = 0;
            this.disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnect.ForeColor = System.Drawing.Color.White;
            this.disconnect.Image = ((System.Drawing.Image)(resources.GetObject("disconnect.Image")));
            this.disconnect.Location = new System.Drawing.Point(3, 279);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(71, 73);
            this.disconnect.TabIndex = 18;
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Visible = false;
            this.disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // manualStatus
            // 
            this.manualStatus.AutoSize = true;
            this.manualStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manualStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.manualStatus.Location = new System.Drawing.Point(3, 221);
            this.manualStatus.Name = "manualStatus";
            this.manualStatus.Size = new System.Drawing.Size(71, 55);
            this.manualStatus.TabIndex = 12;
            this.manualStatus.Text = "Automatic";
            this.manualStatus.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 565);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Light Control Using LDR";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.valuePanel.ResumeLayout(false);
            this.valuePanel.PerformLayout();
            this.valuesPanel2.ResumeLayout(false);
            this.alarmPanel.ResumeLayout(false);
            this.alarmPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.currentPanel.ResumeLayout(false);
            this.currentPanel.PerformLayout();
            this.sessionStartPanel.ResumeLayout(false);
            this.sessionStartPanel.PerformLayout();
            this.thresholdPanel.ResumeLayout(false);
            this.thresholdPanel.PerformLayout();
            this.valuesPanel1.ResumeLayout(false);
            this.minimumPanel.ResumeLayout(false);
            this.minimumPanel.PerformLayout();
            this.elapsedPanel.ResumeLayout(false);
            this.elapsedPanel.PerformLayout();
            this.maximumPanel.ResumeLayout(false);
            this.maximumPanel.PerformLayout();
            this.countPanel.ResumeLayout(false);
            this.countPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.settingsTablePanel.ResumeLayout(false);
            this.homeScreenPanel1.ResumeLayout(false);
            this.homeScreenPanel1.PerformLayout();
            this.settingspanel.ResumeLayout(false);
            this.settingspanel.PerformLayout();
            this.thresholdSettings.ResumeLayout(false);
            this.thresholdSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.displaySettingsPanel.ResumeLayout(false);
            this.displaySettingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button connectionsettings;
        private System.IO.Ports.SerialPort clientport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel Panel;
        private System.Windows.Forms.TableLayoutPanel valuePanel;
        private System.Windows.Forms.TableLayoutPanel elapsedPanel;
        private System.Windows.Forms.Label sessionend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel countPanel;
        private System.Windows.Forms.Label thresholdcount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel valuesPanel1;
        private System.Windows.Forms.TableLayoutPanel minimumPanel;
        private System.Windows.Forms.Label minimum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel maximumPanel;
        private System.Windows.Forms.Label maximum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel valuesPanel2;
        private System.Windows.Forms.TableLayoutPanel currentPanel;
        private System.Windows.Forms.Label currentValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel thresholdPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel sessionStartPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label sessionstart;
        private System.Windows.Forms.TableLayoutPanel alarmPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label thresholdvalue;
        private System.Windows.Forms.TableLayoutPanel rightPanel;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label manualStatus;
        private System.Windows.Forms.TableLayoutPanel settingspanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox portBox;
        private System.Windows.Forms.TextBox minthreshold;
        private System.Windows.Forms.TextBox threshold;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.TableLayoutPanel settingsTablePanel;
        private System.Windows.Forms.Panel homeScreenPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel thresholdSettings;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.TableLayoutPanel displaySettingsPanel;
        private System.Windows.Forms.Label displayMinThreshold;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label displayPort;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button disconnect;
    }
}

