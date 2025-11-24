🛒 SalesProjectApp: Ứng dụng Quản lý Bán hàng (Windows Forms)
Dự án này được xây dựng trên nền tảng .NET Framework sử dụng kiến trúc phân lớp (Multi-tier Architecture) với Entity Framework (Database First) để quản lý dữ liệu.

1. ⚙️ Yêu cầu Môi trường
Để chạy dự án, bạn cần cài đặt các công cụ sau:

IDE: Visual Studio (2019 trở lên).

Database: SQL Server (bao gồm một phiên bản như SQLEXPRESS).

.NET Framework: Phiên bản 4.7.2 (hoặc cao hơn).

2. 🗄️ Thiết lập Cơ sở Dữ liệu
Dự án sử dụng Entity Framework để kết nối với Database SalesProjectNetDB. Bạn cần tạo Database và các bảng trước khi chạy code.

Bước 2.1: Tạo Database và Bảng
Mở SQL Server Management Studio (SSMS) và chạy toàn bộ Script SQL dưới đây (hoặc chạy trong công cụ quản lý DB khác):
```sql
-- Tên Database: SalesProjectNetDB
CREATE DATABASE SalesProjectNetDB;
GO 
USE SalesProjectNetDB;
GO

-- 1. Bảng Users (Người dùng & Phân quyền)
CREATE TABLE Users (
    userID VARCHAR(50) PRIMARY KEY,
    userName VARCHAR(50) UNIQUE NOT NULL, 
    password VARCHAR(255) NOT NULL,
    fullName NVARCHAR(100), 
    phone VARCHAR(20),
    address NVARCHAR(255), 
    userRole VARCHAR(10) NOT NULL,
    CONSTRAINT CHK_UserRole CHECK (userRole IN ('Admin', 'User', 'Guest'))
);

-- 2. Bảng Products (Hàng hóa & Tồn kho)
CREATE TABLE Products (
    SKU VARCHAR(50) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL UNIQUE, 
    category NVARCHAR(100), 
    price DECIMAL(18, 0) NOT NULL,
    stockQuantity INT NOT NULL DEFAULT 0,
    ImagePath NVARCHAR(MAX),
    Description NVARCHAR(MAX),
    isActive BIT NOT NULL DEFAULT 1
);

-- 3. Bảng Orders (Đơn hàng/Hóa đơn)
CREATE TABLE Orders (
    orderID INT IDENTITY(1,1) PRIMARY KEY,
    userID VARCHAR(50), 
    orderDate DATETIME NOT NULL DEFAULT GETDATE(),
    totalAmount DECIMAL(18, 0) NOT NULL,
    status VARCHAR(50) NOT NULL DEFAULT 'Completed',
    FOREIGN KEY (userID) REFERENCES Users(userID)
);

-- 4. Bảng OrderItems (Chi tiết Đơn hàng)
CREATE TABLE OrderItems (
    itemID INT IDENTITY(1,1) PRIMARY KEY,
    orderID INT NOT NULL, 
    SKU VARCHAR(50) NOT NULL, 
    quantity INT NOT NULL,
    unitPrice DECIMAL(18, 0) NOT NULL,
    FOREIGN KEY (orderID) REFERENCES Orders(orderID),
    FOREIGN KEY (SKU) REFERENCES Products(SKU)
);

-- Dữ liệu Khởi tạo
INSERT INTO Users (userID, userName, password, fullName, userRole) VALUES
('AD001', 'admin', '123', N'Quản trị viên Hệ thống', 'Admin'),
('GT001', 'guest', '123', N'Khách Vãng Lai', 'Guest');
```

Bước 2.2: Cập nhật Chuỗi Kết nối
Do chuỗi kết nối đang trỏ đến Server của người tạo, bạn cần sửa lại file App.config để khớp với tên Server SQL của bạn:

Mở file App.config trong thư mục gốc.

Tìm thẻ <connectionStrings>.

Thay thế phần Data Source trong connectionString bằng tên Server SQL của bạn (ví dụ: TEN_SERVER_CUA_BAN\SQLEXPRESS).

```
<connectionStrings>
    <add name="SalesProjectDBEntities" 
        connectionString="metadata=res://*/Models.SalesModel.csdl|res://*/Models.SalesModel.ssdl|res://*/Models.SalesModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;Data Source=TEN_SERVER_CUA_BAN\SQLEXPRESS;Initial Catalog=SalesProjectNetDB;Integrated Security=True;..." 
        providerName="System.Data.EntityClient" />
</connectionStrings>
```