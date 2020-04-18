CREATE TABLE [dbo].[TExtendedDirection]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TExtendedDirectionId]	TINYINT		NOT NULL,
	[Value]				NVARCHAR(7)	NOT NULL,

	CONSTRAINT [PK_TExtendedDirectionId] PRIMARY KEY CLUSTERED ([TExtendedDirectionId] ASC)
);
