namespace WinFormsApp1 {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            fontDialog1 = new FontDialog();
            toolStrip1 = new ToolStrip();
            toolStripButtonSave = new ToolStripButton();
            toolStripButtonOpen = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButtonUndo = new ToolStripButton();
            toolStripButtonRedo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            FontStripComboBox = new ToolStripComboBox();
            FontSizeComboBox = new ToolStripComboBox();
            toolStripButtonIncrease = new ToolStripButton();
            toolStripButtonDecrease = new ToolStripButton();
            toolStripDropDownButtonFontColor = new ToolStripDropDownButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButtonBold = new ToolStripButton();
            toolStripButtonItalic = new ToolStripButton();
            toolStripButtonUnderline = new ToolStripButton();
            toolStripButtonSubScript = new ToolStripButton();
            toolStripButtonSuperScript = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButtonLeftAlign = new ToolStripButton();
            toolStripButtonCenterAlign = new ToolStripButton();
            toolStripButtonRightAlign = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButtonBulletList = new ToolStripButton();
            toolStripSeparator10 = new ToolStripSeparator();
            colorDialog1 = new ColorDialog();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItemCreate = new ToolStripMenuItem();
            ToolStripMenuItemOpen = new ToolStripMenuItem();
            ToolStripMenuItemSave = new ToolStripMenuItem();
            toolStripSeparator9 = new ToolStripSeparator();
            ToolStripMenuItemPrint = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            ToolStripMenuItemExit = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemUndo = new ToolStripMenuItem();
            ToolStripMenuItemRedo = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            ToolStripMenuItemCut = new ToolStripMenuItem();
            ToolStripMenuItemCopy = new ToolStripMenuItem();
            ToolStripMenuItemPaste = new ToolStripMenuItem();
            ToolStripMenuItemDelete = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            ToolStripMenuItemSelectAll = new ToolStripMenuItem();
            ToolStripMenuItemClear = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItemSubScript = new ToolStripMenuItem();
            ToolStripMenuItemSuperscript = new ToolStripMenuItem();
            ToolStripMenuItemFont = new ToolStripMenuItem();
            ToolStripMenuItemWordWrap = new ToolStripMenuItem();
            ToolStripMenuItemClearFormatting = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            richTextBox = new RichTextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelLine = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // fontDialog1
            // 
            fontDialog1.ShowApply = true;
            fontDialog1.ShowColor = true;
            fontDialog1.ShowHelp = true;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = SystemColors.MenuBar;
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonSave, toolStripButtonOpen, toolStripSeparator2, toolStripButtonUndo, toolStripButtonRedo, toolStripSeparator1, FontStripComboBox, FontSizeComboBox, toolStripButtonIncrease, toolStripButtonDecrease, toolStripDropDownButtonFontColor, toolStripSeparator4, toolStripButtonBold, toolStripButtonItalic, toolStripButtonUnderline, toolStripButtonSubScript, toolStripButtonSuperScript, toolStripSeparator3, toolStripButtonLeftAlign, toolStripButtonCenterAlign, toolStripButtonRightAlign, toolStripSeparator5, toolStripButtonBulletList, toolStripSeparator10 });
            toolStrip1.Location = new Point(0, 32);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1043, 41);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(34, 38);
            toolStripButtonSave.Text = "Сохранить";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // toolStripButtonOpen
            // 
            toolStripButtonOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonOpen.Image = (Image)resources.GetObject("toolStripButtonOpen.Image");
            toolStripButtonOpen.ImageTransparentColor = Color.Magenta;
            toolStripButtonOpen.Name = "toolStripButtonOpen";
            toolStripButtonOpen.Size = new Size(34, 38);
            toolStripButtonOpen.Text = "Открыть";
            toolStripButtonOpen.Click += toolStripButtonOpen_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 41);
            // 
            // toolStripButtonUndo
            // 
            toolStripButtonUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonUndo.Image = (Image)resources.GetObject("toolStripButtonUndo.Image");
            toolStripButtonUndo.ImageTransparentColor = Color.Magenta;
            toolStripButtonUndo.Name = "toolStripButtonUndo";
            toolStripButtonUndo.Size = new Size(34, 38);
            toolStripButtonUndo.Text = "Отменить";
            toolStripButtonUndo.Click += toolStripButtonUndo_Click;
            // 
            // toolStripButtonRedo
            // 
            toolStripButtonRedo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRedo.Image = (Image)resources.GetObject("toolStripButtonRedo.Image");
            toolStripButtonRedo.ImageTransparentColor = Color.Magenta;
            toolStripButtonRedo.Name = "toolStripButtonRedo";
            toolStripButtonRedo.Size = new Size(34, 38);
            toolStripButtonRedo.Text = "Восстановить";
            toolStripButtonRedo.Click += toolStripButtonRedo_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 41);
            // 
            // FontStripComboBox
            // 
            FontStripComboBox.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FontStripComboBox.Name = "FontStripComboBox";
            FontStripComboBox.Size = new Size(121, 41);
            FontStripComboBox.Text = "Шрифты";
            FontStripComboBox.SelectedIndexChanged += fontStripComboBox_SelectedIndexChanged;
            // 
            // FontSizeComboBox
            // 
            FontSizeComboBox.IntegralHeight = false;
            FontSizeComboBox.Name = "FontSizeComboBox";
            FontSizeComboBox.Size = new Size(140, 41);
            FontSizeComboBox.Text = "Размер шрифта";
            FontSizeComboBox.SelectedIndexChanged += fontSizeComboBox_SelectedIndexChanged;
            // 
            // toolStripButtonIncrease
            // 
            toolStripButtonIncrease.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonIncrease.Image = (Image)resources.GetObject("toolStripButtonIncrease.Image");
            toolStripButtonIncrease.ImageTransparentColor = Color.Magenta;
            toolStripButtonIncrease.Name = "toolStripButtonIncrease";
            toolStripButtonIncrease.Size = new Size(34, 38);
            toolStripButtonIncrease.Text = "Увеличить шрифт";
            toolStripButtonIncrease.Click += toolStripButtonIncrease_Click;
            // 
            // toolStripButtonDecrease
            // 
            toolStripButtonDecrease.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDecrease.Image = (Image)resources.GetObject("toolStripButtonDecrease.Image");
            toolStripButtonDecrease.ImageTransparentColor = Color.Magenta;
            toolStripButtonDecrease.Name = "toolStripButtonDecrease";
            toolStripButtonDecrease.Size = new Size(34, 38);
            toolStripButtonDecrease.Text = "Уменьшить шрифт";
            toolStripButtonDecrease.Click += toolStripButtonDecrease_Click;
            // 
            // toolStripDropDownButtonFontColor
            // 
            toolStripDropDownButtonFontColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButtonFontColor.Image = (Image)resources.GetObject("toolStripDropDownButtonFontColor.Image");
            toolStripDropDownButtonFontColor.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButtonFontColor.Name = "toolStripDropDownButtonFontColor";
            toolStripDropDownButtonFontColor.Size = new Size(44, 38);
            toolStripDropDownButtonFontColor.Text = "Цвет шрифта";
            toolStripDropDownButtonFontColor.DropDownItemClicked += toolStripDropDownButtonFontColor_DropDownItemClicked;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 41);
            // 
            // toolStripButtonBold
            // 
            toolStripButtonBold.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonBold.Image = (Image)resources.GetObject("toolStripButtonBold.Image");
            toolStripButtonBold.ImageTransparentColor = Color.Magenta;
            toolStripButtonBold.Name = "toolStripButtonBold";
            toolStripButtonBold.Size = new Size(34, 38);
            toolStripButtonBold.Text = "Полужирный";
            toolStripButtonBold.Click += toolStripButtonBold_Click;
            // 
            // toolStripButtonItalic
            // 
            toolStripButtonItalic.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonItalic.Image = (Image)resources.GetObject("toolStripButtonItalic.Image");
            toolStripButtonItalic.ImageTransparentColor = Color.Magenta;
            toolStripButtonItalic.Name = "toolStripButtonItalic";
            toolStripButtonItalic.Size = new Size(34, 38);
            toolStripButtonItalic.Text = "Курсив";
            toolStripButtonItalic.Click += toolStripButtonItalic_Click;
            // 
            // toolStripButtonUnderline
            // 
            toolStripButtonUnderline.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonUnderline.Image = (Image)resources.GetObject("toolStripButtonUnderline.Image");
            toolStripButtonUnderline.ImageTransparentColor = Color.Magenta;
            toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            toolStripButtonUnderline.Size = new Size(34, 38);
            toolStripButtonUnderline.Text = "Подчёркнутый";
            toolStripButtonUnderline.Click += toolStripButtonUnderline_Click;
            // 
            // toolStripButtonSubScript
            // 
            toolStripButtonSubScript.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSubScript.Image = (Image)resources.GetObject("toolStripButtonSubScript.Image");
            toolStripButtonSubScript.ImageTransparentColor = Color.Magenta;
            toolStripButtonSubScript.Name = "toolStripButtonSubScript";
            toolStripButtonSubScript.Size = new Size(34, 38);
            toolStripButtonSubScript.Text = "toolStripButton1";
            toolStripButtonSubScript.Click += toolStripButtonSubScript_Click;
            // 
            // toolStripButtonSuperScript
            // 
            toolStripButtonSuperScript.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSuperScript.Image = (Image)resources.GetObject("toolStripButtonSuperScript.Image");
            toolStripButtonSuperScript.ImageTransparentColor = Color.Magenta;
            toolStripButtonSuperScript.Name = "toolStripButtonSuperScript";
            toolStripButtonSuperScript.Size = new Size(34, 38);
            toolStripButtonSuperScript.Text = "toolStripButton2";
            toolStripButtonSuperScript.Click += toolStripButtonSuperScript_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 41);
            // 
            // toolStripButtonLeftAlign
            // 
            toolStripButtonLeftAlign.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonLeftAlign.Image = (Image)resources.GetObject("toolStripButtonLeftAlign.Image");
            toolStripButtonLeftAlign.ImageTransparentColor = Color.Magenta;
            toolStripButtonLeftAlign.Name = "toolStripButtonLeftAlign";
            toolStripButtonLeftAlign.Size = new Size(34, 38);
            toolStripButtonLeftAlign.Text = "Выровнять по левому краю";
            toolStripButtonLeftAlign.Click += toolStripButtonLeftAlign_Click;
            // 
            // toolStripButtonCenterAlign
            // 
            toolStripButtonCenterAlign.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCenterAlign.Image = (Image)resources.GetObject("toolStripButtonCenterAlign.Image");
            toolStripButtonCenterAlign.ImageTransparentColor = Color.Magenta;
            toolStripButtonCenterAlign.Name = "toolStripButtonCenterAlign";
            toolStripButtonCenterAlign.Size = new Size(34, 38);
            toolStripButtonCenterAlign.Text = "Выровнять по центру";
            toolStripButtonCenterAlign.Click += toolStripButtonCenterAlign_Click;
            // 
            // toolStripButtonRightAlign
            // 
            toolStripButtonRightAlign.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRightAlign.Image = (Image)resources.GetObject("toolStripButtonRightAlign.Image");
            toolStripButtonRightAlign.ImageTransparentColor = Color.Magenta;
            toolStripButtonRightAlign.Name = "toolStripButtonRightAlign";
            toolStripButtonRightAlign.Size = new Size(34, 38);
            toolStripButtonRightAlign.Text = "Выровнять по правому краю ";
            toolStripButtonRightAlign.Click += toolStripButtonRightAlign_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 41);
            // 
            // toolStripButtonBulletList
            // 
            toolStripButtonBulletList.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonBulletList.Image = (Image)resources.GetObject("toolStripButtonBulletList.Image");
            toolStripButtonBulletList.ImageTransparentColor = Color.Magenta;
            toolStripButtonBulletList.Name = "toolStripButtonBulletList";
            toolStripButtonBulletList.Size = new Size(34, 38);
            toolStripButtonBulletList.Text = "Создать маркировынный список";
            toolStripButtonBulletList.Click += toolStripButtonBulletList_Click;
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(6, 41);
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            colorDialog1.ShowHelp = true;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Текстовые файлы(*.txt)|*.txt|Rich Text Format(*.rtf)|*.rtf|C files(*.c)|*.c|C++ files(*.cpp)|*.cpp|C# files(*.cs)|*.cs";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Текстовые файлы(*.txt)|*.txt|Rich Text Format(*.rtf)|*.rtf|C files(*.c)|*.c|C++ files(*.cpp)|*.cpp|C# files(*.cs)|*.cs";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.Menu;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1043, 32);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemCreate, ToolStripMenuItemOpen, ToolStripMenuItemSave, toolStripSeparator9, ToolStripMenuItemPrint, toolStripSeparator8, ToolStripMenuItemExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 28);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // ToolStripMenuItemCreate
            // 
            ToolStripMenuItemCreate.Name = "ToolStripMenuItemCreate";
            ToolStripMenuItemCreate.ShortcutKeys = Keys.Control | Keys.N;
            ToolStripMenuItemCreate.Size = new Size(216, 26);
            ToolStripMenuItemCreate.Text = "Создать";
            ToolStripMenuItemCreate.Click += ToolStripMenuItemCreate_Click;
            // 
            // ToolStripMenuItemOpen
            // 
            ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            ToolStripMenuItemOpen.ShortcutKeys = Keys.Control | Keys.O;
            ToolStripMenuItemOpen.Size = new Size(216, 26);
            ToolStripMenuItemOpen.Text = "Открыть";
            ToolStripMenuItemOpen.Click += ToolStripMenuItemOpen_Click;
            // 
            // ToolStripMenuItemSave
            // 
            ToolStripMenuItemSave.Name = "ToolStripMenuItemSave";
            ToolStripMenuItemSave.ShortcutKeys = Keys.Control | Keys.S;
            ToolStripMenuItemSave.Size = new Size(216, 26);
            ToolStripMenuItemSave.Text = "Сохранить";
            ToolStripMenuItemSave.Click += ToolStripMenuItemSave_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(213, 6);
            // 
            // ToolStripMenuItemPrint
            // 
            ToolStripMenuItemPrint.Name = "ToolStripMenuItemPrint";
            ToolStripMenuItemPrint.ShortcutKeys = Keys.Control | Keys.P;
            ToolStripMenuItemPrint.Size = new Size(216, 26);
            ToolStripMenuItemPrint.Text = "Печать";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(213, 6);
            // 
            // ToolStripMenuItemExit
            // 
            ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            ToolStripMenuItemExit.Size = new Size(216, 26);
            ToolStripMenuItemExit.Text = "Выход";
            ToolStripMenuItemExit.Click += ToolStripMenuItemExit_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Checked = true;
            editToolStripMenuItem.CheckState = CheckState.Checked;
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemUndo, ToolStripMenuItemRedo, toolStripSeparator6, ToolStripMenuItemCut, ToolStripMenuItemCopy, ToolStripMenuItemPaste, ToolStripMenuItemDelete, toolStripSeparator7, ToolStripMenuItemSelectAll, ToolStripMenuItemClear });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(74, 28);
            editToolStripMenuItem.Text = "Правка";
            // 
            // toolStripMenuItemUndo
            // 
            toolStripMenuItemUndo.Name = "toolStripMenuItemUndo";
            toolStripMenuItemUndo.ShortcutKeys = Keys.Control | Keys.Z;
            toolStripMenuItemUndo.Size = new Size(238, 26);
            toolStripMenuItemUndo.Text = "Отменить";
            toolStripMenuItemUndo.Click += toolStripMenuItemUndo_Click;
            // 
            // ToolStripMenuItemRedo
            // 
            ToolStripMenuItemRedo.Name = "ToolStripMenuItemRedo";
            ToolStripMenuItemRedo.ShortcutKeys = Keys.Control | Keys.Y;
            ToolStripMenuItemRedo.Size = new Size(238, 26);
            ToolStripMenuItemRedo.Text = "Восстановить";
            ToolStripMenuItemRedo.Click += ToolStripMenuItemRedo_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(235, 6);
            // 
            // ToolStripMenuItemCut
            // 
            ToolStripMenuItemCut.Name = "ToolStripMenuItemCut";
            ToolStripMenuItemCut.ShortcutKeys = Keys.Control | Keys.X;
            ToolStripMenuItemCut.Size = new Size(238, 26);
            ToolStripMenuItemCut.Text = "Вырезать";
            ToolStripMenuItemCut.Click += ToolStripMenuItemCut_Click;
            // 
            // ToolStripMenuItemCopy
            // 
            ToolStripMenuItemCopy.Name = "ToolStripMenuItemCopy";
            ToolStripMenuItemCopy.ShortcutKeys = Keys.Control | Keys.C;
            ToolStripMenuItemCopy.Size = new Size(238, 26);
            ToolStripMenuItemCopy.Text = "Копировать";
            ToolStripMenuItemCopy.Click += ToolStripMenuItemCopy_Click;
            // 
            // ToolStripMenuItemPaste
            // 
            ToolStripMenuItemPaste.Name = "ToolStripMenuItemPaste";
            ToolStripMenuItemPaste.ShortcutKeys = Keys.Control | Keys.V;
            ToolStripMenuItemPaste.Size = new Size(238, 26);
            ToolStripMenuItemPaste.Text = "Вставить";
            ToolStripMenuItemPaste.Click += ToolStripMenuItemPaste_Click;
            // 
            // ToolStripMenuItemDelete
            // 
            ToolStripMenuItemDelete.Name = "ToolStripMenuItemDelete";
            ToolStripMenuItemDelete.ShortcutKeys = Keys.Delete;
            ToolStripMenuItemDelete.Size = new Size(238, 26);
            ToolStripMenuItemDelete.Text = "Удалить";
            ToolStripMenuItemDelete.Click += ToolStripMenuItemDelete_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(235, 6);
            // 
            // ToolStripMenuItemSelectAll
            // 
            ToolStripMenuItemSelectAll.Name = "ToolStripMenuItemSelectAll";
            ToolStripMenuItemSelectAll.ShortcutKeys = Keys.Control | Keys.A;
            ToolStripMenuItemSelectAll.Size = new Size(238, 26);
            ToolStripMenuItemSelectAll.Text = "Выделить всё";
            ToolStripMenuItemSelectAll.Click += ToolStripMenuItemSelectAll_Click;
            // 
            // ToolStripMenuItemClear
            // 
            ToolStripMenuItemClear.Name = "ToolStripMenuItemClear";
            ToolStripMenuItemClear.Size = new Size(238, 26);
            ToolStripMenuItemClear.Text = "Очистить всё";
            ToolStripMenuItemClear.Click += ToolStripMenuItemClear_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemSubScript, ToolStripMenuItemSuperscript, ToolStripMenuItemFont, ToolStripMenuItemWordWrap, ToolStripMenuItemClearFormatting });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(77, 28);
            formatToolStripMenuItem.Text = "Формат";
            // 
            // ToolStripMenuItemSubScript
            // 
            ToolStripMenuItemSubScript.Name = "ToolStripMenuItemSubScript";
            ToolStripMenuItemSubScript.ShortcutKeys = Keys.Control | Keys.Down;
            ToolStripMenuItemSubScript.Size = new Size(284, 26);
            ToolStripMenuItemSubScript.Text = "Подстрочный";
            ToolStripMenuItemSubScript.Click += ToolStripMenuItemSubScript_Click;
            // 
            // ToolStripMenuItemSuperscript
            // 
            ToolStripMenuItemSuperscript.Name = "ToolStripMenuItemSuperscript";
            ToolStripMenuItemSuperscript.ShortcutKeys = Keys.Control | Keys.Up;
            ToolStripMenuItemSuperscript.Size = new Size(284, 26);
            ToolStripMenuItemSuperscript.Text = "Надстрочный";
            ToolStripMenuItemSuperscript.Click += ToolStripMenuItemSuperscript_Click;
            // 
            // ToolStripMenuItemFont
            // 
            ToolStripMenuItemFont.Name = "ToolStripMenuItemFont";
            ToolStripMenuItemFont.Size = new Size(284, 26);
            ToolStripMenuItemFont.Text = "Шрифт";
            ToolStripMenuItemFont.Click += ToolStripMenuItemFont_Click;
            // 
            // ToolStripMenuItemWordWrap
            // 
            ToolStripMenuItemWordWrap.Name = "ToolStripMenuItemWordWrap";
            ToolStripMenuItemWordWrap.Size = new Size(284, 26);
            ToolStripMenuItemWordWrap.Text = "Перенос по словам";
            ToolStripMenuItemWordWrap.Click += ToolStripMenuItemWordWrap_Click;
            // 
            // ToolStripMenuItemClearFormatting
            // 
            ToolStripMenuItemClearFormatting.Name = "ToolStripMenuItemClearFormatting";
            ToolStripMenuItemClearFormatting.Size = new Size(284, 26);
            ToolStripMenuItemClearFormatting.Text = "Сбросить форматирование";
            ToolStripMenuItemClearFormatting.Click += ToolStripMenuItemClearFormatting_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1049F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.892857134F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 1);
            tableLayoutPanel1.Controls.Add(statusStrip1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(1049, 603);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel2.Controls.Add(toolStrip1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 44.2857132F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 55.7142868F));
            tableLayoutPanel2.Size = new Size(1043, 73);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.HotTrack = true;
            tabControl1.Location = new Point(3, 82);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1043, 488);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(richTextBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1035, 455);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Безымянный.txt";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            richTextBox.AcceptsTab = true;
            richTextBox.BackColor = SystemColors.Window;
            richTextBox.Cursor = Cursors.IBeam;
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.EnableAutoDragDrop = true;
            richTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox.Location = new Point(3, 3);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(1029, 449);
            richTextBox.TabIndex = 2;
            richTextBox.Text = "";
            richTextBox.WordWrap = false;
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.Dock = DockStyle.Fill;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelLine, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 573);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1049, 30);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelLine
            // 
            toolStripStatusLabelLine.BackColor = SystemColors.ButtonFace;
            toolStripStatusLabelLine.Name = "toolStripStatusLabelLine";
            toolStripStatusLabelLine.Size = new Size(57, 24);
            toolStripStatusLabelLine.Text = "Строка";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = SystemColors.ButtonFace;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(67, 24);
            toolStripStatusLabel1.Tag = "";
            toolStripStatusLabel1.Text = "Столбец";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1049, 603);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "First Text Editor";
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        private void FontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        #endregion
        private FontDialog fontDialog1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonSave;
        private ColorDialog colorDialog1;
        private ToolStripComboBox FontSizeComboBox;
        private ToolStripComboBox FontStripComboBox;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonUndo;
        private ToolStripButton toolStripButtonRedo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonBold;
        private ToolStripButton toolStripButtonItalic;
        private ToolStripButton toolStripButtonUnderline;
        private SaveFileDialog saveFileDialog1;
        private ToolStripButton toolStripButtonOpen;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButtonLeftAlign;
        private ToolStripButton toolStripButtonCenterAlign;
        private ToolStripButton toolStripButtonRightAlign;
        private OpenFileDialog openFileDialog1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButtonBulletList;
        private ToolStripButton toolStripButtonIncrease;
        private ToolStripButton toolStripButtonDecrease;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemUndo;
        private ToolStripMenuItem ToolStripMenuItemRedo;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem ToolStripMenuItemCut;
        private ToolStripMenuItem ToolStripMenuItemCopy;
        private ToolStripMenuItem ToolStripMenuItemPaste;
        private ToolStripMenuItem ToolStripMenuItemDelete;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem ToolStripMenuItemSelectAll;
        private ToolStripMenuItem ToolStripMenuItemClear;
        private ToolStripMenuItem ToolStripMenuItemCreate;
        private ToolStripMenuItem ToolStripMenuItemOpen;
        private ToolStripMenuItem ToolStripMenuItemSave;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem ToolStripMenuItemPrint;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem ToolStripMenuItemExit;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem ToolStripMenuItemSubScript;
        private ToolStripMenuItem ToolStripMenuItemSuperscript;
        private ToolStripMenuItem ToolStripMenuItemFont;
        private ToolStripButton toolStripButtonSubScript;
        private ToolStripButton toolStripButtonSuperScript;
        private ToolStripMenuItem ToolStripMenuItemWordWrap;
        private ToolStripMenuItem ToolStripMenuItemClearFormatting;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ToolStripDropDownButton toolStripDropDownButtonFontColor;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelLine;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private RichTextBox richTextBox;
    }
}