CREATE TABLE [dbo].[TSignalMilepost]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSignalMilepostId]		SMALLINT			NOT NULL,
	[ShownValueValue]			DECIMAL(18, 6)	NOT NULL,
	[ShownValueValueSpecified]	BIT				NOT NULL,
	[ShownRemark]				NVARCHAR(MAX)	NOT NULL,
	[MileageChangeRef]			NVARCHAR(MAX)	NOT NULL,
	[LineRef]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TSignalMilepostId] PRIMARY KEY CLUSTERED ([TSignalMilepostId] ASC)
);
