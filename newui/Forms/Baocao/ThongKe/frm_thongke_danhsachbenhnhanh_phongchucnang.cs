﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using SubSonic;
using VNS.HIS.DAL;
using VNS.Libs;

namespace VNS.HIS.UI.Forms.Baocao.ThongKe
{
    public partial class frm_thongke_danhsachbenhnhanh_phongchucnang : Form
    {
        private readonly string Args = "ALL";

        private string reportname = "";
        private string tieude = "";

        public frm_thongke_danhsachbenhnhanh_phongchucnang(string sthamso)
        {
            Args = sthamso;
            InitializeComponent();
            txtdichvu._OnEnterMe += txtdichvu__OnEnterMe;
        }

        private void txtdichvu__OnEnterMe()
        {
            //   AddServiceDetail();
        }

        private void AddServiceDetail()
        {
            // if (Utility.Int32Dbnull(txtdichvu.MyID, -1) > 0)
            // {
            //  txtdichvu.Text = txtdichvu.MyText;
            //  }
        }

        private void frm_thongke_danhsachbenhnhanh_sieuam_Load(object sender, EventArgs e)
        {
            try
            {
                DataBinding.BindDataCombobox(cboDoituongKCB, THU_VIEN_CHUNG.LaydanhsachDoituongKcb(),
                                             DmucDoituongkcb.Columns.IdDoituongKcb,
                                             DmucDoituongkcb.Columns.TenDoituongKcb,
                                             "Chọn đối tượng KCB", true);
                DataTable m_dtKhoathucHien = THU_VIEN_CHUNG.Laydanhmuckhoa("NGOAI", 0);
                DataBinding.BindDataCombobox(cboKhoa, m_dtKhoathucHien,
                                             DmucKhoaphong.Columns.MaKhoaphong, DmucKhoaphong.Columns.TenKhoaphong,
                                             "Chọn khoa KCB", true);

                EnumerableRowCollection<DataRow> query = from khoa in m_dtKhoathucHien.AsEnumerable()
                                                         where
                                                             Utility.sDbnull(khoa[DmucKhoaphong.Columns.MaKhoaphong]) ==
                                                             globalVariables.MA_KHOA_THIEN
                                                         select khoa;
                if (query.Any())
                {
                    cboKhoa.SelectedValue = globalVariables.MA_KHOA_THIEN;
                }
                dtFromDate.Value = dtToDate.Value = dtNgayInPhieu.Value = DateTime.Now;
                string reportcode = "";
                baocaO_TIEUDE1.TIEUDE = "";
                switch (Args.Substring(0, 2))
                {
                    case "SA":
                        reportcode = "baocao_thongkedanhsach_sieuam";
                        break;
                    case "XQ":
                        reportcode = "baocao_thongkedanhsach_xquang";
                        break;
                    case "DT":
                        reportcode = "baocao_thongkedanhsach_dientim";
                        break;
                    case "NS":
                        reportcode = "baocao_thongkedanhsach_noisoi";
                        break;
                    default:
                        reportcode = "baocao_thongkedanhsach_noisoi";
                        break;
                }
                Utility.GetReport(reportcode, ref tieude, ref reportname);
                baocaO_TIEUDE1.TIEUDE = tieude;
                LoaddanhmucCLS();
                // txtdichvu.dtData = 
            }
            catch (Exception ex)
            {
                Utility.ShowMsg(ex.Message);
            }
        }
        private void LoaddanhmucCLS()
        {
            DataTable dtdmuc = null;
            if (raddmucall.Checked)
            {
                dtdmuc = new Select().From(DmucDichvuclsChitiet.Schema).ExecuteDataSet().Tables[0];
            }
            if (raddmuctruoc.Checked)
            {
                dtdmuc = new Select().From(DmucDichvuclsChitiet.Schema).Where(DmucDichvuclsChitiet.Columns.TrangThai).IsEqualTo(0).ExecuteDataSet().Tables[0];
            }
            if (raddmucsau.Checked)
            {
                dtdmuc = new Select().From(DmucDichvuclsChitiet.Schema).Where(DmucDichvuclsChitiet.Columns.TrangThai).IsEqualTo(1).ExecuteDataSet().Tables[0];
            }
            txtdichvu.Init(dtdmuc
                ,
                new List<string>
                        {
                            DmucDichvuclsChitiet.Columns.IdChitietdichvu,
                            DmucDichvuclsChitiet.Columns.MaChitietdichvu,
                            DmucDichvuclsChitiet.Columns.TenChitietdichvu
                        });
        }
        private void cmdInPhieu_Click(object sender, EventArgs e)
        {
            int trangthai = -1;
            if (radTatca.Checked) trangthai = -1;
            if (radDathuchien.Checked) trangthai = 1;
            if (radChuathuchien.Checked) trangthai = 0;
            DataTable dtDanhsach =
                SPs.BaocaoThongkedanhsachThuchienchucnang(dtFromDate.Value, dtToDate.Value,
                                                          Utility.Int16Dbnull(cboDoituongKCB.SelectedValue, -1),
                                                          Utility.sDbnull(cboKhoa.SelectedValue, "KKB"), Args,
                                                          Utility.Int32Dbnull(txtdichvu.MyID, -1), trangthai)
                    .GetDataSet().Tables[0];
            Utility.SetDataSourceForDataGridEx(grdResult, dtDanhsach, false, false, "", "");
            THU_VIEN_CHUNG.CreateXML(dtDanhsach, "baocao_thongkedanhsach_chucnang.XML");
            if (dtDanhsach.Rows.Count <= 0)
            {
                Utility.ShowMsg("Không có dữ liệu để báo cáo!");
                return;
            }
            Utility.UpdateLogotoDatatable(ref dtDanhsach);
            string reportCode = "";
            switch (Args.Substring(0, 2))
            {
                case "SA":
                    reportCode = "baocao_thongkedanhsach_sieuam";
                    break;
                case "XQ":
                    reportCode = "baocao_thongkedanhsach_xquang";
                    break;
                case "DT":
                    reportCode = "baocao_thongkedanhsach_dientim";
                    break;
                case "NS":
                    reportCode = "baocao_thongkedanhsach_noisoi";
                    break;
                default:
                    reportCode = "baocao_thongkedanhsach_noisoi";
                    break;
            }
            string Condition =
                string.Format("Từ ngày {0} đến {1} - Đối tượng : {2} - Khoa KCB :{3}",
                              dtFromDate.Text, dtToDate.Text,
                              cboDoituongKCB.SelectedIndex >= 0
                                  ? Utility.sDbnull(cboDoituongKCB.Text)
                                  : "Tất cả",
                              cboKhoa.SelectedIndex > 0
                                  ? Utility.sDbnull(cboKhoa.Text)
                                  : "Tất cả");
            ReportDocument crpt = Utility.GetReport(reportCode, ref tieude, ref reportname);
            if (crpt == null) return;

            string StaffName = globalVariables.gv_strTenNhanvien;
            if (string.IsNullOrEmpty(globalVariables.gv_strTenNhanvien)) StaffName = globalVariables.UserName;
            try
            {
                var objForm = new frmPrintPreview(tieude, crpt, true, dtDanhsach.Rows.Count <= 0 ? false : true);
                crpt.SetDataSource(dtDanhsach);
                objForm.mv_sReportFileName = Path.GetFileName(reportname);
                objForm.mv_sReportCode = reportCode;
                crpt.SetParameterValue("StaffName", StaffName);
                crpt.SetParameterValue("ParentBranchName", globalVariables.ParentBranch_Name);
                crpt.SetParameterValue("BranchName", globalVariables.Branch_Name);
                crpt.SetParameterValue("Address", globalVariables.Branch_Address);
                crpt.SetParameterValue("Phone", globalVariables.Branch_Phone);
                crpt.SetParameterValue("FromDateToDate", Condition);
                crpt.SetParameterValue("sTitleReport", tieude);
                crpt.SetParameterValue("sCurrentDate", Utility.FormatDateTimeWithThanhPho(dtNgayInPhieu.Value));
                crpt.SetParameterValue("BottomCondition", THU_VIEN_CHUNG.BottomCondition());
                Utility.SetParameterValue(crpt, "txtTrinhky",
                                          Utility.getTrinhky(objForm.mv_sReportFileName, globalVariables.SysDate));
                objForm.crptViewer.ReportSource = crpt;
                objForm.ShowDialog();
            }
            catch (Exception exception)
            {
                Utility.ShowMsg("Lỗi:" + exception.Message);
            }
            finally
            {
                Utility.FreeMemory(crpt);
            }
        }

