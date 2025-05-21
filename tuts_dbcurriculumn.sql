-- Use the database
USE tuts_dbcurriculumn;

-- Insert 3 records into tblcourse
INSERT INTO tblcourse (Course) VALUES
('Computer Science'),
('Information Technology'),
('Software Engineering');

-- Insert 3 records into tblstudent
INSERT INTO tblstudent (IdNo, Firstname, Lastname, MI, HomeAddress, Sex, CourseId, YearLevel, StudentPhoto) VALUES
('STU20251000', 'John', 'Doe', 'A', '123 Main St, City', 'Male', 1, 'First', 'john_doe.jpg'),
('STU20251001', 'Jane', 'Smith', 'B', '456 Oak Ave, Town', 'Female', 2, 'Second', 'jane_smith.jpg'),
('STU20251002', 'Michael', 'Brown', 'C', '789 Pine Rd, Village', 'Male', 3, 'Third', 'michael_brown.jpg');

-- Insert 3 records into tblsubject
INSERT INTO tblsubject (Subject, DescriptiveTitle, LecUnit, LabUnit, CourseId, Semester, YearLevel, PreRequisite, Level) VALUES
('CS101', 'Introduction to Programming', '3', '1', 1, 'First', 'First', 'None', 1),
('IT201', 'Database Management Systems', '3', '2', 2, 'Second', 'Second', 'CS101', 2),
('SE301', 'Software Design Patterns', '3', '1', 3, 'First', 'Third', 'IT201', 3);

-- Insert 3 records into tblgrades
INSERT INTO tblgrades (CourseId, IdNo, SubjectId, YearLevel, Sem, Grades) VALUES
(1, 'STU20251000', 1, 'First', 'First', 2.75),
(2, 'STU20251001', 2, 'Second', 'Second', 3.00),
(3, 'STU20251002', 3, 'Third', 'First', 2.50);

-- Insert 3 records into tblprerequisite
INSERT INTO tblprerequisite (SubjectId, Pre1, Pre2, Pre3, Pre4, Pre5, Pre6, Pre7, Pre8, Pre9) VALUES
(1, 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None'),
(2, 'CS101', 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None'),
(3, 'IT201', 'CS101', 'None', 'None', 'None', 'None', 'None', 'None', 'None');

-- Insert 3 records into tbluseraccount
-- Note: Passwords are hashed using SHA1 as per the frmLogin code (example hashes generated for simplicity)
INSERT INTO tbluseraccount (Fullname, User_name, Pass, UserType) VALUES
('Admin One', 'admin', SHA1('admin'), 'Administrator'),
('Teacher Two', 'teacher2', SHA1('password2'), 'Teacher'),
('Staff Three', 'staff3', SHA1('password3'), 'Staff');

-- Insert 3 records into tblautonumber
INSERT INTO tblautonumber (STRT, END, INCREMENT, DESCRIPTION) VALUES
('STU', 1003, 1, 'StudentID'),
('SUB', 1000, 1, 'SubjectID'),
('TRN', 1000, 1, 'TransactionID');

-- Insert 3 records into tblauto
INSERT INTO tblauto (id, autoend) VALUES
(1, 1004),
(3, 1005);



