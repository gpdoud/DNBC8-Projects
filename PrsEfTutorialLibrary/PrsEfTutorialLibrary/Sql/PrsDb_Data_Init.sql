use PrsEfDb8;
go
INSERT into Users (Username, Password, Firstname, Lastname, Phone, Email, IsReviewer, IsAdmin)
		VALUES ('sa', 'sa', 'System', 'Admin', '911', 'urgent@help.com', 1, 1);
INSERT into Users (Username, Password, Firstname, Lastname, Phone, Email, IsReviewer, IsAdmin)
		VALUES ('rv', 'rv', 'System', 'Reviewer', '611', 'reviewer@help.com', 1, 0);
INSERT into Users (Username, Password, Firstname, Lastname, Phone, Email, IsReviewer, IsAdmin)
		VALUES ('us', 'us', 'System', 'User', '411', 'user@help.com', 0, 0);
go
SELECT * from Users;
go
INSERT into Vendors (Code, Name, Address, City, State, Zip, Phone, Email)
		VALUES ('AMAZ', 'Amazon', '1 Amazon Way', 'Seattle', 'WA', '12345', '748-555-1212', 'info@amazon.com');
INSERT into Vendors (Code, Name, Address, City, State, Zip, Phone, Email)
		VALUES ('TARG', 'Target', 'Target St.', 'Minneapolic', 'MN', '54321', '489-555-1212', 'info@target.com');
INSERT into Vendors (Code, Name, Address, City, State, Zip, Phone, Email)
		VALUES ('WALM', 'Walmart', '1 Walmart Dr.', 'Bentonville', 'AR', '56789', '395-555-1212', 'info@walmart.com');
go
SELECT * from Vendors;
go