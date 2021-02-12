namespace _2._0
{
    partial class frmTeamRoster
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
            this.lblPeopleOnTeam = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.lblSpotsOpen = new System.Windows.Forms.Label();
            this.txtNumPeople = new System.Windows.Forms.TextBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamMem = new System.Windows.Forms.Label();
            this.lblSpots = new System.Windows.Forms.Label();
            this.lblMemberNames = new System.Windows.Forms.Label();
            this.lstTeamMembers = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnAddToTeam = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPeopleOnTeam
            // 
            this.lblPeopleOnTeam.AutoSize = true;
            this.lblPeopleOnTeam.Location = new System.Drawing.Point(43, 69);
            this.lblPeopleOnTeam.Name = "lblPeopleOnTeam";
            this.lblPeopleOnTeam.Size = new System.Drawing.Size(236, 17);
            this.lblPeopleOnTeam.TabIndex = 0;
            this.lblPeopleOnTeam.Text = "How many people are on your team:";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(43, 130);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(155, 17);
            this.lblMemberName.TabIndex = 1;
            this.lblMemberName.Text = "Name of team member:";
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Location = new System.Drawing.Point(43, 221);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(141, 17);
            this.lblTotalMembers.TabIndex = 2;
            this.lblTotalMembers.Text = "Total team members:";
            // 
            // lblSpotsOpen
            // 
            this.lblSpotsOpen.AutoSize = true;
            this.lblSpotsOpen.Location = new System.Drawing.Point(43, 256);
            this.lblSpotsOpen.Name = "lblSpotsOpen";
            this.lblSpotsOpen.Size = new System.Drawing.Size(84, 17);
            this.lblSpotsOpen.TabIndex = 3;
            this.lblSpotsOpen.Text = "Spots open:";
            // 
            // txtNumPeople
            // 
            this.txtNumPeople.Location = new System.Drawing.Point(306, 67);
            this.txtNumPeople.Name = "txtNumPeople";
            this.txtNumPeople.Size = new System.Drawing.Size(100, 22);
            this.txtNumPeople.TabIndex = 4;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(304, 125);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(100, 22);
            this.txtTeamName.TabIndex = 5;
            // 
            // lblTeamMem
            // 
            this.lblTeamMem.AutoSize = true;
            this.lblTeamMem.Location = new System.Drawing.Point(202, 220);
            this.lblTeamMem.Name = "lblTeamMem";
            this.lblTeamMem.Size = new System.Drawing.Size(16, 17);
            this.lblTeamMem.TabIndex = 6;
            this.lblTeamMem.Text = "0";
            // 
            // lblSpots
            // 
            this.lblSpots.AutoSize = true;
            this.lblSpots.Location = new System.Drawing.Point(202, 256);
            this.lblSpots.Name = "lblSpots";
            this.lblSpots.Size = new System.Drawing.Size(16, 17);
            this.lblSpots.TabIndex = 7;
            this.lblSpots.Text = "0";
            // 
            // lblMemberNames
            // 
            this.lblMemberNames.AutoSize = true;
            this.lblMemberNames.Location = new System.Drawing.Point(304, 189);
            this.lblMemberNames.Name = "lblMemberNames";
            this.lblMemberNames.Size = new System.Drawing.Size(106, 17);
            this.lblMemberNames.TabIndex = 8;
            this.lblMemberNames.Text = "Team Members";
            // 
            // lstTeamMembers
            // 
            this.lstTeamMembers.FormattingEnabled = true;
            this.lstTeamMembers.ItemHeight = 16;
            this.lstTeamMembers.Location = new System.Drawing.Point(307, 209);
            this.lstTeamMembers.Name = "lstTeamMembers";
            this.lstTeamMembers.Size = new System.Drawing.Size(169, 148);
            this.lstTeamMembers.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(424, 66);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(129, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAddToTeam
            // 
            this.btnAddToTeam.Location = new System.Drawing.Point(424, 124);
            this.btnAddToTeam.Name = "btnAddToTeam";
            this.btnAddToTeam.Size = new System.Drawing.Size(129, 23);
            this.btnAddToTeam.TabIndex = 11;
            this.btnAddToTeam.Text = "Add to Team";
            this.btnAddToTeam.UseVisualStyleBackColor = true;
            this.btnAddToTeam.Click += new System.EventHandler(this.btnAddToTeam_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(306, 381);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Roster";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmTeamRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 427);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddToTeam);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lstTeamMembers);
            this.Controls.Add(this.lblMemberNames);
            this.Controls.Add(this.lblSpots);
            this.Controls.Add(this.lblTeamMem);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.txtNumPeople);
            this.Controls.Add(this.lblSpotsOpen);
            this.Controls.Add(this.lblTotalMembers);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.lblPeopleOnTeam);
            this.Name = "frmTeamRoster";
            this.Text = "Team Roster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeopleOnTeam;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Label lblSpotsOpen;
        private System.Windows.Forms.TextBox txtNumPeople;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamMem;
        private System.Windows.Forms.Label lblSpots;
        private System.Windows.Forms.Label lblMemberNames;
        private System.Windows.Forms.ListBox lstTeamMembers;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnAddToTeam;
        private System.Windows.Forms.Button btnClear;
    }
}

