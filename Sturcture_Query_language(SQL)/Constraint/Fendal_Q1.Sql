CREATE TABLE TableNation
                        (NationID INT PRIMARY KEY,
						 NationName VARCHAR(500));

INSERT INTO TableNation VALUES(5255,'India'),
                              (5256,'US'),
							  (5257,'UK'),
							  (5258,'Itli'),
							  (5259,'Japan')
------------------------------------------

CREATE TABLE TableState 
                       (StateID INT PRIMARY KEY,
					    NationID INT,
						StateName VARCHAR(500),
						FOREIGN KEY (NationID)
						REFERENCES TableNation (NationID));

INSERT INTO TableState VALUES(44501,5255,'Maharshta'),
                             (44502,5255,'Maharatra')
INSERT INTO TableState VALUES(44503,5257,'Cliforniya'),
                             (44504,5259,'Tako'),
							 (44505,5256,'DisneyLand')
-----------------------------------------------------

CREATE TABLE TableCity 
                     (CityID INT,
					  StateID INT,
					  CityName VARCHAR(500),
					  FOREIGN KEY (StateID)
					  REFERENCES TableState(StateID));

INSERT INTO TableCity VALUES(440002,44501,'Nagpur'),
                            (490042,44502,'Bhandara'),
							(123456,44505,'kufi')
----------------------------------------

CREATE TABLE TableCourseRegDetail
                                 (CourseRegID INT PRIMARY KEY,
								  CategoryInd INT,
								  FullName VARCHAR(1500),
								  GenderInd INT);

INSERT INTO TableCourseRegDetail VALUES(1,1,'Trishla Bhisikar',101),
                                       (2,2,'Mrunal Gajbhiye',102),
									   (3,3,'Mayuri kale', 103),
									   (4,4,'Vrushali Mohite',104),
									   (5,5,'Priya Matre',105)
-------------------------------------------

CREATE TABLE TableRegAddress 
                            (RegAddressID INT,
							 CourseRegID INT,
							 NationID INT,
							 StateID INT,
							 CityID INT,
							 FOREIGN KEY (CourseRegID) REFERENCES TableCourseRegDetail(CourseRegID),
							 FOREIGN KEY (NationID) REFERENCES TableNation(NationID));
					 
INSERT INTO TableRegAddress VALUES(11,1,5255,44501,440002),
                                  (12,2,5255,44501,440002),
								  (13,3,5256,44505,123456)
-------------------------------------------

CREATE TABLE TableFeeDetail
                            (FeeID INT,
							 CourseRegID INT,
							 TotalAmount Decimal(10,2),
							 MinPer Decimal(10,2),
							 PaidAmount Decimal(10,2),
							 BalAmount Decimal(10,2),
							 PaidDate DateTime
							 FOREIGN KEY (CourseRegID) REFERENCES TableCourseRegDetail(CourseRegID));

INSERT INTO TableFeeDetail VALUES(201,1,65000,5000,5000,60000,2023-12-12),
                                 (202,2,5000,100,100,4900,100)
--------------------------------

SELECT * FROM TableNation
SELECT * FROM TableState
SELECT * FROM TableCity
SELECT * FROM TableCourseRegDetail
SELECT * FROM TableRegAddress
SELECT * FROM TableFeeDetail