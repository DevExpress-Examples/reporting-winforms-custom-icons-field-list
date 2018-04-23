using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UserDesigner;

namespace FieldListCustomIcons {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            FieldListService.Instance = new CustomFieldListService();
        }

        private void button1_Click(object sender, EventArgs e) {
            new XtraReport1().ShowDesignerDialog();
        }
    }
}