CREATE TABLE [dbo].[TLaxDirection]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TLaxDirectionId]	TINYINT		NOT NULL,
	[Value]		NVARCHAR(7)	NOT NULL,

	CONSTRAINT [PK_TLaxDirectionId] PRIMARY KEY CLUSTERED ([TLaxDirectionId] ASC)
);
