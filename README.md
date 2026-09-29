# 🛒 eShop – Website bán hàng trực tuyến
**eShop** là một dự án website bán hàng trực tuyến được xây dựng nhằm phục vụ quá trình học tập và thực hành lập trình ứng dụng Web.
Dự án được thực hiện bởi **Nguyễn Thị Lưu**, sinh viên ngành **Tin học Kinh tế**, **Khoa Hệ thống Thông tin Kinh tế – Trường Đại học Kinh tế, Đại học Huế**.

## 👨‍💻 Thông tin dự án
* **Tên dự án:** eShop
* **Tác giả:** Nguyễn Thị Lưu
* **Ngành:** Tin học Kinh tế
* **Trường:** Trường Đại học Kinh tế – Đại học Huế
* **Khoa:** Hệ thống Thông tin Kinh tế
* **Mục đích:** Học tập và thực hành phát triển ứng dụng Web

## 🛠️ Công nghệ sử dụng
Dự án được phát triển với các công nghệ chính:
* **C#**
* **.NET 8**
* **Blazor**
* **Dapper**
* **SQL Server**
* **Bootstrap**
* **Visual Studio**
* **Git / GitHub**

## 📌 Chức năng chính
Dự án tập trung xây dựng các chức năng cơ bản của một hệ thống bán hàng trực tuyến, bao gồm:
* Xem danh sách sản phẩm
* Tìm kiếm sản phẩm
* Xem thông tin chi tiết sản phẩm
* Thêm sản phẩm vào giỏ hàng
* Cập nhật số lượng sản phẩm trong giỏ hàng
* Xóa sản phẩm khỏi giỏ hàng
* Thực hiện đặt hàng
* Quản lý đơn hàng
* Xem chi tiết đơn hàng
* Đăng nhập và đăng xuất
* Phân quyền người dùng
* Chức năng dành cho quản trị viên

## 🏗️ Cấu trúc dự án
Dự án được tổ chức theo hướng phân tách các thành phần nhằm thuận tiện cho việc phát triển và bảo trì:
```text
eShop
│
├── eShop.UseCases
│   └── Xử lý các nghiệp vụ của hệ thống
│
├── eShop.Web
│   └── Ứng dụng Web và giao diện người dùng
│
├── eShop.Web.Modules
│   └── Các module/chức năng của ứng dụng
│
├── e_Shop.CoreBusiness
│   └── Các model và thành phần nghiệp vụ cốt lõi
│
├── Plugins
│   └── Các thành phần kết nối và triển khai chức năng
│
├── DemoDapper
│   └── Thực hành kết nối và thao tác dữ liệu với Dapper
│
└── eShop.sln
    └── Solution quản lý toàn bộ các project

### Các thành phần chính
- **eShop.UseCases:** Xử lý các nghiệp vụ của hệ thống
- **eShop.Web:** Ứng dụng Web và giao diện người dùng
- **eShop.Web.Modules:** Các module chức năng
- **e_Shop.CoreBusiness:** Các thành phần nghiệp vụ cốt lõi
- **Plugins:** Các thành phần hỗ trợ hệ thống
- **DemoDapper:** Thực hành kết nối và thao tác cơ sở dữ liệu với Dapper

## 💾 Cơ sở dữ liệu
Dự án sử dụng **SQL Server** để lưu trữ dữ liệu và **Dapper** để thực hiện các thao tác truy vấn cơ sở dữ liệu.

## 📚 Mục tiêu học tập
Thông qua dự án, tác giả thực hành:
- Phát triển Web với **Blazor**
- Lập trình **C# / .NET**
- **Dependency Injection** và **Blazor Components**
- Quản lý trạng thái ứng dụng
- Kết nối và thao tác cơ sở dữ liệu
- Xây dựng nghiệp vụ bán hàng
- Xác thực và phân quyền
- Quản lý mã nguồn với **Git / GitHub**

## 👤 Tác giả
**Nguyễn Thị Lưu**
🎓 **Ngành:** Tin học Kinh tế  
🏫 **Khoa:** Hệ thống Thông tin Kinh tế  
🏛️ **Trường:** Trường Đại học Kinh tế – Đại học Huế  
🔗 **GitHub:** [nguyenluu-jpg](https://github.com/nguyenluu-jpg)
---
> Dự án được thực hiện với mục đích học tập và thực hành phát triển ứng dụng Web.
