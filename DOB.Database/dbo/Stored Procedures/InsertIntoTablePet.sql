 CREATE procedure [dbo].[InsertIntoTablePet]
 @PersonName VARCHAR(30),
 @PersonDob DATE,
 @PersonAge INT,
 @PetBreed VARCHAR(30)
 as
 begin
 insert into PersonDetails(PersonName,PersonDob,PersonAge) values(@PersonName,@PersonDob,@PersonAge);
 declare @Id INT = scope_identity()
 insert into Pet (Id,PetBreed) values (@Id, @PetBreed);
 end