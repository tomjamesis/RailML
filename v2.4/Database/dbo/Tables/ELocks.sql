CREATE TABLE [dbo].[ELocks]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ELocksId]	BIGINT		NOT NULL,
	[Lock]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_ELocksId] PRIMARY KEY CLUSTERED ([ELocksId] ASC),
	CONSTRAINT [FK_ELocks_TLock] FOREIGN KEY ([Lock]) REFERENCES [dbo].[TLock] ([TLockId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
