using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.OneNote;
using System.Xml.Linq;
using System.IO;

namespace Linear_Track_GUI
{
    public partial class Ephys : Form
    {
        public dynamic currrentRat = LinearTrackGui.chosenRat;


        static Microsoft.Office.Interop.OneNote.Application onenoteApp = new Microsoft.Office.Interop.OneNote.Application();
        static XNamespace ns = null;
        public Ephys()
        {
            InitializeComponent();
            
            

        }
        static void GetNamespace()
        {
            string xml;

            onenoteApp.GetHierarchy(null, Microsoft.Office.Interop.OneNote.HierarchyScope.hsNotebooks, out xml);
            var doc = XDocument.Parse(xml);
            ns = doc.Root.Name.Namespace;
        }
        // GET OBJECT ID ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static string GetObjectId(string parentId, Microsoft.Office.Interop.OneNote.HierarchyScope scope, string objectName)
        {
            string xml;
            onenoteApp.GetHierarchy(parentId, scope, out xml);

            var doc = XDocument.Parse(xml);
            var nodeName = "";

            switch (scope)
            {
                case (HierarchyScope.hsNotebooks): nodeName = "Notebook"; break;
                case (HierarchyScope.hsPages): nodeName = "Page"; break;
                case (HierarchyScope.hsSections): nodeName = "Section"; break;
                default:
                    return null;
            }

            var node = doc.Descendants(ns + nodeName).Where(n => n.Attribute("name").Value == objectName).FirstOrDefault();

            return node.Attribute("ID").Value;
        }
        // CREATE A PAGE ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static string CreatePage(string sectionId, string pageName)
        {
            // Create the new page
            string pageId;
            onenoteApp.CreateNewPage(sectionId, out pageId, NewPageStyle.npsBlankPageWithTitle);

            // Get the title and set it to our page name
            string xml;
            onenoteApp.GetPageContent(pageId, out xml, PageInfo.piAll);
            var doc = XDocument.Parse(xml);
            var title = doc.Descendants(ns + "T").First();
            title.Value = pageName;


            // Update the page
            onenoteApp.UpdatePageContent(doc.ToString());

            return pageId;
        }
        static string ModifyPageContent(string pageId, string newcontent)
        {
            string xml;
            onenoteApp.GetPageContent(pageId, out xml, PageInfo.piAll);
            var doc = XDocument.Parse(xml);
            new XElement( ns + "Outline");
            new XElement(ns + "OEChildren");
            var outLine = doc.Descendants (ns + "Outline").First();
            var content = outLine.Descendants(ns + "T").FirstOrDefault();
            string contentVal = content.Value;
            content.Value = newcontent;
            onenoteApp.UpdatePageContent(doc.ToString());
            return null;

        }


      

// ##################################################################################################################################
        private void quality1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void enter_Click(object sender, EventArgs e)
        {
            box.Text = "";
            box.AppendText($"{DateTime.Now.ToString()} \r\n");
            //ACC
            box.AppendText(Environment.NewLine);
            box.AppendText("ACC TETRODES \r\n");
            box.AppendText(Environment.NewLine);
            box.AppendText($"Reference: Tetrode- {ACC_ref.Text}  AD Channel- {ACC_refAD.Text }\r\n");
            for (int i = 1; i <= 8; i++) 
            {
                string qual = "quality" + i;
                string numbox = "num" + i;
                string lfp = "lfp" + i;

                CheckedListBox clb = (CheckedListBox) this.Controls[qual];
                if (clb.CheckedItems.Count > 0)
                {
                    box.AppendText($"TT{i}: {clb.SelectedItem.ToString()}, Cells = {this.Controls[numbox].Text} ");
                }

                CheckedListBox clb_lfp = (CheckedListBox)this.Controls[lfp];
                if (clb_lfp.CheckedItems.Count > 0)
                {
                    box.AppendText($"LFP{i}: {clb_lfp.SelectedItem.ToString()} \r\n ");
                }
                else if (clb.CheckedItems.Count > 0)
                {
                    box.AppendText(" \r\n");
                }
            }

            if (qualityrr.CheckedItems.Count > 0){ box.AppendText($"RR: {qualityrr.SelectedItem.ToString()}, Cells = {numrr.Text}  "); }
            if (lfprr.CheckedItems.Count > 0)
            {
                box.AppendText($"LFP RR: {lfprr.SelectedItem.ToString()} \r\n ");
            }
           
            box.AppendText(Environment.NewLine);

            //HIPPOCAMPUS
            

            box.AppendText("HIPPOCAMPUS TETRODES \r\n");
            box.AppendText(Environment.NewLine);
            box.AppendText($"Reference: Tetrode- {HC_ref.Text}  AD Channel- {HC_refAD.Text }\r\n");
            for (int i = 9; i <= 16; i++)
            {
                string qual = "quality" + i;
                string numbox = "num" + i;
                string lfp = "lfp" + i;

                CheckedListBox clb = (CheckedListBox)this.Controls[qual];
                if (clb.CheckedItems.Count > 0) {
                    box.AppendText($"TT{i}: {clb.SelectedItem.ToString()}, Cells = {this.Controls[numbox].Text}  ");
                }
                CheckedListBox clb_lfp = (CheckedListBox)this.Controls[lfp];
                if (clb_lfp.CheckedItems.Count > 0)
                {
                    box.AppendText($"LFP{i}: {clb_lfp.SelectedItem.ToString()} \r\n ");
                }
                else if(clb.CheckedItems.Count >0)
                {
                    box.AppendText(" \r\n");
                }

            }
            if (qualityrf.CheckedItems.Count > 0) { box.AppendText($"R2: {qualityrf.SelectedItem.ToString()}, Cells = {numrf.Text}  "); }
            if (lfprf.CheckedItems.Count > 0)
            {
                box.AppendText($"LFP RF: {lfprf.SelectedItem.ToString()} \r\n ");
            }
            
            box.AppendText(Environment.NewLine);

            box.AppendText("Changes during Session: ");
            box.AppendText(Environment.NewLine);
            box.AppendText("Other Info: ");
            box.AppendText(Environment.NewLine);
            box.AppendText("Screenshots: ");
        }

