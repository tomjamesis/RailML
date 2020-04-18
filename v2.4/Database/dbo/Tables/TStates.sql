CREATE TABLE [dbo].[TStates]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStatesId]	BIGINT		NOT NULL,
	[State]	BIGINT		NOT NULL,

	CONSTRAINT [PK_TStatesId] PRIMARY KEY CLUSTERED ([TStatesId] ASC),
	CONSTRAINT [FK_TStates_TState] FOREIGN KEY ([State]) REFERENCES [dbo].[TState] ([TStateId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
