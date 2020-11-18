CREATE TABLE [dbo].[TLoadSwitch]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TLoadSwitchId]	TINYINT		NOT NULL,
	[Value]		NVARCHAR(5)	NOT NULL,

	CONSTRAINT [PK_TLoadSwitchId] PRIMARY KEY CLUSTERED ([TLoadSwitchId] ASC)
);
