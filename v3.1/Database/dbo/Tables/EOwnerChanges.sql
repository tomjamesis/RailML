CREATE TABLE [dbo].[EOwnerChanges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOwnerChangesId]	BIGINT		NOT NULL,
	[OwnerChange]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EOwnerChangesId] PRIMARY KEY CLUSTERED ([EOwnerChangesId] ASC),
	CONSTRAINT [FK_EOwnerChanges_TOwnerChange] FOREIGN KEY ([OwnerChange]) REFERENCES [dbo].[TOwnerChange] ([TOwnerChangeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
