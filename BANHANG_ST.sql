ALTER DATABASE QLBANHANG_ST
GO
use QLBANHANG_ST
GO
ALTER TABLE HangHoa(
	ID_HangHoa CHAR(10) NOT NULL,
	TenHang NVARCHAR(50) NOT NULL,
	GiaHang int,
	NgayNhap datetime,
	HanSd datetime,
	SoLuong int
)

ALTER TABLE NhanVien(
	ID_NhanVien CHAR(10) NOT NULL,
	HoTen NVARCHAR(50) NOT NULL,
	Quequan nvarchar(100),
	GT CHAR(3),
	CMND int,
	NgaySinh datetime,
	Luong int
)

ALTER TABLE KhachHang(
	ID_KhachHang CHAR(10) NOT NULL,
	Ten_KhachHang NVARCHAR(50),
	SDT_KhachHang int,
	GioiTinh_KhachHang NVARCHAR(100)
)

ALTER TABLE HoaDon(
	ID_HoaDon CHAR(10) NOT NULL,
	Ten_HoaDon NVARCHAR(30),
	ID_KhachHang char(10) not null,
	ID_HangHoa char(10) not null,
	ID_NhanVien char(10)not null
)

alter table HangHoa add constraint HH_ID_PK primary key(ID_HangHoa)
alter table NhanVien add constraint NV_ID_PK primary key(ID_NhanVien)
alter table KhachHang add constraint KH_ID_PK primary key(ID_KhachHang)
alter table HoaDon add constraint HD_ID_PK primary key(ID_HoaDon)


insert into HangHoa(ID_HangHoa,TenHang,GiaHang,NgayNhap,HanSd,soluong)values('HH001',N'Sữa Tắm Nam','100000','2015-01-01','2017-01-01',1000)
insert into HangHoa(ID_HangHoa,TenHang,GiaHang,NgayNhap,HanSd,soluong)values('HH002',N'Dầu Gội','50000','2015-03-01','2017-09-02',2000)
insert into HangHoa(ID_HangHoa,TenHang,GiaHang,NgayNhap,HanSd,soluong)values('HH003',N'Khăn Tắm','20000','2015-01-01','2020-09-02',2000)
insert into HangHoa(ID_HangHoa,TenHang,GiaHang,NgayNhap,HanSd,soluong)values('HH004',N'Ti Vi','3000000','2014-01-01','2020-03-04',3000)
insert into HangHoa(ID_HangHoa,TenHang,GiaHang,NgayNhap,HanSd,soluong)values('HH005',N'Quạt Điện','1000000','2015-3-01','2022-02-02',2500)
insert into HangHoa(ID_HangHoa,TenHang,GiaHang,NgayNhap,HanSd,soluong)values('HH006',N'Ấm Siêu Tốc','500000','2014-04-03','2021-02-02',5000)
insert into HangHoa(ID_HangHoa,TenHang,GiaHang,NgayNhap,HanSd,soluong)values('HH007',N'Chăn Bông','200000','2013-04-01','2017-02-04',5000)
insert into HangHoa(ID_HangHoa,TenHang,GiaHang,NgayNhap,HanSd,soluong)values('HH008',N'Màn','100000','2014-01-01','2020-02-01',4000)
insert into HangHoa(ID_HangHoa,TenHang,GiaHang,NgayNhap,HanSd,soluong)values('HH009',N'Nho Sấy','200000','2015-01-01','2015-06-02',5000)
insert into HangHoa(ID_HangHoa,TenHang,GiaHang,NgayNhap,HanSd,soluong)values('HH010',N'Dừa Khô','100000','2014-01-01','2015-02-01',2000)


