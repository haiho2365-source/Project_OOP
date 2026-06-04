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

INSERT INTO Users (Id, FullName, Email, Password, Role) VALUES
('A01', N'Trần Quản Trị', 'admin1@gmail.com', '123456', 'Admin'),
('A02', N'Lê Hệ Thống', 'admin2@gmail.com', '123456', 'Admin');

INSERT INTO Users (Id, FullName, Email, Password, Role, Department, PostsCount) VALUES
('R01', N'Nguyễn Phóng Viên', 'pv1@gmail.com', '123456', 'Reporter', N'Thời sự', 0),
('R02', N'Phạm Thể Thao', 'pv2@gmail.com', '123456', 'Reporter', N'Thể thao', 0),
('R03', N'Đinh Giải Trí', 'pv3@gmail.com', '123456', 'Reporter', N'Giải trí', 0),
('R04', N'Hoàng Kinh Tế', 'pv4@gmail.com', '123456', 'Reporter', N'Kinh tế', 0),
('R05', N'Ngô Giáo Dục', 'pv5@gmail.com', '123456', 'Reporter', N'Giáo dục', 0);

INSERT INTO Users (Id, FullName, Email, Password, Role, IsPremium) VALUES
('S01', N'Độc giả Một', 'sub1@gmail.com', '123456', 'Subscriber', 1),
('S02', N'Độc giả Hai', 'sub2@gmail.com', '123456', 'Subscriber', 0),
('S03', N'Độc giả Ba', 'sub3@gmail.com', '123456', 'Subscriber', 1),
('S04', N'Độc giả Bốn', 'sub4@gmail.com', '123456', 'Subscriber', 0),
('S05', N'Độc giả Năm', 'sub5@gmail.com', '123456', 'Subscriber', 1),
('S06', N'Độc giả Sáu', 'sub6@gmail.com', '123456', 'Subscriber', 0),
('S07', N'Độc giả Bảy', 'sub7@gmail.com', '123456', 'Subscriber', 1),
('S08', N'Độc giả Tám', 'sub8@gmail.com', '123456', 'Subscriber', 0),
('S09', N'Độc giả Chín', 'sub9@gmail.com', '123456', 'Subscriber', 1),
('S10', N'Độc giả Mười', 'sub10@gmail.com', '123456', 'Subscriber', 0);
GO