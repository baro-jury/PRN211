USE [master]
GO
CREATE DATABASE [Karaoke]
GO
USE [Karaoke]
GO
CREATE TABLE [Account](
	[displayName] [nvarchar](255) NOT NULL,
	[userName] [varchar](50) NOT NULL,
	[password] [varchar](32) NOT NULL,
	[permission] [nvarchar](255) NOT NULL,
	CONSTRAINT [account_pk] PRIMARY KEY ([userName])
);
GO
INSERT [Account] ([displayName], [userName], [password], [permission]) VALUES (N'Admin', 'admin', 'admin', N'Administrator')
INSERT [Account] ([displayName], [userName], [password], [permission]) VALUES (N'Room 1', 'room11', 'room11', N'Standard')
INSERT [Account] ([displayName], [userName], [password], [permission]) VALUES (N'Room 2', 'room21', 'room21', N'Standard')
INSERT [Account] ([displayName], [userName], [password], [permission]) VALUES (N'Room 3', 'room31', 'room31', N'Standard')
INSERT [Account] ([displayName], [userName], [password], [permission]) VALUES (N'Room 1', 'room12', 'room12', N'VIP')
INSERT [Account] ([displayName], [userName], [password], [permission]) VALUES (N'Room 2', 'room22', 'room22', N'VIP')
INSERT [Account] ([displayName], [userName], [password], [permission]) VALUES (N'Room 3', 'room32', 'room32', N'VIP')
GO
CREATE TABLE [Music](
	[music_id] [varchar](6) NOT NULL,
	[accented_name] [nvarchar](255) NOT NULL,
	[genre] [nvarchar](255) NOT NULL,
	[composer] [nvarchar](255) NOT NULL,
	[singer] [nvarchar](255) NULL,
	[lyric] [nvarchar](255) NULL,
	[unaccented_name] [nvarchar](255) NOT NULL,
	[abbreviation] [varchar](255) NOT NULL,
	[link] [varchar](255) NOT NULL,
	CONSTRAINT [music_pk] PRIMARY KEY ([music_id])
);
GO
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('AD0308', N'Anh Đã Lạc Vào', N'Pop', N'Green', N'Green', N'Một phút lơ là lỡ va vào đôi mắt em anh đã vội đem con tim trao về em', N'Anh Da Lac Vao', 'ADLV', 'https://tinyurl.com/anhdalacvao')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('BE0313', N'Bỏ Em Vào Ba Lô', N'Pop', N'Tân Trần', N'Tân Trần', N'Đón em về nhà sau buổi chiều tăng ca đoạn đường vẫn thế sao hôm nay xa quá', N'Bo Em Vao Ba Lo', 'BEVBL', 'https://tinyurl.com/boemvaobalo')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('CD0452', N'Con Đường Xưa Em Đi', N'Bolero', N'Hồ Đình Phương', N'Như Quỳnh', N'Con đường xưa em đi vàng lên mái tóc thề ngõ hồn dâng tái tê', N'Con Duong Xua Em Di', 'CDXED', 'https://tinyurl.com/conduongxuaemdi')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('DC0358', N'Dù Cho Mai Về Sau', N'Pop', N'buitruonglinh', N'buitruonglinh', N'Bầu trời đêm không mây không sao trăng treo trên cao khi lòng anh vẫn nhớ nhung em nhiều', N'Du Cho Mai Ve Sau', 'DCMVS', 'https://tinyurl.com/duchomaivesau')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('DP0543', N'Duyên Phận', N'Bolero', N'Thái Thịnh', N'Như Quỳnh', N'Phận là con gái chưa một lần yêu ai nhìn về tương lai mà thấy như sông rộng đường dài', N'Duyen Phan', 'DP', 'https://tinyurl.com/duyenphan')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('DT0426', N'Đường Tôi Chở Em Về', N'Pop', N'buitruonglinh', N'buitruonglinh', N'Xe đạp lách cách tôi vẫn chưa quen đường thì tối chơi vơi còn tôi vẫn cứ đứng đợi', N'Duong Toi Cho Em Ve', 'DTCEV', 'https://tinyurl.com/duongtoichoemve')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('DT0646', N'Đồi Thông Hai Mộ', N'Bolero', N'Hồng Vân', N'Lệ Quyên', N'Một chiều rừng gió lộng một chiều rừng kể chuyện bên đồi thông', N'Doi Thong Hai Mo', 'DTHM', 'https://tinyurl.com/doithonghaimo')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('DV0325', N'Đi Về Nhà', N'Rap', N'Đen, Hứa Kim Tuyền, Xuân Ty', N'Đen x JustaTee', N'Đường về nhà là vào tim ta dẫu nắng mưa gần xa thất bát vang danh nhà vẫn luôn chờ ta', N'Di Ve Nha', 'DVN', 'https://tinyurl.com/divenha0325')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('HS0428', N'Hoa Sứ Nhà Nàng', N'Bolero', N'Hoàng Phương', N'Khánh Duy, Tâm Đoan', N'Đêm đêm ngửi mùi hương mùi hoa sứ nhà nàng hương nồng hoa tình ái đậm đà ngày đó gọi tên', N'Hoa Su Nha Nang', 'HSNN', 'https://tinyurl.com/hsnn0428')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('KD0345', N'Kém Duyên', N'Pop', N'Hưng Nguyễn, Rum', N'Hưng Nguyễn, Rum', N'Một chiều mưa trong lòng anh thấm bao nỗi sầu dù không đau nhưng giờ anh vẫn nhớ', N'Kem Duyen', 'KD', 'https://tinyurl.com/kemduyen0345')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('LY0433', N'Lời Yêu Ngây Dại', N'Pop', N'Kha', N'Kha', N'Long lanh giọt sương kia như trôi là vài câu nói chưa kịp nghĩ tới', N'Loi Yeu Ngay Dai', 'LYND', 'https://tinyurl.com/loiyeungaydai')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('MT0641', N'Mang Tiền Về Cho Mẹ', N'Rap', N'Đen', N'Đen, Nguyên Thảo', N'Mang tiền về cho mẹ mang tiền về cho mẹ mang tiền về cho mẹ đừng mang ưu phiền về cho mẹ', N'Mang Tien Ve Cho Me', 'MTVCM', 'https://tinyurl.com/mtvcm')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('PC0334', N'Phải Chăng Em Đã Yêu', N'Pop', N'RedT', N'Juky San x RedT', N'Phải chăng em đã yêu ngay từ cái nhìn đầu tiên phải chăng em đã say ngay từ lúc thấy nụ cười ấy', N'Phai Chang Em Da Yeu', 'PCEDY', 'https://tinyurl.com/pcedy0334')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('PC0352', N'Phố Cũ Còn Anh', N'Pop', N'Phạm Duy Anh', N'Quinn x Chilly', N'Đêm lạnh lùng đã làm bùng lên cô đơn tột cùng nụ cười anh chẳng làm sưởi ấm tim em nữa đâu', N'Pho Cu Con Anh', 'PCCA', 'https://tinyurl.com/phocuconanh')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('SE0324', N'Sao Em Lại Tắt Máy', N'Rap', N'Phạm Nguyên Ngọc', N'Phạm Nguyên Ngọc x Vanh', N'Thuê bao quý khách vừa gọi, tạm thời không liên lạc được nếu không phiền sau cuộc gọi này vui lòng thực hiện đủ các bước', N'Sao Em Lai Tat May', 'SELTM', 'https://tinyurl.com/seltm')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('SG0512', N'Sài Gòn Đau Lòng Quá', N'Pop', N'Hứa Kim Tuyền', N'Hứa Kim Tuyền x Hoàng Duyên', N'Cầm tấm vé trên tay em bay đến nơi xa Sài Gòn đau lòng quá toàn kỷ niệm chúng ta', N'Sai Gon Dau Long Qua', 'SGDLQ', 'https://tinyurl.com/sqdlq')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('ST0451', N'Sầu Tím Thiệp Hồng', N'Bolero', N'Hoài Linh', N'Lệ Quyên, Quang Lê', N'Từ lúc quen nhau chưa nói một lời gì, tỏ tình ta mến nhau', N'Sau Tim Thiep Hong', 'STTH', 'https://tinyurl.com/sautimthiephong')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('TX0400', N'Thanh Xuân', N'Pop', N'Da LAB', N'Da LAB', N'Hôm nay ta thức dậy cũng như thường nhật thấy thanh xuân ngày nào bỗng dưng trở lại', N'Thanh Xuan', 'TX', 'https://tinyurl.com/tx0400')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('VD0437', N'Về Đâu Mái Tóc Người Thương ', N'Bolero', N'Hoài Linh', N'Quang Lê', N'Hồn lỡ sa vào đôi mắt em chiều nao xõa tóc ngồi bên rèm thầm ước nhưng nào đâu dám nói khép tâm tư lại thôi đường hoa vẫn chưa mở lối', N'Ve Dau Mai Toc Nguoi Thuong', 'VDMTNT', 'https://tinyurl.com/vdmtnt0437')
INSERT [Music] ([music_id], [accented_name], [genre], [composer], [singer], [lyric], [unaccented_name], [abbreviation], [link]) VALUES ('YT0402', N'Yêu Từ Đâu Mà Ra', N'Pop', N'Lil Z Poet', N'Lil Z Poet', N'Yêu từ đâu mà ra khi chia xa vòng tay của nhau chỉ khiến ta thêm buồn đau', N'Yeu Tu Dau Ma Ra', 'YTDMR', 'https://tinyurl.com/yeutudaumara')
GO
CREATE TABLE [TypeOfRoom](
	[type_id] [int] NOT NULL,
	[type_name] [nvarchar](255) NOT NULL,
	CONSTRAINT [type_pk] PRIMARY KEY ([type_id])
);
GO
INSERT [TypeOfRoom] ([type_id], [type_name]) VALUES (1, N'Standard')
INSERT [TypeOfRoom] ([type_id], [type_name]) VALUES (2, N'VIP')
GO
CREATE TABLE [Service](
	[service_id] [varchar](4) NOT NULL,
	[room_type] [int] NOT NULL FOREIGN KEY ([room_type]) REFERENCES [TypeOfRoom]([type_id]),
	[service_name] [nvarchar](255) NOT NULL,
	[price] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	CONSTRAINT [service_pk] PRIMARY KEY ([service_id])
);
GO
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S001', 1, N'Nước khoáng', 8000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S002', 1, N'Cocacola', 12000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S003', 1, N'Sprite', 12000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S004', 1, N'Fanta', 12000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S005', 1, N'Đĩa hoa quả', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S006', 1, N'Snack đậu phộng', 10000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S007', 1, N'Snack khoai tây', 10000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S008', 1, N'Mít sấy', 30000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S009', 1, N'Khô gà', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S010', 1, N'Khô bò', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S011', 1, N'Strongbow táo', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S012', 1, N'Strongbow mật ong', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S013', 1, N'Strongbow dâu đỏ', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S014', 1, N'Strongbow dâu đen', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S015', 1, N'Strongbow ElderFlower', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S016', 1, N'Bia 333', 15000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S017', 1, N'Bia Sài Gòn', 15000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('S018', 1, N'Bia Tiger', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V001', 2, N'Nước khoáng', 8000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V002', 2, N'Cocacola', 12000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V003', 2, N'Sprite', 12000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V004', 2, N'Fanta', 12000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V005', 2, N'Đĩa hoa quả', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V006', 2, N'Snack đậu phộng', 15000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V007', 2, N'Snack khoai tây', 15000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V008', 2, N'Mít sấy', 30000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V009', 2, N'Khô gà', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V010', 2, N'Khô bò', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V011', 2, N'Strongbow táo', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V012', 2, N'Strongbow mật ong', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V013', 2, N'Strongbow dâu đỏ', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V014', 2, N'Strongbow dâu đen', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V015', 2, N'Strongbow ElderFlower', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V016', 2, N'Bia 333', 15000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V017', 2, N'Bia Sài Gòn', 15000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V018', 2, N'Bia Tiger', 20000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V019', 2, N'Rượu Vodka Men’s', 60000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V020', 2, N'Champagne Nga', 170000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V021', 2, N'Tequila', 300000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V022', 2, N'Nem chua rán', 70000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V023', 2, N'Chả giò Bum', 140000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V024', 2, N'Bò tơ xông khói', 150000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V025', 2, N'Chả mực cuộn mía', 150000, 100)
INSERT [Service] ([service_id], [room_type], [service_name], [price], [quantity]) VALUES ('V026', 2, N'Special Service for Men', 500000, 100)
GO
CREATE TABLE [Room](
	[floor] [int] NOT NULL,
	[room_number] [int] NOT NULL,
	[type] [int] NOT NULL FOREIGN KEY ([type]) REFERENCES [TypeOfRoom]([type_id]),
	[price] [int] NOT NULL,
	[status] [bit] NOT NULL,
	CONSTRAINT [room_pk] PRIMARY KEY ([floor], [room_number])
);
GO
INSERT [Room] ([floor], [room_number], [type], [price], [status]) VALUES (1, 1, 1, 100000, 0)
INSERT [Room] ([floor], [room_number], [type], [price], [status]) VALUES (1, 2, 1, 100000, 0)
INSERT [Room] ([floor], [room_number], [type], [price], [status]) VALUES (1, 3, 1, 100000, 0)
INSERT [Room] ([floor], [room_number], [type], [price], [status]) VALUES (2, 1, 2, 200000, 0)
INSERT [Room] ([floor], [room_number], [type], [price], [status]) VALUES (2, 2, 2, 200000, 0)
INSERT [Room] ([floor], [room_number], [type], [price], [status]) VALUES (2, 3, 2, 200000, 0)
GO
CREATE TABLE [Bill](
	[bill_id] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](50) NOT NULL FOREIGN KEY ([userName]) REFERENCES [Account]([userName]),
	[order_date] [datetime] NOT NULL,
	[payment_method] [nvarchar](12) NOT NULL,
	[status] [bit] NOT NULL,
	CONSTRAINT [bill_pk] PRIMARY KEY ([bill_id])
);
GO
INSERT [Bill] ([userName], [order_date], [payment_method], [status]) VALUES ('admin', GETDATE(), N'ATM Card', 0)
INSERT [Bill] ([userName], [order_date], [payment_method], [status]) VALUES ('room11', GETDATE(), N'Cash', 1)
INSERT [Bill] ([userName], [order_date], [payment_method], [status]) VALUES ('room22', GETDATE(), N'Banking', 1)
GO
CREATE TABLE [Order](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[bill_id] [int] NOT NULL,
	[user] [varchar](50) NOT NULL FOREIGN KEY ([user]) REFERENCES [Account]([userName]),
	[service_id] [varchar](4) NOT NULL FOREIGN KEY ([service_id]) REFERENCES [Service]([service_id]),
	[quantity] [int] NOT NULL,
	[total_payment] [int] NOT NULL,
	[status] [bit] NOT NULL,
	CONSTRAINT [order_pk] PRIMARY KEY ([order_id])
);
GO
INSERT [Order] ([bill_id], [user], [service_id], [quantity], [total_payment], [status]) VALUES (0, 'admin', 'V026', 1, 500000, 0)
INSERT [Order] ([bill_id], [user], [service_id], [quantity], [total_payment], [status]) VALUES (1, 'admin', 'S007', 3, 30000, 1)
INSERT [Order] ([bill_id], [user], [service_id], [quantity], [total_payment], [status]) VALUES (1, 'admin', 'V023', 2, 280000, 1)
INSERT [Order] ([bill_id], [user], [service_id], [quantity], [total_payment], [status]) VALUES (1, 'admin', 'V026', 2, 1000000, 1)
INSERT [Order] ([bill_id], [user], [service_id], [quantity], [total_payment], [status]) VALUES (2, 'room11', 'S008', 3, 90000, 1)
INSERT [Order] ([bill_id], [user], [service_id], [quantity], [total_payment], [status]) VALUES (3, 'room22', 'V023', 2, 280000, 1)
INSERT [Order] ([bill_id], [user], [service_id], [quantity], [total_payment], [status]) VALUES (3, 'room22', 'V026', 2, 1000000, 1)
------------------------------------------------------------------------------------------