insert into NhanVien(ID_NhanVien,HoTen,Quequan,GT,CMND,NgaySinh,luong)values('NV001',N'Đào Quang Tính',N'Hà Nam',N'Nam','12345678','1993-01-03',10000)
insert into NhanVien(ID_NhanVien,HoTen,Quequan,GT,CMND,NgaySinh,luong)values('NV002',N'Ngô Thành  Trung',N'Thanh Hóa',N'Nam','12435679','1994-02-05',20000)
insert into NhanVien(ID_NhanVien,HoTen,Quequan,GT,CMND,NgaySinh,luong)values('NV003',N'Phan Ngọc Anh',N'Nghệ An',N'Nam','12534686','1991-01-04',40000)
insert into NhanVien(ID_NhanVien,HoTen,Quequan,GT,CMND,NgaySinh,luong)values('NV004',N'Phí Vô Thường',N'Hà Tĩnh',N'Nam','11223389','1990-02-03',50000)
insert into NhanVien(ID_NhanVien,HoTen,Quequan,GT,CMND,NgaySinh,luong)values('NV005',N'Phạm Thị Thúy',N'An Giang',N'Nữ','13456789','1993-01-05',50000)

insert into KhachHang(ID_KhachHang,Ten_KhachHang,SDT_KhachHang,GioiTinh_KhachHang) values('KH001',N'Trần Văn Anh Tuấn','01686976063',N'Nam')
insert into KhachHang(ID_KhachHang,Ten_KhachHang,SDT_KhachHang,GioiTinh_KhachHang) values('KH002',N'Nguyễn Thị Ánh','0123456789',N'Nữ')
insert into KhachHang(ID_KhachHang,Ten_KhachHang,SDT_KhachHang,GioiTinh_KhachHang) values('KH003',N'Trần Văn Hóa','0123456978',N'Nam')
insert into KhachHang(ID_KhachHang,Ten_KhachHang,SDT_KhachHang,GioiTinh_KhachHang) values('KH004','Nguyễn Đình Văn','0985585027',N'Nam')
insert into KhachHang(ID_KhachHang,Ten_KhachHang,SDT_KhachHang,GioiTinh_KhachHang) values('KH005','Lê Thị Thủy','0988234567',N'Nữ')

insert into HoaDon(ID_HoaDon,Ten_HoaDon,ID_KhachHang,ID_HangHoa,ID_NhanVien)values('HD001',N'Hóa Đơn 1','KH001','HH001','NV001')
insert into HoaDon(ID_HoaDon,Ten_HoaDon,ID_KhachHang,ID_HangHoa,ID_NhanVien)values('HD002',N'Hóa Đơn 2','KH002','HH002','NV002')
insert into HoaDon(ID_HoaDon,Ten_HoaDon,ID_KhachHang,ID_HangHoa,ID_NhanVien)values('HD003',N'Hóa Đơn 3','KH003','HH003','NV003')
insert into HoaDon(ID_HoaDon,Ten_HoaDon,ID_KhachHang,ID_HangHoa,ID_NhanVien)values('HD004',N'Hóa Đơn 4','KH004','HH004','NV004')
insert into HoaDon(ID_HoaDon,Ten_HoaDon,ID_KhachHang,ID_HangHoa,ID_NhanVien)values('HD005',N'Hóa Đơn 5','KH005','HH005','NV005')


alter table HoaDon add constraint fk_hanghoa_hoadon foreign key (ID_HangHoa) references HangHoa(ID_HangHoa)
alter table HoaDon add constraint fk_khachhang_hoadon foreign key(ID_KhachHang) references KhachHang(ID_KhachHang)
alter table HoaDon add constraint fk_nhanvien_hoadon foreign key(ID_NhanVien) references NhanVien(ID_NhanVien)

create table tblUser
(
	TaiKhoan varchar(50) not null,
	MatKhau varchar(50) not null
)


insert into tblUser values (N'nguyenanhdung', N'nguyenanhdung')
insert into tblUser values (N'hoangdinhdat', N'hoangdinhdat')
insert into tblUser values (N'phixuandao', N'phixuandao')
insert into tblUser values (N'phamdinhminh', N'phamdinhminh')
insert into tblUser values (N'levanvu', N'levanvu')
insert into tblUser values (N'luongvanluan', N'luongvanluan')

create proc LoadHangHoa
as
begin
	select *from HangHoa
end



