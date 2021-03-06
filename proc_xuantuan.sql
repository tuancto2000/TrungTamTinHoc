--========================================giao vien================================================

create or alter procedure UpdateDKKT   @idMonHoc varchar(10 ) , @idHocVien varchar(10) , @diem float
as
	update DKMH_KT set Diem_mon_hoc = @diem , so_lan_thi_lai += 1
			where Id_hv = @idHocVien and Id_mh = @idMonHoc and So_lan_thi_lai < 3;
go


go
create or alter procedure [UpdateDKCC]   @idMonHoc varchar(10 ) , @idHocVien varchar(10) , @diem float
as
	update DKMH_CC set Diem_mon_hoc = @diem
			where Id_hv = @idHocVien and Id_mh = @idMonHoc;

--========================================ke toan =================================================
go
create or alter procedure UpdateHocPhiCC  @idKeToan varchar(10),  @idHocVien varchar(10) 
as
	update DKMH_CC set ID_nv = @idKeToan
			where Id_hv = @idHocVien and ID_nv is null;
go
create or alter procedure UpdateHocPhiKT  @idKeToan varchar(10),  @idHocVien varchar(10) 
as
	update DKMH_KT set ID_nv = @idKeToan
			where Id_hv = @idHocVien and ID_nv is null;
go
create or alter procedure UpdateHocPhiCD    @idKeToan varchar(10),  @idHocVien varchar(10) 
as
	update DKCD set ID_nv = @idKeToan
			where Id_hv = @idHocVien and ID_nv is null;