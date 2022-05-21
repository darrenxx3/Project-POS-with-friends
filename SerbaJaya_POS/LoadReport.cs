using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerbaJaya_POS
{
    public partial class LoadReport : Form
    {
        string formulaString, reportName;

        void loadFormReport()
        {
            switch (reportName)
            {
                case "item":
                    {
                        DataItemReport item = new DataItemReport();
                        item.RecordSelectionFormula = formulaString;
                        crystalReportViewer1.ReportSource = item;
                        break;
                    }
                case "sales":
                    {
                        SalesReport sales = new SalesReport();
                        sales.RecordSelectionFormula = formulaString;
                        crystalReportViewer1.ReportSource = sales;
                        break;
                    }
                case "purchaseOrder":
                    {
                        POReport po = new POReport();
                        po.RecordSelectionFormula = formulaString;
                        crystalReportViewer1.ReportSource = po;
                        break;
                    }
                case "employee":
                    {
                        EmployeeReport employee = new EmployeeReport();
                        employee.RecordSelectionFormula = formulaString;
                        crystalReportViewer1.ReportSource = employee;
                        break;
                    }
                case "cashier":
                    {
                        SalesInvoice receipt = new SalesInvoice();
                        receipt.RecordSelectionFormula = formulaString;
                        crystalReportViewer1.ReportSource = receipt;
                        crystalReportViewer1.RefreshReport();
                        break;
                    }
                case "po":
                    {
                        PurchaseOrderReport po = new PurchaseOrderReport();
                        po.RecordSelectionFormula = formulaString;
                        crystalReportViewer1.ReportSource = po;
                        crystalReportViewer1.RefreshReport();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            loadFormReport();
        }

        public LoadReport(string formula, string report)
        {
            InitializeComponent();

            formulaString = formula;
            reportName = report;
        }
    }
}
