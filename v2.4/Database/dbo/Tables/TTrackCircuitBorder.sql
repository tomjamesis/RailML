CREATE TABLE [dbo].[TTrackCircuitBorder]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrackCircuitBorderId]	SMALLINT			NOT NULL,
	[InsulatedRailValue]		TINYINT			NOT NULL,
	[InsulatedRailValueSpecified]	BIT				NOT NULL,
	[OcpStationRef]			NVARCHAR(MAX)	NOT NULL,
	[ControllerRef]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TTrackCircuitBorderId] PRIMARY KEY CLUSTERED ([TTrackCircuitBorderId] ASC),
	CONSTRAINT [FK_TTrackCircuitBorder_TInsulatedRailSide] FOREIGN KEY ([InsulatedRailValue]) REFERENCES [dbo].[TInsulatedRailSide] ([TInsulatedRailSideId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
