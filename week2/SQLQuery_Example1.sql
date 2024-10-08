-- Create a schema for organizing your tables
CREATE SCHEMA proj1;
GO
-- 'GO' keyword here to separate the commands, otherwise create schema will have red underlines

-- Create a table in the schema proj1 called Owners
CREATE TABLE proj1.Owners(
    id int PRIMARY KEY IDENTITY(1,3),
    name VARCHAR(255) NOT NULL,
    phone VARCHAR(10) UNIQUE,
    address VARCHAR(255) UNIQUE
);

-- Create a table in the schema proj1 called Pets 
CREATE TABLE proj1.Pets(
    id int PRIMARY KEY IDENTITY,
    name VARCHAR(255) NOT NULL,
    animal_type VARCHAR(255) NOT NULL,
    age int check (age > 0),
    birthday DATE DEFAULT getdate(),
    ownerID int FOREIGN KEY REFERENCES proj1.Owners(id) ON DELETE CASCADE
);

-- Drop both table, dropping pets first due to foreign key constraint
DROP TABLE proj1.Pets;
DROP TABLE proj1.Owners;

-- Insert Kung and Vlada into the DB
INSERT INTO proj1.Owners VALUES ('Kung', '8888675309', '1 one st, USA');
INSERT INTO proj1.Owners VALUES ('Vlada', '8888675310', '12 one st, USA');

-- Insert Nyla and Horizon pets into DB
INSERT INTO proj1.Pets VALUES ('Nyla', 'Cat', 12, '2012-10-11', 1);
INSERT INTO proj1.Pets (name, animal_type, age, ownerID) VALUES ('Horizon', 'Dog', 1, 4);

-- This insert will fail age check
INSERT INTO proj1.Pets (name, animal_type, age, ownerID) VALUES ('Horizon', 'Dog', -1, 2);

-- Deleting Kung will cascade down and delete Nyla as well
DELETE FROM proj1.Owners WHERE name = 'Kung';

-- Select every column from pets table
SELECT * FROM proj1.Pets;
SELECT * FROM proj1.Owners;

-- Rename id from owner table to ownerID  
EXEC sp_rename 'proj1.Owners.id', 'ownerID', 'COLUMN';
-- Renam id from pet table to petID
EXEC sp_rename 'proj1.Pets.id', 'petID', 'COLUMN';

ALTER TABLE proj1.Owners
ALTER COLUMN name VARCHAR(10);

INSERT INTO proj1.Owners VALUES ('Kung5678901', '8888675309', '1 one st, USA');