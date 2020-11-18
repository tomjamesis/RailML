CREATE TABLE [dbo].[TCrossing]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TCrossingId]	SMALLINT			NOT NULL,
	[Type]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TCrossingId] PRIMARY KEY CLUSTERED ([TCrossingId] ASC)
);
