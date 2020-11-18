CREATE TABLE [dbo].[TTrainScope]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainScopeId]	TINYINT		NOT NULL,
	[Value]		NVARCHAR(14)	NOT NULL,

	CONSTRAINT [PK_TTrainScopeId] PRIMARY KEY CLUSTERED ([TTrainScopeId] ASC)
);
