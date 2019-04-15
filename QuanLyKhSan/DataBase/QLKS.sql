CREATE DATABASE TT_QLKSan
GO
USE TT_QLKSan
GO
 ---------------------------TẠO BẢNG----------------------------
CREATE TABLE PHONG(
   MAPH INT IDENTITY(1,1) NOT NULL,
   TENPH NVARCHAR (50),
   MAL INT,
   GIATHUE INT
)
GO
CREATE TABLE LOAIPH(
    MAL INT IDENTITY(1,1) NOT NULL,
	TENLOAI NVARCHAR (50),
	GHICHU NVARCHAR(50)
)
GO
CREATE TABLE NHANVIEN(
    MANV INT IDENTITY(1,1) NOT NULL ,
	HOTEN NVARCHAR(100),
	NGAYSINH DATE ,
	GIOITINH NVARCHAR (50),
	DIACHI NVARCHAR(100),
	SDT CHAR(10) ,
	LUONG INT
	)
GO
CREATE TABLE KHACHHANG(
    MAKH INT IDENTITY(1,1) NOT NULL, 
	TENKH NVARCHAR(100),
	DIACHI NVARCHAR (100),
	SDT CHAR(10) 
	)
GO
CREATE TABLE DICHVU(
   MADV INT IDENTITY(1,1) NOT NULL ,
   TENDV NVARCHAR(100),
   GIATIEN INT
   )
GO
CREATE TABLE THUEPHONG(
  MATH INT IDENTITY(1,1) NOT NULL  ,
  MAKH INT ,
  MAPH INT ,
  NGAYBDTHUE DATE,
  NGAYTRA DATE,
  DATCOC INT 
  )
GO
CREATE TABLE SUDUNGDV(
  MASD INT IDENTITY(1,1) NOT NULL,
  MATH INT ,
  MADV INT ,
  NGAYSD DATE,
  DATCOC INT 
  )
GO
CREATE TABLE HOADON(
 MAHD INT IDENTITY(1,1) NOT NULL ,
 MATH INT,
 MANV INT,
 NGAYTT DATE ,
 THANHTIEN INT ,
 GHICHU NVARCHAR(50)
 )
 GO
 ----------------KHÁO CHÍNH------------
 ALTER TABLE dbo.PHONG ADD CONSTRAINT PK_MAPH PRIMARY KEY(MAPH)
 ALTER TABLE dbo.LOAIPH ADD CONSTRAINT PK_MAL PRIMARY KEY(MAL)
 ALTER TABLE dbo.NHANVIEN ADD CONSTRAINT PK_MANV PRIMARY KEY(MANV)
 ALTER TABLE dbo.DICHVU ADD CONSTRAINT PK_MADV PRIMARY KEY(MADV)
 ALTER TABLE dbo.KHACHHANG ADD CONSTRAINT PK_MAKH PRIMARY KEY(MAKH)
 ALTER TABLE dbo.THUEPHONG ADD CONSTRAINT PK_MATH PRIMARY KEY(MATH)
 ALTER TABLE dbo.SUDUNGDV ADD CONSTRAINT PK_MASD PRIMARY KEY(MASD)
 ALTER TABLE dbo.HOADON ADD CONSTRAINT PK_MAHD PRIMARY KEY(MAHD)
 ----KHÓA NGOẠI--------
 ALTER TABLE dbo.PHONG ADD CONSTRAINT FK_MAPH_PH_LP FOREIGN KEY(MAL) REFERENCES dbo.LOAIPH(MAL)
 ALTER TABLE dbo.THUEPHONG ADD CONSTRAINT FK_MATH_KH FOREIGN KEY(MAKH) REFERENCES dbo.KHACHHANG(MAKH)
 ALTER TABLE dbo.THUEPHONG ADD CONSTRAINT FK_MATH_PH FOREIGN KEY(MATH) REFERENCES dbo.PHONG(MAPH)
 ALTER TABLE dbo.SUDUNGDV ADD CONSTRAINT FK_MASD_TH FOREIGN KEY(MASD) REFERENCES dbo.THUEPHONG(MATH)
 ALTER TABLE dbo.SUDUNGDV ADD CONSTRAINT FK_MASD_DV FOREIGN KEY(MADV) REFERENCES dbo.DICHVU(MADV)
 ALTER TABLE dbo.HOADON ADD CONSTRAINT FK_MATH FOREIGN KEY (MATH) REFERENCES dbo.THUEPHONG (MATH)
 ALTER TABLE dbo.HOADON ADD CONSTRAINT FK_MANV FOREIGN KEY (MATH) REFERENCES dbo.NHANVIEN (MANV)
 GO

 -----------------BẢNG NHÂN VIÊN-------------
