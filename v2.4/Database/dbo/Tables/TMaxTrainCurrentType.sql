CREATE TABLE [dbo].[TMaxTrainCurrentType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TMaxTrainCurrentTypeId]	TINYINT		NOT NULL,
	[Value]				NVARCHAR(10)	NOT NULL,

	CONSTRAINT [PK_TMaxTrainCurrentTypeId] PRIMARY KEY CLUSTERED ([TMaxTrainCurrentTypeId] ASC)
);
