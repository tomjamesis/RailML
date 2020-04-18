CREATE TABLE [dbo].[TLocallyControlledArea]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TLocallyControlledAreaId]	SMALLINT			NOT NULL,
	[States]					BIGINT			NOT NULL,
	[OcpRef]					NVARCHAR(MAX)	NOT NULL,
	[OcpStationRef]			NVARCHAR(MAX)	NOT NULL,
	[ControllerRef]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TLocallyControlledAreaId] PRIMARY KEY CLUSTERED ([TLocallyControlledAreaId] ASC),
	CONSTRAINT [FK_TLocallyControlledArea_TStates] FOREIGN KEY ([States]) REFERENCES [dbo].[TStates] ([TStatesId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
