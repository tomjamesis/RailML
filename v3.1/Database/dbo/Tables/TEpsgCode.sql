CREATE TABLE [dbo].[TEpsgCode]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TEpsgCodeId]	BIGINT			NOT NULL,
	[Default]	NVARCHAR(MAX)	NOT NULL,
	[ExtraHeight]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TEpsgCodeId] PRIMARY KEY CLUSTERED ([TEpsgCodeId] ASC)
);
