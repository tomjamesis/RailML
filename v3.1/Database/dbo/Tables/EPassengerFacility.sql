CREATE TABLE [dbo].[EPassengerFacility]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EPassengerFacilityId]	BIGINT		NOT NULL,
	[Places]				BIGINT		NOT NULL,
	[Service]				BIGINT		NOT NULL,

	CONSTRAINT [PK_EPassengerFacilityId] PRIMARY KEY CLUSTERED ([EPassengerFacilityId] ASC),
	CONSTRAINT [FK_EPassengerFacility_TPlaces] FOREIGN KEY ([Places]) REFERENCES [dbo].[TPlaces] ([TPlacesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EPassengerFacility_TService] FOREIGN KEY ([Service]) REFERENCES [dbo].[TService] ([TServiceId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
