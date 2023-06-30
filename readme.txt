- run Project
dotnet run

- hot reload
Install Razor runtime compilation using 
https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation/

dotnet add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation --version 5.0.13

add in program.cs
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

add-migration <migration-name>
- สร้างไฟล์ migration ที่เก็บโครงสร้างตารางจากโมเดล (แปลงโมเดลเป็นตาราง)

update-database
- นำไฟล์ migration ไปใช้งาน

dotnet tool install --global dotnet-ef
ใน *VSCode*

dotnet ef migrations add <migration-name>

dotnet ef database update
