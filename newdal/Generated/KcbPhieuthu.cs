using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace VNS.HIS.DAL
{
	/// <summary>
	/// Strongly-typed collection for the KcbPhieuthu class.
	/// </summary>
    [Serializable]
	public partial class KcbPhieuthuCollection : ActiveList<KcbPhieuthu, KcbPhieuthuCollection>
	{	   
		public KcbPhieuthuCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>KcbPhieuthuCollection</returns>
		public KcbPhieuthuCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                KcbPhieuthu o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the kcb_phieuthu table.
	/// </summary>
	[Serializable]
	public partial class KcbPhieuthu : ActiveRecord<KcbPhieuthu>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public KcbPhieuthu()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public KcbPhieuthu(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public KcbPhieuthu(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public KcbPhieuthu(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("kcb_phieuthu", TableType.Table, DataService.GetInstance("ORM"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdPhieuthu = new TableSchema.TableColumn(schema);
				colvarIdPhieuthu.ColumnName = "id_phieuthu";
				colvarIdPhieuthu.DataType = DbType.Int64;
				colvarIdPhieuthu.MaxLength = 0;
				colvarIdPhieuthu.AutoIncrement = true;
				colvarIdPhieuthu.IsNullable = false;
				colvarIdPhieuthu.IsPrimaryKey = true;
				colvarIdPhieuthu.IsForeignKey = false;
				colvarIdPhieuthu.IsReadOnly = false;
				colvarIdPhieuthu.DefaultSetting = @"";
				colvarIdPhieuthu.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPhieuthu);
				
				TableSchema.TableColumn colvarMaPhieuthu = new TableSchema.TableColumn(schema);
				colvarMaPhieuthu.ColumnName = "ma_phieuthu";
				colvarMaPhieuthu.DataType = DbType.String;
				colvarMaPhieuthu.MaxLength = 50;
				colvarMaPhieuthu.AutoIncrement = false;
				colvarMaPhieuthu.IsNullable = false;
				colvarMaPhieuthu.IsPrimaryKey = false;
				colvarMaPhieuthu.IsForeignKey = false;
				colvarMaPhieuthu.IsReadOnly = false;
				colvarMaPhieuthu.DefaultSetting = @"";
				colvarMaPhieuthu.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaPhieuthu);
				
				TableSchema.TableColumn colvarIdThanhtoan = new TableSchema.TableColumn(schema);
				colvarIdThanhtoan.ColumnName = "id_thanhtoan";
				colvarIdThanhtoan.DataType = DbType.Int64;
				colvarIdThanhtoan.MaxLength = 0;
				colvarIdThanhtoan.AutoIncrement = false;
				colvarIdThanhtoan.IsNullable = false;
				colvarIdThanhtoan.IsPrimaryKey = false;
				colvarIdThanhtoan.IsForeignKey = false;
				colvarIdThanhtoan.IsReadOnly = false;
				colvarIdThanhtoan.DefaultSetting = @"";
				colvarIdThanhtoan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdThanhtoan);
				
				TableSchema.TableColumn colvarIdBenhnhan = new TableSchema.TableColumn(schema);
				colvarIdBenhnhan.ColumnName = "id_benhnhan";
				colvarIdBenhnhan.DataType = DbType.Int64;
				colvarIdBenhnhan.MaxLength = 0;
				colvarIdBenhnhan.AutoIncrement = false;
				colvarIdBenhnhan.IsNullable = true;
				colvarIdBenhnhan.IsPrimaryKey = false;
				colvarIdBenhnhan.IsForeignKey = false;
				colvarIdBenhnhan.IsReadOnly = false;
				colvarIdBenhnhan.DefaultSetting = @"";
				colvarIdBenhnhan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdBenhnhan);
				
				TableSchema.TableColumn colvarMaLuotkham = new TableSchema.TableColumn(schema);
				colvarMaLuotkham.ColumnName = "ma_luotkham";
				colvarMaLuotkham.DataType = DbType.String;
				colvarMaLuotkham.MaxLength = 10;
				colvarMaLuotkham.AutoIncrement = false;
				colvarMaLuotkham.IsNullable = true;
				colvarMaLuotkham.IsPrimaryKey = false;
				colvarMaLuotkham.IsForeignKey = false;
				colvarMaLuotkham.IsReadOnly = false;
				colvarMaLuotkham.DefaultSetting = @"";
				colvarMaLuotkham.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaLuotkham);
				
				TableSchema.TableColumn colvarNgayThuchien = new TableSchema.TableColumn(schema);
				colvarNgayThuchien.ColumnName = "ngay_thuchien";
				colvarNgayThuchien.DataType = DbType.DateTime;
				colvarNgayThuchien.MaxLength = 0;
				colvarNgayThuchien.AutoIncrement = false;
				colvarNgayThuchien.IsNullable = false;
				colvarNgayThuchien.IsPrimaryKey = false;
				colvarNgayThuchien.IsForeignKey = false;
				colvarNgayThuchien.IsReadOnly = false;
				colvarNgayThuchien.DefaultSetting = @"";
				colvarNgayThuchien.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgayThuchien);
				
				TableSchema.TableColumn colvarNguoiNop = new TableSchema.TableColumn(schema);
				colvarNguoiNop.ColumnName = "nguoi_nop";
				colvarNguoiNop.DataType = DbType.String;
				colvarNguoiNop.MaxLength = 100;
				colvarNguoiNop.AutoIncrement = false;
				colvarNguoiNop.IsNullable = false;
				colvarNguoiNop.IsPrimaryKey = false;
				colvarNguoiNop.IsForeignKey = false;
				colvarNguoiNop.IsReadOnly = false;
				colvarNguoiNop.DefaultSetting = @"";
				colvarNguoiNop.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNguoiNop);
				
				TableSchema.TableColumn colvarLydoNop = new TableSchema.TableColumn(schema);
				colvarLydoNop.ColumnName = "lydo_nop";
				colvarLydoNop.DataType = DbType.String;
				colvarLydoNop.MaxLength = 500;
				colvarLydoNop.AutoIncrement = false;
				colvarLydoNop.IsNullable = false;
				colvarLydoNop.IsPrimaryKey = false;
				colvarLydoNop.IsForeignKey = false;
				colvarLydoNop.IsReadOnly = false;
				colvarLydoNop.DefaultSetting = @"";
				colvarLydoNop.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLydoNop);
				
				TableSchema.TableColumn colvarSoTien = new TableSchema.TableColumn(schema);
				colvarSoTien.ColumnName = "so_tien";
				colvarSoTien.DataType = DbType.Currency;
				colvarSoTien.MaxLength = 0;
				colvarSoTien.AutoIncrement = false;
				colvarSoTien.IsNullable = false;
				colvarSoTien.IsPrimaryKey = false;
				colvarSoTien.IsForeignKey = false;
				colvarSoTien.IsReadOnly = false;
				colvarSoTien.DefaultSetting = @"";
				colvarSoTien.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSoTien);
				
				TableSchema.TableColumn colvarSotienGoc = new TableSchema.TableColumn(schema);
				colvarSotienGoc.ColumnName = "sotien_goc";
				colvarSotienGoc.DataType = DbType.Decimal;
				colvarSotienGoc.MaxLength = 0;
				colvarSotienGoc.AutoIncrement = false;
				colvarSotienGoc.IsNullable = true;
				colvarSotienGoc.IsPrimaryKey = false;
				colvarSotienGoc.IsForeignKey = false;
				colvarSotienGoc.IsReadOnly = false;
				colvarSotienGoc.DefaultSetting = @"";
				colvarSotienGoc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSotienGoc);
				
				TableSchema.TableColumn colvarMaLydoChietkhau = new TableSchema.TableColumn(schema);
				colvarMaLydoChietkhau.ColumnName = "ma_lydo_chietkhau";
				colvarMaLydoChietkhau.DataType = DbType.String;
				colvarMaLydoChietkhau.MaxLength = 20;
				colvarMaLydoChietkhau.AutoIncrement = false;
				colvarMaLydoChietkhau.IsNullable = true;
				colvarMaLydoChietkhau.IsPrimaryKey = false;
				colvarMaLydoChietkhau.IsForeignKey = false;
				colvarMaLydoChietkhau.IsReadOnly = false;
				colvarMaLydoChietkhau.DefaultSetting = @"";
				colvarMaLydoChietkhau.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaLydoChietkhau);
				
				TableSchema.TableColumn colvarTienChietkhauchitiet = new TableSchema.TableColumn(schema);
				colvarTienChietkhauchitiet.ColumnName = "tien_chietkhauchitiet";
				colvarTienChietkhauchitiet.DataType = DbType.Decimal;
				colvarTienChietkhauchitiet.MaxLength = 0;
				colvarTienChietkhauchitiet.AutoIncrement = false;
				colvarTienChietkhauchitiet.IsNullable = true;
				colvarTienChietkhauchitiet.IsPrimaryKey = false;
				colvarTienChietkhauchitiet.IsForeignKey = false;
				colvarTienChietkhauchitiet.IsReadOnly = false;
				colvarTienChietkhauchitiet.DefaultSetting = @"";
				colvarTienChietkhauchitiet.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTienChietkhauchitiet);
				
				TableSchema.TableColumn colvarTienChietkhau = new TableSchema.TableColumn(schema);
				colvarTienChietkhau.ColumnName = "tien_chietkhau";
				colvarTienChietkhau.DataType = DbType.Decimal;
				colvarTienChietkhau.MaxLength = 0;
				colvarTienChietkhau.AutoIncrement = false;
				colvarTienChietkhau.IsNullable = true;
				colvarTienChietkhau.IsPrimaryKey = false;
				colvarTienChietkhau.IsForeignKey = false;
				colvarTienChietkhau.IsReadOnly = false;
				colvarTienChietkhau.DefaultSetting = @"";
				colvarTienChietkhau.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTienChietkhau);
				
				TableSchema.TableColumn colvarTienChietkhauhoadon = new TableSchema.TableColumn(schema);
				colvarTienChietkhauhoadon.ColumnName = "tien_chietkhauhoadon";
				colvarTienChietkhauhoadon.DataType = DbType.Decimal;
				colvarTienChietkhauhoadon.MaxLength = 0;
				colvarTienChietkhauhoadon.AutoIncrement = false;
				colvarTienChietkhauhoadon.IsNullable = true;
				colvarTienChietkhauhoadon.IsPrimaryKey = false;
				colvarTienChietkhauhoadon.IsForeignKey = false;
				colvarTienChietkhauhoadon.IsReadOnly = false;
				colvarTienChietkhauhoadon.DefaultSetting = @"";
				colvarTienChietkhauhoadon.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTienChietkhauhoadon);
				
				TableSchema.TableColumn colvarSoluongChungtugoc = new TableSchema.TableColumn(schema);
				colvarSoluongChungtugoc.ColumnName = "soluong_chungtugoc";
				colvarSoluongChungtugoc.DataType = DbType.Int16;
				colvarSoluongChungtugoc.MaxLength = 0;
				colvarSoluongChungtugoc.AutoIncrement = false;
				colvarSoluongChungtugoc.IsNullable = true;
				colvarSoluongChungtugoc.IsPrimaryKey = false;
				colvarSoluongChungtugoc.IsForeignKey = false;
				colvarSoluongChungtugoc.IsReadOnly = false;
				
						colvarSoluongChungtugoc.DefaultSetting = @"((1))";
				colvarSoluongChungtugoc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSoluongChungtugoc);
				
				TableSchema.TableColumn colvarTaikhoanNo = new TableSchema.TableColumn(schema);
				colvarTaikhoanNo.ColumnName = "taikhoan_no";
				colvarTaikhoanNo.DataType = DbType.String;
				colvarTaikhoanNo.MaxLength = 10;
				colvarTaikhoanNo.AutoIncrement = false;
				colvarTaikhoanNo.IsNullable = true;
				colvarTaikhoanNo.IsPrimaryKey = false;
				colvarTaikhoanNo.IsForeignKey = false;
				colvarTaikhoanNo.IsReadOnly = false;
				colvarTaikhoanNo.DefaultSetting = @"";
				colvarTaikhoanNo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTaikhoanNo);
				
				TableSchema.TableColumn colvarTaikhoanCo = new TableSchema.TableColumn(schema);
				colvarTaikhoanCo.ColumnName = "taikhoan_co";
				colvarTaikhoanCo.DataType = DbType.String;
				colvarTaikhoanCo.MaxLength = 10;
				colvarTaikhoanCo.AutoIncrement = false;
				colvarTaikhoanCo.IsNullable = true;
				colvarTaikhoanCo.IsPrimaryKey = false;
				colvarTaikhoanCo.IsForeignKey = false;
				colvarTaikhoanCo.IsReadOnly = false;
				colvarTaikhoanCo.DefaultSetting = @"";
				colvarTaikhoanCo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTaikhoanCo);
				
				TableSchema.TableColumn colvarLoaiPhieuthu = new TableSchema.TableColumn(schema);
				colvarLoaiPhieuthu.ColumnName = "loai_phieuthu";
				colvarLoaiPhieuthu.DataType = DbType.Byte;
				colvarLoaiPhieuthu.MaxLength = 0;
				colvarLoaiPhieuthu.AutoIncrement = false;
				colvarLoaiPhieuthu.IsNullable = true;
				colvarLoaiPhieuthu.IsPrimaryKey = false;
				colvarLoaiPhieuthu.IsForeignKey = false;
				colvarLoaiPhieuthu.IsReadOnly = false;
				colvarLoaiPhieuthu.DefaultSetting = @"";
				colvarLoaiPhieuthu.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLoaiPhieuthu);
				
				TableSchema.TableColumn colvarIdNhanvien = new TableSchema.TableColumn(schema);
				colvarIdNhanvien.ColumnName = "id_nhanvien";
				colvarIdNhanvien.DataType = DbType.Int16;
				colvarIdNhanvien.MaxLength = 0;
				colvarIdNhanvien.AutoIncrement = false;
				colvarIdNhanvien.IsNullable = true;
				colvarIdNhanvien.IsPrimaryKey = false;
				colvarIdNhanvien.IsForeignKey = false;
				colvarIdNhanvien.IsReadOnly = false;
				colvarIdNhanvien.DefaultSetting = @"";
				colvarIdNhanvien.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdNhanvien);
				
				TableSchema.TableColumn colvarIdKhoaThuchien = new TableSchema.TableColumn(schema);
				colvarIdKhoaThuchien.ColumnName = "id_khoa_thuchien";
				colvarIdKhoaThuchien.DataType = DbType.Int16;
				colvarIdKhoaThuchien.MaxLength = 0;
				colvarIdKhoaThuchien.AutoIncrement = false;
				colvarIdKhoaThuchien.IsNullable = true;
				colvarIdKhoaThuchien.IsPrimaryKey = false;
				colvarIdKhoaThuchien.IsForeignKey = false;
				colvarIdKhoaThuchien.IsReadOnly = false;
				colvarIdKhoaThuchien.DefaultSetting = @"";
				colvarIdKhoaThuchien.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdKhoaThuchien);
				
				TableSchema.TableColumn colvarNoiTru = new TableSchema.TableColumn(schema);
				colvarNoiTru.ColumnName = "noi_tru";
				colvarNoiTru.DataType = DbType.Byte;
				colvarNoiTru.MaxLength = 0;
				colvarNoiTru.AutoIncrement = false;
				colvarNoiTru.IsNullable = true;
				colvarNoiTru.IsPrimaryKey = false;
				colvarNoiTru.IsForeignKey = false;
				colvarNoiTru.IsReadOnly = false;
				colvarNoiTru.DefaultSetting = @"";
				colvarNoiTru.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNoiTru);
				
				TableSchema.TableColumn colvarNoiDung = new TableSchema.TableColumn(schema);
				colvarNoiDung.ColumnName = "noi_dung";
				colvarNoiDung.DataType = DbType.String;
				colvarNoiDung.MaxLength = 1000;
				colvarNoiDung.AutoIncrement = false;
				colvarNoiDung.IsNullable = true;
				colvarNoiDung.IsPrimaryKey = false;
				colvarNoiDung.IsForeignKey = false;
				colvarNoiDung.IsReadOnly = false;
				colvarNoiDung.DefaultSetting = @"";
				colvarNoiDung.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNoiDung);
				
				TableSchema.TableColumn colvarNguoiTao = new TableSchema.TableColumn(schema);
				colvarNguoiTao.ColumnName = "nguoi_tao";
				colvarNguoiTao.DataType = DbType.String;
				colvarNguoiTao.MaxLength = 50;
				colvarNguoiTao.AutoIncrement = false;
				colvarNguoiTao.IsNullable = true;
				colvarNguoiTao.IsPrimaryKey = false;
				colvarNguoiTao.IsForeignKey = false;
				colvarNguoiTao.IsReadOnly = false;
				colvarNguoiTao.DefaultSetting = @"";
				colvarNguoiTao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNguoiTao);
				
				TableSchema.TableColumn colvarNgayTao = new TableSchema.TableColumn(schema);
				colvarNgayTao.ColumnName = "ngay_tao";
				colvarNgayTao.DataType = DbType.DateTime;
				colvarNgayTao.MaxLength = 0;
				colvarNgayTao.AutoIncrement = false;
				colvarNgayTao.IsNullable = true;
				colvarNgayTao.IsPrimaryKey = false;
				colvarNgayTao.IsForeignKey = false;
				colvarNgayTao.IsReadOnly = false;
				colvarNgayTao.DefaultSetting = @"";
				colvarNgayTao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgayTao);
				
				TableSchema.TableColumn colvarNguoiSua = new TableSchema.TableColumn(schema);
				colvarNguoiSua.ColumnName = "nguoi_sua";
				colvarNguoiSua.DataType = DbType.String;
				colvarNguoiSua.MaxLength = 50;
				colvarNguoiSua.AutoIncrement = false;
				colvarNguoiSua.IsNullable = true;
				colvarNguoiSua.IsPrimaryKey = false;
				colvarNguoiSua.IsForeignKey = false;
				colvarNguoiSua.IsReadOnly = false;
				colvarNguoiSua.DefaultSetting = @"";
				colvarNguoiSua.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNguoiSua);
				
				TableSchema.TableColumn colvarNgaySua = new TableSchema.TableColumn(schema);
				colvarNgaySua.ColumnName = "ngay_sua";
				colvarNgaySua.DataType = DbType.DateTime;
				colvarNgaySua.MaxLength = 0;
				colvarNgaySua.AutoIncrement = false;
				colvarNgaySua.IsNullable = true;
				colvarNgaySua.IsPrimaryKey = false;
				colvarNgaySua.IsForeignKey = false;
				colvarNgaySua.IsReadOnly = false;
				colvarNgaySua.DefaultSetting = @"";
				colvarNgaySua.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgaySua);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ORM"].AddSchema("kcb_phieuthu",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdPhieuthu")]
		[Bindable(true)]
		public long IdPhieuthu 
		{
			get { return GetColumnValue<long>(Columns.IdPhieuthu); }
			set { SetColumnValue(Columns.IdPhieuthu, value); }
		}
		  
		[XmlAttribute("MaPhieuthu")]
		[Bindable(true)]
		public string MaPhieuthu 
		{
			get { return GetColumnValue<string>(Columns.MaPhieuthu); }
			set { SetColumnValue(Columns.MaPhieuthu, value); }
		}
		  
		[XmlAttribute("IdThanhtoan")]
		[Bindable(true)]
		public long IdThanhtoan 
		{
			get { return GetColumnValue<long>(Columns.IdThanhtoan); }
			set { SetColumnValue(Columns.IdThanhtoan, value); }
		}
		  
		[XmlAttribute("IdBenhnhan")]
		[Bindable(true)]
		public long? IdBenhnhan 
		{
			get { return GetColumnValue<long?>(Columns.IdBenhnhan); }
			set { SetColumnValue(Columns.IdBenhnhan, value); }
		}
		  
		[XmlAttribute("MaLuotkham")]
		[Bindable(true)]
		public string MaLuotkham 
		{
			get { return GetColumnValue<string>(Columns.MaLuotkham); }
			set { SetColumnValue(Columns.MaLuotkham, value); }
		}
		  
		[XmlAttribute("NgayThuchien")]
		[Bindable(true)]
		public DateTime NgayThuchien 
		{
			get { return GetColumnValue<DateTime>(Columns.NgayThuchien); }
			set { SetColumnValue(Columns.NgayThuchien, value); }
		}
		  
		[XmlAttribute("NguoiNop")]
		[Bindable(true)]
		public string NguoiNop 
		{
			get { return GetColumnValue<string>(Columns.NguoiNop); }
			set { SetColumnValue(Columns.NguoiNop, value); }
		}
		  
		[XmlAttribute("LydoNop")]
		[Bindable(true)]
		public string LydoNop 
		{
			get { return GetColumnValue<string>(Columns.LydoNop); }
			set { SetColumnValue(Columns.LydoNop, value); }
		}
		  
		[XmlAttribute("SoTien")]
		[Bindable(true)]
		public decimal SoTien 
		{
			get { return GetColumnValue<decimal>(Columns.SoTien); }
			set { SetColumnValue(Columns.SoTien, value); }
		}
		  
		[XmlAttribute("SotienGoc")]
		[Bindable(true)]
		public decimal? SotienGoc 
		{
			get { return GetColumnValue<decimal?>(Columns.SotienGoc); }
			set { SetColumnValue(Columns.SotienGoc, value); }
		}
		  
		[XmlAttribute("MaLydoChietkhau")]
		[Bindable(true)]
		public string MaLydoChietkhau 
		{
			get { return GetColumnValue<string>(Columns.MaLydoChietkhau); }
			set { SetColumnValue(Columns.MaLydoChietkhau, value); }
		}
		  
		[XmlAttribute("TienChietkhauchitiet")]
		[Bindable(true)]
		public decimal? TienChietkhauchitiet 
		{
			get { return GetColumnValue<decimal?>(Columns.TienChietkhauchitiet); }
			set { SetColumnValue(Columns.TienChietkhauchitiet, value); }
		}
		  
		[XmlAttribute("TienChietkhau")]
		[Bindable(true)]
		public decimal? TienChietkhau 
		{
			get { return GetColumnValue<decimal?>(Columns.TienChietkhau); }
			set { SetColumnValue(Columns.TienChietkhau, value); }
		}
		  
		[XmlAttribute("TienChietkhauhoadon")]
		[Bindable(true)]
		public decimal? TienChietkhauhoadon 
		{
			get { return GetColumnValue<decimal?>(Columns.TienChietkhauhoadon); }
			set { SetColumnValue(Columns.TienChietkhauhoadon, value); }
		}
		  
		[XmlAttribute("SoluongChungtugoc")]
		[Bindable(true)]
		public short? SoluongChungtugoc 
		{
			get { return GetColumnValue<short?>(Columns.SoluongChungtugoc); }
			set { SetColumnValue(Columns.SoluongChungtugoc, value); }
		}
		  
		[XmlAttribute("TaikhoanNo")]
		[Bindable(true)]
		public string TaikhoanNo 
		{
			get { return GetColumnValue<string>(Columns.TaikhoanNo); }
			set { SetColumnValue(Columns.TaikhoanNo, value); }
		}
		  
		[XmlAttribute("TaikhoanCo")]
		[Bindable(true)]
		public string TaikhoanCo 
		{
			get { return GetColumnValue<string>(Columns.TaikhoanCo); }
			set { SetColumnValue(Columns.TaikhoanCo, value); }
		}
		  
		[XmlAttribute("LoaiPhieuthu")]
		[Bindable(true)]
		public byte? LoaiPhieuthu 
		{
			get { return GetColumnValue<byte?>(Columns.LoaiPhieuthu); }
			set { SetColumnValue(Columns.LoaiPhieuthu, value); }
		}
		  
		[XmlAttribute("IdNhanvien")]
		[Bindable(true)]
		public short? IdNhanvien 
		{
			get { return GetColumnValue<short?>(Columns.IdNhanvien); }
			set { SetColumnValue(Columns.IdNhanvien, value); }
		}
		  
		[XmlAttribute("IdKhoaThuchien")]
		[Bindable(true)]
		public short? IdKhoaThuchien 
		{
			get { return GetColumnValue<short?>(Columns.IdKhoaThuchien); }
			set { SetColumnValue(Columns.IdKhoaThuchien, value); }
		}
		  
		[XmlAttribute("NoiTru")]
		[Bindable(true)]
		public byte? NoiTru 
		{
			get { return GetColumnValue<byte?>(Columns.NoiTru); }
			set { SetColumnValue(Columns.NoiTru, value); }
		}
		  
		[XmlAttribute("NoiDung")]
		[Bindable(true)]
		public string NoiDung 
		{
			get { return GetColumnValue<string>(Columns.NoiDung); }
			set { SetColumnValue(Columns.NoiDung, value); }
		}
		  
		[XmlAttribute("NguoiTao")]
		[Bindable(true)]
		public string NguoiTao 
		{
			get { return GetColumnValue<string>(Columns.NguoiTao); }
			set { SetColumnValue(Columns.NguoiTao, value); }
		}
		  
		[XmlAttribute("NgayTao")]
		[Bindable(true)]
		public DateTime? NgayTao 
		{
			get { return GetColumnValue<DateTime?>(Columns.NgayTao); }
			set { SetColumnValue(Columns.NgayTao, value); }
		}
		  
		[XmlAttribute("NguoiSua")]
		[Bindable(true)]
		public string NguoiSua 
		{
			get { return GetColumnValue<string>(Columns.NguoiSua); }
			set { SetColumnValue(Columns.NguoiSua, value); }
		}
		  
		[XmlAttribute("NgaySua")]
		[Bindable(true)]
		public DateTime? NgaySua 
		{
			get { return GetColumnValue<DateTime?>(Columns.NgaySua); }
			set { SetColumnValue(Columns.NgaySua, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varMaPhieuthu,long varIdThanhtoan,long? varIdBenhnhan,string varMaLuotkham,DateTime varNgayThuchien,string varNguoiNop,string varLydoNop,decimal varSoTien,decimal? varSotienGoc,string varMaLydoChietkhau,decimal? varTienChietkhauchitiet,decimal? varTienChietkhau,decimal? varTienChietkhauhoadon,short? varSoluongChungtugoc,string varTaikhoanNo,string varTaikhoanCo,byte? varLoaiPhieuthu,short? varIdNhanvien,short? varIdKhoaThuchien,byte? varNoiTru,string varNoiDung,string varNguoiTao,DateTime? varNgayTao,string varNguoiSua,DateTime? varNgaySua)
		{
			KcbPhieuthu item = new KcbPhieuthu();
			
			item.MaPhieuthu = varMaPhieuthu;
			
			item.IdThanhtoan = varIdThanhtoan;
			
			item.IdBenhnhan = varIdBenhnhan;
			
			item.MaLuotkham = varMaLuotkham;
			
			item.NgayThuchien = varNgayThuchien;
			
			item.NguoiNop = varNguoiNop;
			
			item.LydoNop = varLydoNop;
			
			item.SoTien = varSoTien;
			
			item.SotienGoc = varSotienGoc;
			
			item.MaLydoChietkhau = varMaLydoChietkhau;
			
			item.TienChietkhauchitiet = varTienChietkhauchitiet;
			
			item.TienChietkhau = varTienChietkhau;
			
			item.TienChietkhauhoadon = varTienChietkhauhoadon;
			
			item.SoluongChungtugoc = varSoluongChungtugoc;
			
			item.TaikhoanNo = varTaikhoanNo;
			
			item.TaikhoanCo = varTaikhoanCo;
			
			item.LoaiPhieuthu = varLoaiPhieuthu;
			
			item.IdNhanvien = varIdNhanvien;
			
			item.IdKhoaThuchien = varIdKhoaThuchien;
			
			item.NoiTru = varNoiTru;
			
			item.NoiDung = varNoiDung;
			
			item.NguoiTao = varNguoiTao;
			
			item.NgayTao = varNgayTao;
			
			item.NguoiSua = varNguoiSua;
			
			item.NgaySua = varNgaySua;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(long varIdPhieuthu,string varMaPhieuthu,long varIdThanhtoan,long? varIdBenhnhan,string varMaLuotkham,DateTime varNgayThuchien,string varNguoiNop,string varLydoNop,decimal varSoTien,decimal? varSotienGoc,string varMaLydoChietkhau,decimal? varTienChietkhauchitiet,decimal? varTienChietkhau,decimal? varTienChietkhauhoadon,short? varSoluongChungtugoc,string varTaikhoanNo,string varTaikhoanCo,byte? varLoaiPhieuthu,short? varIdNhanvien,short? varIdKhoaThuchien,byte? varNoiTru,string varNoiDung,string varNguoiTao,DateTime? varNgayTao,string varNguoiSua,DateTime? varNgaySua)
		{
			KcbPhieuthu item = new KcbPhieuthu();
			
				item.IdPhieuthu = varIdPhieuthu;
			
				item.MaPhieuthu = varMaPhieuthu;
			
				item.IdThanhtoan = varIdThanhtoan;
			
				item.IdBenhnhan = varIdBenhnhan;
			
				item.MaLuotkham = varMaLuotkham;
			
				item.NgayThuchien = varNgayThuchien;
			
				item.NguoiNop = varNguoiNop;
			
				item.LydoNop = varLydoNop;
			
				item.SoTien = varSoTien;
			
				item.SotienGoc = varSotienGoc;
			
				item.MaLydoChietkhau = varMaLydoChietkhau;
			
				item.TienChietkhauchitiet = varTienChietkhauchitiet;
			
				item.TienChietkhau = varTienChietkhau;
			
				item.TienChietkhauhoadon = varTienChietkhauhoadon;
			
				item.SoluongChungtugoc = varSoluongChungtugoc;
			
				item.TaikhoanNo = varTaikhoanNo;
			
				item.TaikhoanCo = varTaikhoanCo;
			
				item.LoaiPhieuthu = varLoaiPhieuthu;
			
				item.IdNhanvien = varIdNhanvien;
			
				item.IdKhoaThuchien = varIdKhoaThuchien;
			
				item.NoiTru = varNoiTru;
			
				item.NoiDung = varNoiDung;
			
				item.NguoiTao = varNguoiTao;
			
				item.NgayTao = varNgayTao;
			
				item.NguoiSua = varNguoiSua;
			
				item.NgaySua = varNgaySua;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdPhieuthuColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MaPhieuthuColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdThanhtoanColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdBenhnhanColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn MaLuotkhamColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayThuchienColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiNopColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn LydoNopColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn SoTienColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn SotienGocColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn MaLydoChietkhauColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn TienChietkhauchitietColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn TienChietkhauColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn TienChietkhauhoadonColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn SoluongChungtugocColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn TaikhoanNoColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn TaikhoanCoColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn LoaiPhieuthuColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn IdNhanvienColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn IdKhoaThuchienColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn NoiTruColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn NoiDungColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiTaoColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayTaoColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiSuaColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn NgaySuaColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdPhieuthu = @"id_phieuthu";
			 public static string MaPhieuthu = @"ma_phieuthu";
			 public static string IdThanhtoan = @"id_thanhtoan";
			 public static string IdBenhnhan = @"id_benhnhan";
			 public static string MaLuotkham = @"ma_luotkham";
			 public static string NgayThuchien = @"ngay_thuchien";
			 public static string NguoiNop = @"nguoi_nop";
			 public static string LydoNop = @"lydo_nop";
			 public static string SoTien = @"so_tien";
			 public static string SotienGoc = @"sotien_goc";
			 public static string MaLydoChietkhau = @"ma_lydo_chietkhau";
			 public static string TienChietkhauchitiet = @"tien_chietkhauchitiet";
			 public static string TienChietkhau = @"tien_chietkhau";
			 public static string TienChietkhauhoadon = @"tien_chietkhauhoadon";
			 public static string SoluongChungtugoc = @"soluong_chungtugoc";
			 public static string TaikhoanNo = @"taikhoan_no";
			 public static string TaikhoanCo = @"taikhoan_co";
			 public static string LoaiPhieuthu = @"loai_phieuthu";
			 public static string IdNhanvien = @"id_nhanvien";
			 public static string IdKhoaThuchien = @"id_khoa_thuchien";
			 public static string NoiTru = @"noi_tru";
			 public static string NoiDung = @"noi_dung";
			 public static string NguoiTao = @"nguoi_tao";
			 public static string NgayTao = @"ngay_tao";
			 public static string NguoiSua = @"nguoi_sua";
			 public static string NgaySua = @"ngay_sua";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
