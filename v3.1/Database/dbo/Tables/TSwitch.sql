CREATE TABLE [dbo].[TSwitch]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSwitchId]	SMALLINT			NOT NULL,
	[Type]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TSwitchId] PRIMARY KEY CLUSTERED ([TSwitchId] ASC)
);
