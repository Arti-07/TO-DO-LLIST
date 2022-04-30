
namespace TO_DO_LLIST.Forms
{
    partial class FormTodoList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTodoList));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuFormDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.colIsFinished = new System.Windows.Forms.DataGridViewImageColumn();
            this.colAim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.btnReadAims = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSaveAims = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDeleteAll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.textBoxYourAim = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnDeleteAim = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAddAim = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.datePicker = new TO_DO_LLIST.DatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuFormDock
            // 
            this.bunifuFormDock.AllowFormDragging = true;
            this.bunifuFormDock.AllowFormDropShadow = true;
            this.bunifuFormDock.AllowFormResizing = true;
            this.bunifuFormDock.AllowHidingBottomRegion = true;
            this.bunifuFormDock.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock.ContainerControl = this;
            this.bunifuFormDock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock.DockingOptions.DockAll = false;
            this.bunifuFormDock.DockingOptions.DockBottomLeft = false;
            this.bunifuFormDock.DockingOptions.DockBottomRight = false;
            this.bunifuFormDock.DockingOptions.DockFullScreen = false;
            this.bunifuFormDock.DockingOptions.DockLeft = false;
            this.bunifuFormDock.DockingOptions.DockRight = false;
            this.bunifuFormDock.DockingOptions.DockTopLeft = false;
            this.bunifuFormDock.DockingOptions.DockTopRight = false;
            this.bunifuFormDock.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock.ParentForm = this;
            this.bunifuFormDock.ShowCursorChanges = true;
            this.bunifuFormDock.ShowDockingIndicators = false;
            this.bunifuFormDock.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock.TitleBarOptions.BunifuFormDock = this.bunifuFormDock;
            this.bunifuFormDock.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "icons8-пустой-чекбокс-50 (1).png");
            this.imageList.Images.SetKeyName(1, "icons8-отмеченный-чекбокс-50 (1).png");
            this.imageList.Images.SetKeyName(2, "icons8-отметить-все-96.png");
            this.imageList.Images.SetKeyName(3, "icons8-отметить-все-50.png");
            // 
            // dataGrid
            // 
            this.dataGrid.AllowCustomTheming = false;
            this.dataGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGrid.ColumnHeadersHeight = 40;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIsFinished,
            this.colAim});
            this.dataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.dataGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.CurrentTheme.BackColor = System.Drawing.Color.Navy;
            this.dataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dataGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.dataGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.CurrentTheme.Name = null;
            this.dataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.dataGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dataGrid.HeaderBackColor = System.Drawing.Color.Navy;
            this.dataGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 40;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(934, 585);
            this.dataGrid.TabIndex = 5;
            this.dataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellMouseEnter);
            // 
            // colIsFinished
            // 
            this.colIsFinished.FillWeight = 60F;
            this.colIsFinished.HeaderText = "Is it finished ?";
            this.colIsFinished.Image = global::TO_DO_LLIST.Properties.Resources.icons8_отмеченный_чекбокс_50;
            this.colIsFinished.MinimumWidth = 6;
            this.colIsFinished.Name = "colIsFinished";
            this.colIsFinished.ReadOnly = true;
            // 
            // colAim
            // 
            this.colAim.FillWeight = 150F;
            this.colAim.HeaderText = "Your aim";
            this.colAim.MinimumWidth = 6;
            this.colAim.Name = "colAim";
            this.colAim.ReadOnly = true;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.datePicker);
            this.panel.Controls.Add(this.btnReadAims);
            this.panel.Controls.Add(this.btnSaveAims);
            this.panel.Controls.Add(this.btnDeleteAll);
            this.panel.Controls.Add(this.textBoxYourAim);
            this.panel.Controls.Add(this.btnDeleteAim);
            this.panel.Controls.Add(this.btnAddAim);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(952, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(368, 585);
            this.panel.TabIndex = 8;
            // 
            // btnReadAims
            // 
            this.btnReadAims.AllowAnimations = true;
            this.btnReadAims.AllowMouseEffects = true;
            this.btnReadAims.AllowToggling = false;
            this.btnReadAims.AnimationSpeed = 200;
            this.btnReadAims.AutoGenerateColors = false;
            this.btnReadAims.AutoRoundBorders = false;
            this.btnReadAims.AutoSizeLeftIcon = true;
            this.btnReadAims.AutoSizeRightIcon = true;
            this.btnReadAims.BackColor = System.Drawing.Color.Transparent;
            this.btnReadAims.BackColor1 = System.Drawing.Color.Cyan;
            this.btnReadAims.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReadAims.BackgroundImage")));
            this.btnReadAims.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnReadAims.ButtonText = "Read your previous aims";
            this.btnReadAims.ButtonTextMarginLeft = 0;
            this.btnReadAims.ColorContrastOnClick = 45;
            this.btnReadAims.ColorContrastOnHover = 45;
            this.btnReadAims.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.btnReadAims.CustomizableEdges = borderEdges11;
            this.btnReadAims.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReadAims.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReadAims.DisabledFillColor = System.Drawing.Color.Cyan;
            this.btnReadAims.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReadAims.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReadAims.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadAims.ForeColor = System.Drawing.Color.Black;
            this.btnReadAims.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadAims.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadAims.IconLeftPadding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.btnReadAims.IconMarginLeft = 11;
            this.btnReadAims.IconPadding = 10;
            this.btnReadAims.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReadAims.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadAims.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReadAims.IconSize = 25;
            this.btnReadAims.IdleBorderColor = System.Drawing.Color.Black;
            this.btnReadAims.IdleBorderRadius = 45;
            this.btnReadAims.IdleBorderThickness = 1;
            this.btnReadAims.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnReadAims.IdleIconLeftImage = global::TO_DO_LLIST.Properties.Resources.icons8_чтение_электронных_книг_50;
            this.btnReadAims.IdleIconRightImage = null;
            this.btnReadAims.IndicateFocus = false;
            this.btnReadAims.Location = new System.Drawing.Point(0, 376);
            this.btnReadAims.Name = "btnReadAims";
            this.btnReadAims.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReadAims.OnDisabledState.BorderRadius = 45;
            this.btnReadAims.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReadAims.OnDisabledState.BorderThickness = 1;
            this.btnReadAims.OnDisabledState.FillColor = System.Drawing.Color.Cyan;
            this.btnReadAims.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReadAims.OnDisabledState.IconLeftImage = null;
            this.btnReadAims.OnDisabledState.IconRightImage = null;
            this.btnReadAims.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnReadAims.onHoverState.BorderRadius = 45;
            this.btnReadAims.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReadAims.onHoverState.BorderThickness = 1;
            this.btnReadAims.onHoverState.FillColor = System.Drawing.Color.Lime;
            this.btnReadAims.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReadAims.onHoverState.IconLeftImage = null;
            this.btnReadAims.onHoverState.IconRightImage = null;
            this.btnReadAims.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnReadAims.OnIdleState.BorderRadius = 45;
            this.btnReadAims.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnReadAims.OnIdleState.BorderThickness = 1;
            this.btnReadAims.OnIdleState.FillColor = System.Drawing.Color.Cyan;
            this.btnReadAims.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnReadAims.OnIdleState.IconLeftImage = global::TO_DO_LLIST.Properties.Resources.icons8_чтение_электронных_книг_50;
            this.btnReadAims.OnIdleState.IconRightImage = null;
            this.btnReadAims.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReadAims.OnPressedState.BorderRadius = 45;
            this.btnReadAims.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReadAims.OnPressedState.BorderThickness = 1;
            this.btnReadAims.OnPressedState.FillColor = System.Drawing.Color.Lime;
            this.btnReadAims.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReadAims.OnPressedState.IconLeftImage = null;
            this.btnReadAims.OnPressedState.IconRightImage = null;
            this.btnReadAims.Size = new System.Drawing.Size(365, 51);
            this.btnReadAims.TabIndex = 10;
            this.btnReadAims.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReadAims.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReadAims.TextMarginLeft = 0;
            this.btnReadAims.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReadAims.UseDefaultRadiusAndThickness = true;
            this.btnReadAims.Click += new System.EventHandler(this.btnReadAims_Click);
            // 
            // btnSaveAims
            // 
            this.btnSaveAims.AllowAnimations = true;
            this.btnSaveAims.AllowMouseEffects = true;
            this.btnSaveAims.AllowToggling = false;
            this.btnSaveAims.AnimationSpeed = 200;
            this.btnSaveAims.AutoGenerateColors = false;
            this.btnSaveAims.AutoRoundBorders = false;
            this.btnSaveAims.AutoSizeLeftIcon = true;
            this.btnSaveAims.AutoSizeRightIcon = true;
            this.btnSaveAims.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAims.BackColor1 = System.Drawing.Color.Cyan;
            this.btnSaveAims.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveAims.BackgroundImage")));
            this.btnSaveAims.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnSaveAims.ButtonText = "Save all";
            this.btnSaveAims.ButtonTextMarginLeft = 0;
            this.btnSaveAims.ColorContrastOnClick = 45;
            this.btnSaveAims.ColorContrastOnHover = 45;
            this.btnSaveAims.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.btnSaveAims.CustomizableEdges = borderEdges12;
            this.btnSaveAims.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveAims.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveAims.DisabledFillColor = System.Drawing.Color.Cyan;
            this.btnSaveAims.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveAims.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSaveAims.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAims.ForeColor = System.Drawing.Color.Black;
            this.btnSaveAims.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAims.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAims.IconLeftPadding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.btnSaveAims.IconMarginLeft = 11;
            this.btnSaveAims.IconPadding = 10;
            this.btnSaveAims.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAims.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAims.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSaveAims.IconSize = 25;
            this.btnSaveAims.IdleBorderColor = System.Drawing.Color.Black;
            this.btnSaveAims.IdleBorderRadius = 45;
            this.btnSaveAims.IdleBorderThickness = 1;
            this.btnSaveAims.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnSaveAims.IdleIconLeftImage = global::TO_DO_LLIST.Properties.Resources.icons8_сохранить_50;
            this.btnSaveAims.IdleIconRightImage = null;
            this.btnSaveAims.IndicateFocus = false;
            this.btnSaveAims.Location = new System.Drawing.Point(0, 319);
            this.btnSaveAims.Name = "btnSaveAims";
            this.btnSaveAims.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveAims.OnDisabledState.BorderRadius = 45;
            this.btnSaveAims.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveAims.OnDisabledState.BorderThickness = 1;
            this.btnSaveAims.OnDisabledState.FillColor = System.Drawing.Color.Cyan;
            this.btnSaveAims.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveAims.OnDisabledState.IconLeftImage = null;
            this.btnSaveAims.OnDisabledState.IconRightImage = null;
            this.btnSaveAims.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSaveAims.onHoverState.BorderRadius = 45;
            this.btnSaveAims.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveAims.onHoverState.BorderThickness = 1;
            this.btnSaveAims.onHoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSaveAims.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSaveAims.onHoverState.IconLeftImage = null;
            this.btnSaveAims.onHoverState.IconRightImage = null;
            this.btnSaveAims.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnSaveAims.OnIdleState.BorderRadius = 45;
            this.btnSaveAims.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnSaveAims.OnIdleState.BorderThickness = 1;
            this.btnSaveAims.OnIdleState.FillColor = System.Drawing.Color.Cyan;
            this.btnSaveAims.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnSaveAims.OnIdleState.IconLeftImage = global::TO_DO_LLIST.Properties.Resources.icons8_сохранить_50;
            this.btnSaveAims.OnIdleState.IconRightImage = null;
            this.btnSaveAims.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSaveAims.OnPressedState.BorderRadius = 45;
            this.btnSaveAims.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveAims.OnPressedState.BorderThickness = 1;
            this.btnSaveAims.OnPressedState.FillColor = System.Drawing.Color.Lime;
            this.btnSaveAims.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSaveAims.OnPressedState.IconLeftImage = null;
            this.btnSaveAims.OnPressedState.IconRightImage = null;
            this.btnSaveAims.Size = new System.Drawing.Size(365, 51);
            this.btnSaveAims.TabIndex = 9;
            this.btnSaveAims.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveAims.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveAims.TextMarginLeft = 0;
            this.btnSaveAims.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSaveAims.UseDefaultRadiusAndThickness = true;
            this.btnSaveAims.Click += new System.EventHandler(this.btnSaveAims_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.AllowAnimations = true;
            this.btnDeleteAll.AllowMouseEffects = true;
            this.btnDeleteAll.AllowToggling = false;
            this.btnDeleteAll.AnimationSpeed = 200;
            this.btnDeleteAll.AutoGenerateColors = false;
            this.btnDeleteAll.AutoRoundBorders = false;
            this.btnDeleteAll.AutoSizeLeftIcon = true;
            this.btnDeleteAll.AutoSizeRightIcon = true;
            this.btnDeleteAll.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAll.BackColor1 = System.Drawing.Color.Cyan;
            this.btnDeleteAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.BackgroundImage")));
            this.btnDeleteAll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnDeleteAll.ButtonText = "Delete all your aims";
            this.btnDeleteAll.ButtonTextMarginLeft = 0;
            this.btnDeleteAll.ColorContrastOnClick = 45;
            this.btnDeleteAll.ColorContrastOnHover = 45;
            this.btnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges13.BottomLeft = true;
            borderEdges13.BottomRight = true;
            borderEdges13.TopLeft = true;
            borderEdges13.TopRight = true;
            this.btnDeleteAll.CustomizableEdges = borderEdges13;
            this.btnDeleteAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteAll.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteAll.DisabledFillColor = System.Drawing.Color.Cyan;
            this.btnDeleteAll.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDeleteAll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDeleteAll.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAll.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAll.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAll.IconLeftPadding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.btnDeleteAll.IconMarginLeft = 11;
            this.btnDeleteAll.IconPadding = 10;
            this.btnDeleteAll.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAll.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAll.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDeleteAll.IconSize = 25;
            this.btnDeleteAll.IdleBorderColor = System.Drawing.Color.Black;
            this.btnDeleteAll.IdleBorderRadius = 45;
            this.btnDeleteAll.IdleBorderThickness = 1;
            this.btnDeleteAll.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnDeleteAll.IdleIconLeftImage = global::TO_DO_LLIST.Properties.Resources.icons8_удалить_навсегда_50;
            this.btnDeleteAll.IdleIconRightImage = null;
            this.btnDeleteAll.IndicateFocus = false;
            this.btnDeleteAll.Location = new System.Drawing.Point(0, 262);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteAll.OnDisabledState.BorderRadius = 45;
            this.btnDeleteAll.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteAll.OnDisabledState.BorderThickness = 1;
            this.btnDeleteAll.OnDisabledState.FillColor = System.Drawing.Color.Cyan;
            this.btnDeleteAll.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDeleteAll.OnDisabledState.IconLeftImage = null;
            this.btnDeleteAll.OnDisabledState.IconRightImage = null;
            this.btnDeleteAll.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDeleteAll.onHoverState.BorderRadius = 45;
            this.btnDeleteAll.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteAll.onHoverState.BorderThickness = 1;
            this.btnDeleteAll.onHoverState.FillColor = System.Drawing.Color.Lime;
            this.btnDeleteAll.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.onHoverState.IconLeftImage = null;
            this.btnDeleteAll.onHoverState.IconRightImage = null;
            this.btnDeleteAll.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteAll.OnIdleState.BorderRadius = 45;
            this.btnDeleteAll.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnDeleteAll.OnIdleState.BorderThickness = 1;
            this.btnDeleteAll.OnIdleState.FillColor = System.Drawing.Color.Cyan;
            this.btnDeleteAll.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAll.OnIdleState.IconLeftImage = global::TO_DO_LLIST.Properties.Resources.icons8_удалить_навсегда_50;
            this.btnDeleteAll.OnIdleState.IconRightImage = null;
            this.btnDeleteAll.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDeleteAll.OnPressedState.BorderRadius = 45;
            this.btnDeleteAll.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteAll.OnPressedState.BorderThickness = 1;
            this.btnDeleteAll.OnPressedState.FillColor = System.Drawing.Color.Lime;
            this.btnDeleteAll.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.OnPressedState.IconLeftImage = null;
            this.btnDeleteAll.OnPressedState.IconRightImage = null;
            this.btnDeleteAll.Size = new System.Drawing.Size(365, 51);
            this.btnDeleteAll.TabIndex = 8;
            this.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteAll.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteAll.TextMarginLeft = 0;
            this.btnDeleteAll.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDeleteAll.UseDefaultRadiusAndThickness = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // textBoxYourAim
            // 
            this.textBoxYourAim.AcceptsReturn = false;
            this.textBoxYourAim.AcceptsTab = false;
            this.textBoxYourAim.AnimationSpeed = 200;
            this.textBoxYourAim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxYourAim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxYourAim.BackColor = System.Drawing.Color.Indigo;
            this.textBoxYourAim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxYourAim.BackgroundImage")));
            this.textBoxYourAim.BorderColorActive = System.Drawing.Color.Cyan;
            this.textBoxYourAim.BorderColorDisabled = System.Drawing.Color.Yellow;
            this.textBoxYourAim.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textBoxYourAim.BorderColorIdle = System.Drawing.Color.PaleGoldenrod;
            this.textBoxYourAim.BorderRadius = 1;
            this.textBoxYourAim.BorderThickness = 6;
            this.textBoxYourAim.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxYourAim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxYourAim.DefaultFont = new System.Drawing.Font("Dubai Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYourAim.DefaultText = "";
            this.textBoxYourAim.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxYourAim.FillColor = System.Drawing.Color.Indigo;
            this.textBoxYourAim.ForeColor = System.Drawing.Color.White;
            this.textBoxYourAim.HideSelection = true;
            this.textBoxYourAim.IconLeft = null;
            this.textBoxYourAim.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxYourAim.IconPadding = 10;
            this.textBoxYourAim.IconRight = null;
            this.textBoxYourAim.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxYourAim.Lines = new string[0];
            this.textBoxYourAim.Location = new System.Drawing.Point(0, 0);
            this.textBoxYourAim.MaxLength = 32767;
            this.textBoxYourAim.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxYourAim.Modified = false;
            this.textBoxYourAim.Multiline = false;
            this.textBoxYourAim.Name = "textBoxYourAim";
            stateProperties9.BorderColor = System.Drawing.Color.Cyan;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxYourAim.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Yellow;
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxYourAim.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxYourAim.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.PaleGoldenrod;
            stateProperties12.FillColor = System.Drawing.Color.Indigo;
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxYourAim.OnIdleState = stateProperties12;
            this.textBoxYourAim.Padding = new System.Windows.Forms.Padding(3);
            this.textBoxYourAim.PasswordChar = '\0';
            this.textBoxYourAim.PlaceholderForeColor = System.Drawing.Color.White;
            this.textBoxYourAim.PlaceholderText = "Enter your aim";
            this.textBoxYourAim.ReadOnly = false;
            this.textBoxYourAim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxYourAim.SelectedText = "";
            this.textBoxYourAim.SelectionLength = 0;
            this.textBoxYourAim.SelectionStart = 0;
            this.textBoxYourAim.ShortcutsEnabled = true;
            this.textBoxYourAim.Size = new System.Drawing.Size(368, 106);
            this.textBoxYourAim.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.textBoxYourAim.TabIndex = 0;
            this.textBoxYourAim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxYourAim.TextMarginBottom = 0;
            this.textBoxYourAim.TextMarginLeft = 3;
            this.textBoxYourAim.TextMarginTop = 0;
            this.textBoxYourAim.TextPlaceholder = "Enter your aim";
            this.textBoxYourAim.UseSystemPasswordChar = false;
            this.textBoxYourAim.WordWrap = true;
            // 
            // btnDeleteAim
            // 
            this.btnDeleteAim.AllowAnimations = true;
            this.btnDeleteAim.AllowMouseEffects = true;
            this.btnDeleteAim.AllowToggling = false;
            this.btnDeleteAim.AnimationSpeed = 200;
            this.btnDeleteAim.AutoGenerateColors = false;
            this.btnDeleteAim.AutoRoundBorders = false;
            this.btnDeleteAim.AutoSizeLeftIcon = true;
            this.btnDeleteAim.AutoSizeRightIcon = true;
            this.btnDeleteAim.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAim.BackColor1 = System.Drawing.Color.Cyan;
            this.btnDeleteAim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteAim.BackgroundImage")));
            this.btnDeleteAim.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnDeleteAim.ButtonText = "Delete selected aim";
            this.btnDeleteAim.ButtonTextMarginLeft = 0;
            this.btnDeleteAim.ColorContrastOnClick = 45;
            this.btnDeleteAim.ColorContrastOnHover = 45;
            this.btnDeleteAim.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges14.BottomLeft = true;
            borderEdges14.BottomRight = true;
            borderEdges14.TopLeft = true;
            borderEdges14.TopRight = true;
            this.btnDeleteAim.CustomizableEdges = borderEdges14;
            this.btnDeleteAim.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteAim.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteAim.DisabledFillColor = System.Drawing.Color.Cyan;
            this.btnDeleteAim.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDeleteAim.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDeleteAim.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAim.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAim.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAim.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAim.IconLeftPadding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.btnDeleteAim.IconMarginLeft = 11;
            this.btnDeleteAim.IconPadding = 10;
            this.btnDeleteAim.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAim.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAim.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDeleteAim.IconSize = 25;
            this.btnDeleteAim.IdleBorderColor = System.Drawing.Color.Black;
            this.btnDeleteAim.IdleBorderRadius = 45;
            this.btnDeleteAim.IdleBorderThickness = 1;
            this.btnDeleteAim.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnDeleteAim.IdleIconLeftImage = global::TO_DO_LLIST.Properties.Resources.icons8_удалить_50;
            this.btnDeleteAim.IdleIconRightImage = null;
            this.btnDeleteAim.IndicateFocus = false;
            this.btnDeleteAim.Location = new System.Drawing.Point(3, 167);
            this.btnDeleteAim.Name = "btnDeleteAim";
            this.btnDeleteAim.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteAim.OnDisabledState.BorderRadius = 45;
            this.btnDeleteAim.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteAim.OnDisabledState.BorderThickness = 1;
            this.btnDeleteAim.OnDisabledState.FillColor = System.Drawing.Color.Cyan;
            this.btnDeleteAim.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDeleteAim.OnDisabledState.IconLeftImage = null;
            this.btnDeleteAim.OnDisabledState.IconRightImage = null;
            this.btnDeleteAim.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDeleteAim.onHoverState.BorderRadius = 45;
            this.btnDeleteAim.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteAim.onHoverState.BorderThickness = 1;
            this.btnDeleteAim.onHoverState.FillColor = System.Drawing.Color.Lime;
            this.btnDeleteAim.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAim.onHoverState.IconLeftImage = null;
            this.btnDeleteAim.onHoverState.IconRightImage = null;
            this.btnDeleteAim.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteAim.OnIdleState.BorderRadius = 45;
            this.btnDeleteAim.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnDeleteAim.OnIdleState.BorderThickness = 1;
            this.btnDeleteAim.OnIdleState.FillColor = System.Drawing.Color.Cyan;
            this.btnDeleteAim.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAim.OnIdleState.IconLeftImage = global::TO_DO_LLIST.Properties.Resources.icons8_удалить_50;
            this.btnDeleteAim.OnIdleState.IconRightImage = null;
            this.btnDeleteAim.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDeleteAim.OnPressedState.BorderRadius = 45;
            this.btnDeleteAim.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteAim.OnPressedState.BorderThickness = 1;
            this.btnDeleteAim.OnPressedState.FillColor = System.Drawing.Color.Lime;
            this.btnDeleteAim.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAim.OnPressedState.IconLeftImage = null;
            this.btnDeleteAim.OnPressedState.IconRightImage = null;
            this.btnDeleteAim.Size = new System.Drawing.Size(365, 51);
            this.btnDeleteAim.TabIndex = 7;
            this.btnDeleteAim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteAim.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteAim.TextMarginLeft = 0;
            this.btnDeleteAim.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDeleteAim.UseDefaultRadiusAndThickness = true;
            this.btnDeleteAim.Click += new System.EventHandler(this.btnDeleteAim_Click);
            // 
            // btnAddAim
            // 
            this.btnAddAim.AllowAnimations = true;
            this.btnAddAim.AllowMouseEffects = true;
            this.btnAddAim.AllowToggling = false;
            this.btnAddAim.AnimationSpeed = 200;
            this.btnAddAim.AutoGenerateColors = false;
            this.btnAddAim.AutoRoundBorders = false;
            this.btnAddAim.AutoSizeLeftIcon = true;
            this.btnAddAim.AutoSizeRightIcon = true;
            this.btnAddAim.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAim.BackColor1 = System.Drawing.Color.Cyan;
            this.btnAddAim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAim.BackgroundImage")));
            this.btnAddAim.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnAddAim.ButtonText = "Add aim";
            this.btnAddAim.ButtonTextMarginLeft = 0;
            this.btnAddAim.ColorContrastOnClick = 45;
            this.btnAddAim.ColorContrastOnHover = 45;
            this.btnAddAim.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges15.BottomLeft = true;
            borderEdges15.BottomRight = true;
            borderEdges15.TopLeft = true;
            borderEdges15.TopRight = true;
            this.btnAddAim.CustomizableEdges = borderEdges15;
            this.btnAddAim.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddAim.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddAim.DisabledFillColor = System.Drawing.Color.Cyan;
            this.btnAddAim.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddAim.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddAim.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAim.ForeColor = System.Drawing.Color.Black;
            this.btnAddAim.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAim.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAim.IconLeftPadding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.btnAddAim.IconMarginLeft = 11;
            this.btnAddAim.IconPadding = 10;
            this.btnAddAim.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAim.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAim.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddAim.IconSize = 25;
            this.btnAddAim.IdleBorderColor = System.Drawing.Color.Black;
            this.btnAddAim.IdleBorderRadius = 45;
            this.btnAddAim.IdleBorderThickness = 1;
            this.btnAddAim.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnAddAim.IdleIconLeftImage = global::TO_DO_LLIST.Properties.Resources.icons8_добавить_столбец_50__1_;
            this.btnAddAim.IdleIconRightImage = null;
            this.btnAddAim.IndicateFocus = false;
            this.btnAddAim.Location = new System.Drawing.Point(3, 110);
            this.btnAddAim.Name = "btnAddAim";
            this.btnAddAim.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddAim.OnDisabledState.BorderRadius = 45;
            this.btnAddAim.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddAim.OnDisabledState.BorderThickness = 1;
            this.btnAddAim.OnDisabledState.FillColor = System.Drawing.Color.Cyan;
            this.btnAddAim.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddAim.OnDisabledState.IconLeftImage = null;
            this.btnAddAim.OnDisabledState.IconRightImage = null;
            this.btnAddAim.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddAim.onHoverState.BorderRadius = 45;
            this.btnAddAim.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddAim.onHoverState.BorderThickness = 1;
            this.btnAddAim.onHoverState.FillColor = System.Drawing.Color.Lime;
            this.btnAddAim.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddAim.onHoverState.IconLeftImage = null;
            this.btnAddAim.onHoverState.IconRightImage = null;
            this.btnAddAim.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnAddAim.OnIdleState.BorderRadius = 45;
            this.btnAddAim.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnAddAim.OnIdleState.BorderThickness = 1;
            this.btnAddAim.OnIdleState.FillColor = System.Drawing.Color.Cyan;
            this.btnAddAim.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnAddAim.OnIdleState.IconLeftImage = global::TO_DO_LLIST.Properties.Resources.icons8_добавить_столбец_50__1_;
            this.btnAddAim.OnIdleState.IconRightImage = null;
            this.btnAddAim.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddAim.OnPressedState.BorderRadius = 45;
            this.btnAddAim.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddAim.OnPressedState.BorderThickness = 1;
            this.btnAddAim.OnPressedState.FillColor = System.Drawing.Color.Lime;
            this.btnAddAim.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddAim.OnPressedState.IconLeftImage = null;
            this.btnAddAim.OnPressedState.IconRightImage = null;
            this.btnAddAim.Size = new System.Drawing.Size(365, 51);
            this.btnAddAim.TabIndex = 6;
            this.btnAddAim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAim.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddAim.TextMarginLeft = 0;
            this.btnAddAim.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddAim.UseDefaultRadiusAndThickness = true;
            this.btnAddAim.Click += new System.EventHandler(this.btnAddAim_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 40F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::TO_DO_LLIST.Properties.Resources.icons8_отмеченный_чекбокс_50;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 143;
            // 
            // datePicker
            // 
            this.datePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePicker.BorderSize = 0;
            this.datePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.MediumPurple;
            this.datePicker.CustomFormat = "MMMM dd, yyy";
            this.datePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePicker.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(3, 493);
            this.datePicker.MinimumSize = new System.Drawing.Size(0, 35);
            this.datePicker.Name = "datePicker";
            this.datePicker.RightToLeftLayout = true;
            this.datePicker.Size = new System.Drawing.Size(362, 41);
            this.datePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.datePicker.TabIndex = 11;
            this.datePicker.TextColor = System.Drawing.Color.White;
            // 
            // FormTodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1320, 585);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGrid);
            this.Name = "FormTodoList";
            this.Text = "TodoList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTodoList_FormClosing);
            this.Load += new System.EventHandler(this.FormTodoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ImageList imageList;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGrid;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddAim;
        private Bunifu.UI.WinForms.BunifuTextBox textBoxYourAim;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteAim;
        private System.Windows.Forms.Panel panel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReadAims;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveAims;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteAll;
        private System.Windows.Forms.DataGridViewImageColumn colIsFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAim;
        private DatePicker datePicker;
    }
}