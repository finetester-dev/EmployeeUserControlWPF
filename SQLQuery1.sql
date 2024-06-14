CREATE database WPFEmployeeCustomer
Use  WPFEmployeeCustomer

--drop table Deparment
create table Deparment
(DepartmentId int Primary key identity(1,1),
Name varchar(100))

--drop table EmployeeDepartment
CREATE TABLE EmployeeDepartment
(EmployeeDepartmentId INT PRIMARY KEY IDENTITY(1,1),
DepartmentId INT, 
EmployeeId INT,
FOREIGN KEY (DepartmentId) REFERENCES Deparment(DepartmentId),
FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId)
)

--drop table Employee
create table Employee
(EmployeeId INT PRIMARY KEY IDENTITY(1,1),
Name varchar(100),
DOB Date,
Salary varchar(MAX)
);
