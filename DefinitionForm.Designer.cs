namespace AT1_Wiki_App
{
    partial class DefinitionForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.StructureTextBox = new System.Windows.Forms.TextBox();
            this.DefinitionTextBox = new System.Windows.Forms.TextBox();
            this.CatagoryTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Catagory = new System.Windows.Forms.Label();
            this.Structure = new System.Windows.Forms.Label();
            this.Definition = new System.Windows.Forms.Label();
            this.EditInfo = new System.Windows.Forms.Button();
            this.ClearInfo = new System.Windows.Forms.Button();
            this.DeleteEntry = new System.Windows.Forms.Button();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.NameListView = new System.Windows.Forms.ListView();
            this.NameListLabel = new System.Windows.Forms.Label();
            this.LoadData = new System.Windows.Forms.Button();
            this.AddInfo = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(348, 57);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(145, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // StructureTextBox
            // 
            this.StructureTextBox.Location = new System.Drawing.Point(645, 57);
            this.StructureTextBox.Name = "StructureTextBox";
            this.StructureTextBox.Size = new System.Drawing.Size(143, 20);
            this.StructureTextBox.TabIndex = 1;
            this.StructureTextBox.TextChanged += new System.EventHandler(this.StructureTextBox_TextChanged);
            // 
            // DefinitionTextBox
            // 
            this.DefinitionTextBox.Location = new System.Drawing.Point(348, 101);
            this.DefinitionTextBox.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.DefinitionTextBox.Multiline = true;
            this.DefinitionTextBox.Name = "DefinitionTextBox";
            this.DefinitionTextBox.Size = new System.Drawing.Size(440, 337);
            this.DefinitionTextBox.TabIndex = 2;
            this.DefinitionTextBox.TextChanged += new System.EventHandler(this.DefinitionTextBox_TextChanged);
            // 
            // CatagoryTextBox
            // 
            this.CatagoryTextBox.Location = new System.Drawing.Point(499, 57);
            this.CatagoryTextBox.Name = "CatagoryTextBox";
            this.CatagoryTextBox.Size = new System.Drawing.Size(140, 20);
            this.CatagoryTextBox.TabIndex = 3;
            this.CatagoryTextBox.TextChanged += new System.EventHandler(this.CatagoryTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(345, 41);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // Catagory
            // 
            this.Catagory.AutoSize = true;
            this.Catagory.Location = new System.Drawing.Point(496, 41);
            this.Catagory.Name = "Catagory";
            this.Catagory.Size = new System.Drawing.Size(49, 13);
            this.Catagory.TabIndex = 5;
            this.Catagory.Text = "Catagory";
            // 
            // Structure
            // 
            this.Structure.AutoSize = true;
            this.Structure.Location = new System.Drawing.Point(642, 41);
            this.Structure.Name = "Structure";
            this.Structure.Size = new System.Drawing.Size(50, 13);
            this.Structure.TabIndex = 6;
            this.Structure.Text = "Structure";
            // 
            // Definition
            // 
            this.Definition.AutoSize = true;
            this.Definition.Location = new System.Drawing.Point(345, 85);
            this.Definition.Name = "Definition";
            this.Definition.Size = new System.Drawing.Size(51, 13);
            this.Definition.TabIndex = 7;
            this.Definition.Text = "Definition";
            this.Definition.Click += new System.EventHandler(this.Definition_Click);
            // 
            // EditInfo
            // 
            this.EditInfo.Location = new System.Drawing.Point(78, 130);
            this.EditInfo.Name = "EditInfo";
            this.EditInfo.Size = new System.Drawing.Size(75, 23);
            this.EditInfo.TabIndex = 10;
            this.EditInfo.Text = "Save Edit";
            this.EditInfo.UseVisualStyleBackColor = true;
            this.EditInfo.Click += new System.EventHandler(this.EditInfo_Click);
            // 
            // ClearInfo
            // 
            this.ClearInfo.Location = new System.Drawing.Point(78, 159);
            this.ClearInfo.Name = "ClearInfo";
            this.ClearInfo.Size = new System.Drawing.Size(75, 23);
            this.ClearInfo.TabIndex = 11;
            this.ClearInfo.Text = "Clear Info";
            this.ClearInfo.UseVisualStyleBackColor = true;
            this.ClearInfo.Click += new System.EventHandler(this.ClearInfo_Click);
            // 
            // DeleteEntry
            // 
            this.DeleteEntry.Location = new System.Drawing.Point(78, 188);
            this.DeleteEntry.Name = "DeleteEntry";
            this.DeleteEntry.Size = new System.Drawing.Size(75, 23);
            this.DeleteEntry.TabIndex = 12;
            this.DeleteEntry.Text = "Delete Entry";
            this.DeleteEntry.UseVisualStyleBackColor = true;
            this.DeleteEntry.Click += new System.EventHandler(this.DeleteEntry_Click);
            // 
            // BubbleSort
            // 
            this.BubbleSort.Location = new System.Drawing.Point(78, 217);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(75, 23);
            this.BubbleSort.TabIndex = 13;
            this.BubbleSort.Text = "Bubble Sort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // NameListView
            // 
            this.NameListView.HideSelection = false;
            this.NameListView.Location = new System.Drawing.Point(159, 101);
            this.NameListView.Name = "NameListView";
            this.NameListView.Size = new System.Drawing.Size(164, 337);
            this.NameListView.TabIndex = 14;
            this.NameListView.UseCompatibleStateImageBehavior = false;
            this.NameListView.SelectedIndexChanged += new System.EventHandler(this.NameListView_SelectedIndexChanged);
            // 
            // NameListLabel
            // 
            this.NameListLabel.AutoSize = true;
            this.NameListLabel.Location = new System.Drawing.Point(156, 85);
            this.NameListLabel.Name = "NameListLabel";
            this.NameListLabel.Size = new System.Drawing.Size(54, 13);
            this.NameListLabel.TabIndex = 15;
            this.NameListLabel.Text = "Name List";
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(78, 99);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(75, 23);
            this.LoadData.TabIndex = 17;
            this.LoadData.Text = "Load Data";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // AddInfo
            // 
            this.AddInfo.Location = new System.Drawing.Point(78, 246);
            this.AddInfo.Name = "AddInfo";
            this.AddInfo.Size = new System.Drawing.Size(75, 23);
            this.AddInfo.TabIndex = 18;
            this.AddInfo.Text = "Add Info";
            this.AddInfo.UseVisualStyleBackColor = true;
            this.AddInfo.Click += new System.EventHandler(this.AddInfo_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(78, 57);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 19;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(159, 57);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(164, 20);
            this.SearchTextBox.TabIndex = 20;
            // 
            // DefinitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddInfo);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.NameListLabel);
            this.Controls.Add(this.NameListView);
            this.Controls.Add(this.DeleteEntry);
            this.Controls.Add(this.ClearInfo);
            this.Controls.Add(this.EditInfo);
            this.Controls.Add(this.Definition);
            this.Controls.Add(this.Structure);
            this.Controls.Add(this.Catagory);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CatagoryTextBox);
            this.Controls.Add(this.DefinitionTextBox);
            this.Controls.Add(this.StructureTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "DefinitionForm";
            this.Text = "Definition Form";
            this.Load += new System.EventHandler(this.DefinitionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox StructureTextBox;
        private System.Windows.Forms.TextBox DefinitionTextBox;
        private System.Windows.Forms.TextBox CatagoryTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label Catagory;
        private System.Windows.Forms.Label Structure;
        private System.Windows.Forms.Label Definition;
        private System.Windows.Forms.Button EditInfo;
        private System.Windows.Forms.Button ClearInfo;
        private System.Windows.Forms.Button DeleteEntry;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.ListView NameListView;
        private System.Windows.Forms.Label NameListLabel;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.Button AddInfo;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}

