using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace QuanLyGaraOto
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThoatCT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdChuDe_Executed(object sender, EventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                eStyle style = (eStyle)Enum.Parse(typeof(eStyle), source.CommandParameter.ToString());

                StyleManager.ChangeStyle(style, Color.Empty);
                if (style == eStyle.Office2007Blue || style == eStyle.Office2007Black ||
                    style == eStyle.Office2007Silver)
                {
                    btnStartButton.BackstageTabEnabled = false;
                }
                else
                {
                    btnStartButton.BackstageTabEnabled = true;
                }
            }
            
        }

        private void txtSoXeToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            
        }

       

        
    }
}
