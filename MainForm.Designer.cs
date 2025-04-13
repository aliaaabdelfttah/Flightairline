namespace CivilAviationSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox FlightsListBox;
        private System.Windows.Forms.TextBox FlightNumberTextBox;
        private System.Windows.Forms.TextBox AltitudeTextBox;
        private System.Windows.Forms.TextBox SpeedTextBox;
        private System.Windows.Forms.Button AddFlightButton;
        private System.Windows.Forms.Button UpdateFlightButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.FlightsListBox = new System.Windows.Forms.ListBox();
            this.FlightNumberTextBox = new System.Windows.Forms.TextBox();
            this.AltitudeTextBox = new System.Windows.Forms.TextBox();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.AddFlightButton = new System.Windows.Forms.Button();
            this.UpdateFlightButton = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // FlightsListBox
            this.FlightsListBox.FormattingEnabled = true;
            this.FlightsListBox.Location = new System.Drawing.Point(12, 12);
            this.FlightsListBox.Name = "FlightsListBox";
            this.FlightsListBox.Size = new System.Drawing.Size(400, 160);
            this.FlightsListBox.TabIndex = 0;

            // FlightNumberTextBox
            this.FlightNumberTextBox.Location = new System.Drawing.Point(12, 200);
            this.FlightNumberTextBox.Name = "FlightNumberTextBox";
            this.FlightNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.FlightNumberTextBox.TabIndex = 1;

            // AltitudeTextBox
            this.AltitudeTextBox.Location = new System.Drawing.Point(120, 200);
            this.AltitudeTextBox.Name = "AltitudeTextBox";
            this.AltitudeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AltitudeTextBox.TabIndex = 2;

            // SpeedTextBox
            this.SpeedTextBox.Location = new System.Drawing.Point(230, 200);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.SpeedTextBox.TabIndex = 3;

            // AddFlightButton
            this.AddFlightButton.Location = new System.Drawing.Point(12, 240);
            this.AddFlightButton.Name = "AddFlightButton";
            this.AddFlightButton.Size = new System.Drawing.Size(100, 30);
            this.AddFlightButton.TabIndex = 4;
            this.AddFlightButton.Text = "Add Flight";
            this.AddFlightButton.UseVisualStyleBackColor = true;
            this.AddFlightButton.Click += new System.EventHandler(this.AddFlightButton_Click);

            // UpdateFlightButton
            this.UpdateFlightButton.Location = new System.Drawing.Point(120, 240);
            this.UpdateFlightButton.Name = "UpdateFlightButton";
            this.UpdateFlightButton.Size = new System.Drawing.Size(100, 30);
            this.UpdateFlightButton.TabIndex = 5;
            this.UpdateFlightButton.Text = "Update Status";
            this.UpdateFlightButton.UseVisualStyleBackColor = true;
            this.UpdateFlightButton.Click += new System.EventHandler(this.UpdateFlightButton_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(434, 281);
            this.Controls.Add(this.UpdateFlightButton);
            this.Controls.Add(this.AddFlightButton);
            this.Controls.Add(this.SpeedTextBox);
            this.Controls.Add(this.AltitudeTextBox);
            this.Controls.Add(this.FlightNumberTextBox);
            this.Controls.Add(this.FlightsListBox);
            this.Name = "MainForm";
            this.Text = "Civil Aviation System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