CREATE PROC USP_GetDSNV AS SELECT NHANVIEN.MANV,HOTEN,NGAYSINH,GIOITINH,DIACHI,SDT,LUONG FROM dbo.NHANVIEN
EXEC USP_GetDSNV
GO

-----INSERT-----------
CREATE PROC USP_InsertNV
	@hoten NVARCHAR(100),
	@ngsinh DATE,
	@gioitinh NVARCHAR(50),
	@diachi NVARCHAR(100),
	@sdt CHAR(10),
	@luong INT
	
AS
BEGIN
	INSERT dbo.NHANVIEN
	        ( HOTEN ,
	          NGAYSINH ,
	          GIOITINH ,
			  DIACHI ,
	          SDT ,
	          LUONG 
	        )
	VALUES  ( @hoten , 
	          @ngsinh , 
	          @diachi , 
	          @gioitinh , 
	          @sdt , 
	          @luong  	          
	        )
END
GO


[dbo].[USP_InsertNV]  N'Vũ Thị Hường','1997-05-08',N'Nam Định',N'Nữ','0394249888','15000000'

----------UPDATE-----------
CREATE PROC USP_UpdateNV
	@manv INT,
	@hoten NVARCHAR(100),
	@ngsinh DATE,
	@gioitinh NVARCHAR(50),
	@diachi NVARCHAR(100),
	@sdt CHAR(10),
	@luong INT
AS
BEGIN
	UPDATE dbo.NHANVIEN 
	SET HOTEN=@hoten,NGAYSINH=@ngsinh,GIOITINH=@gioitinh,DIACHI=@diachi,SDT=@sdt,LUONG=@luong 
	WHERE MANV=@manv
END
GO

----------DELETE----------
CREATE PROC USP_DeleteNV
     @manv INT
AS
BEGIN
	DELETE dbo.NHANVIEN WHERE MANV=@manv
END
GO
---------SEARCH--------
CREATE PROC USP_SearchNV
    @search NVARCHAR(100)
AS
BEGIN
	SELECT NHANVIEN.MANV,HOTEN,NGAYSINH,GIOITINH,DIACHI,SDT,LUONG FROM dbo.NHANVIEN, dbo.HOADON 
	WHERE (NHANVIEN.MANV = HOADON.MANV) 
	    AND  ((HOADON.MANV LIKE N'%' + @search + '%')
	    OR (HOTEN LIKE  N'%' + @search + '%' )
	    OR (NGAYSINH LIKE  N'%' + @search + '%')
	    OR (GIOITINH LIKE  N'%' + @search + '%')
		OR (DIACHI LIKE  N'%' + @search + '%') 
	    OR (SDT LIKE  N'%' + @search + '%') 
	    OR (LUONG LIKE  N'%' + @search + '%'))
END 
GO

---------GETALL-----------
CREATE PROC USP_GetallNV
AS
BEGIN
	SELECT HD.MAHD, NV.MANV , NGAYTT
	FROM HOADON AS HD, NHANVIEN AS NV
END
GO
EXEC [dbo].[USP_GetallNV]

select *from[dbo].[NHANVIEN]
GO

-------------------------------------------------- Loại phòng -----------------------------------------------------------
---------------------- TẠO PROC GETALL --------------
CREATE PROC SP_LOAIPHONG_GETALL
AS
	BEGIN
	SELECT MAL, TENLOAI, GHICHU
	FROM dbo.LOAIPH
	END
GO

-- tạo proc insert
CREATE PROC SP_LOAIPHONG_INSERT @TENLOAI NVARCHAR(50), @GHICHU NVARCHAR(50)
AS
	BEGIN
		INSERT INTO dbo.LOAIPH
		        ( TENLOAI, GHICHU )
		VALUES  ( @TENLOAI, -- TENLOAI - nvarchar(50)
		          @GHICHU  -- GHICHU - nvarchar(50)
		          )
	END
GO

--TẠO PROC UPDATE
CREATE PROC SP_LOAIPHONG_UPDATE @MAL INT, @TENLOAI NVARCHAR(50), @GHICHU NVARCHAR(50)
AS
	BEGIN
		UPDATE dbo.LOAIPH
		SET TENLOAI=@TENLOAI, GHICHU=@GHICHU
		WHERE MAL = @MAL
	END
