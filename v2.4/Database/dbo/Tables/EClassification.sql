CREATE TABLE [dbo].[EClassification]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EClassificationId]	BIGINT		NOT NULL,
	[Manufacturer]		BIGINT		NOT NULL,
	[Operator]			SMALLINT		NOT NULL,

	CONSTRAINT [PK_EClassificationId] PRIMARY KEY CLUSTERED ([EClassificationId] ASC),
	CONSTRAINT [FK_EClassification_EOperator] FOREIGN KEY ([Operator]) REFERENCES [dbo].[EOperator] ([EOperatorId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EClassification_TManufacturer] FOREIGN KEY ([Manufacturer]) REFERENCES [dbo].[TManufacturer] ([TManufacturerId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
