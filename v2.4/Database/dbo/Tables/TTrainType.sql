CREATE TABLE [dbo].[TTrainType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainTypeId]	TINYINT		NOT NULL,
	[Value]		NVARCHAR(11)	NOT NULL,

	CONSTRAINT [PK_TTrainTypeId] PRIMARY KEY CLUSTERED ([TTrainTypeId] ASC)
);
