#region Namespaces Used
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
#endregion

#region Documentation

/* Author           :       Charl Roesch
 * Date             :       29/08/2019
 * Description      :       The Emoticons Class is used to store a set of predefined Emoticon Icons with their 
 *                          unique images (paths) which are stored in an ImageList, called and then added to the 
 *                          RichTextBox
 *                          
 *Class Composition :       Variables:
 *                                      - setImg (Image)
 *                                  
 *                          Properties:       
 *                                      
 *                          Functions:
 *                                      - AddEmo()            
 */

#endregion

namespace OMyWord
{
    public static class Emoticons
    {

#region Variables
        // Class Variables

        static private Image setImg;
#endregion

#region Methods

    #region AddEmo()

    /*   Summary:
        *   The AddEmo() method is used to select the Icon from the ImageList based on the Index 
        *   passed when the method is called. The method then sets the icon to the correct size
        *   based on the selected font size plus 5 points. The icon background is then set to the 
        *   background colour of the RichTextBox. The icon is then pasted to the RichTesxtBox as
        *   a image. Three try catch blocks are included to deal with exceptions relating to missing 
        *   resources.
        *
        *   Returns:
        *   No Return.
        */

    public static void AddEmo(this RichTextBox rtxtBox1, int index)
    {
            

        ImageList emoIList = new ImageList();

        try
        {
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-10.ico"));
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-11.ico"));
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-12.ico"));
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-13.ico"));
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-17.ico"));
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-19.ico"));
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-2.ico"));
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-21.ico"));
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-23.ico"));
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-24.ico"));
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-25.ico"));
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-26.ico"));
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-5.ico"));
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-8.ico"));
            emoIList.Images.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/Resources/Seanau-Flat-Smiley-Smiley-9.ico"));

        }

        catch (FileNotFoundException e)
        {

            MessageBox.Show("Resources missing. This was done on purpose, the directory will now be resolved automatically." + "\n" + "\n" +
                            "Error Message: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Directory.Move(AppDomain.CurrentDomain.BaseDirectory + "/Resources_Test/", AppDomain.CurrentDomain.BaseDirectory + "/Resources/");
            
        }

        catch(Exception e)
        {
            MessageBox.Show("An error occured. Please contact your administrator." + "\n" + "\n" +
                            "Error Message: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        try
        {
            emoIList.ImageSize = new Size((int)rtxtBox1.SelectionFont.SizeInPoints + 5, (int)rtxtBox1.SelectionFont.SizeInPoints + 5);
            setImg = emoIList.Images[index];
        }

        catch(IndexOutOfRangeException e)
        {
            MessageBox.Show("Error Index out of Range. Please contact your administrator." + "\n" + "\n" +
                            "Error Message: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        catch (Exception e)
        {
            MessageBox.Show("An error occured. Please contact your administrator." + "\n" + "\n" +
                            "Error Message: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        try
        {
            Bitmap EmoIcon = new Bitmap(setImg);

            using (var g = Graphics.FromImage(EmoIcon))
            {
                g.Clear(rtxtBox1.BackColor);
                g.DrawImage(setImg, new Point(0, 0));
            }
            setImg = (Image)EmoIcon;

            Clipboard.SetImage(setImg);
            rtxtBox1.Paste();
        }

        catch (NullReferenceException e)
        {
            MessageBox.Show("Reference Null Error. Please contact your administrator." + "\n" + "\n" +
                            "Error Message: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        catch (Exception e)
        {
            MessageBox.Show("An error occured. Please contact your administrator." + "\n" + "\n" +
                            "Error Message: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        }
        #endregion

#endregion

    }
}
