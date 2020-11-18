CREATE TABLE [dbo].[TPlacedElement]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TPlacedElementId]	SMALLINT		NOT NULL,
	[States]			BIGINT		NOT NULL,

	CONSTRAINT [PK_TPlacedElementId] PRIMARY KEY CLUSTERED ([TPlacedElementId] ASC),
	CONSTRAINT [FK_TPlacedElement_TStates] FOREIGN KEY ([States]) REFERENCES [dbo].[TStates] ([TStatesId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
