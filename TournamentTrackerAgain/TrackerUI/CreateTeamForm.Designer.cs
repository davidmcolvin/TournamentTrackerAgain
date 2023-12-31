﻿namespace TrackerUI
{
  partial class CreateTeamForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
      this.teamNameValue = new System.Windows.Forms.TextBox();
      this.teamNameLabel = new System.Windows.Forms.Label();
      this.headerLabel = new System.Windows.Forms.Label();
      this.addMemberButton = new System.Windows.Forms.Button();
      this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
      this.selectTeamMemberLabel = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.createMemberButton = new System.Windows.Forms.Button();
      this.cellPhoneValue = new System.Windows.Forms.TextBox();
      this.cellPhoneLabel = new System.Windows.Forms.Label();
      this.emailValue = new System.Windows.Forms.TextBox();
      this.emailLabel = new System.Windows.Forms.Label();
      this.lastNameValue = new System.Windows.Forms.TextBox();
      this.lastNameLabel = new System.Windows.Forms.Label();
      this.firstNameValue = new System.Windows.Forms.TextBox();
      this.firstNameLabel = new System.Windows.Forms.Label();
      this.teamMembersListBox = new System.Windows.Forms.ListBox();
      this.deleteTeamMemberButton = new System.Windows.Forms.Button();
      this.createTeamButton = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // teamNameValue
      // 
      this.teamNameValue.Location = new System.Drawing.Point(21, 129);
      this.teamNameValue.Name = "teamNameValue";
      this.teamNameValue.Size = new System.Drawing.Size(437, 35);
      this.teamNameValue.TabIndex = 13;
      // 
      // teamNameLabel
      // 
      this.teamNameLabel.AutoSize = true;
      this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamNameLabel.Location = new System.Drawing.Point(14, 79);
      this.teamNameLabel.Name = "teamNameLabel";
      this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
      this.teamNameLabel.TabIndex = 12;
      this.teamNameLabel.Text = "Team Name";
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.headerLabel.Location = new System.Drawing.Point(12, 9);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(213, 50);
      this.headerLabel.TabIndex = 11;
      this.headerLabel.Text = "Create Team";
      // 
      // addMemberButton
      // 
      this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addMemberButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.addMemberButton.Location = new System.Drawing.Point(125, 285);
      this.addMemberButton.Name = "addMemberButton";
      this.addMemberButton.Size = new System.Drawing.Size(218, 67);
      this.addMemberButton.TabIndex = 19;
      this.addMemberButton.Text = "Add Member";
      this.addMemberButton.UseVisualStyleBackColor = true;
      // 
      // selectTeamMemberDropDown
      // 
      this.selectTeamMemberDropDown.FormattingEnabled = true;
      this.selectTeamMemberDropDown.Location = new System.Drawing.Point(23, 221);
      this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
      this.selectTeamMemberDropDown.Size = new System.Drawing.Size(435, 38);
      this.selectTeamMemberDropDown.TabIndex = 18;
      // 
      // selectTeamMemberLabel
      // 
      this.selectTeamMemberLabel.AutoSize = true;
      this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.selectTeamMemberLabel.Location = new System.Drawing.Point(14, 181);
      this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
      this.selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
      this.selectTeamMemberLabel.TabIndex = 17;
      this.selectTeamMemberLabel.Text = "Select Team Member";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.createMemberButton);
      this.groupBox1.Controls.Add(this.cellPhoneValue);
      this.groupBox1.Controls.Add(this.cellPhoneLabel);
      this.groupBox1.Controls.Add(this.emailValue);
      this.groupBox1.Controls.Add(this.emailLabel);
      this.groupBox1.Controls.Add(this.lastNameValue);
      this.groupBox1.Controls.Add(this.lastNameLabel);
      this.groupBox1.Controls.Add(this.firstNameValue);
      this.groupBox1.Controls.Add(this.firstNameLabel);
      this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.groupBox1.Location = new System.Drawing.Point(33, 377);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(425, 387);
      this.groupBox1.TabIndex = 20;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Add New Member";
      // 
      // createMemberButton
      // 
      this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createMemberButton.Location = new System.Drawing.Point(113, 290);
      this.createMemberButton.Name = "createMemberButton";
      this.createMemberButton.Size = new System.Drawing.Size(224, 79);
      this.createMemberButton.TabIndex = 20;
      this.createMemberButton.Text = "Create Member";
      this.createMemberButton.UseVisualStyleBackColor = true;
      // 
      // cellPhoneValue
      // 
      this.cellPhoneValue.Location = new System.Drawing.Point(156, 232);
      this.cellPhoneValue.Name = "cellPhoneValue";
      this.cellPhoneValue.Size = new System.Drawing.Size(238, 43);
      this.cellPhoneValue.TabIndex = 16;
      // 
      // cellPhoneLabel
      // 
      this.cellPhoneLabel.AutoSize = true;
      this.cellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cellPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.cellPhoneLabel.Location = new System.Drawing.Point(6, 235);
      this.cellPhoneLabel.Name = "cellPhoneLabel";
      this.cellPhoneLabel.Size = new System.Drawing.Size(144, 37);
      this.cellPhoneLabel.TabIndex = 15;
      this.cellPhoneLabel.Text = "Cell Phone";
      // 
      // emailValue
      // 
      this.emailValue.Location = new System.Drawing.Point(156, 175);
      this.emailValue.Name = "emailValue";
      this.emailValue.Size = new System.Drawing.Size(238, 43);
      this.emailValue.TabIndex = 14;
      // 
      // emailLabel
      // 
      this.emailLabel.AutoSize = true;
      this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.emailLabel.Location = new System.Drawing.Point(68, 178);
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Size = new System.Drawing.Size(82, 37);
      this.emailLabel.TabIndex = 13;
      this.emailLabel.Text = "Email";
      // 
      // lastNameValue
      // 
      this.lastNameValue.Location = new System.Drawing.Point(156, 118);
      this.lastNameValue.Name = "lastNameValue";
      this.lastNameValue.Size = new System.Drawing.Size(238, 43);
      this.lastNameValue.TabIndex = 12;
      // 
      // lastNameLabel
      // 
      this.lastNameLabel.AutoSize = true;
      this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.lastNameLabel.Location = new System.Drawing.Point(8, 121);
      this.lastNameLabel.Name = "lastNameLabel";
      this.lastNameLabel.Size = new System.Drawing.Size(142, 37);
      this.lastNameLabel.TabIndex = 11;
      this.lastNameLabel.Text = "Last Name";
      // 
      // firstNameValue
      // 
      this.firstNameValue.Location = new System.Drawing.Point(156, 61);
      this.firstNameValue.Name = "firstNameValue";
      this.firstNameValue.Size = new System.Drawing.Size(238, 43);
      this.firstNameValue.TabIndex = 10;
      // 
      // firstNameLabel
      // 
      this.firstNameLabel.AutoSize = true;
      this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.firstNameLabel.Location = new System.Drawing.Point(6, 64);
      this.firstNameLabel.Name = "firstNameLabel";
      this.firstNameLabel.Size = new System.Drawing.Size(144, 37);
      this.firstNameLabel.TabIndex = 9;
      this.firstNameLabel.Text = "First Name";
      // 
      // teamMembersListBox
      // 
      this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.teamMembersListBox.FormattingEnabled = true;
      this.teamMembersListBox.ItemHeight = 30;
      this.teamMembersListBox.Location = new System.Drawing.Point(492, 93);
      this.teamMembersListBox.Name = "teamMembersListBox";
      this.teamMembersListBox.Size = new System.Drawing.Size(339, 662);
      this.teamMembersListBox.TabIndex = 21;
      // 
      // deleteTeamMemberButton
      // 
      this.deleteTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.deleteTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.deleteTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.deleteTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.deleteTeamMemberButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.deleteTeamMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.deleteTeamMemberButton.Location = new System.Drawing.Point(860, 331);
      this.deleteTeamMemberButton.Name = "deleteTeamMemberButton";
      this.deleteTeamMemberButton.Size = new System.Drawing.Size(185, 114);
      this.deleteTeamMemberButton.TabIndex = 22;
      this.deleteTeamMemberButton.Text = "Delete Team Member";
      this.deleteTeamMemberButton.UseVisualStyleBackColor = true;
      // 
      // createTeamButton
      // 
      this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createTeamButton.Location = new System.Drawing.Point(335, 810);
      this.createTeamButton.Name = "createTeamButton";
      this.createTeamButton.Size = new System.Drawing.Size(371, 82);
      this.createTeamButton.TabIndex = 23;
      this.createTeamButton.Text = "Create Team";
      this.createTeamButton.UseVisualStyleBackColor = true;
      // 
      // CreateTeamForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1073, 957);
      this.Controls.Add(this.createTeamButton);
      this.Controls.Add(this.deleteTeamMemberButton);
      this.Controls.Add(this.teamMembersListBox);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.addMemberButton);
      this.Controls.Add(this.selectTeamMemberDropDown);
      this.Controls.Add(this.selectTeamMemberLabel);
      this.Controls.Add(this.teamNameValue);
      this.Controls.Add(this.teamNameLabel);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "CreateTeamForm";
      this.Text = "Create Team";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox teamNameValue;
    private System.Windows.Forms.Label teamNameLabel;
    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.Button addMemberButton;
    private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
    private System.Windows.Forms.Label selectTeamMemberLabel;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button createMemberButton;
    private System.Windows.Forms.TextBox cellPhoneValue;
    private System.Windows.Forms.Label cellPhoneLabel;
    private System.Windows.Forms.TextBox emailValue;
    private System.Windows.Forms.Label emailLabel;
    private System.Windows.Forms.TextBox lastNameValue;
    private System.Windows.Forms.Label lastNameLabel;
    private System.Windows.Forms.TextBox firstNameValue;
    private System.Windows.Forms.Label firstNameLabel;
    private System.Windows.Forms.ListBox teamMembersListBox;
    private System.Windows.Forms.Button deleteTeamMemberButton;
    private System.Windows.Forms.Button createTeamButton;
  }
}