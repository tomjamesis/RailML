CREATE TABLE [dbo].[TTrainPart]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainPartId]				SMALLINT			NOT NULL,
	[Line]						NVARCHAR(MAX)	NOT NULL,
	[TrainLine]				NVARCHAR(MAX)	NOT NULL,
	[TrainNumber]				NVARCHAR(MAX)	NOT NULL,
	[AdditionalTrainNumber]	NVARCHAR(MAX)	NOT NULL,
	[ProcessStatus]			NVARCHAR(MAX)	NOT NULL,
	[Debitcode]				NVARCHAR(MAX)	NOT NULL,
	[Remarks]					NVARCHAR(MAX)	NOT NULL,
	[TimetablePeriodRef]		NVARCHAR(MAX)	NOT NULL,
	[CategoryRef]				NVARCHAR(MAX)	NOT NULL,
	[Operator]					NVARCHAR(MAX)	NOT NULL,
	[CancellationValue]		BIT				NOT NULL,
	[CancellationValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TTrainPartId] PRIMARY KEY CLUSTERED ([TTrainPartId] ASC)
);
