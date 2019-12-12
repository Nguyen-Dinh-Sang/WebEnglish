create database WebDB;
go

Use WebDB;
go

create table NguoiDung
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	TenNguoiDung nvarchar(100),
	TaiKhoan varchar(50),
	MatKhau varchar(50),
	NgayTao date default getdate(),
	SoDienThoai varchar(20),
	Gmail varchar(50),
	VaiTro int default 1
);
go

truncate table NguoiDung;
go

insert into NguoiDung(TenNguoiDung, TaiKhoan, MatKhau, SoDienThoai, Gmail, VaiTro)
output inserted.ID
values (N'Trần Thanh Phong', 'phongle', '123456', '0333568910', 'tranphong123@gmail.com', 2);

insert into NguoiDung(TenNguoiDung, TaiKhoan, MatKhau, SoDienThoai, Gmail, VaiTro)
output inserted.ID
values (N'Nguyễn Thị Xuan Linh', 'linhxinhdep', '123456', '0333748913', 'xuanlinh@gmail.com', 2);

insert into NguoiDung(TenNguoiDung, TaiKhoan, MatKhau, SoDienThoai, Gmail, VaiTro)
output inserted.ID
values (N'Nguyễn Đình Sang', 'sangdeptrai', '123456', '0345225651', 'nguyendinhsang9199@gmail.com', 2);

insert into NguoiDung(TenNguoiDung, TaiKhoan, MatKhau, SoDienThoai, Gmail)
output inserted.ID
values (N'Trần Minh Nhật', 'nhattran', '123456', '0333568100', 'trannhat24@gmail.com');

insert into NguoiDung(TenNguoiDung, TaiKhoan, MatKhau, SoDienThoai, Gmail)
output inserted.ID
values (N'Huỳnh Khương Ninh', 'hkn', '123456', '0345678900', 'ninh@gmail.com');

insert into NguoiDung(TenNguoiDung, TaiKhoan, MatKhau, SoDienThoai, Gmail)
output inserted.ID
values (N'Trần Minh Hiếu', 'tranminhhieu', '123456', '0345678932', 'hieutran@gmail.com');

insert into NguoiDung(TenNguoiDung, TaiKhoan, MatKhau, SoDienThoai, Gmail)
output inserted.ID
values (N'Phạm Phương Thanh', 'thanhthanh', '123456', '0339999999', 'chethichhoa@gmail.com');

insert into NguoiDung(TenNguoiDung, TaiKhoan, MatKhau, SoDienThoai, Gmail)
output inserted.ID
values (N'Trần Thị Thúy An', 'thuyan', '123456', '0985632547', 'an123@gmail.com');

insert into NguoiDung(TenNguoiDung, TaiKhoan, MatKhau, SoDienThoai, Gmail)
output inserted.ID
values (N'Thái Minh Quân', 'vodoi', '123456', '0333568910', 'batcandoi@gmail.com');

insert into NguoiDung(TenNguoiDung, TaiKhoan, MatKhau, SoDienThoai, Gmail)
output inserted.ID
values (N'Phạm Tấn Phát', 'phamtanphat', '123456', '0987654321', 'phatpham@gmail.com');
go

create table ChuDe
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	TenChuDe nvarchar(100),
	ThongTin nvarchar(1000),
	NgayTao date default getdate()
)
go

