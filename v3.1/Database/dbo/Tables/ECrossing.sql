CREATE TABLE [dbo].[ECrossing]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ECrossingId]	SMALLINT		NOT NULL,
	[Connection]SMALLINT		NOT NULL,

	CONSTRAINT [PK_ECrossingId] PRIMARY KEY CLUSTERED ([ECrossingId] ASC),
	CONSTRAINT [FK_ECrossing_TSwitchConnectionData] FOREIGN KEY ([Connection]) REFERENCES [dbo].[TSwitchConnectionData] ([TSwitchConnectionDataId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
