#region Namespaces Used
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
#endregion

#region Documentation

/* Author           :       Charl Roesch
 * Date             :       29/08/2019
 * Description      :       The mainForm Class inherits from the Form Class and is used to control the
 *                          GUI form and events that are created when interacting with the form. 
 *                          
 *Class Composition :       Variables:
 *                                      - saved (bool)    
 *                                      - txtEmpty (bool) 
 *                                  
 *                          Properties:   
 *                                      - TxtEmpty (bool)    
 *                                      
 *                          Functions:
 *                                      - ResetContols()
 *                                      - SaveClear()
 *                                      - SaveDoc()
 *                                      - OpenDoc()
 *                                      - SetTextColourButton()
 *                                      - SetBackColourButton()
 *                                      - ShowHideToolStrip()
 */

#endregion

namespace OMyWord
{
    public partial class mainForm : Form
    {

#region Variables

        // Public variables used in the control of the form.
        public bool saved = false;
        public bool txtEmpty = true;

#endregion

#region Properties

        //Properties used to determine if the RichTextBox is empty or not.

        public bool TxtEmpty
        {
            get
            {
                txtEmpty = rtxtBox1.TextLength > 0 ? true : false;
                return txtEmpty;
            }

        }

        #endregion

#region MainForm

        /*   Summary:
         *   The mainForm constructor is used to Initialize all form components.
         *
         *   Returns:
         *   No Return.
         */

        public mainForm()
        {
            InitializeComponent();
            
        }
        #endregion

#region Events

        /*   Summary:
         *   The below listed events calls the applicable methods when the event is triggered.
         *
         *   Returns:
         *   No Return
         */

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void newDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveClear();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            SaveClear();
        }

        private void saveDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDoc();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDoc();
        }

        private void openDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveClear();
            OpenDoc();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            SaveClear();
            OpenDoc();
        }

        private void tsbtnBold_Click(object sender, EventArgs e)
        {
            rtxtBox1.SetBIU(tsbtnBold.Checked, tsbtnItalic.Checked, tsbtnULine.Checked);
        }

        private void tsbtnItalic_Click(object sender, EventArgs e)
        {
            rtxtBox1.SetBIU(tsbtnBold.Checked, tsbtnItalic.Checked, tsbtnULine.Checked);
        }

        private void tsbtnULine_Click(object sender, EventArgs e)
        {
            rtxtBox1.SetBIU(tsbtnBold.Checked, tsbtnItalic.Checked, tsbtnULine.Checked);
        }

        public void tsbtnTextColour_ButtonClick(object sender, EventArgs e)
        {
            rtxtBox1.SetTextColor();
            SetTextColourButton();
        }

        private void changeTextColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtBox1.SetTextColor();
            SetTextColourButton();
        }

        private void tsbtnBackColour_ButtonClick(object sender, EventArgs e)
        {
            rtxtBox1.SetBackColor();
            SetBackColourButton();
        }

        private void changeBackgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtBox1.SetBackColor();
            SetBackColourButton();
        }

        private void tsbtnFont_Click(object sender, EventArgs e)
        {
            rtxtBox1.SetFontName();
        }

        private void tsbtnUpper_Click(object sender, EventArgs e)
        {
            rtxtBox1.SetUpLow(0);
        }

        private void tsbtnLower_Click(object sender, EventArgs e)
        {
            rtxtBox1.SetUpLow(1);
        }

        private void tscBoxLib_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tscBoxLib.WordLib();
            }
        }

        private void tscBoxLib_SelectedIndexChanged(object sender, EventArgs e)
        {
            tscBoxLib.AddWord(rtxtBox1);
        }

        private void btnEmo1_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(0);
        }

        private void btnEmo2_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(1);
        }

        private void btnEmo3_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(2);
        }

        private void btnEmo4_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(3);
        }

        private void btnEmo5_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(4);
        }

        private void btnEmo6_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(5);
        }

        private void btnEmo7_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(6);
        }

        private void btnEmo8_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(7);
        }

        private void btnEmo9_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(8);
        }

        private void btnEmo10_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(9);
        }

        private void btnEmo11_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(10);
        }

        private void btnEmo12_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(11);
        }

        private void btnEmo13_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(12);
        }

        private void btnEmo14_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(13);
        }

        private void btnEmo15_Click(object sender, EventArgs e)
        {
            rtxtBox1.AddEmo(14);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveClear() == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void emoticonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emoticonsToolStripMenuItem.Checked = emoticonsToolStripMenuItem.Checked == false ? emoticonsToolStripMenuItem.Checked = true : emoticonsToolStripMenuItem.Checked = false;

            ShowHideToolStrip();
        }

        private void wordLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordLibraryToolStripMenuItem.Checked = wordLibraryToolStripMenuItem.Checked == false ? wordLibraryToolStripMenuItem.Checked = true : wordLibraryToolStripMenuItem.Checked = false;

            ShowHideToolStrip();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Messages.MsgBox(5);
        }

        private void grpBoxLib_MouseHover(object sender, EventArgs e)
        {
            tlTipWordLib.Show("Add a new word to the Word Library by typing the word and pressing the Enter key.", grpBoxLib);
        }

        private void grpBoxEmoticons_MouseHover(object sender, EventArgs e)
        {
            tlTipEmo.Show("Press any of the Emoticons to add it to your text. It will size automatically.", grpBoxEmoticons);
        }

        #endregion

