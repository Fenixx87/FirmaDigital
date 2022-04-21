using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace firmado21._2
{
    public partial class XtraReport2 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport2()
        {
            InitializeComponent();
        }
        public void InitData(string name, string lastName, string codeImg)
        {
            pName.Value = name;
            pLastName.Value = lastName;
            pCode.Value = codeImg;
        }

    }
}
