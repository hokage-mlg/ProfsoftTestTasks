USE master;  
GO  

--Delete the ProfsoftTest database if it exists.  
IF EXISTS(SELECT * from sys.databases WHERE name='ProfsoftTest')  
BEGIN  
    DROP DATABASE ProfsoftTest;  
END  

--Create a new database called ProfsoftTest.  
CREATE DATABASE ProfsoftTest;
GO

use ProfsoftTest;
GO

/*
Задание 6. Дан двумерный массив [[1, a], [2, b], [3, c]].
Написать запрос, создающию таблицу в БД, возвращающую данный массив запросом
SELECT * FROM table_name WHERE 1;
*/

/*
I did not quite understand the task. There was an assumption that it was necessary to make JSON parser,
however, since the rest of the tasks were easy, I decided to choose a simple option.
Since the array must be returned in its entirety and there are no additional actions,
I think the use of parser will be superfluous. Hopefully this version will suit...
*/

-- Creating a table with arrays.
CREATE TABLE dbo.Task6
(ID int PRIMARY KEY NOT NULL,
Array nvarchar(25) NOT NULL)
GO

-- Filling a table with data.
INSERT INTO Task6(ID,Array)
VALUES (1, '[[1, a], [2, b], [3, c]]')
GO

-- Select table data.
SELECT * FROM Task6 WHERE 1=1;

/*Задание 7. Даны две таблицы. Необходимо выбрать сотрудников из отдела Research.*/

-- Creating a table with employees.
CREATE TABLE dbo.Task7_employee
(ID int PRIMARY KEY NOT NULL,
name nvarchar(25) NOT NULL,
department int NOT NULL)
GO

-- Creating a table with departments.
CREATE TABLE dbo.Task7_department
(ID int PRIMARY KEY NOT NULL,
name nvarchar(25) NOT NULL)
GO

-- Filling a employees table with data.
INSERT INTO Task7_employee(ID, name, department)
VALUES (1, 'Иванов', 1)
INSERT INTO Task7_employee(ID, name, department)
VALUES (2, 'Петров', 1)
INSERT INTO Task7_employee(ID, name, department)
VALUES (3, 'Сидоров', 2)
GO

-- Filling a departments table with data.
INSERT INTO Task7_department(ID, name)
VALUES (1, 'Research')
INSERT INTO Task7_department(ID, name)
VALUES (2, 'Analytic')
GO

-- Selecting employees from Research department.
SELECT e.ID, e.name, d.name AS department
FROM Task7_employee e
INNER JOIN Task7_department d ON e.department = d.ID
WHERE d.name='Research';

/*Задание 8. Дана таблица. Необходимо выбрать сотрудников, не являющихся ни чьими руководителями.*/

-- Creating a table with employees.
CREATE TABLE dbo.Task8
(ID int PRIMARY KEY NOT NULL,
name nvarchar(25) NOT NULL,
chief int NULL)
GO

-- Filling a employees table with data.
INSERT INTO Task8(ID, name, chief)
VALUES (1, 'Иванов', NULL)
INSERT INTO Task8(ID, name, chief)
VALUES (2, 'Петров', 1)
INSERT INTO Task8(ID, name, chief)
VALUES (3, 'Сидоров', 2)
GO

-- Selecting of employees who are not any managers.
SELECT name FROM Task8
WHERE ID NOT IN 
(SELECT DISTINCT chief
FROM Task8
WHERE chief IS NOT NULL)
