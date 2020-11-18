CREATE TABLE [dbo].[TStrictDirection]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStrictDirectionId]	TINYINT		NOT NULL,
	[Value]			NVARCHAR(4)	NOT NULL,

	CONSTRAINT [PK_TStrictDirectionId] PRIMARY KEY CLUSTERED ([TStrictDirectionId] ASC)
);
