CREATE TABLE [dbo].[EConnectionsTT]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EConnectionsTTId]	BIGINT		NOT NULL,
	[Connection]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_EConnectionsTTId] PRIMARY KEY CLUSTERED ([EConnectionsTTId] ASC),
	CONSTRAINT [FK_EConnectionsTT_EConnectionTT] FOREIGN KEY ([Connection]) REFERENCES [dbo].[EConnectionTT] ([EConnectionTTId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
