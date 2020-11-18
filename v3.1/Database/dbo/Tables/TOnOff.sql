CREATE TABLE [dbo].[TOnOff]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOnOffId]	TINYINT		NOT NULL,
	[Value]	NVARCHAR(4)	NOT NULL,

	CONSTRAINT [PK_TOnOffId] PRIMARY KEY CLUSTERED ([TOnOffId] ASC)
);
