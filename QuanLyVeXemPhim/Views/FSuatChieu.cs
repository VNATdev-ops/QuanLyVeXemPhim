using QuanLyVeXemPhim.Controller;
using QuanLyVeXemPhim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVeXemPhim.Views
{
    public partial class FSuatChieu : Form
    {
        CtrlSuatChieu ctrlSuatChieu = new CtrlSuatChieu();
        List<CSuatChieu> dsSuatChieu = new List<CSuatChieu>();

        CtrlRapChieuPhim ctrlRapChieuPhim = new CtrlRapChieuPhim();
        List<CRapChieuPhim> dsRapChieuPhim = new List<CRapChieuPhim>();

        CtrlPhongChieu ctrPhongChieu = new CtrlPhongChieu();
        List<CRapChieuPhim> dsRap = new List<CRapChieuPhim>();


        public FSuatChieu()
        {
            InitializeComponent();
        }

        private void txtIDSuatChieu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
