Create database QL_he_thong_kho_hang ;
use QL_he_thong_kho_hang;
go
Create Table tbl_kho_hang (
	 kh_id varchar(10)  primary key ,
	 kh_dia_chi nvarchar(70) not null ,
	 kh_quan_ly nvarchar(30) not null ,
	 kh_suc_chua int not null 
)
Create Table tbl_hang_hoa(
	hh_id varchar(10) primary key ,
	hh_ten nvarchar(100) ,
	hh_noi_san_xuat nvarchar(100) , 
	hh_thong_tin nvarchar(500) ,
	kh_id varchar(10) references tbl_kho_hang(kh_id)  
)
Create Table tbl_hoa_don(
	hd_id varchar(10) primary key ,
	kh_id varchar(10) references tbl_kho_hang(kh_id),
    hd_loai nvarchar(20) ,
	hd_ngay_lap datetime ,
	hd_nv nvarchar ,
)
Create Table tbl_chi_tiet(
	cthd_id varchar(10) primary key ,
	hd_id varchar(10) references tbl_hoa_don(hd_id) not null,
	hh_id varchar(10) references tbl_hang_hoa(hh_id) not null,
	cthd_so_luong int  not null ,
)
Alter table tbl_hang_hoa add hh_so_luong int ;
go