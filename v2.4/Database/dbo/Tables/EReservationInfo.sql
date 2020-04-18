CREATE TABLE [dbo].[EReservationInfo]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EReservationInfoId]	BIGINT		NOT NULL,
	[Booking]			BIGINT		NOT NULL,

	CONSTRAINT [PK_EReservationInfoId] PRIMARY KEY CLUSTERED ([EReservationInfoId] ASC),
	CONSTRAINT [FK_EReservationInfo_TBooking] FOREIGN KEY ([Booking]) REFERENCES [dbo].[TBooking] ([TBookingId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
