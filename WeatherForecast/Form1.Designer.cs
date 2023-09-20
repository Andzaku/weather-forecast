namespace Weather_Forecast
{
    partial class Form1
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
            citylabel = new Label();
            textBox1 = new TextBox();
            citytextbox = new TextBox();
            searchbutton = new Button();
            tmplabel = new Label();
            humiditylabel = new Label();
            sunriseoutput = new Label();
            sunsetoutput = new Label();
            cloudslabel = new Label();
            cloudsoutput = new Label();
            sunriselabel = new Label();
            windlabel = new Label();
            sunsetlabel = new Label();
            windoutput = new Label();
            humidityoutput = new Label();
            tmpoutput = new Label();
            iconbox = new PictureBox();
            timelabel = new Label();
            ((System.ComponentModel.ISupportInitialize)iconbox).BeginInit();
            SuspendLayout();
            // 
            // citylabel
            // 
            citylabel.AutoSize = true;
            citylabel.BackColor = Color.Transparent;
            citylabel.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            citylabel.Location = new Point(98, 78);
            citylabel.Name = "citylabel";
            citylabel.Size = new Size(47, 24);
            citylabel.TabIndex = 0;
            citylabel.Text = "City";
            citylabel.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-35, -64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // citytextbox
            // 
            citytextbox.BackColor = SystemColors.ButtonFace;
            citytextbox.BorderStyle = BorderStyle.FixedSingle;
            citytextbox.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            citytextbox.Location = new Point(163, 80);
            citytextbox.Name = "citytextbox";
            citytextbox.Size = new Size(234, 27);
            citytextbox.TabIndex = 2;
            // 
            // searchbutton
            // 
            searchbutton.BackColor = Color.Transparent;
            searchbutton.FlatStyle = FlatStyle.Flat;
            searchbutton.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchbutton.Location = new Point(425, 75);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(106, 37);
            searchbutton.TabIndex = 3;
            searchbutton.Text = "Search";
            searchbutton.UseVisualStyleBackColor = false;
            searchbutton.Click += button1_Click;
            // 
            // tmplabel
            // 
            tmplabel.AutoSize = true;
            tmplabel.BackColor = Color.Transparent;
            tmplabel.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tmplabel.Location = new Point(38, 221);
            tmplabel.Name = "tmplabel";
            tmplabel.Size = new Size(131, 24);
            tmplabel.TabIndex = 4;
            tmplabel.Text = "Temperature";
            // 
            // humiditylabel
            // 
            humiditylabel.AutoSize = true;
            humiditylabel.BackColor = Color.Transparent;
            humiditylabel.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            humiditylabel.Location = new Point(49, 272);
            humiditylabel.Name = "humiditylabel";
            humiditylabel.Size = new Size(96, 24);
            humiditylabel.TabIndex = 5;
            humiditylabel.Text = "Humidity";
            // 
            // sunriseoutput
            // 
            sunriseoutput.AutoSize = true;
            sunriseoutput.BackColor = Color.Transparent;
            sunriseoutput.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sunriseoutput.Location = new Point(468, 272);
            sunriseoutput.Name = "sunriseoutput";
            sunriseoutput.Size = new Size(46, 24);
            sunriseoutput.TabIndex = 7;
            sunriseoutput.Text = "N/A";
            // 
            // sunsetoutput
            // 
            sunsetoutput.AutoSize = true;
            sunsetoutput.BackColor = Color.Transparent;
            sunsetoutput.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sunsetoutput.Location = new Point(468, 317);
            sunsetoutput.Name = "sunsetoutput";
            sunsetoutput.Size = new Size(46, 24);
            sunsetoutput.TabIndex = 9;
            sunsetoutput.Text = "N/A";
            // 
            // cloudslabel
            // 
            cloudslabel.AutoSize = true;
            cloudslabel.BackColor = Color.Transparent;
            cloudslabel.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cloudslabel.Location = new Point(350, 221);
            cloudslabel.Name = "cloudslabel";
            cloudslabel.Size = new Size(75, 24);
            cloudslabel.TabIndex = 10;
            cloudslabel.Text = "Clouds";
            // 
            // cloudsoutput
            // 
            cloudsoutput.AutoSize = true;
            cloudsoutput.BackColor = Color.Transparent;
            cloudsoutput.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cloudsoutput.Location = new Point(468, 221);
            cloudsoutput.Name = "cloudsoutput";
            cloudsoutput.Size = new Size(46, 24);
            cloudsoutput.TabIndex = 11;
            cloudsoutput.Text = "N/A";
            // 
            // sunriselabel
            // 
            sunriselabel.AutoSize = true;
            sunriselabel.BackColor = Color.Transparent;
            sunriselabel.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sunriselabel.Location = new Point(350, 272);
            sunriselabel.Name = "sunriselabel";
            sunriselabel.Size = new Size(82, 24);
            sunriselabel.TabIndex = 12;
            sunriselabel.Text = "Sunrise";
            // 
            // windlabel
            // 
            windlabel.AutoSize = true;
            windlabel.BackColor = Color.Transparent;
            windlabel.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            windlabel.Location = new Point(44, 317);
            windlabel.Name = "windlabel";
            windlabel.Size = new Size(125, 24);
            windlabel.TabIndex = 13;
            windlabel.Text = "Wind Speed";
            // 
            // sunsetlabel
            // 
            sunsetlabel.AutoSize = true;
            sunsetlabel.BackColor = Color.Transparent;
            sunsetlabel.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sunsetlabel.Location = new Point(350, 317);
            sunsetlabel.Name = "sunsetlabel";
            sunsetlabel.Size = new Size(75, 24);
            sunsetlabel.TabIndex = 14;
            sunsetlabel.Text = "Sunset";
            // 
            // windoutput
            // 
            windoutput.AutoSize = true;
            windoutput.BackColor = Color.Transparent;
            windoutput.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            windoutput.Location = new Point(202, 317);
            windoutput.Name = "windoutput";
            windoutput.Size = new Size(46, 24);
            windoutput.TabIndex = 15;
            windoutput.Text = "N/A";
            // 
            // humidityoutput
            // 
            humidityoutput.AutoSize = true;
            humidityoutput.BackColor = Color.Transparent;
            humidityoutput.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            humidityoutput.Location = new Point(202, 272);
            humidityoutput.Name = "humidityoutput";
            humidityoutput.Size = new Size(46, 24);
            humidityoutput.TabIndex = 17;
            humidityoutput.Text = "N/A";
            // 
            // tmpoutput
            // 
            tmpoutput.AutoSize = true;
            tmpoutput.BackColor = Color.Transparent;
            tmpoutput.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tmpoutput.Location = new Point(202, 221);
            tmpoutput.Name = "tmpoutput";
            tmpoutput.Size = new Size(46, 24);
            tmpoutput.TabIndex = 18;
            tmpoutput.Text = "N/A";
            // 
            // iconbox
            // 
            iconbox.BackColor = Color.Transparent;
            iconbox.Location = new Point(12, 12);
            iconbox.Name = "iconbox";
            iconbox.Size = new Size(82, 71);
            iconbox.TabIndex = 19;
            iconbox.TabStop = false;
            // 
            // timelabel
            // 
            timelabel.AutoSize = true;
            timelabel.BackColor = Color.Transparent;
            timelabel.Font = new Font("MS Reference Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            timelabel.Location = new Point(177, 130);
            timelabel.Name = "timelabel";
            timelabel.Size = new Size(255, 60);
            timelabel.TabIndex = 20;
            timelabel.Text = "00:00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(648, 383);
            Controls.Add(timelabel);
            Controls.Add(iconbox);
            Controls.Add(tmpoutput);
            Controls.Add(humidityoutput);
            Controls.Add(windoutput);
            Controls.Add(sunsetlabel);
            Controls.Add(windlabel);
            Controls.Add(sunriselabel);
            Controls.Add(cloudsoutput);
            Controls.Add(cloudslabel);
            Controls.Add(sunsetoutput);
            Controls.Add(sunriseoutput);
            Controls.Add(humiditylabel);
            Controls.Add(tmplabel);
            Controls.Add(searchbutton);
            Controls.Add(citytextbox);
            Controls.Add(textBox1);
            Controls.Add(citylabel);
            Name = "Form1";
            Text = "Weather Forecast";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)iconbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label citylabel;
        private TextBox textBox1;
        private TextBox citytextbox;
        private Button searchbutton;
        private Label tmplabel;
        private Label humiditylabel;
        private Label sunriseoutput;
        private Label sunsetoutput;
        private Label cloudslabel;
        private Label cloudsoutput;
        private Label sunriselabel;
        private Label windlabel;
        private Label sunsetlabel;
        private Label windoutput;
        private Label humidityoutput;
        private Label tmpoutput;
        private PictureBox iconbox;
        private Label timelabel;
    }
}