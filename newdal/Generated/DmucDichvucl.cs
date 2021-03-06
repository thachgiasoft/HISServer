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
	/// Strongly-typed collection for the DmucDichvucl class.
	/// </summary>
    [Serializable]
	public partial class DmucDichvuclCollection : ActiveList<DmucDichvucl, DmucDichvuclCollection>
	{	   
		public DmucDichvuclCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>DmucDichvuclCollection</returns>
		public DmucDichvuclCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                DmucDichvucl o = this[i];
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
	/// This is an ActiveRecord class which wraps the dmuc_dichvucls table.
	/// </summary>
	[Serializable]
	public partial class DmucDichvucl : ActiveRecord<DmucDichvucl>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public DmucDichvucl()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public DmucDichvucl(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public DmucDichvucl(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public DmucDichvucl(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("dmuc_dichvucls", TableType.Table, DataService.GetInstance("ORM"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdDichvu = new TableSchema.TableColumn(schema);
				colvarIdDichvu.ColumnName = "id_dichvu";
				colvarIdDichvu.DataType = DbType.Int16;
				colvarIdDichvu.MaxLength = 0;
				colvarIdDichvu.AutoIncrement = true;
				colvarIdDichvu.IsNullable = false;
				colvarIdDichvu.IsPrimaryKey = true;
				colvarIdDichvu.IsForeignKey = false;
				colvarIdDichvu.IsReadOnly = false;
				colvarIdDichvu.DefaultSetting = @"";
				colvarIdDichvu.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdDichvu);
				
				TableSchema.TableColumn colvarIdLoaidichvu = new TableSchema.TableColumn(schema);
				colvarIdLoaidichvu.ColumnName = "id_loaidichvu";
				colvarIdLoaidichvu.DataType = DbType.String;
				colvarIdLoaidichvu.MaxLength = 20;
				colvarIdLoaidichvu.AutoIncrement = false;
				colvarIdLoaidichvu.IsNullable = false;
				colvarIdLoaidichvu.IsPrimaryKey = false;
				colvarIdLoaidichvu.IsForeignKey = false;
				colvarIdLoaidichvu.IsReadOnly = false;
				colvarIdLoaidichvu.DefaultSetting = @"";
				colvarIdLoaidichvu.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdLoaidichvu);
				
				TableSchema.TableColumn colvarMaDichvu = new TableSchema.TableColumn(schema);
				colvarMaDichvu.ColumnName = "ma_dichvu";
				colvarMaDichvu.DataType = DbType.AnsiString;
				colvarMaDichvu.MaxLength = 20;
				colvarMaDichvu.AutoIncrement = false;
				colvarMaDichvu.IsNullable = true;
				colvarMaDichvu.IsPrimaryKey = false;
				colvarMaDichvu.IsForeignKey = false;
				colvarMaDichvu.IsReadOnly = false;
				colvarMaDichvu.DefaultSetting = @"";
				colvarMaDichvu.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaDichvu);
				
				TableSchema.TableColumn colvarTenDichvu = new TableSchema.TableColumn(schema);
				colvarTenDichvu.ColumnName = "ten_dichvu";
				colvarTenDichvu.DataType = DbType.String;
				colvarTenDichvu.MaxLength = 300;
				colvarTenDichvu.AutoIncrement = false;
				colvarTenDichvu.IsNullable = false;
				colvarTenDichvu.IsPrimaryKey = false;
				colvarTenDichvu.IsForeignKey = false;
				colvarTenDichvu.IsReadOnly = false;
				colvarTenDichvu.DefaultSetting = @"";
				colvarTenDichvu.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTenDichvu);
				
				TableSchema.TableColumn colvarDonGia = new TableSchema.TableColumn(schema);
				colvarDonGia.ColumnName = "don_gia";
				colvarDonGia.DataType = DbType.Decimal;
				colvarDonGia.MaxLength = 0;
				colvarDonGia.AutoIncrement = false;
				colvarDonGia.IsNullable = false;
				colvarDonGia.IsPrimaryKey = false;
				colvarDonGia.IsForeignKey = false;
				colvarDonGia.IsReadOnly = false;
				colvarDonGia.DefaultSetting = @"";
				colvarDonGia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDonGia);
				
				TableSchema.TableColumn colvarTrangThai = new TableSchema.TableColumn(schema);
				colvarTrangThai.ColumnName = "trang_thai";
				colvarTrangThai.DataType = DbType.Byte;
				colvarTrangThai.MaxLength = 0;
				colvarTrangThai.AutoIncrement = false;
				colvarTrangThai.IsNullable = false;
				colvarTrangThai.IsPrimaryKey = false;
				colvarTrangThai.IsForeignKey = false;
				colvarTrangThai.IsReadOnly = false;
				colvarTrangThai.DefaultSetting = @"";
				colvarTrangThai.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTrangThai);
				
				TableSchema.TableColumn colvarDichvuKtc = new TableSchema.TableColumn(schema);
				colvarDichvuKtc.ColumnName = "dichvu_ktc";
				colvarDichvuKtc.DataType = DbType.Int16;
				colvarDichvuKtc.MaxLength = 0;
				colvarDichvuKtc.AutoIncrement = false;
				colvarDichvuKtc.IsNullable = true;
				colvarDichvuKtc.IsPrimaryKey = false;
				colvarDichvuKtc.IsForeignKey = false;
				colvarDichvuKtc.IsReadOnly = false;
				colvarDichvuKtc.DefaultSetting = @"";
				colvarDichvuKtc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDichvuKtc);
				
				TableSchema.TableColumn colvarSttHthi = new TableSchema.TableColumn(schema);
				colvarSttHthi.ColumnName = "stt_hthi";
				colvarSttHthi.DataType = DbType.Int16;
				colvarSttHthi.MaxLength = 0;
				colvarSttHthi.AutoIncrement = false;
				colvarSttHthi.IsNullable = false;
				colvarSttHthi.IsPrimaryKey = false;
				colvarSttHthi.IsForeignKey = false;
				colvarSttHthi.IsReadOnly = false;
				colvarSttHthi.DefaultSetting = @"";
				colvarSttHthi.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSttHthi);
				
				TableSchema.TableColumn colvarHienthiChitiet = new TableSchema.TableColumn(schema);
				colvarHienthiChitiet.ColumnName = "hienthi_chitiet";
				colvarHienthiChitiet.DataType = DbType.Byte;
				colvarHienthiChitiet.MaxLength = 0;
				colvarHienthiChitiet.AutoIncrement = false;
				colvarHienthiChitiet.IsNullable = true;
				colvarHienthiChitiet.IsPrimaryKey = false;
				colvarHienthiChitiet.IsForeignKey = false;
				colvarHienthiChitiet.IsReadOnly = false;
				
						colvarHienthiChitiet.DefaultSetting = @"((1))";
				colvarHienthiChitiet.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHienthiChitiet);
				
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
				
				TableSchema.TableColumn colvarIdPhongThuchien = new TableSchema.TableColumn(schema);
				colvarIdPhongThuchien.ColumnName = "id_phong_thuchien";
				colvarIdPhongThuchien.DataType = DbType.Int16;
				colvarIdPhongThuchien.MaxLength = 0;
				colvarIdPhongThuchien.AutoIncrement = false;
				colvarIdPhongThuchien.IsNullable = true;
				colvarIdPhongThuchien.IsPrimaryKey = false;
				colvarIdPhongThuchien.IsForeignKey = false;
				colvarIdPhongThuchien.IsReadOnly = false;
				colvarIdPhongThuchien.DefaultSetting = @"";
				colvarIdPhongThuchien.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPhongThuchien);
				
				TableSchema.TableColumn colvarChiDan = new TableSchema.TableColumn(schema);
				colvarChiDan.ColumnName = "chi_dan";
				colvarChiDan.DataType = DbType.String;
				colvarChiDan.MaxLength = 255;
				colvarChiDan.AutoIncrement = false;
				colvarChiDan.IsNullable = true;
				colvarChiDan.IsPrimaryKey = false;
				colvarChiDan.IsForeignKey = false;
				colvarChiDan.IsReadOnly = false;
				colvarChiDan.DefaultSetting = @"";
				colvarChiDan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarChiDan);
				
				TableSchema.TableColumn colvarNhomBaocao = new TableSchema.TableColumn(schema);
				colvarNhomBaocao.ColumnName = "nhom_baocao";
				colvarNhomBaocao.DataType = DbType.String;
				colvarNhomBaocao.MaxLength = 20;
				colvarNhomBaocao.AutoIncrement = false;
				colvarNhomBaocao.IsNullable = true;
				colvarNhomBaocao.IsPrimaryKey = false;
				colvarNhomBaocao.IsForeignKey = false;
				colvarNhomBaocao.IsReadOnly = false;
				colvarNhomBaocao.DefaultSetting = @"";
				colvarNhomBaocao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNhomBaocao);
				
				TableSchema.TableColumn colvarNhomInCls = new TableSchema.TableColumn(schema);
				colvarNhomInCls.ColumnName = "nhom_in_cls";
				colvarNhomInCls.DataType = DbType.String;
				colvarNhomInCls.MaxLength = 20;
				colvarNhomInCls.AutoIncrement = false;
				colvarNhomInCls.IsNullable = true;
				colvarNhomInCls.IsPrimaryKey = false;
				colvarNhomInCls.IsForeignKey = false;
				colvarNhomInCls.IsReadOnly = false;
				colvarNhomInCls.DefaultSetting = @"";
				colvarNhomInCls.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNhomInCls);
				
				TableSchema.TableColumn colvarMotaThem = new TableSchema.TableColumn(schema);
				colvarMotaThem.ColumnName = "mota_them";
				colvarMotaThem.DataType = DbType.String;
				colvarMotaThem.MaxLength = 255;
				colvarMotaThem.AutoIncrement = false;
				colvarMotaThem.IsNullable = true;
				colvarMotaThem.IsPrimaryKey = false;
				colvarMotaThem.IsForeignKey = false;
				colvarMotaThem.IsReadOnly = false;
				colvarMotaThem.DefaultSetting = @"";
				colvarMotaThem.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMotaThem);
				
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
				
				TableSchema.TableColumn colvarIdVungkhaosat = new TableSchema.TableColumn(schema);
				colvarIdVungkhaosat.ColumnName = "id_vungkhaosat";
				colvarIdVungkhaosat.DataType = DbType.Int32;
				colvarIdVungkhaosat.MaxLength = 0;
				colvarIdVungkhaosat.AutoIncrement = false;
				colvarIdVungkhaosat.IsNullable = true;
				colvarIdVungkhaosat.IsPrimaryKey = false;
				colvarIdVungkhaosat.IsForeignKey = false;
				colvarIdVungkhaosat.IsReadOnly = false;
				colvarIdVungkhaosat.DefaultSetting = @"";
				colvarIdVungkhaosat.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdVungkhaosat);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ORM"].AddSchema("dmuc_dichvucls",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdDichvu")]
		[Bindable(true)]
		public short IdDichvu 
		{
			get { return GetColumnValue<short>(Columns.IdDichvu); }
			set { SetColumnValue(Columns.IdDichvu, value); }
		}
		  
		[XmlAttribute("IdLoaidichvu")]
		[Bindable(true)]
		public string IdLoaidichvu 
		{
			get { return GetColumnValue<string>(Columns.IdLoaidichvu); }
			set { SetColumnValue(Columns.IdLoaidichvu, value); }
		}
		  
		[XmlAttribute("MaDichvu")]
		[Bindable(true)]
		public string MaDichvu 
		{
			get { return GetColumnValue<string>(Columns.MaDichvu); }
			set { SetColumnValue(Columns.MaDichvu, value); }
		}
		  
		[XmlAttribute("TenDichvu")]
		[Bindable(true)]
		public string TenDichvu 
		{
			get { return GetColumnValue<string>(Columns.TenDichvu); }
			set { SetColumnValue(Columns.TenDichvu, value); }
		}
		  
		[XmlAttribute("DonGia")]
		[Bindable(true)]
		public decimal DonGia 
		{
			get { return GetColumnValue<decimal>(Columns.DonGia); }
			set { SetColumnValue(Columns.DonGia, value); }
		}
		  
		[XmlAttribute("TrangThai")]
		[Bindable(true)]
		public byte TrangThai 
		{
			get { return GetColumnValue<byte>(Columns.TrangThai); }
			set { SetColumnValue(Columns.TrangThai, value); }
		}
		  
		[XmlAttribute("DichvuKtc")]
		[Bindable(true)]
		public short? DichvuKtc 
		{
			get { return GetColumnValue<short?>(Columns.DichvuKtc); }
			set { SetColumnValue(Columns.DichvuKtc, value); }
		}
		  
		[XmlAttribute("SttHthi")]
		[Bindable(true)]
		public short SttHthi 
		{
			get { return GetColumnValue<short>(Columns.SttHthi); }
			set { SetColumnValue(Columns.SttHthi, value); }
		}
		  
		[XmlAttribute("HienthiChitiet")]
		[Bindable(true)]
		public byte? HienthiChitiet 
		{
			get { return GetColumnValue<byte?>(Columns.HienthiChitiet); }
			set { SetColumnValue(Columns.HienthiChitiet, value); }
		}
		  
		[XmlAttribute("IdKhoaThuchien")]
		[Bindable(true)]
		public short? IdKhoaThuchien 
		{
			get { return GetColumnValue<short?>(Columns.IdKhoaThuchien); }
			set { SetColumnValue(Columns.IdKhoaThuchien, value); }
		}
		  
		[XmlAttribute("IdPhongThuchien")]
		[Bindable(true)]
		public short? IdPhongThuchien 
		{
			get { return GetColumnValue<short?>(Columns.IdPhongThuchien); }
			set { SetColumnValue(Columns.IdPhongThuchien, value); }
		}
		  
		[XmlAttribute("ChiDan")]
		[Bindable(true)]
		public string ChiDan 
		{
			get { return GetColumnValue<string>(Columns.ChiDan); }
			set { SetColumnValue(Columns.ChiDan, value); }
		}
		  
		[XmlAttribute("NhomBaocao")]
		[Bindable(true)]
		public string NhomBaocao 
		{
			get { return GetColumnValue<string>(Columns.NhomBaocao); }
			set { SetColumnValue(Columns.NhomBaocao, value); }
		}
		  
		[XmlAttribute("NhomInCls")]
		[Bindable(true)]
		public string NhomInCls 
		{
			get { return GetColumnValue<string>(Columns.NhomInCls); }
			set { SetColumnValue(Columns.NhomInCls, value); }
		}
		  
		[XmlAttribute("MotaThem")]
		[Bindable(true)]
		public string MotaThem 
		{
			get { return GetColumnValue<string>(Columns.MotaThem); }
			set { SetColumnValue(Columns.MotaThem, value); }
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
		  
		[XmlAttribute("IdVungkhaosat")]
		[Bindable(true)]
		public int? IdVungkhaosat 
		{
			get { return GetColumnValue<int?>(Columns.IdVungkhaosat); }
			set { SetColumnValue(Columns.IdVungkhaosat, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varIdLoaidichvu,string varMaDichvu,string varTenDichvu,decimal varDonGia,byte varTrangThai,short? varDichvuKtc,short varSttHthi,byte? varHienthiChitiet,short? varIdKhoaThuchien,short? varIdPhongThuchien,string varChiDan,string varNhomBaocao,string varNhomInCls,string varMotaThem,string varNguoiTao,DateTime? varNgayTao,string varNguoiSua,DateTime? varNgaySua,int? varIdVungkhaosat)
		{
			DmucDichvucl item = new DmucDichvucl();
			
			item.IdLoaidichvu = varIdLoaidichvu;
			
			item.MaDichvu = varMaDichvu;
			
			item.TenDichvu = varTenDichvu;
			
			item.DonGia = varDonGia;
			
			item.TrangThai = varTrangThai;
			
			item.DichvuKtc = varDichvuKtc;
			
			item.SttHthi = varSttHthi;
			
			item.HienthiChitiet = varHienthiChitiet;
			
			item.IdKhoaThuchien = varIdKhoaThuchien;
			
			item.IdPhongThuchien = varIdPhongThuchien;
			
			item.ChiDan = varChiDan;
			
			item.NhomBaocao = varNhomBaocao;
			
			item.NhomInCls = varNhomInCls;
			
			item.MotaThem = varMotaThem;
			
			item.NguoiTao = varNguoiTao;
			
			item.NgayTao = varNgayTao;
			
			item.NguoiSua = varNguoiSua;
			
			item.NgaySua = varNgaySua;
			
			item.IdVungkhaosat = varIdVungkhaosat;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(short varIdDichvu,string varIdLoaidichvu,string varMaDichvu,string varTenDichvu,decimal varDonGia,byte varTrangThai,short? varDichvuKtc,short varSttHthi,byte? varHienthiChitiet,short? varIdKhoaThuchien,short? varIdPhongThuchien,string varChiDan,string varNhomBaocao,string varNhomInCls,string varMotaThem,string varNguoiTao,DateTime? varNgayTao,string varNguoiSua,DateTime? varNgaySua,int? varIdVungkhaosat)
		{
			DmucDichvucl item = new DmucDichvucl();
			
				item.IdDichvu = varIdDichvu;
			
				item.IdLoaidichvu = varIdLoaidichvu;
			
				item.MaDichvu = varMaDichvu;
			
				item.TenDichvu = varTenDichvu;
			
				item.DonGia = varDonGia;
			
				item.TrangThai = varTrangThai;
			
				item.DichvuKtc = varDichvuKtc;
			
				item.SttHthi = varSttHthi;
			
				item.HienthiChitiet = varHienthiChitiet;
			
				item.IdKhoaThuchien = varIdKhoaThuchien;
			
				item.IdPhongThuchien = varIdPhongThuchien;
			
				item.ChiDan = varChiDan;
			
				item.NhomBaocao = varNhomBaocao;
			
				item.NhomInCls = varNhomInCls;
			
				item.MotaThem = varMotaThem;
			
				item.NguoiTao = varNguoiTao;
			
				item.NgayTao = varNgayTao;
			
				item.NguoiSua = varNguoiSua;
			
				item.NgaySua = varNgaySua;
			
				item.IdVungkhaosat = varIdVungkhaosat;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdDichvuColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdLoaidichvuColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn MaDichvuColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn TenDichvuColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn DonGiaColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn TrangThaiColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn DichvuKtcColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn SttHthiColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn HienthiChitietColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn IdKhoaThuchienColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPhongThuchienColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn ChiDanColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn NhomBaocaoColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn NhomInClsColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn MotaThemColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiTaoColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayTaoColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiSuaColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn NgaySuaColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn IdVungkhaosatColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdDichvu = @"id_dichvu";
			 public static string IdLoaidichvu = @"id_loaidichvu";
			 public static string MaDichvu = @"ma_dichvu";
			 public static string TenDichvu = @"ten_dichvu";
			 public static string DonGia = @"don_gia";
			 public static string TrangThai = @"trang_thai";
			 public static string DichvuKtc = @"dichvu_ktc";
			 public static string SttHthi = @"stt_hthi";
			 public static string HienthiChitiet = @"hienthi_chitiet";
			 public static string IdKhoaThuchien = @"id_khoa_thuchien";
			 public static string IdPhongThuchien = @"id_phong_thuchien";
			 public static string ChiDan = @"chi_dan";
			 public static string NhomBaocao = @"nhom_baocao";
			 public static string NhomInCls = @"nhom_in_cls";
			 public static string MotaThem = @"mota_them";
			 public static string NguoiTao = @"nguoi_tao";
			 public static string NgayTao = @"ngay_tao";
			 public static string NguoiSua = @"nguoi_sua";
			 public static string NgaySua = @"ngay_sua";
			 public static string IdVungkhaosat = @"id_vungkhaosat";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
