CREATE TABLE [dbo].[TSide]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSideId]	TINYINT		NOT NULL,
	[Value]NVARCHAR(5)	NOT NULL,

	CONSTRAINT [PK_TSideId] PRIMARY KEY CLUSTERED ([TSideId] ASC)
);
