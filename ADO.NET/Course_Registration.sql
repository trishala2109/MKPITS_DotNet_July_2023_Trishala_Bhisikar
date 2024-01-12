CREATE TABLE TableNation(NationID INT PRIMARY KEY,
                         NationName VARCHAR(500))

INSERT INTO TableNation VALUES(1,'India'),
                              (2,'US')

CREATE TABLE TableState(StateID INT PRIMARY KEY,
                        NationID INT,
						StateName VARCHAR(500),
						FOREIGN KEY (NationID) REFERENCES TableNation(NationID))

INSERT INTO TableState VALUES(101,1,'Maharashta'),
                             (102,1,'Uttarpardesh'),
							 (103,2,'California'),
							 (104,2,'London')

CREATE TABLE TableCity(CityID INT,
                       StateID INT,
					   CityName VARCHAR(500),
					   FOREIGN KEY (StateID) REFERENCES TableState (StateID))

INSERT INTO TableCity VALUES(201,101,'Nagpur'),
                            (202,101,'Pune'),
							(203,101,'Mumbai'),
							(204,102,'Delhi'),
							(205,102,'Kanpur'),
							(206,103,'Kuku'),
							(207,103,'Havre'),
							(208,104,'Maxico'),
							(209,104,'Disneyland')

CREATE TABLE TableCourseRegDetail(CourseRegID INT PRIMARY KEY IDENTITY,
                                  CategoryInd INT,
								  FullName VARCHAR(1500),
								  GenderInd INT)

CREATE TABLE TableRegAddress(RegAddressID INT IDENTITY,
                             CourseRegID INT,
							 NationID INT,
							 StateID INT,
							 CityID INT,
							 FOREIGN KEY (CourseRegID) REFERENCES TableCourseRegDetail(CourseRegID),
							 FOREIGN KEY (NationID) REFERENCES TableNation(NationID))

CREATE TABLE TableFeeDetail(FeeID INT IDENTITY,
                            CourseRegID INT,
							TotalAmount Decimal(10,2),
							MinPer Decimal (10,2),
							PaidAmount Decimal(10,2),
							BalAmount Decimal(10,2),
							PaidDate DateTime,
							FOREIGN KEY (CourseRegID) REFERENCES TableCourseRegDetail (CourseRegID))

SELECT * FROM TableNation
SELECT * FROM TableState
SELECT * FROM TableCity
SELECT * FROM TableCourseRegDetail
SELECT * FROM TableRegAddress 
SELECT * FROM TableFeeDetail

DROP TABLE TableCourseRegDetail
DROP TABLE TableFeeDetail
DROP TABLE TableRegAddress