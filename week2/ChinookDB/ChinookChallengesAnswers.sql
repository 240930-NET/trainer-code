-- On the Chinook DB, practice writing queries with the following exercises

-- BASIC CHALLENGES
-- List all customers (full name, customer id, and country) who are not in the USA
SELECT FirstName + ' ' + LastName AS full_name, CustomerId, Country 
FROM Customer 
WHERE Country != 'USA';

SELECT CONCAT(FirstName,' ', LastName) AS full_name, CustomerId, Country 
FROM Customer 
WHERE Country != 'USA'; -- Guillame B.
    
-- List all customers from Brazil
SELECT * 
FROM Customer c
WHERE c.Country = 'Brazil';
    
-- List all sales agents
SELECT * 
FROM Employee e
WHERE e.Title LIKE '%Agent';

-- Retrieve a list of all countries in billing addresses on invoices
SELECT DISTINCT(i.BillingCountry) 
FROM Invoice i;

-- Retrieve how many invoices there were in 2009, and what was the sales total for that year?
SELECT COUNT(i.InvoiceId) AS 'Number of invoices', SUM(i.Total) AS Total 
FROM Invoice i
WHERE YEAR(InvoiceDate) = 2009;

    -- (challenge: find the invoice count sales total for every year using one query)
    SELECT DISTINCT(YEAR(i.InvoiceDate)) AS 'Year', COUNT(i.InvoiceId) AS 'Number of invoices', SUM(i.Total) AS Total 
    FROM Invoice i
    GROUP BY YEAR(i.InvoiceDate);

-- how many line items were there for invoice #37
SELECT COUNT(i.InvoiceId) AS 'Number of items' 
FROM Invoice i
INNER JOIN InvoiceLine il ON i.InvoiceId = il.InvoiceId
WHERE i.InvoiceId = 37;

-- how many invoices per country? BillingCountry  # of invoices -
SELECT i.BillingCountry, COUNT(i.BillingCountry) AS 'Count'
FROM Invoice i
GROUP BY i.BillingCountry;

-- Retrieve the total sales per country, ordered by the highest total sales first.
SELECT i.BillingCountry, SUM(i.Total) AS 'Total'
FROM Invoice i
GROUP BY i.BillingCountry
ORDER BY 'Total' DESC;


-- JOINS CHALLENGES
-- Every Album by Artist
SELECT a.Title, b.Name 
FROM Album a
LEFT JOIN Artist b ON a.ArtistId = b.ArtistId;

-- All songs of the rock genre
SELECT t.Name, g.Name AS Genre
FROM Track t
LEFT JOIN Genre g on t.GenreId = g.GenreId
WHERE g.Name = 'Rock';

-- Show all invoices of customers from brazil (mailing address not billing)
SELECT * 
FROM Invoice i
INNER JOIN Customer c ON i.CustomerId = c.CustomerId
WHERE c.Country = 'Brazil';

-- Show all invoices together with the name of the sales agent for each one
SELECT i.InvoiceId, i.InvoiceDate, c.CustomerId, c.FirstName + ' ' + c.LastName AS 'Customer Name', e.EmployeeId, e.FirstName + ' ' + e.LastName AS 'Agent Name', e.Title
FROM Invoice i
INNER JOIN Customer c ON i.CustomerId = c.CustomerId
INNER JOIN Employee e ON c.SupportRepId = e.EmployeeId;

-- Which sales agent made the most sales in 2009?
    --This questions is a bit ambiguous. What does 'most sales' mean?

    --This answer give the sales rep with the most invoices for 2009
    SELECT TOP(1) e.EmployeeId, e.FirstName + ' ' + e.LastName AS 'Agent Name', COUNT(i.InvoiceId) AS 'Number of invoice for 2009'
    FROM Invoice i
    INNER JOIN Customer c ON i.CustomerId = c.CustomerId
    INNER JOIN Employee e ON c.SupportRepId = e.EmployeeId
    WHERE YEAR(i.InvoiceDate) = 2009
    GROUP BY e.EmployeeId, e.FirstName, e.LastName
    ORDER BY 'Number of invoice for 2009' DESC;

    --This answer give the sales rep that made the most revenue in 2009 eg. made the most total from sales
    SELECT TOP(1) e.EmployeeId, e.FirstName + ' ' + e.LastName AS 'Agent Name', SUM(i.Total) AS 'Total revenue for 2009'
    FROM Invoice i
    INNER JOIN Customer c ON i.CustomerId = c.CustomerId
    INNER JOIN Employee e ON c.SupportRepId = e.EmployeeId
    WHERE YEAR(i.InvoiceDate) = 2009
    GROUP BY e.EmployeeId, e.FirstName, e.LastName
    ORDER BY 'Total revenue for 2009' DESC;

