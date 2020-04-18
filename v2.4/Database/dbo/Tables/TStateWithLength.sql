CREATE TABLE [dbo].[TStateWithLength]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStateWithLengthId]	SMALLINT		NOT NULL,
	[From]				BIGINT		NOT NULL,
	[To]				BIGINT		NOT NULL,

	CONSTRAINT [PK_TStateWithLengthId] PRIMARY KEY CLUSTERED ([TStateWithLengthId] ASC),
	CONSTRAINT [FK_TStateWithLength_TLocation] FOREIGN KEY ([From]) REFERENCES [dbo].[TLocation] ([TLocationId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
