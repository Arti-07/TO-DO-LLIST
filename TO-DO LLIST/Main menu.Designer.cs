
namespace TO_DO_LLIST
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnTodoList = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picboxMyIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBoxMainMenu = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMyIcon)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnSchedule);
            this.panelMenu.Controls.Add(this.btnNotes);
            this.panelMenu.Controls.Add(this.btnTodoList);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(245, 653);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSchedule.Image = global::TO_DO_LLIST.Properties.Resources.icons8_календарь_50;
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(-3, 293);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSchedule.Size = new System.Drawing.Size(245, 74);
            this.btnSchedule.TabIndex = 3;
            this.btnSchedule.Text = "    Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnAchieve_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotes.FlatAppearance.BorderSize = 0;
            this.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNotes.Image = global::TO_DO_LLIST.Properties.Resources.icons8_заметка_50;
            this.btnNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotes.Location = new System.Drawing.Point(-3, 213);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNotes.Size = new System.Drawing.Size(245, 74);
            this.btnNotes.TabIndex = 2;
            this.btnNotes.Text = "    Notes";
            this.btnNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnTodoList
            // 
            this.btnTodoList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodoList.FlatAppearance.BorderSize = 0;
            this.btnTodoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTodoList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTodoList.Image = global::TO_DO_LLIST.Properties.Resources.icons8_сделать_50;
            this.btnTodoList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodoList.Location = new System.Drawing.Point(0, 133);
            this.btnTodoList.Name = "btnTodoList";
            this.btnTodoList.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTodoList.Size = new System.Drawing.Size(245, 74);
            this.btnTodoList.TabIndex = 1;
            this.btnTodoList.Text = "    To-do list";
            this.btnTodoList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodoList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTodoList.UseVisualStyleBackColor = true;
            this.btnTodoList.Click += new System.EventHandler(this.btnTodoList_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.picboxMyIcon);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(245, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // picboxMyIcon
            // 
            this.picboxMyIcon.Image = global::TO_DO_LLIST.Properties.Resources.icons8_reminders_256;
            this.picboxMyIcon.Location = new System.Drawing.Point(3, 3);
            this.picboxMyIcon.Name = "picboxMyIcon";
            this.picboxMyIcon.Size = new System.Drawing.Size(70, 71);
            this.picboxMyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxMyIcon.TabIndex = 1;
            this.picboxMyIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(73, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planning app";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.btnCloseChildForm);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(245, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1087, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(985, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 38);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "●";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(1021, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 38);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "●";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            this.btnMaximize.MouseEnter += new System.EventHandler(this.btnMaximize_MouseEnter);
            this.btnMaximize.MouseLeave += new System.EventHandler(this.btnMaximize_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1057, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "●";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::TO_DO_LLIST.Properties.Resources.icons8_macos_закрыть_64;
            this.btnCloseChildForm.Location = new System.Drawing.Point(6, 12);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(66, 62);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            this.btnCloseChildForm.MouseEnter += new System.EventHandler(this.btnCloseChildForm_MouseEnter);
            this.btnCloseChildForm.MouseLeave += new System.EventHandler(this.btnCloseChildForm_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1087, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "H O M E";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBoxMainMenu);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(245, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1087, 573);
            this.panelDesktop.TabIndex = 2;
            // 
            // pictureBoxMainMenu
            // 
            this.pictureBoxMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMainMenu.Image = global::TO_DO_LLIST.Properties.Resources.Best_To_Do_List_apps_cover;
            this.pictureBoxMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMainMenu.Name = "pictureBoxMainMenu";
            this.pictureBoxMainMenu.Size = new System.Drawing.Size(1087, 573);
            this.pictureBoxMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMainMenu.TabIndex = 0;
            this.pictureBoxMainMenu.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 653);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMyIcon)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTodoList;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picboxMyIcon;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBoxMainMenu;
    }
}

