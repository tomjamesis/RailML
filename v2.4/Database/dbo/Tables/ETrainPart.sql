CREATE TABLE [dbo].[ETrainPart]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrainPartId]				SMALLINT			NOT NULL,
	[FormationTT]				SMALLINT			NOT NULL,
	[OperatingPeriodRef]		SMALLINT			NOT NULL,
	[OcpsTT]					BIGINT			NOT NULL,
	[OrganizationalUnitBinding]	BIGINT			NOT NULL,
	[AnnotationRef]			SMALLINT			NOT NULL,
	[Any]						VARCHAR(MAX)		NOT NULL,

	CONSTRAINT [PK_ETrainPartId] PRIMARY KEY CLUSTERED ([ETrainPartId] ASC),
	CONSTRAINT [FK_ETrainPart_TAnnotationRef] FOREIGN KEY ([AnnotationRef]) REFERENCES [dbo].[TAnnotationRef] ([TAnnotationRefId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrainPart_EFormationTT] FOREIGN KEY ([FormationTT]) REFERENCES [dbo].[EFormationTT] ([EFormationTTId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrainPart_EOperatingPeriodRef] FOREIGN KEY ([OperatingPeriodRef]) REFERENCES [dbo].[EOperatingPeriodRef] ([EOperatingPeriodRefId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrainPart_EOcpsTT] FOREIGN KEY ([OcpsTT]) REFERENCES [dbo].[EOcpsTT] ([EOcpsTTId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrainPart_EOrganizationalUnitBinding] FOREIGN KEY ([OrganizationalUnitBinding]) REFERENCES [dbo].[EOrganizationalUnitBinding] ([EOrganizationalUnitBindingId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