truncate table ChuDe;
go

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Gặp Mặt Lần Đầu', N'Nói chuyên làm quen, hỏi quê quán, gặp người nước ngoài lần đầu');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Gặp Gỡ Tình Cờ', N'Hỏi thăm sau khi chuyển nhà, hỏi thăm sau thời gian dài không gặp, sự thay đổi sau thời gian dài không gặp');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Vui Mừng - Hạnh Phúc', N'Báo tin tốt lành về kì thi, mong ước gặp một người, hào hứng với chiếc xe mới');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Lo Lắng - Buồn', N'Buồn chán vì bài thi tiếng Anh không đạt, chia tay người yêu, bất tiện khi nhà ở gần sân bay');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Chia Sẻ - Cảm Thông', N'Động viên bạn cố gắng, động viên bạn cố gắng làm việc tốt hơn, chia sẻ khi bạn có tin buồn');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Cảm Ơn - Xin Lỗi', N'Trượt phỏng vấn, đề nghị giúp đỡ người khác, xin lỗi vì đến trễ bữa tiệc');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Tại Hiệu Thuốc', N'Mua thuốc theo đơn, mua thuốc nhờ tư vấn của nhân viên bán hàng, mua thuốc đau lưng');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Tại Ngân Hàng', N'Tư vấn gửi tiết kiệm kỳ hạn, tư vấn mở tài khoản tiết kiệm, không biết nên mở tài khoản tiết kiệm như thế nào');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Tại Bưu Điện', N'Gửi bưu phẩm và hỏi mua tem, cân nhắc/hỏi tư vấn về gửi bưu phẩm qua đường hàng không, gửi bưu kiện tới Pháp qua đường hàng hải');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Tại Rạp Chiếu Phim', N'Hỏi giá mua vé xem phim, bình luận về một bộ phim, rủ đi xem phim');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Tại Hiệu Chụp Ảnh', N'Chụp ảnh thẻ, đề nghị rửa cuộn phim, tạo dáng khi chụp ảnh');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Tại Tiệm Làm Đẹp', N'Gội đầu và sửa tóc, mát xa mặt, thử com lê');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Tại Bệnh Viện', N'Mô tả triệu chứng bệnh, đau bụng');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Tại Hiệu Giặt Là', N'Cách đưa ra một yêu cầu làm sạch cụ thể, đưa ra yêu cầu giặt đơn giản, hỏi giá');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Đi Ăn Nhà Hàng', N'Tình huống chưa đặt bàn trước, tình huống đã đặt bàn, gọi món');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Đi Mua Sắm', N'Mua giày, mua áo sơ mi');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Nói Lời Khẳng Định', N'Khẳng định sẻ đến buổi diễn ca nhạc, khẳng định nỗ lực học tiếng anh');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Đề Nghị - Xin Phép', N'Đệ nghị qua xem phòng thuê, xin phép gặp một người thông qua người thứ ba');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Phán Đoán Và Ý Kiến', N'Thảo luận về chạy bộ, bình luận về một cuốn sách');

insert into ChuDe(TenChuDe, ThongTin)
output inserted.ID
values (N'Kinh Doanh', N'Hỏi doanh thi và trụ sở/địa chỉ, hỏi về cơ chế và nguyên tắc hoạt động của doanh nghiệp, hỏi thị phần định hướng phát triển doanh nghiệp');
go

create table ThamGiaChuDe
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	IDNguoiDung int,
	IDChuDe int,
	CONSTRAINT NguoiDung_ThamGiaChuDe
	FOREIGN KEY (IDNguoiDung)
	REFERENCES dbo.NguoiDung (ID) 
	ON DELETE CASCADE,
	CONSTRAINT ChuDe_ThamGiaChuDe
	FOREIGN KEY (IDChuDe)
	REFERENCES dbo.ChuDe (ID) 
	ON DELETE CASCADE,
)
go

truncate table ThamGiaChuDe;
go

insert into ThamGiaChuDe(IDNguoiDung, IDChuDe)
output inserted.ID
values (1,1);

insert into ThamGiaChuDe(IDNguoiDung, IDChuDe)
output inserted.ID
values (1,2);

insert into ThamGiaChuDe(IDNguoiDung, IDChuDe)
output inserted.ID
values (2,5);

insert into ThamGiaChuDe(IDNguoiDung, IDChuDe)
output inserted.ID
values (3,10);

insert into ThamGiaChuDe(IDNguoiDung, IDChuDe)
output inserted.ID
values (3,11);

insert into ThamGiaChuDe(IDNguoiDung, IDChuDe)
output inserted.ID
values (3,12);
go