-- How many customers are assigned to each sales agent?
SELECT e.EmployeeId, e.FirstName + ' ' + e.LastName AS 'Agent Name', COUNT(c.CustomerId) AS 'Number of customers'
FROM Employee e
INNER JOIN Customer c ON e.EmployeeId = c.SupportRepId
GROUP BY e.EmployeeId, e.FirstName, e.LastName

-- Which track was purchased the most in 2010?
    --Technically the answer is none of them, without the TOP(1) the query shows that all tracks purchased in 2010 was only ever purchased once
    SELECT TOP(1) COUNT(il.TrackId) AS 'TrackID'
    FROM Invoice i
    INNER JOIN InvoiceLine il ON i.InvoiceId = il.InvoiceId
    WHERE YEAR(i.InvoiceDate) = 2010
    GROUP BY il.TrackId
    ORDER BY 'TrackID' DESC

-- Show the top three best selling artists.
SELECT TOP(3) a.NAME, SUM(il.Quantity * il.UnitPrice) AS 'Total Sold'
FROM Artist a
INNER JOIN Album al ON a.ArtistId = al.ArtistId
INNER JOIN Track t ON al.AlbumId = t.AlbumId
INNER JOIN InvoiceLine il ON t.TrackId = il.InvoiceLineId
GROUP BY a.Name
ORDER BY 'Total Sold' DESC

-- Which customers have the same initials as at least one other customer?
    --Note: this one took me quite a lot of googling to figure out, lol
    SELECT c.FirstName + ' ' + c.LastName AS 'Name'
    FROM Customer c
    INNER JOIN(
        SELECT SUBSTRING(c1.FirstName, 1, 1) + SUBSTRING(c1.LastName, 1, 1) AS 'Initials'
        FROM Customer c1
        GROUP BY SUBSTRING(c1.FirstName, 1, 1) + SUBSTRING(c1.LastName, 1, 1)
        HAVING COUNT(*) > 1
    ) AS Grouped ON SUBSTRING(c.FirstName, 1, 1) + SUBSTRING(c.LastName, 1, 1) = Grouped.Initials
    ORDER BY c.FirstName, c.LastName

-- ADVACED CHALLENGES
-- solve these with a mixture of joins, subqueries, CTE, and set operators.
-- solve at least one of them in two different ways, and see if the execution
-- plan for them is the same, or different.

-- 1. which artists did not make any albums at all?
SELECT a.name from Artist a
LEFT JOIN Album b ON a.ArtistId = b.ArtistId
WHERE b.AlbumId is null;

-- 2. which artists did not record any tracks of the Latin genre?
SELECT a.Name
FROM Artist a
LEFT JOIN Album al ON a.ArtistId = al.ArtistId
LEFT JOIN Track t ON al.AlbumId = t.AlbumId
LEFT JOIN Genre g ON t.GenreId = g.GenreId
WHERE g.Name != 'Latin' OR g.Name IS NULL
GROUP BY a.Name;

-- 3. which video track has the longest length? (use media type table)
SELECT TOP(1) *
FROM Track t
INNER JOIN MediaType m ON t.MediaTypeId = m.MediaTypeId
WHERE t.MediaTypeId = 3
ORDER BY t.Milliseconds DESC;

-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)
SELECT c.FirstName + ' ' + c.LastName AS 'Name'
FROM Customer c
INNER JOIN Employee e ON c.City = e.City
WHERE e.ReportsTo IS NULL;

-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?
SELECT COUNT(il.TrackID) AS 'Number of tracks', SUM(il.Quantity * il.UnitPrice) AS 'Total'
FROM InvoiceLine il
INNER JOIN Invoice i ON il.InvoiceId = i.InvoiceId
INNER JOIN Customer c ON i.CustomerId = c.CustomerId
WHERE c.Country = 'Germany';

-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.
SELECT c.FirstName + ' ' + c.LastName AS 'Name', c.Country
FROM Customer c
INNER JOIN Employee e ON c.SupportRepId = e.EmployeeId
WHERE DATEDIFF(YEAR, e.BirthDate, e.HireDate) < 35

-- DML exercises

-- 1. insert two new records into the employee table.

-- 2. insert two new records into the tracks table.

-- 3. update customer Aaron Mitchell's name to Robert Walter

-- 4. delete one of the employees you inserted.

-- 5. delete customer Robert Walter.
