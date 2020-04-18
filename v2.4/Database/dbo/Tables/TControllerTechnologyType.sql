CREATE TABLE [dbo].[TControllerTechnologyType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TControllerTechnologyTypeId]	TINYINT		NOT NULL,
	[Value]					NVARCHAR(18)	NOT NULL,

	CONSTRAINT [PK_TControllerTechnologyTypeId] PRIMARY KEY CLUSTERED ([TControllerTechnologyTypeId] ASC)
);
