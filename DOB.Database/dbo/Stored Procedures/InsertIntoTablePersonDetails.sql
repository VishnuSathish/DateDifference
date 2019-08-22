 CREATE procedure [dbo].[InsertIntoTablePersonDetails]
 @PersonName VARCHAR(30),
 @PersonDob DATE,
 @PersonAge INT
 as
 begin
 insert into PersonDetails(PersonName,PersonDob,PersonAge) values (@PersonName,@PersonDob,@PersonAge);
 end