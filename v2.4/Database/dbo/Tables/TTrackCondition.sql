CREATE TABLE [dbo].[TTrackCondition]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrackConditionId]	SMALLINT			NOT NULL,
	[LengthValue]			DECIMAL(18, 6)	NOT NULL,
	[LengthValueSpecified]	BIT				NOT NULL,
	[Type]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TTrackConditionId] PRIMARY KEY CLUSTERED ([TTrackConditionId] ASC)
);