create table BaiHoc
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	IDChuDe int,
	BaiSo int default 1,
	TenBaiHoc nvarchar(100),
	NgayTao date default getdate(),
	CONSTRAINT ChuDe_BaiHoc
	FOREIGN KEY (IDChuDe)
	REFERENCES dbo.ChuDe (ID) 
	ON DELETE CASCADE 
)
go

truncate table BaiHoc;
go

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (1, N'Nói chuyện làm quen');

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (1, N'Hỏi quê quán');

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (1, N'Gặp người nước ngoài lần đầu');

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (2, N'Hỏi thăm sau khi chuyển nhà');

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (2, N'Hỏi thăm sau thời gian dài không gặp');

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (2, N'Sự thay đổi sau thời gian dài không gặp');

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (3, N'Báo tin tốt lành về kì thi');

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (3, N'Mong ước gặp một người');

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (3, N'Hòa hứng về một chiếc xe mới');

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (4, N'Buồn vì bài thi tiếng Anh không đạt');

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (4, N'Chia tay người yêu');

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (4, N'Bất tiên khi có nhà ở gần sân bay');

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (5, N'Động viên bạn cố gắng');

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (5, N'Chia sẻ khi bạn có tin buồn');

insert into BaiHoc(IDChuDe, TenBaiHoc)
output inserted.ID
values (5, N'Động viên bạn cố gắng làm việc');
go

create table ChiTietBaiHoc
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	IDBaiHoc int,
	NoiDung text,
	LinkMp3 varchar(100),
	GhiChu varchar(100),
	CONSTRAINT BaiHoc_ChiTietBaiHoc
	FOREIGN KEY (IDBaiHoc)
	REFERENCES dbo.BaiHoc (ID) 
	ON DELETE CASCADE 
)
go

truncate table ChiTietBaiHoc;
go

insert into ChiTietBaiHoc(IDBaiHoc, NoiDung, LinkMp3, GhiChu)
output inserted.ID
values (1, 'M: Hello. Last Thursday, I arranged to have cable television installed at my house this Wednesday, Unfortunately, I will have to be out of town that day because of some urgent matters and would like to reschedule the appointment for Friday afternoon. <br /> W: Ok, that should not be a problem. However, I would like to warn you that there is a $5 rescheduling fee. Thats our companys police. Can I have your name, please? <br /> M: Oh, I see. My name is Charlie Kramer. I am living in Hainesville. Do you know when I will have to pay this fee? <br /> W: I will e-mail you soon about a user name and temporary password that you can use on our website. Please check the e-mail and pay all your bills through our website.', 'Link', 'Test4 32->34');

insert into ChiTietBaiHoc(IDBaiHoc, NoiDung, LinkMp3, GhiChu)
output inserted.ID
values (2, 'M: Hi, Tiffany. Do you know what happened to the company car? I tried to reserve it to day, but I was told it is being repaired. <br /> W: When Mark was driwing yesterday, he got a flat tire. I just headrd that the car should be out of the repair shop by this evening. I will let you know when they call me. <br /> M: Oh, thats good news. I was worried because I need it tomorrow morning to pick up an important client from the airport. <br /> W: Ah, is not that Mr.Lee from Beijing? Just in case, why do not you call a local car rental business and reserve a car for tomorrow? If the company car is fixed in time, you can cancel.', 'Link', 'Test4 35->37');

insert into ChiTietBaiHoc(IDBaiHoc, NoiDung, LinkMp3, GhiChu)
output inserted.ID
values (3, 'W: hello, this is Kelly in the accounting department. The ink cartridge in the printer on the fourth floor has run out. Do you think you could come to replace it to day? <br /> M: Sure. By the way, can I ask ou a favor? I need you to let me know what model the machine is so I can bring the correct one. Actually, I am not in the office right now, so I can not see what it is. <br /> W: Ok. But how can I find out that information? Do I have to open the printer cover or press some function buttons? <br /> M: No, you do not> Just ask Mr.Hills in your department. He should have a complete list of all the hardware on the fourth floor.', 'Link', 'Test4 38->40');

