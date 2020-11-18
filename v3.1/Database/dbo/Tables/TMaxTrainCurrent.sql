CREATE TABLE [dbo].[TMaxTrainCurrent]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TMaxTrainCurrentId]		BIGINT		NOT NULL,
	[MaxCurrentValue]			DECIMAL(18, 6)	NOT NULL,
	[MaxCurrentValueSpecified]	BIT			NOT NULL,
	[TypeValue]				TINYINT		NOT NULL,
	[TypeValueSpecified]		BIT			NOT NULL,
	[ValidForValue]			TINYINT		NOT NULL,
	[ValidForValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TMaxTrainCurrentId] PRIMARY KEY CLUSTERED ([TMaxTrainCurrentId] ASC),
	CONSTRAINT [FK_TMaxTrainCurrent_TMaxTrainCurrentType] FOREIGN KEY ([TypeValue]) REFERENCES [dbo].[TMaxTrainCurrentType] ([TMaxTrainCurrentTypeId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TMaxTrainCurrent_TMaxTrainCurrentValidFor] FOREIGN KEY ([ValidForValue]) REFERENCES [dbo].[TMaxTrainCurrentValidFor] ([TMaxTrainCurrentValidForId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
