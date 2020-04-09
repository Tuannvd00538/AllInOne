using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllInOne
{
    public partial class AllInOne : Form
    {
        internal static AllInOne allInOne;
        internal static GoogleLoginForm googleLoginForm;
        public AllInOne()
        {
            InitializeComponent();
            customizeDesign();
            allInOne = this;
        }

        private void customizeDesign()
        {
            panelAutoCrawlersSubmenu.Visible = false;
            panelTiktokDownloader.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        #region AutoCrawlers
        private void btnAutoCrawlers_Click(object sender, EventArgs e)
        {
            showSubmenu(panelAutoCrawlersSubmenu);
        }

        private void btnBlogspot_Click(object sender, EventArgs e)
        {
            openControllerForm(new GoogleLoginForm());
        }

        private void btnWordpress_Click(object sender, EventArgs e)
        {
            openControllerForm(new AutoCrawlersWordpres());
        }
        #endregion

        #region TiktokDownloader
        private void btnTiktokDownloader_Click(object sender, EventArgs e)
        {
            showSubmenu(panelTiktokDownloader);
        }

        private void btnTiktok_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDouyin_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region OpenControllerForm
        private Form activeForm = null;
        public void openControllerForm(Form controllerForm)
        {
            Console.WriteLine("Tao Form " + controllerForm);
            if (activeForm != null)
                activeForm.Close();
            activeForm = controllerForm;
            controllerForm.TopLevel = false;
            controllerForm.Dock = DockStyle.Fill;
            panelController.Controls.Add(controllerForm);
            panelController.Tag = controllerForm;
            controllerForm.BringToFront();
            controllerForm.Show();
        }
        #endregion

        private void logo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }
    }
}
