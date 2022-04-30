
namespace TO_DO_LLIST.Forms
{
    partial class FormNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotes));
            this.noteBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLineCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusWordsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteBox
            // 
            this.noteBox.BackColor = System.Drawing.Color.Khaki;
            this.noteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteBox.Location = new System.Drawing.Point(0, 30);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(800, 420);
            this.noteBox.TabIndex = 0;
            this.noteBox.Text = "";
            this.noteBox.TextChanged += new System.EventHandler(this.noteBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFile,
            this.tsEdit,
            this.tsFormat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsFile
            // 
            this.tsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCreate,
            this.tsOpen,
            this.tsSave,
            this.tsSaveAs,
            this.tsPrint});
            this.tsFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsFile.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsFile.Name = "tsFile";
            this.tsFile.Size = new System.Drawing.Size(47, 26);
            this.tsFile.Text = "File";
            // 
            // tsCreate
            // 
            this.tsCreate.Name = "tsCreate";
            this.tsCreate.ShortcutKeyDisplayString = "";
            this.tsCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsCreate.Size = new System.Drawing.Size(222, 26);
            this.tsCreate.Text = "Create";
            this.tsCreate.Click += new System.EventHandler(this.tsCreate_Click);
            // 
            // tsOpen
            // 
            this.tsOpen.Name = "tsOpen";
            this.tsOpen.ShortcutKeyDisplayString = "";
            this.tsOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsOpen.Size = new System.Drawing.Size(222, 26);
            this.tsOpen.Text = "Open...";
            this.tsOpen.Click += new System.EventHandler(this.tsOpen_Click);
            // 
            // tsSave
            // 
            this.tsSave.Name = "tsSave";
            this.tsSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsSave.Size = new System.Drawing.Size(222, 26);
            this.tsSave.Text = "Save";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsSaveAs
            // 
            this.tsSaveAs.Name = "tsSaveAs";
            this.tsSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.tsSaveAs.Size = new System.Drawing.Size(222, 26);
            this.tsSaveAs.Text = "Save as";
            this.tsSaveAs.Click += new System.EventHandler(this.tsSaveAs_Click);
            // 
            // tsPrint
            // 
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsPrint.Size = new System.Drawing.Size(222, 26);
            this.tsPrint.Text = "Print...";
            this.tsPrint.Click += new System.EventHandler(this.tsPrint_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCancel,
            this.tsCut,
            this.tsCopy,
            this.tsPaste,
            this.tsDelete});
            this.tsEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(49, 26);
            this.tsEdit.Text = "Edit";
            // 
            // tsCancel
            // 
            this.tsCancel.Name = "tsCancel";
            this.tsCancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsCancel.Size = new System.Drawing.Size(189, 26);
            this.tsCancel.Text = "Cancel";
            this.tsCancel.Click += new System.EventHandler(this.tsCancel_Click);
            // 
            // tsCut
            // 
            this.tsCut.Name = "tsCut";
            this.tsCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsCut.Size = new System.Drawing.Size(189, 26);
            this.tsCut.Text = "Cut";
            this.tsCut.Click += new System.EventHandler(this.tsCut_Click);
            // 
            // tsCopy
            // 
            this.tsCopy.Name = "tsCopy";
            this.tsCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsCopy.Size = new System.Drawing.Size(189, 26);
            this.tsCopy.Text = "Copy";
            this.tsCopy.Click += new System.EventHandler(this.tsCopy_Click);
            // 
            // tsPaste
            // 
            this.tsPaste.Name = "tsPaste";
            this.tsPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsPaste.Size = new System.Drawing.Size(189, 26);
            this.tsPaste.Text = "Paste";
            this.tsPaste.Click += new System.EventHandler(this.tsPaste_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsDelete.Size = new System.Drawing.Size(189, 26);
            this.tsDelete.Text = "Delete";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // tsFormat
            // 
            this.tsFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFont,
            this.tsFontColor});
            this.tsFormat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsFormat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsFormat.Name = "tsFormat";
            this.tsFormat.Size = new System.Drawing.Size(72, 26);
            this.tsFormat.Text = "Format";
            // 
            // tsFont
            // 
            this.tsFont.Name = "tsFont";
            this.tsFont.Size = new System.Drawing.Size(162, 26);
            this.tsFont.Text = "Font";
            this.tsFont.Click += new System.EventHandler(this.tsFont_Click);
            // 
            // tsFontColor
            // 
            this.tsFontColor.Name = "tsFontColor";
            this.tsFontColor.Size = new System.Drawing.Size(162, 26);
            this.tsFontColor.Text = "Font color";
            this.tsFontColor.Click += new System.EventHandler(this.tsFontColor_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1,
            this.statusLineCount,
            this.statusLabel2,
            this.statusWordsCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip";
            // 
            // statusLabel1
            // 
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(139, 20);
            this.statusLabel1.Text = "Количество строк :";
            // 
            // statusLineCount
            // 
            this.statusLineCount.Name = "statusLineCount";
            this.statusLineCount.Size = new System.Drawing.Size(29, 20);
            this.statusLineCount.Text = "\"0\"";
            // 
            // statusLabel2
            // 
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(133, 20);
            this.statusLabel2.Text = "Количество слов :";
            // 
            // statusWordsCount
            // 
            this.statusWordsCount.Name = "statusWordsCount";
            this.statusWordsCount.Size = new System.Drawing.Size(29, 20);
            this.statusWordsCount.Text = "\"0\"";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNotes";
            this.Text = "Notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNotes_FormClosing);
            this.Load += new System.EventHandler(this.FormNotes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsFile;
        private System.Windows.Forms.ToolStripMenuItem tsCreate;
        private System.Windows.Forms.ToolStripMenuItem tsOpen;
        private System.Windows.Forms.ToolStripMenuItem tsSave;
        private System.Windows.Forms.ToolStripMenuItem tsSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsPrint;
        private System.Windows.Forms.ToolStripMenuItem tsEdit;
        private System.Windows.Forms.ToolStripMenuItem tsCancel;
        private System.Windows.Forms.ToolStripMenuItem tsCut;
        private System.Windows.Forms.ToolStripMenuItem tsCopy;
        private System.Windows.Forms.ToolStripMenuItem tsPaste;
        private System.Windows.Forms.ToolStripMenuItem tsDelete;
        private System.Windows.Forms.ToolStripMenuItem tsFormat;
        private System.Windows.Forms.ToolStripMenuItem tsFont;
        private System.Windows.Forms.ToolStripMenuItem tsFontColor;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        public System.Windows.Forms.RichTextBox noteBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLineCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusWordsCount;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}