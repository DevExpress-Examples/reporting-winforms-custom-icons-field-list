using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UserDesigner;

namespace FieldListCustomIcons {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            DevExpress.Data.Browsing.Design.ColumnImageProvider.Instance = new CustomColumnImageProvider();
        }

        private void button1_Click(object sender, EventArgs e) {
            new XtraReport1().ShowDesignerDialog();
        }
    }
}