        private void radTatca_CheckedChanged(object sender, EventArgs e)
        {
            //   if (radTatca.Checked) trangthai = -1;
        }

        private void cmdExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelUtlity.ExportGridEx(grdResult);
                //saveFileDialog1.Filter = "Excel File(*.xls)|*.xls";
                //saveFileDialog1.FileName = string.Format("{0}.xls", tieude);
                ////saveFileDialog1.ShowDialog();
                //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    string sPath = saveFileDialog1.FileName;
                //    var fs = new FileStream(sPath, FileMode.Create);
                //    fs.CanWrite.CompareTo(true);
                //    fs.CanRead.CompareTo(true);
                //    gridEXExporter1.Export(fs);
                //    fs.Dispose();
                //}
                //saveFileDialog1.Dispose();
                //saveFileDialog1.Reset();
            }
            catch (Exception exception)
            {
                Utility.ShowMsg("Lỗi:" + exception.Message);
            }
        }

        private void raddmucall_CheckedChanged(object sender, EventArgs e)
        {
            LoaddanhmucCLS();
        }

        private void raddmuctruoc_CheckedChanged(object sender, EventArgs e)
        {
            LoaddanhmucCLS();
        }

        private void raddmucsau_CheckedChanged(object sender, EventArgs e)
        {
            LoaddanhmucCLS();
        }
    }
}