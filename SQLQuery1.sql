CREATE DATABASE Project_Desktop;
GO
USE Project_Desktop;
GO

CREATE TABLE Users (
    Id VARCHAR(50) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Role VARCHAR(50) NOT NULL,
    Department NVARCHAR(100) NULL,
    IsPremium BIT NULL,
    PostsCount INT NULL
);
GO

CREATE TABLE Publications (
    Id VARCHAR(50) PRIMARY KEY,
    Title NVARCHAR(255) NOT NULL,
    Content NVARCHAR(MAX) NULL,
    PublishDate DATETIME NOT NULL,
    VideoUrl VARCHAR(255) NULL,
    IsApproved BIT NOT NULL,
    ViewCount INT NOT NULL,
    AirTime DATETIME NULL,
    Type VARCHAR(50) NOT NULL,
    TrendLevel INT NULL,
    IsConfirmed BIT NULL,
    Duration FLOAT NULL,
    Resolution VARCHAR(20) NULL,
    Author NVARCHAR(100) NULL
);
GO

USE Project_Desktop;
GO

INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A001', N'Quản Trị Viên 1', 'admin1@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A002', N'Quản Trị Viên 2', 'admin2@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A003', N'Quản Trị Viên 3', 'admin3@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A004', N'Quản Trị Viên 4', 'admin4@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A005', N'Quản Trị Viên 5', 'admin5@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A006', N'Quản Trị Viên 6', 'admin6@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A007', N'Quản Trị Viên 7', 'admin7@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A008', N'Quản Trị Viên 8', 'admin8@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A009', N'Quản Trị Viên 9', 'admin9@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A010', N'Quản Trị Viên 10', 'admin10@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A011', N'Quản Trị Viên 11', 'admin11@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A012', N'Quản Trị Viên 12', 'admin12@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A013', N'Quản Trị Viên 13', 'admin13@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A014', N'Quản Trị Viên 14', 'admin14@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A015', N'Quản Trị Viên 15', 'admin15@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A016', N'Quản Trị Viên 16', 'admin16@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A017', N'Quản Trị Viên 17', 'admin17@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A018', N'Quản Trị Viên 18', 'admin18@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A019', N'Quản Trị Viên 19', 'admin19@gmail.com', '123456', 'Admin');
INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES ('A020', N'Quản Trị Viên 20', 'admin20@gmail.com', '123456', 'Admin');
GO


INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R001', N'Phóng Viên 1', 'rep1@gmail.com', '123456', 'Reporter', N'Thời sự', 12);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R002', N'Phóng Viên 2', 'rep2@gmail.com', '123456', 'Reporter', N'Thể thao', 5);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R003', N'Phóng Viên 3', 'rep3@gmail.com', '123456', 'Reporter', N'Giải trí', 18);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R004', N'Phóng Viên 4', 'rep4@gmail.com', '123456', 'Reporter', N'Kinh tế', 2);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R005', N'Phóng Viên 5', 'rep5@gmail.com', '123456', 'Reporter', N'Giáo dục', 9);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R006', N'Phóng Viên 6', 'rep6@gmail.com', '123456', 'Reporter', N'Thời sự', 21);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R007', N'Phóng Viên 7', 'rep7@gmail.com', '123456', 'Reporter', N'Thể thao', 14);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R008', N'Phóng Viên 8', 'rep8@gmail.com', '123456', 'Reporter', N'Giải trí', 3);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R009', N'Phóng Viên 9', 'rep9@gmail.com', '123456', 'Reporter', N'Kinh tế', 7);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R010', N'Phóng Viên 10', 'rep10@gmail.com', '123456', 'Reporter', N'Giáo dục', 11);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R011', N'Phóng Viên 11', 'rep11@gmail.com', '123456', 'Reporter', N'Thời sự', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R012', N'Phóng Viên 12', 'rep12@gmail.com', '123456', 'Reporter', N'Thể thao', 25);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R013', N'Phóng Viên 13', 'rep13@gmail.com', '123456', 'Reporter', N'Giải trí', 8);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R014', N'Phóng Viên 14', 'rep14@gmail.com', '123456', 'Reporter', N'Kinh tế', 19);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R015', N'Phóng Viên 15', 'rep15@gmail.com', '123456', 'Reporter', N'Giáo dục', 4);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R016', N'Phóng Viên 16', 'rep16@gmail.com', '123456', 'Reporter', N'Thời sự', 16);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R017', N'Phóng Viên 17', 'rep17@gmail.com', '123456', 'Reporter', N'Thể thao', 22);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R018', N'Phóng Viên 18', 'rep18@gmail.com', '123456', 'Reporter', N'Giải trí', 6);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R019', N'Phóng Viên 19', 'rep19@gmail.com', '123456', 'Reporter', N'Kinh tế', 13);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R020', N'Phóng Viên 20', 'rep20@gmail.com', '123456', 'Reporter', N'Giáo dục', 30);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R021', N'Phóng Viên 21', 'rep21@gmail.com', '123456', 'Reporter', N'Thời sự', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R022', N'Phóng Viên 22', 'rep22@gmail.com', '123456', 'Reporter', N'Thể thao', 9);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R023', N'Phóng Viên 23', 'rep23@gmail.com', '123456', 'Reporter', N'Giải trí', 15);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R024', N'Phóng Viên 24', 'rep24@gmail.com', '123456', 'Reporter', N'Kinh tế', 27);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R025', N'Phóng Viên 25', 'rep25@gmail.com', '123456', 'Reporter', N'Giáo dục', 5);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R026', N'Phóng Viên 26', 'rep26@gmail.com', '123456', 'Reporter', N'Thời sự', 11);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R027', N'Phóng Viên 27', 'rep27@gmail.com', '123456', 'Reporter', N'Thể thao', 8);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R028', N'Phóng Viên 28', 'rep28@gmail.com', '123456', 'Reporter', N'Giải trí', 20);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R029', N'Phóng Viên 29', 'rep29@gmail.com', '123456', 'Reporter', N'Kinh tế', 17);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R030', N'Phóng Viên 30', 'rep30@gmail.com', '123456', 'Reporter', N'Giáo dục', 2);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R031', N'Phóng Viên 31', 'rep31@gmail.com', '123456', 'Reporter', N'Thời sự', 14);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R032', N'Phóng Viên 32', 'rep32@gmail.com', '123456', 'Reporter', N'Thể thao', 6);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R033', N'Phóng Viên 33', 'rep33@gmail.com', '123456', 'Reporter', N'Giải trí', 23);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R034', N'Phóng Viên 34', 'rep34@gmail.com', '123456', 'Reporter', N'Kinh tế', 10);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R035', N'Phóng Viên 35', 'rep35@gmail.com', '123456', 'Reporter', N'Giáo dục', 18);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R036', N'Phóng Viên 36', 'rep36@gmail.com', '123456', 'Reporter', N'Thời sự', 7);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R037', N'Phóng Viên 37', 'rep37@gmail.com', '123456', 'Reporter', N'Thể thao', 12);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R038', N'Phóng Viên 38', 'rep38@gmail.com', '123456', 'Reporter', N'Giải trí', 29);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R039', N'Phóng Viên 39', 'rep39@gmail.com', '123456', 'Reporter', N'Kinh tế', 4);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R040', N'Phóng Viên 40', 'rep40@gmail.com', '123456', 'Reporter', N'Giáo dục', 16);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R041', N'Phóng Viên 41', 'rep41@gmail.com', '123456', 'Reporter', N'Thời sự', 21);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R042', N'Phóng Viên 42', 'rep42@gmail.com', '123456', 'Reporter', N'Thể thao', 3);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R043', N'Phóng Viên 43', 'rep43@gmail.com', '123456', 'Reporter', N'Giải trí', 11);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R044', N'Phóng Viên 44', 'rep44@gmail.com', '123456', 'Reporter', N'Kinh tế', 25);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R045', N'Phóng Viên 45', 'rep45@gmail.com', '123456', 'Reporter', N'Giáo dục', 9);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R046', N'Phóng Viên 46', 'rep46@gmail.com', '123456', 'Reporter', N'Thời sự', 15);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R047', N'Phóng Viên 47', 'rep47@gmail.com', '123456', 'Reporter', N'Thể thao', 28);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R048', N'Phóng Viên 48', 'rep48@gmail.com', '123456', 'Reporter', N'Giải trí', 5);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R049', N'Phóng Viên 49', 'rep49@gmail.com', '123456', 'Reporter', N'Kinh tế', 14);
INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES ('R050', N'Phóng Viên 50', 'rep50@gmail.com', '123456', 'Reporter', N'Giáo dục', 20);
GO

INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S001', N'Độc Giả 1', 'sub1@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S002', N'Độc Giả 2', 'sub2@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S003', N'Độc Giả 3', 'sub3@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S004', N'Độc Giả 4', 'sub4@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S005', N'Độc Giả 5', 'sub5@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S006', N'Độc Giả 6', 'sub6@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S007', N'Độc Giả 7', 'sub7@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S008', N'Độc Giả 8', 'sub8@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S009', N'Độc Giả 9', 'sub9@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S010', N'Độc Giả 10', 'sub10@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S011', N'Độc Giả 11', 'sub11@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S012', N'Độc Giả 12', 'sub12@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S013', N'Độc Giả 13', 'sub13@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S014', N'Độc Giả 14', 'sub14@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S015', N'Độc Giả 15', 'sub15@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S016', N'Độc Giả 16', 'sub16@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S017', N'Độc Giả 17', 'sub17@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S018', N'Độc Giả 18', 'sub18@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S019', N'Độc Giả 19', 'sub19@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S020', N'Độc Giả 20', 'sub20@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S021', N'Độc Giả 21', 'sub21@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S022', N'Độc Giả 22', 'sub22@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S023', N'Độc Giả 23', 'sub23@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S024', N'Độc Giả 24', 'sub24@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S025', N'Độc Giả 25', 'sub25@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S026', N'Độc Giả 26', 'sub26@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S027', N'Độc Giả 27', 'sub27@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S028', N'Độc Giả 28', 'sub28@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S029', N'Độc Giả 29', 'sub29@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S030', N'Độc Giả 30', 'sub30@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S031', N'Độc Giả 31', 'sub31@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S032', N'Độc Giả 32', 'sub32@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S033', N'Độc Giả 33', 'sub33@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S034', N'Độc Giả 34', 'sub34@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S035', N'Độc Giả 35', 'sub35@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S036', N'Độc Giả 36', 'sub36@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S037', N'Độc Giả 37', 'sub37@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S038', N'Độc Giả 38', 'sub38@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S039', N'Độc Giả 39', 'sub39@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S040', N'Độc Giả 40', 'sub40@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S041', N'Độc Giả 41', 'sub41@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S042', N'Độc Giả 42', 'sub42@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S043', N'Độc Giả 43', 'sub43@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S044', N'Độc Giả 44', 'sub44@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S045', N'Độc Giả 45', 'sub45@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S046', N'Độc Giả 46', 'sub46@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S047', N'Độc Giả 47', 'sub47@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S048', N'Độc Giả 48', 'sub48@gmail.com', '123456', 'Subscriber', 1);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S049', N'Độc Giả 49', 'sub49@gmail.com', '123456', 'Subscriber', 0);
INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES ('S050', N'Độc Giả 50', 'sub50@gmail.com', '123456', 'Subscriber', 0);

ALTER TABLE Publications
ADD AirTime DATETIME NULL;

