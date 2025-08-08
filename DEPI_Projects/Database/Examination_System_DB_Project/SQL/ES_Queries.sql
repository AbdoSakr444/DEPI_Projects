-- Select all students
SELECT * FROM Students;

-- Select a specific student by ID
SELECT * FROM Students WHERE ID = 3;

-- Select students who belong to Training Manager ID 5
SELECT * FROM Students WHERE Training_Manager_ID = 5;

-- Update the phone number of student with ID 2
UPDATE Students
SET Phone = '01009998887'
WHERE ID = 2;


-- Delete student with ID 5
DELETE FROM Students
WHERE ID = 5;


 -- Create a view to show student name and their manager name
CREATE VIEW View_Student_Manager AS
SELECT S.ID AS Student_ID, S.First_Name + ' ' + S.Last_Name AS Student_Name, TM.First_Name + ' ' + TM.Last_Name AS Manager_Name, S.Email
FROM Students S INNER JOIN Training_Manager TM 
ON S.Training_Manager_ID = TM.ID;

SELECT * FROM View_Student_Manager

--  Use CTE to calculate student age
WITH Students_Age AS (
    SELECT ID, First_Name, Last_Name, DATEDIFF(YEAR, BOD, GETDATE()) AS Age
    FROM Students
)
--  Show students older than 22
SELECT * FROM Students_Age
WHERE Age > 22;

--  Create a procedure to get student by ID
CREATE PROCEDURE GetStudentByID @StudentID INT
AS
BEGIN
    SELECT * FROM Students
    WHERE ID = @StudentID;
END;

-- Call the procedure to get student with ID = 3
EXEC GetStudentByID @StudentID = 3;

--  Create a function to calculate age from birth date
CREATE FUNCTION GetStudentAge (@BOD DATE)
RETURNS INT
AS
BEGIN
    RETURN DATEDIFF(YEAR, @BOD, GETDATE());
END;

--  Use the function to show each student's age
SELECT ID, First_Name, dbo.GetStudentAge(BOD) AS Age
FROM Students;

--  Create a trigger to print a message after inserting a student
CREATE TRIGGER trg_AfterInsert_Student
ON Students
AFTER INSERT
AS
BEGIN
    PRINT 'New student has been added!';
END;
