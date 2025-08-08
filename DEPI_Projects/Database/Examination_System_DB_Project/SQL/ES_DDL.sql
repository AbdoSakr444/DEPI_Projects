CREATE DATABASE Examination_System_DB;

USE Examination_System_DB; 


CREATE TABLE Students (		  
    ID INT NOT NULL PRIMARY KEY,
    First_Name NVARCHAR(255) NOT NULL,
    Last_Name NVARCHAR(255) NOT NULL,
    Phone NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    BOD DATE NOT NULL,
    Training_Manager_ID INT NOT NULL,
    User_Acount_ID INT NOT NULL
);

CREATE TABLE Training_Manager (
    ID INT NOT NULL PRIMARY KEY,
    First_Name NVARCHAR(255) NOT NULL,
    Last_Name NVARCHAR(255) NOT NULL,
    Phone NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Hire_Date DATE NOT NULL,
    User_Acount_ID INT NOT NULL
);

CREATE TABLE User_Acount (
    ID INT NOT NULL PRIMARY KEY,
    User_Name NVARCHAR(255) NOT NULL,
    Password_Hash NVARCHAR(255) NOT NULL,
    Role_Name BIGINT NOT NULL
);

CREATE TABLE Instructor (
    ID INT NOT NULL PRIMARY KEY,
    First_Name NVARCHAR(255) NOT NULL,
    Last_Name NVARCHAR(255) NOT NULL,
    Phone NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Hire_Date DATE NOT NULL,
    User_Acount_ID INT NOT NULL
);

CREATE TABLE Track (
    ID BIGINT NOT NULL PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Department NVARCHAR(255) NOT NULL,
    Training_Manager_ID INT NOT NULL
);

CREATE TABLE Branch (
    ID INT NOT NULL PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Training_Manager_ID INT NOT NULL
);

CREATE TABLE Intake (
    ID INT NOT NULL PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Year INT NOT NULL,
    Training_Manager_ID INT NOT NULL
);

CREATE TABLE Exam (
    ID INT NOT NULL PRIMARY KEY,
    Type NVARCHAR(255) NOT NULL,
    Year INT NOT NULL,
    Start_Time TIME NOT NULL,
    End_Time TIME NOT NULL,
    Course_ID INT NOT NULL
);

CREATE TABLE Students_Exams (
    ID BIGINT NOT NULL PRIMARY KEY,
    Student_ID INT NOT NULL,
    Exam_ID INT NOT NULL,
    Total_Degree DECIMAL(8, 2) NOT NULL
);

CREATE TABLE Course (
    ID INT NOT NULL PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Min_Degree INT NOT NULL,
    Max_Degree INT NOT NULL,
    Description NVARCHAR(255) NOT NULL,
    Instructor_ID INT NOT NULL
);

CREATE TABLE Students_Courses (
    ID INT NOT NULL PRIMARY KEY,
    Student_ID INT NOT NULL,
    Course_ID INT NOT NULL
);

CREATE TABLE Questions (
    ID INT NOT NULL PRIMARY KEY,
    Correct_Answer NVARCHAR(255) NOT NULL,
    Question_Text NVARCHAR(255) NOT NULL,
    Question_Type NVARCHAR(255) NOT NULL,
    Question_Degree DECIMAL(8, 2) NOT NULL
);

CREATE TABLE Exam_Questions (
    ID INT NOT NULL PRIMARY KEY,
    Question_ID INT NOT NULL,
    Exam_ID INT NOT NULL
);

CREATE TABLE Answer_Options (
    ID INT NOT NULL PRIMARY KEY,
    Option_Text NVARCHAR(255) NOT NULL,
    IS_Correct BIT NOT NULL
);

CREATE TABLE Questions_Options (
    ID INT NOT NULL PRIMARY KEY,
    Question_ID INT NOT NULL,
    Answer_Option_ID INT NOT NULL
);

CREATE TABLE Student_Answers (
    ID INT NOT NULL PRIMARY KEY,
    Answer_Text NVARCHAR(255),
    Question_ID INT NOT NULL
);


ALTER TABLE Intake ADD CONSTRAINT fk_in_tm FOREIGN KEY(Training_Manager_ID) REFERENCES Training_Manager(ID);
ALTER TABLE Course ADD CONSTRAINT fk_cr_ins FOREIGN KEY(Instructor_ID) REFERENCES Instructor(ID);
ALTER TABLE Students ADD CONSTRAINT fk_st_tm FOREIGN KEY(Training_Manager_ID) REFERENCES Training_Manager(ID);
ALTER TABLE Students_Exams ADD CONSTRAINT fk_se_st FOREIGN KEY(Student_ID) REFERENCES Students(ID);
ALTER TABLE Branch ADD CONSTRAINT fk_br_tm FOREIGN KEY(Training_Manager_ID) REFERENCES Training_Manager(ID);
ALTER TABLE Students ADD CONSTRAINT fk_st_usr FOREIGN KEY(User_Acount_ID) REFERENCES User_Acount(ID);
ALTER TABLE Exam_Questions ADD CONSTRAINT fk_eq_q FOREIGN KEY(Question_ID) REFERENCES Questions(ID);
ALTER TABLE Questions_Options ADD CONSTRAINT fk_qo_q FOREIGN KEY(Question_ID) REFERENCES Questions(ID);
ALTER TABLE Questions_Options ADD CONSTRAINT fk_qo_op FOREIGN KEY(Answer_Option_ID) REFERENCES Answer_Options(ID);
ALTER TABLE Students_Courses ADD CONSTRAINT fk_sc_st FOREIGN KEY(Student_ID) REFERENCES Students(ID);
ALTER TABLE Exam_Questions ADD CONSTRAINT fk_eq_ex FOREIGN KEY(Exam_ID) REFERENCES Exam(ID);
ALTER TABLE Instructor ADD CONSTRAINT fk_ins_usr FOREIGN KEY(User_Acount_ID) REFERENCES User_Acount(ID);
ALTER TABLE Students_Exams ADD CONSTRAINT fk_se_ex FOREIGN KEY(Exam_ID) REFERENCES Exam(ID);
ALTER TABLE Exam ADD CONSTRAINT fk_ex_cr FOREIGN KEY(Course_ID) REFERENCES Course(ID);
ALTER TABLE Track ADD CONSTRAINT fk_tr_tm FOREIGN KEY(Training_Manager_ID) REFERENCES Training_Manager(ID);
ALTER TABLE Training_Manager ADD CONSTRAINT fk_tm_usr FOREIGN KEY(User_Acount_ID) REFERENCES User_Acount(ID);
ALTER TABLE Students_Courses ADD CONSTRAINT fk_sc_cr FOREIGN KEY(Course_ID) REFERENCES Course(ID);
ALTER TABLE Student_Answers ADD CONSTRAINT fk_sa_q FOREIGN KEY(Question_ID) REFERENCES Questions(ID);

