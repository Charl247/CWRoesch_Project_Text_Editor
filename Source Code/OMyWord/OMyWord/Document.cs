using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMyWord
{
    /* Author       :   Charl Roesch
     * Date         :   29/08/2019
     * Description  :   The Document class is used to clear all controls on the main form 
     *                  when it is initiated by clicking on and of the New Document controls.
     *                  On initialisation it will set the RichTextBow to visible and the user
     *                  will be able to start editing the document
     */
    public class Document
    {

        public void ResetContols(Form fm)
        {
            //Form ;

            // Method resets controls on New Document request
            fm.tsbtnBold.Checked = false;
            fm.tsbtnItalic.Checked = false;
            fm.tsbtnULine.Checked = false;
            fm.rtxtBox1.Clear();
            fm.rtxtBox1.BackColor = Color.White;
        }


    }
}
