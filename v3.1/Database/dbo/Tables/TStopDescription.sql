CREATE TABLE [dbo].[TStopDescription]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStopDescriptionId]					BIGINT			NOT NULL,
	[Any]									VARCHAR(MAX)		NOT NULL,
	[CommercialValue]						BIT				NOT NULL,
	[CommercialValueSpecified]				BIT				NOT NULL,
	[StopOnRequestValue]					BIT				NOT NULL,
	[StopOnRequestValueSpecified]			BIT				NOT NULL,
	[OnOffValue]							TINYINT			NOT NULL,
	[OnOffValueSpecified]					BIT				NOT NULL,
	[Purpose]								NVARCHAR(MAX)	NOT NULL,
	[GuaranteedPassValue]					BIT				NOT NULL,
	[GuaranteedPassValueSpecified]			BIT				NOT NULL,
	[OperationalStopOrderedValue]			BIT				NOT NULL,
	[OperationalStopOrderedValueSpecified]	BIT				NOT NULL,
	[OperatingPeriodRef]					NVARCHAR(MAX)	NOT NULL,
	[StopPostRef]							NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TStopDescriptionId] PRIMARY KEY CLUSTERED ([TStopDescriptionId] ASC),
	CONSTRAINT [FK_TStopDescription_TOnOff] FOREIGN KEY ([OnOffValue]) REFERENCES [dbo].[TOnOff] ([TOnOffId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
