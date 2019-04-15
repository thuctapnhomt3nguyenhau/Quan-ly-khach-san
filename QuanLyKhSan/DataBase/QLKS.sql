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
  ALTER TABLE dbo.THUEPHONG ADD CONSTRAINT FK_MAKH_TH_KH FOREIGN KEY(MAKH) REFERENCES dbo.KHACHHANG(MAKH)
 ALTER TABLE dbo.THUEPHONG ADD CONSTRAINT FK_MATH_TH_PH FOREIGN KEY(MAPH) REFERENCES dbo.PHONG(MAPH)
  ALTER TABLE dbo.SUDUNGDV ADD CONSTRAINT FK_MATH_SD_TH FOREIGN KEY(MATH) REFERENCES dbo.THUEPHONG(MATH)
 ALTER TABLE dbo.SUDUNGDV ADD CONSTRAINT FK_MADV_SD_DV FOREIGN KEY(MADV) REFERENCES dbo.DICHVU(MADV)
 ALTER TABLE dbo.PHONG ADD CONSTRAINT FK_MAPH_PH_LP FOREIGN KEY(MAL) REFERENCES dbo.LOAIPH(MAL)
 ALTER TABLE dbo.HOADON ADD CONSTRAINT FK_MATH FOREIGN KEY (MATH) REFERENCES dbo.THUEPHONG (MATH)
 ALTER TABLE dbo.HOADON ADD CONSTRAINT FK_MANV FOREIGN KEY (MATH) REFERENCES dbo.NHANVIEN (MANV)
 GO

 -----------------BẢNG NHÂN VIÊN-------------

-----INSERT-----------
CREATE PROC USP_NHANVIEN_Insert
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


 [dbo].[USP_NHANVIEN_Insert] N'Vũ Thị Hường','1997-05-08',N'Nam Định',N'Nữ','0394249888','15000000'
select *from[dbo].[NHANVIEN]
----------UPDATE-----------
CREATE PROC USP_NHANVIEN_Update
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
CREATE PROC USP_NHANVIEN_Delete
     @manv INT
AS
BEGIN
	DELETE dbo.NHANVIEN WHERE MANV=@manv
END
GO
---------SEARCH--------
CREATE PROC USP_NHANVIEN_Search
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
ALTER PROC USP_NHANVIEN_Getall
AS
BEGIN
	SELECT  NV.MANV , HOTEN , NGAYSINH , GIOITINH , DIACHI , SDT, LUONG 
	FROM  NHANVIEN AS NV
END
GO
EXEC [dbo].[USP_NHANVIEN_Getall]

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
go



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
exec [dbo].[USP_InsertThuePhong] '1','3','20180327','20180328','50000'
INSERT into dbo.THUEPHONG
	        ( MAKH ,
	          MAPH ,
	          NGAYBDTHUE ,
	          NGAYTRA ,
	          DATCOC
	        )
	VALUES  ( '1' , -- MAKH - int
	          '3' , -- MAPH - int
	          '20180327' , -- NGAYBDTHUE - date
	          '20180328' , -- NGAYTRA - date
	          '50000'  -- DATCOC - int
	        )

select *from[dbo].[KHACHHANG]
select *from [dbo].[PHONG]
select *from [dbo].[THUEPHONG]
insert into 
-----
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
	INSERT dbo.KHACHHANG
		        ( TENKH, DIACHI, SDT )
		VALUES  ( N'Nguyễn Đức Hậu', -- TENKH - nvarchar(100)
		          N'Hà Nội', -- DIACHI - nvarchar(100)
		          '0123456789' -- SDT - char(10)
		          )
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
	delete SUDUNGDV
	where MADV = @maDichVu
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
SELECT *FROM[dbo].[DICHVU]
GO
-----------------------------------SỬ DỤNG DỊCH VỤ -------------------------
-----GETALL-----
CREATE PROC USP_SUDUNGDV_GetDS
AS
SELECT MASD,MATH,DV.MADV,NGAYSD,DATCOC
FROM [dbo].[SUDUNGDV] , [dbo].[DICHVU] DV
WHERE [dbo].[SUDUNGDV].MADV = DV.MADV
GO

EXEC [dbo].[USP_SUDUNGDV_GetDS]
GO

------ INSERT----
CREATE PROC USP_SUDUNGDV_Insert
    @MATH INT,
	@MADV INT,
	@NGAYSD DATE,
    @DATCOC INT
