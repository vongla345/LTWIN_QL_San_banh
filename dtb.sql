use  QLSanbanh
go

create table San(
	maSan nvarchar(50) primary key,
	tenSan nvarchar(50),
	loaiSan nvarchar(50), check (loaiSan = N'Sân cỏ thật' or loaiSan= N'Sân cỏ nhân tạo' or loaiSan= N'Sân futsal'),
	kichThuoc int ,check (kichThuoc=5 or kichThuoc = 7 or kichThuoc =11),
	giaTien int
)

create table NhanVien(
	maNV nvarchar(50) primary key,
	tenNV nvarchar(50),
	gioiTinh nvarchar(50) check (gioiTinh = N'Nam' or gioiTinh = N'Nữ'),
	ngaySinh date,
	sdt nvarchar(50),
	diaChi nvarchar(50),
	taiKhoan nvarchar(50),
	matKhau nvarchar(50)
)

create table DonDatSan(
	maDon nvarchar(50) primary key,
	maSan nvarchar(50) constraint DDS_maSan foreign key (maSan) references San (maSan),
	maNV nvarchar(50) constraint DDS_maNV foreign key (maNV)references NhanVien (maNV),
	tenNguoiDat nvarchar(50),
	thoiGianDat datetime,
	thoiLuong int,
	tongTien int,
)