#region Methods

        #region ResetContols()

        /*   Summary:
         *   The ResetContols() method resets the controls and properties when called.
         *
         *   Returns:
         *   No Return
         */

        public void ResetContols()
        {

            // Method resets controls on New Document request
            tsbtnBold.Checked = false;
            tsbtnItalic.Checked = false;
            tsbtnULine.Checked = false;
            rtxtBox1.Clear();
            rtxtBox1.BackColor = Color.White;
            pnlTextColour.BackColor = Color.Black;
            pnlBackColour.BackColor = Color.WhiteSmoke;
            rtxtBox1.ForeColor = Color.Black;


        }
        #endregion

        #region SaveClear()

        /*   Summary:
         *   The SaveClear() method initialices the saveDialog and resets the controls
         *   when a new document is requested.
         *
         *   Returns:
         *   No Return
         */

        private DialogResult SaveClear()
        {
            if (TxtEmpty == true)
            {
                DialogResult result = Messages.MsgBox(3);

                if (result == DialogResult.Yes)
                {

                    SaveDoc();

                    if (saved == true)
                    {
                        ResetContols();
                    }
                    else
                    {
                        Messages.MsgBox(2);
                    }

                }
                else if (result == DialogResult.No)
                {
                    ResetContols();
                }
                else
                {
                    
                }

                return result;

            }
            else
            {
                ResetContols();
            }

            return 0;
        }
        #endregion

        #region SaveDoc()

        /*   Summary:
         *   The SaveDoc() method initializes the saveDialog and saves the document
         *   to a rtf file.
         *
         *   Returns:
         *   No Return
         */

        public void SaveDoc()
        {
            string savePath;
            saveFileDialog1.DefaultExt = "rtf";
            saveFileDialog1.Filter = "RichTextFormat |*.rtf";
            saveFileDialog1.FileName = "New Document";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                savePath = Path.GetFullPath(saveFileDialog1.FileName);
                using (var sw = new StreamWriter(savePath))
                {
                    sw.Write(rtxtBox1.Rtf);
                }

                saved = true;
            }

        }
        #endregion

        #region OpenDoc()

        /*   Summary:
         *   The OpenDoc() initializes the openFileDialog and opens a rtf 
         *   file in the applications RichTextBox.
         *
         *   Returns:
         *   No Return
         */

        public void OpenDoc()
        {
            openFileDialog1.Filter = "RichTextFormat |*.rtf";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtxtBox1.LoadFile(openFileDialog1.FileName);
            }
        }
        #endregion

        #region SetTextColourButton()

        /*   Summary:
         *   The SetTextColourButton() sets the panel colour that indicates the
         *   selected Text colour as indicated from the Fonts class ButtonColor
         *   property.
         *
         *   Returns:
         *   No Return
         */

        public void SetTextColourButton()
        {
            pnlTextColour.BackColor = Fonts.ButtonColor;
        }
        #endregion

        #region SetBackColourButton()

        /*   Summary:
         *   The SetBackColourButton() sets the panel colour that indicates the
         *   selected Background colour as indicated from the Fonts class ButtonColor
         *   property.
         *
         *   Returns:
         *   No Return
         */

        public void SetBackColourButton()
        {
            pnlBackColour.BackColor = Fonts.ButtonColor;
        }
        #endregion

        #region ShowHideToolStrip()

        /*   Summary:
         *   The ShowHideToolStrip() sets the Emoticon and Word Library group boxes
         *   visible or hidden based on the View menu selection.
         *
         *   Returns:
         *   No Return
         */

        public void ShowHideToolStrip()
        {
            if (emoticonsToolStripMenuItem.Checked == true)
            {
                grpBoxEmoticons.Visible = true;
            }
            else
            {
                grpBoxEmoticons.Visible = false;
            }

            if (wordLibraryToolStripMenuItem.Checked == true)
            {
                grpBoxLib.Visible = true;
            }
            else
            {
                grpBoxLib.Visible = false;
            }
        }


        #endregion

        #endregion

    }

}
