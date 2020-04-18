CREATE TABLE [dbo].[TVehicleIdentification]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TVehicleIdentificationId]	BIGINT			NOT NULL,
	[UicIdentNumber]			NVARCHAR(MAX)	NOT NULL,
	[CountryCode]				NVARCHAR(MAX)	NOT NULL,
	[VehicleKeeperMarking]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TVehicleIdentificationId] PRIMARY KEY CLUSTERED ([TVehicleIdentificationId] ASC)
);
