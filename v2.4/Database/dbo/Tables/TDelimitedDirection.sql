CREATE TABLE [dbo].[TDelimitedDirection]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TDelimitedDirectionId]	TINYINT		NOT NULL,
	[Value]				NVARCHAR(7)	NOT NULL,

	CONSTRAINT [PK_TDelimitedDirectionId] PRIMARY KEY CLUSTERED ([TDelimitedDirectionId] ASC)
);
