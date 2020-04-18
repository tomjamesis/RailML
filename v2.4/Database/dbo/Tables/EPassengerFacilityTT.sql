CREATE TABLE [dbo].[EPassengerFacilityTT]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EPassengerFacilityTTId]	BIGINT			NOT NULL,
	[Any]					VARCHAR(MAX)		NOT NULL,
	[Places]				BIGINT			NOT NULL,
	[Service]				BIGINT			NOT NULL,

	CONSTRAINT [PK_EPassengerFacilityTTId] PRIMARY KEY CLUSTERED ([EPassengerFacilityTTId] ASC),
	CONSTRAINT [FK_EPassengerFacilityTT_TPlacesTT] FOREIGN KEY ([Places]) REFERENCES [dbo].[TPlacesTT] ([TPlacesTTId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EPassengerFacilityTT_TService] FOREIGN KEY ([Service]) REFERENCES [dbo].[TService] ([TServiceId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
