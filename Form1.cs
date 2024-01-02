using System.Drawing.Text;
using System.Numerics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;

namespace WinFormsApp1 {
    public partial class MainForm : Form {

        List<string> colorList = new List<string>();
        string filename_open;
        const int MIDDLE = 382;
        int sumRGD;
        int pos, line, column;
        const int MAX_TEXT_SIZE = 100;
        const int MIN_TEXT_SIZE = 6;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

            // заполнение combo box размерами шрифтов
            for (int i = MIN_TEXT_SIZE; i < MAX_TEXT_SIZE; i += 2) {
                FontSizeComboBox.Items.Add(i);
            }

            // заполнение combo box названиями шрифтов
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families) {
                FontStripComboBox.Items.Add(family.Name);
            }

            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties()) {
                if (prop.PropertyType.FullName == "System.Drawing.Color") {
                    colorList.Add(prop.Name);
                }
            }

            foreach (string color in colorList) {
                toolStripDropDownButtonFontColor.DropDownItems.Add(color);
            }

            for (int i = 0; i < toolStripDropDownButtonFontColor.DropDownItems.Count; i++) {
                KnownColor selectedColor;
                selectedColor = (KnownColor)System.Enum.Parse(typeof(KnownColor), colorList[i]);
                toolStripDropDownButtonFontColor.DropDownItems[i].BackColor = Color.FromKnownColor(selectedColor);


                Color col = Color.FromName(colorList[i]);

                sumRGD = ConvertToRGB(col);
                if (sumRGD <= MIDDLE) {
                    toolStripDropDownButtonFontColor.DropDownItems[i].ForeColor = Color.White;

                } else if (sumRGD > MIDDLE) {
                    toolStripDropDownButtonFontColor.DropDownItems[i].ForeColor = Color.Black;
                }
            }

            // определяем значения для line и column
            int pos = richTextBox.SelectionStart;
            int line = richTextBox.GetLineFromCharIndex(pos);
            int column = richTextBox.SelectionStart - richTextBox.GetFirstCharIndexFromLine(line);
            // сделать инфо бокс снизу (линии, колонки)

        }
        private int ConvertToRGB(System.Drawing.Color c) {
            int r = c.R;
            int g = c.G;
            int b = c.B;

            int sum = 0;
            sum = r + g + b;

            return sum;
        }

        private TabPage TabPageCreater() {
            TabPage tabPage = new TabPage();
            return tabPage;
        }


        /********************************
         * 
         *      ПАНЕЛЬ ИНСТРУМЕНТОВ
         * 
         ********************************/


        private void toolStripDropDownButtonFontColor_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            try {
                //if (toolStripDropDownButtonFontColor.Selected == null) {
                //    return;
                //}

                KnownColor selectedColor;
                selectedColor = (KnownColor)System.Enum.Parse(typeof(KnownColor), e.ClickedItem.Text);

                if (tabControl1.SelectedTab.Controls.ContainsKey("richTextBox")) {
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionColor = Color.FromKnownColor(selectedColor);
                    //((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox" + (tabControl1.SelectedIndex + 1)]).SelectionColor = Color.FromKnownColor(selectedColor);
                }

                //richTextBox1.SelectionColor = Color.FromKnownColor(selectedColor);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка цвета для фона", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e) {

            try {
                int size = Convert.ToInt32(FontSizeComboBox.Text);

                /*if (richTextBox.SelectionFont == null) {
                    return;
                }

                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, size, richTextBox.SelectionFont.Style);
                FontSizeComboBox.Text = size.ToString();
                */
                if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                    return;
                }
                ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.FontFamily, size, ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Style);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void fontStripComboBox_SelectedIndexChanged(object sender, EventArgs e) { // Доделать (((((((
            //richTextBox1.Font = new Font(FontStripComboBox.Text, richTextBox1.SelectionFont.Size);
            try {
                /*if (richTextBox.SelectionFont == null) {
                    richTextBox.SelectionFont = new Font(FontStripComboBox.Text, richTextBox.Font.Size);

                }

                richTextBox.SelectionFont = new Font(FontStripComboBox.Text, richTextBox.SelectionFont.Size);
                */
                if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(FontStripComboBox.Text, ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Font.Size);

                }

               ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(FontStripComboBox.Text, ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Size);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e) {
            //richTextBox.Undo();
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Undo();
        }

        private void toolStripButtonRedo_Click(object sender, EventArgs e) {
            //richTextBox.Redo();
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Redo();
        }

        private void toolStripButtonBold_Click(object sender, EventArgs e) {

            if (toolStripButtonBold.Checked == false) {
                toolStripButtonBold.Checked = true; // 

            } else if (toolStripButtonBold.Checked == true) {
                toolStripButtonBold.Checked = false; // 
            }

            if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                return;
            }

            FontStyle style = ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Style;

            if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Bold) {
                style &= ~FontStyle.Bold;

            } else {
                style |= FontStyle.Bold;
            }

            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont, style); // устанавливаем стиль 
        }

        private void toolStripButtonItalic_Click(object sender, EventArgs e) {

            if (toolStripButtonItalic.Checked == false) {
                toolStripButtonItalic.Checked = true;

            } else if (toolStripButtonItalic.Checked == true) {
                toolStripButtonItalic.Checked = false;
            }

            if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                return;
            }

            FontStyle style = ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Style;

            if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Italic) {
                style &= ~FontStyle.Italic;

            } else {
                style |= FontStyle.Italic;
            }

            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont, style);
        }

        private void toolStripButtonUnderline_Click(object sender, EventArgs e) {
            if (toolStripButtonUnderline.Checked == false) {
                toolStripButtonUnderline.Checked = true;

            } else if (toolStripButtonUnderline.Checked == true) {
                toolStripButtonUnderline.Checked = false;
            }

            if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                return;
            }

            FontStyle style = ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Style;

            if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Underline) {
                style &= ~FontStyle.Underline;

            } else {
                style |= FontStyle.Underline;
            }

            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont, style);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e) { // кнопка сохранить
            try {
                //saveFileDialog1.ShowDialog();
                string file;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                    string filename = saveFileDialog1.FileName;

                    //saveFileDialog1.FilterIndex = 2; // RichText
                    //saveFileDialog1.FilterIndex = 1; // PlainText

                    if (saveFileDialog1.FilterIndex == 2) {
                        ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SaveFile(filename, RichTextBoxStreamType.RichText);
                        //MessageBox.Show("RTF", "Save RTF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {
                        ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SaveFile(filename, RichTextBoxStreamType.PlainText);
                       // MessageBox.Show("TXT", "Save TXT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    file = Path.GetFileName(filename);
                    MessageBox.Show("Файл " + file + " успешно открыт.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e) {

            //openFileDialog1.ShowDialog();
            try {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) {

                    filename_open = openFileDialog1.FileName;
                    string tabTitle = openFileDialog1.SafeFileName;
                    bool flag = false;

                    foreach (TabPage Page in tabControl1.TabPages) {
                        if (Page.Text == tabTitle) {
                            tabControl1.SelectTab(Page);
                            flag = true; MessageBox.Show("Файл уже открыт", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); ; break;
                        }
                    }
                    if (!flag) {
                        TabPage tmpTabPage = new TabPage(); //создание новой вкладки 
                        RichTextBox tmpRTB = new RichTextBox(); // создание нового текстового поля

                        tmpRTB.AcceptsTab = true;
                        tmpRTB.BackColor = SystemColors.Window;
                        tmpRTB.BorderStyle = BorderStyle.Fixed3D;
                        tmpRTB.Cursor = Cursors.IBeam;
                        tmpRTB.Dock = DockStyle.Fill;
                        tmpRTB.EnableAutoDragDrop = true;
                        tmpRTB.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        tmpRTB.Location = new Point(3, 3);
                        tmpRTB.Name = "richTextBox";
                        tmpRTB.Size = new Size(1029, 449);
                        tmpRTB.Text = "";
                        tmpRTB.WordWrap = false;

                        tmpTabPage.Text = tabTitle; // название вкладки -- имя открытого файла
                        tmpTabPage.Controls.Add(tmpRTB); // добавляем новое текстовое поле на новую вкладку

                        tabControl1.TabPages.Add(tmpTabPage); // добавляем новую вкалдку в коллекцию всех вкладок 

                        if (openFileDialog1.FilterIndex == 2) {
                            ((RichTextBox)tabControl1.TabPages[tabControl1.TabCount - 1].Controls["richTextBox"]).LoadFile(filename_open, RichTextBoxStreamType.RichText);


                            //((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox" + (tabControl1.SelectedIndex + 1)]).LoadFile(filename_open, RichTextBoxStreamType.RichText);

                            //richTextBox1.LoadFile(filename_open, RichTextBoxStreamType.RichText);
                            //MessageBox.Show("RTF", "Open RTF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else {
                            ((RichTextBox)tabControl1.TabPages[tabControl1.TabCount - 1].Controls["richTextBox"]).LoadFile(filename_open, RichTextBoxStreamType.PlainText);

                            //((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox" + (tabControl1.SelectedIndex + 1)]).LoadFile(filename_open, RichTextBoxStreamType.PlainText);
                            //richTextBox1.LoadFile(filename_open, RichTextBoxStreamType.PlainText);
                            //MessageBox.Show("TXT", "Open TXT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButtonLeftAlign_Click(object sender, EventArgs e) {
            toolStripButtonCenterAlign.Checked = false;
            toolStripButtonRightAlign.Checked = false;

            if (toolStripButtonLeftAlign.Checked == false) {
                toolStripButtonLeftAlign.Checked = true;

            } else if (toolStripButtonLeftAlign.Checked == true) {
                toolStripButtonLeftAlign.Checked = false;
            }
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButtonCenterAlign_Click(object sender, EventArgs e) {
            toolStripButtonLeftAlign.Checked = false;
            toolStripButtonRightAlign.Checked = false;

            if (toolStripButtonCenterAlign.Checked == false) {
                toolStripButtonCenterAlign.Checked = true;

            } else if (toolStripButtonCenterAlign.Checked == true) {
                toolStripButtonCenterAlign.Checked = false;
            }
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButtonRightAlign_Click(object sender, EventArgs e) {
            toolStripButtonLeftAlign.Checked = false;
            toolStripButtonCenterAlign.Checked = false;

            if (toolStripButtonRightAlign.Checked == false) {
                toolStripButtonRightAlign.Checked = true;

            } else if (toolStripButtonRightAlign.Checked == true) {
                toolStripButtonRightAlign.Checked = false;
            }
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButtonBulletList_Click(object sender, EventArgs e) {

            if (toolStripButtonBulletList.Checked == false) {
                toolStripButtonBulletList.Checked = true;
                ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionBullet = true;

            } else if (toolStripButtonBulletList.Checked == true) {
                toolStripButtonBulletList.Checked = false;
                ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionBullet = false;
            }

        }

        private void toolStripButtonIncrease_Click(object sender, EventArgs e) {

            string fontSizeNum = FontSizeComboBox.Text;
            try {


                int size = Convert.ToInt32(fontSizeNum);
                if (size == MAX_TEXT_SIZE) {
                    return;
                }
                size += 1;
                if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                    return;
                }

                ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.FontFamily, size, ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Style);
                FontSizeComboBox.Text = size.ToString();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButtonDecrease_Click(object sender, EventArgs e) {

            string fontSizeNum = FontSizeComboBox.Text;
            try {

                int size = Convert.ToInt32(fontSizeNum);

                if (size == MIN_TEXT_SIZE) {
                    return;
                }
                size -= 1;

                if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                    return;
                }

                ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.FontFamily, size, ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Style);
                FontSizeComboBox.Text = size.ToString();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButtonSubScript_Click(object sender, EventArgs e) {
            string fontSizeNum = FontSizeComboBox.Text;

            if (ToolStripMenuItemSubScript.Checked == false) {

                try {

                    int size = Convert.ToInt32(fontSizeNum);
                    if (size - 6 < MIN_TEXT_SIZE) {
                        return;
                    }

                    if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                        return;
                    }
                    ToolStripMenuItemSubScript.Checked = true;
                    ToolStripMenuItemSuperscript.Checked = false;
                    size -= 6;
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionCharOffset = -7;
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.FontFamily, size, ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Style);

                }
                catch (Exception ex) {
                    ToolStripMenuItemSubScript.Checked = false;
                    MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            } else if (ToolStripMenuItemSubScript.Checked == true) {
                ToolStripMenuItemSubScript.Checked = false;
                ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionCharOffset = 0;
                try {

                    int size = Convert.ToInt32(fontSizeNum);
                    if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                        return;
                    }
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.FontFamily, size, ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Style);

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void toolStripButtonSuperScript_Click(object sender, EventArgs e) {
            string fontSizeNum = FontSizeComboBox.Text;

            if (ToolStripMenuItemSuperscript.Checked == false) {

                try {

                    int size = Convert.ToInt32(fontSizeNum);
                    if (size + 6 > MAX_TEXT_SIZE) {
                        return;
                    }

                    if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                        return;
                    }
                    ToolStripMenuItemSuperscript.Checked = true;
                    ToolStripMenuItemSubScript.Checked = false;
                    size -= 6;
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionCharOffset = 7;
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.FontFamily, size, ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Style);

                }
                catch (Exception ex) {
                    ToolStripMenuItemSuperscript.Checked = false;
                    MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            } else if (ToolStripMenuItemSuperscript.Checked == true) {

                try {

                    int size = Convert.ToInt32(fontSizeNum);
                    if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                        return;
                    }
                    ToolStripMenuItemSuperscript.Checked = false;
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionCharOffset = 0;
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.FontFamily, size, ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Style);

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Посмотерть старнную функцию из блока панели инструментов (строчка 333)


        /********************************
        * 
        *           МЕНЮ
        * 
        ********************************/

        // Пункт "Правка"

        private void toolStripMenuItemUndo_Click(object sender, EventArgs e) {
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Undo();
        }

        private void ToolStripMenuItemRedo_Click(object sender, EventArgs e) {
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Redo();
        }

        private void ToolStripMenuItemCut_Click(object sender, EventArgs e) {
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Cut();
        }

        private void ToolStripMenuItemCopy_Click(object sender, EventArgs e) {
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Copy();
        }

        private void ToolStripMenuItemPaste_Click(object sender, EventArgs e) {
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Paste();
        }

        private void ToolStripMenuItemDelete_Click(object sender, EventArgs e) {
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectedText = "";
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Focus();
        }

        private void ToolStripMenuItemSelectAll_Click(object sender, EventArgs e) {
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectAll();
        }

        private void ToolStripMenuItemClear_Click(object sender, EventArgs e) {
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Clear();
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Focus();
        }


        //Пункт "Файл" 

        private void ToolStripMenuItemCreate_Click(object sender, EventArgs e) {

            if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Text != string.Empty) {
                DialogResult result = MessageBox.Show("Вы хотите сохранить изменения файла " + tabControl1.SelectedTab.Text + " ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) {

                    //saveFileDialog1.ShowDialog();
                    try {
                        //saveFileDialog1.ShowDialog();
                        string file;
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                            string filename = saveFileDialog1.FileName;

                            //saveFileDialog1.FilterIndex = 2; // RichText
                            //saveFileDialog1.FilterIndex = 1; // PlainText

                            if (saveFileDialog1.FilterIndex == 2) {

                                ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SaveFile(filename, RichTextBoxStreamType.RichText);
                                //MessageBox.Show("RTF", "Save RTF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } else {
                                ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SaveFile(filename, RichTextBoxStreamType.PlainText);
                                //MessageBox.Show("TXT", "Save TXT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            file = Path.GetFileName(filename);
                            MessageBox.Show("Файл " + file + " был успешно сохранён.", "Сохранено успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    tabControl1.SelectedTab.Text = "Безымянный.txt";
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).ResetText();
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Focus();


                } else if (result == DialogResult.No) {
                    tabControl1.SelectedTab.Text = "Безымянный.txt";
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).ResetText();
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Focus();
                }

            } else {
                tabControl1.SelectedTab.Text = "Безымянный.txt";
                ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).ResetText();
                ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Focus();
            }
        }

        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e) {
            //openFileDialog1.ShowDialog();
            try {

                if (openFileDialog1.ShowDialog() == DialogResult.OK) {

                    filename_open = openFileDialog1.FileName;
                    string tabTitle = openFileDialog1.SafeFileName;
                    bool flag = false;

                    foreach (TabPage Page in tabControl1.TabPages) {
                        if (Page.Text == tabTitle) {
                            tabControl1.SelectTab(Page);
                            flag = true; MessageBox.Show("Файл уже открыт", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); ; break;
                        }
                    }
                    if (!flag) {
                        TabPage tmpTabPage = new TabPage(); //создание новой вкладки 
                        RichTextBox tmpRTB = new RichTextBox(); // создание нового текстового поля

                        tmpRTB.AcceptsTab = true;
                        tmpRTB.BackColor = SystemColors.Window;
                        tmpRTB.BorderStyle = BorderStyle.Fixed3D;
                        tmpRTB.Cursor = Cursors.IBeam;
                        tmpRTB.Dock = DockStyle.Fill;
                        tmpRTB.EnableAutoDragDrop = true;
                        tmpRTB.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        tmpRTB.Location = new Point(3, 3);
                        tmpRTB.Name = "richTextBox";
                        tmpRTB.Size = new Size(1029, 449);
                        tmpRTB.Text = "";
                        tmpRTB.WordWrap = false;

                        tmpTabPage.Text = tabTitle; // название вкладки -- имя открытого файла
                        tmpTabPage.Controls.Add(tmpRTB); // добавляем новое текстовое поле на новую вкладку

                        tabControl1.TabPages.Add(tmpTabPage); // добавляем новую вкалдку в коллекцию всех вкладок 

                        if (openFileDialog1.FilterIndex == 2) {
                            ((RichTextBox)tabControl1.TabPages[tabControl1.TabCount - 1].Controls["richTextBox"]).LoadFile(filename_open, RichTextBoxStreamType.RichText);
                            //richTextBox.LoadFile(filename_open, RichTextBoxStreamType.RichText);
                            //MessageBox.Show("RTF", "Open RTF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else {
                            ((RichTextBox)tabControl1.TabPages[tabControl1.TabCount - 1].Controls["richTextBox"]).LoadFile(filename_open, RichTextBoxStreamType.PlainText);
                            //richTextBox.LoadFile(filename_open, RichTextBoxStreamType.PlainText);
                            //MessageBox.Show("TXT", "Open TXT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ToolStripMenuItemSave_Click(object sender, EventArgs e) {

            try {
                //saveFileDialog1.ShowDialog();
                string file;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                    string filename = saveFileDialog1.FileName;

                    //saveFileDialog1.FilterIndex = 2; // RichText
                    //saveFileDialog1.FilterIndex = 1; // PlainText

                    if (saveFileDialog1.FilterIndex == 2) {
                        ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SaveFile(filename, RichTextBoxStreamType.RichText);
                        //MessageBox.Show("RTF", "Save RTF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {
                        ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SaveFile(filename, RichTextBoxStreamType.PlainText);
                        //MessageBox.Show("TXT", "Save TXT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    file = Path.GetFileName(filename);
                    MessageBox.Show("Файл " + file + " был успешно сохранён.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Пункт "Формат" 

        private void ToolStripMenuItemSubScript_Click(object sender, EventArgs e) {

            string fontSizeNum = FontSizeComboBox.Text;

            if (ToolStripMenuItemSubScript.Checked == false) {

                try {

                    int size = Convert.ToInt32(fontSizeNum);
                    if (size - 6 < MIN_TEXT_SIZE) {
                        return;
                    }

                    if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                        return;
                    }
                    ToolStripMenuItemSubScript.Checked = true;
                    ToolStripMenuItemSuperscript.Checked = false;
                    size -= 6;
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionCharOffset = -7;
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.FontFamily, size, ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Style);

                }
                catch (Exception ex) {
                    ToolStripMenuItemSubScript.Checked = false;
                    MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            } else if (ToolStripMenuItemSubScript.Checked == true) {
                ToolStripMenuItemSubScript.Checked = false;
                ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionCharOffset = 0;
                try {

                    int size = Convert.ToInt32(fontSizeNum);
                    if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                        return;
                    }
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.FontFamily, size, ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Style);

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ToolStripMenuItemSuperscript_Click(object sender, EventArgs e) {
            string fontSizeNum = FontSizeComboBox.Text;

            if (ToolStripMenuItemSuperscript.Checked == false) {

                try {

                    int size = Convert.ToInt32(fontSizeNum);
                    if (size + 6 > MAX_TEXT_SIZE) {
                        return;
                    }

                    if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                        return;
                    }
                    ToolStripMenuItemSuperscript.Checked = true;
                    ToolStripMenuItemSubScript.Checked = false;
                    size -= 6;
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionCharOffset = 7;
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.FontFamily, size, ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Style);

                }
                catch (Exception ex) {
                    ToolStripMenuItemSuperscript.Checked = false;
                    MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            } else if (ToolStripMenuItemSuperscript.Checked == true) {

                try {

                    int size = Convert.ToInt32(fontSizeNum);
                    if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont == null) {
                        return;
                    }
                    ToolStripMenuItemSuperscript.Checked = false;
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionCharOffset = 0;
                    ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont = new Font(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.FontFamily, size, ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).SelectionFont.Style);

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ToolStripMenuItemFont_Click(object sender, EventArgs e) {

            try {
                //fontDialog1.ShowDialog();
                System.Drawing.Font oldFont = this.Font;

                DialogResult result = fontDialog1.ShowDialog();

                if (result == DialogResult.OK) {
                    fontDialog1_Apply(((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]), new System.EventArgs());

                } else if (result == DialogResult.Cancel) {
                    this.Font = oldFont;

                    foreach (Control containedControl in ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Controls) {
                        containedControl.Font = oldFont;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка информации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e) {

            fontDialog1.FontMustExist = true;

            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Font = fontDialog1.Font;
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).ForeColor = fontDialog1.Color;

            foreach (Control containedControl in ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Controls) {
                containedControl.Font = fontDialog1.Font;
            }
        }

        private void ToolStripMenuItemWordWrap_Click(object sender, EventArgs e) {

            if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).WordWrap == false) {
                ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).WordWrap = true;
                ToolStripMenuItemWordWrap.Checked = true;

            } else if (((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).WordWrap == true) {
                ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).WordWrap = false;
                ToolStripMenuItemWordWrap.Checked = false;
            }
        }

        private void ToolStripMenuItemClearFormatting_Click(object sender, EventArgs e) {
            FontStripComboBox.Text = "Font Family";
            FontSizeComboBox.Text = "Font Size";
            string pureText = ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Text;
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Clear();
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).ForeColor = Color.Black;
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Font = default(Font);
            ((RichTextBox)tabControl1.SelectedTab.Controls["richTextBox"]).Text = pureText;
            toolStripButtonLeftAlign.Checked = true;
            toolStripButtonCenterAlign.Checked = false;
            toolStripButtonRightAlign.Checked = false;
        }

    }
}