CREATE TABLE [dbo].[TStatesWithLength]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStatesWithLengthId]	BIGINT		NOT NULL,
	[State]			SMALLINT		NOT NULL,

	CONSTRAINT [PK_TStatesWithLengthId] PRIMARY KEY CLUSTERED ([TStatesWithLengthId] ASC),
	CONSTRAINT [FK_TStatesWithLength_TStateWithLength] FOREIGN KEY ([State]) REFERENCES [dbo].[TStateWithLength] ([TStateWithLengthId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