create table Hoc
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	IDThamGiaChuDe int,
	IDBaiHoc int,
	Diem int default 0,
	CONSTRAINT ThamGiaChuDe_Hoc
	FOREIGN KEY (IDThamGiaChuDe)
	REFERENCES dbo.ThamGiaChuDe (ID),
	CONSTRAINT BaiHoc_Hoc
	FOREIGN KEY (IDBaiHoc)
	REFERENCES dbo.BaiHoc (ID) 
	ON DELETE CASCADE
)
go

truncate table Hoc;
go

insert into Hoc(IDThamGiaChuDe, IDBaiHoc)
output inserted.ID
values (1, 1);

insert into Hoc(IDThamGiaChuDe, IDBaiHoc)
output inserted.ID
values (1, 2);
go

create table BaiKiemTra
(
	ID int IDENTITY(1, 1) PRIMARY KEY,
	IDBaiHoc int,
	NgayTao date default getdate(),
	CONSTRAINT BaiHoc_BaiKiemTra
	FOREIGN KEY (IDBaiHoc)
	REFERENCES dbo.BaiHoc (ID) 
	ON DELETE CASCADE
)
go

truncate table BaiKiemTra;
go

insert into BaiKiemTra(IDBaiHoc)
output inserted.ID
values (1);

insert into BaiKiemTra(IDBaiHoc)
output inserted.ID
values (2);

insert into BaiKiemTra(IDBaiHoc)
output inserted.ID
values (3);

insert into BaiKiemTra(IDBaiHoc)
output inserted.ID
values (4);

insert into BaiKiemTra(IDBaiHoc)
output inserted.ID
values (5);
go

create table CauHoi
(
	ID int IDENTITY(1, 1) PRIMARY KEY,
	IDBaiKiemTra int,
	CauHoi varchar(200),
	DapAnA varchar(200),
	DapAnB varchar(200),
	DapAnC varchar(200),
	DapAnD varchar(200),
	DapAnDung varchar(2),
	GoiY ntext,
	CONSTRAINT BaiKiemTra_CauHoi
	FOREIGN KEY (IDBaiKiemTra)
	REFERENCES dbo.BaiKiemTra (ID) 
	ON DELETE CASCADE
)
go

truncate table CauHoi;
go

insert into CauHoi(IDBaiKiemTra, CauHoi, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, GoiY)
output inserted.ID
values (1, 'What did the man recently do?', 'Purchased a house.', 'Went on a business trip.', 'Signed up for a service.', 'Installed a television.', 'B', N'Người đàn ông vừa mới làm gì? <br /> A Mua nhà. <br /> B Đi công tác. <br /> C Đăng ký một dịch vụ. <br /> D Lắp đặt TV');

insert into CauHoi(IDBaiKiemTra, CauHoi, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, GoiY)
output inserted.ID
values (1, 'Why must the man pay a fee?', 'He wants to change his schedule.', 'He returned an item late.', 'He lost his membership card.', 'He needs an additional service.', 'A', N'Tại sao người đàn ông phải trả phí? <br /> A Anh ấy muốn thay đổi lịch. <br /> B Anh ấy trả hàng trễ hạng. <br /> C Anh ấy bị mất thẻ thành viên. <br /> D Anh ấy cần thêm dịch vụ khác');

insert into CauHoi(IDBaiKiemTra, CauHoi, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, GoiY)
output inserted.ID
values (1, 'What will the woman include in an e-mail?', 'A receipt.', 'Login information.', 'A membership contract.', 'Driving directions.', 'B', N'Người phụ nữ sẽ gửi kèm cái gì trong e-mail? <br /> A Biên lai. <br /> B Thông tin đăng nhập. <br /> C Hợp đồng đăng kí thành viên. <br /> D Hướng dẫn chỉ đường');

