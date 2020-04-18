CREATE TABLE [dbo].[TPlacedElementWithLength]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TPlacedElementWithLengthId]	SMALLINT		NOT NULL,
	[States]					BIGINT		NOT NULL,
	[LengthValue]				DECIMAL(18, 6)	NOT NULL,
	[LengthValueSpecified]		BIT			NOT NULL,

	CONSTRAINT [PK_TPlacedElementWithLengthId] PRIMARY KEY CLUSTERED ([TPlacedElementWithLengthId] ASC),
	CONSTRAINT [FK_TPlacedElementWithLength_TStatesWithLength] FOREIGN KEY ([States]) REFERENCES [dbo].[TStatesWithLength] ([TStatesWithLengthId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