        private void box_TextChanged(object sender, EventArgs e)
        {

        }
        private string MergeRtfTexts(RichTextBox[] SourceRtbBoxes)
        {
            using (RichTextBox temp = new RichTextBox())
            {
                foreach (RichTextBox rtbSource in SourceRtbBoxes)
                {
                    rtbSource.SelectAll();
                    //move the end
                    temp.Select(temp.TextLength, 0);
                    //append the rtf
                    temp.SelectedRtf = rtbSource.SelectedRtf;
                }
                return temp.Rtf;
            }
        }
        // ##################################################################################################################################
        private void ephys_save_Click(object sender, EventArgs e)
        {

            string BoxText = box.Text.ToString();
            string DateTimeStr = DateTime.Now.ToString("MM-dd-yy");
            //GetNamespace();
            //string notebookId = GetObjectId(null, HierarchyScope.hsNotebooks, "W Maze");
            //string sectionId = GetObjectId(notebookId, HierarchyScope.hsSections, "Test");
            //string pageId = CreatePage(sectionId, DateTimeStr);
            //string firstPageId = GetObjectId(sectionId, HierarchyScope.hsPages, DateTimeStr);
            //ModifyPageContent(firstPageId, BoxText);
            //Console.Read();
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extention for the file.
            saveFile1.DefaultExt = ".rtf";
            saveFile1.FileName = $"{DateTimeStr}_ LT Session  ";
            saveFile1.Filter = "RTF Files|*.rtf";

            //Directory
            string folderPath = $@"C:\Users\sahanasrivathsa\Documents\Barnes Lab\LTtraining\Rat_EphysData\{currrentRat}\";
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            saveFile1.InitialDirectory = folderPath;

            
            // Determine whether the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.

                final.Rtf = MergeRtfTexts(new RichTextBox[] { box, screenshots });
                final.SaveFile(saveFile1.FileName, RichTextBoxStreamType.RichText);
                //box.SaveFile(Path.GetFileName(saveFile1.FileName));
            }

            Close();

        }

        private void quality2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
    }

