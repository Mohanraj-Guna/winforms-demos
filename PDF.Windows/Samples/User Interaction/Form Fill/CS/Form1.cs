#region Copyright Syncfusion Inc. 2001 - 2005
//
//  Copyright Syncfusion Inc. 2001 - 2005. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Licensing;

namespace EssentialPDFSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        private System.Windows.Forms.Button btnPDFForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Button btnViewTemplate;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.MinimizeBox = true;
            
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPDFForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewTemplate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPDFForm
            // 
            this.btnPDFForm.BackColor = System.Drawing.Color.Transparent;
            this.btnPDFForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPDFForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPDFForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPDFForm.Image = ((System.Drawing.Image)(resources.GetObject("btnPDFForm.Image")));
            this.btnPDFForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDFForm.Location = new System.Drawing.Point(294, 197);
            this.btnPDFForm.Name = "btnPDFForm";
            this.btnPDFForm.Size = new System.Drawing.Size(75, 23);
            this.btnPDFForm.TabIndex = 0;
            this.btnPDFForm.Text = "PDF";
            this.btnPDFForm.UseVisualStyleBackColor = false;
            this.btnPDFForm.Click += new System.EventHandler(this.btnPDFForm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 105);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the button to view an PDF document generated by Essential PDF.  Please note" +
                " that Adobe Reader or its equivalent is required to view the resultant document." +
                "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = System.Drawing.Image.FromFile(GetFullTemplatePath("pdf_header.png", true));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 90);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnViewTemplate
            // 
            this.btnViewTemplate.BackColor = System.Drawing.Color.Transparent;
            this.btnViewTemplate.Location = new System.Drawing.Point(4, 196);
            this.btnViewTemplate.Name = "btnViewTemplate";
            this.btnViewTemplate.Size = new System.Drawing.Size(163, 23);
            this.btnViewTemplate.TabIndex = 25;
            this.btnViewTemplate.Text = "View PDF Form template";
            this.btnViewTemplate.UseVisualStyleBackColor = false;
            this.btnViewTemplate.Click += new System.EventHandler(this.btnViewTemplate_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 240);
            this.Controls.Add(this.btnViewTemplate);
            this.Controls.Add(this.btnPDFForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(GetFullTemplatePath("syncfusion.ico", true));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Filling";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			SyncfusionLicenseProvider.RegisterLicense(DemoCommon.FindLicenseKey());
			Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        private void btnPDFForm_Click(object sender, System.EventArgs e)
        {
            //Load the template document
            PdfLoadedDocument doc = new PdfLoadedDocument(@"..\..\..\..\..\..\..\Common\Data\PDF\Form.pdf");

            PdfLoadedForm form = doc.Form;

            // fill the fields from the first page
            (form.Fields["f1-1"] as PdfLoadedTextBoxField).Text = "1";
            (form.Fields["f1-2"] as PdfLoadedTextBoxField).Text = "1";
            (form.Fields["f1-3"] as PdfLoadedTextBoxField).Text = "1";
            (form.Fields["f1-4"] as PdfLoadedTextBoxField).Text = "3";
            (form.Fields["f1-5"] as PdfLoadedTextBoxField).Text = "1";
            (form.Fields["f1-6"] as PdfLoadedTextBoxField).Text = "1";
            (form.Fields["f1-7"] as PdfLoadedTextBoxField).Text = "22";
            (form.Fields["f1-8"] as PdfLoadedTextBoxField).Text = "30";
            (form.Fields["f1-9"] as PdfLoadedTextBoxField).Text = "John";
            (form.Fields["f1-10"] as PdfLoadedTextBoxField).Text = "Doe";
            (form.Fields["f1-11"] as PdfLoadedTextBoxField).Text = "3233 Spring Rd.";
            (form.Fields["f1-12"] as PdfLoadedTextBoxField).Text = "Atlanta, GA 30339";
            (form.Fields["f1-13"] as PdfLoadedTextBoxField).Text = "332";
            (form.Fields["f1-14"] as PdfLoadedTextBoxField).Text = "43";
            (form.Fields["f1-15"] as PdfLoadedTextBoxField).Text = "4556";
            (form.Fields["f1-16"] as PdfLoadedTextBoxField).Text = "3";
            (form.Fields["f1-17"] as PdfLoadedTextBoxField).Text = "2000";
            (form.Fields["f1-18"] as PdfLoadedTextBoxField).Text = "Exempt";
            (form.Fields["f1-19"] as PdfLoadedTextBoxField).Text = "Syncfusion, Inc.";
            (form.Fields["f1-20"] as PdfLoadedTextBoxField).Text = "200";
            (form.Fields["f1-21"] as PdfLoadedTextBoxField).Text = "22";
            (form.Fields["f1-22"] as PdfLoadedTextBoxField).Text = "56654";
            (form.Fields["c1-1[0]"] as PdfLoadedCheckBoxField).Items[0].Checked = true;
            (form.Fields["c1-1[1]"] as PdfLoadedCheckBoxField).Items[0].Checked = true;

            // fill the fields from the second page
            (form.Fields["f2-1"] as PdfLoadedTextBoxField).Text = "3200";
            (form.Fields["f2-2"] as PdfLoadedTextBoxField).Text = "4850";
            (form.Fields["f2-3"] as PdfLoadedTextBoxField).Text = "0";
            (form.Fields["f2-4"] as PdfLoadedTextBoxField).Text = "500";
            (form.Fields["f2-5"] as PdfLoadedTextBoxField).Text = "500";
            (form.Fields["f2-6"] as PdfLoadedTextBoxField).Text = "800";
            (form.Fields["f2-7"] as PdfLoadedTextBoxField).Text = "0";
            (form.Fields["f2-8"] as PdfLoadedTextBoxField).Text = "0";
            (form.Fields["f2-9"] as PdfLoadedTextBoxField).Text = "3";
            (form.Fields["f2-10"] as PdfLoadedTextBoxField).Text = "3";
            (form.Fields["f2-11"] as PdfLoadedTextBoxField).Text = "3";
            (form.Fields["f2-12"] as PdfLoadedTextBoxField).Text = "2";
            (form.Fields["f2-13"] as PdfLoadedTextBoxField).Text = "3";
            (form.Fields["f2-14"] as PdfLoadedTextBoxField).Text = "3";
            (form.Fields["f2-15"] as PdfLoadedTextBoxField).Text = "2";
            (form.Fields["f2-16"] as PdfLoadedTextBoxField).Text = "1";
            (form.Fields["f2-17"] as PdfLoadedTextBoxField).Text = "200";
            (form.Fields["f2-18"] as PdfLoadedTextBoxField).Text = "600";
            (form.Fields["f2-19"] as PdfLoadedTextBoxField).Text = "250";

            doc.Save("sample.pdf");

            //Message box confirmation to view the created PDF document.
            if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Sample.pdf");
                this.Close();
            }
            else
            {
                // Exit
                this.Close();
            }
        }

        private void btnViewTemplate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\..\..\..\..\..\Common\Data\PDF\Form.pdf");
        }
      /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName, bool image)
        {
            string fullPath = @"..\..\..\..\..\..\..\Common\";
            string folder = image ? "Images" : "Data";

            return string.Format(@"{0}{1}\PDF\{2}", fullPath, folder, fileName);
        }
    }
	/// <summary>
    /// Represents a class that is used to find the licensing file for Syncfusion controls.
    /// </summary>
    public class DemoCommon
    {

        /// <summary>
        /// Finds the license key from the Common folder.
        /// </summary>
        /// <returns>Returns the license key.</returns>
        public static string FindLicenseKey()
        {
            string licenseKeyFile = "..\\Common\\SyncfusionLicense.txt";
            for (int n = 0; n < 20; n++)
            {
                if (!System.IO.File.Exists(licenseKeyFile))
                {
                    licenseKeyFile = @"..\" + licenseKeyFile;
                    continue;
                }
                return System.IO.File.ReadAllText(licenseKeyFile);
            }
            return string.Empty;
        }
    }
}