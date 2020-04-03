namespace trainingBoard
{
    partial class Main1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeTrainingBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSyndicat = new System.Windows.Forms.Button();
            this.buttonStagiaire = new System.Windows.Forms.Button();
            this.buttonMutualFormation = new System.Windows.Forms.Button();
            this.buttonFormateur = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.optionToolStripMenuItem.Text = "&Outils";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::trainingBoard.Properties.Resources.app_option;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.optionsToolStripMenuItem.Text = "Options...";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeTrainingBoardToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // aProposDeTrainingBoardToolStripMenuItem
            // 
            this.aProposDeTrainingBoardToolStripMenuItem.Image = global::trainingBoard.Properties.Resources.help;
            this.aProposDeTrainingBoardToolStripMenuItem.Name = "aProposDeTrainingBoardToolStripMenuItem";
            this.aProposDeTrainingBoardToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.aProposDeTrainingBoardToolStripMenuItem.Text = "A propos de trainingBoard";
            this.aProposDeTrainingBoardToolStripMenuItem.Click += new System.EventHandler(this.aProposDeTrainingBoardToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1256, 634);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisir une action a effectué";
            // 
            // buttonSyndicat
            // 
            this.buttonSyndicat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSyndicat.AutoSize = true;
            this.buttonSyndicat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(120)))), ((int)(((byte)(67)))));
            this.buttonSyndicat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSyndicat.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSyndicat.FlatAppearance.BorderSize = 2;
            this.buttonSyndicat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSyndicat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSyndicat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSyndicat.Image = global::trainingBoard.Properties.Resources.Syndicat;
            this.buttonSyndicat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSyndicat.Location = new System.Drawing.Point(135, 347);
            this.buttonSyndicat.Margin = new System.Windows.Forms.Padding(3, 40, 75, 3);
            this.buttonSyndicat.Name = "buttonSyndicat";
            this.buttonSyndicat.Size = new System.Drawing.Size(415, 260);
            this.buttonSyndicat.TabIndex = 3;
            this.buttonSyndicat.Text = "Syndicat";
            this.buttonSyndicat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSyndicat.UseVisualStyleBackColor = false;
            // 
            // buttonStagiaire
            // 
            this.buttonStagiaire.AutoSize = true;
            this.buttonStagiaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(167)))), ((int)(((byte)(45)))));
            this.buttonStagiaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStagiaire.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonStagiaire.FlatAppearance.BorderSize = 2;
            this.buttonStagiaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStagiaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStagiaire.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStagiaire.Image = global::trainingBoard.Properties.Resources.Stagiaire;
            this.buttonStagiaire.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStagiaire.Location = new System.Drawing.Point(700, 347);
            this.buttonStagiaire.Margin = new System.Windows.Forms.Padding(75, 40, 3, 3);
            this.buttonStagiaire.Name = "buttonStagiaire";
            this.buttonStagiaire.Size = new System.Drawing.Size(415, 260);
            this.buttonStagiaire.TabIndex = 4;
            this.buttonStagiaire.Text = "Stagiaire";
            this.buttonStagiaire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStagiaire.UseVisualStyleBackColor = false;
            // 
            // buttonMutualFormation
            // 
            this.buttonMutualFormation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMutualFormation.AutoSize = true;
            this.buttonMutualFormation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(231)))));
            this.buttonMutualFormation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMutualFormation.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonMutualFormation.FlatAppearance.BorderSize = 2;
            this.buttonMutualFormation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMutualFormation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMutualFormation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMutualFormation.Image = global::trainingBoard.Properties.Resources.Mutuel;
            this.buttonMutualFormation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMutualFormation.Location = new System.Drawing.Point(135, 7);
            this.buttonMutualFormation.Margin = new System.Windows.Forms.Padding(3, 3, 75, 40);
            this.buttonMutualFormation.Name = "buttonMutualFormation";
            this.buttonMutualFormation.Size = new System.Drawing.Size(415, 260);
            this.buttonMutualFormation.TabIndex = 1;
            this.buttonMutualFormation.Text = "Mutual Formation";
            this.buttonMutualFormation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMutualFormation.UseVisualStyleBackColor = false;
            // 
            // buttonFormateur
            // 
            this.buttonFormateur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFormateur.AutoSize = true;
            this.buttonFormateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.buttonFormateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFormateur.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonFormateur.FlatAppearance.BorderSize = 2;
            this.buttonFormateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormateur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonFormateur.Image = global::trainingBoard.Properties.Resources.Formateur;
            this.buttonFormateur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFormateur.Location = new System.Drawing.Point(700, 7);
            this.buttonFormateur.Margin = new System.Windows.Forms.Padding(75, 3, 3, 40);
            this.buttonFormateur.Name = "buttonFormateur";
            this.buttonFormateur.Size = new System.Drawing.Size(415, 260);
            this.buttonFormateur.TabIndex = 2;
            this.buttonFormateur.Text = "Formateur";
            this.buttonFormateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFormateur.UseVisualStyleBackColor = false;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuitter.AutoSize = true;
            this.buttonQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(1197, 671);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 28);
            this.buttonQuitter.TabIndex = 6;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = false;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonMutualFormation, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonStagiaire, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonFormateur, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSyndicat, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1250, 614);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1300, 750);
            this.Name = "Main1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main1";
            this.Load += new System.EventHandler(this.Main1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeTrainingBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Button buttonMutualFormation;
        private System.Windows.Forms.Button buttonFormateur;
        private System.Windows.Forms.Button buttonSyndicat;
        private System.Windows.Forms.Button buttonStagiaire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

