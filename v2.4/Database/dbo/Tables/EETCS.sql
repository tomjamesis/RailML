CREATE TABLE [dbo].[EETCS]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EETCSId]					SMALLINT		NOT NULL,
	[SpecificTransmissionModule]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EETCSId] PRIMARY KEY CLUSTERED ([EETCSId] ASC),
	CONSTRAINT [FK_EETCS_TSpecificTransmissionModule] FOREIGN KEY ([SpecificTransmissionModule]) REFERENCES [dbo].[TSpecificTransmissionModule] ([TSpecificTransmissionModuleId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
