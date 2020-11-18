CREATE TABLE [dbo].[TMaxTrainCurrentValidFor]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TMaxTrainCurrentValidForId]	TINYINT		NOT NULL,
	[Value]					NVARCHAR(10)	NOT NULL,

	CONSTRAINT [PK_TMaxTrainCurrentValidForId] PRIMARY KEY CLUSTERED ([TMaxTrainCurrentValidForId] ASC)
);
