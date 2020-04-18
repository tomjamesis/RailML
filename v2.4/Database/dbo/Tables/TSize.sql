CREATE TABLE [dbo].[TSize]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSizeId]	BIGINT		NOT NULL,
	[Width]BIGINT		NOT NULL,
	[Height]BIGINT		NOT NULL,

	CONSTRAINT [PK_TSizeId] PRIMARY KEY CLUSTERED ([TSizeId] ASC)
);
