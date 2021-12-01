
namespace Lab6
{
    partial class TemperatureConverter
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
            this.numberboxTempValue = new System.Windows.Forms.NumericUpDown();
            this.comboUnits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageTempGauge = new System.Windows.Forms.PictureBox();
            this.lblConversion1Value = new System.Windows.Forms.Label();
            this.lblConversion2Value = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numberboxTempValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTempGauge)).BeginInit();
            this.SuspendLayout();
            // 
            // numberboxTempValue
            // 
            this.numberboxTempValue.Location = new System.Drawing.Point(236, 16);
            this.numberboxTempValue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numberboxTempValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numberboxTempValue.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numberboxTempValue.Name = "numberboxTempValue";
            this.numberboxTempValue.Size = new System.Drawing.Size(167, 26);
            this.numberboxTempValue.TabIndex = 0;
            this.numberboxTempValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberboxTempValue.ValueChanged += new System.EventHandler(this.numberboxTempValue_ValueChanged);
            // 
            // comboUnits
            // 
            this.comboUnits.FormattingEnabled = true;
            this.comboUnits.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius",
            "Kelvin"});
            this.comboUnits.Location = new System.Drawing.Point(413, 15);
            this.comboUnits.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboUnits.Name = "comboUnits";
            this.comboUnits.Size = new System.Drawing.Size(143, 26);
            this.comboUnits.TabIndex = 1;
            this.comboUnits.TextChanged += new System.EventHandler(this.comboUnits_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Starting Temperature:";
            // 
            // imageTempGauge
            // 
            this.imageTempGauge.Image = global::Lab6.Properties.Resources.temperaturegauge_none;
            this.imageTempGauge.Location = new System.Drawing.Point(12, 81);
            this.imageTempGauge.Name = "imageTempGauge";
            this.imageTempGauge.Size = new System.Drawing.Size(214, 73);
            this.imageTempGauge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageTempGauge.TabIndex = 3;
            this.imageTempGauge.TabStop = false;
            // 
            // lblConversion1Value
            // 
            this.lblConversion1Value.BackColor = System.Drawing.Color.White;
            this.lblConversion1Value.Location = new System.Drawing.Point(236, 81);
            this.lblConversion1Value.Name = "lblConversion1Value";
            this.lblConversion1Value.Size = new System.Drawing.Size(320, 30);
            this.lblConversion1Value.TabIndex = 4;
            this.lblConversion1Value.Text = "value 1";
            this.lblConversion1Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConversion2Value
            // 
            this.lblConversion2Value.BackColor = System.Drawing.Color.White;
            this.lblConversion2Value.Location = new System.Drawing.Point(236, 124);
            this.lblConversion2Value.Name = "lblConversion2Value";
            this.lblConversion2Value.Size = new System.Drawing.Size(320, 30);
            this.lblConversion2Value.TabIndex = 5;
            this.lblConversion2Value.Text = "value 2";
            this.lblConversion2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 169);
            this.Controls.Add(this.lblConversion2Value);
            this.Controls.Add(this.lblConversion1Value);
            this.Controls.Add(this.imageTempGauge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboUnits);
            this.Controls.Add(this.numberboxTempValue);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TemperatureConverter";
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberboxTempValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTempGauge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numberboxTempValue;
        private System.Windows.Forms.ComboBox comboUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imageTempGauge;
        private System.Windows.Forms.Label lblConversion1Value;
        private System.Windows.Forms.Label lblConversion2Value;
        private System.Windows.Forms.Timer timer1;
    }
}

