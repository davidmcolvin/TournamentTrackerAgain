namespace TrackerUI
{
  partial class CreateTournamentForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
      this.headerLabel = new System.Windows.Forms.Label();
      this.tournamentNameValue = new System.Windows.Forms.TextBox();
      this.tournamentNameLabel = new System.Windows.Forms.Label();
      this.teamOneScoreValue = new System.Windows.Forms.TextBox();
      this.entryFeeLabel = new System.Windows.Forms.Label();
      this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
      this.selectTeamLabel = new System.Windows.Forms.Label();
      this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
      this.addTeamButton = new System.Windows.Forms.Button();
      this.createPrizebutton = new System.Windows.Forms.Button();
      this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
      this.tournamentPlayersLabel = new System.Windows.Forms.Label();
      this.deletePlayerButton = new System.Windows.Forms.Button();
      this.deletePrizeButton = new System.Windows.Forms.Button();
      this.prizeLabel = new System.Windows.Forms.Label();
      this.prizeListBox = new System.Windows.Forms.ListBox();
      this.createTournamentButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.headerLabel.Location = new System.Drawing.Point(12, 9);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(317, 50);
      this.headerLabel.TabIndex = 1;
      this.headerLabel.Text = "Create Tournament";
      // 
      // tournamentNameValue
      // 
      this.tournamentNameValue.Location = new System.Drawing.Point(21, 129);
      this.tournamentNameValue.Name = "tournamentNameValue";
      this.tournamentNameValue.Size = new System.Drawing.Size(379, 35);
      this.tournamentNameValue.TabIndex = 10;
      // 
      // tournamentNameLabel
      // 
      this.tournamentNameLabel.AutoSize = true;
      this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.tournamentNameLabel.Location = new System.Drawing.Point(14, 79);
      this.tournamentNameLabel.Name = "tournamentNameLabel";
      this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
      this.tournamentNameLabel.TabIndex = 9;
      this.tournamentNameLabel.Text = "Tournament Name";
      // 
      // teamOneScoreValue
      // 
      this.teamOneScoreValue.Location = new System.Drawing.Point(143, 198);
      this.teamOneScoreValue.Name = "teamOneScoreValue";
      this.teamOneScoreValue.Size = new System.Drawing.Size(255, 35);
      this.teamOneScoreValue.TabIndex = 12;
      this.teamOneScoreValue.Text = "0";
      // 
      // entryFeeLabel
      // 
      this.entryFeeLabel.AutoSize = true;
      this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.entryFeeLabel.Location = new System.Drawing.Point(12, 198);
      this.entryFeeLabel.Name = "entryFeeLabel";
      this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
      this.entryFeeLabel.TabIndex = 11;
      this.entryFeeLabel.Text = "Entry Fee";
      // 
      // selectTeamDropDown
      // 
      this.selectTeamDropDown.FormattingEnabled = true;
      this.selectTeamDropDown.Location = new System.Drawing.Point(21, 306);
      this.selectTeamDropDown.Name = "selectTeamDropDown";
      this.selectTeamDropDown.Size = new System.Drawing.Size(373, 38);
      this.selectTeamDropDown.TabIndex = 14;
      // 
      // selectTeamLabel
      // 
      this.selectTeamLabel.AutoSize = true;
      this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.selectTeamLabel.Location = new System.Drawing.Point(12, 266);
      this.selectTeamLabel.Name = "selectTeamLabel";
      this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
      this.selectTeamLabel.TabIndex = 13;
      this.selectTeamLabel.Text = "Select Team";
      // 
      // createNewTeamLink
      // 
      this.createNewTeamLink.AutoSize = true;
      this.createNewTeamLink.Location = new System.Drawing.Point(224, 266);
      this.createNewTeamLink.Name = "createNewTeamLink";
      this.createNewTeamLink.Size = new System.Drawing.Size(176, 30);
      this.createNewTeamLink.TabIndex = 15;
      this.createNewTeamLink.TabStop = true;
      this.createNewTeamLink.Text = "Create New Team";
      // 
      // addTeamButton
      // 
      this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.addTeamButton.Location = new System.Drawing.Point(112, 371);
      this.addTeamButton.Name = "addTeamButton";
      this.addTeamButton.Size = new System.Drawing.Size(162, 67);
      this.addTeamButton.TabIndex = 16;
      this.addTeamButton.Text = "Add Team";
      this.addTeamButton.UseVisualStyleBackColor = true;
      // 
      // createPrizebutton
      // 
      this.createPrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createPrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createPrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.createPrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createPrizebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createPrizebutton.Location = new System.Drawing.Point(112, 463);
      this.createPrizebutton.Name = "createPrizebutton";
      this.createPrizebutton.Size = new System.Drawing.Size(162, 67);
      this.createPrizebutton.TabIndex = 17;
      this.createPrizebutton.Text = "Create Prize";
      this.createPrizebutton.UseVisualStyleBackColor = true;
      // 
      // tournamentPlayersListBox
      // 
      this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tournamentPlayersListBox.FormattingEnabled = true;
      this.tournamentPlayersListBox.ItemHeight = 30;
      this.tournamentPlayersListBox.Location = new System.Drawing.Point(423, 119);
      this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
      this.tournamentPlayersListBox.Size = new System.Drawing.Size(339, 212);
      this.tournamentPlayersListBox.TabIndex = 18;
      // 
      // tournamentPlayersLabel
      // 
      this.tournamentPlayersLabel.AutoSize = true;
      this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tournamentPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.tournamentPlayersLabel.Location = new System.Drawing.Point(416, 79);
      this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
      this.tournamentPlayersLabel.Size = new System.Drawing.Size(248, 37);
      this.tournamentPlayersLabel.TabIndex = 19;
      this.tournamentPlayersLabel.Text = "Tournament Players";
      // 
      // deletePlayerButton
      // 
      this.deletePlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.deletePlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.deletePlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.deletePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.deletePlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.deletePlayerButton.Location = new System.Drawing.Point(770, 119);
      this.deletePlayerButton.Name = "deletePlayerButton";
      this.deletePlayerButton.Size = new System.Drawing.Size(162, 67);
      this.deletePlayerButton.TabIndex = 20;
      this.deletePlayerButton.Text = "Delete Player";
      this.deletePlayerButton.UseVisualStyleBackColor = true;
      // 
      // deletePrizeButton
      // 
      this.deletePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.deletePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.deletePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.deletePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.deletePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.deletePrizeButton.Location = new System.Drawing.Point(770, 384);
      this.deletePrizeButton.Name = "deletePrizeButton";
      this.deletePrizeButton.Size = new System.Drawing.Size(162, 67);
      this.deletePrizeButton.TabIndex = 23;
      this.deletePrizeButton.Text = "Delete Prize";
      this.deletePrizeButton.UseVisualStyleBackColor = true;
      // 
      // prizeLabel
      // 
      this.prizeLabel.AutoSize = true;
      this.prizeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.prizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.prizeLabel.Location = new System.Drawing.Point(416, 344);
      this.prizeLabel.Name = "prizeLabel";
      this.prizeLabel.Size = new System.Drawing.Size(101, 37);
      this.prizeLabel.TabIndex = 22;
      this.prizeLabel.Text = "Prize(s)";
      // 
      // prizeListBox
      // 
      this.prizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.prizeListBox.FormattingEnabled = true;
      this.prizeListBox.ItemHeight = 30;
      this.prizeListBox.Location = new System.Drawing.Point(423, 384);
      this.prizeListBox.Name = "prizeListBox";
      this.prizeListBox.Size = new System.Drawing.Size(339, 212);
      this.prizeListBox.TabIndex = 21;
      // 
      // createTournamentButton
      // 
      this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createTournamentButton.Location = new System.Drawing.Point(320, 637);
      this.createTournamentButton.Name = "createTournamentButton";
      this.createTournamentButton.Size = new System.Drawing.Size(301, 67);
      this.createTournamentButton.TabIndex = 24;
      this.createTournamentButton.Text = "Create Tournament";
      this.createTournamentButton.UseVisualStyleBackColor = true;
      // 
      // CreateTournamentForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(944, 733);
      this.Controls.Add(this.createTournamentButton);
      this.Controls.Add(this.deletePrizeButton);
      this.Controls.Add(this.prizeLabel);
      this.Controls.Add(this.prizeListBox);
      this.Controls.Add(this.deletePlayerButton);
      this.Controls.Add(this.tournamentPlayersLabel);
      this.Controls.Add(this.tournamentPlayersListBox);
      this.Controls.Add(this.createPrizebutton);
      this.Controls.Add(this.addTeamButton);
      this.Controls.Add(this.createNewTeamLink);
      this.Controls.Add(this.selectTeamDropDown);
      this.Controls.Add(this.selectTeamLabel);
      this.Controls.Add(this.teamOneScoreValue);
      this.Controls.Add(this.entryFeeLabel);
      this.Controls.Add(this.tournamentNameValue);
      this.Controls.Add(this.tournamentNameLabel);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "CreateTournamentForm";
      this.Text = "Create Tournament";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.TextBox tournamentNameValue;
    private System.Windows.Forms.Label tournamentNameLabel;
    private System.Windows.Forms.TextBox teamOneScoreValue;
    private System.Windows.Forms.Label entryFeeLabel;
    private System.Windows.Forms.ComboBox selectTeamDropDown;
    private System.Windows.Forms.Label selectTeamLabel;
    private System.Windows.Forms.LinkLabel createNewTeamLink;
    private System.Windows.Forms.Button addTeamButton;
    private System.Windows.Forms.Button createPrizebutton;
    private System.Windows.Forms.ListBox tournamentPlayersListBox;
    private System.Windows.Forms.Label tournamentPlayersLabel;
    private System.Windows.Forms.Button deletePlayerButton;
    private System.Windows.Forms.Button deletePrizeButton;
    private System.Windows.Forms.Label prizeLabel;
    private System.Windows.Forms.ListBox prizeListBox;
    private System.Windows.Forms.Button createTournamentButton;
  }
}