create proc Add_HangHoa(@TenHang nvarchar(50), @GiaHang int, @NgayNhap datetime, @HanSd datetime)
as
declare @i char(10)
begin
set @i = (select count(ID_HangHoa) from HangHoa)
if @i <10 begin insert into HangHoa (ID_HangHoa,TenHang,GiaHang,NgayNhap,Hansd) values ('HH00'+ convert(varchar(4),@i+1), @TenHang, @GiaHang, @NgayNhap, @HanSd) end
else if @i <100  begin insert into HangHoa (ID_HangHoa,TenHang,GiaHang,NgayNhap,Hansd) values ('HH0'+ convert(varchar(5),@i+1), @TenHang, @GiaHang, @NgayNhap, @HanSd) end
else if @i <1000 begin insert into HangHoa (ID_HangHoa,TenHang,GiaHang,NgayNhap,Hansd) values ('HH'+ convert(varchar(6),@i+1), @TenHang, @GiaHang, @NgayNhap, @HanSd) end
--else if @i <10000 begin insert into HangHoa values ('HH'+ convert(varchar(8),@i+1), @TenHang, @GiaHang, @NgayNhap, @HanSd) end
--else begin insert into HangHoa values ('HH'+ convert(varchar(6),@i+1), @TenHang, @GiaHang, @NgayNhap, @HanSd) end
end


create proc LoadKhachHang
as
begin
	select *from KhachHang
end

create proc Add_KhachHang(@id char(10), @ten nvarchar(50), @sdt int, @gioitinh nvarchar(100))
as
begin
insert into KhachHang values (@id, @ten, @sdt, @gioitinh)
end

create proc Edit_KhachHang(@ID_KhachHang char(10),@Ten_KhachHang char(20),@SDT_KhachHang int,@GioiTinh_KhachHang char(3))
as
begin
	update KhachHang
	set ID_KhachHang=@ID_KhachHang,Ten_KhachHang=@Ten_KhachHang,SDT_KhachHang=@SDT_KhachHang,GioiTinh_KhachHang=@GioiTinh_KhachHang
	where ID_KhachHang=@ID_KhachHang
end

create proc Delete_NhanVien(@ID_NhanVien char(10))
as
begin
	delete from NhanVien
		where ID_NhanVien=@ID_NhanVien	
end			


create proc Add_NhanVien(@ID_NhanVien char(10),@Hoten nvarchar(50),@QueQuan nvarchar(100),@GT char(3),@CMND int, @NgaySinh datetime)
as
begin
	insert into NhanVien(ID_NhanVien,HoTen,Quequan,GT,CMND,NgaySinh)
	values(@ID_NhanVien,@Hoten,@QueQuan,@GT,@CMND,@NgaySinh)
end

create proc Edit_NhanVien(@ID_NhanVien char(10),@HoTen char(50),@QueQuan nvarchar(100),@GT char(3),@CMND int,@NgaySinh datetime)			
as
begin
	update NhanVien
	set ID_NhanVien=@ID_NhanVien,HoTen=@Hoten,Quequan=@QueQuan,GT=@GT,NgaySinh=@Ngaysinh,CMND=@CMND
	where ID_NhanVien=@ID_NhanVien
end

create proc timkienhanghoa(@tim nvarchar(max))
as
begin
	select *from HangHoa
	where TenHang like '%' + @tim + '%' or ID_HangHoa like '%' + @tim + '%'
end

create proc timkiemnhanvien(@tim nvarchar(max))
as
begin
	select *from NhanVien
	where HoTen like '%'+@tim+ '%' or ID_NhanVien like '%' +@tim+ '%'
end
create proc LoadNhanVien
as 
begin
select * from NhanVien
end

create  proc Edit_HangHoa(@ID_HangHoa char(10), @TenHang nvarchar(50),@GiaHang int, @NgayNhap datetime, @HanSd datetime)
as  
begin
update HangHoa
set TenHang= @TenHang, GiaHang= @GiaHang, NgayNhap=@NgayNhap,HanSd=@HanSd
where ID_HangHoa= @ID_HangHoa
end
create proc Delete_HangHoa(@ID_HangHoa char(10))
as 
begin
 delete from HangHoa where ID_HangHoa=@ID_HangHoa
 end
 
 create proc DelDG(@madg varchar(10))
as
begin
delete from tblDocGia where MaDG = @madg
end

create proc Delete_KhachHang(@ID_KhachHang char(10))
as
begin
delete from KhachHang
where ID_KhachHang= @ID_KhachHang
end

