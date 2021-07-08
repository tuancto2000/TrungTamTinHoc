create or alter proc sp_check_exists_ld @mamh varchar(10),
										@magv varchar(10)
as
begin
	declare @lich_hoc nvarchar(10)
	select @lich_hoc = Lich_hoc from mon_hoc where Id_mh = @mamh

	select Id_mh from (select top 1 Id_mh
						from Mon_hoc
						where ID_nv = @magv and Lich_hoc = @lich_hoc) monhoc
end
go

-------------------------------------------------------------------------------------------
create or alter proc sp_select_hvtn
as
begin
	select hv.Id_hv, hv.Id_lop, hv.Ten_hv
	from Hoc_vien_tot_nghiep hvtn join Hoc_vien hv on hvtn.Id_hv = hv.Id_hv
	where Diem_trung_binh is null
end
go

-------------------------------------------------------------------------------------------
create or alter proc sp_nhap_diem_tot_nghiep @mahv varchar(10),
											@diem float
as
begin
	declare @xeploai varchar(10)
	if @diem >= 9
		set @xeploai = N'Xuất sắc'
	else if @diem >= 8
		set @xeploai = N'Giỏi'
	else if @diem >= 6.5
		set @xeploai = N'Khá'
	else
		set @xeploai = N'Trung bình'

	update Hoc_vien_tot_nghiep
	set Diem_trung_binh = @diem, Loai_tot_nghiep = @xeploai
	where Id_hv = @mahv
end
go

-------------------------------------------------------------------------------------------
create or alter proc sp_check_exists_lt @mamh varchar(10)
as
begin
	select *
	from Lich_thi
	where id_MH = @mamh
end
go