AS
BEGIN 
    INSERT [dbo].[SUDUNGDV]
           ( MATH,
	         MADV,
		     NGAYSD,
		     DATCOC  )
    VALUES ( @MATH,
             @MADV,
		     @NGAYSD,
		     @DATCOC
                      )
END
GO
INSERT [dbo].[SUDUNGDV]
       ( MATH,
	     MADV,
		 NGAYSD,
		 DATCOC
		 )
VALUES ('1',
        '1',
		'20180327',
		'200000'
         )
GO
----------UPDATE------------
CREATE PROC USP_SUDUNGDV_Update
    @MASD INT,
	@MATH INT,
	@MADV INT,
	@NGAYSD DATE,
    @DATCOC INT
AS
BEGIN
  UPDATE [dbo].[SUDUNGDV]
  SET MATH = @MATH ,MADV = @MADV ,NGAYSD = @NGAYSD , DATCOC =@DATCOC
  WHERE MASD = @MASD
END
GO
-------DELETE----------------
CREATE PROC USP_SUDUNGDV_Delete
     (@masd INT)
AS 
BEGIN
   DELETE FROM [dbo].[SUDUNGDV]
   WHERE MASD = @masd
END
GO
-------SERACH--------------------
CREATE PROC USP_SUDUNGDV_Search
	@search NVARCHAR(100)
AS
BEGIN
	SELECT MASD ,MATH,DV.MADV ,NGAYSD,DATCOC FROM [dbo].[SUDUNGDV] SD,[dbo].[DICHVU] DV
	WHERE (SD.MADV = DV.MADV ) 
	    AND  ((MASD LIKE N'%' + @search + '%')
	    OR (MATH LIKE  N'%' + @search + '%' )
	    OR (DV.MADV LIKE  N'%' + @search + '%')
	    OR (NGAYSD LIKE  N'%' + @search + '%')
		OR (DATCOC LIKE  N'%' + @search + '%'))
END
GO

------------------------------------HÓA ĐƠN -------------------------------
-----GETALL---
CREATE PROC USP_HOADON_GETALL
AS
SELECT *FROM [dbo].[HOADON]
GO

EXEC [dbo].[USP_HOADON_GETALL]
GO
-----INSSERT----
CREATE PROC USP_HOADON_INSERT
       @MATH INT,
	   @MANV INT,
       @NGAYTT DATE,
	   @THANHTIEN INT,
	   @GHICHU NVARCHAR(50)
AS
BEGIN
  INSERT [dbo].[HOADON]
         (MATH,
          MANV,
          NGAYTT,
          THANHTIEN,
          GHICHU
		     )
   VALUES (@MATH,
           @MANV,
		   @NGAYTT,
		   @THANHTIEN,
		   @GHICHU
               )
END
GO

------UPDATE------------
CREATE PROC USP_HOADON_UPDATE
     @MAHD  INT,
	 @MATH INT,
	 @MANV  INT,
	 @NGAYTT DATE,
	 @THANHTIEN INT,
	 @GHICHU NVARCHAR(50)
AS
BEGIN
    UPDATE [dbo].[HOADON]
	SET MATH = @MATH , MANV = @MANV ,NGAYTT = @NGAYTT , THANHTIEN = @THANHTIEN , GHICHU = @GHICHU
	WHERE MAHD = @MAHD
END
GO
-----DELETE------------
CREATE PROC USP_HOADON_DELETE
     @mahd int
AS
BEGIN
   DELETE FROM [dbo].[HOADON]
   WHERE MAHD = @mahd
END
GO
-------SREACH--------------------
CREATE PROC USP_HOADON_SREACH
	@search NVARCHAR(100)
AS
BEGIN
	SELECT MAHD,MATH,HD.MANV ,NGAYTT,THANHTIEN,GHICHU FROM [dbo].[HOADON] HD,[dbo].[NHANVIEN] NV
	WHERE (HD.MANV = NV.MANV ) 
	    AND  ((MAHD LIKE N'%' + @search + '%')
	    OR (MATH LIKE  N'%' + @search + '%' )
	    OR (HD.MANV LIKE  N'%' + @search + '%')
	    OR (NGAYTT LIKE  N'%' + @search + '%')
		OR (THANHTIEN LIKE  N'%' + @search + '%')
		OR (GHICHU LIKE  N'%' + @search + '%'))
END
GO

INSERT [dbo].[PHONG] (  TENPH , MAL ,GIATHUE )
VALUES ( N'AA','1','1000')

select *from [dbo].[PHONG]
select *from [dbo].[KHACHHANG]
select *from[dbo].[THUEPHONG]
select *from [dbo].[NHANVIEN]