GO

--TẠO PROC DETLETE
CREATE PROC SP_LOAIPHONG_DELETE @MAL INT
AS
	BEGIN
	DELETE FROM dbo.LOAIPH
	WHERE MAL = @MAL
	END
GO

--TẠO PROC TÌM KIẾM
CREATE PROC SP_LOAIPHONG_TIMKIEM @SEARCHVALUE NVARCHAR(100)
AS
	BEGIN
		SELECT MAL, TENLOAI, GHICHU
		FROM dbo.LOAIPH
		WHERE (dbo.LOAIPH.MAL LIKE N'%' + @SEARCHVALUE +'%')
		OR (dbo.LOAIPH.TENLOAI LIKE N'%' + @SEARCHVALUE + '%')
		OR (dbo.LOAIPH.GHICHU LIKE N'%' + @SEARCHVALUE + '%')
	END
GO


		


---------------------------------------------THUEPHONG
CREATE PROC USP_GetDSThuePhong AS
SELECT MATH,KHACHHANG.MAKH,TENKH,MAPH,NGAYBDTHUE,NGAYTRA,DATCOC FROM dbo.THUEPHONG LEFT JOIN dbo.KHACHHANG ON KHACHHANG.MAKH = THUEPHONG.MAKH
GO
EXEC dbo.USP_GetDSThuePhong

INSERT dbo.THUEPHONG
        ( MAKH ,
          MAPH ,
          NGAYBDTHUE ,
          NGAYTRA ,
          DATCOC
        )
VALUES  ( 1 , -- MAKH - int
          1 , -- MAPH - int
          GETDATE() , -- NGAYBDTHUE - date
          GETDATE() , -- NGAYTRA - date
          1  -- DATCOC - int
        )
		INSERT dbo.PHONG
		        ( TENPH, MAL, GIATHUE )
		VALUES  ( N'a', -- TENPH - nvarchar(50)
		          1, -- MAL - int
		          0  -- GIATHUE - int
		          )

GO

CREATE PROC USP_InsertThuePhong
  @makh INT ,
  @maph INT ,
  @ngaybdthue DATE,
  @ngaytra DATE,
  @datcoc INT
AS
BEGIN
	INSERT dbo.THUEPHONG
	        ( MAKH ,
	          MAPH ,
	          NGAYBDTHUE ,
	          NGAYTRA ,
	          DATCOC
	        )
	VALUES  ( @MAKH , -- MAKH - int
	          @MAPH , -- MAPH - int
	          @NGAYBDTHUE , -- NGAYBDTHUE - date
	          @NGAYTRA , -- NGAYTRA - date
	          @DATCOC  -- DATCOC - int
	        )
END
GO
CREATE PROC USP_UpdateThuePhong
  @math INT,
  @makh INT ,
  @maph INT ,
  @ngaybdthue DATE,
  @ngaytra DATE,
  @datcoc INT
AS
BEGIN
	UPDATE dbo.THUEPHONG SET MAKH=@makh , MAPH=@maph , NGAYBDTHUE=@ngaybdthue , NGAYTRA=@ngaytra , DATCOC = @datcoc
	WHERE MATH=@math
END
GO
CREATE PROC USP_DeleteThuePhong
	@math int
AS
BEGIN
	DELETE FROM dbo.THUEPHONG WHERE MATH=@math
END
GO
CREATE PROC USP_SearchThuePhong
@search NVARCHAR(100)
AS
BEGIN
	SELECT MATH,KHACHHANG.MAKH,TENKH,MAPH,NGAYBDTHUE,NGAYTRA,DATCOC FROM dbo.THUEPHONG, dbo.KHACHHANG 
	WHERE KHACHHANG.MAKH = THUEPHONG.MAKH
	AND KHACHHANG.MAKH LIKE N'%' + @search + '%' OR TENKH LIKE N'%' + @search + '%' OR MATH LIKE N'%' + @search + '%' OR 
	MAPH LIKE N'%' + @search + '%' OR NGAYBDTHUE LIKE N'%' + @search + '%' OR NGAYTRA LIKE N'%' + @search + '%' OR DATCOC LIKE N'%' + @search + '%'
END

