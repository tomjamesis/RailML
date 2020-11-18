CREATE TABLE [dbo].[TBooking]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBookingId]	BIGINT			NOT NULL,
	[BookingNumber]NVARCHAR(MAX)	NOT NULL,
	[PosInFormation]	NVARCHAR(MAX)	NOT NULL,
	[VehicleRef]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TBookingId] PRIMARY KEY CLUSTERED ([TBookingId] ASC)
);
