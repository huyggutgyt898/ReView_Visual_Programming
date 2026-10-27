create database DanhSachSV_db;
go

use DanhSachSV_db;
go

create table SinhVien (
	MaSV int Identity(1,1) primary key,
	HoTen nvarchar(100) not null,
	Email nvarchar(100) unique,
	NgaySinh datetime,
	NgayTao datetime default getdate()
);