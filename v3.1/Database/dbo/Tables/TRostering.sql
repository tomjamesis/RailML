CREATE TABLE [dbo].[TRostering]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TRosteringId]				SMALLINT			NOT NULL,
	[VehicleRef]				NVARCHAR(MAX)	NOT NULL,
	[FormationRef]				NVARCHAR(MAX)	NOT NULL,
	[Depot]					NVARCHAR(MAX)	NOT NULL,
	[DefaultPreProcessingTime]	NVARCHAR(MAX)	NOT NULL,
	[DefaultPostProcessingTime]	NVARCHAR(MAX)	NOT NULL,
	[Scope]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TRosteringId] PRIMARY KEY CLUSTERED ([TRosteringId] ASC)
);