------------------------------------------Khách hàng
GO
CREATE PROC USP_GetListKhachHang
AS SELECT * FROM dbo.KHACHHANG
GO
CREATE PROC USP_InsertKhachHang
	@tenkh NVARCHAR(100),
	@diachi NVARCHAR (100),
	@sdt CHAR(10)
	AS
	BEGIN
		INSERT dbo.KHACHHANG
		        ( TENKH, DIACHI, SDT )
		VALUES  ( @tenkh, -- TENKH - nvarchar(100)
		          @diachi, -- DIACHI - nvarchar(100)
		          @sdt  -- SDT - char(10)
		          )
	END
	GO
CREATE PROC USP_UpdateKhachHang
	@makh INT,
	@tenkh NVARCHAR(100),
	@diachi NVARCHAR (100),
	@sdt CHAR(10)
AS
BEGIN
	UPDATE dbo.KHACHHANG SET TENKH=@tenkh , DIACHI = @diachi , SDT = @sdt WHERE MAKH=@makh
END
GO
CREATE PROC USP_DeleteKhachHang
	@makh INT
AS
BEGIN
	UPDATE dbo.THUEPHONG SET MAKH = NULL
	DELETE FROM dbo.KHACHHANG WHERE MAKH=@makh
END
GO
CREATE PROC USP_SearchKhachHang
@search NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.KHACHHANG WHERE
	MAKH LIKE N'%' + @search + '%' OR TENKH LIKE N'%' + @search + '%' OR SDT LIKE N'%' + @search + '%' OR 
	DIACHI LIKE N'%' + @search + '%'
END

go
----------------------------------------Bảng dịch vụ------------------------------
-- Lấy ra danh sách
create procedure SP_DichVu_GetAll
as
begin
	select * from DICHVU
end
go

-- Thêm một dịch vụ
create procedure SP_DichVu_Insert
	@tenDichVu nvarchar(100),
	@giaTien int
as
begin
	insert into DICHVU(TENDV, GIATIEN)
	values(@tenDichVu, @giaTien)
end
go

-- Xóa một dịch vụ
create procedure SP_DichVu_Delete
	@maDichVu int
as
begin
	delete DICHVU
	where MADV = @maDichVu
end
go

-- Sửa một dịch vụ
create procedure SP_DichVu_Update
	@maDichVu int, @tenDichVu nvarchar(50), @giaDichVu int
as
begin
	update DICHVU
	set TENDV = @tenDichVu, GIATIEN = @giaDichVu
	where MADV = @maDichVu
end
go

-- Tìm kiếm dịch vụ
create procedure SP_DichVu_Search
	@searchValue nvarchar(50)
as
begin
	select * from DICHVU
	where (MADV like N'%'+ @searchValue +'%')
		  or (TENDV like N'%'+ @searchValue +'%')
		  or (GIATIEN like N'%'+ @searchValue +'%')
end
go
----PHONG----
CREATE PROC SP_GetDSP AS SELECT MAPH,TENPH,MAL,GIATHUE FROM PHONG
EXEC SP_GetDSP
GO

-- TẠO THỦ TỤC THÊM:
CREATE PROC SP_InsertP @TENPH NVARCHAR(50), @MAL INT,@GIATHUE INT
AS
	BEGIN
		INSERT INTO PHONG
		        ( TENPH,MAL,GIATHUE)
		VALUES  ( @TENPH ,@MAL ,@GIATHUE )
	END
GO

--TẠO PROC UPDATE
CREATE PROC SP_UpdateP @MAPH INT, @TENPH NVARCHAR(50), @MAL INT,@GIATHUE INT
AS
	BEGIN
		UPDATE PHONG
		SET TENPH=@TENPH ,MAL=@MAL ,GIATHUE=@GIATHUE
		WHERE MAPH=@MAPH
	END
GO

--TẠO PROC DETLETE
CREATE PROC SP_DeleteP @MAPH INT
AS
	BEGIN
	DELETE FROM PHONG
	WHERE MAPH = @MAPH
	END
GO

--TẠO PROC TÌM KIẾM
Create PROC SP_SearchP @SEARCHVALUE NVARCHAR(100)
AS
	BEGIN
		SELECT MAPH,TENPH,MAL,GIATHUE
		FROM PHONG
		WHERE (PHONG.MAPH LIKE N'%' + @SEARCHVALUE +'%')
		OR (PHONG.TENPH LIKE N'%' + @SEARCHVALUE + '%')
		OR (PHONG.MAL LIKE N'%' + @SEARCHVALUE + '%')
		OR (PHONG.GIATHUE LIKE N'%' + @SEARCHVALUE + '%')
	END
GO