-- creating database make sure database is pointed as master
CREATE DATABASE MyProject;

-- creating an expense table
CREATE TABLE Expenses(
    id int PRIMARY KEY IDENTITY,
    expenseName VARCHAR(255),
    amount DECIMAL(10,2),
    description VARCHAR(512) 
);

-- inserting data into the table
INSERT INTO Expenses VALUES('Electricity', 100.50, 'It was hot');
INSERT INTO Expenses VALUES(null, null, null);
INSERT INTO Expenses (expenseName, description) VALUES ('Vacation', 'It was fun');

-- selecting all columns from Expenses table
SELECT * FROM Expenses;