create proc Delete_HoaDon(@ID_HoaDon char(10))
as
begin
delete from HoaDon
where ID_HoaDon= @ID_HoaDon
end

create proc Add_HoaDon(@id char(10), @ten nvarchar(30), @idkh char(10), @idhh char(10), @idnv char(10))
as
begin
insert into HoaDon values (@id, @ten, @idkh, @idhh, @idnv)
end

create  proc Edit_HoaDon(@ID_HoaDon char(10),@Ten_HoaDon nvarchar(30),@ID_HangHoa char(10),@ID_NhanVien char(10),@ID_KhachHang char(10))
as
begin
update HoaDon
set ID_HoaDon=@ID_HoaDon,Ten_HoaDon=@Ten_HoaDon,ID_HangHoa=@ID_HangHoa,ID_NhanVien=@ID_NhanVien,ID_KhachHang=@ID_KhachHang
where ID_HoaDon=@ID_HoaDon
end

create proc LoadHoaDon
as
begin
select* from HoaDon
end

create proc timkiemkhachhang(@tim nvarchar(max))
as
begin
	select *from KhachHang
	where Ten_KhachHang like '%'+@tim+ '%' or ID_KhachHang like '%' +@tim+ '%'
end

create proc timkiemhoadon(@tim nvarchar(max))
as
begin
select * from HoaDon
where ID_HoaDon like '%'+ @tim+ '%' or Ten_HoaDon like '%'+@tim+'%'
end

alter table HangHoa drop column NgayNhap
alter table HangHoa drop column HanSd

ALTER table PhieuXuat
(
	MaPhieu varchar(10) primary key,
	ID_HangHoa char(10) constraint FK_PX_HH foreign key references HangHoa(ID_HangHoa),
	SoLuong int,
	NgayBan datetime
)

ALTER table PhieuNhap
(
	MaPhieu varchar(10) primary key,
	ID_HangHoa char(10) constraint FK_PN_HH foreign key references HangHoa(ID_HangHoa),
	SoLuong int,
	GiaBan int,
	NgayNhap datetime
)

create proc BanHang (@tenhang nvarchar(50), @soluong int, @ngayban datetime)
as
declare @i int, @id char(10)
begin
set @i = (select count(MaPhieu) from PhieuXuat)
set @id = (select ID_HangHoa from HangHoa where TenHang = @tenhang)
update HangHoa set SoLuong = SoLuong - @soluong where TenHang = @tenhang
insert into PhieuXuat values (convert(varchar(10),@i+1),@id, @soluong, @ngayban)
end



create proc NhapHang (@tenhang nvarchar(50), @soluong int, @giaban int, @ngaynhap datetime)
as
declare @i int, @id int, @id1 char(10), @id2 char(10)
begin
set @i = (select count(MaPhieu) from PhieuNhap)
set @id = (select count(ID_HangHoa) from HangHoa where TenHang = @tenhang)
set @id1 = (select count(ID_HangHoa) from HangHoa)
set @id2 = (select Id_HangHoa from HangHoa where TenHang = @tenhang)
if (@id  = 0)
begin
insert into HangHoa values('HH' + convert(varchar(10), @id1+1), @tenhang, @giaban, @soluong)
insert into PhieuNhap values(convert(varchar(10), + @i+1),'HH' + convert(varchar(10), @id1+1), @soluong, @giaban, @ngaynhap)
end
else
begin
update HangHoa set SoLuong = SoLuong + @soluong, GiaHang = @giaban where TenHang = @tenhang
insert into PhieuNhap values(convert(varchar(10), + @i+1), @id2, @soluong, @giaban, @ngaynhap)
end
end

create proc LuuLuong(@ngaybatdau datetime, @ngayketthuc datetime)
as
begin
select  c.TenHang, Isnull(sum(b.soluong),0) as Nhap, isnull(sum(a.soluong),0) as Xuat, c.SoLuong as ConLai from HangHoa c left join PhieuNhap b on b.id_hanghoa = c.id_hanghoa left join PhieuXuat a on a.id_hanghoa=c.id_hanghoa
where (b.ngaynhap between @ngaybatdau and @ngayketthuc) or (a.ngayban between @ngaybatdau and @ngayketthuc)
group by c.TenHang, c.SoLuong
end
