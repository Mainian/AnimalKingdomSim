namespace AnimalKingdomSimulator
{
    partial class AnimalKingdomWorld
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
            this.WorldStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.WorldStatpropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.GenerateWorldBtn = new System.Windows.Forms.Button();
            this.ResumeBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.ClearWorldBtn = new System.Windows.Forms.Button();
            this.saveMementoBtn = new System.Windows.Forms.Button();
            this.loadMementoBtn = new System.Windows.Forms.Button();
            this.WorldStatsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorldStatsGroupBox
            // 
            this.WorldStatsGroupBox.Controls.Add(this.WorldStatpropertyGrid);
            this.WorldStatsGroupBox.Location = new System.Drawing.Point(1654, 23);
            this.WorldStatsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.WorldStatsGroupBox.Name = "WorldStatsGroupBox";
            this.WorldStatsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.WorldStatsGroupBox.Size = new System.Drawing.Size(482, 969);
            this.WorldStatsGroupBox.TabIndex = 0;
            this.WorldStatsGroupBox.TabStop = false;
            this.WorldStatsGroupBox.Text = "World Statistics. State: No World.";
            // 
            // WorldStatpropertyGrid
            // 
            this.WorldStatpropertyGrid.HelpVisible = false;
            this.WorldStatpropertyGrid.Location = new System.Drawing.Point(14, 38);
            this.WorldStatpropertyGrid.Margin = new System.Windows.Forms.Padding(6);
            this.WorldStatpropertyGrid.Name = "WorldStatpropertyGrid";
            this.WorldStatpropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.WorldStatpropertyGrid.Size = new System.Drawing.Size(456, 919);
            this.WorldStatpropertyGrid.TabIndex = 0;
            this.WorldStatpropertyGrid.ToolbarVisible = false;
            // 
            // GenerateWorldBtn
            // 
            this.GenerateWorldBtn.Location = new System.Drawing.Point(1718, 1001);
            this.GenerateWorldBtn.Margin = new System.Windows.Forms.Padding(6);
            this.GenerateWorldBtn.Name = "GenerateWorldBtn";
            this.GenerateWorldBtn.Size = new System.Drawing.Size(374, 83);
            this.GenerateWorldBtn.TabIndex = 1;
            this.GenerateWorldBtn.Text = "Generate World";
            this.GenerateWorldBtn.UseVisualStyleBackColor = true;
            this.GenerateWorldBtn.Click += new System.EventHandler(this.GenerateWorldBtn_Click);
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.Location = new System.Drawing.Point(1718, 1369);
            this.ResumeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(374, 79);
            this.ResumeBtn.TabIndex = 3;
            this.ResumeBtn.Text = "Resume";
            this.ResumeBtn.UseVisualStyleBackColor = true;
            this.ResumeBtn.Click += new System.EventHandler(this.ResumeBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.Location = new System.Drawing.Point(1718, 1460);
            this.PauseBtn.Margin = new System.Windows.Forms.Padding(6);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(374, 79);
            this.PauseBtn.TabIndex = 4;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // ClearWorldBtn
            // 
            this.ClearWorldBtn.Location = new System.Drawing.Point(1718, 1096);
            this.ClearWorldBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ClearWorldBtn.Name = "ClearWorldBtn";
            this.ClearWorldBtn.Size = new System.Drawing.Size(374, 79);
            this.ClearWorldBtn.TabIndex = 5;
            this.ClearWorldBtn.Text = "Clear World";
            this.ClearWorldBtn.UseVisualStyleBackColor = true;
            // 
            // saveMementoBtn
            // 
            this.saveMementoBtn.Location = new System.Drawing.Point(1718, 1187);
            this.saveMementoBtn.Margin = new System.Windows.Forms.Padding(6);
            this.saveMementoBtn.Name = "saveMementoBtn";
            this.saveMementoBtn.Size = new System.Drawing.Size(374, 79);
            this.saveMementoBtn.TabIndex = 6;
            this.saveMementoBtn.Text = "Save Board";
            this.saveMementoBtn.UseVisualStyleBackColor = true;
            this.saveMementoBtn.Click += new System.EventHandler(this.saveMementoBtn_Click);
            // 
            // loadMementoBtn
            // 
            this.loadMementoBtn.Location = new System.Drawing.Point(1718, 1278);
            this.loadMementoBtn.Margin = new System.Windows.Forms.Padding(6);
            this.loadMementoBtn.Name = "loadMementoBtn";
            this.loadMementoBtn.Size = new System.Drawing.Size(374, 79);
            this.loadMementoBtn.TabIndex = 7;
            this.loadMementoBtn.Text = "Load Board";
            this.loadMementoBtn.UseVisualStyleBackColor = true;
            this.loadMementoBtn.Click += new System.EventHandler(this.loadMementoBtn_Click);
            // 
            // AnimalKingdomWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2160, 1560);
            this.Controls.Add(this.loadMementoBtn);
            this.Controls.Add(this.saveMementoBtn);
            this.Controls.Add(this.ClearWorldBtn);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.ResumeBtn);
            this.Controls.Add(this.GenerateWorldBtn);
            this.Controls.Add(this.WorldStatsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "AnimalKingdomWorld";
            this.Text = "Animal Kingdom Simulator";
            this.TopMost = true;
            this.WorldStatsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WorldStatsGroupBox;
        private System.Windows.Forms.Button GenerateWorldBtn;
        private System.Windows.Forms.Button ResumeBtn;
        private System.Windows.Forms.PropertyGrid WorldStatpropertyGrid;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button ClearWorldBtn;
        private System.Windows.Forms.Button saveMementoBtn;
        private System.Windows.Forms.Button loadMementoBtn;


    }
}

