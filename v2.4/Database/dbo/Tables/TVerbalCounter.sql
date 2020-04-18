CREATE TABLE [dbo].[TVerbalCounter]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TVerbalCounterId]	TINYINT		NOT NULL,
	[Value]			NVARCHAR(6)	NOT NULL,

	CONSTRAINT [PK_TVerbalCounterId] PRIMARY KEY CLUSTERED ([TVerbalCounterId] ASC)
);
