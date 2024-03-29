  # TLGK-Web

## Các thành viên trong nhóm:
- 52100014 - Nguyễn Thành Hồng Đức
- 52100572 - Lê Trần Phú

## Giới thiệu sơ lược
Báo cáo và source code cho bài tiểu luận giữa kỳ môn học Lập trình web và Ứng dụng.

Được xây dựng bằng:
- C# (ASP.NET Core)
- Microsoft SQL Server
- Bootstrap
- jQuery
- Azure Server

Các công nghệ được sử dụng trong project:
- ASP.NET Entity Framework
- Cách sử dụng Entity Framework:
  - Sau khi mở project bằng Visual Studio
  - Ta nhấn chuột phải vào project, chọn Manage NuGet Packages
  -  Ta cần cài đặt các package sau:
    - Microsoft.EntityFrameworkCore.Tools
    - Microsoft.EntityFrameworkCore.SqlServer
    - Microsoft.EntityFrameworkCore
  - Sau khi cài đặt hoàn tất, trên thanh tiêu đề, chọn Tools -> NuGet Package Manager -> Package Manager Console
  - Sử dụng đoạn mã "Scaffold-DbContext "Server={YourServer}; Database=FuhoWeb;Integrated Security=true;TrustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models"
  - Đoạn mã trên sẽ tự động tạo các Models cũng như DbContext cho toàn bộ database.


## Cấu trúc project:
- Tập tin: chứa nội dung của bài báo cáo cho toàn bộ đề tài.
- Thư mục source: chứa tất cả mã nguồn, thư viện, file dữ liệu và các tập tin cần thiết khác.
- Phiếu tự đánh giá: TuDanhGia.docx

# Getting Started
- Link video demo:
  - GG Drive: https://drive.google.com/file/d/1nvvOPawfCRrOudz5BjAfJ40ThF2JuLDn/view?usp=sharing
  - Youtube: https://youtu.be/5P2j8uHEtGQ
- Trang web được triển khai tại: https://fuhoweb.azurewebsites.net/

## Cách triển khai website trên máy local
Cài đặt môi trường và phần mềm hỗ trợ:
- Cài đặt Visual Studio 2022: https://visualstudio.microsoft.com/vs/
- Cài đặt SQL Server: https://www.microsoft.com/en-us/sql-server/sql-server-downloads
- Cài đặt Microsoft SQL Server Management Studio: https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16 

Các bước thực hiện:
- Sau khi giải nén bài nộp, trong đó sẽ có folder project và file database data.sql.
- Sử dụng Microft SQL Server Manager để tạo database bằng cách copy data.sql vào new querry.
- Mở project bằng Visual Studio, config câu lệnh kết nối với server lại cho phù hợp với máy local.
- Nhấn khởi chạy chương trình.
