CREATE TABLE [dbo].[ESwitch]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ESwitchId]SMALLINT		NOT NULL,
	[Connection]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ESwitchId] PRIMARY KEY CLUSTERED ([ESwitchId] ASC),
	CONSTRAINT [FK_ESwitch_TSwitchConnectionData] FOREIGN KEY ([Connection]) REFERENCES [dbo].[TSwitchConnectionData] ([TSwitchConnectionDataId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
