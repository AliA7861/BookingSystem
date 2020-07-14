CREATE PROC MonthlyBookings
AS

	BEGIN

		SELECT COUNT(BookingID) AS 'No. of Bookings'
		,DATEPART(MM, [Date]) AS 'Month'
		FROM	[dbo].[BookingTBL]
		GROUP BY DATEPART(MM, [Date])

	END