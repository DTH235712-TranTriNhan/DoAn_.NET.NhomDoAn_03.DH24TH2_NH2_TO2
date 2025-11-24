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
USE master;
GO

-- 1. Tạo Database mới
CREATE DATABASE SalesProjectNetDB;
GO

-- 2. Sử dụng Database vừa tạo
USE SalesProjectNetDB;
GO

-- =================================================================
-- TẠO CÁC BẢNG (TABLES)
-- =================================================================

-- Bảng Users
CREATE TABLE users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE, 
    password VARCHAR(255) NOT NULL,
    email VARCHAR(100), 
    phone_number VARCHAR(20),
    full_name NVARCHAR(100), 
    role VARCHAR(10) DEFAULT 'user',
    created_at DATETIME DEFAULT GETDATE(),
    CONSTRAINT CK_Users_Role CHECK (role IN ('user', 'admin')) 
);
GO

-- Tạo Index duy nhất cho Email (Bỏ qua NULL)
CREATE UNIQUE INDEX IX_Users_Email_Unique ON users(email) WHERE email IS NOT NULL;
GO

-- Bảng Categories
CREATE TABLE categories (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    code VARCHAR(50) NOT NULL UNIQUE
);
GO

-- Bảng Products
CREATE TABLE products (
    id INT IDENTITY(1,1) PRIMARY KEY,
    category_id INT,
    name NVARCHAR(255) NOT NULL,
    description NVARCHAR(MAX),   
    price DECIMAL(18, 0) NOT NULL, 
    image NVARCHAR(255),
    is_active BIT DEFAULT 1, 
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (category_id) REFERENCES categories(id) ON DELETE SET NULL
);
GO

-- Bảng Orders
CREATE TABLE orders (
    id INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT,
    total_money DECIMAL(18, 0),
    shipping_fee DECIMAL(18, 0) DEFAULT 0,
    status VARCHAR(20) DEFAULT 'Pending',
    payment_method NVARCHAR(50), 
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (user_id) REFERENCES users(id),
    CONSTRAINT CK_Orders_Status CHECK (status IN ('Pending', 'Processing', 'Completed', 'Canceled'))
);
GO

-- Bảng Order Details
CREATE TABLE order_details (
    id INT IDENTITY(1,1) PRIMARY KEY,
    order_id INT NOT NULL,
    product_id INT NOT NULL,
    quantity INT NOT NULL,
    unit_price DECIMAL(18, 0) NOT NULL,
    FOREIGN KEY (order_id) REFERENCES orders(id) ON DELETE CASCADE, 
    FOREIGN KEY (product_id) REFERENCES products(id)
);
GO

-- Bảng Shipping Info
CREATE TABLE shipping_info (
    id INT IDENTITY(1,1) PRIMARY KEY,
    order_id INT UNIQUE, 
    recipient_name NVARCHAR(100) NOT NULL, 
    phone_number VARCHAR(20) NOT NULL,
    address NVARCHAR(MAX) NOT NULL, 
    notes NVARCHAR(MAX), 
    FOREIGN KEY (order_id) REFERENCES orders(id) ON DELETE CASCADE
);
GO

-- =================================================================
-- INSERT DỮ LIỆU MẪU
-- =================================================================

INSERT INTO users (username, password, full_name, role, email) 
VALUES ('admin', '123456', N'Quản Trị Viên', 'admin', 'admin@example.com');

INSERT INTO users (username, password, full_name, role, email) 
VALUES ('khachhang', '123456', N'Nguyễn Văn A', 'user', NULL);

INSERT INTO categories (name, code) VALUES (N'Bánh Mochi', 'mochi');
INSERT INTO categories (name, code) VALUES (N'Bánh Tart', 'tart');

INSERT INTO products (category_id, name, price, description) 
VALUES (1, N'Mochi Trà Xanh', 25000, N'Vị trà xanh Nhật Bản thơm ngon');

INSERT INTO products (category_id, name, price, description) 
VALUES (2, N'Tart Trứng', 15000, N'Bánh tart trứng nướng giòn rụm');
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