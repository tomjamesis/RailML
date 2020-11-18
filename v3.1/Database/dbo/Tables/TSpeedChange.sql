CREATE TABLE [dbo].[TSpeedChange]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSpeedChangeId]			SMALLINT			NOT NULL,
	[TrainCategory]			NVARCHAR(MAX)	NOT NULL,
	[EtcsTrainCategory]		NVARCHAR(MAX)	NOT NULL,
	[ProfileRef]				NVARCHAR(MAX)	NOT NULL,
	[Status]					NVARCHAR(MAX)	NOT NULL,
	[VMax]						NVARCHAR(MAX)	NOT NULL,
	[TrainRelation]			NVARCHAR(MAX)	NOT NULL,
	[MandatoryStopValue]		BIT				NOT NULL,
	[MandatoryStopValueSpecified]	BIT				NOT NULL,
	[SignalisedValue]			BIT				NOT NULL,
	[SignalisedValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TSpeedChangeId] PRIMARY KEY CLUSTERED ([TSpeedChangeId] ASC)
);