INSERT INTO Publications
(Id, Title, PublishDate, IsApproved, ViewCount, AirTime, Content, VideoUrl, Type, TrendLevel, Resolution, Author)
VALUES
('DN001', N'Bản tin Thời sự Hà Nội 11h30 ngày 07/05/2026', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/15xQX-lFK-_ZBtJ5mWyPURNuZv9FtIX42/view?usp=drive_link', 'DailyNews', 0, NULL, NULL),
('DN002', N'Bản tin Thời sự Hà Nội 15h ngày 06/05', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/11EXOlEhfrk0NT_WX8ETaxe4ppVCfNVda/view?usp=drive_link', 'DailyNews', 0, NULL, NULL),
('DN003', N'Bản tin thời sự: Kinh hãi clip du khách rơi xuống vực sâu, nhân viên cố tình phớt lờ lời "cầu cứu"', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1l8zxGQ9-NZT4NHPuZzTZPisyt_5DQ0oi/view?usp=drive_link', 'DailyNews', 0, NULL, NULL),
('DN004', N'Chuyển động 24h ngày 09/4: Học cao hơn để đi xa hơn | VTV24', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1drOMV7Bocbwegp0B4pGDJKf4vGMwHwAK/view?usp=drive_link', 'DailyNews', 0, NULL, NULL),
('DN005', N'Làn sóng A.I thúc đẩy ngành bán dẫn | Thế giới 24h', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1ojpumkFa4VstLPsrjJjnxGy5phPzpiTs/view?usp=drive_link', 'DailyNews', 0, NULL, NULL),
('DN006', N'Lỗ hổng kiểm dịch: Vì sao lợn chết, lợn bệnh vẫn được thu gom công khai?', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1xQYq4HQCWcNquRXXupMFhVGn3PDPocD5/view?usp=drive_link', 'DailyNews', 0, NULL, NULL),
('DN007', N'Lỗ hổng kiểm soát trong các Bữa ăn học đường | Tiêu điểm | VTV1', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1v08ts2DWl-Lpj5C5dWOcXM1o91-noRip/view?usp=drive_link', 'DailyNews', 0, NULL, NULL),
('DN008', N'Minh bạch bữa ăn bán trú - làm rõ các khoản chi suất ăn học đường | Chuyển động 24h', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/19FfDP59vGIqESe_ND0P1xbloR4E9gl4e/view?usp=drive_link', 'DailyNews', 0, NULL, NULL),
('DN009', N'Nghịch lý thế hệ ''Henry'': Những người kiếm nhiều tiền nhưng chưa thể giàu có | VTV24', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1-rD7hC-DUoBZSaH1xQoOvVHdlBU411E2/view?usp=drive_link', 'DailyNews', 0, NULL, NULL),
('DN010', N'Phim lậu, truyền hình lậu: Nhiều vụ bị xử lý hình sự | VTV24', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1_d1USqnzKqketuLGxMwSROCNlGJ7uVNd/view?usp=drive_link', 'DailyNews', 0, NULL, NULL),
('DN011', N'Singapore mạnh tay xử lý bạo lực học đường, áp dụng cả phạt roi | VTV24', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/18wSwbOZPYxwZls2NnrBPIxDhvkWEikIk/view?usp=drive_link', 'DailyNews', 0, NULL, NULL),
('DN012', N'TIÊU ĐIỂM: Làm rõ các khoản chi xung quanh gói thầu cung cấp suất ăn cho trường học | VTV24', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/10I1JKn5kHW_pDas3crTt-PI5n0_OxKrE/view?usp=drive_link', 'DailyNews', 0, NULL, NULL),
('DN013', N'Tổng hợp tin tức an ninh trật tự nóng, thời sự Việt Nam mới nhất 24h | ANTV', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1XnZ0XmuaspGJB-jw0f8ph1yP85vGxcpW/view?usp=drive_link', 'DailyNews', 0, NULL, NULL),
('DN014', N'Triệt phá băng nhóm bắt cóc người nước ngoài, tống tiền 10 triệu USDT tại TP', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1Muy9TGhqQTesBpikgECd1tP8oHIJmn51/view?usp=drive_link', 'DailyNews', 0, NULL, NULL);
GO

-- DẠNG PHÓNG SỰ VIDEO
INSERT INTO Publications
(Id, Title, PublishDate, IsApproved, ViewCount, AirTime, Content, VideoUrl, Type, TrendLevel, Resolution, Author)
VALUES
('VR001', N'Bóc trần chiêu gọi hồn, áp vong, vòi tiền của bà thầy bói ở Thái Bình | VTV24', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1yGXliJYZcV9g1ph8NKseqdNK45VszxHH/view?usp=drive_link', 'VideoReport', NULL, NULL, NULL),
('VR002', N'Cảnh báo tình trạng bắt cóc tống tiền người nước ngoài | VTV Times', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1TXlVXSnOG3BgE5dw0Lm7bcfsilidsAd6/view?usp=drive_link', 'VideoReport', NULL, NULL, NULL),
('VR003', N'Công nghệ dầu gội, sữa tắm ‘’xô chậu’’: Từ tự chế hóa chất đến nguy cơ cho người tiêu dùng | VTV24', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1hdAJ7V5dE8IMNA8LbHwdZRjB6UV-m5oJ/view?usp=drive_link', 'VideoReport', NULL, NULL, NULL),
('VR004', N'Điểm tuần: “Hở” chút là ghi hình | VTV24', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1dfLyUGf3albLN1nohk4XnlPcfW54iH7x/view?usp=drive_link', 'VideoReport', NULL, NULL, NULL),
('VR005', N'Đột nhập "thủ phủ cần sa" | Phóng sự điều tra | Đảng với Dân', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1gvQvzGGoYD48XxGPbD8CLW_kW85Shhxx/view?usp=drive_link', 'VideoReport', NULL, NULL, NULL),
('VR006', N'Hàng loạt người dân mất tiền tỷ vì tin lời góp vốn đầu tư dự án ‘vua rau má’ | VTV24', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1tcJipB_QmVwPcceCkijeuetHxlwgmlU9/view?usp=drive_link', 'VideoReport', NULL, NULL, NULL),
('VR007', N'Kế hoạch tẩu thoát khỏi "địa ngục" ở bên kia biên giới | VTV đặc biệt BẪY', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1HLkddQDmuF3PGnLtRPQSYclWHvlgTpn8/view?usp=drive_link', 'VideoReport', NULL, NULL, NULL),
('VR008', N'Lợn ốm, lợn chết vào bàn ăn: Đường đi khuất tất của thịt không kiểm dịch | VTV24', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1twcf4mhKJ3U0MHMBe03pm29s6B2DTnXP/view?usp=drive_link', 'VideoReport', NULL, NULL, NULL),
('VR009', N'Phóng viên điều tra trải lòng về nghề nguy hiểm | VTV24', GETDATE(), 1, 0, GETDATE(), NULL, NULL, 'VideoReport', NULL, NULL, NULL),
('VR010', N'Tâm sự của 3 sinh viên bị lôi kéo tham gia Tổ chức tự xưng “Hội Thánh Đức Chúa Trời” - Tin Tức VTV24', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1EMqUYlNKdK51--WqOZ3Jd56BTXpyXnbr/view?usp=drive_link', 'VideoReport', NULL, NULL, NULL),
('VR011', N'Tôi năm nay hơn 70 tuổi rồi mà..', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1Izjg_OkHRS4YczHcXFI25RIY3rJgTrNx/view?usp=drive_link', 'VideoReport', NULL, NULL, NULL),
('VR012', N'Triệt phá băng nhóm bắt cóc người nước ngoài, tống tiền 10 triệu USDT tại TP. Hồ Chí Minh | VTV24', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1aOKKZFHqf08OeIleLbz13aUtH-BKdVb7/view?usp=drive_link', 'VideoReport', NULL, NULL, NULL);
GO

INSERT INTO Publications
(Id, Title, PublishDate, IsApproved, ViewCount, AirTime, Content, VideoUrl, Type, TrendLevel, Resolution, Author)
VALUES
('WM001', N'Một thời giới trẻ say mê "Tạp chí MTV" | VTV24', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1RMRyCqQpCX8SHrd-2ZvfndI084mWtMXL/view?usp=drive_link', 'WeeklyMagazine', NULL, NULL, NULL),
('WM002', N'VTV1 - Giới thiệu Tạp chí truyền hình VTV kỳ 2 tháng 5 năm 2005', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1aimOA5IPZSevM1nJHSUdlBjQkGwL30Hz/view?usp=drive_link', 'WeeklyMagazine', NULL, NULL, NULL);
GO

INSERT INTO Publications
(Id, Title, PublishDate, IsApproved, ViewCount, AirTime, Content, VideoUrl, Type, TrendLevel, Resolution, Author)
VALUES
('BN001', N'TIN BÃO KHẨN CẤP (Cơn bão số 11) 12h ngày 5/10', GETDATE(), 1, 0, GETDATE(), NULL, 'https://drive.google.com/file/d/1gsiMx_wHCl2OHnK4SjwP4a5FmCBFFNrQ/view?usp=drive_link', 'BreakingNews', 0, NULL, NULL);

GO