insert into CauHoi(IDBaiKiemTra, CauHoi, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, GoiY)
output inserted.ID
values (2, 'What does the woman say caused the problem?', 'A repair cost has increased.', 'A reseervation has been canceled.', 'Aclient arrived too late.', 'A tire needed to be replaced.', 'D', N'Người phụ nữ nói điều gì gây ra sự cố? <br /> A Chi phí sửa chữa đã tăng lên. <br /> B Việc đặt chỗ đã bị hủy bỏ. <br /> C Khách hàng đến quá muộn. <br /> D Một lốp xe cần phải được thay mới');

insert into CauHoi(IDBaiKiemTra, CauHoi, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, GoiY)
output inserted.ID
values (2, 'Why is the man concerned?', 'He lost an important receipt..', 'He needs a car to greet a chlient.', 'He has to reschedule a meeting.', 'He was unable to contact a client.', 'B', N'Tại sao người đàn ông lại lo lắng? <br /> A Anh ta đã làm mất một biên lai quan trọng. <br /> B Anh ta cần một chiếc xe hơi để đi đón khách hàng. <br /> C Anh ấy phải đặt lại một lịch họp. <br /> D Anh ta không thể liên lạc với khách hàng');

insert into CauHoi(IDBaiKiemTra, CauHoi, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, GoiY)
output inserted.ID
values (2, 'What dose th woman suggest?', 'Prearing an alternative plan.', 'Ordering a replacement part.', 'Attending a conference.', 'Reserving a less expansive ticket.', 'A', N'Người phụ nữ khuyên điều gì? <br /> A Chuẩn bị một phương án dự phòng. <br /> B Đặt phụ tùng thay thế. <br /> C Tham dự một hội nghị. <br /> D Đặt một vé có giá thấp hơn');

insert into CauHoi(IDBaiKiemTra, CauHoi, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, GoiY)
output inserted.ID
values (3, 'What problen is the woman reporting?', 'An accounting error has been made.', 'A printer is out of order.', 'Some office supplies have been used up.', 'A document has become lost.', 'C', N'Người phụ nữ báo cáo sự cố gì? <br /> A Sai sót trong công tác kế toán. <br /> B Một máy in bị hư. <br /> C Một vài dụng cụ văn phòng đã hết. <br /> D Một tài liệu đã bị mất');

insert into CauHoi(IDBaiKiemTra, CauHoi, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, GoiY)
output inserted.ID
values (3, 'What dose the man ask the woman to do?', 'Check some product information.', 'Install new equipment.', 'Update customer information.', 'Stop by his office.', 'A', N'Người đàn ông yêu cầu người phụ nữ làm gì? <br /> A Kiểm tra thông tin sản phẩm. <br /> B Lắp đặt thiết bị mới. <br /> C Cập nhật thông tin khách hàng. <br /> D Ghé qua văn phòng anh ta');

insert into CauHoi(IDBaiKiemTra, CauHoi, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, GoiY)
output inserted.ID
values (3, 'What is mentioned about Mr.Hills?', 'He is in charge of a new project.', 'He is in the same department as the woman.', 'He is in the same department as the woman.', 'He wrote a hardware list.', 'B', N'Ông Hills được nhắc đến về điều gì? <br /> A Anh ấy phụ trách một dự án mới. <br /> B Anh ấy ở cùng phòng ban với người phụ nữ. <br /> C Anh ta vừa đặt một đơn hàng. <br /> D Ông đã lập ra danh sách mua thiết bị');
go

select *
from CauHoi
go

select *
from BaiKiemTra
go

select *
from Hoc
go

select *
from ChiTietBaiHoc
go

select *
from BaiHoc
go

select *
from ThamGiaChuDe
go

select *
from ChuDe
go

select *
from NguoiDung;
go

drop table CauHoi
go

drop table BaiKiemTra
go

drop table Hoc
go

drop table ChiTietBaiHoc
go

drop table BaiHoc
go

drop table ThamGiaChuDe
go

drop table NguoiDung;
go

drop table ChuDe;
go

select *
from ChiTietbaihoc
where (idbaihoc in (select Idbaihoc
					from BaiHoc
					where idchude = 1));

