CREATE TABLE [dbo].[TSpecificTransmissionModule]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSpecificTransmissionModuleId]	SMALLINT			NOT NULL,
	[OnBoardUnitID]				NVARCHAR(MAX)	NOT NULL,
	[SoftwareVersion]				NVARCHAR(MAX)	NOT NULL,
	[NationalSystemRef]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TSpecificTransmissionModuleId] PRIMARY KEY CLUSTERED ([TSpecificTransmissionModuleId] ASC)
);
