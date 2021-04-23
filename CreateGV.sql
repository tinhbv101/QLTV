create table GiaoVien
(
	MaGV varchar(10) constraint pk_GiaoVien primary key,
	TenGV nvarchar(30),
	GioiTinhGV nvarchar(5),
	NgaySinhGV varchar(10),
	SDTGV int,
	DiaChiGV nvarchar(50),
	LoaiGV nvarchar(20),
	GhiChu nvarchar(30),
	TenTaiKhoanGV varchar(10),
	MatKhauGV varchar(20),
)
insert into GiaoVien values ('GV001',N'Vũ Đình Cần',N'Nam','15/06/1995','0974633324',N'115 Lê Đức Thọ, Gò Vấp',N'Giáo viên','...','GV001','123')
insert into GiaoVien values ('GV002',N'Huỳnh Thanh Hải',N'Nam','14/04/1996','045693224',N'115 Nguyễn Oanh, Gò Vấp',N'Giáo viên','...','GV002','123')
insert into GiaoVien values ('GV003',N'Thiều Sỹ Tùng',N'Nam','15/01/1995','0978633224',N'115 Lê Văn Thọ, Gò Vấp',N'Giáo viên','...','GV003','123')
insert into GiaoVien values ('GV004',N'Trần Nam',N'Nam','11/03/1994','0974551224',N'115 Hồ Thị Hương, Tân Bình',N'Giáo viên','...','GV004','123')
insert into GiaoVien values ('GV005',N'Nguyễn Trãi',N'Nam','23/10/1995','0974688824',N'119 Lê Đức Thọ, Gò Vấp',N'Giáo viên','...','GV005','123')
insert into GiaoVien values ('GV006',N'Nguyễn Xuân Phúc',N'Nam','15/10/1995','0974693111',N'113 Lê Duẩn, Q1',N'Giáo viên','...','GV006','123')
insert into GiaoVien values ('GV007',N'Phạm Nguyễn Gia Hân',N'Nữ','20/11/1993','033393224',N'784 Nguyễn Kiệm, Gò Vấp',N'Giáo viên','...','GV007','123')
insert into GiaoVien values ('GV008',N'Lê Chí Trung',N'Nam','08/03/1995','0974697754',N'988 Quang Trung, Gò Vấp',N'Giáo viên','...','GV008','123')
insert into GiaoVien values ('GV009',N'Lê Nguyễn Hồng Ngọc',N'Nữ','20/11/1995','0974694444',N'115 QL1, Q12',N'Giáo viên','...','GV009','123')
insert into GiaoVien values ('GV010',N'Nguyễn Vũ Hoàng',N'Nam','15/01/1990','0865693224',N'111 Hà Huy Giáp, Q12',N'Giáo viên','...','GV010','123')