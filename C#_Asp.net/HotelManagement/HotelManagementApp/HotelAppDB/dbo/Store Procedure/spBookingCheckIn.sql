CREATE PROCEDURE [dbo].[spBookingCheckIn]
	@id int
AS
begin

	update dbo.Bookings
	set CheckedIn = 1
	where Id = @id;
end