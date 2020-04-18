CREATE TABLE [dbo].[TDerailer]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TDerailerId]				SMALLINT			NOT NULL,
	[DerailSideValue]			TINYINT			NOT NULL,
	[DerailSideValueSpecified]	BIT				NOT NULL,
	[KindValue]				TINYINT			NOT NULL,
	[KindValueSpecified]		BIT				NOT NULL,
	[Model]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TDerailerId] PRIMARY KEY CLUSTERED ([TDerailerId] ASC),
	CONSTRAINT [FK_TDerailer_TSide] FOREIGN KEY ([DerailSideValue]) REFERENCES [dbo].[TSide] ([TSideId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TDerailer_TDerailKind] FOREIGN KEY ([KindValue]) REFERENCES [dbo].[TDerailKind] ([TDerailKindId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
